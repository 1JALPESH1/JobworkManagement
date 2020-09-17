<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="AdminPanel_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"> <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Poppins:300,400,500,600,700|Roboto:300,400,500,600,700" />
    <!--end::Fonts -->

    <!--begin::Page Vendors Styles(used by this page) -->
    <link href="<%=ResolveClientUrl("assets/plugins/custom/fullcalendar/fullcalendar.bundle.css")%>" rel="stylesheet" type="text/css" />
    <!--end::Page Vendors Styles -->


    <!--begin::Global Theme Styles(used by all pages) -->
    <link href="<%=ResolveClientUrl("assets/plugins/global/plugins.bundle.css")%>" rel="stylesheet" type="text/css" />
    <link href="<%=ResolveClientUrl("assets/css/style.bundle.css")%>" rel="stylesheet" type="text/css" />
    <!--end::Global Theme Styles -->

    <!--begin::Layout Skins(used by all pages) -->
    <link href="<%=ResolveClientUrl("assets/css/skins/header/base/light.css")%>" rel="stylesheet" type="text/css" />
    <link href="<%=ResolveClientUrl("assets/css/skins/header/menu/light.css")%>" rel="stylesheet" type="text/css" />
    <link href="<%=ResolveClientUrl("assets/css/skins/brand/dark.css")%>" rel="stylesheet" type="text/css" />
    <link href="<%=ResolveClientUrl("assets/css/skins/aside/dark.css")%>" rel="stylesheet" type="text/css" />


    <!--end::Layout Skins -->

    <!-- Data Table -->
     <!--begin::Page CSS(used by this page) -->
    <link href="<%=ResolveClientUrl("assets/css/datatable/dataTables.bootstrap4.min.css")%>" rel="stylesheet" type="text/css" />
    <link href="<%=ResolveClientUrl("assets/css/datatable/responsive.bootstrap4.min.css")%>" rel="stylesheet" />
    <!--end::Page CSS -->

   
    
  





    <!-- Hotjar Tracking Code for keenthemes.com -->
    <script>
        (function (h, o, t, j, a, r) {
            h.hj = h.hj || function () { (h.hj.q = h.hj.q || []).push(arguments) };
            h._hjSettings = { hjid: 1070954, hjsv: 6 };
            a = o.getElementsByTagName('head')[0];
            r = o.createElement('script'); r.async = 1;
            r.src = t + h._hjSettings.hjid + j + h._hjSettings.hjsv;
            a.appendChild(r);
        })(window, document, 'https://static.hotjar.com/c/hotjar-', '.js?sv=');
    </script>
    <!-- Global site tag (gtag.js) - Google Analytics -->
    <script async src="https://www.googletagmanager.com/gtag/js?id=UA-37564768-1"></script>
    <script>
        window.dataLayer = window.dataLayer || [];
        function gtag() { dataLayer.push(arguments); }
        gtag('js', new Date());
        gtag('config', 'UA-37564768-1');
    </script>
     <script>
         var KTAppOptions = {
             "colors": {
                 "state": {
                     "brand": "#5d78ff",
                     "dark": "#282a3c",
                     "light": "#ffffff",
                     "primary": "#5867dd",
                     "success": "#34bfa3",
                     "info": "#36a3f7",
                     "warning": "#ffb822",
                     "danger": "#fd3995"
                 },
                 "base": {
                     "label": [
                         "#c5cbe3",
                         "#a1a8c3",
                         "#3d4465",
                         "#3e4466"
                     ],
                     "shape": [
                         "#f0f3ff",
                         "#d9dffa",
                         "#afb4d4",
                         "#646c9a"
                     ]
                 }
             }
         };
    </script>
    <!-- end::Global Config -->

    <!--begin::Global Theme Bundle(used by all pages) -->
    <script src="<%=ResolveClientUrl("assets/plugins/global/plugins.bundle.js")%>" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("assets/js/scripts.bundle.js")%>" type="text/javascript"></script>
    <!--end::Global Theme Bundle -->

    <!--begin::Page Vendors(used by this page) -->
    <script src="<%=ResolveClientUrl("assets/plugins/custom/fullcalendar/fullcalendar.bundle.js")%>" type="text/javascript"></script>
    <script src="http://maps.google.com/maps/api/js?key=AIzaSyBTGnKT7dt597vo9QgeQ7BFhvSRP4eiMSM" type="text/javascript"></script>
    <script src="<%=ResolveClientUrl("assets/plugins/custom/gmaps/gmaps.js")%>" type="text/javascript"></script>
    <!--end::Page Vendors -->

    <!--begin::Page Scripts(used by this page) -->
    <script src="<%=ResolveClientUrl("assets/js/pages/dashboard.js")%>" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="kt-subheader   kt-grid__item" id="kt_subheader">
        <div class="kt-container  kt-container--fluid ">
            <div class="kt-subheader__main">

                <h3 class="kt-subheader__title">Exam            
                </h3>

                <span class="kt-subheader__separator kt-subheader__separator--v"></span>

                <div class="kt-subheader__group" id="kt_subheader_search">
                    <span class="kt-subheader__desc" id="kt_subheader_total">Enter Exam details and submit</span>

                </div>

            </div>
            <div class="kt-subheader__toolbar">
                <div class="kt-subheader__wrapper">
                    <a href="#" class="btn kt-subheader__btn-primary">Go To List &nbsp;
                        <!--<i class="flaticon2-calendar-1"></i>-->
                    </a>


                </div>
            </div>
        </div>
    </div>
    <asp:Label ID="lblMessage" runat="server" CssClass="label-info" />
    <br />

    <div class="kt-container  kt-container--fluid  kt-grid__item kt-grid__item--fluid">
        <div class="row">
            <div class="col-lg-12">
                <!--begin::Portlet-->
                <div class="kt-portlet">
                    <div class="kt-portlet__head kt-portlet__head--noborder  kt-ribbon  kt-ribbon--alert kt-ribbon--left">
                        <div class="kt-ribbon__target" style="top: 12px; left: -2px; height: 40px; width: 300px">
                            <span class="kt-ribbon__inner"></span>Add Details Of Exam 
                        </div>
                    </div>

                    <!--end::Portlet-->

                    <!--begin::Portlet-->

                    <!--end::Portlet-->

                    <!--begin::Portlet-->

                    <!--end::Portlet-->

                    <!--begin::Portlet-->

                    <!--begin::Form-->
                    <br />
                    <div class="kt-portlet__head">
                        <div class="kt-portlet__head-label">
                            <h3 class="kt-portlet__head-title">Basic Information
                            </h3>
                        </div>
                    </div>
                    <form class="kt-form kt-form--label-right">
                        <div class="kt-portlet__body">
                            <div class="form-group row">

                                <div class="col-lg-12">
                                    <label>Institute :</label>

                                    <select class="custom-select form-control">
                                        <option selected="">Select Institute</option>
                                        <option value="1">Darshan</option>
                                       
                                    </select>

                                </div>
                            </div>
                            <div class="form-group row">

                                <div class="col-lg-6">
                                    <label>Academic Year :</label>

                                    <select class="custom-select form-control">
                                        <option selected="">Select Academic Year</option>
                                        <option value="1">2017-18</option>
                                        <option value="2">2018-19</option>
                                        <option value="3">2019-20</option>
                                        <option value="4">2020-21</option>
                                    </select>

                                </div>
                                <div class="col-lg-6">
                                    <label>Exam Type : ( Regular / Remedial )</label>
                                    <asp:TextBox runat="server" ID="txtExamType" class="form-control" placeholder="Exam Type" />
                                </div>
                            </div>
                            <div class="form-group row">
                                <div class="col-lg-12">
                                    <label>Exam Name :</label>

                                    <asp:TextBox runat="server" ID="txtExam" class="form-control" placeholder="Exam Name" />

                                </div>
                            </div>
                        </div>
                        </div>


                        <div class="kt-portlet">
                      <div class="kt-portlet__body">
                      <div class="form-group row">
                            <div class="col-lg-12">
                                <label>Remarks :</label>

                               
                                     <textarea runat="server" id="Textarea2" class="form-control" placeholder="" />

                                

                            </div>
                          </div>
                          </div>
                <div class="kt-portlet__foot">
                    <div class="kt-form__actions">
                        <div class="row">
                        
                            <div class="col-lg-5"></div>
                            <div class="col-lg-7">
                                <button type="reset" class="btn btn-brand">Save</button>
                                <button type="reset" class="btn btn-secondary">Cancel</button>
                            </div>
                        </div>
                    </div>
                </div>
                </form>
			<!--end::Form-->
            </div>
            <!--end::Portlet-->
        </div>
    </div>
    </div>
   
</asp:Content>

