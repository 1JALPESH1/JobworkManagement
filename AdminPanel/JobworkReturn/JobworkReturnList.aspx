<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel.master" AutoEventWireup="true" CodeFile="JobworkReturnList.aspx.cs" Inherits="AdminPanel_JobworkReturn_JobworkReturnList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <!-- begin:: Content -->
    <div class="kt-container  kt-container--fluid  kt-grid__item kt-grid__item--fluid">
        <div class="kt-portlet kt-portlet--mobile">
            <div class="kt-portlet__head kt-portlet__head--lg">
                <div class="kt-portlet__head-label">
                    <span class="kt-portlet__head-icon">
                        <i class="kt-font-brand flaticon2-line-chart"></i>
                    </span>
                    <h3 class="kt-portlet__head-title">List of JobworkReturn
                    </h3>
                </div>
                <div class="kt-portlet__head-toolbar">
                    <div class="kt-portlet__head-wrapper">
                        <div class="dropdown dropdown-inline">
                            <asp:HyperLink ID="hlJobworkReturnAdd" runat="server" Text="Add New" NavigateUrl="~/AdminPanel/JobworkReturn/JobworkReturnAddEdit.aspx" CssClass="btn btn-primary btn-icon-sm flaticon2-plus" />
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
                            <asp:HyperLink runat="server" ID="hlCancel" Text="Cancel" NavigateUrl="~/AdminPanel/JobworkReturn/JobworkReturnList.aspx" CssClass="nav-link active" />
                        </li>
                        <li class="nav-item">
                            <%--<a class="nav-link" data-toggle="tab" href="#kt_quick_panel_tab_logs" role="tab">Audit Logs</a>--%>
                            <asp:HyperLink runat="server" ID="HyperLink1" Text="Cancel" NavigateUrl="~/AdminPanel/JobworkReturn/JobworkReturnAddEdit.aspx" CssClass="nav-link" />
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

            <div class="Container">
            <div class="row">
                <div class="col-md-12">
                    <br />
                    <asp:Label runat="server" ID="lblMessage" CssClass="alert-danger" EnableViewState="false" />

                    <asp:GridView ID="gvJobworkReturn" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-hover table-responsive-sm">
                        <Columns>
                            <asp:TemplateField HeaderText="Edit ">
                                <ItemTemplate>
                                    <asp:HyperLink runat="server" ID="hlEdit" CssClass="btn btn-primary" NavigateUrl='<%# "~/AdminPanel/JobworkReturn/JobworkReturnAddEdit.aspx?JobworkReturnID=" + Eval("JobworkReturnID").ToString().Trim() %>'>Edit</asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Delete ">
                                <ItemTemplate>
                                        <asp:LinkButton ID="lbDelete" runat="server" Text="Delete" CssClass="btn btn-danger btn-sm d-sm-inline-block" CommandName="DeleteRecord" CommandArgument='<%# Eval("JobworkReturnID") %>'><i class="far fa-trash-alt"></i></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                              <asp:BoundField DataField="JobworkReturnID" HeaderText=" ID" />
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









   