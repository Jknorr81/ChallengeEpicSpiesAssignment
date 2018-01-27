<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 190px;
            height: 223px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img class="auto-style1" src="epic-spies-logo.jpg" /><br />
        <br />
        <h2>Spy New Assignment Form</h2>
        Spy Code Name:&nbsp;
        <asp:TextBox ID="spyNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        New Assignment Name:&nbsp;
        <asp:TextBox ID="newAssignmentTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        End Date of Previous Assignment:<br />
        <asp:Calendar ID="endDateCalendar" runat="server"></asp:Calendar>
        <br />
        Start Date of New Assignment:<br />
        <asp:Calendar ID="startDateCalendar" runat="server"></asp:Calendar>
        <br />
        Projected End Date of New Assignment:<br />
        <asp:Calendar ID="projectedEndDateCalendar" runat="server"></asp:Calendar>
        <br />
        <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Spy" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
