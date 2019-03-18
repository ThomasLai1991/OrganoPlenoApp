#pragma checksum "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\APIs\APIs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f021c6ffb0254984a7a9efb45df0a2b52a79495a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OrganoPlenoApp.Pages.APIs.Pages_APIs_APIs), @"mvc.1.0.razor-page", @"/Pages/APIs/APIs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/APIs/APIs.cshtml", typeof(OrganoPlenoApp.Pages.APIs.Pages_APIs_APIs), null)]
namespace OrganoPlenoApp.Pages.APIs
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f021c6ffb0254984a7a9efb45df0a2b52a79495a", @"/Pages/APIs/APIs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10abc98801f3856cfd724c6057d3d8dd930e9e0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_APIs_APIs : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\visual studio projects\Azure\OrganoPlenoApp\OrganoPlenoApp\Pages\APIs\APIs.cshtml"
  
    ViewData["Title"] = "APIs";

#line default
#line hidden
            BeginContext(47, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(76, 609, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f021c6ffb0254984a7a9efb45df0a2b52a79495a3760", async() => {
                BeginContext(82, 596, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>APIs</title>
    <style>
        input[type='submit'], button, [aria-label] {
            cursor: pointer;
        }

        #spoiler {
            display: none;
        }

        table {
            font-family: Arial, sans-serif;
            border: 1px solid;
            border-collapse: collapse;
        }

        th {
            background-color: #0066CC;
            color: white;
        }

        td {
            border: 1px solid;
            padding: 5px;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(685, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(687, 2097, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f021c6ffb0254984a7a9efb45df0a2b52a79495a5540", async() => {
                BeginContext(693, 2084, true);
                WriteLiteral(@"


    <div class=""container"">
        <h2>API route table</h2>
        <table class=""table"">
            <thead>
                <tr>
                    <th>HTTP Methods</th>
                    <th>Organs</th>
                    <th>Divisions</th>
                    <th>Pipes</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>GET(list)</td>
                    <td>api/Organs/</td>
                    <td>api/Divisions/</td>
                    <td>api/Pipes/</td>
                </tr>
                <tr>
                    <td>GET(query)</td>
                    <td>?name=asc/des/{name} (sort by name order or seach by name) </td>
                    <td>?organID={id}(search by organ id)</td>
                    <td>?category={category}(search by category, case insensitive)</td>
                </tr>
                <tr>
                    <td>GET(single)</td>
                    <td>api/Organs/{id}</td>
       ");
                WriteLiteral(@"             <td>api/Divisions/{id}</td>
                    <td>api/Pipes/{id}</td>
                </tr>
                <tr>
                    <td>PUT</td>
                    <td>api/Organs/{id}</td>
                    <td>api/Divisions/{id}</td>
                    <td>api/Pipes/{id}</td>
                </tr>
                <tr>
                    <td>POST</td>
                    <td>api/Organs/</td>
                    <td>api/Divisions/</td>
                    <td>api/Pipes/</td>
                </tr>
                <tr>
                    <td>DELETE</td>
                    <td>api/Organs/{id}</td>
                    <td>api/Divisions/{id}</td>
                    <td>api/Pipes/{id}</td>
                </tr>
            </tbody>
        </table>
    </div>

    <p>
        For example, if you type ""https://organoplenoapp.azurewebsites.net/api/organs?name=asc"" into browser address bar<br />
        You will receive a list of organ entities in JSON ordered ascendin");
                WriteLiteral("gly by their names\r\n    </p>\r\n\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2784, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_APIs_APIs> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_APIs_APIs> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_APIs_APIs>)PageContext?.ViewData;
        public Pages_APIs_APIs Model => ViewData.Model;
    }
}
#pragma warning restore 1591