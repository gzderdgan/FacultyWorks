<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexStudent.aspx.cs" Inherits="ProjectStockSystem.WebForm1" %>

<!DOCTYPE html>

<style type="text/css">
    .auto-style2 {
        width: 295px
    }
    .auto-style3 {
        width: 220px
    }
    .auto-style4 {
        width: 152px
    }
    .auto-style5 {
        width: 100%;
        height: 235px;
    }
    .auto-style6 {
        width: 220px;
        height: auto;
        table-layout: auto;
    }
</style>

<form runat="server">
<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Stock Tracking System</title>

    <!-- Bootstrap Core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom CSS -->
    <link href="css/sb-admin.css" rel="stylesheet">

    <!-- Morris Charts CSS -->
    <link href="css/plugins/morris.css" rel="stylesheet">

    <!-- Custom Fonts -->
    <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

</head>

<body>

    <div id="wrapper">

        <!-- Navigation -->
        <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="IndexStudent.aspx"> &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp Öğrenci Malzeme Takip </a>
            </div>
            <!-- Top Menu Items -->
            <ul class="nav navbar-right top-nav">
                <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown"><i class="fa fa-envelope"></i> <b class="caret"></b></a>
                    <ul class="dropdown-menu message-dropdown">
                        <li class="message-preview">
                            <a href="#">
                                <div class="media">
                                    <span class="pull-left">
                                        <img class="media-object" src="http://placehold.it/50x50" alt="">
                                    </span>
                                    <div class="media-body">
                                        <h5 class="media-heading"><strong>John Smith</strong>
                                        </h5>
                                        <p class="small text-muted"><i class="fa fa-clock-o"></i> Yesterday at 4:32 PM</p>
                                        <p>Lorem ipsum dolor sit amet, consectetur...</p>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class="message-preview">
                            <a href="#">
                                <div class="media">
                                    <span class="pull-left">
                                        <img class="media-object" src="http://placehold.it/50x50" alt="">
                                    </span>
                                    <div class="media-body">
                                        <h5 class="media-heading"><strong>John Smith</strong>
                                        </h5>
                                        <p class="small text-muted"><i class="fa fa-clock-o"></i> Yesterday at 4:32 PM</p>
                                        <p>Lorem ipsum dolor sit amet, consectetur...</p>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class="message-preview">
                            <a href="#">
                                <div class="media">
                                    <span class="pull-left">
                                        <img class="media-object" src="http://placehold.it/50x50" alt="">
                                    </span>
                                    <div class="media-body">
                                        <h5 class="media-heading"><strong>John Smith</strong>
                                        </h5>
                                        <p class="small text-muted"><i class="fa fa-clock-o"></i> Yesterday at 4:32 PM</p>
                                        <p>Lorem ipsum dolor sit amet, consectetur...</p>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class="message-footer">
                            <a href="#">Read All New Messages</a>
                        </li>
                    </ul>
                </li>
                <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown"><i class="fa fa-bell"></i> <b class="caret"></b></a>
                    <ul class="dropdown-menu alert-dropdown">
                        <li>
                            <a href="#">Alert Name <span class="label label-default">Alert Badge</span></a>
                        </li>
                        <li>
                            <a href="#">Alert Name <span class="label label-primary">Alert Badge</span></a>
                        </li>
                        <li>
                            <a href="#">Alert Name <span class="label label-success">Alert Badge</span></a>
                        </li>
                        <li>
                            <a href="#">Alert Name <span class="label label-info">Alert Badge</span></a>
                        </li>
                        <li>
                            <a href="#">Alert Name <span class="label label-warning">Alert Badge</span></a>
                        </li>
                        <li>
                            <a href="#">Alert Name <span class="label label-danger">Alert Badge</span></a>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <a href="#">View All</a>
                        </li>
                    </ul>
                </li>
                <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown"><i class="fa fa-user"></i> <asp:Label ID="loginName" runat="server" Text="Label"></asp:Label> <b class="caret"></b></a>
                    <ul class="dropdown-menu">
                        <li>
                            <a href="#"><i class="fa fa-fw fa-user"></i> Profile</a>
                        </li>
                        <li>
                            <a href="#"><i class="fa fa-fw fa-envelope"></i> Inbox</a>
                        </li>
                        <li>
                            <a href="#"><i class="fa fa-fw fa-gear"></i> Settings</a>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <a href="#"><i class="fa fa-fw fa-power-off"></i> <asp:Button ID="logOutButton" runat="server" Text="Logout" OnClick="logOutButton_Click" /> </a>
                        </li>
                    </ul>
                </li>
            </ul>
            <!-- Sidebar Menu Items - These collapse to the responsive navigation menu on small screens -->
            <div class="collapse navbar-collapse navbar-ex1-collapse">
                <ul class="nav navbar-nav side-nav">
                    <li class="active">
                        <a href="IndexStudent.aspx"><i class="fa fa-fw fa-dashboard"></i> Öğrenci Bilgileri </a>
                    </li>
                    <li>
                        <a href="IndexStudentGroup.aspx"><i class="fa fa-fw fa-edit"></i>Grup Bilgileri </a>
                    </li>
                    <li>
                        <a href="IndexStudentSelectAssistantCourse.aspx"><i class="fa fa-fw fa-table"></i> Danışman ve Ders Bilgileri  </a>
                    </li>
                    <li>
                        <a href="IndexStudentMaterial.aspx"><i class="fa fa-fw fa-bar-chart-o"></i> Malzeme Bilgileri </a>
                    </li>                   
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </nav>

        <div id="page-wrapper">

            <div class="container-fluid">
                 <div class="panel panel-primary">
                  <div class="panel-heading">
                                <h3 class="panel-title">Öğrenci Bilgileri</h3>
                            </div>
             
   
            <table class="auto-style5">
                <tr>
                    <td aria-expanded="false" class="auto-style4" rowspan="6">
                        <img alt="" src="" style="padding: 0px; margin: 0px; height: 231px; width: 188px; position: inherit; z-index: auto;" />
                    </td>
                    <td aria-expanded="false" aria-setsize="20" class="auto-style2" style="margin: 8px; padding: 8px; border-spacing: inherit; font-weight: bold;">Rezervasyon ID :&nbsp; </td>
                    <td aria-expanded="false" aria-setsize="20" class="auto-style6" style="margin: 8px; padding: 8px; border-spacing: inherit;">
                        <asp:TextBox ID="tcTxtbox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td aria-expanded="false" class="auto-style2" aria-setsize="20" style="margin: 8px; padding: 8px; border-spacing: inherit; font-weight: bold;">TC :</td>
                    <td aria-expanded="false" class="auto-style6" aria-setsize="20" style="margin: 8px; padding: 8px; border-spacing: inherit;">
                        <asp:TextBox ID="rzTxtbox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td aria-expanded="false" class="auto-style2" aria-setsize="20" style="margin: 8px; padding: 8px; border-spacing: inherit; font-weight: bold;">Ad:</td>
                    <td aria-expanded="false" class="auto-style6" aria-setsize="20" style="margin: 8px; padding: 8px; border-spacing: inherit;">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                  <tr>
                    <td aria-expanded="false" class="auto-style2" aria-setsize="20" style="margin: 8px; padding: 8px; border-spacing: inherit; font-weight: bold;">Soyad:</td>
                    <td aria-expanded="false" class="auto-style6" aria-setsize="20" style="margin: 8px; padding: 8px; border-spacing: inherit;">
                        <asp:TextBox ID="surnameTxtbox" runat="server"></asp:TextBox>
                      </td>
                </tr>
                  <tr>
                    <td aria-expanded="false" class="auto-style2" aria-setsize="20" style="margin: 8px; padding: 8px; border-spacing: inherit; font-weight: bold;">Bölüm:</td>
                    <td aria-expanded="false" class="auto-style6" aria-setsize="20" style="margin: 8px; padding: 8px; border-spacing: inherit;">
                        <asp:TextBox ID="dptTxtbox" runat="server"></asp:TextBox>
                      </td>
                </tr>
                <tr>
                    <td aria-expanded="false" aria-setsize="20" class="auto-style2" style="margin: 8px; padding: 8px;border-spacing: inherit; font-weight: bold;">
                        Telefon(*):</td>
                    <td aria-expanded="false" aria-setsize="20" class="auto-style6" style="margin: 8px; padding: 8px; border-spacing: inherit;">
                        <asp:TextBox ID="telTxtbox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                
                    </td>
                      <td>
                
                    </td>
                      <td class="auto-style3">
                
                    </td>
                     <td>
                         <asp:Button ID="btnSaveContinue" runat="server" Text="Kaydet ve Devam Et" Height="29px" Width="227px" OnClick="btnKaydetIlerle_Click"></asp:Button>

                    </td>
            
                </tr>
                 <tr>
                    <td>
                
                    </td>
                      <td>
                
                    </td>
                      <td class="auto-style3">
                
                    </td>
                     <td>
 

                    </td>
            
                </tr>
            </table>
    

               </div>


        </div>
        <!-- /#page-wrapper -->

    </div>
    <!-- /#wrapper -->

    <!-- jQuery -->
    <script src="js/jquery.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="js/bootstrap.min.js"></script>

    <!-- Morris Charts JavaScript -->
    <script src="js/plugins/morris/raphael.min.js"></script>
    <script src="js/plugins/morris/morris.min.js"></script>
    <script src="js/plugins/morris/morris-data.js"></script>
    </div>



</body>

</html>
    </form>