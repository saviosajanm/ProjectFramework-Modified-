namespace ProjectFrameworkAPITest
{
    partial class ProjectFrameworkForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonGet = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMainHeading = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAppName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxResponseData = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelAuthTokenValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEmail = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableSsl = new System.Windows.Forms.CheckBox();
            this.buttonSetEmail = new System.Windows.Forms.Button();
            this.buttonGetEmail = new System.Windows.Forms.Button();
            this.textBoxEmailPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSmtpPort = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSmtpServer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxDevice = new System.Windows.Forms.GroupBox();
            this.buttonGetDevice = new System.Windows.Forms.Button();
            this.textBoxSpaceLeft = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTotalSpace = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxMemoryLeft = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxTotalMemory = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxProcessorCount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxEmail.SuspendLayout();
            this.groupBoxDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSet);
            this.groupBox1.Controls.Add(this.buttonGet);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxMainHeading);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxAppName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 133);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configure App Settings Data";
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(705, 79);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(171, 31);
            this.buttonSet.TabIndex = 10;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_ClickAsync);
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(705, 30);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(171, 31);
            this.buttonGet.TabIndex = 10;
            this.buttonGet.Text = "Get";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_ClickAsync);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(181, 96);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(501, 22);
            this.textBoxDescription.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Description";
            // 
            // textBoxMainHeading
            // 
            this.textBoxMainHeading.Location = new System.Drawing.Point(181, 65);
            this.textBoxMainHeading.Name = "textBoxMainHeading";
            this.textBoxMainHeading.Size = new System.Drawing.Size(501, 22);
            this.textBoxMainHeading.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Main Heading";
            // 
            // textBoxAppName
            // 
            this.textBoxAppName.Location = new System.Drawing.Point(181, 34);
            this.textBoxAppName.Name = "textBoxAppName";
            this.textBoxAppName.Size = new System.Drawing.Size(501, 22);
            this.textBoxAppName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Application Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxResponseData);
            this.groupBox2.Location = new System.Drawing.Point(12, 638);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(918, 134);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Response Data";
            // 
            // textBoxResponseData
            // 
            this.textBoxResponseData.Location = new System.Drawing.Point(6, 23);
            this.textBoxResponseData.Multiline = true;
            this.textBoxResponseData.Name = "textBoxResponseData";
            this.textBoxResponseData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResponseData.Size = new System.Drawing.Size(893, 93);
            this.textBoxResponseData.TabIndex = 14;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(664, 789);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(266, 34);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelAuthTokenValue);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.buttonLogin);
            this.groupBox3.Controls.Add(this.textBoxPassword);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxUserID);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxURL);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(918, 148);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Authenticate User";
            // 
            // labelAuthTokenValue
            // 
            this.labelAuthTokenValue.Location = new System.Drawing.Point(109, 119);
            this.labelAuthTokenValue.Name = "labelAuthTokenValue";
            this.labelAuthTokenValue.Size = new System.Drawing.Size(779, 22);
            this.labelAuthTokenValue.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Auth Token";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(718, 69);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(171, 31);
            this.buttonLogin.TabIndex = 15;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_ClickAsync);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(459, 75);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(220, 22);
            this.textBoxPassword.TabIndex = 14;
            this.textBoxPassword.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(109, 77);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(220, 22);
            this.textBoxUserID.TabIndex = 12;
            this.textBoxUserID.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "User ID";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(106, 32);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(779, 22);
            this.textBoxURL.TabIndex = 10;
            this.textBoxURL.Text = "http://localhost:51000/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Web URL";
            // 
            // groupBoxEmail
            // 
            this.groupBoxEmail.Controls.Add(this.checkBoxEnableSsl);
            this.groupBoxEmail.Controls.Add(this.buttonSetEmail);
            this.groupBoxEmail.Controls.Add(this.buttonGetEmail);
            this.groupBoxEmail.Controls.Add(this.textBoxEmailPassword);
            this.groupBoxEmail.Controls.Add(this.label8);
            this.groupBoxEmail.Controls.Add(this.textBoxEmailAddress);
            this.groupBoxEmail.Controls.Add(this.label9);
            this.groupBoxEmail.Controls.Add(this.textBoxSmtpPort);
            this.groupBoxEmail.Controls.Add(this.label10);
            this.groupBoxEmail.Controls.Add(this.textBoxSmtpServer);
            this.groupBoxEmail.Controls.Add(this.label11);
            this.groupBoxEmail.Location = new System.Drawing.Point(13, 306);
            this.groupBoxEmail.Name = "groupBoxEmail";
            this.groupBoxEmail.Size = new System.Drawing.Size(917, 161);
            this.groupBoxEmail.TabIndex = 13;
            this.groupBoxEmail.TabStop = false;
            this.groupBoxEmail.Text = "Configure Email Settings";
            // 
            // checkBoxEnableSsl
            // 
            this.checkBoxEnableSsl.AutoSize = true;
            this.checkBoxEnableSsl.Location = new System.Drawing.Point(180, 126);
            this.checkBoxEnableSsl.Name = "checkBoxEnableSsl";
            this.checkBoxEnableSsl.Size = new System.Drawing.Size(102, 21);
            this.checkBoxEnableSsl.TabIndex = 24;
            this.checkBoxEnableSsl.Text = "Enable SSL";
            this.checkBoxEnableSsl.UseVisualStyleBackColor = true;
            // 
            // buttonSetEmail
            // 
            this.buttonSetEmail.Location = new System.Drawing.Point(704, 80);
            this.buttonSetEmail.Name = "buttonSetEmail";
            this.buttonSetEmail.Size = new System.Drawing.Size(171, 31);
            this.buttonSetEmail.TabIndex = 15;
            this.buttonSetEmail.Text = "Set";
            this.buttonSetEmail.UseVisualStyleBackColor = true;
            this.buttonSetEmail.Click += new System.EventHandler(this.buttonSetEmail_ClickAsync);
            // 
            // buttonGetEmail
            // 
            this.buttonGetEmail.Location = new System.Drawing.Point(704, 31);
            this.buttonGetEmail.Name = "buttonGetEmail";
            this.buttonGetEmail.Size = new System.Drawing.Size(171, 31);
            this.buttonGetEmail.TabIndex = 14;
            this.buttonGetEmail.Text = "Get";
            this.buttonGetEmail.UseVisualStyleBackColor = true;
            this.buttonGetEmail.Click += new System.EventHandler(this.buttonGetEmail_ClickAsync);
            // 
            // textBoxEmailPassword
            // 
            this.textBoxEmailPassword.Location = new System.Drawing.Point(464, 89);
            this.textBoxEmailPassword.Name = "textBoxEmailPassword";
            this.textBoxEmailPassword.PasswordChar = '*';
            this.textBoxEmailPassword.Size = new System.Drawing.Size(217, 22);
            this.textBoxEmailPassword.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Password";
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(180, 89);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(170, 22);
            this.textBoxEmailAddress.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Email Address";
            // 
            // textBoxSmtpPort
            // 
            this.textBoxSmtpPort.Location = new System.Drawing.Point(180, 59);
            this.textBoxSmtpPort.Name = "textBoxSmtpPort";
            this.textBoxSmtpPort.Size = new System.Drawing.Size(501, 22);
            this.textBoxSmtpPort.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "SMTP Port";
            // 
            // textBoxSmtpServer
            // 
            this.textBoxSmtpServer.Location = new System.Drawing.Point(180, 29);
            this.textBoxSmtpServer.Name = "textBoxSmtpServer";
            this.textBoxSmtpServer.Size = new System.Drawing.Size(501, 22);
            this.textBoxSmtpServer.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "SMTP Server";
            // 
            // groupBoxDevice
            // 
            this.groupBoxDevice.Controls.Add(this.buttonGetDevice);
            this.groupBoxDevice.Controls.Add(this.textBoxSpaceLeft);
            this.groupBoxDevice.Controls.Add(this.label12);
            this.groupBoxDevice.Controls.Add(this.textBoxTotalSpace);
            this.groupBoxDevice.Controls.Add(this.label13);
            this.groupBoxDevice.Controls.Add(this.textBoxMemoryLeft);
            this.groupBoxDevice.Controls.Add(this.label14);
            this.groupBoxDevice.Controls.Add(this.textBoxTotalMemory);
            this.groupBoxDevice.Controls.Add(this.label15);
            this.groupBoxDevice.Controls.Add(this.textBoxProcessorCount);
            this.groupBoxDevice.Controls.Add(this.label16);
            this.groupBoxDevice.Location = new System.Drawing.Point(12, 473);
            this.groupBoxDevice.Name = "groupBoxDevice";
            this.groupBoxDevice.Size = new System.Drawing.Size(917, 159);
            this.groupBoxDevice.TabIndex = 14;
            this.groupBoxDevice.TabStop = false;
            this.groupBoxDevice.Text = "View Device Details";
            // 
            // buttonGetDevice
            // 
            this.buttonGetDevice.Location = new System.Drawing.Point(704, 31);
            this.buttonGetDevice.Name = "buttonGetDevice";
            this.buttonGetDevice.Size = new System.Drawing.Size(171, 31);
            this.buttonGetDevice.TabIndex = 25;
            this.buttonGetDevice.Text = "Get";
            this.buttonGetDevice.UseVisualStyleBackColor = true;
            this.buttonGetDevice.Click += new System.EventHandler(this.buttonGetDevice_ClickAsync);
            // 
            // textBoxSpaceLeft
            // 
            this.textBoxSpaceLeft.Location = new System.Drawing.Point(465, 92);
            this.textBoxSpaceLeft.Name = "textBoxSpaceLeft";
            this.textBoxSpaceLeft.ReadOnly = true;
            this.textBoxSpaceLeft.Size = new System.Drawing.Size(217, 22);
            this.textBoxSpaceLeft.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(366, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Space Left";
            // 
            // textBoxTotalSpace
            // 
            this.textBoxTotalSpace.Location = new System.Drawing.Point(181, 92);
            this.textBoxTotalSpace.Name = "textBoxTotalSpace";
            this.textBoxTotalSpace.ReadOnly = true;
            this.textBoxTotalSpace.Size = new System.Drawing.Size(170, 22);
            this.textBoxTotalSpace.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Total Space";
            // 
            // textBoxMemoryLeft
            // 
            this.textBoxMemoryLeft.Location = new System.Drawing.Point(181, 62);
            this.textBoxMemoryLeft.Name = "textBoxMemoryLeft";
            this.textBoxMemoryLeft.ReadOnly = true;
            this.textBoxMemoryLeft.Size = new System.Drawing.Size(501, 22);
            this.textBoxMemoryLeft.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "Memory Left";
            // 
            // textBoxTotalMemory
            // 
            this.textBoxTotalMemory.Location = new System.Drawing.Point(465, 29);
            this.textBoxTotalMemory.Name = "textBoxTotalMemory";
            this.textBoxTotalMemory.ReadOnly = true;
            this.textBoxTotalMemory.Size = new System.Drawing.Size(217, 22);
            this.textBoxTotalMemory.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(366, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "Total Memory";
            // 
            // textBoxProcessorCount
            // 
            this.textBoxProcessorCount.Location = new System.Drawing.Point(181, 32);
            this.textBoxProcessorCount.Name = "textBoxProcessorCount";
            this.textBoxProcessorCount.ReadOnly = true;
            this.textBoxProcessorCount.Size = new System.Drawing.Size(170, 22);
            this.textBoxProcessorCount.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "Processor Count";
            // 
            // ProjectFrameworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 835);
            this.Controls.Add(this.groupBoxDevice);
            this.Controls.Add(this.groupBoxEmail);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectFrameworkForm";
            this.Text = "Form API Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxEmail.ResumeLayout(false);
            this.groupBoxEmail.PerformLayout();
            this.groupBoxDevice.ResumeLayout(false);
            this.groupBoxDevice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAppName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMainHeading;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxResponseData;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox labelAuthTokenValue;
        private System.Windows.Forms.GroupBox groupBoxEmail;
        private System.Windows.Forms.TextBox textBoxEmailPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSmtpPort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSmtpServer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxEnableSsl;
        private System.Windows.Forms.Button buttonSetEmail;
        private System.Windows.Forms.Button buttonGetEmail;
        private System.Windows.Forms.GroupBox groupBoxDevice;
        private System.Windows.Forms.Button buttonGetDevice;
        private System.Windows.Forms.TextBox textBoxSpaceLeft;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxTotalSpace;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxMemoryLeft;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxTotalMemory;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxProcessorCount;
        private System.Windows.Forms.Label label16;
    }
}