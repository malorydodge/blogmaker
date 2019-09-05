<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewPost.aspx.cs" Inherits="User_NewPost"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Content/themes/base/jquery.ui.all.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />

    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>&nbsp;&nbsp;&nbsp;Write a new blog post!</h1>
        <section>

                <p class="auto-style1">

                Title:<br />

                <asp:TextBox ID="txtTitle" runat="server" placeholder="Post Title" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:TextBox ID="txtSnippet" runat="server" placeholder="Write a short preview of your post." CssClass="form-control" Rows="3" TextMode="MultiLine"></asp:TextBox>
                <br />
                <asp:TextBox ID="txtPost" runat="server" Columns="20" placeholder="Write your post." CssClass="form-control" Rows="10" TextMode="MultiLine"></asp:TextBox>
                </p>
            </section>
            <section>

                <p class="auto-style1">

                Enter Category:<br />

                &nbsp;&nbsp;&nbsp;

                <asp:TextBox ID="txtCategory" runat="server"  CssClass="form-control"></asp:TextBox>
                <br />
                Enter Keyword:<br />
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtKeyword" runat="server" CssClass="form-control"  OnTextChanged="txtKeyword_TextChanged" AutoPostBack="True"></asp:TextBox>
                <br />
                <asp:Button ID="btnAddKeyword" runat="server" OnClick="btnAddKeyword_Click" Text="Add Keyword" />
                <br />
                &nbsp;&nbsp;&nbsp;
                Keywords:<br />
                &nbsp;&nbsp;&nbsp;
                <asp:ListBox ID="lbKeywords" runat="server" CssClass="form-control" Height="122px" Width="249px"></asp:ListBox>
                
                <br />
                <br />
                <asp:Button ID="btnPost" runat="server" width="20%" OnClick="btnPost_Click" Text="Post to Blog" />

            &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancel" runat="server" width="20%" OnClick="btnCancel_Click" Text="Cancel" />

                </p>

            </section>
        </div>
    </form>
</body>
</html>
