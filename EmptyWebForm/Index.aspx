<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="EmptyWebForm.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
  <%--  <link href="Content/Less/myLess.less" rel="stylesheet" />--%>
    <%:System.Web.Optimization.Styles.Render("~/Content/Less") %>
    <%:System.Web.Optimization.Scripts.Render("~/bundles/jquery") %>

    <%:System.Web.Optimization.Scripts.Render("~/bundles/WebFormsJs")%>

    <%:System.Web.Optimization.Styles.Render("~/bundles/themes/base/style")%>

    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
