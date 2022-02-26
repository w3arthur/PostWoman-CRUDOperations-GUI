namespace PostWomanApp
{
    partial class PostWoman
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.pnlMethods = new System.Windows.Forms.Panel();
            this.chkPost = new System.Windows.Forms.RadioButton();
            this.chkGet = new System.Windows.Forms.RadioButton();
            this.chkPut = new System.Windows.Forms.RadioButton();
            this.chkDelete = new System.Windows.Forms.RadioButton();
            this.pnlFilePost = new System.Windows.Forms.Panel();
            this.lblDeleteFile = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.btnExample = new System.Windows.Forms.Button();
            this.btnGetAnd = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.clrMessage = new System.Windows.Forms.Button();
            this.lblPostWoman = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.lnlWebApp = new System.Windows.Forms.LinkLabel();
            this.lblCredit = new System.Windows.Forms.LinkLabel();
            this.lblThanks = new System.Windows.Forms.Label();
            this.clrResult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.pnlMessage.SuspendLayout();
            this.pnlMethods.SuspendLayout();
            this.pnlFilePost.SuspendLayout();
            this.pnlResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMessage
            // 
            this.pnlMessage.BackColor = System.Drawing.Color.LightBlue;
            this.pnlMessage.Controls.Add(this.pnlMethods);
            this.pnlMessage.Controls.Add(this.pnlFilePost);
            this.pnlMessage.Controls.Add(this.btnExample);
            this.pnlMessage.Controls.Add(this.btnGetAnd);
            this.pnlMessage.Controls.Add(this.lblMessage);
            this.pnlMessage.Controls.Add(this.clrMessage);
            this.pnlMessage.Controls.Add(this.lblPostWoman);
            this.pnlMessage.Controls.Add(this.txtMessage);
            this.pnlMessage.Controls.Add(this.lblAddress);
            this.pnlMessage.Controls.Add(this.btnSend);
            this.pnlMessage.Controls.Add(this.txtAddress);
            this.pnlMessage.Location = new System.Drawing.Point(21, 15);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(534, 363);
            this.pnlMessage.TabIndex = 1;
            // 
            // pnlMethods
            // 
            this.pnlMethods.Controls.Add(this.chkPost);
            this.pnlMethods.Controls.Add(this.chkGet);
            this.pnlMethods.Controls.Add(this.chkPut);
            this.pnlMethods.Controls.Add(this.chkDelete);
            this.pnlMethods.Location = new System.Drawing.Point(92, 95);
            this.pnlMethods.Name = "pnlMethods";
            this.pnlMethods.Size = new System.Drawing.Size(151, 68);
            this.pnlMethods.TabIndex = 3;
            // 
            // chkPost
            // 
            this.chkPost.AutoSize = true;
            this.chkPost.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkPost.ForeColor = System.Drawing.Color.Navy;
            this.chkPost.Location = new System.Drawing.Point(68, 5);
            this.chkPost.Name = "chkPost";
            this.chkPost.Size = new System.Drawing.Size(63, 27);
            this.chkPost.TabIndex = 3;
            this.chkPost.TabStop = true;
            this.chkPost.Text = "Post";
            this.chkPost.UseVisualStyleBackColor = true;
            this.chkPost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkPost_KeyDown);
            // 
            // chkGet
            // 
            this.chkGet.AutoSize = true;
            this.chkGet.Checked = true;
            this.chkGet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkGet.ForeColor = System.Drawing.Color.Navy;
            this.chkGet.Location = new System.Drawing.Point(5, 5);
            this.chkGet.Name = "chkGet";
            this.chkGet.Size = new System.Drawing.Size(58, 27);
            this.chkGet.TabIndex = 1;
            this.chkGet.TabStop = true;
            this.chkGet.Text = "Get";
            this.chkGet.UseVisualStyleBackColor = true;
            this.chkGet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkGet_KeyDown);
            // 
            // chkPut
            // 
            this.chkPut.AutoSize = true;
            this.chkPut.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkPut.ForeColor = System.Drawing.Color.Navy;
            this.chkPut.Location = new System.Drawing.Point(5, 35);
            this.chkPut.Name = "chkPut";
            this.chkPut.Size = new System.Drawing.Size(57, 27);
            this.chkPut.TabIndex = 2;
            this.chkPut.TabStop = true;
            this.chkPut.Text = "Put";
            this.chkPut.UseVisualStyleBackColor = true;
            this.chkPut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkPut_KeyDown);
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkDelete.ForeColor = System.Drawing.Color.Navy;
            this.chkDelete.Location = new System.Drawing.Point(68, 35);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(80, 27);
            this.chkDelete.TabIndex = 4;
            this.chkDelete.TabStop = true;
            this.chkDelete.Text = "Delete";
            this.chkDelete.UseVisualStyleBackColor = true;
            this.chkDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkDelete_KeyDown);
            // 
            // pnlFilePost
            // 
            this.pnlFilePost.Controls.Add(this.lblDeleteFile);
            this.pnlFilePost.Controls.Add(this.checkBox1);
            this.pnlFilePost.Controls.Add(this.btnUploadFile);
            this.pnlFilePost.Location = new System.Drawing.Point(246, 135);
            this.pnlFilePost.Name = "pnlFilePost";
            this.pnlFilePost.Size = new System.Drawing.Size(159, 48);
            this.pnlFilePost.TabIndex = 10;
            // 
            // lblDeleteFile
            // 
            this.lblDeleteFile.AutoSize = true;
            this.lblDeleteFile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeleteFile.Location = new System.Drawing.Point(3, 8);
            this.lblDeleteFile.Name = "lblDeleteFile";
            this.lblDeleteFile.Size = new System.Drawing.Size(19, 23);
            this.lblDeleteFile.TabIndex = 3;
            this.lblDeleteFile.TabStop = true;
            this.lblDeleteFile.Text = "x";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.Navy;
            this.checkBox1.Location = new System.Drawing.Point(22, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.MintCream;
            this.btnUploadFile.Enabled = false;
            this.btnUploadFile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUploadFile.ForeColor = System.Drawing.Color.Navy;
            this.btnUploadFile.Location = new System.Drawing.Point(44, 7);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(113, 29);
            this.btnUploadFile.TabIndex = 1;
            this.btnUploadFile.Text = "Add File";
            this.btnUploadFile.UseVisualStyleBackColor = false;
            // 
            // btnExample
            // 
            this.btnExample.BackColor = System.Drawing.Color.MintCream;
            this.btnExample.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExample.ForeColor = System.Drawing.Color.Navy;
            this.btnExample.Location = new System.Drawing.Point(435, 133);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(87, 29);
            this.btnExample.TabIndex = 9;
            this.btnExample.Text = "+httpbin";
            this.btnExample.UseVisualStyleBackColor = false;
            // 
            // btnGetAnd
            // 
            this.btnGetAnd.BackColor = System.Drawing.Color.MintCream;
            this.btnGetAnd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetAnd.ForeColor = System.Drawing.Color.Navy;
            this.btnGetAnd.Location = new System.Drawing.Point(274, 100);
            this.btnGetAnd.Name = "btnGetAnd";
            this.btnGetAnd.Size = new System.Drawing.Size(48, 29);
            this.btnGetAnd.TabIndex = 4;
            this.btnGetAnd.Text = "?/&&";
            this.btnGetAnd.UseVisualStyleBackColor = false;
            this.btnGetAnd.Click += new System.EventHandler(this.btnGetAnd_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblMessage.Location = new System.Drawing.Point(53, 163);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(77, 23);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message";
            // 
            // clrMessage
            // 
            this.clrMessage.BackColor = System.Drawing.Color.MintCream;
            this.clrMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clrMessage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clrMessage.Location = new System.Drawing.Point(466, 289);
            this.clrMessage.Name = "clrMessage";
            this.clrMessage.Size = new System.Drawing.Size(65, 29);
            this.clrMessage.TabIndex = 7;
            this.clrMessage.Text = "Clear";
            this.clrMessage.UseVisualStyleBackColor = false;
            this.clrMessage.Click += new System.EventHandler(this.clrMessage_Click);
            // 
            // lblPostWoman
            // 
            this.lblPostWoman.AutoSize = true;
            this.lblPostWoman.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPostWoman.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPostWoman.Location = new System.Drawing.Point(14, 9);
            this.lblPostWoman.Name = "lblPostWoman";
            this.lblPostWoman.Size = new System.Drawing.Size(216, 28);
            this.lblPostWoman.TabIndex = 0;
            this.lblPostWoman.Text = "Zionet - POST Woman";
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMessage.Location = new System.Drawing.Point(16, 187);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(444, 145);
            this.txtMessage.TabIndex = 6;
            this.txtMessage.Text = "";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblAddress.Location = new System.Drawing.Point(53, 34);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 23);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.OldLace;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSend.ForeColor = System.Drawing.Color.Navy;
            this.btnSend.Location = new System.Drawing.Point(328, 100);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 29);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.Location = new System.Drawing.Point(52, 60);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(447, 30);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            // 
            // pnlResult
            // 
            this.pnlResult.BackColor = System.Drawing.Color.LightBlue;
            this.pnlResult.Controls.Add(this.lnlWebApp);
            this.pnlResult.Controls.Add(this.lblCredit);
            this.pnlResult.Controls.Add(this.lblThanks);
            this.pnlResult.Controls.Add(this.clrResult);
            this.pnlResult.Controls.Add(this.lblResult);
            this.pnlResult.Controls.Add(this.txtResult);
            this.pnlResult.Location = new System.Drawing.Point(21, 384);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(534, 274);
            this.pnlResult.TabIndex = 8;
            // 
            // lnlWebApp
            // 
            this.lnlWebApp.AutoSize = true;
            this.lnlWebApp.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lnlWebApp.Location = new System.Drawing.Point(441, 239);
            this.lnlWebApp.Name = "lnlWebApp";
            this.lnlWebApp.Size = new System.Drawing.Size(81, 23);
            this.lnlWebApp.TabIndex = 4;
            this.lnlWebApp.TabStop = true;
            this.lnlWebApp.Tag = "";
            this.lnlWebApp.Text = "Web App";
            this.lnlWebApp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlWebApp_LinkClicked);
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCredit.Location = new System.Drawing.Point(190, 239);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(81, 23);
            this.lblCredit.TabIndex = 3;
            this.lblCredit.TabStop = true;
            this.lblCredit.Tag = "";
            this.lblCredit.Text = "w3Arthur";
            this.lblCredit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCredit_LinkClicked);
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblThanks.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblThanks.Location = new System.Drawing.Point(16, 239);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(145, 23);
            this.lblThanks.TabIndex = 0;
            this.lblThanks.Text = "Thanks for usage.";
            // 
            // clrResult
            // 
            this.clrResult.BackColor = System.Drawing.Color.MintCream;
            this.clrResult.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clrResult.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clrResult.Location = new System.Drawing.Point(466, 164);
            this.clrResult.Name = "clrResult";
            this.clrResult.Size = new System.Drawing.Size(65, 29);
            this.clrResult.TabIndex = 2;
            this.clrResult.Text = "Clear";
            this.clrResult.UseVisualStyleBackColor = false;
            this.clrResult.Click += new System.EventHandler(this.clrResult_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblResult.Location = new System.Drawing.Point(53, 5);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(57, 23);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(16, 31);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(444, 177);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "";
            // 
            // PostWoman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(573, 679);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.pnlMessage);
            this.Name = "PostWoman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Post Woman";
            this.pnlMessage.ResumeLayout(false);
            this.pnlMessage.PerformLayout();
            this.pnlMethods.ResumeLayout(false);
            this.pnlMethods.PerformLayout();
            this.pnlFilePost.ResumeLayout(false);
            this.pnlFilePost.PerformLayout();
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RadioButton chkDelete;
        private System.Windows.Forms.RadioButton chkPut;
        private System.Windows.Forms.RadioButton chkPost;
        private System.Windows.Forms.RadioButton chkGet;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button clrMessage;
        private System.Windows.Forms.Label lblPostWoman;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button clrResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnExample;
        private System.Windows.Forms.Button btnGetAnd;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.LinkLabel lblCredit;
        private System.Windows.Forms.Panel pnlMethods;
        private System.Windows.Forms.Panel pnlFilePost;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.LinkLabel lblDeleteFile;
        private System.Windows.Forms.LinkLabel lnlWebApp;
    }
}
