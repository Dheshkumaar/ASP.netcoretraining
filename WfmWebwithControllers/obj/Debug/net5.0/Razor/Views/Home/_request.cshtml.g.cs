#pragma checksum "D:\3-OCT-2022\WfmWeb\Views\Home\_request.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa798f5c699ab1275b4fe8d19c62ca5d3ac5046e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__request), @"mvc.1.0.view", @"/Views/Home/_request.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa798f5c699ab1275b4fe8d19c62ca5d3ac5046e", @"/Views/Home/_request.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8f92b0a92afd1191338f19d406198ad88563ecb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__request : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WfmWeb.Models.Softlocks>
    {
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
            WriteLiteral(@"
<div class=""modal-dialog modal-dialog-centered"">
    <div class=""modal-content"">
        <div class=""modal-header"">
            <h6 class=""modal-title"">Softlock Request Confirmation</h6>
            <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
        </div>
        <div class=""modal-body"">
            <p>Status update for request Lock</p>
");
#nullable restore
#line 11 "D:\3-OCT-2022\WfmWeb\Views\Home\_request.cshtml"
             using (Html.BeginForm("_Request", "Home", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <fieldset>\r\n                    ");
#nullable restore
#line 14 "D:\3-OCT-2022\WfmWeb\Views\Home\_request.cshtml"
               Write(Html.HiddenFor(m => m.lockid, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 16 "D:\3-OCT-2022\WfmWeb\Views\Home\_request.cshtml"
                   Write(Html.HiddenFor(m => m.employee_id, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <h6>Employee ID:</h6><p>");
#nullable restore
#line 17 "D:\3-OCT-2022\WfmWeb\Views\Home\_request.cshtml"
                                           Write(Model.employee_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <h6>Employee Manager:</h6><p>");
#nullable restore
#line 20 "D:\3-OCT-2022\WfmWeb\Views\Home\_request.cshtml"
                                                Write(Model.manager);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <h6>Request Message:</h6><p>");
#nullable restore
#line 23 "D:\3-OCT-2022\WfmWeb\Views\Home\_request.cshtml"
                                               Write(Model.requestmessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <h6>Manager Status:</h6>\r\n                        <select id=\"managerstatus\" name=\"managerstatus\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa798f5c699ab1275b4fe8d19c62ca5d3ac5046e5538", async() => {
                WriteLiteral("accepted");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa798f5c699ab1275b4fe8d19c62ca5d3ac5046e6526", async() => {
                WriteLiteral("Rejected");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-sm btn-outline-secondary"" data-dismiss=""modal"">Cancel</button>
                        <button type=""Submit"" class=""btn btn-sm btn-outline-primary"">Send request</button>
                    </div>
                </fieldset>
");
#nullable restore
#line 37 "D:\3-OCT-2022\WfmWeb\Views\Home\_request.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"modal-footer\">\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 45 "D:\3-OCT-2022\WfmWeb\Views\Home\_request.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WfmWeb.Models.Softlocks> Html { get; private set; }
    }
}
#pragma warning restore 1591
