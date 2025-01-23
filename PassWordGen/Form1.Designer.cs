namespace PassWordGen
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.přihlášeníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.změnitHlavníHesloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odhlásitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.showAll = new System.Windows.Forms.Button();
            this.passTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordLenghtUpDown = new System.Windows.Forms.NumericUpDown();
            this.IsSpecSigns = new System.Windows.Forms.CheckBox();
            this.deletePassBtn = new System.Windows.Forms.Button();
            this.updatePassBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.urlTb = new System.Windows.Forms.TextBox();
            this.userNameTb = new System.Windows.Forms.TextBox();
            this.savePassBtn = new System.Windows.Forms.Button();
            this.copyPassBtn = new System.Windows.Forms.Button();
            this.generatePassBt = new System.Windows.Forms.Button();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLenghtUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.userName,
            this.password,
            this.url});
            this.dataGridView1.Location = new System.Drawing.Point(21, 461);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(836, 497);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.přihlášeníToolStripMenuItem,
            this.oProgramuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 33);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // přihlášeníToolStripMenuItem
            // 
            this.přihlášeníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.změnitHlavníHesloToolStripMenuItem,
            this.odhlásitToolStripMenuItem});
            this.přihlášeníToolStripMenuItem.Name = "přihlášeníToolStripMenuItem";
            this.přihlášeníToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.přihlášeníToolStripMenuItem.Text = "Přihlášení";
            // 
            // změnitHlavníHesloToolStripMenuItem
            // 
            this.změnitHlavníHesloToolStripMenuItem.Name = "změnitHlavníHesloToolStripMenuItem";
            this.změnitHlavníHesloToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.změnitHlavníHesloToolStripMenuItem.Text = "Změnit hlavní heslo";
            this.změnitHlavníHesloToolStripMenuItem.Click += new System.EventHandler(this.změnitHlavníHesloToolStripMenuItem_Click);
            // 
            // odhlásitToolStripMenuItem
            // 
            this.odhlásitToolStripMenuItem.Name = "odhlásitToolStripMenuItem";
            this.odhlásitToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.odhlásitToolStripMenuItem.Text = "Odhlásit";
            this.odhlásitToolStripMenuItem.Click += new System.EventHandler(this.odhlásitToolStripMenuItem_Click);
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(21, 429);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(521, 26);
            this.searchTb.TabIndex = 17;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(548, 406);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(153, 49);
            this.searchBtn.TabIndex = 18;
            this.searchBtn.Text = "Vyhledat";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 985);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 15);
            // 
            // showAll
            // 
            this.showAll.Location = new System.Drawing.Point(707, 406);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(150, 49);
            this.showAll.TabIndex = 18;
            this.showAll.Text = "Zobrazit vše";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // passTb
            // 
            this.passTb.Location = new System.Drawing.Point(428, 215);
            this.passTb.Name = "passTb";
            this.passTb.Size = new System.Drawing.Size(432, 26);
            this.passTb.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(768, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Délka hesla";
            // 
            // passwordLenghtUpDown
            // 
            this.passwordLenghtUpDown.Location = new System.Drawing.Point(687, 269);
            this.passwordLenghtUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.passwordLenghtUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.passwordLenghtUpDown.Name = "passwordLenghtUpDown";
            this.passwordLenghtUpDown.Size = new System.Drawing.Size(75, 26);
            this.passwordLenghtUpDown.TabIndex = 32;
            this.passwordLenghtUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.passwordLenghtUpDown.Click += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // IsSpecSigns
            // 
            this.IsSpecSigns.AutoSize = true;
            this.IsSpecSigns.Checked = true;
            this.IsSpecSigns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsSpecSigns.Location = new System.Drawing.Point(428, 272);
            this.IsSpecSigns.Name = "IsSpecSigns";
            this.IsSpecSigns.Size = new System.Drawing.Size(189, 24);
            this.IsSpecSigns.TabIndex = 31;
            this.IsSpecSigns.Text = "Použít speciální znaky";
            this.IsSpecSigns.UseVisualStyleBackColor = true;
            this.IsSpecSigns.Click += new System.EventHandler(this.IsSpecSigns_CheckedChanged);
            // 
            // deletePassBtn
            // 
            this.deletePassBtn.BackColor = System.Drawing.Color.IndianRed;
            this.deletePassBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletePassBtn.Location = new System.Drawing.Point(707, 319);
            this.deletePassBtn.Name = "deletePassBtn";
            this.deletePassBtn.Size = new System.Drawing.Size(153, 49);
            this.deletePassBtn.TabIndex = 30;
            this.deletePassBtn.Text = "Smazat heslo";
            this.deletePassBtn.UseVisualStyleBackColor = false;
            this.deletePassBtn.Click += new System.EventHandler(this.deletePassBtn_Click);
            // 
            // updatePassBtn
            // 
            this.updatePassBtn.Location = new System.Drawing.Point(548, 319);
            this.updatePassBtn.Name = "updatePassBtn";
            this.updatePassBtn.Size = new System.Drawing.Size(153, 49);
            this.updatePassBtn.TabIndex = 29;
            this.updatePassBtn.Text = "Upravit heslo";
            this.updatePassBtn.UseVisualStyleBackColor = true;
            this.updatePassBtn.Click += new System.EventHandler(this.updatePassBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Heslo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Odkaz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Uživatelské jméno:";
            // 
            // urlTb
            // 
            this.urlTb.Location = new System.Drawing.Point(428, 160);
            this.urlTb.Name = "urlTb";
            this.urlTb.Size = new System.Drawing.Size(432, 26);
            this.urlTb.TabIndex = 24;
            // 
            // userNameTb
            // 
            this.userNameTb.Location = new System.Drawing.Point(428, 108);
            this.userNameTb.Name = "userNameTb";
            this.userNameTb.Size = new System.Drawing.Size(432, 26);
            this.userNameTb.TabIndex = 23;
            // 
            // savePassBtn
            // 
            this.savePassBtn.Location = new System.Drawing.Point(389, 319);
            this.savePassBtn.Name = "savePassBtn";
            this.savePassBtn.Size = new System.Drawing.Size(153, 49);
            this.savePassBtn.TabIndex = 22;
            this.savePassBtn.Text = "Uložit heslo";
            this.savePassBtn.UseVisualStyleBackColor = true;
            this.savePassBtn.Click += new System.EventHandler(this.savePassBtn_Click);
            // 
            // copyPassBtn
            // 
            this.copyPassBtn.Location = new System.Drawing.Point(232, 319);
            this.copyPassBtn.Name = "copyPassBtn";
            this.copyPassBtn.Size = new System.Drawing.Size(151, 49);
            this.copyPassBtn.TabIndex = 21;
            this.copyPassBtn.Text = "Kopírovat heslo";
            this.copyPassBtn.UseVisualStyleBackColor = true;
            this.copyPassBtn.Click += new System.EventHandler(this.copyPassBtn_Click);
            // 
            // generatePassBt
            // 
            this.generatePassBt.Location = new System.Drawing.Point(24, 59);
            this.generatePassBt.Name = "generatePassBt";
            this.generatePassBt.Size = new System.Drawing.Size(153, 182);
            this.generatePassBt.TabIndex = 20;
            this.generatePassBt.Text = "Generovat heslo";
            this.generatePassBt.UseVisualStyleBackColor = true;
            this.generatePassBt.Click += new System.EventHandler(this.generatePassBt_Click);
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(428, 59);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(432, 26);
            this.nameTb.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Název záznamu:";
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "Název záznamu";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            // 
            // userName
            // 
            this.userName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.userName.HeaderText = "Uživatelské jméno";
            this.userName.MinimumWidth = 8;
            this.userName.Name = "userName";
            this.userName.Width = 168;
            // 
            // password
            // 
            this.password.HeaderText = "Heslo";
            this.password.MinimumWidth = 8;
            this.password.Name = "password";
            // 
            // url
            // 
            this.url.HeaderText = "Odkaz";
            this.url.MinimumWidth = 8;
            this.url.Name = "url";
            this.url.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.url.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 1007);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordLenghtUpDown);
            this.Controls.Add(this.IsSpecSigns);
            this.Controls.Add(this.deletePassBtn);
            this.Controls.Add(this.updatePassBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.userNameTb);
            this.Controls.Add(this.savePassBtn);
            this.Controls.Add(this.copyPassBtn);
            this.Controls.Add(this.generatePassBt);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PassWordGen - Generátor hesel v. 1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLenghtUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem přihlášeníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem změnitHlavníHesloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odhlásitToolStripMenuItem;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.TextBox passTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown passwordLenghtUpDown;
        private System.Windows.Forms.CheckBox IsSpecSigns;
        private System.Windows.Forms.Button deletePassBtn;
        private System.Windows.Forms.Button updatePassBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlTb;
        private System.Windows.Forms.TextBox userNameTb;
        private System.Windows.Forms.Button savePassBtn;
        private System.Windows.Forms.Button copyPassBtn;
        private System.Windows.Forms.Button generatePassBt;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewLinkColumn url;
    }
}

