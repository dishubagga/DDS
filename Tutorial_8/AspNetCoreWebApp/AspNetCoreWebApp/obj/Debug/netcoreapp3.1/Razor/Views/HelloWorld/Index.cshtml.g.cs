#pragma checksum "/Users/dishubagga/Documents/study/Practice(DDS)/Tutorial/Tutorial_8/AspNetCoreWebApp/AspNetCoreWebApp/Views/HelloWorld/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d80f29b47d9b52787ba7092eead6b830784e45b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_Index), @"mvc.1.0.view", @"/Views/HelloWorld/Index.cshtml")]
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
#line 1 "/Users/dishubagga/Documents/study/Practice(DDS)/Tutorial/Tutorial_8/AspNetCoreWebApp/AspNetCoreWebApp/Views/_ViewImports.cshtml"
using AspNetCoreWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dishubagga/Documents/study/Practice(DDS)/Tutorial/Tutorial_8/AspNetCoreWebApp/AspNetCoreWebApp/Views/_ViewImports.cshtml"
using AspNetCoreWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d80f29b47d9b52787ba7092eead6b830784e45b", @"/Views/HelloWorld/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4f3bb6d18b6041f0aae711f24d6acb2ce243732", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("Copy\n");
#nullable restore
#line 2 "/Users/dishubagga/Documents/study/Practice(DDS)/Tutorial/Tutorial_8/AspNetCoreWebApp/AspNetCoreWebApp/Views/HelloWorld/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Welcome</h2>\n\n<ul>\n");
#nullable restore
#line 9 "/Users/dishubagga/Documents/study/Practice(DDS)/Tutorial/Tutorial_8/AspNetCoreWebApp/AspNetCoreWebApp/Views/HelloWorld/Index.cshtml"
     for (int i = 0; i < (int)ViewData["NumTimes"]; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 11 "/Users/dishubagga/Documents/study/Practice(DDS)/Tutorial/Tutorial_8/AspNetCoreWebApp/AspNetCoreWebApp/Views/HelloWorld/Index.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 12 "/Users/dishubagga/Documents/study/Practice(DDS)/Tutorial/Tutorial_8/AspNetCoreWebApp/AspNetCoreWebApp/Views/HelloWorld/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n");
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
