#pragma checksum "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowAllProperty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2be4894fb7a5e86378b072f03a97c37dae80ebb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowAllProperty), @"mvc.1.0.view", @"/Views/Product/ShowAllProperty.cshtml")]
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
#line 3 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\_ViewImports.cshtml"
using HamnavaKala.DataLayer.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\_ViewImports.cshtml"
using HamnavaKala.Core.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\_ViewImports.cshtml"
using HamnavaKala.Core.Classes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2be4894fb7a5e86378b072f03a97c37dae80ebb", @"/Views/Product/ShowAllProperty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"095e940bf288069610f4a0a0c5275406d43bce51", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowAllProperty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ValueViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowAllProperty.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<article>\r\n    <h2 class=\"params-headline\">\r\n        مشخصات فنی \r\n");
            WriteLiteral("    </h2>\r\n\r\n    <section>\r\n        <ul class=\"params-list\">\r\n");
#nullable restore
#line 14 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowAllProperty.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"params-list-item\">\r\n                    <div class=\"params-list-key\">\r\n                        <span class=\"block\">");
#nullable restore
#line 19 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowAllProperty.cshtml"
                                       Write(item.propname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"params-list-value\">\r\n                        <span class=\"block\">\r\n                            ");
#nullable restore
#line 23 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowAllProperty.cshtml"
                       Write(item.value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                </li>\r\n");
#nullable restore
#line 27 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowAllProperty.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </ul>\r\n    </section>\r\n\r\n</article>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ValueViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591