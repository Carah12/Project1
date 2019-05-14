namespace ProgrammingProject
{
    partial class Decryption
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
            this.rtbDisplayMessage = new System.Windows.Forms.RichTextBox();
            this.txtBrowse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDecryption = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnPastLogs = new System.Windows.Forms.Button();
            this.btnDecryption = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbDisplayMessage
            // 
            this.rtbDisplayMessage.Location = new System.Drawing.Point(99, 137);
            this.rtbDisplayMessage.Name = "rtbDisplayMessage";
            this.rtbDisplayMessage.Size = new System.Drawing.Size(470, 96);
            this.rtbDisplayMessage.TabIndex = 0;
            this.rtbDisplayMessage.Text = "";
            // 
            // txtBrowse
            // 
            this.txtBrowse.Location = new System.Drawing.Point(99, 32);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(470, 20);
            this.txtBrowse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a File";
            // 
            // lblDecryption
            // 
            this.lblDecryption.AutoSize = true;
            this.lblDecryption.Location = new System.Drawing.Point(276, 105);
            this.lblDecryption.Name = "lblDecryption";
            this.lblDecryption.Size = new System.Drawing.Size(102, 13);
            this.lblDecryption.TabIndex = 3;
            this.lblDecryption.Text = "Decrypted Message";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(575, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // btnPastLogs
            // 
            this.btnPastLogs.Location = new System.Drawing.Point(602, 173);
            this.btnPastLogs.Name = "btnPastLogs";
            this.btnPastLogs.Size = new System.Drawing.Size(75, 23);
            this.btnPastLogs.TabIndex = 5;
            this.btnPastLogs.Text = "Past Logs";
            this.btnPastLogs.UseVisualStyleBackColor = true;
            // 
            // btnDecryption
            // 
            this.btnDecryption.Location = new System.Drawing.Point(602, 135);
            this.btnDecryption.Name = "btnDecryption";
            this.btnDecryption.Size = new System.Drawing.Size(75, 23);
            this.btnDecryption.TabIndex = 6;
            this.btnDecryption.Text = "Decrypt File";
            this.btnDecryption.UseVisualStyleBackColor = true;
            this.btnDecryption.Click += new System.EventHandler(this.btnDecryption_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(602, 210);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Decryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 356);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDecryption);
            this.Controls.Add(this.btnPastLogs);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblDecryption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrowse);
            this.Controls.Add(this.rtbDisplayMessage);
            this.Name = "Decryption";
            this.Text = "Decryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDisplayMessage;
        private System.Windows.Forms.TextBox txtBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDecryption;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnPastLogs;
        private System.Windows.Forms.Button btnDecryption;
        private System.Windows.Forms.Button btnExit;
    }
}