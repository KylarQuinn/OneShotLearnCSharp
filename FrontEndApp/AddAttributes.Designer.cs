namespace FrontEndApp
{
    partial class AddAttributes
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
            this.txtDisplayMsg = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtDisplayMsg
            // 
            this.txtDisplayMsg.Location = new System.Drawing.Point(257, 77);
            this.txtDisplayMsg.Name = "txtDisplayMsg";
            this.txtDisplayMsg.Size = new System.Drawing.Size(271, 96);
            this.txtDisplayMsg.TabIndex = 0;
            this.txtDisplayMsg.Text = "Made it here.";
            // 
            // AddAttributes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDisplayMsg);
            this.Name = "AddAttributes";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtDisplayMsg;
    }
}