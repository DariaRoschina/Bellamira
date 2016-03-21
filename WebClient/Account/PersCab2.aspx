<%@ Page Language="C#" MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="PersCab2.aspx.cs" Inherits="WebClient.Account.PersonalCab2" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2></h2>
     <h3>Личные данные</h3>
   <div><p style="padding: 15px"> Ваше имя:<%: WebClient.Account.PersonalData.youname%></p>  <asp:Button runat="server"  style="float: right" Text="Оплатить занятие" CssClass="btn btn-default" /> </div>  
    <p> Номер телефона:8983452324</p>  
    <p> Адрес: ул.Ивлиева,д26,к62</p> 
    <p>Номер вашей группы: <%: WebClient.Account.PersonalData.yougroup %> </p>
</asp:Content>
