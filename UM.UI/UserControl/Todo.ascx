<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Todo.ascx.cs" Inherits="UM.UI.UserControl.Todo" %>

<div class="col-md-4">

    <div class="row" style="margin-top: 30px;">
        <div class="col-md-2"></div>
        <div class="col-md-7" style="padding: 0;">
            <input type="text" class="search-input" id="txtSearch"
                placeholder="请输入关键字" runat="server">
        </div>

        
        <div class="col-md-2" style="padding: 0;">
            <asp:Button ID="btnSearch" runat="server" CssClass="search-btn" Text="" OnClick="btnSearch_Click" />
        </div>
    </div>
</div>

