#pragma checksum "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\UserSubcriptionDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c25b6566a4bcc1ff207bf022bc1fa2ca095f70f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserSubcription_UserSubcriptionDetails), @"mvc.1.0.view", @"/Views/UserSubcription/UserSubcriptionDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserSubcription/UserSubcriptionDetails.cshtml", typeof(AspNetCore.Views_UserSubcription_UserSubcriptionDetails))]
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
#line 2 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\_ViewImports.cshtml"
using AuthenticationandAuthorization;

#line default
#line hidden
#line 4 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\_ViewImports.cshtml"
using AuthenticationandAuthorization.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\_ViewImports.cshtml"
using AuthenticationandAuthorization.Models;

#line default
#line hidden
#line 6 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\_ViewImports.cshtml"
using AuthenticationandAuthorization.Services;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c25b6566a4bcc1ff207bf022bc1fa2ca095f70f", @"/Views/UserSubcription/UserSubcriptionDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e80801615f7db83c5d0fd5da94c5c41cac60d09", @"/_ViewImports.cshtml")]
    public class Views_UserSubcription_UserSubcriptionDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Subcription>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\UserSubcriptionDetails.cshtml"
  
    ViewData["Title"] = "UserSubcriptionDetails";

#line default
#line hidden
            BeginContext(84, 252, true);
            WriteLiteral("\r\n<h1>UserSubcriptionDetails</h1>\r\n\r\n<table border=\"1\">\r\n    <tr>\r\n       <td>Memberhip</td>\r\n        <td>Payment</td>\r\n        <td>Start Date</td>\r\n        <td>Expires On</td>\r\n        <td>Status</td>\r\n        <td>Action</td>\r\n    </tr>\r\n    <tbody>\r\n");
            EndContext();
#line 18 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\UserSubcriptionDetails.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(385, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(424, 19, false);
#line 21 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\UserSubcriptionDetails.cshtml"
               Write(item.MembershipName);

#line default
#line hidden
            EndContext();
            BeginContext(443, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(471, 11, false);
#line 22 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\UserSubcriptionDetails.cshtml"
               Write(item.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(482, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(510, 34, false);
#line 23 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\UserSubcriptionDetails.cshtml"
               Write(item.StartDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(544, 29, true);
            WriteLiteral("</td>\r\n                <td>\r\n");
            EndContext();
#line 25 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\UserSubcriptionDetails.cshtml"
                     if(item.ExpireDate == null)
                    {

#line default
#line hidden
            BeginContext(646, 30, true);
            WriteLiteral("                    <p>-</p>\r\n");
            EndContext();
#line 28 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\UserSubcriptionDetails.cshtml"
                    }
                    else
                    {
                         

#line default
#line hidden
            BeginContext(774, 15, false);
#line 31 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\UserSubcriptionDetails.cshtml"
                    Write(item.ExpireDate);

#line default
#line hidden
            EndContext();
#line 31 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\UserSubcriptionDetails.cshtml"
                                             
                    }

#line default
#line hidden
            BeginContext(818, 71, true);
            WriteLiteral("                    \r\n\r\n                </td>\r\n\r\n                <td>\r\n");
            EndContext();
#line 38 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\UserSubcriptionDetails.cshtml"
                     if (item.Status == false)
                    {

#line default
#line hidden
            BeginContext(960, 40, true);
            WriteLiteral("                        <p>Pending</p>\r\n");
            EndContext();
#line 41 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\UserSubcriptionDetails.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1072, 50, true);
            WriteLiteral("                        <p>Payment Completed</p>\r\n");
            EndContext();
#line 45 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\UserSubcriptionDetails.cshtml"
                    }

#line default
#line hidden
            BeginContext(1145, 79, true);
            WriteLiteral("                </td>\r\n\r\n                <td>Action</td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 51 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\UserSubcriptionDetails.cshtml"
        }

#line default
#line hidden
            BeginContext(1235, 26, true);
            WriteLiteral("        </tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Subcription>> Html { get; private set; }
    }
}
#pragma warning restore 1591
