#pragma checksum "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Divisions\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9b525554233ab980791d6db3e45747384606fab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OrganoPlenoApp.Pages.Divisions.Pages_Divisions_Details), @"mvc.1.0.razor-page", @"/Pages/Divisions/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Divisions/Details.cshtml", typeof(OrganoPlenoApp.Pages.Divisions.Pages_Divisions_Details), null)]
namespace OrganoPlenoApp.Pages.Divisions
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9b525554233ab980791d6db3e45747384606fab", @"/Pages/Divisions/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10abc98801f3856cfd724c6057d3d8dd930e9e0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Divisions_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Pipes/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Divisions\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(104, 129, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Division</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(234, 50, false);
#line 15 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Divisions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Division.Organ));

#line default
#line hidden
            EndContext();
            BeginContext(284, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(346, 51, false);
#line 18 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Divisions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Division.Organ.Name));

#line default
#line hidden
            EndContext();
            BeginContext(397, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(458, 49, false);
#line 21 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Divisions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Division.Name));

#line default
#line hidden
            EndContext();
            BeginContext(507, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(569, 45, false);
#line 24 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Divisions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Division.Name));

#line default
#line hidden
            EndContext();
            BeginContext(614, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(675, 58, false);
#line 27 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Divisions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Division.NumberOfStops));

#line default
#line hidden
            EndContext();
            BeginContext(733, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(795, 54, false);
#line 30 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Divisions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Division.NumberOfStops));

#line default
#line hidden
            EndContext();
            BeginContext(849, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(910, 50, false);
#line 33 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Divisions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Division.Pipes));

#line default
#line hidden
            EndContext();
            BeginContext(960, 119, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            <table class=\"table\">\r\n                <tr><th>Spec</th><th>Name</th></tr>\r\n");
            EndContext();
#line 38 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Divisions\Details.cshtml"
                  foreach (var p in Model.Division.Pipes)
                    {

#line default
#line hidden
            BeginContext(1161, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1224, 41, false);
#line 41 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Divisions\Details.cshtml"
                           Write(Html.DisplayFor(model => p.Specification));

#line default
#line hidden
            EndContext();
            BeginContext(1265, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1304, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9b525554233ab980791d6db3e45747384606fab8788", async() => {
                BeginContext(1355, 6, false);
#line 42 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Divisions\Details.cshtml"
                                                                             Write(p.Name);

#line default
#line hidden
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
#line 42 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Divisions\Details.cshtml"
                                                               WriteLiteral(p.ID);

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
            BeginContext(1365, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 44 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Divisions\Details.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(1445, 69, true);
            WriteLiteral("            </table>\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1514, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9b525554233ab980791d6db3e45747384606fab11735", async() => {
                BeginContext(1569, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\Divisions\Details.cshtml"
                           WriteLiteral(Model.Division.ID);

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
            BeginContext(1577, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1585, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9b525554233ab980791d6db3e45747384606fab14077", async() => {
                BeginContext(1607, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1623, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrganoPlenoApp.Pages.Divisions.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OrganoPlenoApp.Pages.Divisions.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OrganoPlenoApp.Pages.Divisions.DetailsModel>)PageContext?.ViewData;
        public OrganoPlenoApp.Pages.Divisions.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
