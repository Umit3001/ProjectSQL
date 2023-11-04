namespace UI
{
    partial class NoSQL
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AllTickets = new System.Windows.Forms.ListBox();
            this.EmployeePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.EmployeePanelBackButton = new System.Windows.Forms.Button();
            this.ServicedeskPanel = new System.Windows.Forms.Panel();
            this.ServicedeskPanelBackButton = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginPanelUsernameTextBox = new System.Windows.Forms.TextBox();
            this.LoginPanelPasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginPanelLoginButton = new System.Windows.Forms.Button();
            this.LoginPanelPasswordLabel = new System.Windows.Forms.Label();
            this.LoginPanelUsernameLabel = new System.Windows.Forms.Label();
            this.LoginPanelLogo = new System.Windows.Forms.PictureBox();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.TitleDetailNavigationPanel = new System.Windows.Forms.Label();
            this.TitleNavigationPanel = new System.Windows.Forms.Label();
            this.UserManagementButtonNavigationPanel = new System.Windows.Forms.Button();
            this.IncidentManagementButtonNavigationPanel = new System.Windows.Forms.Button();
            this.DashboardButtonNavigationPanel = new System.Windows.Forms.Button();
            this.TitleLoginPanel = new System.Windows.Forms.Label();
            this.TitleDetailLoginPanel = new System.Windows.Forms.Label();
            this.RememberMeCheckBoxLoginPanel = new System.Windows.Forms.CheckBox();
            this.EmployeePanel.SuspendLayout();
            this.ServicedeskPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPanelLogo)).BeginInit();
            this.NavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllTickets
            // 
            this.AllTickets.FormattingEnabled = true;
            this.AllTickets.ItemHeight = 15;
            this.AllTickets.Location = new System.Drawing.Point(153, 3);
            this.AllTickets.Name = "AllTickets";
            this.AllTickets.Size = new System.Drawing.Size(553, 409);
            this.AllTickets.TabIndex = 0;
            // 
            // EmployeePanel
            // 
            this.EmployeePanel.Controls.Add(this.button1);
            this.EmployeePanel.Controls.Add(this.EmployeePanelBackButton);
            this.EmployeePanel.Location = new System.Drawing.Point(0, 141);
            this.EmployeePanel.Name = "EmployeePanel";
            this.EmployeePanel.Size = new System.Drawing.Size(935, 497);
            this.EmployeePanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EmployeePanelBackButton
            // 
            this.EmployeePanelBackButton.Location = new System.Drawing.Point(92, 183);
            this.EmployeePanelBackButton.Name = "EmployeePanelBackButton";
            this.EmployeePanelBackButton.Size = new System.Drawing.Size(94, 28);
            this.EmployeePanelBackButton.TabIndex = 9;
            this.EmployeePanelBackButton.Text = "Back";
            this.EmployeePanelBackButton.UseVisualStyleBackColor = true;
            this.EmployeePanelBackButton.Click += new System.EventHandler(this.EmployeePanelBackButton_Click);
            // 
            // ServicedeskPanel
            // 
            this.ServicedeskPanel.Controls.Add(this.ServicedeskPanelBackButton);
            this.ServicedeskPanel.Controls.Add(this.AllTickets);
            this.ServicedeskPanel.Location = new System.Drawing.Point(1, 9);
            this.ServicedeskPanel.Name = "ServicedeskPanel";
            this.ServicedeskPanel.Size = new System.Drawing.Size(935, 644);
            this.ServicedeskPanel.TabIndex = 1;
            // 
            // ServicedeskPanelBackButton
            // 
            this.ServicedeskPanelBackButton.Location = new System.Drawing.Point(93, 431);
            this.ServicedeskPanelBackButton.Name = "ServicedeskPanelBackButton";
            this.ServicedeskPanelBackButton.Size = new System.Drawing.Size(93, 34);
            this.ServicedeskPanelBackButton.TabIndex = 1;
            this.ServicedeskPanelBackButton.Text = "Back";
            this.ServicedeskPanelBackButton.UseVisualStyleBackColor = true;
            this.ServicedeskPanelBackButton.Click += new System.EventHandler(this.ServicedeskPanelBackButton_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.White;
            this.LoginPanel.Controls.Add(this.RememberMeCheckBoxLoginPanel);
            this.LoginPanel.Controls.Add(this.TitleDetailLoginPanel);
            this.LoginPanel.Controls.Add(this.TitleLoginPanel);
            this.LoginPanel.Controls.Add(this.pictureBox1);
            this.LoginPanel.Controls.Add(this.LoginPanelUsernameTextBox);
            this.LoginPanel.Controls.Add(this.LoginPanelPasswordTextBox);
            this.LoginPanel.Controls.Add(this.LoginPanelLoginButton);
            this.LoginPanel.Controls.Add(this.LoginPanelPasswordLabel);
            this.LoginPanel.Controls.Add(this.LoginPanelUsernameLabel);
            this.LoginPanel.Location = new System.Drawing.Point(1, 9);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(929, 644);
            this.LoginPanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.TheGardenGroupLogo;
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPanelUsernameTextBox
            // 
            this.LoginPanelUsernameTextBox.Location = new System.Drawing.Point(399, 233);
            this.LoginPanelUsernameTextBox.Name = "LoginPanelUsernameTextBox";
            this.LoginPanelUsernameTextBox.Size = new System.Drawing.Size(186, 23);
            this.LoginPanelUsernameTextBox.TabIndex = 7;
            // 
            // LoginPanelPasswordTextBox
            // 
            this.LoginPanelPasswordTextBox.Location = new System.Drawing.Point(399, 285);
            this.LoginPanelPasswordTextBox.Name = "LoginPanelPasswordTextBox";
            this.LoginPanelPasswordTextBox.Size = new System.Drawing.Size(186, 23);
            this.LoginPanelPasswordTextBox.TabIndex = 6;
            // 
            // LoginPanelLoginButton
            // 
            this.LoginPanelLoginButton.Location = new System.Drawing.Point(443, 397);
            this.LoginPanelLoginButton.Name = "LoginPanelLoginButton";
            this.LoginPanelLoginButton.Size = new System.Drawing.Size(95, 36);
            this.LoginPanelLoginButton.TabIndex = 5;
            this.LoginPanelLoginButton.Text = "Log in";
            this.LoginPanelLoginButton.UseVisualStyleBackColor = true;
            this.LoginPanelLoginButton.Click += new System.EventHandler(this.LoginPanelLoginButton_Click);
            // 
            // LoginPanelPasswordLabel
            // 
            this.LoginPanelPasswordLabel.AutoSize = true;
            this.LoginPanelPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginPanelPasswordLabel.Location = new System.Drawing.Point(275, 283);
            this.LoginPanelPasswordLabel.Name = "LoginPanelPasswordLabel";
            this.LoginPanelPasswordLabel.Size = new System.Drawing.Size(86, 21);
            this.LoginPanelPasswordLabel.TabIndex = 4;
            this.LoginPanelPasswordLabel.Text = "Password:";
            // 
            // LoginPanelUsernameLabel
            // 
            this.LoginPanelUsernameLabel.AutoSize = true;
            this.LoginPanelUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginPanelUsernameLabel.Location = new System.Drawing.Point(275, 230);
            this.LoginPanelUsernameLabel.Name = "LoginPanelUsernameLabel";
            this.LoginPanelUsernameLabel.Size = new System.Drawing.Size(91, 21);
            this.LoginPanelUsernameLabel.TabIndex = 3;
            this.LoginPanelUsernameLabel.Text = "Username:";
            // 
            // LoginPanelLogo
            // 
            this.LoginPanelLogo.Image = global::UI.Properties.Resources.TheGardenGroupLogo;
            this.LoginPanelLogo.Location = new System.Drawing.Point(11, 5);
            this.LoginPanelLogo.Name = "LoginPanelLogo";
            this.LoginPanelLogo.Size = new System.Drawing.Size(279, 91);
            this.LoginPanelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPanelLogo.TabIndex = 1;
            this.LoginPanelLogo.TabStop = false;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.White;
            this.NavigationPanel.Controls.Add(this.EmployeePanel);
            this.NavigationPanel.Controls.Add(this.TitleDetailNavigationPanel);
            this.NavigationPanel.Controls.Add(this.TitleNavigationPanel);
            this.NavigationPanel.Controls.Add(this.UserManagementButtonNavigationPanel);
            this.NavigationPanel.Controls.Add(this.IncidentManagementButtonNavigationPanel);
            this.NavigationPanel.Controls.Add(this.DashboardButtonNavigationPanel);
            this.NavigationPanel.Controls.Add(this.LoginPanelLogo);
            this.NavigationPanel.Location = new System.Drawing.Point(1, 12);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(935, 641);
            this.NavigationPanel.TabIndex = 5;
            // 
            // TitleDetailNavigationPanel
            // 
            this.TitleDetailNavigationPanel.AutoSize = true;
            this.TitleDetailNavigationPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TitleDetailNavigationPanel.Location = new System.Drawing.Point(490, 63);
            this.TitleDetailNavigationPanel.Name = "TitleDetailNavigationPanel";
            this.TitleDetailNavigationPanel.Size = new System.Drawing.Size(262, 25);
            this.TitleDetailNavigationPanel.TabIndex = 5;
            this.TitleDetailNavigationPanel.Text = "Licensed to: The Garden Group";
            // 
            // TitleNavigationPanel
            // 
            this.TitleNavigationPanel.AutoSize = true;
            this.TitleNavigationPanel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleNavigationPanel.Location = new System.Drawing.Point(594, 13);
            this.TitleNavigationPanel.Name = "TitleNavigationPanel";
            this.TitleNavigationPanel.Size = new System.Drawing.Size(158, 50);
            this.TitleNavigationPanel.TabIndex = 3;
            this.TitleNavigationPanel.Text = "NoDesk";
            // 
            // UserManagementButtonNavigationPanel
            // 
            this.UserManagementButtonNavigationPanel.BackColor = System.Drawing.Color.White;
            this.UserManagementButtonNavigationPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserManagementButtonNavigationPanel.Location = new System.Drawing.Point(577, 102);
            this.UserManagementButtonNavigationPanel.Name = "UserManagementButtonNavigationPanel";
            this.UserManagementButtonNavigationPanel.Size = new System.Drawing.Size(175, 33);
            this.UserManagementButtonNavigationPanel.TabIndex = 2;
            this.UserManagementButtonNavigationPanel.Text = "User Management";
            this.UserManagementButtonNavigationPanel.UseVisualStyleBackColor = false;
            // 
            // IncidentManagementButtonNavigationPanel
            // 
            this.IncidentManagementButtonNavigationPanel.BackColor = System.Drawing.Color.White;
            this.IncidentManagementButtonNavigationPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IncidentManagementButtonNavigationPanel.Location = new System.Drawing.Point(349, 102);
            this.IncidentManagementButtonNavigationPanel.Name = "IncidentManagementButtonNavigationPanel";
            this.IncidentManagementButtonNavigationPanel.Size = new System.Drawing.Size(175, 33);
            this.IncidentManagementButtonNavigationPanel.TabIndex = 1;
            this.IncidentManagementButtonNavigationPanel.Text = "Incident Management";
            this.IncidentManagementButtonNavigationPanel.UseVisualStyleBackColor = false;
            // 
            // DashboardButtonNavigationPanel
            // 
            this.DashboardButtonNavigationPanel.BackColor = System.Drawing.Color.White;
            this.DashboardButtonNavigationPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashboardButtonNavigationPanel.Location = new System.Drawing.Point(115, 102);
            this.DashboardButtonNavigationPanel.Name = "DashboardButtonNavigationPanel";
            this.DashboardButtonNavigationPanel.Size = new System.Drawing.Size(175, 33);
            this.DashboardButtonNavigationPanel.TabIndex = 0;
            this.DashboardButtonNavigationPanel.Text = "Dashboard";
            this.DashboardButtonNavigationPanel.UseVisualStyleBackColor = false;
            // 
            // TitleLoginPanel
            // 
            this.TitleLoginPanel.AutoSize = true;
            this.TitleLoginPanel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLoginPanel.Location = new System.Drawing.Point(399, 105);
            this.TitleLoginPanel.Name = "TitleLoginPanel";
            this.TitleLoginPanel.Size = new System.Drawing.Size(185, 37);
            this.TitleLoginPanel.TabIndex = 9;
            this.TitleLoginPanel.Text = "NoDesk: TGG";
            // 
            // TitleDetailLoginPanel
            // 
            this.TitleDetailLoginPanel.AutoSize = true;
            this.TitleDetailLoginPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TitleDetailLoginPanel.Location = new System.Drawing.Point(349, 159);
            this.TitleDetailLoginPanel.Name = "TitleDetailLoginPanel";
            this.TitleDetailLoginPanel.Size = new System.Drawing.Size(284, 40);
            this.TitleDetailLoginPanel.TabIndex = 10;
            this.TitleDetailLoginPanel.Text = "Please provide login credentials to login to \r\nNoDesk for The Garden Group";
            this.TitleDetailLoginPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RememberMeCheckBoxLoginPanel
            // 
            this.RememberMeCheckBoxLoginPanel.AutoSize = true;
            this.RememberMeCheckBoxLoginPanel.Location = new System.Drawing.Point(399, 333);
            this.RememberMeCheckBoxLoginPanel.Name = "RememberMeCheckBoxLoginPanel";
            this.RememberMeCheckBoxLoginPanel.Size = new System.Drawing.Size(104, 19);
            this.RememberMeCheckBoxLoginPanel.TabIndex = 12;
            this.RememberMeCheckBoxLoginPanel.Text = "Remember me";
            this.RememberMeCheckBoxLoginPanel.UseVisualStyleBackColor = true;
            // 
            // NoSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 663);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.ServicedeskPanel);
            this.Controls.Add(this.NavigationPanel);
            this.Name = "NoSQL";
            this.Text = "NoSQL-Project";
            this.EmployeePanel.ResumeLayout(false);
            this.ServicedeskPanel.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPanelLogo)).EndInit();
            this.NavigationPanel.ResumeLayout(false);
            this.NavigationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox AllTickets;
        private Panel EmployeePanel;
        private Panel ServicedeskPanel;
        private Panel LoginPanel;
        private TextBox LoginPanelUsernameTextBox;
        private TextBox LoginPanelPasswordTextBox;
        private Button LoginPanelLoginButton;
        private Label LoginPanelPasswordLabel;
        private Label LoginPanelUsernameLabel;
        private PictureBox LoginPanelLogo;
        private Button ServicedeskPanelBackButton;
        private Button EmployeePanelBackButton;
        private PictureBox pictureBox1;
        private Panel NavigationPanel;
        private Label TitleDetailNavigationPanel;
        private Label TitleNavigationPanel;
        private Button UserManagementButtonNavigationPanel;
        private Button IncidentManagementButtonNavigationPanel;
        private Button DashboardButtonNavigationPanel;
        private Button button1;
        private CheckBox RememberMeCheckBoxLoginPanel;
        private Label TitleDetailLoginPanel;
        private Label TitleLoginPanel;
    }
}