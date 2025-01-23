namespace PassWordGen
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.createPassBtn = new System.Windows.Forms.Button();
            this.createPassTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createPassBtn
            // 
            this.createPassBtn.Location = new System.Drawing.Point(313, 254);
            this.createPassBtn.Name = "createPassBtn";
            this.createPassBtn.Size = new System.Drawing.Size(165, 52);
            this.createPassBtn.TabIndex = 3;
            this.createPassBtn.Text = "Vytvořit heslo";
            this.createPassBtn.UseVisualStyleBackColor = true;
            this.createPassBtn.Click += new System.EventHandler(this.createPassBtn_Click);
            // 
            // createPassTb
            // 
            this.createPassTb.Location = new System.Drawing.Point(206, 165);
            this.createPassTb.Name = "createPassTb";
            this.createPassTb.Size = new System.Drawing.Size(389, 26);
            this.createPassTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zvolte dobře zapamatovatelné heslo. Z bezpečnostních důvodů nelze zapomenuté hesl" +
    "o obnovit.";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createPassBtn);
            this.Controls.Add(this.createPassTb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "PassWordGen - Vytvoření hlavního hesla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createPassBtn;
        private System.Windows.Forms.TextBox createPassTb;
        private System.Windows.Forms.Label label1;
    }
}