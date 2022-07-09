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
    public partial class Form_menu : Form
    {

        public string hashPass(string pass, byte[] salt)
        {
            string hashedPass = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: pass,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));

            return hashedPass;
        }
        public static string uname = "";
        public Form_menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_createAcc_Click(object sender, EventArgs e)
        {
            Hide();
            FormCreateAccount newAcc = new FormCreateAccount();
            newAcc.ShowDialog();
            newAcc = null;
            Show();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            Txt_accNameLogin.Visible = true;
            Txt_accPswLogin.Visible = true;
            Lbl_AccName.Visible = true;
            Lbl_AccPsw.Visible = true;
            Btn_continueLogin.Visible = true;
            Btn_login.Hide();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form_menu_Load(object sender, EventArgs e)
        {

        }

        // Login SQL

        private void Btn_continueLogin_Click(object sender, EventArgs e)
        {
            Lbl_Error.Visible = false;
            if (!String.IsNullOrWhiteSpace(Txt_accNameLogin.Text) && !String.IsNullOrWhiteSpace(Txt_accPswLogin.Text))
            {
                // Initialize Connection to the Server
                NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; Database = rpg_data; User ID = postgres; Password = R@hfcekm_202; ");
                conn.Open();

                // Initialize Data Adapter to Perform Insertion of Info in the DB
                var data = new NpgsqlDataAdapter("SELECT * FROM accounts where uname = '" + Txt_accNameLogin.Text + "'", conn);

                DataTable dt = new DataTable();
                data.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    var items = new NpgsqlCommand("SELECT pasword,salt FROM accounts where uname = '" + Txt_accNameLogin.Text + "'", conn);
                    NpgsqlDataReader readerer = items.ExecuteReader();
                    string saltstr = ""; string hashedPass = "";
                    while (readerer.Read())
                    {
                        hashedPass = readerer[0].ToString();
                        saltstr = readerer[1].ToString();
                    }
                    byte[] salt = Convert.FromBase64String(saltstr);
                    string temp = hashPass(Txt_accPswLogin.Text, salt);
                    if (hashedPass == temp)
                    {
                        /* Successful Login */
                        uname = Txt_accNameLogin.Text;
                        this.Hide();
                        GameWorldMap forma = new GameWorldMap();
                        forma.ShowDialog();

                        // Switch to game map
                        Hide();
                        GameWorldMap loadedMap = new GameWorldMap();
                        loadedMap.ShowDialog();
                        loadedMap = null;
                        Show();
                    }
                    // Incorrect Password
                    else
                    {
                        MessageBox.Show("ERROR. Check username/password !");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR. Check username/password !");
                }
                conn.Close();

            }
            else
            {
                Lbl_Error.Visible = true;
                Lbl_Error.Text = "Provide Name and Password";
            }

        }

    }
}
