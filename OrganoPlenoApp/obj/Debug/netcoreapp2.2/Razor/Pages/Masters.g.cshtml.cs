#pragma checksum "E:\VisualStudio\OrganoPlenoApp\OrganoPlenoApp\Pages\Masters.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9d4e77a865fbefb842ead5490743c225d210871"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OrganoPlenoApp.Pages.Pages_Masters), @"mvc.1.0.razor-page", @"/Pages/Masters.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Masters.cshtml", typeof(OrganoPlenoApp.Pages.Pages_Masters), null)]
namespace OrganoPlenoApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\VisualStudio\OrganoPlenoApp\OrganoPlenoApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\VisualStudio\OrganoPlenoApp\OrganoPlenoApp\Pages\_ViewImports.cshtml"
using OrganoPlenoApp;

#line default
#line hidden
#line 3 "E:\VisualStudio\OrganoPlenoApp\OrganoPlenoApp\Pages\_ViewImports.cshtml"
using OrganoPlenoApp.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d4e77a865fbefb842ead5490743c225d210871", @"/Pages/Masters.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10abc98801f3856cfd724c6057d3d8dd930e9e0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Masters : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\VisualStudio\OrganoPlenoApp\OrganoPlenoApp\Pages\Masters.cshtml"
  
    ViewData["Title"] = "Masters";

#line default
#line hidden
            BeginContext(50, 604, true);
            WriteLiteral(@"<div class=""text-center"">
    <h2>Masters</h2>
    <h3> - See what humans can do with their hands and feet</h3>
</div>
<div class=""text-center"">
    <iframe class=""mt-lg-5"" width=""885"" height=""500"" src=""https://www.youtube.com/embed/Qk40cJLgRTY"" frameborder=""0"" allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
    <iframe class=""mt-lg-5"" width=""885"" height=""500"" src=""https://www.youtube.com/embed/SfS14rpl0OI"" frameborder=""0"" allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Masters> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Masters> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Masters>)PageContext?.ViewData;
        public Pages_Masters Model => ViewData.Model;
    }
}
#pragma warning restore 1591
