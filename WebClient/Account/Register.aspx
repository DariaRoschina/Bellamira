<%@ Page Title="Регистрация" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebClient.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Создание новой учетной записи</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Login" CssClass="col-md-2 control-label">Логин</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Login" CssClass="form-control"  />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Login"
                    CssClass="text-danger" ErrorMessage="Поле логин заполнять обязательно." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Пароль</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                    CssClass="text-danger" ErrorMessage="Поле пароля заполнять обязательно." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-2 control-label">Подтверждение пароля</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="Поле подтверждения пароля заполнять обязательно." />
                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="Пароль и его подтверждение не совпадают." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Fam" CssClass="col-md-2 control-label">Фамилия</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Fam"  CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Fam"
                    CssClass="text-danger" ErrorMessage="Поле фамилия заполнять обязательно." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Name" CssClass="col-md-2 control-label">Имя</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Name"  CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Name"
                    CssClass="text-danger" ErrorMessage="Поле имя заполнять обязательно." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Otch" CssClass="col-md-2 control-label">Отчество</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Otch"  CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Otch"
                    CssClass="text-danger" ErrorMessage="Поле отчество заполнять обязательно." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="TypeUser" CssClass="col-md-2 control-label">Выберете тип пользователя:</asp:Label>
            <div class="col-md-10">

                
                <asp:DropDownList ID="TypeUser" runat="server">
                        
                </asp:DropDownList>
                 <asp:RequiredFieldValidator runat="server" ControlToValidate="TypeUser"
                    CssClass="text-danger" ErrorMessage="Поле заполнять обязательно." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Groups" CssClass="col-md-2 control-label">Выберете группу:</asp:Label>
            <div class="col-md-10">

                <asp:DropDownList ID="Groups" runat="server">
                    <asp:ListItem>младшая</asp:ListItem>
                    <asp:ListItem>средняя</asp:ListItem>
                    <asp:ListItem>старшая</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Groups"
                    CssClass="text-danger" ErrorMessage="Поле заполнять обязательно." />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Регистрация" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>
