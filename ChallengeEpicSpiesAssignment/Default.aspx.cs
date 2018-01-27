using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                endDateCalendar.SelectedDate = DateTime.Today;
                startDateCalendar.SelectedDate = DateTime.Today.AddDays(14);
                startDateCalendar.VisibleDate = DateTime.Today.AddDays(14);
                projectedEndDateCalendar.SelectedDate = DateTime.Today.AddDays(21);
                projectedEndDateCalendar.VisibleDate = DateTime.Today.AddDays(21);
            }

            Page.MaintainScrollPositionOnPostBack = true;
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            TimeSpan daysBetweenAssignment = startDateCalendar.SelectedDate.Subtract(endDateCalendar.SelectedDate);
            int days = int.Parse(daysBetweenAssignment.TotalDays.ToString());
            
            if (days < 14)
            {
                resultLabel.Text = "Error, you must give our agents at least 14 days off between assignments.";
                startDateCalendar.SelectedDate = endDateCalendar.SelectedDate.AddDays(14);
                startDateCalendar.VisibleDate = endDateCalendar.SelectedDate.AddDays(14);
            }  
            else
            {
                TimeSpan assignmentDays = projectedEndDateCalendar.SelectedDate.Subtract(startDateCalendar.SelectedDate);
                int totalDays = int.Parse(assignmentDays.TotalDays.ToString());
                int budget = totalDays * 500;
                if (budget > 10500)
                {
                    budget = budget + 1000;
                }

                resultLabel.Text = string.Format("Assignment of {0} to project {1} is authorized!" +
                    "<br />Budget for project is {2:C}",
                    spyNameTextBox.Text, 
                    newAssignmentTextBox.Text, 
                    budget);
            }
               
        }
    }
}