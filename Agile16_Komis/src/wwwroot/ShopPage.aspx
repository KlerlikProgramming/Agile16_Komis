﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/src/wwwroot/ShopMaster.Master" CodeBehind="ShopPage.aspx.cs" Inherits="Agile16_Komis.src.wwwroot.ShopPage" %>

<asp:Content ID="Main" ContentPlaceHolderID="MainContent" runat="server">
        
        <asp:GridView ID="carsDataGridView" runat="server" AutoGenerateColumns="True" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" AutoGenerateSelectButton="True">
        

    </asp:GridView>
</asp:Content>