<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="offer.aspx.cs" Inherits="Agile16_Komis.src.wwwroot.offer" MasterPageFile="~/src/wwwroot/ShopMaster.Master" %>

<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Label ID="model" runat="server" Text="Model" />
    <br />
    <asp:Label ID="brand" runat="server" Text="Marka" />
    <br />       
    <asp:Label ID="yearProduction" runat="server" Text="Rok produkcji" />
    <br />  
    <asp:Label ID="engineType" runat="server" Text="Typ silnika" />
    <br />
    <asp:Label ID="engineFuel" runat="server" Text="Pojemność silnika" />
    <br />
    <asp:Label ID="transmissionModel" runat="server" Text="Typ skrzyni biegów" />
    <br />
    <asp:Label ID="transmissionGears" runat="server" Text="Ilość biegów" />
    <br />
    <asp:Label ID="chassis" runat="server" Text="Podwozie" />
    <br />
    <asp:Label ID="color" runat="server" Text="Kolor" />
    <br />
    <asp:Label ID="price" runat="server" Text="Cena" />
</asp:Content>
