#pragma checksum "C:\arquivos\estudo\projetos\empregare\Vagas\Views\Home\LayoutOriginalIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bae73d5e42881d87ccb635b5ffa722e3a4005ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LayoutOriginalIndex), @"mvc.1.0.view", @"/Views/Home/LayoutOriginalIndex.cshtml")]
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
#line 1 "C:\arquivos\estudo\projetos\empregare\Vagas\Views\_ViewImports.cshtml"
using Vagas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\arquivos\estudo\projetos\empregare\Vagas\Views\_ViewImports.cshtml"
using Vagas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bae73d5e42881d87ccb635b5ffa722e3a4005ae", @"/Views/Home/LayoutOriginalIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d333b2525dfe28ae348215eca476b06c702c9d14", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LayoutOriginalIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vaga>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/destaque.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mh-100 col-lg-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("My image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\arquivos\estudo\projetos\empregare\Vagas\Views\Home\LayoutOriginalIndex.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 12 "C:\arquivos\estudo\projetos\empregare\Vagas\Views\Home\LayoutOriginalIndex.cshtml"
  
    ViewData["Title"] = "Vagas";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container d-flex justify-content-around align-items-center row"">
    <span class=""align-middle col-lg-6"">
        <h6 style=""font-weight: 400;"">SOLUÇÕES PARA</h6>
        <h1 class=""text-secondary"" style=""font-weight: 800;"">CANDIDATOS</h1>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. 
            Expedita, consectetur. Tempore optio quae dolore. </p>
        <button type=""button"" class=""px-5 my-4 py-2 btn btn-primary btn""
            style=""border-radius: 5%; font-weight: 500"">CADASTRE-SE</button>
    </span>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3bae73d5e42881d87ccb635b5ffa722e3a4005ae5242", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div class=\"bg-primary\">\r\n    <div class=\"text-white text-center py-5\">\r\n        <h3 class=\"d-inline-block mb-5\">Confira nossas vagas disponíveis</h3>\r\n        <span class=\"px-4 d-flex flex-wrap justify-content-start\">\r\n");
#nullable restore
#line 30 "C:\arquivos\estudo\projetos\empregare\Vagas\Views\Home\LayoutOriginalIndex.cshtml"
             foreach (Vaga vaga in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"my-4 mx-5 text-left\" style=\"width: 190px;\" overflow=hidden>\r\n                    <h5>");
#nullable restore
#line 33 "C:\arquivos\estudo\projetos\empregare\Vagas\Views\Home\LayoutOriginalIndex.cshtml"
                   Write(vaga.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <div><i class=\"fas fa-map-marker-alt\"></i> ");
#nullable restore
#line 34 "C:\arquivos\estudo\projetos\empregare\Vagas\Views\Home\LayoutOriginalIndex.cshtml"
                                                          Write(vaga.Localizacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div><i class=\"fas fa-money-bill-wave\"></i> R$ ");
#nullable restore
#line 35 "C:\arquivos\estudo\projetos\empregare\Vagas\Views\Home\LayoutOriginalIndex.cshtml"
                                                              Write(vaga.Salario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </span>\r\n");
#nullable restore
#line 37 "C:\arquivos\estudo\projetos\empregare\Vagas\Views\Home\LayoutOriginalIndex.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </span>
    </div>
</div>
<div class=""text-center align-middle my-5"">
    <h3 class=""my-5 text-secondary"">Faça parte você também</h3>
    <button type=""button"" class=""mx-5 px-5 py-3 btn btn-primary btn-lg font-weight-bold""
        style=""border-radius: 5%"">CADASTRE-SE</button>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vaga>> Html { get; private set; }
    }
}
#pragma warning restore 1591
