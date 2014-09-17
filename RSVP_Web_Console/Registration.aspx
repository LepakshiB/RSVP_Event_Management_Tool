<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="c.aspx.cs" Inherits="Hostel.Registration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <link rel="stylesheet" href="CSS/style.css">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="login">
      <h1>Registration</h1>

        <p><span >First Name:</span><asp:TextBox ID="First_name" runat="server"></asp:TextBox>
        </p>
        <p><span >Last Name:</span><asp:TextBox ID="Last_name" runat="server"></asp:TextBox>
        </p>
        <p><span >Email:&nbsp&nbsp&nbsp    </span><asp:TextBox ID="User_Email" runat="server"></asp:TextBox>
        </p>
        <p><span >Password:</span><asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox></p>
        <br />
        
        <p class="submit">
          <asp:Button ID="Button1" runat="server" Text="Register" onclick="Button1_Click" />
        </p>
        <br />
              <p> <a href="_login.aspx">Go To Login Page</a>.</p>

               <label>
          <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
          </label>
      
    </div>

  
    </div>
    
    </form>
</body>
</html>
