<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DotNetHiringTst_Worklio.Default" Async="true" MaintainScrollPositionOnPostback="true" %>
<%@ Register Src="~/Countries.ascx" TagName="Countries" TagPrefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test Website</title>
    <style>
        .navbar {
            display: flex;
            position: relative;
            justify-content: space-between;
            align-items: center;
            background-color: #0b0c10;
            color: white;
            }
  
        .brand-title {
            font-size: 1.5rem;
            margin: .5rem;
            display: flex;
            gap: 1em;
            text-align: center;
            margin-left: 1em;
        }
        
        .brand-title a {
            align-self: center;
            text-decoration: none;
            color: white;
            transition: color 0.3s ease 0s;
        }
        
        .brand-title a:hover {
            color: #ff6600;
        }

        .brand-title img {
            width: 100%;
            height: 2em;
            width: 2em;
            border-radius: 4em;
            object-fit: cover;
        
        }
        
        .toggle-button {
            position: absolute;
            top: 1.25rem;
            right: 1rem;
            display: none;
            width: 30px;
            height: 30px;
            color: white;
            justify-self: center;
            align-self: center;
          }
        
        .navbar-links {
            height: 100%;
        }
        
        .navbar-links ul {
            display: flex;
            margin: 0;
            padding: 0;
        }
          
        .navbar-links li {
            list-style: none;
        }

        .navbar-links li a {
            display: block;
            text-decoration: none;
            color: white;
            padding: 1rem;
            transition: color 0.3s ease 0s;
        }
        
        .navbar-links li a:hover {
            color: #ff6600;
        }

        h1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <header>
          <nav class="navbar">
              <div class="brand-title">
                <a href="#">WORKLIO</a>
              </div>
              <a href="#" class="toggle-button">
                <i class="fas fa-bars"></i>
              </a>
              <div class="navbar-links">
                <ul>
                  <li><a href="#about-me">About me</a></li>
                </ul>
              </div>
          </nav>
      </header>
    <form id="form1" runat="server">
        <div>
            <h1>Select a Country</h1>
            <asp:Label runat="server" ID="lblTest02"> hello there </asp:Label>
            <uc1:Countries runat="server" id="Countries" />
        </div>
        <%--<button type="button" id="test" runat="server" onclick="clickTest" >click me</button>
        <asp:Button runat="server" Text="click me asp" OnClick="clickTest" />
        <span id="testing" runat="server">hello there</span>--%>
    </form>
</body>
</html>
