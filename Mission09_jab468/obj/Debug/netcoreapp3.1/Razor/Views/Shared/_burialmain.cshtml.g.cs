#pragma checksum "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79fb397feaf0bd7ab6e05fe4cc8682c9d0bc3cce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__burialmain), @"mvc.1.0.view", @"/Views/Shared/_burialmain.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79fb397feaf0bd7ab6e05fe4cc8682c9d0bc3cce", @"/Views/Shared/_burialmain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"806256f2949806da62e0beb9ba094debcaf38b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__burialmain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BodyViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <div class=\"mx-auto\" style=\"max-width: 1042px;\">\r\n");
#nullable restore
#line 7 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-right\">\r\n                <button type=\"button\" class=\"btn btn-outline-primary\" data-toggle=\"modal\" data-target=\"#AddBurial\">\r\n                    Add Burial\r\n                </button>\r\n\r\n                ");
#nullable restore
#line 14 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
           Write(await Html.PartialAsync("_AddBurialPartialView", new Burialmain()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 16 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-striped table-bordered table-hover table-responsive"">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Body Depth</th>
                        <th>Head Direction</th>
                        <th>Sex</th>
                        <th>Age at Death</th>
                        <th>Hair Color</th>
                        <th>Burial ID</th>
                        <th>Options</th>
                        <!-- Add additional columns here -->
                    </tr>
                </thead>
");
#nullable restore
#line 31 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                 foreach (Burialmain b in Model.Burials)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                       Write(b.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                       Write(b.Depth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                       Write(b.Headdirection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                       Write(b.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                       Write(b.Ageatdeath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                       Write(b.Haircolor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                       Write(b.Burialid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 45 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <!-- Buttons to display when user is logged in -->\r\n                            <td>\r\n                                <button type=\"button\" class=\"btn btn-warning\" data-toggle=\"modal\" data-target=\"");
#nullable restore
#line 49 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                                                                                                           Write("#EditBurial-"+b.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-url=\"");
#nullable restore
#line 49 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                                                                                                                                            Write(Url.Action($"Edit/{b.Id}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    Edit\r\n                                </button>\r\n                                ");
#nullable restore
#line 52 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                           Write(await Html.PartialAsync("_EditBurialPartialView", b));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <button type=\"button\" class=\"btn btn-success\" data-toggle=\"modal\" data-target=\"");
#nullable restore
#line 53 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                                                                                                           Write("#burialDetails-" + b.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-url=\"");
#nullable restore
#line 53 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                                                                                                                                                 Write(Url.Action($"BurialDetails/{b.Id}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    See More\r\n                                </button>\r\n                                ");
#nullable restore
#line 56 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                           Write(await Html.PartialAsync("_BurialDetailsPartialView", b));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"");
#nullable restore
#line 57 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                                                                                                          Write("#DeleteBurial-" + b.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-url=\"");
#nullable restore
#line 57 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                                                                                                                                               Write(Url.Action($"Delete/{b.Id}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    Delete\r\n                                </button>\r\n                                ");
#nullable restore
#line 60 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                           Write(await Html.PartialAsync("_DeleteBurialPartialView", b));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 62 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <!-- Button to display when user is not logged in -->\r\n                            <td>\r\n                                <button type=\"button\" class=\"btn btn-success\" data-toggle=\"modal\" data-target=\"");
#nullable restore
#line 67 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                                                                                                           Write("#burialDetails-" + b.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-url=\"");
#nullable restore
#line 67 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                                                                                                                                                 Write(Url.Action($"BurialDetails/{b.Id}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    See More\r\n                                </button>\r\n                                ");
#nullable restore
#line 70 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                           Write(await Html.PartialAsync("_BurialDetailsPartialView", b));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79fb397feaf0bd7ab6e05fe4cc8682c9d0bc3cce14694", async() => {
                WriteLiteral("Login For More!");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 73 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 78 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_burialmain.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n\r\n        </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BodyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
