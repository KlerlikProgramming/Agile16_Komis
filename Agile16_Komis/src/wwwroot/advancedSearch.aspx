<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="advancedSearch.aspx.cs" MasterPageFile="ShopMaster.Master" Inherits="Agile16_Komis.src.wwwroot.advancedSearch" %>

<asp:Content id="Main" ContentPlaceholderID="MainContent" runat="server">
    <div id ="menu" onload="menuOnLoad"><a href="index.aspx">Strona główna </a><a href="advancedSearch.aspx">Wyszukiwanie zaawansowane</a><a href ="contact.aspx">Kontakt</a></div>
    <div id ="header" onload="headerOnLoad">
            <asp:TextBox ID="searchInput" runat="server" OnTextChanged="searchInputTextChange"/> 
            <asp:Button runat="server" ID="searchButton" OnClick="searchButtonClick" Text="Szukaj"/>
        </div>
</asp:Content>
