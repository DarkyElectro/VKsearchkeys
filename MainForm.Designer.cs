namespace VkAPITutorial
{
    partial class MainForm
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
            this.User_Photo = new System.Windows.Forms.PictureBox();
            this.Label_User_Name = new System.Windows.Forms.Label();
            this.Label_User_Surname = new System.Windows.Forms.Label();
            this.Label_User_UserID = new System.Windows.Forms.Label();
            this.User_ID = new System.Windows.Forms.TextBox();
            this.User_Name = new System.Windows.Forms.Label();
            this.User_Surname = new System.Windows.Forms.Label();
            this.Button_GetToken = new System.Windows.Forms.Button();
            this.Button_GetInformation = new System.Windows.Forms.Button();
            this.button_Test = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.labelinfocheck = new System.Windows.Forms.Label();
            this.label_checked = new System.Windows.Forms.Label();
            this.label_groupinfo = new System.Windows.Forms.Label();
            this.checkBox_group = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.User_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // User_Photo
            // 
            this.User_Photo.Location = new System.Drawing.Point(13, 13);
            this.User_Photo.Name = "User_Photo";
            this.User_Photo.Size = new System.Drawing.Size(199, 197);
            this.User_Photo.TabIndex = 0;
            this.User_Photo.TabStop = false;
            // 
            // Label_User_Name
            // 
            this.Label_User_Name.AutoSize = true;
            this.Label_User_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_User_Name.Location = new System.Drawing.Point(219, 30);
            this.Label_User_Name.Name = "Label_User_Name";
            this.Label_User_Name.Size = new System.Drawing.Size(44, 20);
            this.Label_User_Name.TabIndex = 1;
            this.Label_User_Name.Text = "Имя:";
            // 
            // Label_User_Surname
            // 
            this.Label_User_Surname.AutoSize = true;
            this.Label_User_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_User_Surname.Location = new System.Drawing.Point(219, 50);
            this.Label_User_Surname.Name = "Label_User_Surname";
            this.Label_User_Surname.Size = new System.Drawing.Size(85, 20);
            this.Label_User_Surname.TabIndex = 2;
            this.Label_User_Surname.Text = "Фамилия:";
            // 
            // Label_User_UserID
            // 
            this.Label_User_UserID.AutoSize = true;
            this.Label_User_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_User_UserID.Location = new System.Drawing.Point(411, 13);
            this.Label_User_UserID.Name = "Label_User_UserID";
            this.Label_User_UserID.Size = new System.Drawing.Size(64, 20);
            this.Label_User_UserID.TabIndex = 5;
            this.Label_User_UserID.Text = "UserID:";
            // 
            // User_ID
            // 
            this.User_ID.Location = new System.Drawing.Point(481, 13);
            this.User_ID.Name = "User_ID";
            this.User_ID.Size = new System.Drawing.Size(100, 20);
            this.User_ID.TabIndex = 7;
            // 
            // User_Name
            // 
            this.User_Name.AutoSize = true;
            this.User_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_Name.Location = new System.Drawing.Point(300, 30);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(45, 20);
            this.User_Name.TabIndex = 8;
            this.User_Name.Text = "none";
            // 
            // User_Surname
            // 
            this.User_Surname.AutoSize = true;
            this.User_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_Surname.Location = new System.Drawing.Point(300, 50);
            this.User_Surname.Name = "User_Surname";
            this.User_Surname.Size = new System.Drawing.Size(45, 20);
            this.User_Surname.TabIndex = 11;
            this.User_Surname.Text = "none";
            // 
            // Button_GetToken
            // 
            this.Button_GetToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_GetToken.Location = new System.Drawing.Point(223, 96);
            this.Button_GetToken.Name = "Button_GetToken";
            this.Button_GetToken.Size = new System.Drawing.Size(153, 36);
            this.Button_GetToken.TabIndex = 12;
            this.Button_GetToken.Text = "Получить токен";
            this.Button_GetToken.UseVisualStyleBackColor = true;
            this.Button_GetToken.Click += new System.EventHandler(this.Button_GetToken_Click_1);
            // 
            // Button_GetInformation
            // 
            this.Button_GetInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_GetInformation.Location = new System.Drawing.Point(415, 39);
            this.Button_GetInformation.Name = "Button_GetInformation";
            this.Button_GetInformation.Size = new System.Drawing.Size(141, 36);
            this.Button_GetInformation.TabIndex = 13;
            this.Button_GetInformation.Text = "Get information";
            this.Button_GetInformation.UseVisualStyleBackColor = true;
            this.Button_GetInformation.Click += new System.EventHandler(this.Button_GetInformation_Click_1);
            // 
            // button_Test
            // 
            this.button_Test.Location = new System.Drawing.Point(576, 47);
            this.button_Test.Name = "button_Test";
            this.button_Test.Size = new System.Drawing.Size(75, 23);
            this.button_Test.TabIndex = 14;
            this.button_Test.Text = "Test";
            this.button_Test.UseVisualStyleBackColor = true;
            this.button_Test.Click += new System.EventHandler(this.button_Test_Click);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(576, 96);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 15;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // labelinfocheck
            // 
            this.labelinfocheck.AutoSize = true;
            this.labelinfocheck.Location = new System.Drawing.Point(223, 14);
            this.labelinfocheck.Name = "labelinfocheck";
            this.labelinfocheck.Size = new System.Drawing.Size(75, 13);
            this.labelinfocheck.TabIndex = 16;
            this.labelinfocheck.Text = "На проверке:";
            // 
            // label_checked
            // 
            this.label_checked.AutoSize = true;
            this.label_checked.Location = new System.Drawing.Point(226, 139);
            this.label_checked.Name = "label_checked";
            this.label_checked.Size = new System.Drawing.Size(75, 13);
            this.label_checked.TabIndex = 17;
            this.label_checked.Text = "Проверено: 0";
            // 
            // label_groupinfo
            // 
            this.label_groupinfo.AutoSize = true;
            this.label_groupinfo.Location = new System.Drawing.Point(504, 159);
            this.label_groupinfo.Name = "label_groupinfo";
            this.label_groupinfo.Size = new System.Drawing.Size(106, 13);
            this.label_groupinfo.TabIndex = 18;
            this.label_groupinfo.Text = "Проверено групп: 0";
            // 
            // checkBox_group
            // 
            this.checkBox_group.AutoSize = true;
            this.checkBox_group.Location = new System.Drawing.Point(507, 139);
            this.checkBox_group.Name = "checkBox_group";
            this.checkBox_group.Size = new System.Drawing.Size(107, 17);
            this.checkBox_group.TabIndex = 19;
            this.checkBox_group.Text = "Проверка групп";
            this.checkBox_group.UseVisualStyleBackColor = true;
            this.checkBox_group.CheckedChanged += new System.EventHandler(this.checkBox_group_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 318);
            this.Controls.Add(this.checkBox_group);
            this.Controls.Add(this.label_groupinfo);
            this.Controls.Add(this.label_checked);
            this.Controls.Add(this.labelinfocheck);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_Test);
            this.Controls.Add(this.Button_GetInformation);
            this.Controls.Add(this.Button_GetToken);
            this.Controls.Add(this.User_Surname);
            this.Controls.Add(this.User_Name);
            this.Controls.Add(this.User_ID);
            this.Controls.Add(this.Label_User_UserID);
            this.Controls.Add(this.Label_User_Surname);
            this.Controls.Add(this.Label_User_Name);
            this.Controls.Add(this.User_Photo);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.User_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox User_Photo;
        private System.Windows.Forms.Label Label_User_Name;
        private System.Windows.Forms.Label Label_User_Surname;
        private System.Windows.Forms.Label Label_User_UserID;
        private System.Windows.Forms.TextBox User_ID;
        private System.Windows.Forms.Label User_Name;
        private System.Windows.Forms.Label User_Surname;
        private System.Windows.Forms.Button Button_GetToken;
        private System.Windows.Forms.Button Button_GetInformation;
        private System.Windows.Forms.Button button_Test;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label labelinfocheck;
        private System.Windows.Forms.Label label_checked;
        private System.Windows.Forms.Label label_groupinfo;
        private System.Windows.Forms.CheckBox checkBox_group;
    }
}