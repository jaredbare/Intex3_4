#pragma checksum "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\ProjectSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fdad83e00b5e2582977cb9d5cf57d59b471319a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProjectSummary), @"mvc.1.0.view", @"/Views/Shared/ProjectSummary.cshtml")]
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
#line 1 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\_ViewImports.cshtml"
using Intex3_4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\_ViewImports.cshtml"
using Intex3_4.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\_ViewImports.cshtml"
using Intex3_4.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\_ViewImports.cshtml"
using Intex3_4.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fdad83e00b5e2582977cb9d5cf57d59b471319a", @"/Views/Shared/ProjectSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"806256f2949806da62e0beb9ba094debcaf38b02", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_ProjectSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Burialmain>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card card-outline-primary m-1 p-1\">\r\n    <div class=\"bg-faded p-2\">\r\n        <h3 class=\"bg-light\">\r\n            ");
#nullable restore
#line 8 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\ProjectSummary.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("        </h3>\r\n");
            WriteLiteral("    <ul>\r\n        <li>Textile Color: ");
#nullable restore
#line 15 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\ProjectSummary.cshtml"
                      Write(Model.Squarenorthsouth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Textile Structure: ");
#nullable restore
#line 16 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\ProjectSummary.cshtml"
                          Write(Model.Headdirection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Sex: ");
#nullable restore
#line 17 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\ProjectSummary.cshtml"
            Write(Model.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Burial Depth: ");
#nullable restore
#line 18 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\ProjectSummary.cshtml"
                     Write(Model.Depth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Estimate Stature: ");
#nullable restore
#line 19 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\ProjectSummary.cshtml"
                         Write(Model.Adultsubadult);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Age at Death: ");
#nullable restore
#line 20 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\ProjectSummary.cshtml"
                     Write(Model.Facebundles);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Head Direction: $");
#nullable restore
#line 21 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\ProjectSummary.cshtml"
                        Write(Model.Preservation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Textile Function: $");
#nullable restore
#line 22 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\ProjectSummary.cshtml"
                          Write(Model.Fieldbookpage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Hair Color: $");
#nullable restore
#line 23 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\ProjectSummary.cshtml"
                    Write(Model.Hair);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fdad83e00b5e2582977cb9d5cf57d59b471319a7890", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5fdad83e00b5e2582977cb9d5cf57d59b471319a8156", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 27 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\ProjectSummary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type =\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 1038, "\"", 1093, 1);
#nullable restore
#line 28 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\ProjectSummary.cshtml"
WriteAttributeValue("", 1046, ViewContext.HttpContext.Request.PathAndQuery(), 1046, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <span class=\"card-text\" style=\"float:right\">\r\n            <button type=\"submit\" class=\"btn btn-success btn-sm float-end\">More Info</button>\r\n        </span>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Burialmain> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
