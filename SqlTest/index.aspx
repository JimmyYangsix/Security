<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SqlTest.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>SQL测试</title>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="css/index.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/index.js"></script>
</head>
<body runat="server">
    <h1 class="title">SQL注入测试页面</h1>
    <h2 class="author">网络工程15-1 惠阳</h2>
    <div class="content">
        <form action="index.aspx" method="post" runat="server">
            <div class="form-group">
                <label for="exampleInputEmail1">Username</label>
                <asp:TextBox  type="text" ID="Username" Cssclass="form-control"  onblur="LookUp(this)"  runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="exampleInputPassword1">Password</label>              
                <asp:TextBox  type="password"  ID="Password" CssClass="form-control"   onblur="LookUp(this)" runat="server" ></asp:TextBox>
            </div>
           <asp:Button  type="submit" Cssclass="btn btn-default" runat="server" onclick="Login_click" Text="Login"/> 
             <asp:Button ID="Button1"  type="submit" Cssclass="btn btn-default" onclick="Join_click" runat="server"  Text="Join Us"/> 
                         <asp:Button ID="Button2"  type="submit" Cssclass="btn btn-default" onclick="Update_click" runat="server"  Text="Update"/> 
            <div class="form-group">
                <label style="color: red">输入情况即时输出：</label>
                <textarea class="form-control" rows="3" id="output" ></textarea>
            </div>
        </form>
    </div>
</body>
</html>
