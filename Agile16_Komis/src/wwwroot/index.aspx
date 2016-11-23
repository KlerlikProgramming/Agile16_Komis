<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Agile16_Komis.wwwroot.index" %>
<link href="../style/Style.css" rel="stylesheet" type="text/css" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div id ="menu" onload="menuOnLoad"><a href="index.aspx">Strona główna </a><a href="advancedSearch.aspx">Wyszukiwanie zaawansowane</a><a href ="contact.aspx">Kontakt</a></div>
        <div id ="header" onload="headerOnLoad">
            <asp:TextBox ID="searchInput" runat="server" OnTextChanged="searchInputTextChange"/> 
            <asp:Button runat="server" ID="searchButton" OnClick="searchButtonClick" Text="Szukaj"/>
        </div>
        <div id ="filters" onload="filtersOnLoad"></div>
        <div id ="offers" onload ="offersOnLoad"></div>
        <div id ="categories" onload="categoriesOnLoad"></div>
    </form>
</body>
</html>
