using System.Windows.Forms;

namespace UI
{
    partial class NoSQL
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AddIncindentPanel = new System.Windows.Forms.Panel();
            this.StatusComboBoxAddIncidentPanel = new System.Windows.Forms.ComboBox();
            this.labelStatusAddIncidentPanel = new System.Windows.Forms.Label();
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
            this.labelIncidentTicket = new System.Windows.Forms.Label();
            this.overviewTicketsPanel = new System.Windows.Forms.Panel();
            this.TransferServiceDeskEmployeeButton = new System.Windows.Forms.Button();
            this.sortByPriorityComboBox = new System.Windows.Forms.ComboBox();
            this.sortByPriorityLabel = new System.Windows.Forms.Label();
            this.createButtonInOverviewTickets = new System.Windows.Forms.Button();
            this.closeTicketButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.overviewTicketsListView = new System.Windows.Forms.ListView();
            this.ticketId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOpened = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectOfIncident = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.createIncidentButton = new System.Windows.Forms.Button();
            this.overviewTicketsLabel = new System.Windows.Forms.Label();
            this.UserManagementPanel = new System.Windows.Forms.Panel();
            this.UserListView = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tickets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddNewUserButtonUserManagement = new System.Windows.Forms.Button();
            this.FilterByEmailLabelUserManagement = new System.Windows.Forms.Label();
            this.FilterByEmailTextBoxUserManagement = new System.Windows.Forms.TextBox();
            this.TitleUserManagementPanel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.CreateNewUserPanel = new System.Windows.Forms.Panel();
            this.PasswordTextboxCreateUserPanel = new System.Windows.Forms.TextBox();
            this.PasswordLabelCreateUserPanel = new System.Windows.Forms.Label();
            this.UsernameTextboxCreateUserPanel = new System.Windows.Forms.TextBox();
            this.UsernameLabelCreateUserPanel = new System.Windows.Forms.Label();
            this.LocationComboboxCreateUserPanel = new System.Windows.Forms.ComboBox();
            this.TypeUserComboboxCreateUserPanel = new System.Windows.Forms.ComboBox();
            this.CancelButtonCreateUserPanel = new System.Windows.Forms.Button();
            this.AddUserButtonCreateUserPanel = new System.Windows.Forms.Button();
            this.PhoneTextboxCreateUserPanel = new System.Windows.Forms.TextBox();
            this.EmailTextboxCreateUserPanel = new System.Windows.Forms.TextBox();
            this.FullNameTextboxCreateUserPanel = new System.Windows.Forms.TextBox();
            this.LocationLabelCreateUserPanel = new System.Windows.Forms.Label();
            this.PhoneLabelCreateUserPanel = new System.Windows.Forms.Label();
            this.EmailLabelCreateUserPanel = new System.Windows.Forms.Label();
            this.TypeUserLabelCreateUserPanel = new System.Windows.Forms.Label();
            this.FullNameLabelCreateUserPanel = new System.Windows.Forms.Label();
            this.HeaderLabelCreateUserPanel = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.ResetPasswordLabel = new System.Windows.Forms.Label();
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
            this.DashBoardPanel = new System.Windows.Forms.Panel();
            this.incidentsPastDeadLineLabel = new System.Windows.Forms.Label();
            this.unresolvedTicketsLabel = new System.Windows.Forms.Label();
            this.TitleLabelDashBOardPanel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ResetPasswordPanel = new System.Windows.Forms.Panel();
            this.UserFoundLabel = new System.Windows.Forms.Label();
            this.ConfirmNewPasswordButton = new System.Windows.Forms.Button();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.ResetPasswordLabelTitle = new System.Windows.Forms.Label();
            this.EmailLabelResetPassword = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AddIncindentPanel.SuspendLayout();
            this.overviewTicketsPanel.SuspendLayout();
            this.UserManagementPanel.SuspendLayout();
            this.CreateNewUserPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPanelLogo)).BeginInit();
            this.NavigationPanel.SuspendLayout();
            this.DashBoardPanel.SuspendLayout();
            this.ResetPasswordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddIncindentPanel
            // 
            this.AddIncindentPanel.Controls.Add(this.StatusComboBoxAddIncidentPanel);
            this.AddIncindentPanel.Controls.Add(this.labelStatusAddIncidentPanel);
            this.AddIncindentPanel.Controls.Add(this.submitTicketButtonInIncidentPanel);
            this.AddIncindentPanel.Controls.Add(this.cancelButtonInIncidentPanel);
            this.AddIncindentPanel.Controls.Add(this.descriptionTextBox);
            this.AddIncindentPanel.Controls.Add(this.deadlineComboBox);
            this.AddIncindentPanel.Controls.Add(this.priorityComboBox);
            this.AddIncindentPanel.Controls.Add(this.reportedByUserTextBox);
            this.AddIncindentPanel.Controls.Add(this.typeOfIncidentComboBox);
            this.AddIncindentPanel.Controls.Add(this.subjectOfIncidentTextBox);
            this.AddIncindentPanel.Controls.Add(this.descriptionLabelInIncidentPanel);
            this.AddIncindentPanel.Controls.Add(this.deadlineLabelInIncidentLabel);
            this.AddIncindentPanel.Controls.Add(this.priorityLabelInIncididentPanel);
            this.AddIncindentPanel.Controls.Add(this.reportedByUserInIncidentPanel);
            this.AddIncindentPanel.Controls.Add(this.typeOfIncidentLabelInIncidentLabel);
            this.AddIncindentPanel.Controls.Add(this.subjectOfIncidentLabelInIncidentPanel);
            this.AddIncindentPanel.Controls.Add(this.labelIncidentTicket);
            this.AddIncindentPanel.Location = new System.Drawing.Point(1, 98);
            this.AddIncindentPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.AddIncindentPanel.Name = "AddIncindentPanel";
            this.AddIncindentPanel.Size = new System.Drawing.Size(613, 389);
            this.AddIncindentPanel.TabIndex = 1;
            // 
            // StatusComboBoxAddIncidentPanel
            // 
            this.StatusComboBoxAddIncidentPanel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBoxAddIncidentPanel.FormattingEnabled = true;
            this.StatusComboBoxAddIncidentPanel.Items.AddRange(new object[] {
            "InProgress",
            "Handled",
            "Closed",
            "Pending",
            "Reopened"});
            this.StatusComboBoxAddIncidentPanel.Location = new System.Drawing.Point(187, 188);
            this.StatusComboBoxAddIncidentPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.StatusComboBoxAddIncidentPanel.Name = "StatusComboBoxAddIncidentPanel";
            this.StatusComboBoxAddIncidentPanel.Size = new System.Drawing.Size(193, 21);
            this.StatusComboBoxAddIncidentPanel.TabIndex = 29;
            // 
            // labelStatusAddIncidentPanel
            // 
            this.labelStatusAddIncidentPanel.AutoSize = true;
            this.labelStatusAddIncidentPanel.Location = new System.Drawing.Point(82, 192);
            this.labelStatusAddIncidentPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelStatusAddIncidentPanel.Name = "labelStatusAddIncidentPanel";
            this.labelStatusAddIncidentPanel.Size = new System.Drawing.Size(40, 13);
            this.labelStatusAddIncidentPanel.TabIndex = 28;
            this.labelStatusAddIncidentPanel.Text = "Status:";
            // 
            // submitTicketButtonInIncidentPanel
            // 
            this.submitTicketButtonInIncidentPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.submitTicketButtonInIncidentPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitTicketButtonInIncidentPanel.Location = new System.Drawing.Point(279, 216);
            this.submitTicketButtonInIncidentPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.submitTicketButtonInIncidentPanel.Name = "submitTicketButtonInIncidentPanel";
            this.submitTicketButtonInIncidentPanel.Size = new System.Drawing.Size(99, 27);
            this.submitTicketButtonInIncidentPanel.TabIndex = 27;
            this.submitTicketButtonInIncidentPanel.Text = "Submit ticket";
            this.submitTicketButtonInIncidentPanel.UseVisualStyleBackColor = false;
            this.submitTicketButtonInIncidentPanel.Click += new System.EventHandler(this.submitTicketButtonInIncidentPanel_Click);
            // 
            // cancelButtonInIncidentPanel
            // 
            this.cancelButtonInIncidentPanel.Location = new System.Drawing.Point(187, 216);
            this.cancelButtonInIncidentPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cancelButtonInIncidentPanel.Name = "cancelButtonInIncidentPanel";
            this.cancelButtonInIncidentPanel.Size = new System.Drawing.Size(77, 27);
            this.cancelButtonInIncidentPanel.TabIndex = 26;
            this.cancelButtonInIncidentPanel.Text = "Cancel";
            this.cancelButtonInIncidentPanel.UseVisualStyleBackColor = true;
            this.cancelButtonInIncidentPanel.Click += new System.EventHandler(this.cancelButtonInIncidentPanel_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(187, 165);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(193, 20);
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
            this.deadlineComboBox.Location = new System.Drawing.Point(187, 144);
            this.deadlineComboBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.deadlineComboBox.Name = "deadlineComboBox";
            this.deadlineComboBox.Size = new System.Drawing.Size(193, 21);
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
            this.priorityComboBox.Location = new System.Drawing.Point(187, 121);
            this.priorityComboBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(193, 21);
            this.priorityComboBox.TabIndex = 23;
            // 
            // reportedByUserTextBox
            // 
            this.reportedByUserTextBox.Location = new System.Drawing.Point(187, 101);
            this.reportedByUserTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.reportedByUserTextBox.Name = "reportedByUserTextBox";
            this.reportedByUserTextBox.Size = new System.Drawing.Size(193, 20);
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
            this.typeOfIncidentComboBox.Location = new System.Drawing.Point(187, 81);
            this.typeOfIncidentComboBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.typeOfIncidentComboBox.Name = "typeOfIncidentComboBox";
            this.typeOfIncidentComboBox.Size = new System.Drawing.Size(193, 21);
            this.typeOfIncidentComboBox.TabIndex = 21;
            // 
            // subjectOfIncidentTextBox
            // 
            this.subjectOfIncidentTextBox.Location = new System.Drawing.Point(187, 61);
            this.subjectOfIncidentTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.subjectOfIncidentTextBox.Name = "subjectOfIncidentTextBox";
            this.subjectOfIncidentTextBox.Size = new System.Drawing.Size(193, 20);
            this.subjectOfIncidentTextBox.TabIndex = 20;
            // 
            // descriptionLabelInIncidentPanel
            // 
            this.descriptionLabelInIncidentPanel.AutoSize = true;
            this.descriptionLabelInIncidentPanel.Location = new System.Drawing.Point(81, 168);
            this.descriptionLabelInIncidentPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.descriptionLabelInIncidentPanel.Name = "descriptionLabelInIncidentPanel";
            this.descriptionLabelInIncidentPanel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabelInIncidentPanel.TabIndex = 19;
            this.descriptionLabelInIncidentPanel.Text = "Description:";
            // 
            // deadlineLabelInIncidentLabel
            // 
            this.deadlineLabelInIncidentLabel.AutoSize = true;
            this.deadlineLabelInIncidentLabel.Location = new System.Drawing.Point(81, 147);
            this.deadlineLabelInIncidentLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.deadlineLabelInIncidentLabel.Name = "deadlineLabelInIncidentLabel";
            this.deadlineLabelInIncidentLabel.Size = new System.Drawing.Size(99, 13);
            this.deadlineLabelInIncidentLabel.TabIndex = 18;
            this.deadlineLabelInIncidentLabel.Text = "Deadline/follow up:";
            // 
            // priorityLabelInIncididentPanel
            // 
            this.priorityLabelInIncididentPanel.AutoSize = true;
            this.priorityLabelInIncididentPanel.Location = new System.Drawing.Point(81, 126);
            this.priorityLabelInIncididentPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.priorityLabelInIncididentPanel.Name = "priorityLabelInIncididentPanel";
            this.priorityLabelInIncididentPanel.Size = new System.Drawing.Size(41, 13);
            this.priorityLabelInIncididentPanel.TabIndex = 17;
            this.priorityLabelInIncididentPanel.Text = "Priority:";
            // 
            // reportedByUserInIncidentPanel
            // 
            this.reportedByUserInIncidentPanel.AutoSize = true;
            this.reportedByUserInIncidentPanel.Location = new System.Drawing.Point(81, 104);
            this.reportedByUserInIncidentPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.reportedByUserInIncidentPanel.Name = "reportedByUserInIncidentPanel";
            this.reportedByUserInIncidentPanel.Size = new System.Drawing.Size(91, 13);
            this.reportedByUserInIncidentPanel.TabIndex = 16;
            this.reportedByUserInIncidentPanel.Text = "Reported by user:";
            // 
            // typeOfIncidentLabelInIncidentLabel
            // 
            this.typeOfIncidentLabelInIncidentLabel.AutoSize = true;
            this.typeOfIncidentLabelInIncidentLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.typeOfIncidentLabelInIncidentLabel.Location = new System.Drawing.Point(81, 86);
            this.typeOfIncidentLabelInIncidentLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.typeOfIncidentLabelInIncidentLabel.Name = "typeOfIncidentLabelInIncidentLabel";
            this.typeOfIncidentLabelInIncidentLabel.Size = new System.Drawing.Size(94, 15);
            this.typeOfIncidentLabelInIncidentLabel.TabIndex = 15;
            this.typeOfIncidentLabelInIncidentLabel.Text = "Type of incident:";
            // 
            // subjectOfIncidentLabelInIncidentPanel
            // 
            this.subjectOfIncidentLabelInIncidentPanel.AutoSize = true;
            this.subjectOfIncidentLabelInIncidentPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.subjectOfIncidentLabelInIncidentPanel.Location = new System.Drawing.Point(81, 64);
            this.subjectOfIncidentLabelInIncidentPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.subjectOfIncidentLabelInIncidentPanel.Name = "subjectOfIncidentLabelInIncidentPanel";
            this.subjectOfIncidentLabelInIncidentPanel.Size = new System.Drawing.Size(109, 15);
            this.subjectOfIncidentLabelInIncidentPanel.TabIndex = 14;
            this.subjectOfIncidentLabelInIncidentPanel.Text = "Subject of incident:";
            // 
            // labelIncidentTicket
            // 
            this.labelIncidentTicket.AutoSize = true;
            this.labelIncidentTicket.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelIncidentTicket.Location = new System.Drawing.Point(79, 14);
            this.labelIncidentTicket.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelIncidentTicket.Name = "labelIncidentTicket";
            this.labelIncidentTicket.Size = new System.Drawing.Size(408, 45);
            this.labelIncidentTicket.TabIndex = 10;
            this.labelIncidentTicket.Text = "Create new incident ticket";
            // 
            // overviewTicketsPanel
            // 
            this.overviewTicketsPanel.Controls.Add(this.TransferServiceDeskEmployeeButton);
            this.overviewTicketsPanel.Controls.Add(this.sortByPriorityComboBox);
            this.overviewTicketsPanel.Controls.Add(this.sortByPriorityLabel);
            this.overviewTicketsPanel.Controls.Add(this.createButtonInOverviewTickets);
            this.overviewTicketsPanel.Controls.Add(this.closeTicketButton);
            this.overviewTicketsPanel.Controls.Add(this.deleteButton);
            this.overviewTicketsPanel.Controls.Add(this.updateButton);
            this.overviewTicketsPanel.Controls.Add(this.overviewTicketsListView);
            this.overviewTicketsPanel.Controls.Add(this.createIncidentButton);
            this.overviewTicketsPanel.Controls.Add(this.overviewTicketsLabel);
            this.overviewTicketsPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.overviewTicketsPanel.Location = new System.Drawing.Point(1, 98);
            this.overviewTicketsPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 3);
            this.overviewTicketsPanel.Name = "overviewTicketsPanel";
            this.overviewTicketsPanel.Size = new System.Drawing.Size(613, 389);
            this.overviewTicketsPanel.TabIndex = 1;
            // 
            // TransferServiceDeskEmployeeButton
            // 
            this.TransferServiceDeskEmployeeButton.Location = new System.Drawing.Point(266, 339);
            this.TransferServiceDeskEmployeeButton.Name = "TransferServiceDeskEmployeeButton";
            this.TransferServiceDeskEmployeeButton.Size = new System.Drawing.Size(69, 28);
            this.TransferServiceDeskEmployeeButton.TabIndex = 11;
            this.TransferServiceDeskEmployeeButton.Text = "Transfer";
            this.TransferServiceDeskEmployeeButton.UseVisualStyleBackColor = true;
            this.TransferServiceDeskEmployeeButton.Click += new System.EventHandler(this.TransferServiceDeskEmployeeButton_Click);
            // 
            // sortByPriorityComboBox
            // 
            this.sortByPriorityComboBox.FormattingEnabled = true;
            this.sortByPriorityComboBox.Items.AddRange(new object[] {
            "All",
            "Low",
            "Normal",
            "High"});
            this.sortByPriorityComboBox.Location = new System.Drawing.Point(105, 43);
            this.sortByPriorityComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortByPriorityComboBox.Name = "sortByPriorityComboBox";
            this.sortByPriorityComboBox.Size = new System.Drawing.Size(115, 21);
            this.sortByPriorityComboBox.TabIndex = 10;
            this.sortByPriorityComboBox.SelectedIndexChanged += new System.EventHandler(this.sortByPriorityComboBox_SelectedIndexChanged);
            // 
            // sortByPriorityLabel
            // 
            this.sortByPriorityLabel.AutoSize = true;
            this.sortByPriorityLabel.Location = new System.Drawing.Point(25, 46);
            this.sortByPriorityLabel.Name = "sortByPriorityLabel";
            this.sortByPriorityLabel.Size = new System.Drawing.Size(75, 13);
            this.sortByPriorityLabel.TabIndex = 9;
            this.sortByPriorityLabel.Text = "Priorty Sort by:";
            // 
            // createButtonInOverviewTickets
            // 
            this.createButtonInOverviewTickets.Location = new System.Drawing.Point(187, 339);
            this.createButtonInOverviewTickets.Name = "createButtonInOverviewTickets";
            this.createButtonInOverviewTickets.Size = new System.Drawing.Size(69, 28);
            this.createButtonInOverviewTickets.TabIndex = 8;
            this.createButtonInOverviewTickets.Text = "Create";
            this.createButtonInOverviewTickets.UseVisualStyleBackColor = true;
            this.createButtonInOverviewTickets.Click += new System.EventHandler(this.createButtonInOverviewTickets_Click);
            // 
            // closeTicketButton
            // 
            this.closeTicketButton.Location = new System.Drawing.Point(511, 339);
            this.closeTicketButton.Name = "closeTicketButton";
            this.closeTicketButton.Size = new System.Drawing.Size(83, 28);
            this.closeTicketButton.TabIndex = 7;
            this.closeTicketButton.Text = "Close Ticket";
            this.closeTicketButton.UseVisualStyleBackColor = true;
            this.closeTicketButton.Click += new System.EventHandler(this.closeTicketButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(105, 339);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(69, 28);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(25, 339);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(69, 28);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // overviewTicketsListView
            // 
            this.overviewTicketsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ticketId,
            this.DateOpened,
            this.SubjectOfIncident,
            this.Deadline,
            this.Status});
            this.overviewTicketsListView.FullRowSelect = true;
            this.overviewTicketsListView.HideSelection = false;
            this.overviewTicketsListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.overviewTicketsListView.Location = new System.Drawing.Point(23, 71);
            this.overviewTicketsListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.overviewTicketsListView.MultiSelect = false;
            this.overviewTicketsListView.Name = "overviewTicketsListView";
            this.overviewTicketsListView.Size = new System.Drawing.Size(571, 260);
            this.overviewTicketsListView.TabIndex = 2;
            this.overviewTicketsListView.UseCompatibleStateImageBehavior = false;
            this.overviewTicketsListView.View = System.Windows.Forms.View.Details;
            // 
            // ticketId
            // 
            this.ticketId.Text = "Id";
            this.ticketId.Width = 100;
            // 
            // DateOpened
            // 
            this.DateOpened.Text = "DateOpened";
            this.DateOpened.Width = 100;
            // 
            // SubjectOfIncident
            // 
            this.SubjectOfIncident.Text = "Subject";
            this.SubjectOfIncident.Width = 200;
            // 
            // Deadline
            // 
            this.Deadline.Text = "Deadline";
            this.Deadline.Width = 100;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 100;
            // 
            // createIncidentButton
            // 
            this.createIncidentButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.createIncidentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createIncidentButton.Location = new System.Drawing.Point(491, 37);
            this.createIncidentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createIncidentButton.Name = "createIncidentButton";
            this.createIncidentButton.Size = new System.Drawing.Size(103, 30);
            this.createIncidentButton.TabIndex = 1;
            this.createIncidentButton.Text = "Create incident";
            this.createIncidentButton.UseVisualStyleBackColor = false;
            this.createIncidentButton.Click += new System.EventHandler(this.createIncidentButton_Click);
            // 
            // overviewTicketsLabel
            // 
            this.overviewTicketsLabel.AutoSize = true;
            this.overviewTicketsLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.overviewTicketsLabel.Location = new System.Drawing.Point(37, 1);
            this.overviewTicketsLabel.Name = "overviewTicketsLabel";
            this.overviewTicketsLabel.Size = new System.Drawing.Size(274, 45);
            this.overviewTicketsLabel.TabIndex = 0;
            this.overviewTicketsLabel.Text = "Overview Tickets";
            // 
            // UserManagementPanel
            // 
            this.UserManagementPanel.Controls.Add(this.UserListView);
            this.UserManagementPanel.Controls.Add(this.AddNewUserButtonUserManagement);
            this.UserManagementPanel.Controls.Add(this.FilterByEmailLabelUserManagement);
            this.UserManagementPanel.Controls.Add(this.FilterByEmailTextBoxUserManagement);
            this.UserManagementPanel.Controls.Add(this.TitleUserManagementPanel);
            this.UserManagementPanel.Location = new System.Drawing.Point(1, 98);
            this.UserManagementPanel.Name = "UserManagementPanel";
            this.UserManagementPanel.Size = new System.Drawing.Size(613, 388);
            this.UserManagementPanel.TabIndex = 1;
            // 
            // UserListView
            // 
            this.UserListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Email,
            this.EmployeeName,
            this.Tickets});
            this.UserListView.HideSelection = false;
            this.UserListView.Location = new System.Drawing.Point(69, 68);
            this.UserListView.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.UserListView.Name = "UserListView";
            this.UserListView.Size = new System.Drawing.Size(459, 216);
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
            this.AddNewUserButtonUserManagement.Location = new System.Drawing.Point(445, 32);
            this.AddNewUserButtonUserManagement.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.AddNewUserButtonUserManagement.Name = "AddNewUserButtonUserManagement";
            this.AddNewUserButtonUserManagement.Size = new System.Drawing.Size(81, 23);
            this.AddNewUserButtonUserManagement.TabIndex = 5;
            this.AddNewUserButtonUserManagement.Text = "+ADD NEW USER";
            this.AddNewUserButtonUserManagement.UseVisualStyleBackColor = false;
            this.AddNewUserButtonUserManagement.Click += new System.EventHandler(this.AddNewUserButtonUserManagement_Click);
            // 
            // FilterByEmailLabelUserManagement
            // 
            this.FilterByEmailLabelUserManagement.AutoSize = true;
            this.FilterByEmailLabelUserManagement.Location = new System.Drawing.Point(67, 37);
            this.FilterByEmailLabelUserManagement.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.FilterByEmailLabelUserManagement.Name = "FilterByEmailLabelUserManagement";
            this.FilterByEmailLabelUserManagement.Size = new System.Drawing.Size(76, 13);
            this.FilterByEmailLabelUserManagement.TabIndex = 4;
            this.FilterByEmailLabelUserManagement.Text = "Filter by email: ";
            // 
            // FilterByEmailTextBoxUserManagement
            // 
            this.FilterByEmailTextBoxUserManagement.Location = new System.Drawing.Point(143, 35);
            this.FilterByEmailTextBoxUserManagement.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.FilterByEmailTextBoxUserManagement.Name = "FilterByEmailTextBoxUserManagement";
            this.FilterByEmailTextBoxUserManagement.Size = new System.Drawing.Size(117, 20);
            this.FilterByEmailTextBoxUserManagement.TabIndex = 3;
            this.FilterByEmailTextBoxUserManagement.TextChanged += new System.EventHandler(this.FilterByEmailTextBoxUserManagement_TextChanged);
            // 
            // TitleUserManagementPanel
            // 
            this.TitleUserManagementPanel.AutoSize = true;
            this.TitleUserManagementPanel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.TitleUserManagementPanel.Location = new System.Drawing.Point(69, 6);
            this.TitleUserManagementPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TitleUserManagementPanel.Name = "TitleUserManagementPanel";
            this.TitleUserManagementPanel.Size = new System.Drawing.Size(223, 32);
            this.TitleUserManagementPanel.TabIndex = 2;
            this.TitleUserManagementPanel.Text = "User Management";
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(551, 9);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(54, 25);
            this.LogOutButton.TabIndex = 1;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // CreateNewUserPanel
            // 
            this.CreateNewUserPanel.BackColor = System.Drawing.Color.White;
            this.CreateNewUserPanel.Controls.Add(this.PasswordTextboxCreateUserPanel);
            this.CreateNewUserPanel.Controls.Add(this.PasswordLabelCreateUserPanel);
            this.CreateNewUserPanel.Controls.Add(this.UsernameTextboxCreateUserPanel);
            this.CreateNewUserPanel.Controls.Add(this.UsernameLabelCreateUserPanel);
            this.CreateNewUserPanel.Controls.Add(this.LocationComboboxCreateUserPanel);
            this.CreateNewUserPanel.Controls.Add(this.TypeUserComboboxCreateUserPanel);
            this.CreateNewUserPanel.Controls.Add(this.CancelButtonCreateUserPanel);
            this.CreateNewUserPanel.Controls.Add(this.AddUserButtonCreateUserPanel);
            this.CreateNewUserPanel.Controls.Add(this.PhoneTextboxCreateUserPanel);
            this.CreateNewUserPanel.Controls.Add(this.EmailTextboxCreateUserPanel);
            this.CreateNewUserPanel.Controls.Add(this.FullNameTextboxCreateUserPanel);
            this.CreateNewUserPanel.Controls.Add(this.LocationLabelCreateUserPanel);
            this.CreateNewUserPanel.Controls.Add(this.PhoneLabelCreateUserPanel);
            this.CreateNewUserPanel.Controls.Add(this.EmailLabelCreateUserPanel);
            this.CreateNewUserPanel.Controls.Add(this.TypeUserLabelCreateUserPanel);
            this.CreateNewUserPanel.Controls.Add(this.FullNameLabelCreateUserPanel);
            this.CreateNewUserPanel.Controls.Add(this.HeaderLabelCreateUserPanel);
            this.CreateNewUserPanel.Location = new System.Drawing.Point(3, 98);
            this.CreateNewUserPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.CreateNewUserPanel.Name = "CreateNewUserPanel";
            this.CreateNewUserPanel.Size = new System.Drawing.Size(612, 391);
            this.CreateNewUserPanel.TabIndex = 6;
            // 
            // PasswordTextboxCreateUserPanel
            // 
            this.PasswordTextboxCreateUserPanel.Location = new System.Drawing.Point(263, 137);
            this.PasswordTextboxCreateUserPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.PasswordTextboxCreateUserPanel.Name = "PasswordTextboxCreateUserPanel";
            this.PasswordTextboxCreateUserPanel.PasswordChar = '●';
            this.PasswordTextboxCreateUserPanel.Size = new System.Drawing.Size(245, 20);
            this.PasswordTextboxCreateUserPanel.TabIndex = 24;
            // 
            // PasswordLabelCreateUserPanel
            // 
            this.PasswordLabelCreateUserPanel.AutoSize = true;
            this.PasswordLabelCreateUserPanel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.PasswordLabelCreateUserPanel.Location = new System.Drawing.Point(103, 133);
            this.PasswordLabelCreateUserPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PasswordLabelCreateUserPanel.Name = "PasswordLabelCreateUserPanel";
            this.PasswordLabelCreateUserPanel.Size = new System.Drawing.Size(95, 25);
            this.PasswordLabelCreateUserPanel.TabIndex = 23;
            this.PasswordLabelCreateUserPanel.Text = "Password:";
            // 
            // UsernameTextboxCreateUserPanel
            // 
            this.UsernameTextboxCreateUserPanel.Location = new System.Drawing.Point(263, 111);
            this.UsernameTextboxCreateUserPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.UsernameTextboxCreateUserPanel.Name = "UsernameTextboxCreateUserPanel";
            this.UsernameTextboxCreateUserPanel.Size = new System.Drawing.Size(245, 20);
            this.UsernameTextboxCreateUserPanel.TabIndex = 21;
            // 
            // UsernameLabelCreateUserPanel
            // 
            this.UsernameLabelCreateUserPanel.AutoSize = true;
            this.UsernameLabelCreateUserPanel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.UsernameLabelCreateUserPanel.Location = new System.Drawing.Point(103, 107);
            this.UsernameLabelCreateUserPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.UsernameLabelCreateUserPanel.Name = "UsernameLabelCreateUserPanel";
            this.UsernameLabelCreateUserPanel.Size = new System.Drawing.Size(101, 25);
            this.UsernameLabelCreateUserPanel.TabIndex = 20;
            this.UsernameLabelCreateUserPanel.Text = "Username:";
            // 
            // LocationComboboxCreateUserPanel
            // 
            this.LocationComboboxCreateUserPanel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocationComboboxCreateUserPanel.FormattingEnabled = true;
            this.LocationComboboxCreateUserPanel.Items.AddRange(new object[] {
            "Haarlem",
            "Amsterdam",
            "Utrecht"});
            this.LocationComboboxCreateUserPanel.Location = new System.Drawing.Point(263, 246);
            this.LocationComboboxCreateUserPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.LocationComboboxCreateUserPanel.Name = "LocationComboboxCreateUserPanel";
            this.LocationComboboxCreateUserPanel.Size = new System.Drawing.Size(245, 21);
            this.LocationComboboxCreateUserPanel.TabIndex = 19;
            // 
            // TypeUserComboboxCreateUserPanel
            // 
            this.TypeUserComboboxCreateUserPanel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeUserComboboxCreateUserPanel.FormattingEnabled = true;
            this.TypeUserComboboxCreateUserPanel.Items.AddRange(new object[] {
            "Regular",
            "ServiceDesk"});
            this.TypeUserComboboxCreateUserPanel.Location = new System.Drawing.Point(263, 163);
            this.TypeUserComboboxCreateUserPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.TypeUserComboboxCreateUserPanel.Name = "TypeUserComboboxCreateUserPanel";
            this.TypeUserComboboxCreateUserPanel.Size = new System.Drawing.Size(245, 21);
            this.TypeUserComboboxCreateUserPanel.TabIndex = 18;
            // 
            // CancelButtonCreateUserPanel
            // 
            this.CancelButtonCreateUserPanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CancelButtonCreateUserPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButtonCreateUserPanel.Location = new System.Drawing.Point(283, 296);
            this.CancelButtonCreateUserPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.CancelButtonCreateUserPanel.Name = "CancelButtonCreateUserPanel";
            this.CancelButtonCreateUserPanel.Size = new System.Drawing.Size(90, 26);
            this.CancelButtonCreateUserPanel.TabIndex = 17;
            this.CancelButtonCreateUserPanel.Text = "CANCEL";
            this.CancelButtonCreateUserPanel.UseVisualStyleBackColor = false;
            this.CancelButtonCreateUserPanel.Click += new System.EventHandler(this.CancelButtonCreateUserPanel_Click);
            // 
            // AddUserButtonCreateUserPanel
            // 
            this.AddUserButtonCreateUserPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddUserButtonCreateUserPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddUserButtonCreateUserPanel.Location = new System.Drawing.Point(389, 296);
            this.AddUserButtonCreateUserPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.AddUserButtonCreateUserPanel.Name = "AddUserButtonCreateUserPanel";
            this.AddUserButtonCreateUserPanel.Size = new System.Drawing.Size(90, 26);
            this.AddUserButtonCreateUserPanel.TabIndex = 16;
            this.AddUserButtonCreateUserPanel.Text = "ADD USER";
            this.AddUserButtonCreateUserPanel.UseVisualStyleBackColor = false;
            this.AddUserButtonCreateUserPanel.Click += new System.EventHandler(this.AddUserButtonCreateUserPanel_Click);
            // 
            // PhoneTextboxCreateUserPanel
            // 
            this.PhoneTextboxCreateUserPanel.Location = new System.Drawing.Point(263, 219);
            this.PhoneTextboxCreateUserPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.PhoneTextboxCreateUserPanel.Name = "PhoneTextboxCreateUserPanel";
            this.PhoneTextboxCreateUserPanel.Size = new System.Drawing.Size(245, 20);
            this.PhoneTextboxCreateUserPanel.TabIndex = 12;
            // 
            // EmailTextboxCreateUserPanel
            // 
            this.EmailTextboxCreateUserPanel.Location = new System.Drawing.Point(263, 192);
            this.EmailTextboxCreateUserPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.EmailTextboxCreateUserPanel.Name = "EmailTextboxCreateUserPanel";
            this.EmailTextboxCreateUserPanel.Size = new System.Drawing.Size(245, 20);
            this.EmailTextboxCreateUserPanel.TabIndex = 11;
            // 
            // FullNameTextboxCreateUserPanel
            // 
            this.FullNameTextboxCreateUserPanel.Location = new System.Drawing.Point(263, 83);
            this.FullNameTextboxCreateUserPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.FullNameTextboxCreateUserPanel.Name = "FullNameTextboxCreateUserPanel";
            this.FullNameTextboxCreateUserPanel.Size = new System.Drawing.Size(245, 20);
            this.FullNameTextboxCreateUserPanel.TabIndex = 8;
            // 
            // LocationLabelCreateUserPanel
            // 
            this.LocationLabelCreateUserPanel.AutoSize = true;
            this.LocationLabelCreateUserPanel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.LocationLabelCreateUserPanel.Location = new System.Drawing.Point(103, 244);
            this.LocationLabelCreateUserPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LocationLabelCreateUserPanel.Name = "LocationLabelCreateUserPanel";
            this.LocationLabelCreateUserPanel.Size = new System.Drawing.Size(154, 25);
            this.LocationLabelCreateUserPanel.TabIndex = 6;
            this.LocationLabelCreateUserPanel.Text = "Location/branch:";
            // 
            // PhoneLabelCreateUserPanel
            // 
            this.PhoneLabelCreateUserPanel.AutoSize = true;
            this.PhoneLabelCreateUserPanel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.PhoneLabelCreateUserPanel.Location = new System.Drawing.Point(103, 216);
            this.PhoneLabelCreateUserPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PhoneLabelCreateUserPanel.Name = "PhoneLabelCreateUserPanel";
            this.PhoneLabelCreateUserPanel.Size = new System.Drawing.Size(141, 25);
            this.PhoneLabelCreateUserPanel.TabIndex = 5;
            this.PhoneLabelCreateUserPanel.Text = "Phone number:";
            // 
            // EmailLabelCreateUserPanel
            // 
            this.EmailLabelCreateUserPanel.AutoSize = true;
            this.EmailLabelCreateUserPanel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.EmailLabelCreateUserPanel.Location = new System.Drawing.Point(103, 188);
            this.EmailLabelCreateUserPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.EmailLabelCreateUserPanel.Name = "EmailLabelCreateUserPanel";
            this.EmailLabelCreateUserPanel.Size = new System.Drawing.Size(140, 25);
            this.EmailLabelCreateUserPanel.TabIndex = 4;
            this.EmailLabelCreateUserPanel.Text = "E-mail address:";
            // 
            // TypeUserLabelCreateUserPanel
            // 
            this.TypeUserLabelCreateUserPanel.AutoSize = true;
            this.TypeUserLabelCreateUserPanel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TypeUserLabelCreateUserPanel.Location = new System.Drawing.Point(103, 160);
            this.TypeUserLabelCreateUserPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TypeUserLabelCreateUserPanel.Name = "TypeUserLabelCreateUserPanel";
            this.TypeUserLabelCreateUserPanel.Size = new System.Drawing.Size(118, 25);
            this.TypeUserLabelCreateUserPanel.TabIndex = 3;
            this.TypeUserLabelCreateUserPanel.Text = "Type of user:";
            // 
            // FullNameLabelCreateUserPanel
            // 
            this.FullNameLabelCreateUserPanel.AutoSize = true;
            this.FullNameLabelCreateUserPanel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.FullNameLabelCreateUserPanel.Location = new System.Drawing.Point(103, 80);
            this.FullNameLabelCreateUserPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.FullNameLabelCreateUserPanel.Name = "FullNameLabelCreateUserPanel";
            this.FullNameLabelCreateUserPanel.Size = new System.Drawing.Size(98, 25);
            this.FullNameLabelCreateUserPanel.TabIndex = 1;
            this.FullNameLabelCreateUserPanel.Text = "Full name:";
            // 
            // HeaderLabelCreateUserPanel
            // 
            this.HeaderLabelCreateUserPanel.AutoSize = true;
            this.HeaderLabelCreateUserPanel.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.HeaderLabelCreateUserPanel.Location = new System.Drawing.Point(96, 16);
            this.HeaderLabelCreateUserPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.HeaderLabelCreateUserPanel.Name = "HeaderLabelCreateUserPanel";
            this.HeaderLabelCreateUserPanel.Size = new System.Drawing.Size(284, 47);
            this.HeaderLabelCreateUserPanel.TabIndex = 0;
            this.HeaderLabelCreateUserPanel.Text = "Create new user";
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.White;
            this.LoginPanel.Controls.Add(this.ResetPasswordLabel);
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
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(615, 484);
            this.LoginPanel.TabIndex = 4;
            // 
            // ResetPasswordLabel
            // 
            this.ResetPasswordLabel.AutoSize = true;
            this.ResetPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ResetPasswordLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ResetPasswordLabel.Location = new System.Drawing.Point(273, 256);
            this.ResetPasswordLabel.Name = "ResetPasswordLabel";
            this.ResetPasswordLabel.Size = new System.Drawing.Size(132, 17);
            this.ResetPasswordLabel.TabIndex = 12;
            this.ResetPasswordLabel.Text = "Forgot Login Details?";
            this.ResetPasswordLabel.Click += new System.EventHandler(this.ResetPasswordLabel_Click);
            // 
            // RememberMeCheckBoxLoginPanel
            // 
            this.RememberMeCheckBoxLoginPanel.AutoSize = true;
            this.RememberMeCheckBoxLoginPanel.Location = new System.Drawing.Point(273, 228);
            this.RememberMeCheckBoxLoginPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.RememberMeCheckBoxLoginPanel.Name = "RememberMeCheckBoxLoginPanel";
            this.RememberMeCheckBoxLoginPanel.Size = new System.Drawing.Size(94, 17);
            this.RememberMeCheckBoxLoginPanel.TabIndex = 11;
            this.RememberMeCheckBoxLoginPanel.Text = "Remember me";
            this.RememberMeCheckBoxLoginPanel.UseVisualStyleBackColor = true;
            // 
            // TitleDetailLoginPanel
            // 
            this.TitleDetailLoginPanel.AutoSize = true;
            this.TitleDetailLoginPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic);
            this.TitleDetailLoginPanel.Location = new System.Drawing.Point(245, 116);
            this.TitleDetailLoginPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TitleDetailLoginPanel.Name = "TitleDetailLoginPanel";
            this.TitleDetailLoginPanel.Size = new System.Drawing.Size(263, 40);
            this.TitleDetailLoginPanel.TabIndex = 10;
            this.TitleDetailLoginPanel.Text = "Please provide login credentials to login\r\nto NoDesk The Garden Group";
            this.TitleDetailLoginPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleLoginPanel
            // 
            this.TitleLoginPanel.AutoSize = true;
            this.TitleLoginPanel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.TitleLoginPanel.Location = new System.Drawing.Point(265, 77);
            this.TitleLoginPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TitleLoginPanel.Name = "TitleLoginPanel";
            this.TitleLoginPanel.Size = new System.Drawing.Size(199, 40);
            this.TitleLoginPanel.TabIndex = 9;
            this.TitleLoginPanel.Text = "NoDesk: TGG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.TheGardenGroupLogo;
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPanelUsernameTextBox
            // 
            this.LoginPanelUsernameTextBox.Location = new System.Drawing.Point(273, 162);
            this.LoginPanelUsernameTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.LoginPanelUsernameTextBox.Name = "LoginPanelUsernameTextBox";
            this.LoginPanelUsernameTextBox.Size = new System.Drawing.Size(129, 20);
            this.LoginPanelUsernameTextBox.TabIndex = 7;
            // 
            // LoginPanelPasswordTextBox
            // 
            this.LoginPanelPasswordTextBox.Location = new System.Drawing.Point(273, 198);
            this.LoginPanelPasswordTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.LoginPanelPasswordTextBox.Name = "LoginPanelPasswordTextBox";
            this.LoginPanelPasswordTextBox.PasswordChar = '*';
            this.LoginPanelPasswordTextBox.Size = new System.Drawing.Size(129, 20);
            this.LoginPanelPasswordTextBox.TabIndex = 6;
            // 
            // LoginPanelLoginButton
            // 
            this.LoginPanelLoginButton.Location = new System.Drawing.Point(273, 297);
            this.LoginPanelLoginButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.LoginPanelLoginButton.Name = "LoginPanelLoginButton";
            this.LoginPanelLoginButton.Size = new System.Drawing.Size(78, 27);
            this.LoginPanelLoginButton.TabIndex = 5;
            this.LoginPanelLoginButton.Text = "Log in";
            this.LoginPanelLoginButton.UseVisualStyleBackColor = true;
            this.LoginPanelLoginButton.Click += new System.EventHandler(this.LoginPanelLoginButton_Click);
            // 
            // LoginPanelPasswordLabel
            // 
            this.LoginPanelPasswordLabel.AutoSize = true;
            this.LoginPanelPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LoginPanelPasswordLabel.Location = new System.Drawing.Point(180, 195);
            this.LoginPanelPasswordLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LoginPanelPasswordLabel.Name = "LoginPanelPasswordLabel";
            this.LoginPanelPasswordLabel.Size = new System.Drawing.Size(86, 21);
            this.LoginPanelPasswordLabel.TabIndex = 4;
            this.LoginPanelPasswordLabel.Text = "Password:";
            // 
            // LoginPanelUsernameLabel
            // 
            this.LoginPanelUsernameLabel.AutoSize = true;
            this.LoginPanelUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LoginPanelUsernameLabel.Location = new System.Drawing.Point(180, 159);
            this.LoginPanelUsernameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LoginPanelUsernameLabel.Name = "LoginPanelUsernameLabel";
            this.LoginPanelUsernameLabel.Size = new System.Drawing.Size(91, 21);
            this.LoginPanelUsernameLabel.TabIndex = 3;
            this.LoginPanelUsernameLabel.Text = "Username:";
            // 
            // LoginPanelLogo
            // 
            this.LoginPanelLogo.Image = global::UI.Properties.Resources.TheGardenGroupLogo;
            this.LoginPanelLogo.Location = new System.Drawing.Point(7, 3);
            this.LoginPanelLogo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.LoginPanelLogo.Name = "LoginPanelLogo";
            this.LoginPanelLogo.Size = new System.Drawing.Size(191, 63);
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
            this.NavigationPanel.Controls.Add(this.LogOutButton);
            this.NavigationPanel.Controls.Add(this.LoginPanelLogo);
            this.NavigationPanel.Controls.Add(this.DashBoardPanel);
            this.NavigationPanel.Controls.Add(this.overviewTicketsPanel);
            this.NavigationPanel.Controls.Add(this.UserManagementPanel);
            this.NavigationPanel.Controls.Add(this.AddIncindentPanel);
            this.NavigationPanel.Controls.Add(this.CreateNewUserPanel);
            this.NavigationPanel.Location = new System.Drawing.Point(1, 1);
            this.NavigationPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(615, 487);
            this.NavigationPanel.TabIndex = 5;
            // 
            // TitleDetailNavigationPanel
            // 
            this.TitleDetailNavigationPanel.AutoSize = true;
            this.TitleDetailNavigationPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.TitleDetailNavigationPanel.Location = new System.Drawing.Point(336, 43);
            this.TitleDetailNavigationPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TitleDetailNavigationPanel.Name = "TitleDetailNavigationPanel";
            this.TitleDetailNavigationPanel.Size = new System.Drawing.Size(262, 25);
            this.TitleDetailNavigationPanel.TabIndex = 5;
            this.TitleDetailNavigationPanel.Text = "Licensed to: The Garden Group";
            // 
            // TitleNavigationPanel
            // 
            this.TitleNavigationPanel.AutoSize = true;
            this.TitleNavigationPanel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleNavigationPanel.Location = new System.Drawing.Point(440, 6);
            this.TitleNavigationPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TitleNavigationPanel.Name = "TitleNavigationPanel";
            this.TitleNavigationPanel.Size = new System.Drawing.Size(103, 32);
            this.TitleNavigationPanel.TabIndex = 3;
            this.TitleNavigationPanel.Text = "NoDesk";
            // 
            // UserManagementButtonNavigationPanel
            // 
            this.UserManagementButtonNavigationPanel.BackColor = System.Drawing.Color.White;
            this.UserManagementButtonNavigationPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.UserManagementButtonNavigationPanel.Location = new System.Drawing.Point(395, 71);
            this.UserManagementButtonNavigationPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.UserManagementButtonNavigationPanel.Name = "UserManagementButtonNavigationPanel";
            this.UserManagementButtonNavigationPanel.Size = new System.Drawing.Size(120, 23);
            this.UserManagementButtonNavigationPanel.TabIndex = 2;
            this.UserManagementButtonNavigationPanel.Text = "User Management";
            this.UserManagementButtonNavigationPanel.UseVisualStyleBackColor = false;
            this.UserManagementButtonNavigationPanel.Click += new System.EventHandler(this.UserManagementButtonNavigationPanel_Click);
            // 
            // IncidentManagementButtonNavigationPanel
            // 
            this.IncidentManagementButtonNavigationPanel.BackColor = System.Drawing.Color.White;
            this.IncidentManagementButtonNavigationPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.IncidentManagementButtonNavigationPanel.Location = new System.Drawing.Point(239, 71);
            this.IncidentManagementButtonNavigationPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.IncidentManagementButtonNavigationPanel.Name = "IncidentManagementButtonNavigationPanel";
            this.IncidentManagementButtonNavigationPanel.Size = new System.Drawing.Size(120, 23);
            this.IncidentManagementButtonNavigationPanel.TabIndex = 1;
            this.IncidentManagementButtonNavigationPanel.Text = "Incident Management";
            this.IncidentManagementButtonNavigationPanel.UseVisualStyleBackColor = false;
            this.IncidentManagementButtonNavigationPanel.Click += new System.EventHandler(this.IncidentManagementButtonNavigationPanel_Click);
            // 
            // DashboardButtonNavigationPanel
            // 
            this.DashboardButtonNavigationPanel.BackColor = System.Drawing.Color.White;
            this.DashboardButtonNavigationPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DashboardButtonNavigationPanel.Location = new System.Drawing.Point(79, 71);
            this.DashboardButtonNavigationPanel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.DashboardButtonNavigationPanel.Name = "DashboardButtonNavigationPanel";
            this.DashboardButtonNavigationPanel.Size = new System.Drawing.Size(120, 23);
            this.DashboardButtonNavigationPanel.TabIndex = 0;
            this.DashboardButtonNavigationPanel.Text = "Dashboard";
            this.DashboardButtonNavigationPanel.UseVisualStyleBackColor = false;
            this.DashboardButtonNavigationPanel.Click += new System.EventHandler(this.DashboardButtonNavigationPanel_Click);
            // 
            // DashBoardPanel
            // 
            this.DashBoardPanel.Controls.Add(this.chart1);
            this.DashBoardPanel.Controls.Add(this.incidentsPastDeadLineLabel);
            this.DashBoardPanel.Controls.Add(this.unresolvedTicketsLabel);
            this.DashBoardPanel.Controls.Add(this.TitleLabelDashBOardPanel);
            this.DashBoardPanel.Location = new System.Drawing.Point(1, 99);
            this.DashBoardPanel.Name = "DashBoardPanel";
            this.DashBoardPanel.Size = new System.Drawing.Size(613, 387);
            this.DashBoardPanel.TabIndex = 7;
            // 
            // incidentsPastDeadLineLabel
            // 
            this.incidentsPastDeadLineLabel.AutoSize = true;
            this.incidentsPastDeadLineLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.incidentsPastDeadLineLabel.Location = new System.Drawing.Point(305, 52);
            this.incidentsPastDeadLineLabel.Name = "incidentsPastDeadLineLabel";
            this.incidentsPastDeadLineLabel.Size = new System.Drawing.Size(198, 25);
            this.incidentsPastDeadLineLabel.TabIndex = 4;
            this.incidentsPastDeadLineLabel.Text = "Incidents past deadline";
            // 
            // unresolvedTicketsLabel
            // 
            this.unresolvedTicketsLabel.AutoSize = true;
            this.unresolvedTicketsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.unresolvedTicketsLabel.Location = new System.Drawing.Point(7, 55);
            this.unresolvedTicketsLabel.Name = "unresolvedTicketsLabel";
            this.unresolvedTicketsLabel.Size = new System.Drawing.Size(181, 25);
            this.unresolvedTicketsLabel.TabIndex = 3;
            this.unresolvedTicketsLabel.Text = "Unresolved incidents";
            // 
            // TitleLabelDashBOardPanel
            // 
            this.TitleLabelDashBOardPanel.AutoSize = true;
            this.TitleLabelDashBOardPanel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.TitleLabelDashBOardPanel.Location = new System.Drawing.Point(11, 9);
            this.TitleLabelDashBOardPanel.Name = "TitleLabelDashBOardPanel";
            this.TitleLabelDashBOardPanel.Size = new System.Drawing.Size(212, 32);
            this.TitleLabelDashBOardPanel.TabIndex = 0;
            this.TitleLabelDashBOardPanel.Text = "Current incidents";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ResetPasswordPanel
            // 
            this.ResetPasswordPanel.Controls.Add(this.UserFoundLabel);
            this.ResetPasswordPanel.Controls.Add(this.ConfirmNewPasswordButton);
            this.ResetPasswordPanel.Controls.Add(this.newPasswordTextBox);
            this.ResetPasswordPanel.Controls.Add(this.newPasswordLabel);
            this.ResetPasswordPanel.Controls.Add(this.confirmButton);
            this.ResetPasswordPanel.Controls.Add(this.ResetPasswordLabelTitle);
            this.ResetPasswordPanel.Controls.Add(this.EmailLabelResetPassword);
            this.ResetPasswordPanel.Controls.Add(this.emailTextBox);
            this.ResetPasswordPanel.Location = new System.Drawing.Point(1, 1);
            this.ResetPasswordPanel.Name = "ResetPasswordPanel";
            this.ResetPasswordPanel.Size = new System.Drawing.Size(615, 483);
            this.ResetPasswordPanel.TabIndex = 13;
            // 
            // UserFoundLabel
            // 
            this.UserFoundLabel.AutoSize = true;
            this.UserFoundLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.UserFoundLabel.Location = new System.Drawing.Point(147, 248);
            this.UserFoundLabel.Name = "UserFoundLabel";
            this.UserFoundLabel.Size = new System.Drawing.Size(336, 21);
            this.UserFoundLabel.TabIndex = 7;
            this.UserFoundLabel.Text = "User found, change password down below:";
            // 
            // ConfirmNewPasswordButton
            // 
            this.ConfirmNewPasswordButton.Location = new System.Drawing.Point(245, 331);
            this.ConfirmNewPasswordButton.Name = "ConfirmNewPasswordButton";
            this.ConfirmNewPasswordButton.Size = new System.Drawing.Size(110, 28);
            this.ConfirmNewPasswordButton.TabIndex = 6;
            this.ConfirmNewPasswordButton.Text = "Confirm password";
            this.ConfirmNewPasswordButton.UseVisualStyleBackColor = true;
            this.ConfirmNewPasswordButton.Click += new System.EventHandler(this.ConfirmNewPasswordButton_Click);
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(245, 287);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(140, 20);
            this.newPasswordTextBox.TabIndex = 5;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(164, 289);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(80, 13);
            this.newPasswordLabel.TabIndex = 4;
            this.newPasswordLabel.Text = "New password:";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(245, 205);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(110, 28);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Confirm email";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // ResetPasswordLabelTitle
            // 
            this.ResetPasswordLabelTitle.AutoSize = true;
            this.ResetPasswordLabelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.ResetPasswordLabelTitle.Location = new System.Drawing.Point(184, 100);
            this.ResetPasswordLabelTitle.Name = "ResetPasswordLabelTitle";
            this.ResetPasswordLabelTitle.Size = new System.Drawing.Size(252, 45);
            this.ResetPasswordLabelTitle.TabIndex = 2;
            this.ResetPasswordLabelTitle.Text = "Reset Password";
            // 
            // EmailLabelResetPassword
            // 
            this.EmailLabelResetPassword.AutoSize = true;
            this.EmailLabelResetPassword.Location = new System.Drawing.Point(202, 162);
            this.EmailLabelResetPassword.Name = "EmailLabelResetPassword";
            this.EmailLabelResetPassword.Size = new System.Drawing.Size(38, 13);
            this.EmailLabelResetPassword.TabIndex = 1;
            this.EmailLabelResetPassword.Text = "Email: ";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(243, 162);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(134, 20);
            this.emailTextBox.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(28, 98);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(202, 182);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // NoSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 484);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.ResetPasswordPanel);
            this.Controls.Add(this.LoginPanel);
            this.Name = "NoSQL";
            this.Text = "NoSQL-Project";
            this.AddIncindentPanel.ResumeLayout(false);
            this.AddIncindentPanel.PerformLayout();
            this.overviewTicketsPanel.ResumeLayout(false);
            this.overviewTicketsPanel.PerformLayout();
            this.UserManagementPanel.ResumeLayout(false);
            this.UserManagementPanel.PerformLayout();
            this.CreateNewUserPanel.ResumeLayout(false);
            this.CreateNewUserPanel.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPanelLogo)).EndInit();
            this.NavigationPanel.ResumeLayout(false);
            this.NavigationPanel.PerformLayout();
            this.DashBoardPanel.ResumeLayout(false);
            this.DashBoardPanel.PerformLayout();
            this.ResetPasswordPanel.ResumeLayout(false);
            this.ResetPasswordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel AddIncindentPanel;
        private Panel LoginPanel;
        private Panel UserManagementPanel;
        private TextBox LoginPanelUsernameTextBox;
        private TextBox LoginPanelPasswordTextBox;
        private Button LoginPanelLoginButton;
        private Label LoginPanelPasswordLabel;
        private Label LoginPanelUsernameLabel;
        private PictureBox LoginPanelLogo;
        private Button LogOutButton;
        private PictureBox pictureBox1;
        private Panel NavigationPanel;
        private Label TitleDetailNavigationPanel;
        private Label TitleNavigationPanel;
        private Button UserManagementButtonNavigationPanel;
        private Button IncidentManagementButtonNavigationPanel;
        private Button DashboardButtonNavigationPanel;
        private Label labelIncidentTicket;
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
        private TextBox FullNameTextboxCreateUserPanel;
        private Label LocationLabelCreateUserPanel;
        private Label PhoneLabelCreateUserPanel;
        private Label EmailLabelCreateUserPanel;
        private Label TypeUserLabelCreateUserPanel;
        private Label FullNameLabelCreateUserPanel;
        private Label HeaderLabelCreateUserPanel;
        private Button AddUserButtonCreateUserPanel;
        private TextBox PhoneTextboxCreateUserPanel;
        private TextBox EmailTextboxCreateUserPanel;
        private ContextMenuStrip contextMenuStrip1;
        private Button CancelButtonCreateUserPanel;
        private ComboBox TypeUserComboboxCreateUserPanel;
        private ComboBox LocationComboboxCreateUserPanel;
        private TextBox UsernameTextboxCreateUserPanel;
        private Label UsernameLabelCreateUserPanel;
        private Label PasswordLabelCreateUserPanel;
        private TextBox PasswordTextboxCreateUserPanel;
        private Panel overviewTicketsPanel;
        private Button createIncidentButton;
        private Label overviewTicketsLabel;
        private ListView overviewTicketsListView;
        private ColumnHeader ticketId;
        private ColumnHeader DateOpened;
        private ColumnHeader SubjectOfIncident;
        private ColumnHeader Deadline;
        private ColumnHeader Status;
        private Panel DashBoardPanel;
        private Label TitleLabelDashBOardPanel;
        private Button closeTicketButton;
        private Button deleteButton;
        private Button updateButton;
        private Label incidentsPastDeadLineLabel;
        private Label unresolvedTicketsLabel;
        private Button createButtonInOverviewTickets;
        private ComboBox sortByPriorityComboBox;
        private Label sortByPriorityLabel;
        private Button TransferServiceDeskEmployeeButton;
        private Label ResetPasswordLabel;
        private Panel ResetPasswordPanel;
        private Button confirmButton;
        private Label ResetPasswordLabelTitle;
        private Label EmailLabelResetPassword;
        private TextBox emailTextBox;
        private Button ConfirmNewPasswordButton;
        private TextBox newPasswordTextBox;
        private Label newPasswordLabel;
        private Label UserFoundLabel;
        private ComboBox StatusComboBoxAddIncidentPanel;
        private Label labelStatusAddIncidentPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

