#pragma checksum "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d4a2a9c6938c8517d394503d5e73bb3c5c89dc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BurialDetailsPartialView), @"mvc.1.0.view", @"/Views/Shared/_BurialDetailsPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d4a2a9c6938c8517d394503d5e73bb3c5c89dc6", @"/Views/Shared/_BurialDetailsPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"806256f2949806da62e0beb9ba094debcaf38b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BurialDetailsPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Burialmain>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!-- Modal -->\r\n<div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 60, "\"", 88, 2);
            WriteAttributeValue("", 65, "burialDetails-", 65, 14, true);
#nullable restore
#line 4 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
WriteAttributeValue("", 79, Model.Id, 79, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""burialDetailsLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"" style=""min-width: 1000px"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""burialDetailsLabel"">Burial Details</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <h5 class=""pb-4"">Burial for ");
#nullable restore
#line 14 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                                       Write(Model.Squarenorthsouth);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                                                               Write(Model.Northsouth);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                                                                                 Write(Model.Squareeastwest);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                                                                                                       Write(Model.Eastwest);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                                                                                                                       Write(Model.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                                                                                                                                   Write(Model.Burialnumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                <div class=\"container\">\r\n\r\n                    <div class=\"row\">\r\n                        <div class=\"col\">\r\n                            <p>");
#nullable restore
#line 20 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                          Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>

                    <table class=""table table-light bg-light table-custom"">
                        <thead>
                            <tr>
                                <th scope=""col"">Age Range</th>
                                <th scope=""col"">Age at Death</th>
                                <th scope=""col"">Burial Id</th>
                                <th scope=""col"">Burial Materials</th>
                                <th scope=""col"">Expert Initials</th>
                                <th scope=""col"">Cluster</th>
                                <th scope=""col"">Date of Excavation</th>
                                <th scope=""col"">Depth</th>
                                <th scope=""col"">Excavation Reorder</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>");
#nullable restore
#line 40 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Adultsubadult);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Ageatdeath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 42 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Burialid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 43 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Burialmaterials);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 44 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Dataexpertinitials);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Clusternumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Dateofexcavation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 47 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Depth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 48 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Excavationrecorder);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                    </table>
                    <table class=""table table-light bg-light table-custom"">
                        <thead>
                            <tr>
                                <th scope=""col"">Face Bundles</th>
                                <th scope=""col"">Fieldbook Excavation Year</th>
                                <th scope=""col"">Fieldbook Page</th>
                                <th scope=""col"">Goods</th>
                                <th scope=""col"">Hair</th>
                                <th scope=""col"">Head Direction</th>
                                <th scope=""col"">Hair Color</th>
                                <th scope=""col"">Length</th>
                                <th scope=""col"">Photos</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>");
#nullable restore
#line 68 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Facebundles);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 69 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Fieldbookexcavationyear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 70 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Fieldbookpage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 71 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Goods);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 72 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Hair);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 73 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Headdirection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 74 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Haircolor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 75 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 76 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Photos);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                    </table>
                    <table class=""table table-light bg-light table-custom"">
                        <thead>
                            <tr>
                                <th scope=""col"">Preservation</th>
                                <th scope=""col"">Samples Collected</th>
                                <th scope=""col"">Sex</th>
                                <th scope=""col"">Shaft Number</th>
                                <th scope=""col"">South to Feet</th>
                                <th scope=""col"">South to Head</th>
                                <th scope=""col"">West to Feet</th>
                                <th scope=""col"">West to Head</th>
                                <th scope=""col"">Wrapping</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>");
#nullable restore
#line 96 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Preservation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 97 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Samplescollected);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 98 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 99 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Shaftnumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 100 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Southtofeet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 101 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Southtohead);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 102 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Westtofeet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 103 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Westtohead);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 104 "C:\Users\jared\source\repos\Mission09_jab468\Mission09_jab468\Views\Shared\_BurialDetailsPartialView.cshtml"
                               Write(Model.Wrapping);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Burialmain> Html { get; private set; }
    }
}
#pragma warning restore 1591