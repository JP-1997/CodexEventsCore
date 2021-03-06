#pragma checksum "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e31cbe2273ae304f5266e9368cd686b2ecae2927"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManageRequests), @"mvc.1.0.view", @"/Views/Admin/ManageRequests.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\NET_Workspace\CodexEvents\Views\_ViewImports.cshtml"
using CodexEvents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NET_Workspace\CodexEvents\Views\_ViewImports.cshtml"
using CodexEvents.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e31cbe2273ae304f5266e9368cd686b2ecae2927", @"/Views/Admin/ManageRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce086ff6333d3f2cf17b96db242419ceb7d9edb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ManageRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CodexEvents.Models.UserRequest>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myPage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-spy", new global::Microsoft.AspNetCore.Html.HtmlString("scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString(".navbar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-offset", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
  
    List<UserRequest> urs = ViewBag.UserRequests;
    int eventId = ViewBag.EventId;
    string eventName = ViewBag.EventName;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e31cbe2273ae304f5266e9368cd686b2ecae29275119", async() => {
                WriteLiteral(@"
    <meta charset=""ISO-8859-1"">
    <title>Upcoming Events</title>
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <link href=""https://fonts.googleapis.com/css?family=Montserrat"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Lato"" rel=""stylesheet"" type=""text/css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
    <style>
        body {
            font: 400 15px Lato, sans-serif;
            line-height: 1.8;
            color: #818181;
        }

        h2 {
            font-size: 24px;
            text-transform: uppercase;
            color: #303030;
            font-weight: 600;
            margin-top: 30px;
        }

        h4 {
            font-size: 19px;
            line-height: 1.375em;
            color: #303030;
            ");
                WriteLiteral(@"font-weight: 400;
            margin-bottom: 30px;
        }

        .jumbotron {
            background-color: #f4511e;
            color: #fff;
            padding: 100px 25px;
            font-family: Montserrat, sans-serif;
        }

        .container-fluid {
            padding: 60px 50px;
        }

        .bg-grey {
            background-color: #f6f6f6;
        }

        .navbar {
            margin-bottom: 0;
            background-color: #f4511e;
            z-index: 9999;
            border: 0;
            font-size: 12px !important;
            line-height: 1.42857143 !important;
            letter-spacing: 4px;
            border-radius: 0;
            font-family: Montserrat, sans-serif;
        }

            .navbar li a, .navbar .navbar-brand {
                color: #fff !important;
            }

        .navbar-nav li a:hover, .navbar-nav li.active a {
            color: #f4511e !important;
            background-color: #fff !important;
        }");
                WriteLiteral(@"

        .navbar-default .navbar-toggle {
            border-color: transparent;
            color: #fff !important;
        }

        .slideanim {
            visibility: hidden;
        }

        .slide {
            animation-name: slide;
            -webkit-animation-name: slide;
            animation-duration: 1s;
            -webkit-animation-duration: 1s;
            visibility: visible;
        }

        .noEvents {
            text-align: center;
            font-weight: bold;
            font-size: 20px;
        }

        .myEventsTable {
            width: 85%;
            margin: 0 auto;
            border-radius: 16px;
            background: #ffffff;
            box-shadow: 10px 10px 21px #8a8a8a, -10px -10px 21px #ffffff;
            font-family: Montserrat, sans-serif;
            padding-top: 40px;
        }

        .showRegistrationsFooter {
            background-color: #f4511e;
            letter-spacing: 4px;
            border-radius: 0;
      ");
                WriteLiteral(@"      width: 100%;
            box-sizing: border-box;
            padding: 14px 16px;
            width: 100%;
            align-self: stretch;
        }

            .showRegistrationsFooter a {
                color: #fff !important;
                float: center;
                text-align: center;
                padding: 14px 16px;
                text-decoration: none;
                font-size: 17px;
                border: 1px solid #f4511e;
                display: inline-block;
                width: 100%;
                height: 100%;
                align-self: stretch;
            }

                .showRegistrationsFooter a:hover {
                    color: #f4511e !important;
                    background-color: #fff !important;
                }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e31cbe2273ae304f5266e9368cd686b2ecae292710099", async() => {
                WriteLiteral(@"
    <nav class=""navbar navbar-default navbar-fixed-top"">
        <div class=""container"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target=""#myNavbar"">
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
                <a class=""navbar-brand"" href=""ShowDashboard"">CodeX Events</a>
            </div>
            <div class=""collapse navbar-collapse"" id=""myNavbar"">
                <ul class=""nav navbar-nav navbar-right"">
                    <li><a href=""ShowProfile"">My Profile</a></li>
                    <li><a href=""PerformLogout"">Logout</a></li>
                </ul>
            </div>
        </div>
    </nav>




    <div class=""myEventsTable"">
        <h2>Event ID: ");
#nullable restore
#line 168 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
                 Write(eventId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n        <h2>Event Name: ");
#nullable restore
#line 169 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
                   Write(eventName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n");
#nullable restore
#line 170 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
         if (urs.Count() != 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <table class=\"table table-hover\">\r\n                <tr>\r\n                    <th>Request ID</th>\r\n                    <th>User ID</th>\r\n                    <th>Name</th>\r\n                    <th>Status</th>\r\n                </tr>\r\n");
#nullable restore
#line 179 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
                 foreach (var ur in urs)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 182 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
               Write(ur.RegistrationId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 183 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
               Write(ur.UserId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 184 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
               Write(ur.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 185 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
               Write(ur.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 186 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
                 if (ur.Status == "PENDING APPROVAL")
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td><a");
                BeginWriteAttribute("href", " href=\"", 5814, "\"", 5861, 2);
                WriteAttributeValue("", 5821, "ShowRequest?requestId=", 5821, 22, true);
#nullable restore
#line 188 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
WriteAttributeValue("", 5843, ur.RegistrationId, 5843, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Manage Request</a></td>\r\n");
#nullable restore
#line 189 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 190 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
                 if (ur.Status == "APPROVED")
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td><a");
                BeginWriteAttribute("href", " href=\"", 5999, "\"", 6051, 2);
                WriteAttributeValue("", 6006, "AddPreRequisites?requestId=", 6006, 27, true);
#nullable restore
#line 192 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
WriteAttributeValue("", 6033, ur.RegistrationId, 6033, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Edit Pre-requisites</a></td>\r\n");
#nullable restore
#line 193 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr>\r\n");
#nullable restore
#line 195 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </table>\r\n");
#nullable restore
#line 198 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p class=\"noEvents\">No Pending Requests.</p><br /><br />\r\n");
#nullable restore
#line 202 "D:\NET_Workspace\CodexEvents\Views\Admin\ManageRequests.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CodexEvents.Models.UserRequest>> Html { get; private set; }
    }
}
#pragma warning restore 1591
