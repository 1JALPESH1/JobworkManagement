<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel.master" AutoEventWireup="true" CodeFile="JobworkOrderAddEdit.aspx.cs" Inherits="AdminPanel_JobworkOrder_JobworkOrderAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="kt-subheader   kt-grid__item" id="kt_subheader">
        <div class="kt-container  kt-container--fluid ">
            <div class="kt-subheader__main">

                <h3 class="kt-subheader__title">Order            
                </h3>

                <span class="kt-subheader__separator kt-subheader__separator--v"></span>

                <div class="kt-subheader__group" id="kt_subheader_search">
                    <span class="kt-subheader__desc" id="kt_subheader_total">Enter Order details and submit</span>

                </div>

            </div>
            <div class="kt-subheader__toolbar">
                <div class="kt-subheader__wrapper">
                    <a href="JobworkOrderList.aspx" class="btn kt-subheader__btn-primary">Go To List &nbsp;
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
                            <span class="kt-ribbon__inner"></span>Add Details Of Order 
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

                                <div class="col-lg-6">
                                    <label>Customer :</label>


                                    <asp:DropDownList runat="server" ID="ddlCustomer" CssClass="form-control" placeholder="Select Customer" AutoPostBack="True" OnSelectedIndexChanged="ddlCustomer_SelectedIndexChanged">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator runat="server" ID="rvfCustomer" ControlToValidate="ddlCustomer" Display="Dynamic" ErrorMessage="Select Customer" ForeColor="Red" ValidationGroup="JobworkOrder" />
                                </div>
                                <div class="col-lg-6">
                                    <label>Product :</label>

                                    <asp:DropDownList runat="server" ID="ddlProduct" CssClass="form-control" placeholder="Select Product" AutoPostBack="True"></asp:DropDownList>
                                    <asp:RequiredFieldValidator runat="server" ID="rvfProduct" ControlToValidate="ddlProduct" Display="Dynamic" ErrorMessage="Select Product" ForeColor="Red" ValidationGroup="JobworkOrder" />


                                </div>
                            </div>

                            <div class="form-group row kt-input-icon">
                                <div class="col-lg-6">
                                    <label>Gross :</label>
                                    <asp:TextBox runat="server" ID="txtGross" class="form-control" placeholder="Gross" />
                                    <asp:RequiredFieldValidator runat="server" ID="rfvGross" ControlToValidate="txtGross" Display="Dynamic" ErrorMessage="Enter Gross" ForeColor="Red" ValidationGroup="JobworkOrder" />
                                </div>
                                <div class="col-lg-6">
                                    <label>Rate :</label>

                                    <asp:TextBox runat="server" ID="txtRate" class="form-control" placeholder="Rate" />
                                    <asp:RequiredFieldValidator runat="server" ID="rfvRate" ControlToValidate="txtRate" Display="Dynamic" ErrorMessage="Enter Rate" ForeColor="Red" ValidationGroup="JobworkOrder" />

                                </div>
                            </div>

                            <div class="form-group row">
                                <div class="col-lg-6">
                                    <label>Issue Date :</label>

                                    <asp:TextBox runat="server" ID="txtIssueDate" class="form-control" TextMode="Date" placeholder="Issue Date" />
                                    <asp:RequiredFieldValidator runat="server" ID="rfvIssueDate" ControlToValidate="txtIssueDate" Display="Dynamic" ErrorMessage="Enter Issue Date" ForeColor="Red" ValidationGroup="JobworkOrder" />

                                </div>
                                <div class="col-lg-6">
                                    <label>Return Date :</label>

                                    <asp:TextBox runat="server" ID="txtReturnDate" class="form-control" TextMode="Date" placeholder="Return Date" />
                                    <asp:RequiredFieldValidator runat="server" ID="rfvReturnDate" ControlToValidate="txtIssueDate" Display="Dynamic" ErrorMessage="Enter Return Date" ForeColor="Red" ValidationGroup="JobworkOrder" />

                                </div>
                            </div>
                            <asp:Label ID="lblMessage" runat="server" CssClass="alert-success" EnableViewState="False" Style="text-align: center" ForeColor="#00CC00" />

                        </div>



                        <div class="kt-portlet__foot">
                            <div class="kt-form__actions">
                                <div class="row">

                                    <div class="col-lg-5"></div>
                                    <div class="col-lg-7">
                                        <asp:Button ID="btnSave" runat="server" Text="Save" class="btn btn-brand" OnClick="btnSave_Click" ValidationGroup="JobworkOrder"></asp:Button>
                                        <asp:HyperLink runat="server" ID="hlCancel" Text="Cancel" NavigateUrl="~/AdminPanel/JobworkOrder/JobworkOrderList.aspx" CssClass="btn btn-danger" />
                                    </div>
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

</asp:Content>

