<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonalCab1.aspx.cs" Inherits="WebClient.Account.PersonalCab" Async="true" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2></h2>
    <h3>Личные данные</h3>
    <div><p> Ваше имя:<%: WebClient.Account.PersonalData.youname %> </p>  </div>
    <div><p>тип <%: WebClient.Account.PersonalData.youtype %> </p>  </div>
    <div><p>Номер вашей группы: <%: WebClient.Account.PersonalData.yougroup %> </p>  </div>


</asp:Content>

