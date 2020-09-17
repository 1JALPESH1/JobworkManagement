﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel.master" AutoEventWireup="true" CodeFile="CustomerWiseProductList.aspx.cs" Inherits="AdminPanel_CustomerWiseProduct_CustomerWiseProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <!-- begin:: Content -->
  <%--  <div class="kt-subheader   kt-grid__item" id="kt_subheader">
        <div class="kt-container  kt-container--fluid ">
            <div class="kt-subheader__main">
                <h3 class="kt-subheader__title">
                    <button class="kt-subheader__mobile-toggle kt-subheader__mobile-toggle--left" id="kt_subheader_mobile_toggle"><span></span></button>
                    Admin Panel</h3>
                <span class="kt-subheader__separator kt-hidden"></span>
                <div class="kt-subheader__breadcrumbs">
                    <a href="#" class="kt-subheader__breadcrumbs-home"><i class="flaticon2-shelter"></i></a>
                    <span class="kt-subheader__breadcrumbs-separator"></span>
                    <a href="#" class="kt-subheader__breadcrumbs-link">CustomerWseProduct                  </a>
                    <span class="kt-subheader__breadcrumbs-separator"></span>
                    <a href="#" class="kt-subheader__breadcrumbs-link">CustomerWseProduct-List</a>
                </div>
            </div>
        </div>
    </div>--%>
    <div class="kt-container  kt-container--fluid  kt-grid__item kt-grid__item--fluid">
        <div class="kt-portlet kt-portlet--mobile">
            <div class="kt-portlet__head kt-portlet__head--lg">
                <div class="kt-portlet__head-label">
                    <span class="kt-portlet__head-icon">
                        <i class="kt-font-brand flaticon2-line-chart"></i>
                    </span>
                    <h3 class="kt-portlet__head-title">List of CustomerWiseProduct
                    </h3>
                </div>
                <div class="kt-portlet__head-toolbar">
                    <div class="kt-portlet__head-wrapper">
                        <div class="dropdown dropdown-inline">
                            <asp:HyperLink ID="hlCustomerWiseProductAdd" runat="server" Text="  Add New" NavigateUrl="~/AdminPanel/CustomerWiseProduct/CustomerWiseProductAddEdit.aspx" CssClass="btn btn-primary btn-icon-sm flaticon2-plus" />
                        </div>
                    </div>
                </div>
            </div>

            <div class="kt-portlet__body">
                <!--begin: Search Form -->
                <div class="kt-form kt-form--label-right kt-margin-t-20 kt-margin-b-10">
                    <div class="row align-items-center">
                        <div class="col-xl-8 order-2 order-xl-1">
                            <div class="row align-items-center">
                                <div class="col-md-4 kt-margin-b-20-tablet-and-mobile">
                                    <div class="kt-input-icon kt-input-icon--left">
                                        <%--<input type="text" class="form-control" placeholder="Search..." id="generalSearch">--%>
                                        <asp:TextBox runat="server" ID="txtSearch" CssClass="form-control generalSearch" placeholder="Search"></asp:TextBox>
                                        <span class="kt-input-icon__icon kt-input-icon__icon--left">
                                            <span><i class="la la-search"></i></span>
                                        </span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!--end: Search Form -->
            <div class="kt-portlet__body kt-portlet__body--fit">
                <!--begin: Datatable -->
                <div class="kt-datatable" id="local_data"></div>
                <!--end: Datatable -->
            </div>
            <!-- end:: Content -->

            <!-- end:: Page -->






            <!-- begin::Quick Panel -->
            <div id="kt_quick_panel" class="kt-quick-panel">
                <a href="#" class="kt-quick-panel__close" id="kt_quick_panel_close_btn"><i class="flaticon2-delete"></i></a>

                <div class="kt-quick-panel__nav">
                    <ul class="nav nav-tabs nav-tabs-line nav-tabs-bold nav-tabs-line-3x nav-tabs-line-brand  kt-notification-item-padding-x" role="tablist">
                        <li class="nav-item active">
                            <%--<a class="nav-link active" data-toggle="tab" href="#kt_quick_panel_tab_notifications" role="tab">Notifications</a>--%>
                            <asp:HyperLink runat="server" ID="hlCancel" Text="Cancel" NavigateUrl="~/AdminPanel/CustomerWiseProduct/CustomerWiseProductList.aspx" CssClass="nav-link active" />
                        </li>
                        <li class="nav-item">
                            <%--<a class="nav-link" data-toggle="tab" href="#kt_quick_panel_tab_logs" role="tab">Audit Logs</a>--%>
                            <asp:HyperLink runat="server" ID="HyperLink1" Text="Cancel" NavigateUrl="~/AdminPanel/CustomerWiseProduct/CustomerWiseProductAddEdit.aspx" CssClass="nav-link" />
                        </li>
                    </ul>
                </div>
            </div>
            <!-- end::Quick Panel -->

            <!-- begin::Global Config(global config for global JS sciprts) -->
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
                            "warning": "#ffb822"
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
            <script src="~/Content/assets/plugins/global/plugins.bundle.js" type="text/javascript"></script>
            <script src="~/Content/assets/js/scripts.bundle.js" type="text/javascript"></script>
            <!--end::Global Theme Bundle -->


            <!--begin::Page Scripts(used by this page) -->
            <script src="~/Content/assets/js/pages/crud/metronic-datatable/base/data-local.js" type="text/javascript"></script>
            <!--end::Page Scripts -->

            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <br />
                        <asp:Label runat="server" ID="lblMessage" EnableViewState="false" />

                        <asp:GridView ID="gvCustomerWiseProduct" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-hover table-responsive-sm" OnRowCommand="gvCustomerWiseProduct_RowCommand">
                            <Columns>
                                <asp:TemplateField HeaderText="Operations ">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="hlEdit" runat="server" Text="Edit" CssClass="btn btn-warning btn-sm d-sm-inline-block" NavigateUrl='<%# "~/AdminPanel/CustomerWiseProduct/CustomerWiseProductAddEdit.aspx?CustomerWiseProductID=" + Eval("CustomerWiseProductID").ToString().Trim() %>'><i class="far fa-edit"></i></asp:HyperLink>
                                        <asp:LinkButton ID="lbDelete" runat="server" Text="Delete" CssClass="btn btn-danger btn-sm d-sm-inline-block" CommandName="DeleteRecord" CommandArgument='<%# Eval("CustomerWiseProductID") %>'><i class="far fa-trash-alt"></i></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="CustomerWiseProductID" HeaderText=" ID" />
                                <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                                <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                            </Columns>
                        </asp:GridView>
                        <br />
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>









