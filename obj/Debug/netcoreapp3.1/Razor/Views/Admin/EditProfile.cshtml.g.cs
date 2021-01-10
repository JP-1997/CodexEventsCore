#pragma checksum "D:\NET_Workspace\CodexEvents\Views\Admin\EditProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83fa20e3662eed9adf141f0dda29f9b9388acc59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditProfile), @"mvc.1.0.view", @"/Views/Admin/EditProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83fa20e3662eed9adf141f0dda29f9b9388acc59", @"/Views/Admin/EditProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce086ff6333d3f2cf17b96db242419ceb7d9edb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CodexEvents.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editProfile_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\NET_Workspace\CodexEvents\Views\Admin\EditProfile.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\NET_Workspace\CodexEvents\Views\Admin\EditProfile.cshtml"
  
    User user = ViewBag.User;
    DateTime dob = user.DateOfBirth;
    string dobStr = dob.ToString("yyyy'-'MM'-'dd");

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83fa20e3662eed9adf141f0dda29f9b9388acc595539", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <link href=""https://fonts.googleapis.com/css?family=Montserrat"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Lato"" rel=""stylesheet"" type=""text/css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-validator/0.4.5/js/bootstrapvalidator.min.js""></script>
    <meta charset=""ISO-8859-1"">
    <style>
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
        }");
                WriteLiteral(@"

            .navbar li a, .navbar .navbar-brand {
                color: #fff !important;
            }

        .navbar-nav li a:hover, .navbar-nav li.active a {
            color: #f4511e !important;
            background-color: #fff !important;
        }

        .navbar-default .navbar-toggle {
            border-color: transparent;
            color: #fff !important;
        }

        .profileheading {
            padding-top: 60px;
            text-align: center;
        }

        .neomorphism {
            width: 85%;
            margin: 0 auto;
            border-radius: 16px;
            background: #ffffff;
            box-shadow: 10px 10px 21px #8a8a8a, -10px -10px 21px #ffffff;
            font-family: Montserrat, sans-serif;
            padding: 30px;
            padding-top: 50px;
        }
    </style>
    <script>
        $(document).ready(function () {
            $('#editProfile_form').bootstrapValidator({
                // To use feedback icons, ensu");
                WriteLiteral(@"re that you use Bootstrap v3.1.0 or later
                feedbackIcons: {
                    valid: 'glyphicon glyphicon-ok',
                    invalid: 'glyphicon glyphicon-remove',
                    validating: 'glyphicon glyphicon-refresh'
                },
                fields: {
                    firstName: {
                        validators: {
                            stringLength: {
                                min: 2,
                            },
                            notEmpty: {
                                message: 'Please enter your First Name'
                            }
                        }
                    },
                    lastName: {
                        validators: {
                            stringLength: {
                                min: 2,
                            },
                            notEmpty: {
                                message: 'Please enter your Last Name'
                            }
  ");
                WriteLiteral(@"                      }
                    },
                    date: {
                        validators: {
                            notEmpty: {
                                message: 'Please enter your Date of Birth'
                            }
                        }
                    },
                    country: {
                        validators: {
                            notEmpty: {
                                message: 'Please enter your Country'
                            }
                        }
                    },
                    password: {
                        validators: {
                            stringLength: {
                                min: 7,
                            },
                            notEmpty: {
                                message: 'Please enter your Password'
                            }
                        }
                    },
                    confirmPassword: {
                    ");
                WriteLiteral(@"    validators: {
                            stringLength: {
                                min: 7,
                            },
                            notEmpty: {
                                message: 'Please confirm your Password'
                            },
                            identical: {
                                field: 'password',
                                message: 'The password and its confirm are not the same'
                            }
                        }
                    },
                    email: {
                        validators: {
                            notEmpty: {
                                message: 'Please enter your Email Address'
                            },
                            emailAddress: {
                                message: 'Please enter a valid Email Address'
                            }
                        }
                    },
                    phoneNumber: {
               ");
                WriteLiteral(@"         validators: {
                            stringLength: {
                                min: 10,
                                max: 15,
                                notEmpty: {
                                    message: 'Please enter your Contact No.'
                                }
                            }
                        },
                    }
                }
            })
                .on('success.form.bv', function (e) {
                    $('#success_message').slideDown({ opacity: ""show"" }, ""slow"") // Do something ...
                    $('#editProfile_form').data('bootstrapValidator').resetForm();
                    // Prevent form submission
                    e.preventDefault();
                    // Get the form instance
                    var $form = $(e.target);
                    // Get the BootstrapValidator instance
                    var bv = $form.data('bootstrapValidator');
                    // Use Ajax to submit form dat");
                WriteLiteral(@"a
                    $.post($form.attr('action'), $form.serialize(), function (result) {
                        console.log(result);
                    }, 'json');
                });
        });
    </script>
    <title>Edit User Details</title>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83fa20e3662eed9adf141f0dda29f9b9388acc5913148", async() => {
                WriteLiteral(@"

    <nav class=""navbar navbar-default navbar-fixed-top"">
        <div class=""navbar-header"">
            <a class=""navbar-brand"" href=""showDashboard"">CodeX Events</a>
        </div>
    </nav>
    <h2 class=""profileheading"">Edit Admin Details</h2><br />

    <div class=""neomorphism"">
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83fa20e3662eed9adf141f0dda29f9b9388acc5913721", async() => {
                    WriteLiteral(@"

            <div class=""form-group"">
                <label class=""col-md-4 control-label"">User ID</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
                        <input class=""form-control"" name=""id""");
                    BeginWriteAttribute("value", " value=\"", 7443, "\"", 7459, 1);
#nullable restore
#line 189 "D:\NET_Workspace\CodexEvents\Views\Admin\EditProfile.cshtml"
WriteAttributeValue("", 7451, user.Id, 7451, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" READONLY type=""text"" />
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <label class=""col-md-4 control-label"">First Name</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
                        <input class=""form-control"" name=""firstName""");
                    BeginWriteAttribute("value", " value=\"", 7952, "\"", 7975, 1);
#nullable restore
#line 199 "D:\NET_Workspace\CodexEvents\Views\Admin\EditProfile.cshtml"
WriteAttributeValue("", 7960, user.FirstName, 7960, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" type=""text"" />
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <label class=""col-md-4 control-label"">Last Name</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
                        <input class=""form-control"" name=""lastName""");
                    BeginWriteAttribute("value", " value=\"", 8457, "\"", 8479, 1);
#nullable restore
#line 209 "D:\NET_Workspace\CodexEvents\Views\Admin\EditProfile.cshtml"
WriteAttributeValue("", 8465, user.LastName, 8465, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" type=""text"" />
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <label class=""col-md-4 control-label"">Date of birth</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-calendar""></i></span>
                        <input type=""date"" name=""dateOfBirth""");
                    BeginWriteAttribute("value", " value=\"", 8963, "\"", 8978, 1);
#nullable restore
#line 219 "D:\NET_Workspace\CodexEvents\Views\Admin\EditProfile.cshtml"
WriteAttributeValue("", 8971, dobStr, 8971, 7, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" class=""form-control"" />
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <label class=""col-md-4 control-label"">Gender</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
                        <label class=""radio-inline""><input type=""radio"" name=""gender"" value=""male"" ");
#nullable restore
#line 229 "D:\NET_Workspace\CodexEvents\Views\Admin\EditProfile.cshtml"
                                                                                               Write(user.Gender == "male" ? "checked" : "");

#line default
#line hidden
#nullable disable
                    WriteLiteral(" />Male</label>\r\n                        <label class=\"radio-inline\"><input type=\"radio\" name=\"gender\" value=\"female\" ");
#nullable restore
#line 230 "D:\NET_Workspace\CodexEvents\Views\Admin\EditProfile.cshtml"
                                                                                                 Write(user.Gender == "female" ? "checked" : "");

#line default
#line hidden
#nullable disable
                    WriteLiteral(" />Female</label>\r\n                        <label class=\"radio-inline\"><input type=\"radio\" name=\"gender\" value=\"not_specified\" ");
#nullable restore
#line 231 "D:\NET_Workspace\CodexEvents\Views\Admin\EditProfile.cshtml"
                                                                                                        Write(user.Gender == "not_specified" ? "checked" : "");

#line default
#line hidden
#nullable disable
                    WriteLiteral(@" />Not Specified</label>
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <label class=""col-md-4 control-label"">Country</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-globe""></i></span>
                        <input type=""text"" name=""country""");
                    BeginWriteAttribute("value", " value=\"", 10356, "\"", 10377, 1);
#nullable restore
#line 241 "D:\NET_Workspace\CodexEvents\Views\Admin\EditProfile.cshtml"
WriteAttributeValue("", 10364, user.Country, 10364, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" class=""form-control"" />
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <label class=""col-md-4 control-label"">Phone Number</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-earphone""></i></span>
                        <input type=""text"" name=""phoneNumber""");
                    BeginWriteAttribute("value", " value=\"", 10869, "\"", 10894, 1);
#nullable restore
#line 251 "D:\NET_Workspace\CodexEvents\Views\Admin\EditProfile.cshtml"
WriteAttributeValue("", 10877, user.PhoneNumber, 10877, 17, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" class=""form-control"" />
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <label class=""col-md-4 control-label"">E-Mail</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-envelope""></i></span>
                        <input name=""email""");
                    BeginWriteAttribute("value", " value=\"", 11362, "\"", 11381, 1);
#nullable restore
#line 261 "D:\NET_Workspace\CodexEvents\Views\Admin\EditProfile.cshtml"
WriteAttributeValue("", 11370, user.Email, 11370, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" READONLY class=""form-control"" type=""email"">
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <label class=""col-md-4 control-label""></label>
                <div class=""col-md-4"">
                    <br>
                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<button type=""submit"" class=""btn btn-warning"">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbspSAVE <span class=""glyphicon glyphicon-floppy-save""></span>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</button>
                </div>
            </div>

        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CodexEvents.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
