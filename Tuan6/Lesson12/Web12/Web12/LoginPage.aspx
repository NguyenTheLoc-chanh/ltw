<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Web12.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post" onsubmit="return checkData()">
        <div>
            <input type="text" placeholder="Name" id="IpNickname" name="txtNickName"/>
            <input type="color" id="IpColor" name="txtColor"/>
            <br />
            <input type="submit" id="btnSubmit" value="Login"/>
            <input type="reset" id="btnReset" value="Cancel"/>
        </div>
    </form>
    <script>
        function checkData() {
            var nickName = document.getElementById('IpNickname').value;
            if (nickName == "") {
                alert("Bạn cần nhập Nickname!!!");
                return false;
            }
            return true;
        }
    </script>
</body>
</html>
