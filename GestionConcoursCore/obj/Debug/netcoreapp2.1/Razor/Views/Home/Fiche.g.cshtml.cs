#pragma checksum "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Fiche.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8f1e6036bceed85d669439db25354533fa69c4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Fiche), @"mvc.1.0.view", @"/Views/Home/Fiche.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Fiche.cshtml", typeof(AspNetCore.Views_Home_Fiche))]
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
#line 1 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore;

#line default
#line hidden
#line 2 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore.Models;

#line default
#line hidden
#line 49 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Fiche.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f1e6036bceed85d669439db25354533fa69c4f", @"/Views/Home/Fiche.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d40043f5e6a50be129fc5644635f682c8f7c25f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Fiche : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/ENSA.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-img img-lg rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 50%; width:250px; height:150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("profile image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Fiche.cshtml"
     
     Layout = "~/Views/Shared/_UserLayout.cshtml";
    ViewData["Title"] = "Fiche Convocation";
    
    

#line default
#line hidden
            BeginContext(120, 927, true);
            WriteLiteral(@"

<style>
    .myBody {
        font-family: 'Arial Rounded MT';
    }
    td {
        font-size: 20px;
    }

    th {
        font-size: 18px;
        color: white;
    }

    .myborder {
        padding-top: 10px;
        margin: 0 auto;
    }

    img {
        padding: unset;
    }

    h1 {
        margin: 10px 10px 10px 10px;
        text-align: center;
    }
</style>

<div class=""page-content-wrapper-inner myBody"" style=""font-family:'Arial Rounded MT';"">
    <div class=""content-viewport"">
        <div class=""container-fluid"">
            <!-- USER DATA-->
            <div class=""user-data m-b-40"">

                <h2 class=""title-3 mb-4 mt-4 pb-4 text-center text-warning font-weight-bold"">
                    <i class=""mdi mdi-file-pdf link-icon mr-4""></i>
                    Fiche de Convocation du Concours
                </h2>

                               
");
            EndContext();
            BeginContext(1097, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1163, 309, true);
            WriteLiteral(@"                    <div class=""row myborder"">

                        <div class=""col-lg-6 col-md-8 col-xs-8 col-sm-8"">
                            <table class=""table table table-bordered table-primary"">

                                <tr>
                                    <th class=""bg-dark"">  ");
            EndContext();
            BeginContext(1472, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "38e10b9fba304363b4a232d6c8124053", async() => {
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
            BeginContext(1515, 219, true);
            WriteLiteral(" </th>\r\n                                    <th class=\"bg-dark\"> Ensa de Safi <br /> Concours d\'accès en 3eme année </th>\r\n                                    <th rowspan=\"4\">\r\n\r\n                                        ");
            EndContext();
            BeginContext(1734, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cc803354f9ca4a039278b4a1e3250ba2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 1851, "~/candidatImages/", 1851, 17, true);
#line 61 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Fiche.cshtml"
AddHtmlAttributeValue("", 1868, HttpContextAccessor.HttpContext.Session.GetString("photo"), 1868, 59, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1949, 266, true);
            WriteLiteral(@"
                                    </th>
                                </tr>

                                <tr>
                                    <th class=""bg-dark"">  Matricule: </th>
                                    <td style=""font-size: 18px;""> ");
            EndContext();
            BeginContext(2216, 9, false);
#line 67 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Fiche.cshtml"
                                                             Write(Model.Cne);

#line default
#line hidden
            EndContext();
            BeginContext(2225, 219, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <th class=\"bg-dark\"> CIN: </th>\r\n                                    <td style=\"font-size: 18px;\"> ");
            EndContext();
            BeginContext(2445, 9, false);
#line 71 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Fiche.cshtml"
                                                             Write(Model.Cin);

#line default
#line hidden
            EndContext();
            BeginContext(2454, 225, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <th class=\"bg-dark\"> N°dossier: </th>\r\n                                    <td style=\"font-size: 18px;\"> ");
            EndContext();
            BeginContext(2680, 17, false);
#line 75 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Fiche.cshtml"
                                                             Write(Model.Num_dossier);

#line default
#line hidden
            EndContext();
            BeginContext(2697, 798, true);
            WriteLiteral(@"</td>
                                </tr>
                            </table>

                        </div>





                    </div>

                    <br />

                    <table class=""table table-bordered table-primary"">
                        <tr class=""bg-dark"">
                            <th>Nom</th>
                            <th>Prenom</th>
                            <th>Filiere</th>
                            <th>Diplome</th>
                            <th>CNE</th>
                            <th>Ville Dipl</th>
                            <th>Convoqué</th>
                            <th>Date inscription</th>
                        </tr>

                        <tr>
                            <td style=""font-size: 18px;"">");
            EndContext();
            BeginContext(3496, 9, false);
#line 102 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Fiche.cshtml"
                                                    Write(Model.Nom);

#line default
#line hidden
            EndContext();
            BeginContext(3505, 64, true);
            WriteLiteral("</td>\r\n                            <td style=\"font-size: 18px;\">");
            EndContext();
            BeginContext(3570, 12, false);
#line 103 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Fiche.cshtml"
                                                    Write(Model.Prenom);

#line default
#line hidden
            EndContext();
            BeginContext(3582, 64, true);
            WriteLiteral("</td>\r\n                            <td style=\"font-size: 18px;\">");
            EndContext();
            BeginContext(3647, 17, false);
#line 104 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Fiche.cshtml"
                                                    Write(Model.Filiere.Nom);

#line default
#line hidden
            EndContext();
            BeginContext(3664, 64, true);
            WriteLiteral("</td>\r\n                            <td style=\"font-size: 18px;\">");
            EndContext();
            BeginContext(3729, 18, false);
#line 105 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Fiche.cshtml"
                                                    Write(Model.Diplome.Type);

#line default
#line hidden
            EndContext();
            BeginContext(3747, 64, true);
            WriteLiteral("</td>\r\n                            <td style=\"font-size: 18px;\">");
            EndContext();
            BeginContext(3812, 9, false);
#line 106 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Fiche.cshtml"
                                                    Write(Model.Cne);

#line default
#line hidden
            EndContext();
            BeginContext(3821, 64, true);
            WriteLiteral("</td>\r\n                            <td style=\"font-size: 18px;\">");
            EndContext();
            BeginContext(3886, 28, false);
#line 107 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Fiche.cshtml"
                                                    Write(Model.Diplome.VilleObtention);

#line default
#line hidden
            EndContext();
            BeginContext(3914, 64, true);
            WriteLiteral("</td>\r\n                            <td style=\"font-size: 18px;\">");
            EndContext();
            BeginContext(3979, 14, false);
#line 108 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Fiche.cshtml"
                                                    Write(Model.Convoque);

#line default
#line hidden
            EndContext();
            BeginContext(3993, 69, true);
            WriteLiteral(" </td>\r\n\r\n\r\n                            <td style=\"font-size: 18px;\">");
            EndContext();
            BeginContext(4063, 21, false);
#line 111 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Fiche.cshtml"
                                                    Write(Model.DateInscription);

#line default
#line hidden
            EndContext();
            BeginContext(4084, 148, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </table>\r\n\r\n                    <div class=\"my-5 text-center\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4232, "\"", 4273, 2);
            WriteAttributeValue("", 4239, "ImprimerConvocation?cne=", 4239, 24, true);
#line 116 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Home\Fiche.cshtml"
WriteAttributeValue("", 4263, Model.Cne, 4263, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4274, 295, true);
            WriteLiteral(@" target=""_blank"">
                            <input class=""btn btn-success btn-rounded px-5 py-4 "" style=""font-size:medium;"" type=""text"" value="" Imprimer la fiche "" />
                        </a>
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
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
