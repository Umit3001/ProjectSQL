
using DAL;
using Logic;
using Microsoft.VisualBasic.ApplicationServices;
using Model;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.LinkLabel;
using Timer = System.Windows.Forms.Timer;
using User = Model.User;

namespace UI
{
    public partial class NoSQL : Form
    {
        private User foundUser;

        private UserLogic userLogic;

        private TicketLogic ticketLogic;

        public NoSQL()
        {
            userLogic = new UserLogic();
            ticketLogic = new TicketLogic();

            InitializeComponent();

            HideAllPanels();
            LoginPanel.Show();

        }
        private void HideAllPanels()
        {
            LoginPanel.Hide();
            AddIncendentPanel.Hide();
            NavigationPanel.Hide();
            CreateNewUserPanel.Hide();
           
        }

        // LOGIN
        private void LoginPanelLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = LoginPanelUsernameTextBox.Text;
                string password = LoginPanelPasswordTextBox.Text;


                foundUser = userLogic.FindUser(username, password);

                if (foundUser != null)
                {
                    HideAllPanels();
                    // open employee panel
                    if (foundUser.EmployeeType == TypeOfEmployee.Regular)
                    {
                        UserManagementButtonNavigationPanel.Enabled = false;
                        ShowDashBoardPanel();
                    }
                    // open servicedesk panel
                    else if (foundUser.EmployeeType == TypeOfEmployee.ServiceDesk)
                    {
                        ShowDashBoardPanel();
                    }
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij het inloggen: " + ex.Message);
            }
            if (!RememberMeCheckBoxLoginPanel.Checked)
            {
                LoginPanelUsernameTextBox.Text = "";
                LoginPanelPasswordTextBox.Text = "";
            }
        }
        private void ServicedeskPanelBackButton_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            LoginPanel.Show();
        }

        private void EmployeePanelBackButton_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            LoginPanel.Show();
        }

        private void ShowDashBoardPanel()
        {
            HideAllPanels();
            NavigationPanel.Show();
            AddIncendentPanel.Show(); //hier moet dashboard komen
        }
        private void AddNewUserButtonUserManagement_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            CreateNewUserPanel.Show();
        }

        private void UserManagementButtonNavigationPanel_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            NavigationPanel.Show();
            UserManagementPanel.Show();
            List<User> users = userLogic.GetAllUsers();

            UserListView.Items.Clear();

            foreach (var user in users)
            {
                int totalTicketsCreatedByUser = GetTotalTicketsCreatedByUser(user.Id); // Calculate the total tickets for the user
                ListViewItem item = new ListViewItem(user.Id);
                item.SubItems.Add(user.Email);
                item.SubItems.Add(user.Name);
                item.SubItems.Add(totalTicketsCreatedByUser.ToString()); // Display the total tickets

                UserListView.Items.Add(item);
            }

            
        }

        private int GetTotalTicketsCreatedByUser(string userId)
        {
            List<Ticket> tickets = ticketLogic.GetAllTickets();

            int totalTicketsCreatedByUser = 0;

            foreach (Ticket ticket in tickets)
            {
                if (ticket.RegularEmployeeID != null && ticket.RegularEmployeeID.EmployeeId == userId)
                {
                    totalTicketsCreatedByUser++;
                }
            }

            return totalTicketsCreatedByUser;
        }

        private void FilterByEmailTextBoxUserManagement_TextChanged(object sender, EventArgs e)
        {
            FilterUserListByEmail(userLogic.GetAllUsers(), FilterByEmailTextBoxUserManagement.Text);
        }
        private void FilterUserListByEmail(List<User> users, string filter)
        {
            // Clear the current items in the ListView
            UserListView.Items.Clear();

            // Iterate through the users and filter by email
            foreach (var user in users)
            {
                int totalTicketsCreatedByUser = GetTotalTicketsCreatedByUser(user.Id);

                // Check if the email contains the filter text (with at least 3 letters)
                if (string.IsNullOrEmpty(filter) || filter.Length < 3 || user.Email.Contains(filter, StringComparison.OrdinalIgnoreCase))
                {
                    ListViewItem item = new ListViewItem(user.Id);
                    item.SubItems.Add(user.Email);
                    item.SubItems.Add(user.Name);
                    item.SubItems.Add(totalTicketsCreatedByUser.ToString());

                    UserListView.Items.Add(item);
                }
            }
        }

        private void IncidentManagementButtonNavigationPanel_Click(object sender, EventArgs e)
        {
           
            HideAllPanels();
            NavigationPanel.Show();
            AddIncendentPanel.Show();
        }

        private void submitTicketButtonInIncidentPanel_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(subjectOfIncidentLabelInIncidentPanel.Text) ||
                    string.IsNullOrEmpty(typeOfIncidentComboBox.SelectedItem?.ToString()) ||
                    string.IsNullOrEmpty(reportedByUserTextBox.Text) ||
                    string.IsNullOrEmpty(priorityComboBox.SelectedItem?.ToString()) ||
                    string.IsNullOrEmpty(deadlineComboBox.SelectedItem?.ToString()) ||
                    string.IsNullOrEmpty(descriptionTextBox.Text))
                {
                    throw new InvalidOperationException("All required fields must be filled.");
                }

                Ticket newTicket = new Ticket
                {
                    DateOpened = DateTime.Now.ToString("dd/MM/yyyy"),
                    SubjectOfIncident = subjectOfIncidentTextBox.Text,
                    TypeOfIncident = typeOfIncidentComboBox.SelectedItem.ToString(),
                    ReportedByUser = reportedByUserTextBox.Text,
                    Priority = priorityComboBox.SelectedItem.ToString(),
                    Deadline = deadlineComboBox.SelectedItem.ToString(),
                    Description = descriptionTextBox.Text,
                    Status = StatusTicket.Pending.ToString(),
                    RegularEmployeeID = new EmployeeReference { EmployeeId = foundUser.Id }
                };

                ticketLogic.InsertTicket(newTicket);

                MessageBox.Show("Ticket saved successfully!");
                EmptyTheFieldsInIncidentManagment();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EmptyTheFieldsInIncidentManagment()
        {
            subjectOfIncidentTextBox.Text = string.Empty;
            typeOfIncidentComboBox.SelectedIndex = -1;
            reportedByUserTextBox.Text = string.Empty;
            priorityComboBox.SelectedIndex = -1;
            deadlineComboBox.SelectedIndex = -1;
            descriptionTextBox.Text = string.Empty;

        }

