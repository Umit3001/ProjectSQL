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
            this.AddIncendentPanel = new System.Windows.Forms.Panel();
            this.submitTicketButtonInIncidentPanel = new System.Windows.Forms.Button();
            this.cancelButtonInIncidentPanel = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.deadlineComboBox = new System.Windows.Forms.ComboBox();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.reportedByUserTextBox = new System.Windows.Forms.TextBox();
            this.typeOfIncidentComboBox = new System.Windows.Forms.ComboBox();
            this.subjectOfIncidentTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabelInIncidentPanel = new System.Windows.Forms.Label();
            this.deadlineLabelInIncidentLabel = new System.Windows.Forms.Label();
            this.priorityLabelInIncididentPanel = new System.Windows.Forms.Label();
            this.reportedByUserInIncidentPanel = new System.Windows.Forms.Label();
            this.typeOfIncidentLabelInIncidentLabel = new System.Windows.Forms.Label();
            this.subjectOfIncidentLabelInIncidentPanel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeePanelBackButton = new System.Windows.Forms.Button();
            this.UserManagementPanel = new System.Windows.Forms.Panel();
            this.UserListView = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.EmployeeName = new System.Windows.Forms.ColumnHeader();
            this.Tickets = new System.Windows.Forms.ColumnHeader();
            this.AddNewUserButtonUserManagement = new System.Windows.Forms.Button();
            this.FilterByEmailLabelUserManagement = new System.Windows.Forms.Label();
            this.FilterByEmailTextBoxUserManagement = new System.Windows.Forms.TextBox();
            this.TitleUserManagementPanel = new System.Windows.Forms.Label();
            this.ServicedeskPanelBackButton = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.RememberMeCheckBoxLoginPanel = new System.Windows.Forms.CheckBox();
            this.TitleDetailLoginPanel = new System.Windows.Forms.Label();
            this.TitleLoginPanel = new System.Windows.Forms.Label();
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
            this.CreateNewUserPanel = new System.Windows.Forms.Panel();
            this.AddIncendentPanel.SuspendLayout();
            this.UserManagementPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPanelLogo)).BeginInit();
            this.NavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddIncendentPanel
            // 
            this.AddIncendentPanel.Controls.Add(this.submitTicketButtonInIncidentPanel);
            this.AddIncendentPanel.Controls.Add(this.cancelButtonInIncidentPanel);
            this.AddIncendentPanel.Controls.Add(this.descriptionTextBox);
            this.AddIncendentPanel.Controls.Add(this.deadlineComboBox);
            this.AddIncendentPanel.Controls.Add(this.priorityComboBox);
            this.AddIncendentPanel.Controls.Add(this.reportedByUserTextBox);
            this.AddIncendentPanel.Controls.Add(this.typeOfIncidentComboBox);
            this.AddIncendentPanel.Controls.Add(this.subjectOfIncidentTextBox);
            this.AddIncendentPanel.Controls.Add(this.descriptionLabelInIncidentPanel);
            this.AddIncendentPanel.Controls.Add(this.deadlineLabelInIncidentLabel);
            this.AddIncendentPanel.Controls.Add(this.priorityLabelInIncididentPanel);
            this.AddIncendentPanel.Controls.Add(this.reportedByUserInIncidentPanel);
            this.AddIncendentPanel.Controls.Add(this.typeOfIncidentLabelInIncidentLabel);
            this.AddIncendentPanel.Controls.Add(this.subjectOfIncidentLabelInIncidentPanel);
            this.AddIncendentPanel.Controls.Add(this.label1);
            this.AddIncendentPanel.Controls.Add(this.EmployeePanelBackButton);
            this.AddIncendentPanel.Location = new System.Drawing.Point(3, 188);
            this.AddIncendentPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddIncendentPanel.Name = "AddIncendentPanel";
            this.AddIncendentPanel.Size = new System.Drawing.Size(962, 583);
            this.AddIncendentPanel.TabIndex = 1;
            // 
            // submitTicketButtonInIncidentPanel
            // 
            this.submitTicketButtonInIncidentPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.submitTicketButtonInIncidentPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitTicketButtonInIncidentPanel.Location = new System.Drawing.Point(504, 377);
            this.submitTicketButtonInIncidentPanel.Name = "submitTicketButtonInIncidentPanel";
            this.submitTicketButtonInIncidentPanel.Size = new System.Drawing.Size(127, 51);
            this.submitTicketButtonInIncidentPanel.TabIndex = 27;
            this.submitTicketButtonInIncidentPanel.Text = "Submit ticket";
            this.submitTicketButtonInIncidentPanel.UseVisualStyleBackColor = false;
            this.submitTicketButtonInIncidentPanel.Click += new System.EventHandler(this.submitTicketButtonInIncidentPanel_Click);
            // 
            // cancelButtonInIncidentPanel
            // 
            this.cancelButtonInIncidentPanel.Location = new System.Drawing.Point(324, 377);
            this.cancelButtonInIncidentPanel.Name = "cancelButtonInIncidentPanel";
            this.cancelButtonInIncidentPanel.Size = new System.Drawing.Size(127, 51);
            this.cancelButtonInIncidentPanel.TabIndex = 26;
            this.cancelButtonInIncidentPanel.Text = "Cancel";
            this.cancelButtonInIncidentPanel.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(311, 317);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(319, 27);
            this.descriptionTextBox.TabIndex = 25;
            // 
            // deadlineComboBox
            // 
            this.deadlineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deadlineComboBox.FormattingEnabled = true;
            this.deadlineComboBox.Items.AddRange(new object[] {
            "1 hour",
            "3 hour",
            "1 day",
            "2 days",
            "3 days",
            "4 days",
            "5 days",
            "6 days",
            "1 week",
            "2 weeks"});
            this.deadlineComboBox.Location = new System.Drawing.Point(311, 276);
            this.deadlineComboBox.Name = "deadlineComboBox";
            this.deadlineComboBox.Size = new System.Drawing.Size(319, 28);
            this.deadlineComboBox.TabIndex = 24;
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Items.AddRange(new object[] {
            "High",
            "Normal",
            "Low"});
            this.priorityComboBox.Location = new System.Drawing.Point(311, 233);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(319, 28);
            this.priorityComboBox.TabIndex = 23;
            // 
            // reportedByUserTextBox
            // 
            this.reportedByUserTextBox.Location = new System.Drawing.Point(311, 193);
            this.reportedByUserTextBox.Name = "reportedByUserTextBox";
            this.reportedByUserTextBox.Size = new System.Drawing.Size(319, 27);
            this.reportedByUserTextBox.TabIndex = 22;
            // 
            // typeOfIncidentComboBox
            // 
            this.typeOfIncidentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfIncidentComboBox.FormattingEnabled = true;
            this.typeOfIncidentComboBox.Items.AddRange(new object[] {
            "ServiceInterruption",
            "ServiceDegradation",
            "Hardware",
            "Software",
            "Security",
            "Network",
            "UserRelated",
            "ChangeRelated"});
            this.typeOfIncidentComboBox.Location = new System.Drawing.Point(311, 157);
            this.typeOfIncidentComboBox.Name = "typeOfIncidentComboBox";
            this.typeOfIncidentComboBox.Size = new System.Drawing.Size(319, 28);
            this.typeOfIncidentComboBox.TabIndex = 21;
            // 
            // subjectOfIncidentTextBox
            // 
            this.subjectOfIncidentTextBox.Location = new System.Drawing.Point(311, 116);
            this.subjectOfIncidentTextBox.Name = "subjectOfIncidentTextBox";
            this.subjectOfIncidentTextBox.Size = new System.Drawing.Size(319, 27);
            this.subjectOfIncidentTextBox.TabIndex = 20;
            // 
            // descriptionLabelInIncidentPanel
            // 
            this.descriptionLabelInIncidentPanel.AutoSize = true;
            this.descriptionLabelInIncidentPanel.Location = new System.Drawing.Point(136, 324);
            this.descriptionLabelInIncidentPanel.Name = "descriptionLabelInIncidentPanel";
            this.descriptionLabelInIncidentPanel.Size = new System.Drawing.Size(88, 20);
            this.descriptionLabelInIncidentPanel.TabIndex = 19;
            this.descriptionLabelInIncidentPanel.Text = "Description:";
            // 
            // deadlineLabelInIncidentLabel
            // 
            this.deadlineLabelInIncidentLabel.AutoSize = true;
            this.deadlineLabelInIncidentLabel.Location = new System.Drawing.Point(136, 284);
            this.deadlineLabelInIncidentLabel.Name = "deadlineLabelInIncidentLabel";
            this.deadlineLabelInIncidentLabel.Size = new System.Drawing.Size(141, 20);
            this.deadlineLabelInIncidentLabel.TabIndex = 18;
            this.deadlineLabelInIncidentLabel.Text = "Deadline/follow up:";
            // 
            // priorityLabelInIncididentPanel
            // 
            this.priorityLabelInIncididentPanel.AutoSize = true;
            this.priorityLabelInIncididentPanel.Location = new System.Drawing.Point(136, 241);
            this.priorityLabelInIncididentPanel.Name = "priorityLabelInIncididentPanel";
            this.priorityLabelInIncididentPanel.Size = new System.Drawing.Size(59, 20);
            this.priorityLabelInIncididentPanel.TabIndex = 17;
            this.priorityLabelInIncididentPanel.Text = "Priority:";
            // 
            // reportedByUserInIncidentPanel
            // 
            this.reportedByUserInIncidentPanel.AutoSize = true;
            this.reportedByUserInIncidentPanel.Location = new System.Drawing.Point(136, 200);
            this.reportedByUserInIncidentPanel.Name = "reportedByUserInIncidentPanel";
            this.reportedByUserInIncidentPanel.Size = new System.Drawing.Size(125, 20);
            this.reportedByUserInIncidentPanel.TabIndex = 16;
            this.reportedByUserInIncidentPanel.Text = "Reported by user:";
            // 
            // typeOfIncidentLabelInIncidentLabel
            // 
            this.typeOfIncidentLabelInIncidentLabel.AutoSize = true;
            this.typeOfIncidentLabelInIncidentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeOfIncidentLabelInIncidentLabel.Location = new System.Drawing.Point(136, 165);
            this.typeOfIncidentLabelInIncidentLabel.Name = "typeOfIncidentLabelInIncidentLabel";
            this.typeOfIncidentLabelInIncidentLabel.Size = new System.Drawing.Size(118, 20);
            this.typeOfIncidentLabelInIncidentLabel.TabIndex = 15;
            this.typeOfIncidentLabelInIncidentLabel.Text = "Type of incident:";
            // 
            // subjectOfIncidentLabelInIncidentPanel
            // 
            this.subjectOfIncidentLabelInIncidentPanel.AutoSize = true;
            this.subjectOfIncidentLabelInIncidentPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subjectOfIncidentLabelInIncidentPanel.Location = new System.Drawing.Point(136, 123);
            this.subjectOfIncidentLabelInIncidentPanel.Name = "subjectOfIncidentLabelInIncidentPanel";
            this.subjectOfIncidentLabelInIncidentPanel.Size = new System.Drawing.Size(136, 20);
            this.subjectOfIncidentLabelInIncidentPanel.TabIndex = 14;
            this.subjectOfIncidentLabelInIncidentPanel.Text = "Subject of incident:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Create new incident ticket";
            // 
            // EmployeePanelBackButton
            // 
            this.EmployeePanelBackButton.Location = new System.Drawing.Point(9, 496);
            this.EmployeePanelBackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeePanelBackButton.Name = "EmployeePanelBackButton";
            this.EmployeePanelBackButton.Size = new System.Drawing.Size(107, 37);
            this.EmployeePanelBackButton.TabIndex = 9;
            this.EmployeePanelBackButton.Text = "Back";
            this.EmployeePanelBackButton.UseVisualStyleBackColor = true;
            this.EmployeePanelBackButton.Click += new System.EventHandler(this.EmployeePanelBackButton_Click);
            // 
            // UserManagementPanel
            // 
            this.UserManagementPanel.Controls.Add(this.UserListView);
            this.UserManagementPanel.Controls.Add(this.AddNewUserButtonUserManagement);
            this.UserManagementPanel.Controls.Add(this.FilterByEmailLabelUserManagement);
            this.UserManagementPanel.Controls.Add(this.FilterByEmailTextBoxUserManagement);
            this.UserManagementPanel.Controls.Add(this.TitleUserManagementPanel);
            this.UserManagementPanel.Controls.Add(this.ServicedeskPanelBackButton);
            this.UserManagementPanel.Location = new System.Drawing.Point(3, 192);
            this.UserManagementPanel.Name = "UserManagementPanel";
            this.UserManagementPanel.Size = new System.Drawing.Size(962, 576);
            this.UserManagementPanel.TabIndex = 1;
            // 
            // UserListView
            // 
            this.UserListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Email,
            this.EmployeeName,
            this.Tickets});
            this.UserListView.Location = new System.Drawing.Point(115, 132);
            this.UserListView.Name = "UserListView";
            this.UserListView.Size = new System.Drawing.Size(761, 412);
            this.UserListView.TabIndex = 6;
            this.UserListView.UseCompatibleStateImageBehavior = false;
            this.UserListView.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 120;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 250;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Text = "Name";
            this.EmployeeName.Width = 200;
            // 
            // Tickets
            // 
            this.Tickets.Text = "#Tickets";
            this.Tickets.Width = 75;
            // 
            // AddNewUserButtonUserManagement
            // 
            this.AddNewUserButtonUserManagement.BackColor = System.Drawing.Color.Lime;
            this.AddNewUserButtonUserManagement.Location = new System.Drawing.Point(741, 61);
            this.AddNewUserButtonUserManagement.Name = "AddNewUserButtonUserManagement";
            this.AddNewUserButtonUserManagement.Size = new System.Drawing.Size(136, 43);
            this.AddNewUserButtonUserManagement.TabIndex = 5;
            this.AddNewUserButtonUserManagement.Text = "+ADD NEW USER";
            this.AddNewUserButtonUserManagement.UseVisualStyleBackColor = false;
            this.AddNewUserButtonUserManagement.Click += new System.EventHandler(this.AddNewUserButtonUserManagement_Click);
            // 
            // FilterByEmailLabelUserManagement
            // 
            this.FilterByEmailLabelUserManagement.AutoSize = true;
            this.FilterByEmailLabelUserManagement.Location = new System.Drawing.Point(112, 71);
            this.FilterByEmailLabelUserManagement.Name = "FilterByEmailLabelUserManagement";
            this.FilterByEmailLabelUserManagement.Size = new System.Drawing.Size(110, 20);
            this.FilterByEmailLabelUserManagement.TabIndex = 4;
            this.FilterByEmailLabelUserManagement.Text = "Filter by email: ";
            // 
            // FilterByEmailTextBoxUserManagement
            // 
            this.FilterByEmailTextBoxUserManagement.Location = new System.Drawing.Point(223, 67);
            this.FilterByEmailTextBoxUserManagement.Name = "FilterByEmailTextBoxUserManagement";
            this.FilterByEmailTextBoxUserManagement.Size = new System.Drawing.Size(191, 27);
            this.FilterByEmailTextBoxUserManagement.TabIndex = 3;
            this.FilterByEmailTextBoxUserManagement.TextChanged += new System.EventHandler(this.FilterByEmailTextBoxUserManagement_TextChanged);
            // 
            // TitleUserManagementPanel
            // 
            this.TitleUserManagementPanel.AutoSize = true;
            this.TitleUserManagementPanel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleUserManagementPanel.Location = new System.Drawing.Point(115, 11);
            this.TitleUserManagementPanel.Name = "TitleUserManagementPanel";
            this.TitleUserManagementPanel.Size = new System.Drawing.Size(276, 41);
            this.TitleUserManagementPanel.TabIndex = 2;
            this.TitleUserManagementPanel.Text = "User Management";
            // 
            // ServicedeskPanelBackButton
            // 
            this.ServicedeskPanelBackButton.Location = new System.Drawing.Point(16, 505);
            this.ServicedeskPanelBackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServicedeskPanelBackButton.Name = "ServicedeskPanelBackButton";
            this.ServicedeskPanelBackButton.Size = new System.Drawing.Size(81, 40);
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
            this.LoginPanel.Location = new System.Drawing.Point(1, 3);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(966, 767);
            this.LoginPanel.TabIndex = 4;
            // 
            // RememberMeCheckBoxLoginPanel
            // 
            this.RememberMeCheckBoxLoginPanel.AutoSize = true;
            this.RememberMeCheckBoxLoginPanel.Location = new System.Drawing.Point(456, 439);
            this.RememberMeCheckBoxLoginPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RememberMeCheckBoxLoginPanel.Name = "RememberMeCheckBoxLoginPanel";
            this.RememberMeCheckBoxLoginPanel.Size = new System.Drawing.Size(129, 24);
            this.RememberMeCheckBoxLoginPanel.TabIndex = 11;
            this.RememberMeCheckBoxLoginPanel.Text = "Remember me";
            this.RememberMeCheckBoxLoginPanel.UseVisualStyleBackColor = true;
            // 
            // TitleDetailLoginPanel
            // 
            this.TitleDetailLoginPanel.AutoSize = true;
            this.TitleDetailLoginPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TitleDetailLoginPanel.Location = new System.Drawing.Point(409, 223);
            this.TitleDetailLoginPanel.Name = "TitleDetailLoginPanel";
            this.TitleDetailLoginPanel.Size = new System.Drawing.Size(335, 50);
            this.TitleDetailLoginPanel.TabIndex = 10;
            this.TitleDetailLoginPanel.Text = "Please provide login credentials to login\r\nto NoDesk The Garden Group";
            this.TitleDetailLoginPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleLoginPanel
            // 
            this.TitleLoginPanel.AutoSize = true;
            this.TitleLoginPanel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLoginPanel.Location = new System.Drawing.Point(441, 148);
            this.TitleLoginPanel.Name = "TitleLoginPanel";
            this.TitleLoginPanel.Size = new System.Drawing.Size(252, 50);
            this.TitleLoginPanel.TabIndex = 9;
            this.TitleLoginPanel.Text = "NoDesk: TGG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.TheGardenGroupLogo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPanelUsernameTextBox
            // 
            this.LoginPanelUsernameTextBox.Location = new System.Drawing.Point(456, 311);
            this.LoginPanelUsernameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginPanelUsernameTextBox.Name = "LoginPanelUsernameTextBox";
            this.LoginPanelUsernameTextBox.Size = new System.Drawing.Size(212, 27);
            this.LoginPanelUsernameTextBox.TabIndex = 7;
            // 
            // LoginPanelPasswordTextBox
            // 
            this.LoginPanelPasswordTextBox.Location = new System.Drawing.Point(456, 380);
            this.LoginPanelPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginPanelPasswordTextBox.Name = "LoginPanelPasswordTextBox";
            this.LoginPanelPasswordTextBox.PasswordChar = '*';
            this.LoginPanelPasswordTextBox.Size = new System.Drawing.Size(212, 27);
            this.LoginPanelPasswordTextBox.TabIndex = 6;
            // 
            // LoginPanelLoginButton
            // 
            this.LoginPanelLoginButton.Location = new System.Drawing.Point(456, 571);
            this.LoginPanelLoginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginPanelLoginButton.Name = "LoginPanelLoginButton";
            this.LoginPanelLoginButton.Size = new System.Drawing.Size(130, 52);
            this.LoginPanelLoginButton.TabIndex = 5;
            this.LoginPanelLoginButton.Text = "Log in";
            this.LoginPanelLoginButton.UseVisualStyleBackColor = true;
            this.LoginPanelLoginButton.Click += new System.EventHandler(this.LoginPanelLoginButton_Click);
            // 
            // LoginPanelPasswordLabel
            // 
            this.LoginPanelPasswordLabel.AutoSize = true;
            this.LoginPanelPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginPanelPasswordLabel.Location = new System.Drawing.Point(314, 377);
            this.LoginPanelPasswordLabel.Name = "LoginPanelPasswordLabel";
            this.LoginPanelPasswordLabel.Size = new System.Drawing.Size(106, 28);
            this.LoginPanelPasswordLabel.TabIndex = 4;
            this.LoginPanelPasswordLabel.Text = "Password:";
            // 
            // LoginPanelUsernameLabel
            // 
            this.LoginPanelUsernameLabel.AutoSize = true;
            this.LoginPanelUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginPanelUsernameLabel.Location = new System.Drawing.Point(314, 307);
            this.LoginPanelUsernameLabel.Name = "LoginPanelUsernameLabel";
            this.LoginPanelUsernameLabel.Size = new System.Drawing.Size(111, 28);
            this.LoginPanelUsernameLabel.TabIndex = 3;
            this.LoginPanelUsernameLabel.Text = "Username:";
            // 
            // LoginPanelLogo
            // 
            this.LoginPanelLogo.Image = global::UI.Properties.Resources.TheGardenGroupLogo;
            this.LoginPanelLogo.Location = new System.Drawing.Point(13, 7);
            this.LoginPanelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginPanelLogo.Name = "LoginPanelLogo";
            this.LoginPanelLogo.Size = new System.Drawing.Size(319, 121);
            this.LoginPanelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPanelLogo.TabIndex = 1;
            this.LoginPanelLogo.TabStop = false;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.White;
            this.NavigationPanel.Controls.Add(this.TitleDetailNavigationPanel);
            this.NavigationPanel.Controls.Add(this.TitleNavigationPanel);
            this.NavigationPanel.Controls.Add(this.UserManagementButtonNavigationPanel);
            this.NavigationPanel.Controls.Add(this.IncidentManagementButtonNavigationPanel);
            this.NavigationPanel.Controls.Add(this.DashboardButtonNavigationPanel);
            this.NavigationPanel.Controls.Add(this.LoginPanelLogo);
            this.NavigationPanel.Controls.Add(this.AddIncendentPanel);
            this.NavigationPanel.Controls.Add(this.UserManagementPanel);
            this.NavigationPanel.Controls.Add(this.CreateNewUserPanel);
            this.NavigationPanel.Location = new System.Drawing.Point(1, -1);
            this.NavigationPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(966, 771);
            this.NavigationPanel.TabIndex = 5;
            // 
            // TitleDetailNavigationPanel
            // 
            this.TitleDetailNavigationPanel.AutoSize = true;
            this.TitleDetailNavigationPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TitleDetailNavigationPanel.Location = new System.Drawing.Point(560, 84);
            this.TitleDetailNavigationPanel.Name = "TitleDetailNavigationPanel";
            this.TitleDetailNavigationPanel.Size = new System.Drawing.Size(334, 32);
            this.TitleDetailNavigationPanel.TabIndex = 5;
            this.TitleDetailNavigationPanel.Text = "Licensed to: The Garden Group";
            // 
            // TitleNavigationPanel
            // 
            this.TitleNavigationPanel.AutoSize = true;
            this.TitleNavigationPanel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleNavigationPanel.Location = new System.Drawing.Point(679, 17);
            this.TitleNavigationPanel.Name = "TitleNavigationPanel";
            this.TitleNavigationPanel.Size = new System.Drawing.Size(200, 62);
            this.TitleNavigationPanel.TabIndex = 3;
            this.TitleNavigationPanel.Text = "NoDesk";
            // 
            // UserManagementButtonNavigationPanel
            // 
            this.UserManagementButtonNavigationPanel.BackColor = System.Drawing.Color.White;
            this.UserManagementButtonNavigationPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserManagementButtonNavigationPanel.Location = new System.Drawing.Point(659, 136);
            this.UserManagementButtonNavigationPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserManagementButtonNavigationPanel.Name = "UserManagementButtonNavigationPanel";
            this.UserManagementButtonNavigationPanel.Size = new System.Drawing.Size(200, 44);
            this.UserManagementButtonNavigationPanel.TabIndex = 2;
            this.UserManagementButtonNavigationPanel.Text = "User Management";
            this.UserManagementButtonNavigationPanel.UseVisualStyleBackColor = false;
            this.UserManagementButtonNavigationPanel.Click += new System.EventHandler(this.UserManagementButtonNavigationPanel_Click);
            // 
            // IncidentManagementButtonNavigationPanel
            // 
            this.IncidentManagementButtonNavigationPanel.BackColor = System.Drawing.Color.White;
            this.IncidentManagementButtonNavigationPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IncidentManagementButtonNavigationPanel.Location = new System.Drawing.Point(399, 136);
            this.IncidentManagementButtonNavigationPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IncidentManagementButtonNavigationPanel.Name = "IncidentManagementButtonNavigationPanel";
            this.IncidentManagementButtonNavigationPanel.Size = new System.Drawing.Size(200, 44);
            this.IncidentManagementButtonNavigationPanel.TabIndex = 1;
            this.IncidentManagementButtonNavigationPanel.Text = "Incident Management";
            this.IncidentManagementButtonNavigationPanel.UseVisualStyleBackColor = false;
            this.IncidentManagementButtonNavigationPanel.Click += new System.EventHandler(this.IncidentManagementButtonNavigationPanel_Click);
            // 
            // DashboardButtonNavigationPanel
            // 
            this.DashboardButtonNavigationPanel.BackColor = System.Drawing.Color.White;
            this.DashboardButtonNavigationPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashboardButtonNavigationPanel.Location = new System.Drawing.Point(131, 136);
            this.DashboardButtonNavigationPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DashboardButtonNavigationPanel.Name = "DashboardButtonNavigationPanel";
            this.DashboardButtonNavigationPanel.Size = new System.Drawing.Size(200, 44);
            this.DashboardButtonNavigationPanel.TabIndex = 0;
            this.DashboardButtonNavigationPanel.Text = "Dashboard";
            this.DashboardButtonNavigationPanel.UseVisualStyleBackColor = false;
            // 
            // CreateNewUserPanel
            // 
            this.CreateNewUserPanel.Location = new System.Drawing.Point(5, 188);
            this.CreateNewUserPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateNewUserPanel.Name = "CreateNewUserPanel";
            this.CreateNewUserPanel.Size = new System.Drawing.Size(961, 576);
            this.CreateNewUserPanel.TabIndex = 6;
            // 
            // NoSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 764);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.LoginPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NoSQL";
            this.Text = "NoSQL-Project";
            this.AddIncendentPanel.ResumeLayout(false);
            this.AddIncendentPanel.PerformLayout();
            this.UserManagementPanel.ResumeLayout(false);
            this.UserManagementPanel.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPanelLogo)).EndInit();
            this.NavigationPanel.ResumeLayout(false);
            this.NavigationPanel.PerformLayout();
            this.ResumeLayout(false);

            }
             #endregion
     
        private Panel AddIncendentPanel;
        private Panel LoginPanel;
        private Panel UserManagementPanel;
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
        private Label label1;
        private Label descriptionLabelInIncidentPanel;
        private Label deadlineLabelInIncidentLabel;
        private Label priorityLabelInIncididentPanel;
        private Label reportedByUserInIncidentPanel;
        private Label typeOfIncidentLabelInIncidentLabel;
        private Label subjectOfIncidentLabelInIncidentPanel;
        private TextBox subjectOfIncidentTextBox;
        private Button submitTicketButtonInIncidentPanel;
        private Button cancelButtonInIncidentPanel;
        private TextBox descriptionTextBox;
        private ComboBox deadlineComboBox;
        private ComboBox priorityComboBox;
        private TextBox reportedByUserTextBox;
        private ComboBox typeOfIncidentComboBox;
        private Button button1;
        private CheckBox RememberMeCheckBoxLoginPanel;
        private Label TitleDetailLoginPanel;
        private Label TitleLoginPanel;
        private ListView UserListView;
        private Button AddNewUserButtonUserManagement;
        private Label FilterByEmailLabelUserManagement;
        private TextBox FilterByEmailTextBoxUserManagement;
        private Label TitleUserManagementPanel;
        private ColumnHeader Id;
        private ColumnHeader Email;
        private ColumnHeader EmployeeName;
        private ColumnHeader Tickets;
        private Panel CreateNewUserPanel;
    }
}