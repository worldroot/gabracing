<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GabRacingLabWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Global Azure Bootcamp Racing Lab</title>
    <link href="Styles/Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <h1>
            <asp:Label ID="lblLocationName" runat="server" /></h1>
        <br />
        <a href="Lab.aspx">Hands-On Lab</a>
        <h2>Beginner Track</h2>
        <table width="100%">
            <tr>
                <td>Pos</td>
                <td>Driver Name</td>
                <td>Time</td>
                <td>Delta</td>
                <td>Damage</td>
            </tr>
            <asp:ListView ID="lsvTrack0" runat="server">
                <LayoutTemplate>
                    <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Ranking") %></td>
                        <td><%# Eval("PlayerName") %></td>
                        <td><%# Eval("WebLapTime") %></td>
                        <td><%# Eval("WebDelta") %></td>
                        <td><%# Eval("Dammage") %></td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </table>
        <br />
        <h2>Advanced Track</h2>
        <table width="100%">
            <tr>
                <td>Pos</td>
                <td>Driver Name</td>
                <td>Time</td>
                <td>Delta</td>
                <td>Damage</td>
            </tr>
            <asp:ListView ID="lsvTrack1" runat="server">
                <LayoutTemplate>
                    <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Ranking") %></td>
                        <td><%# Eval("PlayerName") %></td>
                        <td><%# Eval("WebLapTime") %></td>
                        <td><%# Eval("WebDelta") %></td>
                        <td><%# Eval("Dammage") %></td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </table>
        <br />
        <h2>Expert Track</h2>
        <table width="100%">
            <tr>
                <td>Pos</td>
                <td>Driver Name</td>
                <td>Time</td>
                <td>Delta</td>
                <td>Damage</td>
            </tr>
            <asp:ListView ID="lsvTrack2" runat="server">
                <LayoutTemplate>
                    <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Ranking") %></td>
                        <td><%# Eval("PlayerName") %></td>
                        <td><%# Eval("WebLapTime") %></td>
                        <td><%# Eval("WebDelta") %></td>
                        <td><%# Eval("Dammage") %></td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </table>
        <br />
    </form>
</body>
</html>
