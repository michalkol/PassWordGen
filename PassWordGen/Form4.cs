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
    public partial class Form4 : Form
    {
        Encryption encryption = new Encryption();
        string path = "database.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\database.db";

        byte[] key = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        byte[] iv = new byte[] { 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader reader;

        public Form4()
        {
            InitializeComponent();
        }

        //Create main password
        private void createPassBtn_Click(object sender, EventArgs e)
        {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "INSERT INTO admin (password) VALUES (@password)";

                string password = createPassTb.Text;
                byte[] encryptedPassword = encryption.Encrypt(password, key, iv);

            if (password == "")
                {
                    MessageBox.Show("Heslo nemůže být prázdné!");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@password", encryptedPassword);
                    cmd.ExecuteNonQuery();
                }

                this.Close();
                Form3 form3 = new Form3();
                form3.Show();
        }
    }
}
