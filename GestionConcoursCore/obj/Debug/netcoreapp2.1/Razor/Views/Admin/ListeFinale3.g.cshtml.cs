#pragma checksum "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Admin\ListeFinale3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40e20f7f46fc59fcde1acd7c4bafcad0095d15aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListeFinale3), @"mvc.1.0.view", @"/Views/Admin/ListeFinale3.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ListeFinale3.cshtml", typeof(AspNetCore.Views_Admin_ListeFinale3))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40e20f7f46fc59fcde1acd7c4bafcad0095d15aa", @"/Views/Admin/ListeFinale3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d40043f5e6a50be129fc5644635f682c8f7c25f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ListeFinale3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Informatique", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Industriel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "GTR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "GPMC", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Admin\ListeFinale3.cshtml"
  
    ViewBag.Title = "ListeFinal";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(96, 720, true);
            WriteLiteral(@"
<!-- End of Topbar -->
<!-- Begin Page Content -->
<style>
</style>
<div class=""container-fluid"">

    <div class=""align-content-center"">
        <h3 class=""font-weight-bold text-center pt-3 pb-5"" id=""title""> List Final 3eme Année</h3>
        <div class=""row mb-4 justify-content-center"">
            <div class="" col-md-7"">

                <div class=""form-horizontal "">


                    <div class=""form-group row"">
                        <label class=""col-md-4 col-form-label"">Filière : </label>
                        <div class=""col-md-8"">
                            <select class=""form-control"" name=""Filiere"" id=""FiliereSelect"" onchange=""selected()"">
                                ");
            EndContext();
            BeginContext(816, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66afc4a549ac43269710790af4897515", async() => {
                BeginContext(843, 16, true);
                WriteLiteral("Choix du Filiere");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(868, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(902, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2f650b74261472a9ee079361a2b693d", async() => {
                BeginContext(931, 18, true);
                WriteLiteral("Génie Informatique");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(958, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(992, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bf20e89d3784dacb56326581d48501f", async() => {
                BeginContext(1019, 16, true);
                WriteLiteral("Génie Industriel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1044, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1078, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76486e4ecec745e9b6cede650d8e29a9", async() => {
                BeginContext(1098, 3, true);
                WriteLiteral("GTR");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1110, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1144, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46765c19f39d4ae593ba4c422c13dd61", async() => {
                BeginContext(1165, 4, true);
                WriteLiteral("GPMC");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1178, 3044, true);
            WriteLiteral(@"
                            </select>
                        </div>
                    </div>


                </div>
            </div>


        </div>
    </div>

    <div>
        <h4 style=""text-align:center;"">Liste Principale</h4>
        <table class=""table table-bordered text-center"" id=""tableSelection"">
            <tr class=""table-info"">
                <th class=""text-center"">N°</th>
                <th class=""text-center"">Nom</th>
                <th class=""text-center"">Prenom</th>
                <th class=""text-center"">Cin</th>
                <th class=""text-center"">N.Dossier</th>
                <th class=""text-center"">Matricule</th>

            </tr>

            <tbody id=""tbody""></tbody>


        </table>

        <div style=""margin-top:50px"">
            <h4 style=""text-align:center"">Liste Attente</h4>
            <table class=""table table-bordered text-center"" id=""tableSelection"">
                <tr class=""table-warning"">
                    <th c");
            WriteLiteral(@"lass=""text-center"">N°</th>
                    <th class=""text-center"">Nom</th>
                    <th class=""text-center"">Prenom</th>
                    <th class=""text-center"">Cin</th>
                    <th class=""text-center"">N.Dossier</th>
                    <th class=""text-center"">Matricule</th>

                </tr>

                <tbody id=""tbody2""></tbody>


            </table>

        </div>

    </div>

</div>
<!-- /.container-fluid -->


<script>


    function selected() {


        $.get(""/Admin/GetListePrincipal"", { filiere: $(""#FiliereSelect"").val() }, function (data) {

            var num = 0;
            $('#tbody').empty();
            data.forEach(function (element) {
                num++;

                $('#tbody').append(
                    '<tr>' +
                    '<td>' + num + '</td>' +

                    '<td>' + element.nom + '</td>' +
                    '<td>' + element.prenom + '</td>' +

                    '<td>' + e");
            WriteLiteral(@"lement.num_dossier + '</td>' +

                    '<td>' + element.matricule + '</td>' +
                    '<td>' + element.cin + '</td>' +
                    + '</tr>'
                );

            });

        });


        $.get(""/Admin/GetListeAttente"", { filiere: $(""#FiliereSelect"").val() }, function (data) {

            var num = 0;
            $('#tbody2').empty();
            data.forEach(function (element) {
                num++;

                $('#tbody2').append(
                    '<tr>' +
                    '<td>' + num + '</td>' +

                    '<td>' + element.nom + '</td>' +
                    '<td>' + element.prenom + '</td>' +

                    '<td>' + element.num_dossier + '</td>' +

                    '<td>' + element.matricule + '</td>' +
                    '<td>' + element.cin + '</td>' +
                    + '</tr>'
                );

            });

        });
    }






</script>

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
