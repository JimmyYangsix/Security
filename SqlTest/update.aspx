<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="SqlTest.update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="ie=edge" />
    <title>Update</title>
    <link href="css/index.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
     <h1 class="title">SQL注入测试密码修改页面</h1>
    <h2 class="author">网络工程15-1 惠阳</h2>
    <div class="content">
        <form action="update.aspx" method="post" runat="server">
            <div class="form-group">
                <label for="exampleInputEmail1">Username</label>
                <asp:TextBox CssClass="form-control" runat="server" ID="Username"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="exampleInputPassword1">OldPassword</label>
                   <asp:TextBox CssClass="form-control" runat="server" ID="OldPassword"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="exampleInputPassword1">NewPassword</label>
                <p id="show" class="bg-warning text-warning" style="float:right;font-size:180%;"></p>
               <asp:TextBox  type="password" CssClass="form-control" runat="server" ID="NewPassword"></asp:TextBox>
            </div>
            <asp:Button type="submit" CssClass="btn btn-default" Text="Update" onclick=" Update_click" runat="server"/>
        </form>
    </div>
</body>
</html>
