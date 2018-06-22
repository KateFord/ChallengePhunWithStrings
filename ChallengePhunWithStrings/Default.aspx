<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePhunWithStrings.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="stringTextBox" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="reverseNameButton" runat="server" OnClick="reverseNameButton_Click" Text="Reverse Any Given String     " />
&nbsp;
        <asp:TextBox ID="stringResultTextBox" runat="server" Enabled="False"></asp:TextBox>
    
    </div>
        <asp:TextBox ID="StarWarsTextBox" runat="server" Enabled="False">Luke,Leia,Han,Chewbacca</asp:TextBox>
&nbsp;
        <asp:Button ID="reverseSWButton" runat="server" OnClick="reverseSWButton_Click" Text="Reverse Comma Deliminated" />
&nbsp;
        <asp:TextBox ID="starWarsResultTextBox" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <asp:Button ID="asciiArtButton" runat="server" OnClick="asciiArtButton_Click" Text="Ascii Art Creation" Width="522px" />
        <br />
        <br />
        <asp:Label ID="asciiArtResultLabel" runat="server"></asp:Label>
        <br />
        <br />
        NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZHE AID OF ZHEIR COUNTRY.<br />
        <asp:Button ID="sentenceButton" runat="server" OnClick="sentenceButton_Click" Text="Sentence Puzzle" Width="520px" />
&nbsp;<br />
        <br />
        <asp:Label ID="puzzleSentenceResultLabel" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
