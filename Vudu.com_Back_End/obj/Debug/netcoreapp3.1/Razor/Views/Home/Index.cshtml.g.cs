#pragma checksum "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a34ded867660bd1a48e6605e8f73319a2da2bf1a"
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
#line 1 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\_ViewImports.cshtml"
using Vudu.com_Back_End.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\_ViewImports.cshtml"
using Vudu.com_Back_End.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
using Vudu.com_Back_End.View_models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a34ded867660bd1a48e6605e8f73319a2da2bf1a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fa0232b04d24faafd1e56c5cd7d3aaa20f77bda", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("First slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BasketAdd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Trailer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("openTrailer()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n    <div class=\"mainTop col-lg-12\">\r\n        <img src=\"assets/img/MainTop.png\"");
            BeginWriteAttribute("alt", " alt=\"", 182, "\"", 188, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <section id=\"slider\">\r\n\r\n        <div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-ride=\"carousel\">\r\n            <ol class=\"carousel-indicators  \">\r\n");
#nullable restore
#line 15 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                  
                    var count = -1;

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                     foreach (Slider item in Model.Sliders)
                    {
                        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 21 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                                                                               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></li>\r\n");
#nullable restore
#line 22 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ol>\r\n            <div class=\"carousel-inner \">\r\n");
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                  
                    var i = 0;

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                     foreach (Slider slider in Model.Sliders)
                    {
                        var sliderClass = i++ ==0 ? "slider active" : "slider";

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 1002, "\"", 1036, 2);
            WriteAttributeValue("", 1010, "carousel-item", 1010, 13, true);
#nullable restore
#line 33 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1023, sliderClass, 1024, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1070, "\"", 1077, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a34ded867660bd1a48e6605e8f73319a2da2bf1a9797", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1111, "~/assets/img/Slider/", 1111, 20, true);
#nullable restore
#line 34 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1131, slider.Image, 1131, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                        </div>\r\n");
#nullable restore
#line 36 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



            </div>
            <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                <span style=""font-size:45px;"" class=""carousel-control fa-solid fa-angle-left""
                      aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                <span style=""font-size:45px;"" class=""carousel-control fa-solid fa-angle-right""
                      aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>

    </section>


");
#nullable restore
#line 58 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
     foreach (var item in Model.IndexOptions)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <section id=""releases"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""title d-flex justify-content-between w-100"">
                        <div class=""subTitle"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 2284, "\"", 2291, 0);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 65 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                                   Write(Model.IndexOptions.FirstOrDefault(s=>s.Id==@item.Id).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n                        <div class=\"all\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2463, "\"", 2470, 0);
            EndWriteAttribute();
            WriteLiteral(">View All</a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 71 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                     foreach (MovieIndexOption movie in Model.MovieIndexOptions.FindAll(s => s.IndexOptionId==item.Id))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-2 cardReleases\">\r\n                            <div class=\"img\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2832, "\"", 2839, 0);
            EndWriteAttribute();
            WriteLiteral("><img class=\"w-100\"");
            BeginWriteAttribute("src", " src=\"", 2859, "\"", 2903, 2);
            WriteAttributeValue("", 2865, "assets/img/Releases/", 2865, 20, true);
#nullable restore
#line 75 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
WriteAttributeValue("", 2885, movie.Movie.Image, 2885, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2904, "\"", 2910, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                            </div>\r\n                            <div class=\"description\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a34ded867660bd1a48e6605e8f73319a2da2bf1a15117", async() => {
                WriteLiteral("\r\n                                    <h6 class=\"p-2\">");
#nullable restore
#line 79 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                                               Write(movie.Movie.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                    <span>\r\n                                        May 27 |\r\n");
#nullable restore
#line 82 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                                         foreach (Rating rt in Model.Ratings.Where(s => s.Id==movie.Movie.RatingId))
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                                       Write(rt.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                                                    
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        | ");
#nullable restore
#line 86 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                                     Write(movie.Movie.Length);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </span>\r\n                                    <div class=\"pl-2 check\">\r\n                                        <i class=\"fa-regular fa-circle-check\"></i><span>");
#nullable restore
#line 89 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                                                                                   Write(movie.Movie.Age);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                    </div>

                                    <div class=""icon d-flex"">
                                        <div class=""star d-flex pt-2"">
                                            <i class=""fa-solid fa-star""></i>
                                            <i class=""fa-solid fa-star""></i>
                                            <i class=""fa-solid fa-star""></i>
                                            <i class=""fa-solid fa-star""></i>
                                            <i class=""fa-solid fa-star-half-stroke""></i>
                                        </div>
                                        <div class=""faiz"">
                                            <span>");
#nullable restore
#line 101 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                                             Write(movie.Movie.RottenTomatoes);

#line default
#line hidden
#nullable disable
                WriteLiteral(" %</span>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\" plus\">\r\n");
#nullable restore
#line 105 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                                         if (User.Identity.IsAuthenticated)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a34ded867660bd1a48e6605e8f73319a2da2bf1a19087", async() => {
                    WriteLiteral("<i class=\"fa-solid fa-circle-plus\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                                                                                                WriteLiteral(movie.Movie.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 108 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a34ded867660bd1a48e6605e8f73319a2da2bf1a22026", async() => {
                    WriteLiteral("<i class=\"fa-solid fa-circle-plus\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 112 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </div>\r\n                                    <div class=\"buttonTr\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a34ded867660bd1a48e6605e8f73319a2da2bf1a23887", async() => {
                    WriteLiteral("<button>Trailer</button>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
                                                                                WriteLiteral(movie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 120 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </section>\r\n        <hr>\r\n");
#nullable restore
#line 127 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
         foreach (Advertising advr in Model.Advertisings.Where(s => s.Id==item.Id))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"advertising\">\r\n                <div class=\"container\">\r\n                    <img class=\"w-100\"");
            BeginWriteAttribute("src", " src=\"", 6071, "\"", 6108, 2);
            WriteAttributeValue("", 6077, "assets/img/Releases/", 6077, 20, true);
#nullable restore
#line 131 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
WriteAttributeValue("", 6097, advr.Image, 6097, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6109, "\"", 6115, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 134 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Views\Home\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</main>\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LayoutServices servis { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
