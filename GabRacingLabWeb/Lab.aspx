<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lab.aspx.cs" Inherits="GabRacingLabWeb.Lab" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Global Azure Bootcamp Racing Lab</title>
    <link href="Styles/Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>Hands-On Lab</h1>
        <br />
        <a href="Default.aspx">Lap Times</a>
        <br />
        <table>
            <tr>
                <td>Password: </td>
                <td><asp:TextBox ID="txtPassword" runat="server" /></td>
            </tr>
            <tr>
                <td></td>
                <td><asp:Button Text="Get Credentials" OnClick="Button_Click" runat="server" /></td>
            </tr>
            <tr>
                <td>StorageAccountName</td>
                <td><asp:Label ID="lblName" runat="server" /></td>
            </tr>
            <tr>
                <td>StorageAccountKey</td>
                <td><asp:Label ID="lblKey" runat="server" /></td>
            </tr>
        </table>
        <br />
        <a href="https://gabdownload.blob.core.windows.net/lab/RacingGameWorkshop.zip">Racing Game Start Project</a>
        <br />
        <br />
        <a href="Lab/AzureRacingGame_Setup.htm" target="_blank">Hands-On Lab Tools Setup</a>
        <br />
        <br />
        <a href="Lab/AzureRacingGame_Storage.htm" target="_blank">Hands-On Lab Instructons</a>
        <br />

    </form>
</body>
</html>
