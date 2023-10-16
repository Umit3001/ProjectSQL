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
            this.EmployeePanelBackButton = new System.Windows.Forms.Button();
            this.ServicedeskPanel = new System.Windows.Forms.Panel();
            this.ServicedeskPanelBackButton = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginPanelUsernameTextBox = new System.Windows.Forms.TextBox();
            this.LoginPanelPasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginPanelLoginButton = new System.Windows.Forms.Button();
            this.LoginPanelPasswordLabel = new System.Windows.Forms.Label();
            this.LoginPanelUsernameLabel = new System.Windows.Forms.Label();
            this.LoginPanelLogo = new System.Windows.Forms.PictureBox();
            this.EmployeePanel.SuspendLayout();
            this.ServicedeskPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPanelLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // AllTickets
            // 
            this.AllTickets.FormattingEnabled = true;
            this.AllTickets.ItemHeight = 15;
            this.AllTickets.Location = new System.Drawing.Point(261, 79);
            this.AllTickets.Name = "AllTickets";
            this.AllTickets.Size = new System.Drawing.Size(553, 409);
            this.AllTickets.TabIndex = 0;
            // 
            // EmployeePanel
            // 
            this.EmployeePanel.Controls.Add(this.EmployeePanelBackButton);
            this.EmployeePanel.Location = new System.Drawing.Point(7, 4);
            this.EmployeePanel.Name = "EmployeePanel";
            this.EmployeePanel.Size = new System.Drawing.Size(1007, 612);
            this.EmployeePanel.TabIndex = 1;
            // 
            // EmployeePanelBackButton
            // 
            this.EmployeePanelBackButton.Location = new System.Drawing.Point(29, 527);
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
            this.ServicedeskPanel.Location = new System.Drawing.Point(4, 5);
            this.ServicedeskPanel.Name = "ServicedeskPanel";
            this.ServicedeskPanel.Size = new System.Drawing.Size(1004, 612);
            this.ServicedeskPanel.TabIndex = 1;
            // 
            // ServicedeskPanelBackButton
            // 
            this.ServicedeskPanelBackButton.Location = new System.Drawing.Point(43, 560);
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
            this.LoginPanel.Controls.Add(this.LoginPanelUsernameTextBox);
            this.LoginPanel.Controls.Add(this.LoginPanelPasswordTextBox);
            this.LoginPanel.Controls.Add(this.LoginPanelLoginButton);
            this.LoginPanel.Controls.Add(this.LoginPanelPasswordLabel);
            this.LoginPanel.Controls.Add(this.LoginPanelUsernameLabel);
            this.LoginPanel.Controls.Add(this.LoginPanelLogo);
            this.LoginPanel.Location = new System.Drawing.Point(3, 2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1013, 610);
            this.LoginPanel.TabIndex = 4;
            // 
            // LoginPanelUsernameTextBox
            // 
            this.LoginPanelUsernameTextBox.Location = new System.Drawing.Point(431, 325);
            this.LoginPanelUsernameTextBox.Name = "LoginPanelUsernameTextBox";
            this.LoginPanelUsernameTextBox.Size = new System.Drawing.Size(186, 23);
            this.LoginPanelUsernameTextBox.TabIndex = 7;
            // 
            // LoginPanelPasswordTextBox
            // 
            this.LoginPanelPasswordTextBox.Location = new System.Drawing.Point(431, 377);
            this.LoginPanelPasswordTextBox.Name = "LoginPanelPasswordTextBox";
            this.LoginPanelPasswordTextBox.Size = new System.Drawing.Size(186, 23);
            this.LoginPanelPasswordTextBox.TabIndex = 6;
            // 
            // LoginPanelLoginButton
            // 
            this.LoginPanelLoginButton.Location = new System.Drawing.Point(503, 433);
            this.LoginPanelLoginButton.Name = "LoginPanelLoginButton";
            this.LoginPanelLoginButton.Size = new System.Drawing.Size(114, 39);
            this.LoginPanelLoginButton.TabIndex = 5;
            this.LoginPanelLoginButton.Text = "Log in";
            this.LoginPanelLoginButton.UseVisualStyleBackColor = true;
            this.LoginPanelLoginButton.Click += new System.EventHandler(this.LoginPanelLoginButton_Click);
            // 
            // LoginPanelPasswordLabel
            // 
            this.LoginPanelPasswordLabel.AutoSize = true;
            this.LoginPanelPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginPanelPasswordLabel.Location = new System.Drawing.Point(307, 375);
            this.LoginPanelPasswordLabel.Name = "LoginPanelPasswordLabel";
            this.LoginPanelPasswordLabel.Size = new System.Drawing.Size(86, 21);
            this.LoginPanelPasswordLabel.TabIndex = 4;
            this.LoginPanelPasswordLabel.Text = "Password:";
            // 
            // LoginPanelUsernameLabel
            // 
            this.LoginPanelUsernameLabel.AutoSize = true;
            this.LoginPanelUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginPanelUsernameLabel.Location = new System.Drawing.Point(307, 322);
            this.LoginPanelUsernameLabel.Name = "LoginPanelUsernameLabel";
            this.LoginPanelUsernameLabel.Size = new System.Drawing.Size(91, 21);
            this.LoginPanelUsernameLabel.TabIndex = 3;
            this.LoginPanelUsernameLabel.Text = "Username:";
            // 
            // LoginPanelLogo
            // 
            this.LoginPanelLogo.Image = global::UI.Properties.Resources.TheGardenGroupLogo;
            this.LoginPanelLogo.Location = new System.Drawing.Point(262, 67);
            this.LoginPanelLogo.Name = "LoginPanelLogo";
            this.LoginPanelLogo.Size = new System.Drawing.Size(467, 172);
            this.LoginPanelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPanelLogo.TabIndex = 1;
            this.LoginPanelLogo.TabStop = false;
            // 
            // NoSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 615);
            this.Controls.Add(this.ServicedeskPanel);
            this.Controls.Add(this.EmployeePanel);
            this.Controls.Add(this.LoginPanel);
            this.Name = "NoSQL";
            this.Text = "NoSQL-Project";
            this.EmployeePanel.ResumeLayout(false);
            this.ServicedeskPanel.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPanelLogo)).EndInit();
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
    }
}