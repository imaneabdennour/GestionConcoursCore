#pragma checksum "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Epreuve.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49956fd862f9f559e99293750a812fbe63481dcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Epreuve), @"mvc.1.0.view", @"/Views/Home/Epreuve.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Epreuve.cshtml", typeof(AspNetCore.Views_Home_Epreuve))]
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
#line 1 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore;

#line default
#line hidden
#line 2 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49956fd862f9f559e99293750a812fbe63481dcd", @"/Views/Home/Epreuve.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d40043f5e6a50be129fc5644635f682c8f7c25f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Epreuve : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GestionConcoursCore.Models.Epreuves>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Epreuve.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
            BeginContext(153, 1121, true);
            WriteLiteral(@"

<div class=""page-content-wrapper-inner"" style=""font-family:'Arial Rounded MT';"">
    <div class=""content-viewport"">
        <div class=""container-fluid"">
            <!-- USER DATA-->
            <div class=""user-data m-b-40"">
                <div class=""row"">

                    <div class=""col-md-8 offset-md-2 mb-5 text-center"" style=""min-height:500px"">

                        <h2 class=""title-3 mb-4 mt-4 text-center text-warning font-weight-bold"">
                            <i class=""mr-4 mdi mdi-file-multiple link-icon""></i>
                            Les Anciens Epreuves
                        </h2>

                        <hr class=""col-md-8 offset-md-2 mb-5"" />


                        <h6 class=""font-weight-bold mb-5"">Vous trouverez ici tous les anciens épreuves et vous pouvez les télécharger </h6>
                        <h6 class=""font-weight-bold mb-5"">
                            Bonne Révision !
                            <i class=""mdi mdi mdi-heart link-icon text-");
            WriteLiteral("warning\"></i>\r\n                        </h6>\r\n\r\n                        <div class=\"col-md-12\">\r\n");
            EndContext();
#line 32 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Epreuve.cshtml"
                             if (TempData["download"] != null)
                            {

#line default
#line hidden
            BeginContext(1369, 108, true);
            WriteLiteral("                                <div class=\"alert alert-danger\">\r\n                                    <span>");
            EndContext();
            BeginContext(1478, 20, false);
#line 35 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Epreuve.cshtml"
                                     Write(TempData["download"]);

#line default
#line hidden
            EndContext();
            BeginContext(1498, 81, true);
            WriteLiteral("</span>\r\n                                </div>                                \r\n");
            EndContext();
#line 37 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Epreuve.cshtml"
                            }

#line default
#line hidden
            BeginContext(1610, 570, true);
            WriteLiteral(@"                        </div>

                        <table class=""table table-success table-bordered "">

                            <thead class=""bg-light"">
                                <tr>
                                    <th><h6 class=""text-primary"">Année</h6></th>
                                    <th><h6 class=""text-primary"">Matiere</h6></th>
                                    <th><h6 class=""text-primary"">Download</h6></th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 50 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Epreuve.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
            BeginContext(2277, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(2364, 10, false);
#line 53 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Epreuve.cshtml"
                                       Write(item.Annee);

#line default
#line hidden
            EndContext();
            BeginContext(2374, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2426, 12, false);
#line 54 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Epreuve.cshtml"
                                       Write(item.Matiere);

#line default
#line hidden
            EndContext();
            BeginContext(2438, 119, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <a class=\"text-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2557, "\"", 2595, 2);
            WriteAttributeValue("", 2564, "../../epreuves/", 2564, 15, true);
#line 56 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Epreuve.cshtml"
WriteAttributeValue("", 2579, item.NomFichier, 2579, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2596, 314, true);
            WriteLiteral(@" target=""_blank"">
                                                <i class=""mdi mdi-download link-icon mr-3""></i>
                                                Download
                                            </a>
                                        </td>
                                    </tr>
");
            EndContext();
#line 62 "C:\Users\Tarik Ouhamou\source\repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Epreuve.cshtml"
                                }

#line default
#line hidden
            BeginContext(2945, 210, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                        <br /><br />\r\n                    </div>\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GestionConcoursCore.Models.Epreuves>> Html { get; private set; }
    }
}
#pragma warning restore 1591
