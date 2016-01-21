<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonalCab1.aspx.cs" Inherits="WebClient.Account.PersonalCab" Async="true" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2></h2>
    <h3>Личные данные</h3>
    <p> Ваше имя:<%: WebClient.Account.PersonalData.youname %> </p>  
    <p>Номер телефона:89201112324</p>  
    <p> Адрес: ул.Горького,д24,к12</p>  
    <p>Номер вашей группы: <%: WebClient.Account.PersonalData.yougroup %> </p> 
      <div  style="float: right;  padding: 15px; padding-right: 50px">
            <asp:Button runat="server" BackColor="Yellow"  Text="Оплатить занятие" CssClass="btn btn-default" />
      </div>                    
                   
    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10" style="float: left;  padding: 15px; padding-right: 50px">
                            <asp:Button runat="server"  Text="Отменить занятие" CssClass="btn btn-default" />
                        </div>
                    </div>
    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10" style="float: right;  padding: 15px; padding-right: 50px">
                            <asp:Button runat="server"  Text="Сменить логин/пароль" CssClass="btn btn-default" />
                        </div>
                    </div>
    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10" style="float: right;  padding: 15px; padding-right: 50px">
                            <asp:Button runat="server"  Text="Забронировать занятие" CssClass="btn btn-default" />
                        </div>
                    </div>
</asp:Content>

