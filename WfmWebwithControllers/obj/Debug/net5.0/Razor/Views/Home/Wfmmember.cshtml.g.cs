#pragma checksum "D:\3-OCT-2022\WfmWeb\Views\Home\Wfmmember.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c16a34f3744d9ce4c190cf10ac85155fc6698a0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Wfmmember), @"mvc.1.0.view", @"/Views/Home/Wfmmember.cshtml")]
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
#line 1 "D:\3-OCT-2022\WfmWeb\Views\_ViewImports.cshtml"
using WfmWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\3-OCT-2022\WfmWeb\Views\_ViewImports.cshtml"
using WfmWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c16a34f3744d9ce4c190cf10ac85155fc6698a0d", @"/Views/Home/Wfmmember.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8f92b0a92afd1191338f19d406198ad88563ecb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Wfmmember : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WfmWeb.Models.Softlocks>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\3-OCT-2022\WfmWeb\Views\Home\Wfmmember.cshtml"
  
    ViewData["Title"] = "Wfmmember";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"align-middle\">WFMmember Screen</h1>\r\n\r\n<table class=\"table align-middle mb-0 bg-white\">\r\n    <thead class=\"bg-light\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\3-OCT-2022\WfmWeb\Views\Home\Wfmmember.cshtml"
           Write(Html.DisplayNameFor(model => model.employee_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\3-OCT-2022\WfmWeb\Views\Home\Wfmmember.cshtml"
           Write(Html.DisplayNameFor(model => model.manager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\3-OCT-2022\WfmWeb\Views\Home\Wfmmember.cshtml"
           Write(Html.DisplayNameFor(model => model.reqdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\3-OCT-2022\WfmWeb\Views\Home\Wfmmember.cshtml"
           Write(Html.DisplayNameFor(model => model.requestmessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "D:\3-OCT-2022\WfmWeb\Views\Home\Wfmmember.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "D:\3-OCT-2022\WfmWeb\Views\Home\Wfmmember.cshtml"
           Write(Html.DisplayFor(modelItem => item.employee_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "D:\3-OCT-2022\WfmWeb\Views\Home\Wfmmember.cshtml"
           Write(Html.DisplayFor(modelItem => item.manager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\3-OCT-2022\WfmWeb\Views\Home\Wfmmember.cshtml"
           Write(Html.DisplayFor(modelItem => item.reqdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\3-OCT-2022\WfmWeb\Views\Home\Wfmmember.cshtml"
           Write(Html.DisplayFor(modelItem => item.requestmessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                <button type=\"button\" class=\"btn btn-outline-primary\"\r\n                        data-url=\'");
#nullable restore
#line 45 "D:\3-OCT-2022\WfmWeb\Views\Home\Wfmmember.cshtml"
                             Write(Url.ActionLink("_request","Home",item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'>\r\n                    View Details\r\n                </button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 50 "D:\3-OCT-2022\WfmWeb\Views\Home\Wfmmember.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<div class=""modal fade"" id=""Modal"" role=""dialog"" ></div>

<script>
    $('.btn-outline-primary').click(function () {
        var url = $(this).data('url');
        console.log(url);
        $.get(url, function (data) {
            $(""#Modal"").html(data);
            $(""#Modal"").modal('show');
        });
    });
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WfmWeb.Models.Softlocks>> Html { get; private set; }
    }
}
#pragma warning restore 1591