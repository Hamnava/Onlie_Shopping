#pragma checksum "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85817e9736ab39072ca1bc7c574a7819bd115756"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_ShowProduct), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/ShowProduct.cshtml")]
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
#line 3 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\_ViewImports.cshtml"
using HamnavaKala.DataLayer.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\_ViewImports.cshtml"
using HamnavaKala.Core.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\_ViewImports.cshtml"
using HamnavaKala.Core.Classes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85817e9736ab39072ca1bc7c574a7819bd115756", @"/Areas/Admin/Views/Product/ShowProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"397e92ca8624df7ee11a13a28e560d49209981fb", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_ShowProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary waves-effect waves-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("140"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddReviewforProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("on-default "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowPriceForProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("on-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("on-default edit-row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MainModal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
  
    ViewData["Title"] = "نمایش محصول ها";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    int counter = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-sm-12\">\r\n    <div class=\"panel\">\r\n        <div class=\"panel-body\" style=\"margin-top:100px\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"m-b-30\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85817e9736ab39072ca1bc7c574a7819bd1157568245", async() => {
                WriteLiteral("افزودن <i class=\"fa fa-plus\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>

            <div class=""editable-responsive"">
                <div id=""datatable-editable_wrapper"" class=""dataTables_wrapper form-inline dt-bootstrap no-footer"">
                    <div class=""row"">
                        <div class=""col-sm-12"">
");
#nullable restore
#line 23 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                             if (TempData["Result"] != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                                 if (TempData["Result"].ToString() == "true")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""alert alert-info alert-dismissable"">
                                        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">×</button>
                                        عملیات به شکل	<strong>موفقیت آمیز</strong> انجام شد
                                    </div>
");
#nullable restore
#line 31 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                                }

                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""alert alert-danger alert-dismissable"">
                                        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">×</button>
                                        عملیات به شکل	<strong>موفقیت آمیز</strong> انجام نشد
                                    </div>
");
#nullable restore
#line 39 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                                 


                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                             if (TempData["NotFound"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <script>
                                    setTimeout(function () {
                                        Swal.fire({
                                            position: 'top-end',
                                            icon: 'error',
                                            title: 'محصول با این مشخصات پیدا نشد!',
                                            showConfirmButton: false,
                                            timer: 3000
                                        })
                                    }, 100)

                                </script>
");
#nullable restore
#line 57 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <table class=""table table-striped dataTable no-footer"" id=""datatable-editable"" role=""grid"" aria-describedby=""datatable-editable_info"">
                                <thead>
                                    <tr role=""row"">
                                        <th>شماره</th>
                                        <th> عکس محصول</th>
                                        <th> نام فارسی</th>
                                        <th> نام انگلیسی</th>
                                        <th> تاریخ ایجاد</th>
                                        <th> حالت فعال بودن</th>
                                        <th> اورجینال بودن  </th>
                                        <th>  ثبت بررسی  </th>
                                        <th>  ثبت قیمت  </th>
                                        <th style=""width: 110px;"">فعالیت</th>
                                    </tr>
                                </thead>
                                <tbody");
            WriteLiteral(">\r\n");
#nullable restore
#line 74 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                                     if (Model.Count() > 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr class=\"gradeX odd\" role=\"row\">\r\n                                        <td class=\"sorting_1\">");
#nullable restore
#line 79 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                                                         Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"sorting_1\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "85817e9736ab39072ca1bc7c574a7819bd11575615486", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4212, "~/Site/assets/images/slider-product/", 4212, 36, true);
#nullable restore
#line 80 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
AddHtmlAttributeValue("", 4248, item.ProductImage, 4248, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                        <td class=\"sorting_1\">");
#nullable restore
#line 81 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                                                         Write(item.ProductFaName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"sorting_1\">");
#nullable restore
#line 82 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                                                         Write(item.ProductEnName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 84 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                                       Write(item.ProductCreate.ConvertDate());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <div class=\"checkbox checkbox-custom\">\r\n                                                <input");
            BeginWriteAttribute("value", " value=\"", 4809, "\"", 4831, 1);
#nullable restore
#line 88 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
WriteAttributeValue("", 4817, item.IsActive, 4817, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"checkbox\" disabled type=\"checkbox\" ");
#nullable restore
#line 88 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                                                                                                                 Write(item.IsActive ? "checked" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" />
                                                <label for=""checkbox"">

                                                </label>
                                            </div>
                                        </td>
                                        <td>
                                            <div class=""checkbox checkbox-custom"">
                                                <input");
            BeginWriteAttribute("value", " value=\"", 5325, "\"", 5349, 1);
#nullable restore
#line 96 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
WriteAttributeValue("", 5333, item.IsOriginal, 5333, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"checkbox1\" disabled type=\"checkbox\" ");
#nullable restore
#line 96 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                                                                                                                    Write(item.IsOriginal ? "checked" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@" />
                                                <label for=""checkbox1"">

                                                </label>
                                            </div>
                                        </td>
                                        <td>
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85817e9736ab39072ca1bc7c574a7819bd11575620819", async() => {
                WriteLiteral("<i class=\"fa fa-view-card\"></i> نمایش بررسی");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                                                                                  WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85817e9736ab39072ca1bc7c574a7819bd11575623291", async() => {
                WriteLiteral("<i class=\"fa fa-view-card\"></i> نمایش قیمت");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                                                                                  WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"actions\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 6315, "\"", 6390, 2);
            WriteAttributeValue("", 6322, "#showmodal=/Admin/product/ShowPropertyNameForProduct/", 6322, 53, true);
#nullable restore
#line 109 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
WriteAttributeValue("", 6375, item.ProductId, 6375, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"on-default edit-row\"><i class=\"fa fa-product-hunt\"></i></a>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85817e9736ab39072ca1bc7c574a7819bd11575626393", async() => {
                WriteLiteral("<i class=\"fa fa-pencil\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 110 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                                                                            WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 6673, "\"", 6735, 2);
            WriteAttributeValue("", 6680, "#showmodal=/Admin/product/DeleteProduct/", 6680, 40, true);
#nullable restore
#line 111 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
WriteAttributeValue("", 6720, item.ProductId, 6720, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  class=\"on-default remove-row\"><i class=\"fa fa-trash-o\"></i></a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 114 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                                            counter++;
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                                         

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr class=\"gradeX odd\" role=\"row\">\r\n                                            <td class=\"sorting_1\">  محصولی موجود نمی باشد</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 123 "D:\Projects\pro\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Product\ShowProduct.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- end: panel body -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "85817e9736ab39072ca1bc7c574a7819bd11575630772", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div> <!-- end panel -->\r\n</div> <!-- end col-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591