#pragma checksum "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\Pet\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4efd3c20651cc6f60eb9e76fd8c16e54a9bf4c62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pet_Details), @"mvc.1.0.view", @"/Views/Pet/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pet/Details.cshtml", typeof(AspNetCore.Views_Pet_Details))]
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
using AuthenticationandAuthorization.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\_ViewImports.cshtml"
using AuthenticationandAuthorization.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4efd3c20651cc6f60eb9e76fd8c16e54a9bf4c62", @"/Views/Pet/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8de2c07261afebee71f3ad25e780c152f3bd9d7", @"/_ViewImports.cshtml")]
    public class Views_Pet_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pet>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 29, true);
            WriteLiteral("\r\n<h2> Pet Details </h2>\r\n<p>");
            EndContext();
            BeginContext(42, 8, false);
#line 4 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\Pet\Details.cshtml"
Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(50, 8, true);
            WriteLiteral("<p>\r\n<p>");
            EndContext();
            BeginContext(59, 10, false);
#line 5 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\Pet\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(69, 8, true);
            WriteLiteral("<p>\r\n<p>");
            EndContext();
            BeginContext(78, 9, false);
#line 6 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\Pet\Details.cshtml"
Write(Model.Age);

#line default
#line hidden
            EndContext();
            BeginContext(87, 8, true);
            WriteLiteral("<p>\r\n<p>");
            EndContext();
            BeginContext(96, 11, false);
#line 7 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\Pet\Details.cshtml"
Write(Model.Color);

#line default
#line hidden
            EndContext();
            BeginContext(107, 3, true);
            WriteLiteral("<p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pet> Html { get; private set; }
    }
}
#pragma warning restore 1591
