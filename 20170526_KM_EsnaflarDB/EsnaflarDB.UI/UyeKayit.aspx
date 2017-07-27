<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="UyeKayit.aspx.cs" Inherits="EsnaflarDB.UI.UyeKayit" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 172px;
        }
       th{
           font-weight:bold;
           font-size:11px;
           font-family:'Trebuchet MS',Verdana,Arial, Helvetica, sans-serif;
           color:#4f6b72;
           border:1px solid #C1DAD7;
           letter-spacing:2px;
           padding: 5px 5px 5px 5px;
           text-align:left;
           background:#CAE8EA;
       }

       td{
           border-right:1px solid #C1DAD7;
           border-bottom:1px solid #C1DAD7;
           padding:6px 6px 6px 6px;
         color:#4f6b72;
         background:#fff;
       }
        .auto-style3 {
            width: 172px;
            height: 30px;
        }
        .auto-style4 {
            height: 30px;
        }
    </style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="true">

    </asp:ScriptManager>

    <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" PopupPosition="Right" TargetControlID="txtDogumTarihi" />
    <%-- üye kayıt sayfası --%>

    <table class="auto-style1">
        <thead>
             <tr>
                 <th>
                     Üye Kayıt
                 </th>
             </tr>
        </thead>
        <tr>
            <td class="auto-style2">Kullanıcı Adı:</td>
            <td>
                <asp:TextBox ID="txtKullanciAdi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Sifre:</td>
            <td>
                <asp:TextBox ID="txtSifre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Sifre Tekrarı:</td>
            <td>
                <asp:TextBox ID="txtSifreTekrar" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Email:</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Ad:</td>
            <td>
                <asp:TextBox ID="txtAd" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Soyad:</td>
            <td>
                <asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Dogum Tarihi:</td>
            <td>
                <asp:TextBox ID="txtDogumTarihi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Cinsiyeti:</td>
            <td>
                <asp:RadioButton ID="rdbBay" runat="server" GroupName="Cinsiyet" Text="Bay" Checked="true" />
                <asp:RadioButton ID="rdbBayan" runat="server" GroupName="Cinsiyet" Text="Bayan" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Telefon:</td>
            <td>
                <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Sehir:</td>
            <td>
                <asp:DropDownList ID="ddlSehir" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSehir_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">İlçe:</td>
            <td>
                <asp:DropDownList ID="ddlIlce" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Adres:</td>
            <td>
                <asp:TextBox ID="txtAdres" runat="server" EnableTheming="True" TextMode="MultiLine" Height="154px" Width="243px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnKaydet" runat="server" OnClick="btnKaydet_Click" Text="Kaydet" />
            </td>
        </tr>
    </table>

</asp:Content>
