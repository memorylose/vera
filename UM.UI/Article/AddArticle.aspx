<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddArticle.aspx.cs" Inherits="UM.UI.Article.AddArticle" ValidateRequest="false" %>
<%@ Register Src="~/UserControl/Top.ascx" TagPrefix="uc1" TagName="Top" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Article</title>
    <link href="/styles/bootstrap.min.css" rel="stylesheet" />
    <link href="/styles/index.css" rel="stylesheet" />
    <script src="/scripts/jquery-3.0.0.min.js"></script>
    <script type="text/javascript" src="http://js.nicedit.com/nicEdit-latest.js"></script>
    <script type="text/javascript">
        //<![CDATA[
        bkLib.onDomLoaded(function () { nicEditors.allTextAreas() });
        //]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <uc1:Top runat="server" ID="Top" />
        <div class="container-fluid" style="margin-top: 20px;">
            <div class="row">
                <div class="col-md-2"></div>
                <div class="col-md-8" style="padding: 0;">
                    <div class="content-main">
                        <div class="row">
                            <div class="col-md-8">
                                <div style="height: 30px; font-weight: bold; font-size: 20px; margin-bottom: 20px;">
                                    Add Article
                                </div>
                                <div style="height: 40px;">
                                    <div style="float: left; font-size: 13px; height: 30px; line-height: 30px; font-weight: bold; width: 90px;">Title:</div>
                                    <div style="float: left; margin-left: 10px; height: 30px;">
                                        <input type="text" style="height: 25px; width: 200px; border: 1px solid #DDDDDD; padding-left: 5px;" id="txtTitle" runat="server" />
                                    </div>
                                </div>
                                <div style="height: 40px;">
                                    <div style="float: left; font-size: 13px; height: 30px; line-height: 30px; font-weight: bold; width: 90px;">Summary:</div>
                                    <div style="float: left; margin-left: 10px; height: 30px;">
                                        <input type="text" style="height: 25px; width: 200px; border: 1px solid #DDDDDD; padding-left: 5px;" id="txtSummary" runat="server" />
                                    </div>
                                </div>
                                <div style="height: 320px;">
                                    <div style="float: left; font-size: 13px; height: 30px; line-height: 30px; font-weight: bold; width: 90px;">Contents:</div>
                                    <div style="float: left; margin-left: 10px; height: 30px;">
                                        <textarea name="area1" id="txtContent" runat="server" cols="40" style="width: 500px; height: 200px;"></textarea>
                                    </div>
                                </div>
                                <div style="height: 40px;">
                                    <div style="float: left; font-size: 13px; height: 30px; line-height: 30px; font-weight: bold; width: 90px;">Type:</div>
                                    <div style="float: left; margin-left: 10px; height: 30px;">
                                        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                                    </div>
                                </div>
                                <div style="height: 40px;">
                                    <asp:Button ID="Button1" runat="server" Text="Create" Width="70px" Height="25px" OnClick="Button1_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-2"></div>
            </div>
        </div>
    </form>
</body>
</html>
