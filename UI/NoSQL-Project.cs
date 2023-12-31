﻿using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI
{
    public partial class NoSQL : Form
    {
        private User foundUser;

        private UserLogic userLogic;

        private TicketLogic ticketLogic;
        private List<string> serviceDeskEmployeeIds;
        private List<Ticket> ticketList;

        private Ticket selectedTicket;
        private User currentUser;

        private TransferTicketLogic transferTicketLogic;
        private ResetPasswordLogic passwordLogic;

        public NoSQL()
        {
            userLogic = new UserLogic();
            ticketLogic = new TicketLogic();
            transferTicketLogic = new TransferTicketLogic();
            passwordLogic = new ResetPasswordLogic();
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
            ResetPasswordPanel.Hide();
        }

        // LOGIN
        private void LoginPanelLoginButton_Click(object sender, EventArgs e)
        {
           


                string username = LoginPanelUsernameTextBox.Text;
                string password = LoginPanelPasswordTextBox.Text;


                foundUser = userLogic.FindUser(username, password);

                if (foundUser != null)
                {
                    HideAllPanels();
                    NavigationPanel.Show();

                    RoleLabel.Text = $"{foundUser.Name} ({foundUser.EmployeeType})";
                    UserManagementButtonNavigationPanel.Enabled = true;
                    DashboardButtonNavigationPanel.Enabled = true;

                    // open employee panel
                    if (foundUser.EmployeeType == TypeOfEmployee.Regular)
                    {
                        UserManagementButtonNavigationPanel.Enabled = false;
                        FillDashboard();
                        DashBoardPanel.Show();
                        labelIncidentTicket.Text = "Create new incident ticket";
                        submitTicketButtonInIncidentPanel.Text = "Submit ticket";
                        subjectOfIncidentTextBox.Text = "";
                        typeOfIncidentComboBox.SelectedIndex = -1;
                        reportedByUserTextBox.Text = "";
                        priorityComboBox.SelectedIndex = -1;
                        deadlineComboBox.SelectedIndex = -1;
                        descriptionTextBox.Text = "";
                        StatusComboBoxAddIncidentPanel.SelectedIndex = -1;

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

            UserListView.Items.Clear();

            List<User> users = userLogic.GetAllUsers();


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
                if (string.IsNullOrEmpty(filter) || filter.Length < 3 || user.Email.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
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
                updateButton.Show();
                deleteButton.Show();
                closeTicketButton.Show();
                createButtonInOverviewTickets.Show();
                TransferServiceDeskEmployeeButton.Show();
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
                TransferServiceDeskEmployeeButton.Hide();
                createIncidentButton.Show();
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
            if (labelIncidentTicket.Text == "Update incident ticket")
            {
                labelStatusAddIncidentPanel.Show();
                StatusComboBoxAddIncidentPanel.Show();
            }
            else
            {
                labelStatusAddIncidentPanel.Hide();
                StatusComboBoxAddIncidentPanel.Hide();
            }
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
                    updatedTicket.Status = StatusComboBoxAddIncidentPanel.Text;

                    ticketLogic.UpdateTicket(updatedTicket);

                    labelIncidentTicket.Text = "Create new incident ticket";
                    submitTicketButtonInIncidentPanel.Text = "Submit ticket";

                    EmptyTheFieldsInIncidentManagment();
                    MessageBox.Show("Ticket saved successfully!");

                    overviewTicketsPanel.Show();

                    UpdateTicketsListView();
                }
                else
                {
                    List<string> serviceDeskEmployeeIds = userLogic.GetServiceDeskEmployeeIds();

                    int nextServiceDeskEmployeeIndex = ticketLogic.GetNextServiceDeskEmployeeIndex(serviceDeskEmployeeIds);
                    string serviceDeskEmployeeId = serviceDeskEmployeeIds[nextServiceDeskEmployeeIndex];


                    Ticket newTicket = CreateNewTicket(serviceDeskEmployeeId);

                    ticketLogic.InsertTicket(newTicket);

                    EmptyTheFieldsInIncidentManagment();

                    MessageBox.Show("Ticket saved successfully!");
                   
                    overviewTicketsPanel.Show();

                    UpdateTicketsListView();
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
            StatusComboBoxAddIncidentPanel.SelectedIndex = -1;
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
            FillDashboard();
            NavigationPanel.Show();
            DashBoardPanel.Show();

        }

        private DateTime DateOpenedParse(string dateOpened)
        {
            int day = 0;
            int month = 0;
            int year = 0;

            if (dateOpened.Contains("-"))
            {
                string[] dates = dateOpened.Split('-');

                day = int.Parse(dates[0]);
                month = int.Parse(dates[1]);
                year = int.Parse(dates[2]);

            }
            else if (dateOpened.Contains("/"))
            {
                string[] dates = dateOpened.Split('/');

                day = int.Parse(dates[0]);
                month = int.Parse(dates[1]);
                year = int.Parse(dates[2]);

            }

            return new DateTime(year, month, day);
        }



        private DateTime DeadLineParse(string duration, string dateOpened)
        {
            DateTime dateOpenedTicket = DateOpenedParse(dateOpened);

            if (duration.Contains("hour") || duration.Contains("hours"))
            {
                int hours = int.Parse(duration.Split(' ')[0]);
                dateOpenedTicket = dateOpenedTicket.AddHours(hours);
            }
            else if (duration.Contains("day") || duration.Contains("days"))
            {
                int days = int.Parse(duration.Split(' ')[0]);
                dateOpenedTicket = dateOpenedTicket.AddDays(days);
            }
            else if (duration.Contains("week") || duration.Contains("weeks"))
            {
                int weeks = int.Parse(duration.Split(' ')[0]);
                dateOpenedTicket = dateOpenedTicket.AddDays(weeks * 7);
            }

            return dateOpenedTicket;
        }

        private void FillDashboard()
        {
          
                if (foundUser.EmployeeType == TypeOfEmployee.ServiceDesk)
                {
                    ticketList = ticketLogic.GetAllTickets();
                }
                else if (foundUser.EmployeeType == TypeOfEmployee.Regular)
                {
                    ticketList = ticketLogic.GetTicketsForUser(foundUser.Id);
                }

                UnResolvedIncidentsPie();
                DeadlinePastIncidentsPie();

        }

        private void UnResolvedIncidentsPie()
        {
            pie1.Series.Clear();

            int unresolvedIncidentsCount = ticketList.Count(ticket => ticket.Status != StatusTicket.Closed.ToString());

            Color colorSelect = Color.Orange;
            Series series = PopulatePieUnResolved(unresolvedIncidentsCount, "UnresolvedIncidents", colorSelect);

            unreseolvedIncidentsLabelAmount.Text = $"{unresolvedIncidentsCount} / {ticketList.Count}";
            
            pie1.Series.Add(series);
        }

        private void DeadlinePastIncidentsPie()
        {
            pie2.Series.Clear();
            Color incidentColor = Color.Red;

            // Filter incidents that have passed the deadline
            var pastDeadlineIncidents = ticketList
                .Where(ticket =>
                {
                    DateTime deadlineDateTime = DeadLineParse(ticket.Deadline, ticket.DateOpened);

                    return deadlineDateTime < DateTime.Now;
                })
                .ToList();

            Series series = PopulatePieDeadline(pastDeadlineIncidents.Count, "PastDeadline", incidentColor);

            incidentsPastDeadlineAmountLabel.Text = pastDeadlineIncidents.Count.ToString();

            pie2.Series.Add(series);


        }


        private Series PopulatePieUnResolved(int countTheIncidents, string propSeries, Color color)
        {
            Series series = new Series(propSeries);


            series.Points.AddXY("", ticketList.Count - countTheIncidents);
            series.Points.AddXY("", countTheIncidents);

            series.Points[0].Color = Color.Gray;
            series.Points[1].Color = color;


            series.IsVisibleInLegend = false;
            series.ChartType = SeriesChartType.Doughnut;

            return series;
        }

        private Series PopulatePieDeadline(int countTheIncidents, string propSeries, Color color)
        {
            Series series = new Series(propSeries);


            series.Points.AddXY("", ticketList.Count - countTheIncidents);
            series.Points.AddXY("", countTheIncidents);

            series.Points[0].Color = Color.Red;
            series.Points[1].Color = color;


            series.IsVisibleInLegend = false;
            series.ChartType = SeriesChartType.Doughnut;

            return series;
        }


        private void ShowListButton_Click(object sender, EventArgs e)
        {
           HideAllPanels();
           NavigationPanel.Show();
            overviewTicketsPanel.Show();
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
            StatusComboBoxAddIncidentPanel.Text = selectedTicket.Status;
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
                ListViewItem selectedItem = overviewTicketsListView.SelectedItems.Count > 0 ? overviewTicketsListView.SelectedItems[0] : null;

                if (selectedItem != null)
                {
                    selectedTicket = ticketLogic.GetTicketById(selectedItem.SubItems[0].Text);

                    User currentServiceDeskEmployee = transferTicketLogic.GetUserById(selectedTicket.ServiceDeskEmployeeID.EmployeeId);

                    string newServiceDeskEmployeeName = ShowInputDialog("Enter employee", "Transfer Ticket", currentServiceDeskEmployee.Name);

                    if (!string.IsNullOrWhiteSpace(newServiceDeskEmployeeName))
                    {
                        User newServiceDeskEmployee = transferTicketLogic.GetUserByName(newServiceDeskEmployeeName);

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

        // Custom input dialog function
        private string ShowInputDialog(string prompt, string title, string defaultValue = "")
        {
            Form promptForm = new Form();
            promptForm.Width = 300;
            promptForm.Height = 150;
            promptForm.Text = title;

            Label textLabel = new Label() { Left = 50, Top = 20, Text = prompt };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200, Text = defaultValue };
            Button confirmation = new Button() { Text = "Ok", Left = 100, Width = 100, Top = 70 };

            confirmation.Click += (sender, e) => { promptForm.Close(); };

            promptForm.Controls.Add(confirmation);
            promptForm.Controls.Add(textLabel);
            promptForm.Controls.Add(textBox);

            promptForm.ShowDialog();

            return textBox.Text;
        }

        private void ResetPasswordLabel_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            ResetPasswordPanel.Show();

            newPasswordLabel.Hide();
            newPasswordTextBox.Hide();
            ConfirmNewPasswordButton.Hide();
            UserFoundLabel.Hide();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                string email = emailTextBox.Text;
                string newPassword = newPasswordTextBox.Text;

                // Check if the email exists in the database
                currentUser = passwordLogic.GetUserByEmail(email);

                if (currentUser != null)
                {

                    newPasswordLabel.Show();
                    newPasswordTextBox.Show();
                    ConfirmNewPasswordButton.Show();
                    UserFoundLabel.Show();

                    emailTextBox.Hide();
                    confirmButton.Hide();
                    EmailLabelResetPassword.Hide();

                }
                else
                {
                    // Email doesn't exist in the database
                    MessageBox.Show("No user found with the provided email address.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ConfirmNewPasswordButton_Click(object sender, EventArgs e)
        {
            try
            {
                string newPassword = newPasswordTextBox.Text;

                if (currentUser != null)
                {
                    // Update the user's password
                    passwordLogic.UpdateUserPassword(currentUser.Id, newPassword);

                    MessageBox.Show("Your password is reset!");

                }

                HideAllPanels();
                LoginPanel.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void closeTicketButton_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = overviewTicketsListView.SelectedItems[0];

            selectedTicket = ticketLogic.GetTicketById(selectedItem.SubItems[0].Text);

            ticketLogic.CloseTicket(selectedTicket);

            UpdateTicketsListView();
        }
    }
}

