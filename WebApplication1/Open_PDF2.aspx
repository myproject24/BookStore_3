<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Open_PDF2.aspx.cs" Inherits="WebApplication1.Open_PDF2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/jscript">
        function disableContextMenu() {
            //window.frames["fraDisabled"].document.oncontextmenu = function(){alert("No way!"); return false;};
            // Or use this
            
            document.getElementById("fraDisabled").contentWindow.document.oncontextmenu = function () { return false; };
            document.getElementById("fraDisabled").onmousedown = disableselect;
            document.getElementById("fraDisabled").onclick = reEnable;
        }
        function disableselect(e) {
            return false
        }
        function reEnable() {
            return true
        }
        //if IE4+
        window.onclick = reEnable;
        window.onmousedown = disableselect;
        window.document.onselectstart = new Function("return false");
        window.document.oncontextmenu = new Function("return false");
        document.onselectstart = new Function("return false")
        document.oncontextmenu = new Function("return false")
        //if NS6
        if (window.sidebar) {
            document.onmousedown = disableselect
            document.onclick = reEnable
        }
    </script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#fraDisabled').on('contextmenu', function (e) {

                e.preventDefault();
            });
        });
        $(document).bind('contextmenu', function (e) {
            e.preventDefault();
            alert('Right Click is not allowed');
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <h3 style="color: #0000FF">Open PDF files using ASP.NET</h3>
    <div>
        <asp:Button ID="bttnpdf" runat="server" Text="Click for open PDF" Font-Bold="True" OnClick="bttnpdf_Click" />
    </div>
    </form>
</body>
</html>