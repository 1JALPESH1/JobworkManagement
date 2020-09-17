<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel.master" AutoEventWireup="true" CodeFile="CustomerAddEdit.aspx.cs" Inherits="Admin_Panel_Customer_CustomerAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="kt-subheader   kt-grid__item" id="kt_subheader">
        <div class="kt-container  kt-container--fluid ">
            <div class="kt-subheader__main">

                <h3 class="kt-subheader__title">Customer            
                </h3>

                <span class="kt-subheader__separator kt-subheader__separator--v"></span>

                <div class="kt-subheader__group" id="kt_subheader_search">
                    <span class="kt-subheader__desc" id="kt_subheader_total">Enter Customer details and submit</span>

                </div>

            </div>
            <div class="kt-subheader__toolbar">
                <div class="kt-subheader__wrapper">
                    <a href="CustomerList.aspx" class="btn kt-subheader__btn-primary">Go To List &nbsp;
                        <!--<i class="flaticon2-calendar-1"></i>-->
                    </a>


                </div>
            </div>
        </div>
    </div>

    <br />

    <div class="kt-container  kt-container--fluid  kt-grid__item kt-grid__item--fluid">
        <div class="row">
            <div class="col-lg-12">
                <!--begin::Portlet-->
                <div class="kt-portlet">
                    <div class="kt-portlet__head kt-portlet__head--noborder  kt-ribbon  kt-ribbon--alert kt-ribbon--left">
                        <div class="kt-ribbon__target" style="top: 12px; left: -2px; height: 40px; width: 300px">
                            <span class="kt-ribbon__inner"></span>Add Details Of Customer 
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
                                    <label>Customer Name :</label>
                                    <asp:TextBox runat="server" ID="txtCustomerName" class="form-control" placeholder="Customer Name" />
                                    <asp:RequiredFieldValidator runat="server" ID="rfvCustomerName" ControlToValidate="txtCustomerName" Display="Dynamic" ErrorMessage="Enter Address" ForeColor="Red" ValidationGroup="Customer" />

                                </div>
                            </div>

                            <div class="form-group row">
                                <div class="col-lg-6">
                                    <label>Email ID :</label>
                                    <asp:TextBox runat="server" ID="txtEmailAddress" CssClass="form-control" placeholder="Enter Email Address" TextMode="Email" />
                                    <asp:RequiredFieldValidator runat="server" ID="rvfEmailAddress" ControlToValidate="txtEmailAddress" Display="Dynamic" ErrorMessage="Enter Email Address" ForeColor="Red" ValidationGroup="Customer" />
                                    <asp:RegularExpressionValidator ID="rfvEmailAddress" runat="server" ControlToValidate="txtEmailAddress" Display="Dynamic" ErrorMessage="Enter Valid Email Address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                </div>
                                <div class="col-lg-6">
                                    <label>Mobile No :</label>
                                    <asp:TextBox runat="server" ID="txtMobileNo" class="form-control" placeholder="Enter Mobile No" />
                                    <asp:RequiredFieldValidator runat="server" ID="rfvMobileNo" ControlToValidate="txtMobileNo" Display="Dynamic" ErrorMessage="Enter Mobile No" ForeColor="Red" ValidationGroup="Customer" />

                                </div>
                            </div>

                            <div class="form-group row">
                                <div class="col-lg-12">
                                    <label>Address :</label>
                                    <asp:TextBox runat="server" ID="txtAddress" CssClass="form-control" placeholder="Enter Address" TextMode="MultiLine" Rows="3" />
                                    <asp:RequiredFieldValidator runat="server" ID="rfvAddress" ControlToValidate="txtAddress" Display="Dynamic" ErrorMessage="Enter Address" ForeColor="Red" ValidationGroup="Customer" />
                                </div>
                            </div>
                            <asp:Label ID="lblMessage" runat="server" CssClass="alert-success" EnableViewState="False" Style="text-align: center" ForeColor="#00CC00" />

                        </div>


                        <div class="kt-portlet">

                            <div class="kt-portlet__foot">
                                <div class="kt-form__actions">
                                    <div class="row">

                                        <div class="col-lg-5"></div>
                                        <div class="col-lg-7">
                                            <asp:Button ID="btnSave" runat="server" Text="Save" class="btn btn-brand" OnClick="btnSave_Click" ValidationGroup="Customer"></asp:Button>
                                            <asp:HyperLink runat="server" ID="hlCancel" Text="Cancel" NavigateUrl="~/AdminPanel/Customer/CustomerList.aspx" CssClass="btn btn-danger" />

                                        </div>
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

