<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Countries.ascx.cs" Inherits="DotNetHiringTst_Worklio.Countries" %>


<style>

    .countries-wrapper {
        display: flex;
        flex-wrap: wrap;
        height: min-content;
    }

    .countries-wrapper input {
        margin: 0;
        padding: 0;
        text-align: center;
        color: white;
        background-color: black;
        margin: 0.5em;
        height: min-content;
        width: max-content;
        padding: 0.4em 1em 0.4em 1em;    
        text-align: center;
        border-radius: 10px;
        transition: color 0.3s ease 0s;
        text-decoration: none;
    }

    .countries-wrapper input:hover {
        color: #ff6600;
    }

</style>


<%--<div class="countries-wrapper">
    <asp:PlaceHolder ID="holder" runat="server" />
    <br />
</div>--%>






<%--<div id="countriesSection" class="countries-wrapper" runat="server">
    <asp:ListView ID="ListView1" runat="server">
        <ItemTemplate  >
            <div>
                <asp:Button  runat="server" ID='button01' Text='<%# Eval("name.common") %>' OnClick="handleCountryClicked" />
            </div>
        </ItemTemplate>
    </asp:ListView>
</div>--%>


<%--<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <asp:Label runat="server" id="show"  >hello there</asp:Label>
    </ContentTemplate>
</asp:UpdatePanel>--%>
<asp:GridView ID="GridView1" runat="server" AllowSorting="True" OnSorting="GridView1_Sorting" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
    <AlternatingRowStyle BackColor="White" />
    <EditRowStyle BackColor="#2461BF" />
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#EFF3FB" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F5F7FB" />
    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
    <SortedDescendingCellStyle BackColor="#E9EBEF" />
    <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>

<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <asp:Label runat="server" ID="lblCapital"></asp:Label>
        <br />
        <asp:Label runat="server" ID="lblBorders"></asp:Label>
        <asp:BulletedList runat="server" ID="bulletList">

        </asp:BulletedList>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="GridView1" EventName="SelectedIndexChanged">
        </asp:AsyncPostBackTrigger>
    </Triggers>
</asp:UpdatePanel>
