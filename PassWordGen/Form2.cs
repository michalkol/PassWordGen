using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PassWordGen
{
    public partial class Form2 : Form
    {
        string path = "database.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\database.db";
        string currentPassword = "";

        byte[] key = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        byte[] iv = new byte[] { 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader reader;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Show_data();
        }

        //Show data func
        private void Show_data()
        {
            var con = new SQLiteConnection(cs);
            Encryption encryption = new Encryption();
            con.Open();

            string stm = "SELECT * from admin";
            var cmd = new SQLiteCommand(stm, con);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                currentPassword = encryption.Decrypt((byte[])reader.GetValue(1), key, iv);
                ActualPassTb.Text = currentPassword;
            }

        }

        //Update main password
        private void updatePassBtn_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            Encryption encryption = new Encryption();
            con.Open();

            var cmd = new SQLiteCommand(con);
            byte[] encryptedPassword = encryption.Encrypt(newPassTb.Text, key, iv);

            cmd.CommandText = "UPDATE admin SET password = @password ORDER BY id DESC LIMIT 1";
            cmd.Prepare();
            
            cmd.Parameters.AddWithValue("@password", encryptedPassword);
            cmd.ExecuteNonQuery();


            Show_data();
        }
    }

}
