#pragma checksum "C:\Users\Acer\Desktop\.NET dotNet\Web-AdminLTE-dotNet\Views\Empregado\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b2b3e3847115f47ea826c63ac1c41a3efc94f54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empregado_Details), @"mvc.1.0.view", @"/Views/Empregado/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empregado/Details.cshtml", typeof(AspNetCore.Views_Empregado_Details))]
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
#line 1 "C:\Users\Acer\Desktop\.NET dotNet\Web-AdminLTE-dotNet\Views\_ViewImports.cshtml"
using Web_AdminLTE;

#line default
#line hidden
#line 2 "C:\Users\Acer\Desktop\.NET dotNet\Web-AdminLTE-dotNet\Views\_ViewImports.cshtml"
using Web_AdminLTE.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b2b3e3847115f47ea826c63ac1c41a3efc94f54", @"/Views/Empregado/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03182abe1ef280b581a647b46dcc8971d80fb228", @"/Views/_ViewImports.cshtml")]
    public class Views_Empregado_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web_AdminLTE.Models.Empregado>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 415, true);
            WriteLiteral(@"<div class=""content-wrapper"">
    <section class=""content-header"">
        <h1>
            Dashboard
            <small>Version 2.0</small>
        </h1>
        <ol class=""breadcrumb"">
            <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
            <li class=""active"">Dashboard</li>
        </ol>
    </section>

        <!-- Main content -->
        <section class=""content"">
");
            EndContext();
            BeginContext(465, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\Users\Acer\Desktop\.NET dotNet\Web-AdminLTE-dotNet\Views\Empregado\Details.cshtml"
              
                ViewData["Title"] = "Details";
            

#line default
#line hidden
            BeginContext(546, 215, true);
            WriteLiteral("\r\n            <h1>Detalhes</h1>\r\n\r\n            <div>\r\n                <h4>Empregado</h4>\r\n                <hr />\r\n                <dl class=\"row\">\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
            EndContext();
            BeginContext(762, 48, false);
#line 28 "C:\Users\Acer\Desktop\.NET dotNet\Web-AdminLTE-dotNet\Views\Empregado\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.NameCompleto));

#line default
#line hidden
            EndContext();
            BeginContext(810, 97, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
            EndContext();
            BeginContext(908, 44, false);
#line 31 "C:\Users\Acer\Desktop\.NET dotNet\Web-AdminLTE-dotNet\Views\Empregado\Details.cshtml"
                   Write(Html.DisplayFor(model => model.NameCompleto));

#line default
#line hidden
            EndContext();
            BeginContext(952, 96, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
            EndContext();
            BeginContext(1049, 43, false);
#line 34 "C:\Users\Acer\Desktop\.NET dotNet\Web-AdminLTE-dotNet\Views\Empregado\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.EmpCode));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 97, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
            EndContext();
            BeginContext(1190, 39, false);
#line 37 "C:\Users\Acer\Desktop\.NET dotNet\Web-AdminLTE-dotNet\Views\Empregado\Details.cshtml"
                   Write(Html.DisplayFor(model => model.EmpCode));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 96, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
            EndContext();
            BeginContext(1326, 43, false);
#line 40 "C:\Users\Acer\Desktop\.NET dotNet\Web-AdminLTE-dotNet\Views\Empregado\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Posicao));

#line default
#line hidden
            EndContext();
            BeginContext(1369, 97, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
            EndContext();
            BeginContext(1467, 39, false);
#line 43 "C:\Users\Acer\Desktop\.NET dotNet\Web-AdminLTE-dotNet\Views\Empregado\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Posicao));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 96, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
            EndContext();
            BeginContext(1603, 55, false);
#line 46 "C:\Users\Acer\Desktop\.NET dotNet\Web-AdminLTE-dotNet\Views\Empregado\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.LocalizacaoTrabalho));

#line default
#line hidden
            EndContext();
            BeginContext(1658, 97, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
            EndContext();
            BeginContext(1756, 51, false);
#line 49 "C:\Users\Acer\Desktop\.NET dotNet\Web-AdminLTE-dotNet\Views\Empregado\Details.cshtml"
                   Write(Html.DisplayFor(model => model.LocalizacaoTrabalho));

#line default
#line hidden
            EndContext();
            BeginContext(1807, 107, true);
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(1914, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b2b3e3847115f47ea826c63ac1c41a3efc94f548754", async() => {
                BeginContext(1969, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\Acer\Desktop\.NET dotNet\Web-AdminLTE-dotNet\Views\Empregado\Details.cshtml"
                                       WriteLiteral(Model.EmpregadoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1979, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1999, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b2b3e3847115f47ea826c63ac1c41a3efc94f5411116", async() => {
                BeginContext(2021, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2031, 49, true);
            WriteLiteral("\r\n            </div>\r\n        </section>\r\n </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web_AdminLTE.Models.Empregado> Html { get; private set; }
    }
}
#pragma warning restore 1591
