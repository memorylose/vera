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

    <div class="row">
        <div class="col-md-1"></div>

        <div class="col-md-10" style="padding-left: 40px;">
            <%=HotArticlehtml%>
            <%--<div class="right-t">
                <div class="right-num">01.</div>
                <div class="right-con"><a href="">你的碌碌无为，恰恰是因为做得太多!</a></div>
            </div>--%>
            <%--<div class="right-t">
                <div class="right-num">02.</div>
                <div class="right-con"><a href="">你的碌碌无为，恰恰是因为做得太多!</a></div>
            </div>
            <div class="right-t">
                <div class="right-num">03.</div>
                <div class="right-con"><a href="">你的碌碌无为，恰恰是因为做得太多!</a></div>
            </div>
            <div class="right-t">
                <div class="right-num">04.</div>
                <div class="right-con"><a href="">你的碌碌无为，恰恰是因为做得太多!</a></div>
            </div>
            <div class="right-t">
                <div class="right-num">05.</div>
                <div class="right-con"><a href="">你的碌碌无为，恰恰是因为做得太多!</a></div>
            </div>

            <div class="right-t">
                <div class="right-num">06.</div>
                <div class="right-con"><a href="">你的碌碌无为，恰恰是因为做得太多!</a></div>
            </div>
            <div class="right-t">
                <div class="right-num">07.</div>
                <div class="right-con"><a href="">你的碌碌无为，恰恰是因为做得太多!</a></div>
            </div>
            <div class="right-t">
                <div class="right-num">08.</div>
                <div class="right-con"><a href="">你的碌碌无为，恰恰是因为做得太多!</a></div>
            </div>
            <div class="right-t">
                <div class="right-num">09.</div>
                <div class="right-con"><a href="">你的碌碌无为，恰恰是因为做得太多!</a></div>
            </div>
            <div class="right-t">
                <div class="right-num">10.</div>
                <div class="right-con"><a href="">你的碌碌无为，恰恰是因为做得太多!</a></div>
            </div>--%>

        </div>
        <div class="col-md-1"></div>

    </div>
</div>

