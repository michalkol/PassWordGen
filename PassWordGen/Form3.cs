using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PassWordGen
{
    public partial class Form3 : Form
    {
        string path = "database.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\database.db";

        byte[] key = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        byte[] iv = new byte[] { 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };


        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader reader;
        Encryption encryption = new Encryption();

        public Form3()
        {
            InitializeComponent();
        }

        //Create new main password
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "SELECT COUNT(password) FROM admin";

            cmd.Prepare();

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int verify = reader.GetInt32(0);
                if (verify == 0)
                {
                    this.Hide();
                    Form4 form4 = new Form4();
                    form4.Show();
                }
                else
                {
                    MessageBox.Show("Hlavní heslo již bylo vytvořeno!");
                }
            }
        }

        //Main login
        private void button1_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            string password = loginTb.Text;

            cmd.CommandText = "SELECT * FROM admin ORDER BY id DESC LIMIT 1";
            cmd.Prepare();

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string verify = encryption.Decrypt((byte[])reader.GetValue(1), key, iv);
                    if (password == verify)
                    {
                        this.Hide();
                        Form1 form1 = new Form1();
                        form1.Show();
                    }
                    else if (password == "")
                    {
                        MessageBox.Show("Musíte zadat heslo!");
                    }
                    else if (verify != password)
                    {
                        MessageBox.Show("Špatné heslo!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ještě jste nevytvořili hlavní heslo!");
            }

        }

        //Form closing button
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
