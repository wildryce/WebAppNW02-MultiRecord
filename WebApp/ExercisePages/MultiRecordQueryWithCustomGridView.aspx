<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MultiRecordQueryWithCustomGridView.aspx.cs" Inherits="WebApp.ExercisePages.MultiRecordQueryWithCustomGridView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h1> Multi Record Query with Custom GridView</h1>
    <div class="offset-2">
        <asp:Label ID="Label1" runat="server" Text="Select an Item: "></asp:Label>&nbsp;&nbsp;   
        <asp:DropDownList ID="List01" runat="server"></asp:DropDownList>&nbsp;&nbsp;
        <asp:Button ID="Fetch" runat="server" Text="Fetch" 
             CausesValidation="false" OnClick="Fetch_Click"/>
        <br />

        <asp:Label ID="MessageLabel" runat="server" ></asp:Label>
        <br />
    </div>

    <asp:GridView ID="List02" runat="server" 
            AutoGenerateColumns="False"
             CssClass="table table-bordered" GridLines="Horizontal"
             BorderStyle="Solid" AllowPaging="True" OnPageIndexChanging="List02_PageIndexChanging" PageSize="5" OnSelectedIndexChanged="List02_SelectedIndexChanged">

            <Columns>
                <asp:TemplateField HeaderText="Player Name">
                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
                    <ItemTemplate>
                        <%-- this is where your reference to the data on your
                              record is placed--%>
                        <asp:Label ID="PlayerName" runat="server" 
                            Text='<%# Eval("PlayerName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Age">
                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
                     <ItemTemplate>
                        <asp:Label ID="Age" runat="server" 
                            Text='<%# Eval("Age") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

               <asp:TemplateField HeaderText="Gender">
                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
                     <ItemTemplate>
                        <asp:Label ID="Gender" runat="server" 
                            Text='<%# Eval("Gender").ToString() == "M" ? "Male" : "Female" %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Med Alert">
                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
                     <ItemTemplate>
                         <asp:Label ID="MedicalAlertDetails" runat="server" 
                              Text='<%# Eval("MedicalAlertDetails") == null ? "" : Eval("MedicalAlertDetails") %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                This team has no players or does not exist.
            </EmptyDataTemplate>
            <PagerSettings Mode="NumericFirstLast" PageButtonCount="10"/>
        </asp:GridView>
</asp:Content>
