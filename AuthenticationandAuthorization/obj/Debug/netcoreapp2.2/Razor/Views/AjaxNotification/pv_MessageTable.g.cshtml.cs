#pragma checksum "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\AjaxNotification\pv_MessageTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b800cc3d51fc8eee4e0b31d88b67a4756b0d0ce1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AjaxNotification_pv_MessageTable), @"mvc.1.0.view", @"/Views/AjaxNotification/pv_MessageTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AjaxNotification/pv_MessageTable.cshtml", typeof(AspNetCore.Views_AjaxNotification_pv_MessageTable))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b800cc3d51fc8eee4e0b31d88b67a4756b0d0ce1", @"/Views/AjaxNotification/pv_MessageTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e80801615f7db83c5d0fd5da94c5c41cac60d09", @"/_ViewImports.cshtml")]
    public class Views_AjaxNotification_pv_MessageTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 463, true);
            WriteLiteral(@"

    <h1>MessageTable</h1>
    <div class=""container"">
        <table border=""1"">
            <thead>
                <tr>
                    <td>Name</td>
                    <td>Message Title</td>
                    <td>Message Body</td>
                    <td>To</td>
                    <td>Status</td>
                    <td>url</td>
                    <td>Actions</td>
                </tr>
            </thead>

            <tbody>
");
            EndContext();
#line 20 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\AjaxNotification\pv_MessageTable.cshtml"
                 foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(546, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(593, 17, false);
#line 23 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\AjaxNotification\pv_MessageTable.cshtml"
                   Write(item.FromUserName);

#line default
#line hidden
            EndContext();
            BeginContext(610, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(642, 18, false);
#line 24 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\AjaxNotification\pv_MessageTable.cshtml"
                   Write(item.MessageHeader);

#line default
#line hidden
            EndContext();
            BeginContext(660, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(692, 16, false);
#line 25 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\AjaxNotification\pv_MessageTable.cshtml"
                   Write(item.MessageBody);

#line default
#line hidden
            EndContext();
            BeginContext(708, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(740, 15, false);
#line 26 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\AjaxNotification\pv_MessageTable.cshtml"
                   Write(item.ToUserName);

#line default
#line hidden
            EndContext();
            BeginContext(755, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(787, 19, false);
#line 27 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\AjaxNotification\pv_MessageTable.cshtml"
                   Write(item.Comment_status);

#line default
#line hidden
            EndContext();
            BeginContext(806, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(838, 8, false);
#line 28 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\AjaxNotification\pv_MessageTable.cshtml"
                   Write(item.Url);

#line default
#line hidden
            EndContext();
            BeginContext(846, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(903, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b800cc3d51fc8eee4e0b31d88b67a4756b0d0ce18476", async() => {
                BeginContext(940, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(948, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(976, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b800cc3d51fc8eee4e0b31d88b67a4756b0d0ce110380", async() => {
                BeginContext(998, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1014, 54, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 35 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\AjaxNotification\pv_MessageTable.cshtml"
            }

#line default
#line hidden
            BeginContext(1083, 54, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
