<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reader.aspx.cs" Inherits="FileInclusion.Reader" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Local File Inclusion Example</h2>
            <label for="fileInput">Enter the file name:</label>
            <input type="text" id="fileInput" name="fileInput" />
            <button type="submit">Submit</button>
            <br />
            <h3>File Content:</h3>
            <asp:Label ID="resultLabel" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
