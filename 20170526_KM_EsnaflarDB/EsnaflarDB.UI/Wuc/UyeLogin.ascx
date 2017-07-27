<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UyeLogin.ascx.cs" Inherits="EsnaflarDB.UI.Wuc.UyeLogin" %>


    <style type="text/css">
    .auto-style1{
        width:100%
    }
</style>

        <asp:LoginView ID="LoginView1" runat="server">

        <AnonymousTemplate>   

            
<%-- üye giriş --%>

            <table class ="auto-style1">
                <tr>
                    <td>Kullanıcı Adı:</td>
                    <td> <asp:TextBox ID="txtkadi" runat="server"></asp:TextBox></td>
                       
                </tr>
                <tr>
                    <td>Şifre:</td>
                    <td><asp:TextBox ID="txtsifre" runat="server"></asp:TextBox></td>
                        
                </tr>
                <tr>
                    <td>Beni Hatırla</td>
                    <td> <asp:CheckBox ID="chhatirla" runat="server" /></td>                 
                </tr>
                <tr>
                    <td></td>
                    <td> <asp:Button ID="btngiris" runat="server" Text="Giriş!" OnClick="btngiris_Click" /> </td>                 
                </tr>
            </table>
        </AnonymousTemplate>
            <LoggedInTemplate>
               Hoşgeldiniz, <asp:LoginName ID="LoginName1" runat="server" />

                <%-- uye çıkış --%>
                <br/>
                <ul>
                    <li> <asp:LinkButton ID="lnkcikis" runat="server" OnClick="lnk_cikis_click" Text="Çıkış"></asp:LinkButton></li>
                     <li> <a href="Yazar/MakaleEkle.aspx">Makale Ekle</a> </li>
                 <li> <a href="Yazar/YorumOnayla.aspx">Yorum Onayla</a> </li>
                 <li> <a href="Yazar/MakaleDuzenle.aspx">Makale Duzenle</a> </li>

                </ul>
            </LoggedInTemplate>

    </asp:LoginView>
