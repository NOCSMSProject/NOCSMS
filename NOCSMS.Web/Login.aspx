<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript" src="JScript/jquery-1.7.1.min.js"></script>
    <link type="text/css" href="CSS/bootstrap.min.css" rel="Stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        姓名:
        <input type="text" id="nameId" name="name" />
        密码:
        <input type="password" id="pwdId" name="pwd" />
        <input type="button" id="btnSure" value="确定" />
        <input type="button" id="btnRSet" value="重置" />
        <script type="text/javascript">
            
            $("#btnRSet").click(function () {
                $("#nameId").val("");
                $("#pwdId").val("");
            });
            
            $("#btnSure").click(function () {
                $.ajax({
                    url: "Login.ashx",
                    type: "post",
                    data: "",
                    success: function (result) {
                        window.location.href = "main.aspx";
                    },
                    error: function () {
                        alert("用户名或密码错误！");
                    }
                });
            });
            
        </script>
    </div>
    </form>
</body>
</html>
