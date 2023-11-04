
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
            UserManagementPanel.Hide();
            EmployeePanel.Hide();
            NavigationPanel.Hide();
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
                    // open employee panel
                    if (foundUser.EmployeeType == TypeOfEmployee.Regular)
                    {
                        HideAllPanels();
                        ShowRegularEmployeePanel();
                    }
                    // open servicedesk panel
                    else if (foundUser.EmployeeType == TypeOfEmployee.ServiceDesk)
                    {
                        HideAllPanels();
                        ShowServicedeskEmployeePanel();
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
            if(!RememberMeCheckBoxLoginPanel.Checked)
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

        private void ShowRegularEmployeePanel()
        {
            NavigationPanel.Show();
            EmployeePanel.Show();

        }
        private void ShowServicedeskEmployeePanel()
        {
            List<Ticket> tickets = ticketLogic.GetAllTickets();

            AllTickets.Items.Clear(); // Clear any existing items in the ListBox.

            foreach (var ticket in tickets)
            {
                AllTickets.Items.Add(ticket.Description); // Display the description in the ListBox.
            }

            UserManagementPanel.Show();

        }



        




    }
}

