<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonalCab1.aspx.cs" Inherits="WebClient.Account.PersonalCab" Async="true" %>

<asp:Content  ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2></h2>
     
    <h3>Личные данные</h3>
   <div><p style="padding: 15px"> Ваше имя:<%: WebClient.Account.PersonalData.youname%></p>  <asp:Button runat="server"  style="float: right" Text="Оплатить занятие" CssClass="btn btn-default" /> </div>  
    <p> Номер телефона:89201112324</p>  
    <p> Адрес: ул.Горького,д24,к12</p> 
    <p>Номер вашей группы: <%: WebClient.Account.PersonalData.yougroup %> </p>
       <asp:Label runat="server" >Дата</asp:Label>
           
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Fam" CssClass="col-md-2 control-label">Изменение данных пользователя:</asp:Label>
            <div style="padding: 1px">
                <asp:TextBox runat="server" ID="Fam"  CssClass="form-control" />
               
            </div> 
         </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Fam" CssClass="col-md-2 control-label">Описание</asp:Label>
            <div style="padding: 1px">
                <asp:TextBox runat="server" ID="TextBox1"  CssClass="form-control" />
                
            </div>
             </div>

     <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server"  Text="изменить занятие"  CssClass="btn btn-default" />
                <p>
                    
                </p>
            </div>
        </div>
</asp:Content>

