#pragma checksum "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "851d4fb82057df3944603cba945b1d4753bd469b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_ShowAllSubCategory), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/ShowAllSubCategory.cshtml")]
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
#line 3 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\_ViewImports.cshtml"
using HamnavaKala.DataLayer.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\_ViewImports.cshtml"
using HamnavaKala.Core.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\_ViewImports.cshtml"
using HamnavaKala.Core.Classes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"851d4fb82057df3944603cba945b1d4753bd469b", @"/Areas/Admin/Views/Category/ShowAllSubCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"397e92ca8624df7ee11a13a28e560d49209981fb", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_ShowAllSubCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary waves-effect waves-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowAllSubsubCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MainModal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
  
    ViewData["Title"] = "?????????? ?????? ???????? ???????? ????";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    int counter = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-sm-12\">\r\n    <div class=\"panel\">\r\n        <div class=\"panel-body\" style=\"margin-top:100px\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"m-b-30\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "851d4fb82057df3944603cba945b1d4753bd469b6278", async() => {
                WriteLiteral("???????????? <i class=\"fa fa-plus\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
                                                                                WriteLiteral(ViewBag.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 23 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
                             if (TempData["Result"] != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
                                 if (TempData["Result"].ToString() == "true")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""alert alert-info alert-dismissable"">
                                        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">??</button>
                                        ???????????? ???? ??????	<strong>???????????? ????????</strong> ?????????? ????
                                    </div>
");
#nullable restore
#line 31 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
                                }

                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""alert alert-danger alert-dismissable"">
                                        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">??</button>
                                        ???????????? ???? ??????	<strong>???????????? ????????</strong> ?????????? ??????
                                    </div>
");
#nullable restore
#line 39 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
                                 


                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
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
                                            title: '???????????? ???? ?????? ???????????? ???????? ??????!',
                                            showConfirmButton: false,
                                            timer: 3000
                                        })
                                    }, 100)

                                </script>
");
#nullable restore
#line 57 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <table class=""table table-striped dataTable no-footer"" id=""datatable-editable"" role=""grid"" aria-describedby=""datatable-editable_info"">
                                <thead>
                                    <tr role=""row"">
                                        <th class=""sorting_asc"" tabindex=""0"" aria-controls=""datatable-editable"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""?????????? ??????????: activate to sort column descending"">??????????</th>
                                        <th class=""sorting_asc"" tabindex=""0"" aria-controls=""datatable-editable"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""?????????? ??????????: activate to sort column descending"">?????? ?????????? ???????? ????????</th>
                                        <th class=""sorting_asc"" tabindex=""0"" aria-controls=""datatable-editable"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""?????????? ??????????: activate to sort column descending""> ?????? ?????????????? ???????? ????????</th>
                                        <t");
            WriteLiteral(@"h class=""sorting_asc"" tabindex=""0"" aria-controls=""datatable-editable"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""?????????? ??????????: activate to sort column descending"">?????? ???????? </th>
                                        <th class=""sorting_disabled"" rowspan=""1"" colspan=""1"" aria-label=""????????????"" style=""width: 110px;"">????????????</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 69 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
                                     if (Model.Count() > 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr class=\"gradeX odd\" role=\"row\">\r\n                                                <td class=\"sorting_1\">");
#nullable restore
#line 74 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
                                                                 Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td class=\"sorting_1\">");
#nullable restore
#line 75 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
                                                                 Write(item.CategoryFaName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td class=\"sorting_1\">");
#nullable restore
#line 76 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
                                                                 Write(item.CategoryEnName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td class=\"sorting_1\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "851d4fb82057df3944603cba945b1d4753bd469b16356", async() => {
                WriteLiteral("?????? ???????? ???? ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
                                                                                                                                        WriteLiteral(item.CategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                                <td class=\"actions\">\r\n\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 5168, "\"", 5233, 2);
            WriteAttributeValue("", 5175, "#showmodal=/Admin/category/UpdateCategory/", 5175, 42, true);
#nullable restore
#line 80 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
WriteAttributeValue("", 5217, item.CategoryId, 5217, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"on-default edit-row\"><i class=\"fa fa-pencil\"></i></a>\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 5351, "\"", 5416, 2);
            WriteAttributeValue("", 5358, "#showmodal=/Admin/category/DeleteCategory/", 5358, 42, true);
#nullable restore
#line 81 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
WriteAttributeValue("", 5400, item.CategoryId, 5400, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"on-default remove-row\"><i class=\"fa fa-trash-o\"></i></a>\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 84 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
                                            counter++;
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
                                         

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr class=\"gradeX odd\" role=\"row\">\r\n                                            <td class=\"sorting_1\">???????? ???????? ?????????? ?????? ????????</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 93 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Areas\Admin\Views\Category\ShowAllSubCategory.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- end: panel body -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "851d4fb82057df3944603cba945b1d4753bd469b21914", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
