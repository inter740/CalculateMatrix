﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MatrixInt.aspx.cs" Inherits="MatrixInt" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="background: #FFDDDD; padding: 10px">
        Число</br>
        <asp:TextBox ID="number" runat="server"></asp:TextBox>
        </br> </br>
    </div>
</asp:Content>

