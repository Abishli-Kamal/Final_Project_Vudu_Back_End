#pragma checksum "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Areas\VuduAdmin\Views\Setting\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00eaa457007b1e2ba54190c82cd0138d55690486"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_VuduAdmin_Views_Setting_Detail), @"mvc.1.0.view", @"/Areas/VuduAdmin/Views/Setting/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00eaa457007b1e2ba54190c82cd0138d55690486", @"/Areas/VuduAdmin/Views/Setting/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cdcb545d8483492c3e592291d211f610dd9c1cd", @"/Areas/VuduAdmin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_VuduAdmin_Views_Setting_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Setting>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Areas\VuduAdmin\Views\Setting\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-warning mt-5"">
    <thead>
        <tr>

            <th scope=""col"">Id</th>
            <th scope=""col"">Key</th>
            <th scope=""col"">Value</th>
        </tr>
    </thead>
    <tbody>
        <tr>

            <td>");
#nullable restore
#line 18 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Areas\VuduAdmin\Views\Setting\Detail.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Areas\VuduAdmin\Views\Setting\Detail.cshtml"
           Write(Model.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\ASUS\Desktop\Vudu.com_Back_End\Vudu.com_Back_End\Areas\VuduAdmin\Views\Setting\Detail.cshtml"
           Write(Model.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Setting> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
