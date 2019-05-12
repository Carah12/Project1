namespace ProgrammingProject
{
    partial class DecryptionAlteration
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDecryption = new System.Windows.Forms.Button();
            this.btnPastLogs = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblDecryption = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrowse = new System.Windows.Forms.TextBox();
            this.rtbDisplayMsg = new System.Windows.Forms.RichTextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(657, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDecryption
            // 
            this.btnDecryption.Location = new System.Drawing.Point(657, 174);
            this.btnDecryption.Name = "btnDecryption";
            this.btnDecryption.Size = new System.Drawing.Size(82, 23);
            this.btnDecryption.TabIndex = 14;
            this.btnDecryption.Text = "Decrypt File";
            this.btnDecryption.UseVisualStyleBackColor = true;
            // 
            // btnPastLogs
            // 
            this.btnPastLogs.Location = new System.Drawing.Point(657, 82);
            this.btnPastLogs.Name = "btnPastLogs";
            this.btnPastLogs.Size = new System.Drawing.Size(82, 23);
            this.btnPastLogs.TabIndex = 13;
            this.btnPastLogs.Text = "Past Logs";
            this.btnPastLogs.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(613, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // lblDecryption
            // 
            this.lblDecryption.AutoSize = true;
            this.lblDecryption.Location = new System.Drawing.Point(314, 52);
            this.lblDecryption.Name = "lblDecryption";
            this.lblDecryption.Size = new System.Drawing.Size(102, 13);
            this.lblDecryption.TabIndex = 11;
            this.lblDecryption.Text = "Decrypted Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select a File";
            // 
            // txtBrowse
            // 
            this.txtBrowse.Location = new System.Drawing.Point(137, 21);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(470, 20);
            this.txtBrowse.TabIndex = 9;
            // 
            // rtbDisplayMsg
            // 
            this.rtbDisplayMsg.Location = new System.Drawing.Point(137, 84);
            this.rtbDisplayMsg.Name = "rtbDisplayMsg";
            this.rtbDisplayMsg.Size = new System.Drawing.Size(470, 96);
            this.rtbDisplayMsg.TabIndex = 8;
            this.rtbDisplayMsg.Text = "";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(657, 111);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(82, 23);
            this.btnAddUser.TabIndex = 16;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(657, 203);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Remove User";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(657, 145);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update User";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(137, 203);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(470, 150);
            this.dgvDisplay.TabIndex = 19;
            // 
            // DecryptionAlteration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDecryption);
            this.Controls.Add(this.btnPastLogs);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblDecryption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrowse);
            this.Controls.Add(this.rtbDisplayMsg);
            this.Name = "DecryptionAlteration";
            this.Text = "DecryptionAlteration";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDecryption;
        private System.Windows.Forms.Button btnPastLogs;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblDecryption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrowse;
        private System.Windows.Forms.RichTextBox rtbDisplayMsg;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvDisplay;
    }
}