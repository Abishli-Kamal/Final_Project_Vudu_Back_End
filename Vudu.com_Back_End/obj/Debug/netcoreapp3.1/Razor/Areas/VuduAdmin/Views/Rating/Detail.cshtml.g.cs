#pragma checksum "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Areas\VuduAdmin\Views\Rating\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9616fade06d803ced42497a33d52b91a4d66ada4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_VuduAdmin_Views_Rating_Detail), @"mvc.1.0.view", @"/Areas/VuduAdmin/Views/Rating/Detail.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Areas\VuduAdmin\Views\_ViewImports.cshtml"
using Vudu.com_Back_End.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Areas\VuduAdmin\Views\_ViewImports.cshtml"
using Vudu.com_Back_End.View_models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9616fade06d803ced42497a33d52b91a4d66ada4", @"/Areas/VuduAdmin/Views/Rating/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cdcb545d8483492c3e592291d211f610dd9c1cd", @"/Areas/VuduAdmin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_VuduAdmin_Views_Rating_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rating>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Areas\VuduAdmin\Views\Rating\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-warning mt-5\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th scope=\"col\">Id</th>\r\n            <th scope=\"col\">Name</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n\r\n            <td>");
#nullable restore
#line 17 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Areas\VuduAdmin\Views\Rating\Detail.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Areas\VuduAdmin\Views\Rating\Detail.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n</table>");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rating> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
