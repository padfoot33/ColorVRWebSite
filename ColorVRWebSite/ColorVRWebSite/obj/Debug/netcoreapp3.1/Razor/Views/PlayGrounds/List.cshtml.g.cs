#pragma checksum "C:\Users\PadFooT\Documents\GitHub\ColorVRWebSite\ColorVRWebSite\ColorVRWebSite\Views\PlayGrounds\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6d3eef1104089056d7d4b63c9fe3218dcc940bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PlayGrounds_List), @"mvc.1.0.view", @"/Views/PlayGrounds/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PlayGrounds/List.cshtml", typeof(AspNetCore.Views_PlayGrounds_List))]
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
#line 1 "C:\Users\PadFooT\Documents\GitHub\ColorVRWebSite\ColorVRWebSite\ColorVRWebSite\Views\_ViewImports.cshtml"
using ColorVRWebSite.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\PadFooT\Documents\GitHub\ColorVRWebSite\ColorVRWebSite\ColorVRWebSite\Views\_ViewImports.cshtml"
using ColorVRWebSite.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6d3eef1104089056d7d4b63c9fe3218dcc940bb", @"/Views/PlayGrounds/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2905f27f21ff81e572ed79dd091729e2897cc479", @"/Views/_ViewImports.cshtml")]
    public class Views_PlayGrounds_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 65, true);
            WriteLiteral("<div>\r\n    <h2> All PlayGrounds are shown here</h2>\r\n</div>\r\n<h2>");
            EndContext();
            BeginContext(66, 21, false);
#line 4 "C:\Users\PadFooT\Documents\GitHub\ColorVRWebSite\ColorVRWebSite\ColorVRWebSite\Views\PlayGrounds\List.cshtml"
Write(Model.currentCategory);

#line default
#line hidden
            EndContext();
            BeginContext(87, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 5 "C:\Users\PadFooT\Documents\GitHub\ColorVRWebSite\ColorVRWebSite\ColorVRWebSite\Views\PlayGrounds\List.cshtml"
   
    foreach(PlayGrounds pg in Model.playGrounds)
    {
        

#line default
#line hidden
            BeginContext(165, 38, false);
#line 8 "C:\Users\PadFooT\Documents\GitHub\ColorVRWebSite\ColorVRWebSite\ColorVRWebSite\Views\PlayGrounds\List.cshtml"
   Write(Html.Partial("PlayGroundsSummary", pg));

#line default
#line hidden
            EndContext();
#line 8 "C:\Users\PadFooT\Documents\GitHub\ColorVRWebSite\ColorVRWebSite\ColorVRWebSite\Views\PlayGrounds\List.cshtml"
                                               
    }

#line default
#line hidden
            BeginContext(215, 2, true);
            WriteLiteral("\r\n");
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
