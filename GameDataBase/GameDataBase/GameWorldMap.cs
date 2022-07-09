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
using System.Data.SqlClient;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
namespace GameDataBase
{
    public partial class GameWorldMap : Form
    {
        private int GameMapWidth = 24;
        private int GameMapHeight = 24;
        private int characterCoordinateX = 12;
        private int characterCoordinateY = 12;
        //private int pc_name = 0;
        private int inventory = 0;

        private int userId = 0;
        private Bitmap textureWithFish;
        private Bitmap textureOnGrass;
        public int getCharacterCoordinateX()
        {
            return characterCoordinateX;
        }
        public int getCharacterCoordinateY()
        {
            return characterCoordinateY;
        }
        private int[,] TestGameMap = new int[25, 25]{
           {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//1
           {0,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,0},//2
           {0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0},//3
           {0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0},//4
           {0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0},//5
           {0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0},//6
           {0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0},//7
           {0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0},//8
           {0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0},//8
           {0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0},//10
           {0,2,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,2,0},//11
           {2,2,2,2,2,2,0,0,2,0,0,2,3,2,2,0,0,0,0,0,0,0,0,2,0},//12
           {2,2,2,2,0,0,0,0,0,0,1,1,0,1,1,0,0,0,0,0,0,0,0,2,0},//13
           {0,2,0,2,0,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,0,0,0,2,0},//14
           {0,2,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0},//15
           {0,2,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0},//16
           {0,2,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0},//17
           {0,2,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0},//18
           {0,2,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0},//19
           {0,2,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0},//20
           {0,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0},//21
           {0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0},//22
           {0,0,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0},//23
           {0,0,0,0,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,0,0},//24
           {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0} //25
        };
        public const int ScreenWide = 4;
        private int[,] GameMap = new int[5, 5];
        
        public GameWorldMap()
        {
            InitializeComponent();
        }
        private void LoadGameMap(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; Database = RPGdatabase; User ID = postgres; Password = n2k; ");
            conn.Open();
            //Game Map Loading 
            var commandMap = new NpgsqlCommand("SELECT x FROM game_map", conn);
            // PC Name
            
            var command = new NpgsqlCommand("SELECT e_id FROM PC where uname = '" + Form_menu.uname + "'", conn);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                userId = reader.GetInt32(0);

            }
            string charType = userId.ToString();

            switch (userId)
            {
                case 0:
                    charType = "Beige Cat";
                    textureOnGrass = Properties.Resources.BeigeOnGrass;
                    textureWithFish = Properties.Resources.BeigeOnGrassWithFish;
                    break;
                case 1:
                    charType = "Black Cat";
                    textureOnGrass = Properties.Resources.BlackOnGrass;
                    textureWithFish = Properties.Resources.BlackOnGrassWithFish;
                    break;
                case 2:
                    charType = "Gray Cat";
                    textureOnGrass = Properties.Resources.GreyOnGrass;
                    textureWithFish = Properties.Resources.GreyOnGrassWithFish;
                    break;
                case 3:
                    charType = "Orange Cat";
                    textureOnGrass = Properties.Resources.OrangeOnGrass;
                    textureWithFish = Properties.Resources.OrangeOnGrassWithFish;
                    break;
                case 4:
                    charType = "White Cat";
                    textureOnGrass = Properties.Resources.WhiteOnGrass;
                    textureWithFish = Properties.Resources.WhiteOnGrassWithFish;
                    break;
                default:
                    break;
            }
            lbl_hero.Text = charType;
            conn.Close();

            // Fish Quantity
            NpgsqlConnection con = new NpgsqlConnection("Server = localhost; Port = 5432; Database = RPGdatabase; User ID = postgres; Password = n2k; ");
            con.Open();
            var items = new NpgsqlCommand("SELECT s1,s2,s3,s4,s5 FROM Inventory where uname = '" + Form_menu.uname + "'", con);
            NpgsqlDataReader readerer = items.ExecuteReader();
            int counter = 0;
            while (readerer.Read())
            {
                while (!readerer.IsDBNull(0) && counter != 5)
                {
                    if (readerer[counter].ToString() == "5")
                        inventory++;
                    counter++;
                }
            }
            con.Close();
            Lbl_fishQ.Text = inventory.ToString(); // Upd fish quantity
        }
        // TODO: Check number of fishes in the player's inventory!
        private void GameWorldMap_Load(object sender, EventArgs e)
        {
            // Uname
            lbl_login.Text = Form_menu.uname;
            LoadGameMap(sender, e);
            // Map
            updateScreen(GameMap, sender, e);


        }
        private bool isAllowed(int x, int y)
        {
            if (GameMap[x, y] != 2 && GameMap[x, y] != 3)
                return true; 
            else
                return false;
            
        }
        private void updateScreen(int[,] GameMap, object sender, EventArgs e)
        {
            for (int i = 0; i <= ScreenWide; i++)
            {
                for (int j = 0; j <= ScreenWide; j++)
                {
                    //generate map relatevely to position of a character
                    GameMap[i, j] = TestGameMap[characterCoordinateX - 2 + i, characterCoordinateY - 2 + j];
                }
            }
            screenDraw(GameMap, sender, e);
        }

