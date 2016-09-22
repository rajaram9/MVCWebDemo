<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="EmptyWeb.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/jquery-3.1.0.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <%=DateTime.Now %>
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
        <asp:Button ID="btnSet" runat="server" Text="SetValue" OnClick="btnSet_Click" />
    </div>
    </form>
</body>
</html>
<script type="text/javascript">
    $(function () {
        EmptyWeb.Index.GetTime(function (res) {
            alert(res.value);
        });
    });
</script>