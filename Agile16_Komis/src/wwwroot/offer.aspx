<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="offer.aspx.cs" Inherits="Agile16_Komis.src.wwwroot.offer" MasterPageFile="~/src/wwwroot/ShopMaster.Master" %>

<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">
    
            <asp:Label ID="model" runat="server" HeaderText="Model" />
            <asp:Label ID="brand" runat="server" HeaderText="Marka" />
            <asp:Label ID="yearProduction" runat="server" HeaderText="Rok produkcji" />
            <asp:Label ID="engineType" runat="server" HeaderText="Typ silnika" />
            <asp:Label ID="engineFuel" runat="server" HeaderText="Pojemność silnika" />
            <asp:Label ID="transmissionModel" runat="server" HeaderText="Typ skrzyni biegów" />
            <asp:Label ID="transmissionGears" runat="server" HeaderText="Ilość biegów" />
            <asp:Label ID="chassis" runat="server" HeaderText="Podwozie" />
            <asp:Label ID="color" runat="server" HeaderText="Kolor" />
            <asp:Label ID="price" runat="server" HeaderText="Cena" />
</asp:Content>
