#pragma checksum "C:\Users\Paweł\source\repos\Zestaw12\Zestaw12\Views\Doctors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d669795b1820ba762dbab743fd90cca41a0c2542"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_Index), @"mvc.1.0.view", @"/Views/Doctors/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d669795b1820ba762dbab743fd90cca41a0c2542", @"/Views/Doctors/Index.cshtml")]
    public class Views_Doctors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Zestaw12.Models.Doctors>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Hello</h1>\r\n<p>\r\n    There\r\n</p>\r\n<h2>");
#nullable restore
#line 10 "C:\Users\Paweł\source\repos\Zestaw12\Zestaw12\Views\Doctors\Index.cshtml"
Write(ViewBag.Nazwisko);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<ul>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>");
#nullable restore
#line 15 "C:\Users\Paweł\source\repos\Zestaw12\Zestaw12\Views\Doctors\Index.cshtml"
               Write(Html.DisplayNameFor(modelItem => modelItem.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 16 "C:\Users\Paweł\source\repos\Zestaw12\Zestaw12\Views\Doctors\Index.cshtml"
               Write(Html.DisplayNameFor(modelItem => modelItem.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 17 "C:\Users\Paweł\source\repos\Zestaw12\Zestaw12\Views\Doctors\Index.cshtml"
               Write(Html.DisplayNameFor(modelItem => modelItem.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n        </thead>\r\n");
#nullable restore
#line 20 "C:\Users\Paweł\source\repos\Zestaw12\Zestaw12\Views\Doctors\Index.cshtml"
         foreach (var d in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Paweł\source\repos\Zestaw12\Zestaw12\Views\Doctors\Index.cshtml"
               Write(d.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Paweł\source\repos\Zestaw12\Zestaw12\Views\Doctors\Index.cshtml"
               Write(d.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Paweł\source\repos\Zestaw12\Zestaw12\Views\Doctors\Index.cshtml"
               Write(d.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Paweł\source\repos\Zestaw12\Zestaw12\Views\Doctors\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Zestaw12.Models.Doctors>> Html { get; private set; }
    }
}
#pragma warning restore 1591