        private void screenDraw(int[,] GameMap,object sender, EventArgs e)
        {

            Img_screen1.Image = isGrassThere(GameMap, 0, 0, sender, e);
            Img_screen2.Image = isGrassThere(GameMap, 0, 1, sender, e);
            Img_screen3.Image = isGrassThere(GameMap, 0, 2, sender, e);
            Img_screen4.Image = isGrassThere(GameMap, 0, 3, sender, e);
            Img_screen5.Image = isGrassThere(GameMap, 0, 4, sender, e);
            Img_screen6.Image = isGrassThere(GameMap, 1, 0, sender, e);
            Img_screen7.Image = isGrassThere(GameMap, 1, 1, sender, e);
            Img_screen8.Image = isGrassThere(GameMap, 1, 2, sender, e);
            Img_screen9.Image = isGrassThere(GameMap, 1, 3, sender, e);
            Img_screen10.Image = isGrassThere(GameMap, 1, 4, sender, e);
            Img_screen11.Image = isGrassThere(GameMap, 2, 0, sender, e);
            Img_screen12.Image = isGrassThere(GameMap, 2, 1, sender, e);
            if(GameMap[2,2]==1)
                Img_screen13.Image = textureWithFish;
            else
                Img_screen13.Image = textureOnGrass;
            Img_screen14.Image = isGrassThere(GameMap, 2, 3, sender, e);
            Img_screen15.Image = isGrassThere(GameMap, 2, 4, sender, e);
            Img_screen16.Image = isGrassThere(GameMap, 3, 0, sender, e);
            Img_screen17.Image = isGrassThere(GameMap, 3, 1, sender, e);
            Img_screen18.Image = isGrassThere(GameMap, 3, 2, sender, e);
            Img_screen19.Image = isGrassThere(GameMap, 3, 3, sender, e); 
            Img_screen20.Image = isGrassThere(GameMap, 3, 4, sender, e);
            Img_screen21.Image = isGrassThere(GameMap, 4, 0, sender, e);
            Img_screen22.Image = isGrassThere(GameMap, 4, 1, sender, e);
            Img_screen23.Image = isGrassThere(GameMap, 4, 2, sender, e);
            Img_screen24.Image = isGrassThere(GameMap, 4, 3, sender, e);
            Img_screen25.Image = isGrassThere(GameMap, 4, 4, sender, e);


        }

        private Bitmap isGrassThere(int[,] GameMap,int x,int y, object sender, EventArgs e)
        {
            if (GameMap[x, y] == 0)
                return Properties.Resources.Grass;
            else if (GameMap[x, y] == 2)
                return Properties.Resources.Water;
            else if (GameMap[x, y] == 3)
                return Properties.Resources.SalesmanOnGrass;
            else
                return Properties.Resources.GrassWithFish;
        }

