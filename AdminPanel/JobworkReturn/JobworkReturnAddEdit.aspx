<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel.master" AutoEventWireup="true" CodeFile="JobworkReturnAddEdit.aspx.cs" Inherits="AdminPanel_JobworkReturn_JobworkReturnAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="kt-subheader   kt-grid__item" id="kt_subheader">
        <div class="kt-container  kt-container--fluid ">
            <div class="kt-subheader__main">

                <h3 class="kt-subheader__title">Jobwork Return            
                </h3>

                <span class="kt-subheader__separator kt-subheader__separator--v"></span>

                <div class="kt-subheader__group" id="kt_subheader_search">
                    <span class="kt-subheader__desc" id="kt_subheader_total">Enter Jobwork Return details and submit</span>

                </div>

            </div>
            <div class="kt-subheader__toolbar">
                <div class="kt-subheader__wrapper">
                   

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
                            <span class="kt-ribbon__inner"></span>Add Details Of Return 
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
                                    <asp:DropDownList runat="server" ID="ddlCustomer" CssClass="form-control" placeholder="Select Customer" AutoPostBack="True">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator runat="server" ID="rvfCustomer" ControlToValidate="ddlCustomer" Display="Dynamic" ErrorMessage="Select Customer" ForeColor="Red" ValidationGroup="JobworkReturn" />
                                </div>

                                <div class="col-lg-4" style="text-align: center">
                                    <br />
                                    <asp:Button ID="btnShow" runat="server" Text="Show" class="btn btn-brand" OnClick="btnShow_Click"></asp:Button>
                                </div>
                            </div>

                        </div>


                        <div class="container">
                            <asp:Label ID="lblMessage" runat="server" />

                            <div class="row">
                                <div class="col-md-12">
                                    <br />

                                    <asp:GridView ID="gvJobworkReturn" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-hover table-responsive-sm" OnRowCommand="gvJobworkReturn_RowCommand">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Delete ">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lbDelete" runat="server" Text="Delete" CssClass="btn btn-danger btn-sm d-sm-inline-block" CommandName="DeleteRecord" CommandArgument='<%# Eval("JobworkReturnID") %>'><i class="far fa-trash-alt"></i></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                                            <asp:BoundField DataField="ProductName" HeaderText="Prodcut Name" />
                                            <asp:BoundField DataField="IssueGross" HeaderText="Issue Gross" />
                                            <asp:BoundField DataField="ReturnGross" HeaderText="Return Gross" />
                                            <asp:BoundField DataField="PendingGross" HeaderText="Pending Gross" />
                                            <asp:TemplateField HeaderText="Complete Gross">
                                                <ItemTemplate>
                                                    <asp:HiddenField runat="server" ID="hfJobworkReturnID" Value='<%# Eval("JobworkReturnID") %>' />
                                                    <asp:HiddenField runat="server" ID="hfJobWorkOrderID" Value='<%# Eval("JobWorkOrderID") %>' />
                                                    <asp:TextBox runat="server" ID="txtCompleteGross" />
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                        </Columns>
                                    </asp:GridView>
                                    <br />
                                </div>
                            </div>
                            <div class="kt-portlet__foot">
                                <div class="kt-form__actions">
                                    <div class="row">

                                        <div class="col-lg-5"></div>
                                        <div class="col-lg-7">
                                            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-brand" Visible="false" ValidationGroup="JobworkOrder" OnClick="btnSave_Click"></asp:Button>
                                            <asp:HyperLink runat="server" ID="hlCancel" Text="Cancel" Visible="false" NavigateUrl="~/AdminPanel/JobworkOrder/JobworkOrderList.aspx" CssClass="btn btn-danger" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </form>

                    <!--end::Form-->
                    <!--end::Portlet-->
                </div>
            </div>
        </div>
    </div>
</asp:Content>



