<%@ Page Title="Data Table Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DataTable.aspx.cs" Inherits="EarthquakeWatchDk.DataTable" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div class="jumbotron">
        <h1>GEUSS EARTHQUAKE DATA</h1>
        <p class="lead">Display the Geuss earthquake data for the area of Denmark</p>
        
    </div>
    
      
        <div>
            <asp:Literal ID="LiteralDataTable" runat="server"></asp:Literal>
        </div>
   
</asp:Content>
