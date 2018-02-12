<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProductsDatabase.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Products</h1>
           <%-- These C# comments will be stripped out by the server at runtime --%>
            <%-- This HTML comment will still be sent to the client --%>
            <%-- ID Name Price --%>
            ID: <asp:Label runat="server" ID="lblID">0</asp:Label> <br />
            Name: <asp:TextBox runat="server" ID="txtName" /> <br />
           <%-- The textmode attribute maps to the attribute of an <input> element
               compatability depends on your browser--%>
            Price: <asp:TextBox runat="server" ID="txtPrice" /> <br />
            <asp:Button runat="server" ID="btnFirst" Text="First" OnClick="btnFirst_Click" />
             <asp:Button runat="server" ID="btnPrevious" Text="Previous" OnClick="btnPrevious_Click" />
            <asp:Button runat="server" ID="btnLast" Text="Last" OnClick="btnLast_Click" />
            <asp:Button runat="server" ID="btnNext" Text="Next" OnClick="btnNext_Click" />
           
            <%-- line break between navigation and data buttons --%>
            <br />
            <asp:Button runat="server" ID="btnNew" Text="New" OnClick="btnNew_Click" />
            <asp:Button runat="server" ID="btnSave" Text="Save" OnClick="btnSave_Click" />
            <asp:Button runat="server" ID="btnDelete" Text="Delete" OnClick="btnDelete_Click" />





        </div>
    </form>
</body>
</html>