<<<<<<< Updated upstream
 
=======
        // Create User Part
        private void CancelButtonCreateUserPanel_Click(object sender, EventArgs e)
        {

        }

        private void AddUserButtonCreateUserPanel_Click(object sender, EventArgs e)
        {
            string name = FullNameTextboxCreateUserPanel.Text;
            string userName = UsernameTextboxCreateUserPanel.Text;
            string password = PasswordTextboxCreateUserPanel.Text;
            TypeOfEmployee employeeType = (TypeOfEmployee)Enum.Parse(typeof(TypeOfEmployee), TypeUserComboboxCreateUserPanel.Text);
            string email = EmailTextboxCreateUserPanel.Text;
            string phoneNumber = PhoneTextboxCreateUserPanel.Text;
            Location location = (Location)Enum.Parse(typeof(Location), LocationComboboxCreateUserPanel.Text);

            User newUser = new User
            { 
                Name = name,
                Username = userName,
                Password = password,
                Email = email,
                PhoneNumber = phoneNumber,
                UserLocation = location,
                EmployeeType = employeeType
            };

            userLogic.AddUser(newUser);

            FullNameTextboxCreateUserPanel.Text = "";
            UsernameTextboxCreateUserPanel.Text = "";
            PasswordTextboxCreateUserPanel.Text = "";
            EmailTextboxCreateUserPanel.Text = "";
            PhoneTextboxCreateUserPanel.Text = "";
            TypeUserComboboxCreateUserPanel.SelectedIndex = -1;
            LocationComboboxCreateUserPanel.SelectedIndex = -1;

            MessageBox.Show("User successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EmployeePanel_Paint(object sender, PaintEventArgs e)
        {

        }
>>>>>>> Stashed changes
    }


}

               
    


