#pragma checksum "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8af4aaf887e00869e582991fdd27e4d5a7216009"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\_ViewImports.cshtml"
using backend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\_ViewImports.cshtml"
using backend.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8af4aaf887e00869e582991fdd27e4d5a7216009", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e404b651db9ec25e911d8077b5597c2cec1e3e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/slider_1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("First slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Third slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Second slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- main start -->
<main>
    <!-- architecture section start -->
    <div class=""row"">
        <section id=""architecture"">
            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                </ol>
                <div class=""carousel-inner"">
                    <div class=""carousel-item active"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8af4aaf887e00869e582991fdd27e4d5a72160095791", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 21 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                     foreach (var slider in Model.Sliders)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel-item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8af4aaf887e00869e582991fdd27e4d5a72160097376", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1072, "~/images/", 1072, 9, true);
#nullable restore
#line 24 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1081, slider.Url, 1081, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 26 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3 class=\"architecture-carousel-content\">");
#nullable restore
#line 27 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                                                         Write(Model.SliderSummary.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button""
                   data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button""
                   data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
        </section>
    </div>
    <!-- architecture section end -->
    <!-- buildings section start -->
    <div class=""row"">
        <section id=""buildings"">
            <div class=""buildings-summary"">
                <h1>");
#nullable restore
#line 47 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
               Write(Model.WorkSummary.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <p>");
#nullable restore
#line 48 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
              Write(Model.WorkSummary.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                <ol class=""carousel-indicators buildings-carousel-indicators"">
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                </ol>
                <div class=""carousel-inner"">
                    <div class=""carousel-item active"">
                        <div class=""buildings-card"">
");
#nullable restore
#line 59 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                             foreach (var slider in Model.WorkSliders)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"buildings-card-item\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8af4aaf887e00869e582991fdd27e4d5a721600912144", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3133, "~/images/", 3133, 9, true);
#nullable restore
#line 62 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3142, slider.Url, 3142, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <h3>");
#nullable restore
#line 63 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                                   Write(slider.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <p>");
#nullable restore
#line 64 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                                  Write(slider.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n");
#nullable restore
#line 66 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"carousel-item\">\r\n                        <div class=\"buildings-card\">\r\n");
#nullable restore
#line 71 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                             foreach (var slider in Model.WorkSliders)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"buildings-card-item\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8af4aaf887e00869e582991fdd27e4d5a721600915219", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3768, "~/images/", 3768, 9, true);
#nullable restore
#line 74 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3777, slider.Url, 3777, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <h3>");
#nullable restore
#line 76 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                                   Write(slider.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <p>");
#nullable restore
#line 77 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                                  Write(slider.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n");
#nullable restore
#line 79 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"carousel-item\">\r\n                        <div class=\"buildings-card\">\r\n");
#nullable restore
#line 84 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                             foreach (var slider in Model.WorkSliders)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"buildings-card-item\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8af4aaf887e00869e582991fdd27e4d5a721600918294", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4446, "~/images/", 4446, 9, true);
#nullable restore
#line 87 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4455, slider.Url, 4455, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <h3>");
#nullable restore
#line 88 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                                   Write(slider.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <p>");
#nullable restore
#line 89 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                                  Write(slider.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n");
#nullable restore
#line 91 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
        </section>
    </div>
    <!-- buildings section end -->
    <!-- news section start -->
    <div class=""row"">
        <section id=""news"">
            <div class=""news-testimonials-container"">
                <div class=""news"">
                    <h1 class=""news-text"">News</h1>
                    <div class=""news-item-container"">
");
#nullable restore
#line 106 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                         foreach (var news in Model.News)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"news-item\">\r\n                                <h6>");
#nullable restore
#line 109 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                               Write(news.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <a href=\"#\">\r\n                                    <h1>");
#nullable restore
#line 111 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                                   Write(news.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                                </a>\r\n                                <p>");
#nullable restore
#line 113 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                              Write(news.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <hr>\r\n");
#nullable restore
#line 116 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button>MORE NEWS</button>\r\n                    </div>\r\n                </div>\r\n                <div class=\"testimonial\">\r\n                    <h1>Testimonials</h1>\r\n                    <div class=\"testimonials-item-container\">\r\n");
#nullable restore
#line 123 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                         foreach (var testimonial in Model.Testimonials)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"testimonials-item\">\r\n                                <p id=\"text\">");
#nullable restore
#line 126 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                                        Write(testimonial.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p id=\"author\">");
#nullable restore
#line 127 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                                          Write(testimonial.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 129 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </section>
    </div>
    <!-- news section end -->
    </div>
    <hr>
    <!-- summary section start -->
    <div class=""container"">
        <div class=""row"">
            <section id=""summary"">
                <div class=""summary-container"">
");
#nullable restore
#line 143 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                     foreach (var summary in Model.Summaries)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""summary-container-item"">
                        <div class=""icon"">
                            <i class=""fa-solid fa-file-zipper""></i>
                        </div>
                        <div class=""info"">
                            <h6>");
#nullable restore
#line 150 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                           Write(summary.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <p>");
#nullable restore
#line 151 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                          Write(summary.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <a href=\"#\">");
#nullable restore
#line 152 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                                   Write(summary.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 155 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </section>\r\n        </div>\r\n    </div>\r\n    <!-- summary section end -->\r\n</main>\r\n<!-- main end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
