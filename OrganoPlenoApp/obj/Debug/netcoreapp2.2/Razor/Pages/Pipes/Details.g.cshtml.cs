#pragma checksum "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Pipes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1ac9b3621db40551e21decf521d3d1ebfffcc77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OrganoPlenoApp.Pages.Pipes.Pages_Pipes_Details), @"mvc.1.0.razor-page", @"/Pages/Pipes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Pipes/Details.cshtml", typeof(OrganoPlenoApp.Pages.Pipes.Pages_Pipes_Details), null)]
namespace OrganoPlenoApp.Pages.Pipes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\_ViewImports.cshtml"
using OrganoPlenoApp;

#line default
#line hidden
#line 3 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\_ViewImports.cshtml"
using OrganoPlenoApp.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ac9b3621db40551e21decf521d3d1ebfffcc77", @"/Pages/Pipes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10abc98801f3856cfd724c6057d3d8dd930e9e0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pipes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Pipes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(100, 125, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Pipe</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(226, 45, false);
#line 15 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Pipes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pipe.Name));

#line default
#line hidden
            EndContext();
            BeginContext(271, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(333, 41, false);
#line 18 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Pipes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pipe.Name));

#line default
#line hidden
            EndContext();
            BeginContext(374, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(435, 49, false);
#line 21 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Pipes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pipe.Category));

#line default
#line hidden
            EndContext();
            BeginContext(484, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(546, 45, false);
#line 24 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Pipes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pipe.Category));

#line default
#line hidden
            EndContext();
            BeginContext(591, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(652, 54, false);
#line 27 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Pipes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pipe.Specification));

#line default
#line hidden
            EndContext();
            BeginContext(706, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(768, 50, false);
#line 30 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Pipes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pipe.Specification));

#line default
#line hidden
            EndContext();
            BeginContext(818, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(879, 49, false);
#line 33 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Pipes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pipe.Material));

#line default
#line hidden
            EndContext();
            BeginContext(928, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(990, 45, false);
#line 36 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Pipes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pipe.Material));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1096, 46, false);
#line 39 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Pipes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pipe.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1142, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1204, 42, false);
#line 42 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Pipes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pipe.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1246, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1307, 45, false);
#line 45 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Pipes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pipe.Year));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1414, 41, false);
#line 48 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Pipes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pipe.Year));

#line default
#line hidden
            EndContext();
            BeginContext(1455, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1516, 54, false);
#line 51 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Pipes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pipe.Division.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1570, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1632, 50, false);
#line 54 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Pipes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pipe.Division.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1682, 67, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Organ\r\n");
            EndContext();
            BeginContext(1828, 59, true);
            WriteLiteral("        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1888, 56, false);
#line 61 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Pipes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pipe.Division.Organ.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1944, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1991, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1ac9b3621db40551e21decf521d3d1ebfffcc7711165", async() => {
                BeginContext(2042, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Pipes\Details.cshtml"
                           WriteLiteral(Model.Pipe.ID);

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
            BeginContext(2050, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2058, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1ac9b3621db40551e21decf521d3d1ebfffcc7713499", async() => {
                BeginContext(2080, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2096, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrganoPlenoApp.Pages.Pipes.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OrganoPlenoApp.Pages.Pipes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OrganoPlenoApp.Pages.Pipes.DetailsModel>)PageContext?.ViewData;
        public OrganoPlenoApp.Pages.Pipes.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
