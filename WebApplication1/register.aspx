<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebApplication1.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head>
    <meta charset="utf-8" />
    <link rel="stylesheet" type="text/css" href="./Content/Site.css" media='all' />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <title>My Sample Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" runat="server" href="#">Application name</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="#">Home</a></li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button">School<span class="caret"></span></a>
                            <ul class="dropdown-menu multi-level" role="menu" aria-labelledby="dropdownMenu">
                                <li class="dropdown-submenu">
                                    <a tabindex="-1" href="#">State</a>
                                    <ul class="dropdown-menu">
                                        <li><a href="display.aspx?Id=000">1st Standard</a></li>
                                        <li><a href="display.aspx?Id=001">2nd Standard</a></li>
                                        <li><a href="display.aspx?Id=002">3rd Standard</a></li>
                                        <li><a href="display.aspx?Id=003">4th Standard</a></li>
                                        <li><a href="display.aspx?Id=004">5th Standard</a></li>
                                        <li><a href="display.aspx?Id=005">6th Standard</a></li>
                                        <li><a href="display.aspx?Id=006">7th Standard</a></li>
                                        <li><a href="display.aspx?Id=007">8th Standard</a></li>
                                        <li><a href="display.aspx?Id=008">9th Standard</a></li>
                                        <li><a href="display.aspx?Id=009">10th Standard</a></li>
                                        <li><a href="display.aspx?Id=00A">+1 Standard</a></li>
                                        <li><a href="display.aspx?Id=00B">+2 Standard</a></li>
                                    </ul>
                                </li>

                                <li class="dropdown-submenu">
                                    <a tabindex="-1" href="#">CBSE</a>
                                    <ul class="dropdown-menu">
                                        <li><a href="display.aspx?Id=010">1st Standard</a></li>
                                        <li><a href="display.aspx?Id=011">2nd Standard</a></li>
                                        <li><a href="display.aspx?Id=012">3rd Standard</a></li>
                                        <li><a href="display.aspx?Id=013">4th Standard</a></li>
                                        <li><a href="display.aspx?Id=014">5th Standard</a></li>
                                        <li><a href="display.aspx?Id=015">6th Standard</a></li>
                                        <li><a href="display.aspx?Id=016">7th Standard</a></li>
                                        <li><a href="display.aspx?Id=017">8th Standard</a></li>
                                        <li><a href="display.aspx?Id=018">9th Standard</a></li>
                                        <li><a href="display.aspx?Id=019">10th Standard</a></li>
                                        <li><a href="display.aspx?Id=01A">+1 Standard</a></li>
                                        <li><a href="display.aspx?Id=01B">+2 Standard</a></li>
                                    </ul>
                                </li>

                                <li class="dropdown-submenu">
                                    <a tabindex="-1" href="#">ICSE</a>
                                    <ul class="dropdown-menu">
                                        <li><a href="display.aspx?Id=020">1st Standard</a></li>
                                        <li><a href="display.aspx?Id=021">2nd Standard</a></li>
                                        <li><a href="display.aspx?Id=022">3rd Standard</a></li>
                                        <li><a href="display.aspx?Id=023">4th Standard</a></li>
                                        <li><a href="display.aspx?Id=024">5th Standard</a></li>
                                        <li><a href="display.aspx?Id=025">6th Standard</a></li>
                                        <li><a href="display.aspx?Id=026">7th Standard</a></li>
                                        <li><a href="display.aspx?Id=027">8th Standard</a></li>
                                        <li><a href="display.aspx?Id=028">9th Standard</a></li>
                                        <li><a href="display.aspx?Id=029">10th Standard</a></li>
                                        <li><a href="display.aspx?Id=02A">+1 Standard</a></li>
                                        <li><a href="display.aspx?Id=02B">+2 Standard</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button">College<span class="caret"></span></a>
                            <ul class="dropdown-menu multi-level" role="menu" aria-labelledby="dropdownMenu">
                                <li class="dropdown-submenu">
                                    <a tabindex="-1" href="#">B.Tech</a>
                                    <ul class="dropdown-menu">
                                        <li class="dropdown-submenu">
                                            <a href="#">Electronics & Comm Engg</a>
                                            <ul class="dropdown-menu">
                                                <li><a href="#">1st Semester</a></li>
                                                <li><a href="#">2nd Semester</a></li>
                                                <li><a href="#">3rd Semester</a></li>
                                                <li><a href="#">4th Semester</a></li>
                                                <li><a href="#">5th Semester</a></li>
                                                <li><a href="#">6th Semester</a></li>
                                                <li><a href="#">7th Semester</a></li>
                                            </ul>
                                        </li>
                                        <li class="dropdown-submenu">
                                            <a href="#">Mechanical Engg</a>
                                            <ul class="dropdown-menu">
                                                <li><a href="#">1st Semester</a></li>
                                                <li><a href="#">2nd Semester</a></li>
                                                <li><a href="#">3rd Semester</a></li>
                                                <li><a href="#">4th Semester</a></li>
                                                <li><a href="#">5th Semester</a></li>
                                                <li><a href="#">6th Semester</a></li>
                                                <li><a href="#">7th Semester</a></li>
                                            </ul>
                                        </li>
                                        <li class="dropdown-submenu">
                                            <a href="#">Civil Engg</a>
                                            <ul class="dropdown-menu">
                                                <li><a href="#">1st Semester</a></li>
                                                <li><a href="#">2nd Semester</a></li>
                                                <li><a href="#">3rd Semester</a></li>
                                                <li><a href="#">4th Semester</a></li>
                                                <li><a href="#">5th Semester</a></li>
                                                <li><a href="#">6th Semester</a></li>
                                                <li><a href="#">7th Semester</a></li>
                                            </ul>
                                        </li>
                                        <li class="dropdown-submenu">
                                            <a href="#">Electrical Engg</a>
                                            <ul class="dropdown-menu">
                                                <li><a href="#">1st Semester</a></li>
                                                <li><a href="#">2nd Semester</a></li>
                                                <li><a href="#">3rd Semester</a></li>
                                                <li><a href="#">4th Semester</a></li>
                                                <li><a href="#">5th Semester</a></li>
                                                <li><a href="#">6th Semester</a></li>
                                                <li><a href="#">7th Semester</a></li>
                                            </ul>
                                        </li>
                                        <li class="dropdown-submenu">
                                            <a href="#">Chemical Engg</a>
                                            <ul class="dropdown-menu">
                                                <li><a href="#">1st Semester</a></li>
                                                <li><a href="#">2nd Semester</a></li>
                                                <li><a href="#">3rd Semester</a></li>
                                                <li><a href="#">4th Semester</a></li>
                                                <li><a href="#">5th Semester</a></li>
                                                <li><a href="#">6th Semester</a></li>
                                                <li><a href="#">7th Semester</a></li>
                                            </ul>
                                        </li>
                                        <li class="dropdown-submenu">
                                            <a href="#">Computer Sci Engg</a>
                                            <ul class="dropdown-menu">
                                                <li><a href="#">1st Semester</a></li>
                                                <li><a href="#">2nd Semester</a></li>
                                                <li><a href="#">3rd Semester</a></li>
                                                <li><a href="#">4th Semester</a></li>
                                                <li><a href="#">5th Semester</a></li>
                                                <li><a href="#">6th Semester</a></li>
                                                <li><a href="#">7th Semester</a></li>
                                            </ul>
                                        </li>
                                    </ul>
                                </li>
                                <li class="dropdown-submenu">
                                    <a tabindex="-1" href="#">Masters</a>
                                    <ul class="dropdown-menu">
                                        <li><a href="#">Electronics & Comm Engg</a></li>
                                        <li><a href="#">Mechanical Engg</a></li>
                                        <li><a href="#">Civil Engg</a></li>
                                        <li><a href="#">Electrical Engg</a></li>
                                        <li><a href="#">Chemical Engg</a></li>
                                        <li><a href="#">Computer Sci Engg</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </li>
                    </ul>
                    <ul class="nav navbar-nav navbar-right" runat="server" id="withsession">
                        <li>
                            <h4 style="color: #00ff90; margin-left: -150px; margin-top: 16px; width: 200px;">Hello, <%: Session["Username"] %>!</h4>
                        </li>
                        <asp:Button ID="signoutBtn" CssClass="btn btn-success navbar-btn" runat="server" Text="Sign Out" OnClick="signoutBtn_Clicked" />
                    </ul>
                    <div class="nav navbar-nav navbar-right" runat="server" id="withoutsession">
                        <asp:Button ID="singinBtn" CssClass="btn btn-success navbar-btn" runat="server" Text="Sign In" OnClick="btnSignIn_Click" />
                        <asp:Button ID="signupBtn" CssClass="btn btn-success navbar-btn" runat="server" Text="Sign Up" OnClick="btnSignUp_Click" />
                    </div>
                </div>
            </div>
        </div>
        <div class="login_div">
            <h3>Register here.</h3>
            <div class="login_form form-horizontal">
                <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                    <p class="text-danger">
                        <asp:Literal runat="server" ID="FailureText" />
                    </p>
                </asp:PlaceHolder>
                <div class="form-group">
                    <div class="col-sm-8">
                        <asp:TextBox runat="server" ID="Username" CssClass="form-control" placeholder="Email" required="required" />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-8">
                        <asp:TextBox runat="server" ID="Firstname" CssClass="form-control" placeholder="First Name" required="required" />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-8">
                        <asp:TextBox runat="server" ID="Lastname" CssClass="form-control" placeholder="Last Name" required="required" />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-8">
                        <asp:TextBox runat="server" ID="Password1" TextMode="Password" CssClass="form-control" placeholder="Password" required="required" />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-8">
                        <asp:TextBox runat="server" ID="Password2" TextMode="Password" CssClass="form-control" placeholder="Confirm Password" required="required" />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-6">
                        <asp:Button ID="btnSend" Text="Sign Up" class="btn btn-primary" runat="server" OnClick="btnSend_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
