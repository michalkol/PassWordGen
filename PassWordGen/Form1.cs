using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Windows.Forms.VisualStyles;
using System.Security.Cryptography;
using System.Diagnostics;

namespace PassWordGen
{
    public partial class Form1 : Form
    {
        bool IsChecked = true;
        int PasswordLenght = 15;

        string path = "database.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\database.db";
        int idUp = 0;

        byte[] key = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        byte[] iv = new byte[] { 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };


        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader reader;
        Encryption encryption = new Encryption();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Show_data();
        }
         
        //Show data func
        private void Show_data()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * from passwords";
            var cmd = new SQLiteCommand(stm, con);
            reader = cmd.ExecuteReader();

            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                int id = reader.GetInt16(0);
                string name = reader.GetString(1);
                string userName = reader.GetString(2);
                string password = encryption.Decrypt((byte[])reader.GetValue(3), key, iv);
                string url = reader.GetString(4);

                dataGridView1.Rows.Add(id, name, userName, password, url);
            }
        }
        #region Buttons
        //Save button
        private void savePassBtn_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            string name = nameTb.Text;
            string userName = userNameTb.Text;
            string url = urlTb.Text;
            string password = passTb.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vyplňte pole: Název záznamu, Uživatelské jméno a heslo!");
            }
            else
            {
                cmd.CommandText = "INSERT INTO passwords (name, userName, password, url) VALUES (@name, @userName, @password, @url)";

                byte[] encryptedPassword = encryption.Encrypt(password, key, iv);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@password", encryptedPassword);
                cmd.Parameters.AddWithValue("@url", url);

                cmd.ExecuteNonQuery();
                toolStripStatusLabel1.Text = "Záznam uložen";
                dataGridView1.Rows.Clear();
                Show_data();
            }
        }

        //Update button
        private void updatePassBtn_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            string name = nameTb.Text;
            string userName = userNameTb.Text;
            string password = passTb.Text;
            string url = urlTb.Text;
            int id = idUp;

            cmd.CommandText = "UPDATE passwords SET url = @url, password = @password, userName = @userName, name = @name WHERE id = @id";
            cmd.Prepare();

            byte[] encryptedPassword = encryption.Encrypt(password, key, iv);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@password", encryptedPassword);
            cmd.Parameters.AddWithValue("@url", url);

            cmd.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            Show_data();
            toolStripStatusLabel1.Text = "Záznam aktualizován";
        }

        //Delete button
        private void deletePassBtn_Click(object sender, EventArgs e)
        {
            string name = nameTb.Text;
            string userName = userNameTb.Text;
            string url = urlTb.Text;
            string password = passTb.Text;
            int id = idUp;

            if (id != 0)
            {
                var confirmResult = MessageBox.Show("Opravdu chcete smazat záznam?", "Smazat záznam?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var con = new SQLiteConnection(cs);
                    con.Open();
                    var cmd = new SQLiteCommand(con);

                    cmd.CommandText = "DELETE FROM passwords WHERE id = @id";
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@url", url);

                    cmd.ExecuteNonQuery();
                    dataGridView1.Rows.Clear();
                    Show_data();
                    toolStripStatusLabel1.Text = "Záznam smazán";
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "Nelze smazat neexistující záznam!";
            }

        }

        //Generate button
        private void generatePassBt_Click(object sender, EventArgs e)
        {
            GeneratorTest gt = new GeneratorTest();

            string password = gt.Generator(PasswordLenght, IsChecked);
            passTb.Text = password;
            toolStripStatusLabel1.Text = "Heslo vygenerováno";
        }

        //Search button
        private void searchBtn_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM passwords WHERE [url] LIKE '%" + searchTb.Text + "%' OR [password] LIKE '%" + searchTb.Text + "%' OR [userName] LIKE '%" + searchTb.Text + "%' OR [name] LIKE '%" + searchTb.Text + "%'";

            var cmd = new SQLiteCommand(stm, con);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    int id = reader.GetInt16(0);
                    string name = reader.GetString(1);
                    string userName = reader.GetString(2);
                    string password = encryption.Decrypt((byte[])reader.GetValue(3), key, iv);
                    string url = reader.GetString(4);

                    dataGridView1.Rows.Add(id, name, userName, password, url);
                    toolStripStatusLabel1.Text = "Záznam nalezen";
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "Záznam nebyl nalezen";
            }


        }

        //Show all button
        private void showAll_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Dispose();
            dataGridView1.Rows.Clear();
            searchTb.Clear();
            Show_data();

        }

        //Copy password button
        private void copyPassBtn_Click(object sender, EventArgs e)
        {
            if (passTb.Text != "")
            {
                Clipboard.SetText(passTb.Text);
                toolStripStatusLabel1.Text = "Heslo zkopírováno";
            }
            else
            {
                toolStripStatusLabel1.Text = "Heslo je prázdné!";
            }
        }

        //Form closing button
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Variables
        //Special signs checkbox
        private void IsSpecSigns_CheckedChanged(object sender, EventArgs e)
        {
            if (IsSpecSigns.Checked == true)
            {
                IsChecked = true;
            }
            else
            {
                IsChecked = false;
            }
        }

        //Numeric UpDown
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            PasswordLenght = Convert.ToInt32(passwordLenghtUpDown.Value);
        }
        #endregion

        #region Toolstrip
        //Change password toolstrip
        private void změnitHlavníHesloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
        
        //Logout toolstrip
        private void odhlásitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        //About toolstrip
        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PassWordGen je jednoduchý generátor hesel se zabudovanou databázi. Přihlášení do aplikace, stejně jako uložená hesla jsou zabezpečena AES šifrováním. V případě dotazu, či zjištění problémů s funkcionalitou kontaktujte vývojáře: kolibal.m@gmail.com.\n\nPassWordGen v. 1.0.0\nMichal Kolíbal 2025");
        }
        #endregion

        #region DataGridView
        //DataGrid row click
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
            {
                return;
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;

                idUp = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                nameTb.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                userNameTb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                passTb.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                urlTb.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            }
        }

        //Datagrid cell double click
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
            {
                return;
            }
            Process.Start("chrome", dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
        }
        #endregion
    }
}
