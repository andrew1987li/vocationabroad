<%@ Page Language="C#" Debug="true" MasterPageFile="/masterpage/NormalMaster.master" AutoEventWireup="true" CodeFile="AccountInformation.aspx.cs" Inherits="AccountInformation" Title="Account Information" %>

<asp:Content ID="title" ContentPlaceHolderID="head" runat="server">
    Account Information
</asp:Content>

<asp:Content ID="links" ContentPlaceHolderID="links" runat="server">
    <link href="/Assets/css/accountinfo.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="bodycontent" runat="Server">
    <div class="internalpagewidth">
    <div class="newline centered">
  <% if (BackLink.Visible)
       { %>
    <table bgcolor="#e4e4af" cellspacing="0" cellpadding="0" width="250" align="center" border="2">
        <tr>
            <td>
                <div align="center">
                    <strong>
                        <asp:HyperLink ID="BackLink" runat="server" NavigateUrl="MyAccount.aspx">
							Return to My Account page
                        </asp:HyperLink>
                    </strong>
                </div>
            </td>
        </tr>
    </table>
    
    <% } %>
    <asp:Label ID="UsernameWrongWarning" runat="server" ForeColor="Red" Visible="False" Width="100%">
		Incorrect login name or password. Please check whether Caps Lock is pressed and retry entering password,
		if it fails again contact support. If you have lost your password see the section below.
    </asp:Label>
    <table cellspacing="1" cellpadding="1" bgcolor="#cfdfef" border="0" width="100%">  
        <tr valign="top" align="left">
            <td style="height: 26px; width: 140px;">
                Login name:
            </td>
            <td style="height: 26px; width: 13px;">
                <font color="red">* </font>
            </td>
            <td bgcolor="#ffffff" style="height: 26px">
                <asp:TextBox ID="Username" Width="216" runat="server" ReadOnly="True" Text='<%# MainDataSet.Tables["Users"].Rows[0]["Username"] %>' />
                <asp:RequiredFieldValidator ID="UsernameRequired" runat="server" ControlToValidate="Username" Display="Dynamic" ErrorMessage="Please enter login name" Enabled="False" />
                <asp:RegularExpressionValidator ID="UsernameInvalid" runat="server" ControlToValidate="Username" Display="Dynamic" ErrorMessage="Too long login name entered" ValidationExpression="^.{1,30}$"
                    Enabled="False" />
                <asp:Label ID="DuplicateUsername" runat="server" ForeColor="Red" Visible="False">
					Duplicate login name/email, please select another one
                </asp:Label>
            </td>
        </tr>
        <tr valign="top" align="left">
            <td style="width: 140px">
                Email Address:
            </td>
            <td style="width: 13px">
                <font color="red">*</font>
            </td>
            <td bgcolor="#ffffff">
                <asp:TextBox ID="EmailAddress" Width="304" runat="server"
                    Text='<%# MainDataSet.Tables["Users"].Rows[0]["Email"] %>' />
                <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="EmailAddress" Display="Dynamic" ErrorMessage="Please enter e-mail address" />
                <asp:RegularExpressionValidator ID="EmailInvalid" runat="server" ControlToValidate="EmailAddress" Display="Dynamic" ErrorMessage="Invalid e-mail address entered" ValidationExpression="^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$" />
                <asp:RegularExpressionValidator ID="EmailTooLong" runat="server" ControlToValidate="EmailAddress" Display="Dynamic" ErrorMessage="Too long email address entered" ValidationExpression="^.{1,80}$" />
                <br />
                This is the default email for all functions associated with this account.
            </td>
        </tr>
        <% if (OldPassword.Visible)
           { %>
        <tr valign="top" align="left">
            <td style="width: 140px">
                <asp:Label ID="OldPasswordLabel" runat="server">Old Password:</asp:Label>
            </td>
            <td style="width: 13px">
                <asp:Label ID="OldPasswordAsterisk" runat="server" ForeColor="Red">*</asp:Label>
            </td>
            <td bgcolor="#ffffff">
                <asp:TextBox ID="OldPassword" Width="216" runat="server" TextMode="Password" />
                <asp:RequiredFieldValidator ID="OldPasswordRequired" runat="server" ControlToValidate="OldPassword" Display="Dynamic" ErrorMessage="Please enter password" />
                <asp:RegularExpressionValidator ID="OldPasswordInvalid" runat="server" ControlToValidate="OldPassword" Display="Dynamic" ErrorMessage="Too long password entered" ValidationExpression="^.{1,30}$" />&nbsp;
            </td>
        </tr>
        <% } %>
        <tr valign="top" align="left">
            <td style="width: 140px">
                New Password:
            </td>
            <td style="width: 13px">
                <asp:Label ID="NewPasswordAsterisk" runat="server" ForeColor="Red" Visible="False">*</asp:Label>
            </td>
            <td bgcolor="#ffffff">
                <asp:TextBox ID="NewPassword" Width="216" runat="server" TextMode="Password" />
                <asp:RequiredFieldValidator ID="NewPasswordRequired" runat="server" ControlToValidate="NewPassword" Display="Dynamic" ErrorMessage="Please enter password" Enabled="False" />
                <asp:RegularExpressionValidator ID="NewPasswordInvalid" runat="server" ControlToValidate="NewPassword" Display="Dynamic" ErrorMessage="Too long password entered" ValidationExpression="^.{1,30}$" />
            </td>
        </tr>
        <tr valign="top" align="left">
            <td style="width: 140px">
                Reenter Password:
            </td>
            <td style="width: 13px">
                <asp:Label ID="NewPassword2Asterisk" runat="server" ForeColor="Red" Visible="False">*</asp:Label>
            </td>
            <td bgcolor="#ffffff">
                <asp:TextBox ID="NewPassword2" Width="216" runat="server" TextMode="Password" />
                <asp:CompareValidator ID="PasswordsSame" runat="server" ControlToCompare="NewPassword"
                    ControlToValidate="NewPassword2" Display="Dynamic" ErrorMessage="Passwords must be the same" />
            </td>
        </tr>
        <tr valign="top" align="left">
            <td style="width: 140px">
                User ID:
            </td>
            <td style="width: 13px">
            </td>
            <td bgcolor="#ffffff">
                <asp:TextBox ID="UserID" Width="216" runat="server"
                    Text='<%# MainDataSet.Tables["Users"].Rows[0]["UserID"] %>' />
                Create an ID different from you Login Name.
				<font color="red">
                    <asp:RegularExpressionValidator ID="UserIDValid" runat="server" ControlToValidate="UserID" ErrorMessage="Max 7 Characters. No spaces and must contain alphanumeric only." ValidationExpression="^[a-zA-Z0-9]{1,7}$" Display="Dynamic" />
                </font>
            </td>
        </tr>
        <tr valign="top" align="left">
            <td style="width: 140px">
                &nbsp;
            </td>
            <td style="width: 13px">
            </td>
            <td bgcolor="#ffffff">
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" Width="96px" /> &nbsp; 
                <asp:Button ID="CancelButton" runat="server" Text="Cancel" CausesValidation="False" OnClick="CancelButton_Click" Width="96px" />
            </td>
        </tr>
    </table>
    </div>
    </div>

  

    <script src="/Assets/js/accountinfo.js"></script>
</asp:Content>
