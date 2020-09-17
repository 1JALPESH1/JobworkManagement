<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Admin_Panel_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <%-- <link href="~/css/bootstrap.min.css" rel="stylesheet" />
    <link href="~/css/bootstrap-theme.min.css" rel="stylesheet" />
    <script src="~/js/bootstrap.min.js"></script>--%>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!--===============================================================================================-->
    <link rel="icon" type="image/png" href="~/Content/Login/images/icons/favicon.ico" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="~/Content/Login/vendor/bootstrap/css/bootstrap.min.css" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="~/Content/Login/fonts/font-awesome-4.7.0/css/font-awesome.min.css" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="~/Content/Login/fonts/Linearicons-Free-v1.0.0/icon-font.min.css" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="~/Content/Login/vendor/animate/animate.css" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="~/Content/Login/vendor/css-hamburgers/hamburgers.min.css" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="~/Content/Login/vendor/animsition/css/animsition.min.css" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="~/Content/Login/vendor/select2/select2.min.css" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="~/Content/Login/vendor/daterangepicker/daterangepicker.css" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="~/Content/Login/css/util.css" />
    <link rel="stylesheet" type="text/css" href="~/Content/Login/css/main.css" />
</head>
<body>

    <div class="limiter">
        <div class="container-login100 img-responsive" style="background-image: url(../Content/Login/images/background.jpg)">

            <div class="wrap-login100 p-t-30 p-b-50">
                <span class="login100-form-title p-b-41">Account Login
                </span>
                <form id="Form1" class="login100-form validate-form p-b-33 p-t-5" runat="server">

                    <div class="wrap-input100 validate-input" data-validate="Enter username">
                        <asp:TextBox runat="server" ID="txtUserName" class="input100" placeholder="User name"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ID="rfvUserName" ControlToValidate="txtUserName" Display="Dynamic" ErrorMessage="Enter UserName" ForeColor="Red" ValidationGroup="Login" />

                        <span class="focus-input100" data-placeholder="&#xe82a;">
                        </span>
                    </div>


                    <div class="wrap-input100 validate-input" data-validate="Enter password">
                        <asp:TextBox class="input100" ID="txtPassword" runat="server" TextMode="password" placeholder="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ID="rfvPasword" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="Enter Password" ForeColor="Red" ValidationGroup="Login" />
                        <span class="focus-input100" data-placeholder="&#xe80f;"></span>
                    </div><br />

                        <asp:Label ID="lblMessage" runat="server"></asp:Label>

                    <div class="container-login100-form-btn m-t-32">
                        <asp:Button class="login100-form-btn" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" ValidationGroup="Login"></asp:Button>
                    </div>
                    <br />
                    <div class="col-md-12 ml-2 " style="text-align: center">
                        <i>Create a new account ?</i>
                        <asp:HyperLink runat="server" ID="hlSignUp" NavigateUrl="~/AdminPanel/SignUp.aspx">
                            <i class="text-primary">SignUp</i>
                        </asp:HyperLink>
                    </div>

                </form>

            </div>

        </div>
    </div>
    <div id="dropDownSelect1"></div>

    <!--===============================================================================================-->
    <script src="~/Content/Login/vendor/jquery/jquery-3.2.1.min.js"></script>
    <!--===============================================================================================-->
    <script src="~/Content/Login/vendor/animsition/js/animsition.min.js"></script>
    <!--===============================================================================================-->
    <script src="~/Content/Login/vendor/bootstrap/js/popper.js"></script>
    <script src="~/Content/Login/vendor/bootstrap/js/bootstrap.min.js"></script>
    <!--===============================================================================================-->
    <script src="~/Content/Login/vendor/select2/select2.min.js"></script>
    <!--===============================================================================================-->
    <script src="~/Content/Login/vendor/daterangepicker/moment.min.js"></script>
    <script src="~/Content/Login/vendor/daterangepicker/daterangepicker.js"></script>
    <!--===============================================================================================-->
    <script src="~/Content/Login/vendor/countdowntime/countdowntime.js"></script>
    <!--===============================================================================================-->
    <script src="~/Content/Login/js/main.js"></script>


</body>
</html>
