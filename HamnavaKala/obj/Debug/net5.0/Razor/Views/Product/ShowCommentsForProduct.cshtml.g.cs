#pragma checksum "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowCommentsForProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b6b4be4ca51d4c14e5ebd581bafac0d843016e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowCommentsForProduct), @"mvc.1.0.view", @"/Views/Product/ShowCommentsForProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b6b4be4ca51d4c14e5ebd581bafac0d843016e0", @"/Views/Product/ShowCommentsForProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"095e940bf288069610f4a0a0c5275406d43bce51", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowCommentsForProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CommentsForProductViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowCommentsForProduct.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""comments"">
    <h2 class=""params-headline"">
        امتیاز کاربران به
        <span>Samsung Galaxy Note 10 Dual SIM 256GB Mobile Phone</span>
    </h2>
    <div class=""comments-summary"">
        <div class=""col-lg-6 col-md-6 col-xs-12 pr"">
            <div class=""comments-summary-box"">
                <ul class=""comments-item-rating"">
                    <li>
                        <span class=""cell-title"">کیفیت ساخت:</span>
                        <span class=""cell-value"">خوب</span>
                        <div class=""rating-general"">
                            <div class=""rating-value""></div>
                        </div>
                    </li>
                    <li>
                        <span class=""cell-title"">ارزش خرید به نسبت قیمت:</span>
                        <span class=""cell-value"">خوب</span>
                        <div class=""rating-general"">
                            <div class=""rating-value""></div>
                        </div>
                 ");
            WriteLiteral(@"   </li>
                    <li>
                        <span class=""cell-title"">نوآوری:</span>
                        <span class=""cell-value"">خوب</span>
                        <div class=""rating-general"">
                            <div class=""rating-value"" style=""width: 70%;""></div>
                        </div>
                    </li>
                    <li>
                        <span class=""cell-title"">امکانات و قابلیت ها:</span>
                        <span class=""cell-value"">متوسط</span>
                        <div class=""rating-general"">
                            <div class=""rating-value"" style=""width: 65%;""></div>
                        </div>
                    </li>
                    <li>
                        <span class=""cell-title"">سهولت استفاده:</span>
                        <span class=""cell-value"">خوب</span>
                        <div class=""rating-general"">
                            <div class=""rating-value"" style=""width: 75%;""></div>
          ");
            WriteLiteral(@"              </div>
                    </li>
                    <li>
                        <span class=""cell-title"">طراحی و ظاهر:</span>
                        <span class=""cell-value"">خوب</span>
                        <div class=""rating-general"">
                            <div class=""rating-value""></div>
                        </div>
                    </li>
                </ul>
            </div>
        </div>
        <div class=""col-lg-6 col-md-6 col-xs-12 pr"">
            <div class=""comments-summary-note"">
                <h6>شما هم می‌توانید در مورد این کالا نظر بدهید.</h6>
                <p>
                    برای ثبت نظر، لازم است ابتدا وارد حساب کاربری خود شوید. اگر این محصول را قبلا از دیجی‌کالا خریده باشید،
                    نظر
                    شما به عنوان مالک محصول ثبت خواهد شد.
                </p>
                <a href=""#"" class=""btn-add-comment btn btn-secondary"">افزودن نظر جدید</a>
            </div>
        </div>

        <div class=""product-");
            WriteLiteral("comment-list\">\r\n            <ul class=\"comment-list\">\r\n");
#nullable restore
#line 74 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowCommentsForProduct.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <div class=\"col-lg-3 pr\">\r\n                            <section>\r\n                                <div class=\"comments-user-shopping\">\r\n                                    ");
#nullable restore
#line 80 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowCommentsForProduct.cshtml"
                               Write(item.userfullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"cell-date\">\r\n                                        ");
#nullable restore
#line 82 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowCommentsForProduct.cshtml"
                                   Write(item.CreateCommentdate.ConvertDate());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 84 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowCommentsForProduct.cshtml"
                                     switch (item.IslikeProduct)
                                    {
                                        case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""message-light"" style=""background-color:#fff9f2;color:#dd7e19;"">
                                                <i class=""fa fa-thumbs-o-up"">
                                                </i>خرید این محصول را توصیه می‌کنم
                                            </div>
");
#nullable restore
#line 91 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowCommentsForProduct.cshtml"
                                            break;
                                        case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""message-light"" style=""background-color:#fff9f2;color:#dd7e19;"">
                                                <i class=""fa fa-thumbs-o-up"">
                                                </i>در مورد خرید این محصول مطمین نیستم
                                            </div>
");
#nullable restore
#line 97 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowCommentsForProduct.cshtml"
                                            break;
                                        case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""message-light"" style=""background-color:#fff9f2;color:#dd7e19;"">
                                                <i class=""fa fa-thumbs-o-down"">
                                                </i>خرید این محصول را توصیه نمی‌کنم
                                            </div>
");
#nullable restore
#line 103 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowCommentsForProduct.cshtml"
                                            break;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </section>
                        </div>
                        <div class=""col-lg-9 pl"">
                            <div class=""article"">
                                <ul class=""comment-text"">
                                    <div class=""header"">
                                        <div>");
#nullable restore
#line 113 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowCommentsForProduct.cshtml"
                                        Write(item.commentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                       \r\n                                        <p>");
#nullable restore
#line 115 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowCommentsForProduct.cshtml"
                                      Write(Html.Raw(item.CommentDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"!</p>
                                    </div>
                                    <div class=""comments-evaluation"">
                                      
                                        <div class=""footer"">
                                            <div class=""comments-likes"">
                                                آیا این نظر برایتان مفید بود؟
                                                <button class=""btn-like js-comment-like"" type=""submit"">
                                                    بله
                                                    <span class=""count"">");
#nullable restore
#line 124 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowCommentsForProduct.cshtml"
                                                                   Write(item.CommentLike);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                </button>
                                                <button class=""btn-like js-comment-dislike"" type=""submit"">
                                                    خیر
                                                    <span class=""count"">");
#nullable restore
#line 128 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowCommentsForProduct.cshtml"
                                                                   Write(item.CommentDislike);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                </button>
                                            </div>
                                        </div>
                                    </div>
                                </ul>
                            </div>
                        </div>
                    </li>
");
#nullable restore
#line 137 "D:\My Lessons\AspNet Core\Git and GitHub\Git\Onlie_Shopping\HamnavaKala\Views\Product\ShowCommentsForProduct.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CommentsForProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
