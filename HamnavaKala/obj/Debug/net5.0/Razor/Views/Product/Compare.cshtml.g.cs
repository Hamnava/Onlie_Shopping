#pragma checksum "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "379559f93d428120117eda32ce145d34dcf44ede"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Compare), @"mvc.1.0.view", @"/Views/Product/Compare.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"379559f93d428120117eda32ce145d34dcf44ede", @"/Views/Product/Compare.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"095e940bf288069610f4a0a0c5275406d43bce51", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Compare : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<comapreviewmodel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
  
    ViewData["Title"] = "Compare";
    List<Propertyproductcompare> property = ViewBag.property;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main-row mb-4"">
    <div class=""container-main"">
        <div class=""col-12"">
            <div id=""breadcrumb"">
                <i class=""mdi mdi-home""></i>
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb mb-0"">
                        <li class=""breadcrumb-item""><a href=""#"">خانه</a></li>
                        <li class=""breadcrumb-item""><a href=""#"">کالای دیجیتال</a></li>
                        <li class=""breadcrumb-item active open"" aria-current=""page"">موبایل</li>
                    </ol>
                </nav>
            </div>
            <div class=""comparison"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <td class=""align-middle"">
                                <div class=""form-ui"">
                                    <div class=""custom-select-ui"">
");
#nullable restore
#line 27 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                         if (Model.Count() < 3)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <select class=\"right form-control select\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "379559f93d428120117eda32ce145d34dcf44ede5394", async() => {
                WriteLiteral("انتخاب کنید");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 31 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                                 foreach (var item in ViewBag.Product as List<GetProductForCompare>)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "379559f93d428120117eda32ce145d34dcf44ede6992", async() => {
                WriteLiteral(" ");
#nullable restore
#line 33 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                                                                     Write(item.productfatitle);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                                                   Write(item.productid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-value", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 34 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </select>\r\n");
#nullable restore
#line 36 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                </div>
                                <div class=""form-auth-row pr"">
                                    <label for=""#"" class=""ui-checkbox mt-1"">
                                        <input type=""checkbox"" value=""1"" name=""login"" id=""remember"">
                                        <span class=""ui-checkbox-check""></span>
                                    </label>
                                    <label for=""remember"" class=""remember-me mr-0"">فقط تفاوت را نشان بده</label>
                                </div>
                            </td>
");
#nullable restore
#line 47 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"ProductCompare\" data-productid=\"");
#nullable restore
#line 49 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                                                      Write(item.productid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    <div class=\"comparison-item\">\r\n                                        <span class=\"remove-item\">\r\n                                            <i class=\"mdi mdi-close\" data-productid=\"");
#nullable restore
#line 52 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                                                                Write(item.productid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></i>\r\n                                        </span>\r\n                                        <a class=\"comparison-item-thumb\" href=\"#\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 3040, "\"", 3097, 2);
            WriteAttributeValue("", 3046, "/Site/assets/images/slider-product/", 3046, 35, true);
#nullable restore
#line 55 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
WriteAttributeValue("", 3081, item.productimg, 3081, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Samsung-S10Plus\">\r\n                                        </a>\r\n                                        <a class=\"comparison-item-title\" href=\"#\"> ");
#nullable restore
#line 57 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                                                              Write(item.productfatitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        <span class=\"amount\">\r\n");
#nullable restore
#line 59 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                             if (item.productprice <= 0 || item.productprice == null)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span>یافت نشد</span>\r\n");
#nullable restore
#line 62 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                            }
                                            else
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                           Write(item.productprice);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span> افغانی </span>\r\n");
#nullable restore
#line 67 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                        </span>\r\n                                    </div>\r\n                                </td>\r\n");
#nullable restore
#line 73 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 79 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                         foreach (var item in property.GroupBy(p => p.propertyname))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"bg-cs-table-tr\">\r\n                                <th class=\"text-uppercase\">");
#nullable restore
#line 82 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                                      Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 4433, "\"", 4441, 0);
            EndWriteAttribute();
            WriteLiteral("><span class=\"text-medium\"></span></td>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 4518, "\"", 4526, 0);
            EndWriteAttribute();
            WriteLiteral("><span class=\"text-medium\"></span></td>\r\n                                <td");
            BeginWriteAttribute("class", " class=\"", 4603, "\"", 4611, 0);
            EndWriteAttribute();
            WriteLiteral("><span class=\"text-medium\"></span></td>\r\n                            </tr>\r\n");
#nullable restore
#line 87 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                            int colspan = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td></td>\r\n");
#nullable restore
#line 90 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                 foreach (var item2 in Model.OrderBy(f => f.productid))
                                {
                                    var properyvalue = property.Where(p => p.productid == item2.productid).ToList();
                                    colspan++;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                     for (int i = 0; i < properyvalue.Count; i++)
                                    {
                                        if (properyvalue[i].propertynameid == item.First().propertynameid)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <th style=\"padding-left:8%;\" class=\"text-left\"");
            BeginWriteAttribute("colspan", " colspan=\"", 5464, "\"", 5482, 1);
#nullable restore
#line 98 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
WriteAttributeValue("", 5474, colspan, 5474, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 98 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                                                                                         Write(properyvalue[i].propertyvalue);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </th>\r\n");
#nullable restore
#line 99 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                            colspan = 0;
                                        }

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                                     

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 108 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\Compare.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                    </tbody>\r\n\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");
            DefineSection("SCript", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {

            var ListProductid = [];
            $('.ProductCompare').each(function () {
                ListProductid.push($(this).data('productid'))
            });


            $("".option"").click(function () {
                var id = $(this).data('value');

                window.location.href = '/compare/' + ListProductid.join(""/"") + ""/"" + id;
            });
            //$('.select').change(function () {

            //    var id = $(this).children(""option:selected"").data('value');
            //    window.location.href = '/compare/' + ListProductid.join(""/"") + ""/"" + id;
            //});


            $('.mdi-close').click(function () {
                var id = $(this).data('productid');
                ListProductid = $.grep(ListProductid, function (value) {
                    return value != id
                });

                window.location.href = '/compare/' + ListProductid.join('/');
            });

     ");
                WriteLiteral("   });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<comapreviewmodel>> Html { get; private set; }
    }
}
#pragma warning restore 1591