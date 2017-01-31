<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddOffer.aspx.cs" Inherits="Agile16_Komis.src.AddOffer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text ="Uzupełnij pola aby dodać lub edytować samochód" />
        </div>
        <div>
            <asp:Label runat="server" Text ="Model: " />
            <asp:TextBox runat="server" ID="modelTextBox" Text="" />
        </div>
        <div>
            <asp:Label runat="server" Text ="Marka: " />
            <asp:TextBox runat="server" ID="brandTextBox" Text="" />
        </div>
        <div>
            <asp:Label runat="server" Text ="Rok produkcji: " />
            <asp:TextBox runat="server" ID="yearProductionTextBox" Text="" />
        </div>
        <div>
            <asp:Label runat="server" Text ="Typ silnika: " />
            <asp:TextBox runat="server" ID="engineTypeTextBox" Text="" />
        </div>
        <div>
            <asp:Label runat="server" Text ="Pojemność silnika: " />
            <asp:TextBox runat="server" ID="engineFuelTextBox" Text="" />
        </div>
        <div>
            <asp:Label runat="server" Text ="Typ skrzyni biegów: " />
            <asp:TextBox runat="server" ID="transmissionModelTextBox" Text="" />
        </div>
        <div>
            <asp:Label runat="server" Text ="Ilośc biegów: " />
            <asp:TextBox runat="server" ID="transmissionGearsTextBox" Text="" />
        </div>
        <div>
            <asp:Label runat="server" Text ="Podwozie: " />
            <asp:TextBox runat="server" ID="chassisTextBox" Text="" />
        </div>
        <div>
            <asp:Label runat="server" Text ="Kolor: " />
            <asp:TextBox runat="server" ID="colorTextBox" Text="" />
        </div>
        <div>
            <asp:Label runat="server" Text ="Cena: " />
            <asp:TextBox runat="server" ID="priceTextBox" Text="" />
        </div>
        <div>
            <asp:Button ID="applyButton" Text="Dodaj" runat="server" onClick="ApplyButton_Click"/>
            <asp:Button ID="cancelButton" Text="Anuluj" runat="server" OnClick="CancelButton_Click" />
        </div>
    </form>
</body>
</html>
