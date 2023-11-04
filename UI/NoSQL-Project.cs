
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

  
    }
}

