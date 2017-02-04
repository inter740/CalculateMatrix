<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MatrixMultiplication.aspx.cs" Inherits="MatrixMultiplication" %>

<%@ MasterType VirtualPath="~/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="background: #DDDDFF; padding: 10px">
        Матрица В</br>
                <asp:TextBox runat="server" ID="textBox1_matrixB"></asp:TextBox>
        <asp:TextBox runat="server" ID="textBox2_matrixB"></asp:TextBox>
        <asp:TextBox runat="server" ID="textBox3_matrixB"></asp:TextBox>
        </br>
                <asp:TextBox runat="server" ID="textBox4_matrixB"></asp:TextBox>
        <asp:TextBox runat="server" ID="textBox5_matrixB"></asp:TextBox>
        <asp:TextBox runat="server" ID="textBox6_matrixB"></asp:TextBox>
        </br>
                <asp:TextBox runat="server" ID="textBox7_matrixB"></asp:TextBox>
        <asp:TextBox runat="server" ID="textBox8_matrixB"></asp:TextBox>
        <asp:TextBox runat="server" ID="textBox9_matrixB"></asp:TextBox>
        </br> </br>
    </div>
</asp:Content>

