namespace PassWordGen
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.ActualPassTb = new System.Windows.Forms.TextBox();
            this.newPassTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updatePassBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aktuální heslo:";
            // 
            // ActualPassTb
            // 
            this.ActualPassTb.Location = new System.Drawing.Point(330, 153);
            this.ActualPassTb.Name = "ActualPassTb";
            this.ActualPassTb.Size = new System.Drawing.Size(269, 26);
            this.ActualPassTb.TabIndex = 1;
            // 
            // newPassTb
            // 
            this.newPassTb.Location = new System.Drawing.Point(330, 195);
            this.newPassTb.Name = "newPassTb";
            this.newPassTb.Size = new System.Drawing.Size(269, 26);
            this.newPassTb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nové heslo:";
            // 
            // updatePassBtn
            // 
            this.updatePassBtn.Location = new System.Drawing.Point(330, 269);
            this.updatePassBtn.Name = "updatePassBtn";
            this.updatePassBtn.Size = new System.Drawing.Size(163, 65);
            this.updatePassBtn.TabIndex = 4;
            this.updatePassBtn.Text = "Změnit heslo";
            this.updatePassBtn.UseVisualStyleBackColor = true;
            this.updatePassBtn.Click += new System.EventHandler(this.updatePassBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Změna hlavního přístupového hesla";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updatePassBtn);
            this.Controls.Add(this.newPassTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ActualPassTb);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "PassWordGen - Změna hlavního hesla";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ActualPassTb;
        private System.Windows.Forms.TextBox newPassTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updatePassBtn;
        private System.Windows.Forms.Label label3;
    }
}