<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Rabota.Properties.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../StyleSheet1.css" rel="stylesheet" />
    <style type="text/css">
        #TextBox1
        {
        }
        
        #TextBox2
        {
        }
        #TextBox3
        {
        }
        #TextBox4
        {
            height: 24px;
            width: 165px;
        }
        #TextBox5
        {
            height: 24px;
            width: 75px;
        }
       
       
      
        .auto-style12 {
            height: 48px;
            margin-bottom: 6px;
        }
        .auto-style13 {}
       
       
      
        .auto-style15 {
            height: 35px;
        }
       
       
      
    </style>
</head>
<body>

 <form id="form1" runat="server" submitdisabledcontrols="False">
            <div style = "width: 100%; height: 50px">
                <h1>Рабочий проект</h1>
            </div>
                      <div class="auto-style15">
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Добавление" />
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Редактирование" />
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Удаление" />
                     </div>
                <div>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Бренд" />
        <asp:Button ID="Button1" runat="server" Text="Модели" CssClass="auto-style2" Height="32px" OnClick="Button1_Click1" Width="69px" />
                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Группировать" />
                  </div>
                 
        <div style = "width: 100%; height: 150px">
            <asp:Label ID="Label12" runat="server" width="56px" Height="25px" Text="id" CssClass="auto-style13"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" Width="56px" Height="25px" OnTextChanged="TextBox3_TextChanged"></asp:TextBox></br>
            
        <asp:Label ID="Label1" runat="server" width="56px" Height="25px" Text="Name" CssClass="auto-style13"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Width="56px" Height="25px" OnTextChanged="TextBox1_TextChanged1"></asp:TextBox></br>
            
        <asp:Label ID="Label2" runat="server" width="56px" Height="25px" Text="Active" CssClass="auto-style13"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" Width="56px" Height="25px"></asp:TextBox>
            </div>
          <asp:Label ID="Label4" runat="server" height="25px" width="50px" Text="Brand"></asp:Label>
             </div>
              <div style = "width: 100%; height: 400px; overflow: scroll">
            <asp:GridView ID="GridView1" runat="server" OnRowDataBound="RowDataBound" class="table table-hover" align="left" 
                Width="570px" >
        </asp:GridView>
                  </div>
            
            

         </form>
</body>
</html>