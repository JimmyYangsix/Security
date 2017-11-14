<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sign up.aspx.cs" Inherits="SqlTest.sign_up" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta charset="UTF-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <meta http-equiv="X-UA-Compatible" content="ie=edge"/>
    <title>Document</title>
    <link href="css/index.css" rel="stylesheet"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/sign up.js"></script>

</head>
<body runat="server">
    <h1 class="title">SQL注入测试注册页面</h1>
    <h2 class="author">网络工程15-1 惠阳</h2>
    <div class="content">
        <form action="" method="post" runat="server">
            <div class="form-group">
                <label for="exampleInputEmail1">Username</label>
                <asp:TextBox  CssClass="form-control" runat="server" ID="Username"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="exampleInputPassword1">Password</label>
                <asp:TextBox  type="password" CssClass="form-control psd" runat="server" ID="Password"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="exampleInputPassword1">RepeatPassword</label>
                <p  id="show" class="bg-warning text-warning" style="float:right;font-size:180%;"></p>
                 <asp:TextBox  type="password" ID="TextBox1"  onblur="checksign()" CssClass="form-control psd" runat="server"></asp:TextBox>
            </div>
            <asp:Button type="submit" CssClass="btn btn-default"  Text="Join Us" runat="server" OnClick="Join_us"/>
        </form>
    </div>
</body>
</html>
