#pragma checksum "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\Chat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "092a990c69533506c4b3a06d206727f8f465d3f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Index), @"mvc.1.0.view", @"/Views/Chat/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chat/Index.cshtml", typeof(AspNetCore.Views_Chat_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"092a990c69533506c4b3a06d206727f8f465d3f6", @"/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e80801615f7db83c5d0fd5da94c5c41cac60d09", @"/_ViewImports.cshtml")]
    public class Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/chat.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\Chat\Index.cshtml"
  
    ViewData["Title"] = "Chat Room";

#line default
#line hidden
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(49, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "092a990c69533506c4b3a06d206727f8f465d3f64963", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(96, 404, true);
            WriteLiteral(@"



<div class=""container"">



    <div class=""text-center"">
        <h1 class=""display-4"">Chat Room</h1>
    </div>

    <div class=""row rounded-lg overflow-hidden shadow"">
        <div class=""col-5 px-0"">
            <div class=""bg-white"">
                <div class=""bg-gray px-4 py-2 bg-light"">
                    <p class=""h5 mb-0 py-1"">Connections</p>
                </div>


");
            EndContext();
            BeginContext(547, 217, true);
            WriteLiteral("                <div class=\"messages-box\">\r\n                    <div id=\"chatUsers\" class=\"list-group rounded-0\"></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-7 px-0\">\r\n");
            EndContext();
            BeginContext(810, 93, true);
            WriteLiteral("            <div id=\"chatRoom\" class=\"px-4 py-5 chat-box bg-white\">\r\n\r\n            </div>\r\n\r\n");
            EndContext();
            BeginContext(939, 504, true);
            WriteLiteral(@"            <div class=""input-group position-absolute"">
                <input id=""messageInput"" type=""text"" placeholder=""Typea a message"" aria-describedby=""button-addon2"" class=""form-control rounded-0 border-0 py-4 bg-light"" />
                <div class=""input-group-append"">
                    <button id=""sendButton"" type=""button"" class=""btn btn-link""><i class=""fa fa-paper-plane""></i></button>
                </div>
            </div>

        </div>


    </div>


</div>





");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
