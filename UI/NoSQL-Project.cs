
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
        private List<string> serviceDeskEmployeeIds;

        private Ticket selectedTicket;

        public NoSQL()
        {
            userLogic = new UserLogic();
            ticketLogic = new TicketLogic();
            serviceDeskEmployeeIds = userLogic.GetServiceDeskEmployeeIds();

            InitializeComponent();

            HideAllPanels();
            LoginPanel.Show();

        }
        private void HideAllPanels()
        {
            LoginPanel.Hide();
            AddIncindentPanel.Hide();
            NavigationPanel.Hide();
            CreateNewUserPanel.Hide();
            UserManagementPanel.Hide();
            overviewTicketsPanel.Hide();
            DashBoardPanel.Hide();
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
                    NavigationPanel.Show();
                    // open employee panel
                    if (foundUser.EmployeeType == TypeOfEmployee.Regular)
                    {
                        UserManagementButtonNavigationPanel.Enabled = false;
                        FillListViewDashBoard();
                        DashBoardPanel.Show();
                    }
                    // open servicedesk panel
                    else if (foundUser.EmployeeType == TypeOfEmployee.ServiceDesk)
                    {
                        DashboardButtonNavigationPanel.Enabled = false;
                        UserManagementPanel.Show();
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


    
        private void AddNewUserButtonUserManagement_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            NavigationPanel.Show();
            CreateNewUserPanel.Show();
        }

        private void UserManagementButtonNavigationPanel_Click(object sender, EventArgs e)
        {

            HideAllPanels();
            NavigationPanel.Show();
            UserManagementPanel.Show();

            // Refresh the UserListView
            RefreshUserList();
        }

        private void RefreshUserList()
        {
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
            users.Clear();
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
            overviewTicketsPanel.Show();

            UpdateTicketsListView();
        }

        private void sortByPriorityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTicketsListView();
        }

        private void UpdateTicketsListView()
        {
            string selectedPriority = sortByPriorityComboBox.SelectedItem?.ToString();
            List<Ticket> allTickets = ticketLogic.GetAllTickets();
            List<Ticket> filteredTickets;

            if (foundUser.EmployeeType == TypeOfEmployee.ServiceDesk)
            {
                filteredTickets = allTickets;
                createIncidentButton.Hide();
            }
            else if (foundUser.EmployeeType == TypeOfEmployee.Regular)
            {
                filteredTickets = allTickets.Where(ticket => ticket.RegularEmployeeID.EmployeeId == foundUser.Id).ToList();
                updateButton.Hide();
                deleteButton.Hide();
                closeTicketButton.Hide();
                createButtonInOverviewTickets.Hide();
            }
            else
            {
                return; 
            }

            overviewTicketsListView.Items.Clear();

            if (!string.IsNullOrEmpty(selectedPriority) && selectedPriority != "All")
            {
                filteredTickets = FilterTicketsByPriority(filteredTickets, selectedPriority);
            }

            DisplayTicketsInListView(filteredTickets);
        }



        private void DisplayTicketsInListView(List<Ticket> tickets)
        {
            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticket.Id.ToString());
                item.SubItems.Add(ticket.DateOpened);
                item.SubItems.Add(ticket.SubjectOfIncident);
                item.SubItems.Add(ticket.Deadline);
                item.SubItems.Add(ticket.Status);
                overviewTicketsListView.Items.Add(item);
            }
        }


        private List<Ticket> FilterTicketsByPriority(List<Ticket> tickets, string selectedPriority)
        {
            return tickets.Where(ticket => ticket.Priority.ToString() == selectedPriority).ToList();
        }

        private void createIncidentButton_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            NavigationPanel.Show();
            AddIncindentPanel.Show();
        }

        private void cancelButtonInIncidentPanel_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            NavigationPanel.Show();
            overviewTicketsPanel.Show();

        }

        private void submitTicketButtonInIncidentPanel_Click(object sender, EventArgs e)
        {
            try
            {
                if (RequiredFieldsAreEmpty())
                {
                    throw new InvalidOperationException("All required fields must be filled.");
                }

                if (labelIncidentTicket.Text == "Update incident ticket")
                {
                    Ticket updatedTicket = selectedTicket;

                    updatedTicket.SubjectOfIncident = subjectOfIncidentTextBox.Text;
                    updatedTicket.TypeOfIncident = typeOfIncidentComboBox.Text;
                    updatedTicket.ReportedByUser = reportedByUserTextBox.Text;
                    updatedTicket.Priority = Enum.TryParse(priorityComboBox.Text, out Priority selectedPriority) ? selectedPriority : Priority.Normal;
                    updatedTicket.Deadline = deadlineComboBox.Text;
                    updatedTicket.Description = descriptionTextBox.Text;

                    ticketLogic.UpdateTicket(updatedTicket);

                    labelIncidentTicket.Text = "Create new incident ticket";
                    submitTicketButtonInIncidentPanel.Text = "Submit ticket";

                    EmptyTheFieldsInIncidentManagment();
                    MessageBox.Show("Ticket saved successfully!");
                }
                else
                {
                    List<string> serviceDeskEmployeeIds = userLogic.GetServiceDeskEmployeeIds();

                    int nextServiceDeskEmployeeIndex = ticketLogic.GetNextServiceDeskEmployeeIndex(serviceDeskEmployeeIds);
                    string serviceDeskEmployeeId = serviceDeskEmployeeIds[nextServiceDeskEmployeeIndex];


                    Ticket newTicket = CreateNewTicket(serviceDeskEmployeeId);

                    ticketLogic.InsertTicket(newTicket);

                    MessageBox.Show("Ticket saved successfully!");
                    EmptyTheFieldsInIncidentManagment();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool RequiredFieldsAreEmpty()
        {
            return string.IsNullOrEmpty(subjectOfIncidentLabelInIncidentPanel.Text) ||
                string.IsNullOrEmpty(typeOfIncidentComboBox.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(reportedByUserTextBox.Text) ||
                string.IsNullOrEmpty(priorityComboBox.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(deadlineComboBox.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(descriptionTextBox.Text);
        }

        private Ticket CreateNewTicket(string serviceDeskEmployeeId)
        {
            Priority priority = (Priority)Enum.Parse(typeof(Priority), priorityComboBox.Text);
           

            return new Ticket
            {
                DateOpened = DateTime.Now.ToString("dd/MM/yyyy"),
                SubjectOfIncident = subjectOfIncidentTextBox.Text,
                TypeOfIncident = typeOfIncidentComboBox.SelectedItem.ToString(),
                ReportedByUser = reportedByUserTextBox.Text,
                Priority = priority, 
                Deadline = deadlineComboBox.SelectedItem.ToString(),
                Description = descriptionTextBox.Text,
                Status = StatusTicket.Pending.ToString(),
                RegularEmployeeID = new EmployeeReference { EmployeeId = foundUser.Id },
                ServiceDeskEmployeeID = new EmployeeReference { EmployeeId = serviceDeskEmployeeId },
            };
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

        private void CancelButtonCreateUserPanel_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            NavigationPanel.Show();
            UserManagementPanel.Show();
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
            RefreshUserList();
            CreateNewUserPanel.Hide();
            NavigationPanel.Show();
            UserManagementPanel.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            LoginPanel.Show();
        }

        private void DashboardButtonNavigationPanel_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            FillListViewDashBoard();
            NavigationPanel.Show();
            DashBoardPanel.Show();
            
        }

        private void FillListViewDashBoard()
        {

            List<Ticket> allTickets = ticketLogic.GetAllTickets();


            incidentPastDeadLineListView.Items.Clear();
            unresolvedIncidentsListView.Items.Clear();

            foreach (Ticket ticket in allTickets)
            {
                // Check if the ticket belongs to the logged-in employee and has a status indicating it's past deadline
                if (ticket.RegularEmployeeID.EmployeeId == foundUser.Id && ticket.Status == StatusTicket.InProgress.ToString())
                {
                    ListViewItem item = new ListViewItem(ticket.SubjectOfIncident);
                    item.SubItems.Add(ticket.DateOpened);
                    item.SubItems.Add(ticket.Deadline);
                    incidentPastDeadLineListView.Items.Add(item);
                }
            }

            foreach (Ticket ticket in allTickets)
            {
                // Check if the ticket belongs to the logged-in employee and has a status indicating it's unresolved
                if (ticket.RegularEmployeeID.EmployeeId == foundUser.Id && (ticket.Status == StatusTicket.Pending.ToString() || ticket.Status == StatusTicket.Reopened.ToString()))
                {
                    ListViewItem item = new ListViewItem(ticket.SubjectOfIncident);
                    item.SubItems.Add(ticket.DateOpened);
                    item.SubItems.Add(ticket.Deadline);
                    unresolvedIncidentsListView.Items.Add(item);
                }
            }
        }

        // CRUD 
        private void createButtonInOverviewTickets_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            NavigationPanel.Show();
            AddIncindentPanel.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            labelIncidentTicket.Text = "Update incident ticket";
            submitTicketButtonInIncidentPanel.Text = "Update ticket";

            // MAKEN DAT ADDINCIDENTPANEL NAAM NIET ALLEEN VOOR ADD IS MAAR OOK VOOR UPDATE

            HideAllPanels();
            NavigationPanel.Show();
            AddIncindentPanel.Show();

            ListViewItem selectedItem = overviewTicketsListView.SelectedItems[0];

            selectedTicket = ticketLogic.GetTicketById(selectedItem.SubItems[0].Text);

            subjectOfIncidentTextBox.Text = selectedTicket.SubjectOfIncident;
            typeOfIncidentComboBox.Text = selectedTicket.TypeOfIncident;
            reportedByUserTextBox.Text = selectedTicket.ReportedByUser;
            priorityComboBox.Text = selectedTicket.Priority.ToString();
            deadlineComboBox.Text = selectedTicket.Deadline;
            descriptionTextBox.Text = selectedTicket.Description;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = overviewTicketsListView.SelectedItems[0];

            selectedTicket = ticketLogic.GetTicketById(selectedItem.SubItems[0].Text);

            ticketLogic.DeleteTicket(selectedTicket);

            UpdateTicketsListView();
        }

        private void TransferServiceDeskEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selectedItem = overviewTicketsListView.SelectedItems[0];

                selectedTicket = ticketLogic.GetTicketById(selectedItem.SubItems[0].Text);

                User currentServiceDeskEmployee = userLogic.GetUserById(selectedTicket.ServiceDeskEmployeeID.EmployeeId);

                if (selectedTicket != null)
                {
                    string newServiceDeskEmployeeName = Microsoft.VisualBasic.Interaction.InputBox(
                        "Enter the name of the new service desk employee:",
                        "Transfer Ticket",
                        currentServiceDeskEmployee.Name
                    );

                    if (!string.IsNullOrWhiteSpace(newServiceDeskEmployeeName))
                    {
                        User newServiceDeskEmployee = userLogic.GetUserByName(newServiceDeskEmployeeName);

                        if (newServiceDeskEmployee == null)
                        {
                            throw new InvalidOperationException("Service desk employee not found in the database.");
                        }

                        selectedTicket.ServiceDeskEmployeeID.EmployeeId = newServiceDeskEmployee.Id;

                        ticketLogic.UpdateTicket(selectedTicket);

                        UpdateTicketsListView();

                        MessageBox.Show("Ticket transferred to a new service desk employee successfully.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a ticket to transfer.");
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Transfer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

               
    


