<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        <body style="background-image: url('https://wallpaperclicker.com/storage/wallpaper/rainbow-colors-background-wallpaper-43801664.jpg'); width:100%; height:254px;">
        <asp:Image ID="Image1" runat="server" Height="264px" Width="342px" />
         <div style="margin-top: 60px; float: left">
      <asp:RadioButton ID="R1" runat="server" Font-Names="Century Gothic" Font-Size="20pt" OnCheckedChanged="R1_CheckedChanged" GroupName="R"/>
            <asp:RadioButton ID="R2" runat="server" Font-Names="Century Gothic" Font-Size="20pt" OnCheckedChanged="R2_CheckedChanged" GroupName="R"/>
            <asp:RadioButton ID="R3" runat="server" Font-Names="Century Gothic" Font-Size="20pt" OnCheckedChanged="R3_CheckedChanged" GroupName="R"/>
            <asp:RadioButton ID="R4" runat="server" Font-Names="Century Gothic" Font-Size="20pt" OnCheckedChanged="R4_CheckedChanged" GroupName="R"/>
            <asp:RadioButton ID="R5" runat="server" Font-Names="Century Gothic" Font-Size="20pt" OnCheckedChanged="R5_CheckedChanged" GroupName="R"/>

             
           <div style="margin-top: 60px; float: left">  
            <asp:Button ID="Button2" ForeColor="#660066" runat="server" Text="DALEJ" Font-Names="Century Gothic" Font-Size="20pt" BackColor="#CC00CC" BorderColor="#660033" Font-Bold="True" OnClick="Button2_Click" style="margin-left: 109px" Width="223px" />
   

               
               
               
               </form>
</body>
</html>
