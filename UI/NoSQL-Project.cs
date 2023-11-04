
using Logic;
using Model;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.LinkLabel;
using Timer = System.Windows.Forms.Timer;

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
            ServicedeskPanel.Hide();
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
            LoginPanelUsernameTextBox.Text = "";
            LoginPanelPasswordTextBox.Text = "";

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
            NavigationPanel.Show();
<<<<<<< Updated upstream
            AddIncendentPanel.Show();


=======
            EmployeePanel.Show();
>>>>>>> Stashed changes
        }
        private void ShowServicedeskEmployeePanel()
        {
            List<Ticket> tickets = ticketLogic.GetAllTickets();

            AllTickets.Items.Clear(); // Clear any existing items in the ListBox.

            foreach (var ticket in tickets)
            {
                AllTickets.Items.Add(ticket.Description); // Display the description in the ListBox.
            }

            ServicedeskPanel.Show();

        }

<<<<<<< Updated upstream
       
=======
        private void AddNewUserButtonUserManagement_Click(object sender, EventArgs e)
        {
            CreateNewUserPanel.Show();
        }

        private void UserManagementButtonNavigationPanel_Click(object sender, EventArgs e)
        {
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
>>>>>>> Stashed changes
    }
}

