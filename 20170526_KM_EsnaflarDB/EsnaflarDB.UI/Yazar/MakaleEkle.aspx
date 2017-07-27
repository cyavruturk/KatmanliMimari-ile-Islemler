<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="MakaleEkle.aspx.cs" Inherits="EsnaflarDB.UI.MakaleEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <%-- makale ekleme sayfası--%>

     <table style="width: 100%">
        <tr>
            <td style="width: 324px">Kategorisi</td>
            <td>
                <asp:DropDownList ID="ddlkategori" runat="server" Height="16px" Width="466px" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 324px">Başlık</td>
            <td>
                <asp:TextBox ID="txtbaslik" runat="server" Height="85px" TextMode="MultiLine" Width="462px" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 324px">Makale İçerik
            </td>
                <td><textarea class="ckeditor" id="editor1" name="S1" style="height: 191px; width: 462px" runat="server"></textarea></td>
        </tr>
        <tr>
            <td style="width: 324px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 324px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 324px">&nbsp;</td>
            <td>
                <asp:Button ID="btnMakaleKaydet" runat="server" OnClick="btnMakaleKaydet_Click" Text="Makale Kaydet" />
            </td>
        </tr>
    </table>

</asp:Content>
