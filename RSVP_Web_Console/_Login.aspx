<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="_Login.aspx.cs" Inherits="Hostel._Login" %>

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
      <h1>Login </h1>

        <p><span >User Name:</span><asp:TextBox ID="Username" runat="server"></asp:TextBox>
        </p>
        <p><span >Password:</span><asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox></p>
        <br />
        <p class="remember_me">
          <label>
            <input type="checkbox" name="remember_me" id="remember_me" />
            Remember me on this computer
          </label>
        </p>
        <p class="submit">
          <asp:Button ID="Button1" runat="server" Text="Login" onclick="Button1_Click" />
          </p><br />
              <p>Forgot your password? <a href="">Click here to reset Your password</a>.</p>
        <p>
        <a href="Registration.aspx" rel="register" class="linkform">You don't have an account yet? Register here</a>
      
        </p>

               <label>
          <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
          </label>
      
    </div>

  
    </div>
    
    </form>
    <script type="text/javascript">
    </script>
</body>
</html>
