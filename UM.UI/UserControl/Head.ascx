<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Head.ascx.cs" Inherits="UM.UI.UserControl.Head" %>

<div class="header">
    <div class="container">
        <div class="row">
            <div class="col-md-2 header-col"></div>
            <div class="col-md-8 header-col"></div>
            <div class="col-md-2 header-col">
                <%=Pageheadhtml%>
            </div>
        </div>
    </div>
</div>
<div class="container">
    <div class="row">
        <img src="/images/logo.png" class="header-img" />
    </div>
    <div class="row header-word">
        <div class="header-word-detail">
            <%=Headerhtml %>
        </div>
    </div>
</div>

