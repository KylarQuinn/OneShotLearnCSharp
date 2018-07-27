namespace FrontEndApp
{
    partial class NewPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlayer));
            this.lblLiteralAge = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtPlayerAge = new System.Windows.Forms.TextBox();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblLiteralAge
            // 
            this.lblLiteralAge.AutoSize = true;
            this.lblLiteralAge.Location = new System.Drawing.Point(13, 124);
            this.lblLiteralAge.Name = "lblLiteralAge";
            this.lblLiteralAge.Size = new System.Drawing.Size(81, 17);
            this.lblLiteralAge.TabIndex = 0;
            this.lblLiteralAge.Text = "Player Age:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(13, 167);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(41, 17);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Role:";
            // 
            // txtPlayerAge
            // 
            this.txtPlayerAge.Location = new System.Drawing.Point(121, 124);
            this.txtPlayerAge.Name = "txtPlayerAge";
            this.txtPlayerAge.Size = new System.Drawing.Size(100, 22);
            this.txtPlayerAge.TabIndex = 3;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(691, 415);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 23);
            this.btnNextPage.TabIndex = 5;
            this.btnNextPage.Text = "Next";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.BtnNextPage_OnClick);
            // 
            // cboRoles
            // 
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Location = new System.Drawing.Point(121, 167);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(121, 24);
            this.cboRoles.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(750, 90);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // NewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cboRoles);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.txtPlayerAge);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblLiteralAge);
            this.Name = "NewPlayer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLiteralAge;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtPlayerAge;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.ComboBox cboRoles;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

