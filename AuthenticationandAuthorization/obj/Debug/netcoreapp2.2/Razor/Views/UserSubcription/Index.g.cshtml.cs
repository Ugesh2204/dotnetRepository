#pragma checksum "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e59bc8f4ad3ab3f5e4cce39ac9a9b8c4ed8b8ba5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserSubcription_Index), @"mvc.1.0.view", @"/Views/UserSubcription/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserSubcription/Index.cshtml", typeof(AspNetCore.Views_UserSubcription_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e59bc8f4ad3ab3f5e4cce39ac9a9b8c4ed8b8ba5", @"/Views/UserSubcription/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8de2c07261afebee71f3ad25e780c152f3bd9d7", @"/_ViewImports.cshtml")]
    public class Views_UserSubcription_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SubcriptionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddSubcription", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserSubcription", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(70, 225, true);
            WriteLiteral("\r\n\r\n<div class=\"wrapper\">\r\n    <div class=\"container\">\r\n        <div class=\"inner-wrapper \">\r\n            <h1>Add Subcription</h1>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n\r\n                    ");
            EndContext();
            BeginContext(295, 1306, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e59bc8f4ad3ab3f5e4cce39ac9a9b8c4ed8b8ba54952", async() => {
                BeginContext(377, 115, true);
                WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <label >Membership Name</label>\r\n\r\n");
                EndContext();
#line 19 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\Index.cshtml"
                                 if (ViewBag.MembershipList != null)
                                {
                                    //Just bindind the membershipt type into this form
                                    

#line default
#line hidden
                BeginContext(754, 138, false);
#line 22 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\Index.cshtml"
                               Write(Html.DropDownListFor(x => x.MembershipId, ViewBag.MembershipList as SelectList, "Select Membership type", new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
#line 22 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\Index.cshtml"
                                                                                                                                                                               
                                }

#line default
#line hidden
                BeginContext(960, 162, true);
                WriteLiteral("                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label>Price</label>\r\n\r\n                            ");
                EndContext();
                BeginContext(1123, 93, false);
#line 29 "C:\Users\Ugesh\Desktop\dotcore2020\AuthenticationandAuthorization\AuthenticationandAuthorization\Views\UserSubcription\Index.cshtml"
                       Write(Html.DropDownListFor(x => x.PriceId, new SelectList(""), "", new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1216, 378, true);
                WriteLiteral(@"
                        </div>

                        <div class=""form-group"">
                            <label >Joining Date</label>
                           <input type=""date"" id=""Date"" name=""Date"" class=""form-control"">
                        </div>


                        <button type=""submit"" class=""btn btn-primary"">Submit</button>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1601, 809, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {
        //when i select the memshipid  i want to display price
        $(""#MembershipId"").change(function () {
            var membershipId = $(this).val();
            //debugger
            $.ajax({
                type: ""post"",
                url: ""/UserSubcription/GetMPriceList?Mid="" + membershipId,
                contentType: ""html"",
                success: function (response) {
                   // debugger
                    //Once the user select the member type change the state of price
                    $(""#PriceId"").empty();
                    $(""#PriceId"").append(response);
                }
            })
        })
    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SubcriptionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
