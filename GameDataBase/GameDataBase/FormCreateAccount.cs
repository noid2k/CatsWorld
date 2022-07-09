using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
namespace GameDataBase
{
    public partial class FormCreateAccount : Form
    {
        private int selectedOption = 0;
        public FormCreateAccount()
        {
            InitializeComponent();
        }

        private void FormCreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_accPsw_Click(object sender, EventArgs e)
        {

        }

        private void Btn_charSelectNext_Click(object sender, EventArgs e)
        {
            selectedOption--;
            if (selectedOption < 0)
            {
                selectedOption = 4;
            }
            switch (selectedOption)
            {
                case 0:
                    Box_charDisplay.Image = Properties.Resources.HeadBeige;
                    break;
                case 1:
                    Box_charDisplay.Image = Properties.Resources.HeadBlack;
                    break;
                case 2:
                    Box_charDisplay.Image = Properties.Resources.HeadGrey;
                    break;
                case 3:
                    Box_charDisplay.Image = Properties.Resources.HeadOrange;
                    break;
                case 4:
                    Box_charDisplay.Image = Properties.Resources.HeadWhite;
                    break;
            }
        }

        private void Btn_charSelectPrev_Click(object sender, EventArgs e)
        {
            selectedOption++;
            if (selectedOption >= 5)
            {
                selectedOption = 0;
            }
            switch (selectedOption) { 
                case 0:
                    Box_charDisplay.Image = Properties.Resources.HeadBeige;
                    break;
                case 1:
                    Box_charDisplay.Image = Properties.Resources.HeadBlack;
                    break;
                case 2:
                    Box_charDisplay.Image = Properties.Resources.HeadGrey;
                    break;
                case 3:
                    Box_charDisplay.Image = Properties.Resources.HeadOrange;
                    break;
                case 4:
                    Box_charDisplay.Image = Properties.Resources.HeadWhite;
                    break;
                }
            
        }

        private void Btn_createAcc_MouseHover(object sender, EventArgs e)
        {
            Btn_createAcc.Image = Properties.Resources.Asset_4;
        }
        private void Btn_createAcc_MouseLeave(object sender, EventArgs e)
        {

        }
        // Create Account SQL
        private void Btn_createAcc_Click(object sender, EventArgs e)
        {
            Lbl_Error.Visible = false;
            Btn_createAcc.Image = Properties.Resources.Asset_5;
            // Check if the player provided password and login name: check if account exists -> if not, create one
            if (!String.IsNullOrWhiteSpace(Txt_accName.Text) && !String.IsNullOrWhiteSpace(Txt_accPsw.Text))
            {
                // Initialize Connection to the Server
                NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; Database = RPGdatabase; User ID = postgres; Password = n2k; ");
                conn.Open();

                /* Check if the account name already exists  */
                var check = new NpgsqlDataAdapter("SELECT * FROM accounts where uname = '" + Txt_accName.Text + "'", conn);
                DataTable dt = new DataTable();
                check.Fill(dt);
                // Found login
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("ERROR. This name already exists !");
                    return;
                }

                // Initialize Data Adapter to Perform Insertion of Info in the DB
                /* Create Salt and hash password*/
                var fm = new Form_menu();
                byte[] salt = new byte[128 / 8];
                using (var rngCsp = new RNGCryptoServiceProvider())
                {
                    rngCsp.GetNonZeroBytes(salt);
                }
                string salt_str = Convert.ToBase64String(salt);
                string hashedPassword = fm.hashPass(Txt_accPsw.Text, salt);

                /* Accounts */
                var data = new NpgsqlDataAdapter("SELECT * FROM accounts", conn);

                data.InsertCommand = new NpgsqlCommand("INSERT INTO accounts(uname, pasword, salt) VALUES(:u, :p, :s)", conn);
                data.InsertCommand.Parameters.Add(new NpgsqlParameter("u", DbType.String));
                data.InsertCommand.Parameters.Add(new NpgsqlParameter("p", DbType.String));
                data.InsertCommand.Parameters.Add(new NpgsqlParameter("s", DbType.String));

                data.InsertCommand.Parameters[0].Direction = ParameterDirection.Input;
                data.InsertCommand.Parameters[1].Direction = ParameterDirection.Input;
                data.InsertCommand.Parameters[2].Direction = ParameterDirection.Input;
                data.InsertCommand.Parameters[0].SourceColumn = "uname";
                data.InsertCommand.Parameters[1].SourceColumn = "pasword";
                data.InsertCommand.Parameters[2].SourceColumn = "salt";


                data.InsertCommand.Parameters[0].Value = Txt_accName.Text;
                data.InsertCommand.Parameters[1].Value = hashedPassword;
                data.InsertCommand.Parameters[2].Value = salt_str;


                // Execute Query -> Insert
                data.InsertCommand.ExecuteNonQuery();

                /* PC - Playable Characters */
                var hero = new NpgsqlDataAdapter("SELECT * FROM PC", conn);
                hero.InsertCommand = new NpgsqlCommand("INSERT INTO PC(e_id, uname) VALUES(:e, :u)", conn);
                hero.InsertCommand.Parameters.Add(new NpgsqlParameter("e", DbType.Int16));
                hero.InsertCommand.Parameters.Add(new NpgsqlParameter("u", DbType.String));

                hero.InsertCommand.Parameters[0].SourceColumn = "e_id";
                hero.InsertCommand.Parameters[1].SourceColumn = "uname";

                hero.InsertCommand.Parameters[0].Value = selectedOption;
                hero.InsertCommand.Parameters[1].Value = Txt_accName.Text;

                // Execute Query -> Insert
                hero.InsertCommand.ExecuteNonQuery();
                /* Inventory => Initialize */
                var inv = new NpgsqlDataAdapter("SELECT * FROM Inventory", conn);
                inv.InsertCommand = new NpgsqlCommand("INSERT INTO Inventory(uname,e_id) VALUES(:u, :e)", conn);
                inv.InsertCommand.Parameters.Add(new NpgsqlParameter("u", DbType.String));
                inv.InsertCommand.Parameters.Add(new NpgsqlParameter("e", DbType.Int16));

                inv.InsertCommand.Parameters[0].SourceColumn = "uname";
                inv.InsertCommand.Parameters[1].SourceColumn = "e_id";

                inv.InsertCommand.Parameters[0].Value = Txt_accName.Text;
                inv.InsertCommand.Parameters[1].Value = selectedOption;

                Form_menu.uname = Txt_accName.Text;

                // Execute Query -> Insert
                inv.InsertCommand.ExecuteNonQuery();
                conn.Close();

                // Switch to game map
                Hide();
                GameWorldMap loadedMap = new GameWorldMap();
                loadedMap.ShowDialog();
                loadedMap = null;
                Show();
            }
            else
            {
                Lbl_Error.Visible = true;
                Lbl_Error.Text = "Provide Name and Password";
            }
        }

        private void Txt_accName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Box_charDisplay_Click(object sender, EventArgs e)
        {

        }

        private void Btn_mainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lbl_Error_Click(object sender, EventArgs e)
        {

        }
    }
}