        private void button1_Click(object sender, EventArgs e) //goUp
        {
            if(isAllowed(1 ,2)) {
                characterCoordinateX--;
                updateScreen(GameMap, sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)//goDown
        {

            if (isAllowed(3, 2))
            {
                characterCoordinateX++;
                updateScreen(GameMap, sender, e);
            }
        }

        private void Btn_goLeft_Click(object sender, EventArgs e)
        {
            if (isAllowed(2, 1))
            {
                characterCoordinateY--;
                updateScreen(GameMap, sender, e);
            }
            
            
        }

        private void Btn_goRight_Click(object sender, EventArgs e)
        {
            if (isAllowed(2, 3))
            {
                characterCoordinateY++;
                updateScreen(GameMap, sender, e);
            }
        }

        // Inventory SQL -> Update Inventory & Map
        // TODO: Implement a warning when you try to pick up 6th item!          p.s. limit = 5
        private void Btn_pickUp_Click(object sender, EventArgs e)
        {
            if(TestGameMap[getCharacterCoordinateX(), getCharacterCoordinateY()] == 1 && inventory<5)
            {
                TestGameMap[getCharacterCoordinateX(), getCharacterCoordinateY()] = 0;
                updateScreen(GameMap, sender, e);
                inventory++;
                Lbl_fishQ.Text = inventory.ToString();
            }

        }

        private void savePlusQuit(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; Database = RPGdatabase; User ID = postgres; Password = n2k; ");
            conn.Open();
            int i;
            int j;
            var commandMap = new NpgsqlDataAdapter("SELECT * FROM game_map", conn);
            commandMap.InsertCommand = new NpgsqlCommand("INSERT INTO game_map(x,y,what) VALUES (:u,:p,:q);",conn);
            for (i = 0; i < GameMapHeight; i++)
            {
                for (j = 0; j < GameMapWidth; j++)
                {
                    commandMap.InsertCommand =  new NpgsqlCommand("INSERT INTO game_map(x,y,what) VALUES(:u,:p,:q)", conn);
                    commandMap.InsertCommand.Parameters.Add(new NpgsqlParameter("u", DbType.Int16));
                    commandMap.InsertCommand.Parameters.Add(new NpgsqlParameter("p", DbType.Int16));
                    commandMap.InsertCommand.Parameters.Add(new NpgsqlParameter("q", DbType.Int16));
                    commandMap.InsertCommand.Parameters[0].Direction = ParameterDirection.Input;
                    commandMap.InsertCommand.Parameters[1].Direction = ParameterDirection.Input;
                    commandMap.InsertCommand.Parameters[2].Direction = ParameterDirection.Input;
                    commandMap.InsertCommand.Parameters[0].SourceColumn = "u";
                    commandMap.InsertCommand.Parameters[1].SourceColumn = "p";
                    commandMap.InsertCommand.Parameters[2].SourceColumn = "q";
                    commandMap.InsertCommand.Parameters[0].Value = j;
                    commandMap.InsertCommand.Parameters[1].Value = i;
                    commandMap.InsertCommand.Parameters[2].Value = TestGameMap[i,j];

                    // Execute Query -> Insert
                    commandMap.InsertCommand.ExecuteNonQuery();
                }
            }

        
            // Clean inventory in DB
       
            j = 1;
            for (i = 0; i < 5; i++)
            {
                
                var command = new NpgsqlDataAdapter("SELECT * FROM INVENTORY", conn);
                command.UpdateCommand = new NpgsqlCommand("UPDATE Inventory SET s" + j + " = :i where uname = :u", conn);
                command.UpdateCommand.Parameters.Add(new NpgsqlParameter("i", DbType.Int16));
                command.UpdateCommand.Parameters.Add(new NpgsqlParameter("u", DbType.String));

                command.UpdateCommand.Parameters[0].SourceColumn = "s" + j + "";
                command.UpdateCommand.Parameters[1].SourceColumn = "uname";

                command.UpdateCommand.Parameters[0].Value = DBNull.Value;
                command.UpdateCommand.Parameters[1].Value = Form_menu.uname;
                command.UpdateCommand.ExecuteNonQuery();
                 j++;
            }

            // Only insert 5 elements max in the inventory. Alex: remove temp check т.к. не может чел больше 5 поднять предметов
            j = 1;
            for (i = 0; i < inventory; i++)
            {
               
                var command = new NpgsqlDataAdapter("SELECT * FROM INVENTORY", conn);
                command.UpdateCommand = new NpgsqlCommand("UPDATE Inventory SET s" + j + " = :i where uname = :u", conn);
                command.UpdateCommand.Parameters.Add(new NpgsqlParameter("i", DbType.Int16));
                command.UpdateCommand.Parameters.Add(new NpgsqlParameter("u", DbType.String));

                command.UpdateCommand.Parameters[0].SourceColumn = "s" + j + "";
                command.UpdateCommand.Parameters[1].SourceColumn = "uname";

                command.UpdateCommand.Parameters[0].Value = 5;
                command.UpdateCommand.Parameters[1].Value = Form_menu.uname;
                command.UpdateCommand.ExecuteNonQuery();
                 j++;
            }
            inventory = 0;
            this.Hide();
            conn.Close();
        }

        // Inventory - commit to DB
        private void Btn_saveAndQuit_Click(object sender, EventArgs e)
        {
            savePlusQuit(sender, e);
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_hero_Click(object sender, EventArgs e)
        {

        }
    }
}
