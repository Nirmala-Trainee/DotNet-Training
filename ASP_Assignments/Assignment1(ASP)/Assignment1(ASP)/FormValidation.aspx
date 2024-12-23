<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormValidation.aspx.cs" Inherits="Assignment1_ASP_.FormValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <body>
<form id="form1" runat="server">
<div>
<h1>Insert your details : </h1>
<asp:Label ID="label1" runat="server">Name</asp:Label>&nbsp:&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextName" runat="server" Height="22px" CausesValidation="True"
></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name should not be empty" ForeColor="Red" ControlToValidate="TextName">*</asp:RequiredFieldValidator>
<br />
<br />
            FamilyName :&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextFamilyName" runat="server" Width="100px"></asp:TextBox>
&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Name must be different from family name" ForeColor="Red" ControlToValidate="TextFamilyName">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Name must be different from family name" ForeColor="Red" ControlToCompare="TextName" ControlToValidate="TextFamilyName" Operator="NotEqual"></asp:CompareValidator>
<br />
<br />
            Address&nbsp;&nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextAddress" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Address should contain at least 2 letters" ForeColor="Red" ControlToValidate="TextAddress">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextAddress" ErrorMessage="Address should contain at least 2 letters" ForeColor="Red" ValidationExpression="^.{2,}$"></asp:RegularExpressionValidator>
<br />
<br />
            City&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextCity" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="City should contain at least 2 letters" ForeColor="Red" ControlToValidate="TextCity">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;
<asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TextCity" ErrorMessage="City should contain at least 2 letters" ForeColor="Red" ValidationExpression="^.{2,}$"></asp:RegularExpressionValidator>
<br />
<br />
            Zip Code :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextZipCode" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Zip-code  should contain 5 digits(XXXXX)" ForeColor="Red" ControlToValidate="TextZipCode">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextZipCode" ErrorMessage="Zip-code  should contain 5 digits(XXXXX)" ForeColor="Red" ValidationExpression="\d{5}(-\d{4})?"></asp:RegularExpressionValidator>
<br />
<br />
            Phone Number :
<asp:TextBox ID="TextPhoneNumber" runat="server" Width="249px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Phone Number should be in the format XX-XXXXXXX or XXX-XXXXXXX" ForeColor="Red" ControlToValidate="TextPhoneNumber">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextPhoneNumber" ErrorMessage="Phone Number shoul be in the format XX-XXXXXXX or XXX-XXXXXXX" ForeColor="Red" ValidationExpression="^(\d{2}-\d{8}|\d{3}-\d{7})$"></asp:RegularExpressionValidator>
<br />
<br />
            Email :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextEmail" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="e-mail should be in the format example@example.com" ForeColor="Red" ControlToValidate="TextEmail">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextEmail" ErrorMessage="e-mail should be in the format example@example.com" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
<br />
<br />
<br />
<asp:Button ID="CheckButton" runat="server" OnClick="Button1_Click" Text="CHECK" />
<br />
<br />
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ShowMessageBox="True" />
<asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
<br />
</div>
</form>
</body>
</html>
