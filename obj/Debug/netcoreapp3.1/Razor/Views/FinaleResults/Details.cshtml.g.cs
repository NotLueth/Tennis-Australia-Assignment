#pragma checksum "C:\Users\user\source\repos\TennisAustraliaAssignment\Views\FinaleResults\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81cc24c78d02afa02c6f39cd907a9befaa18ac1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FinaleResults_Details), @"mvc.1.0.view", @"/Views/FinaleResults/Details.cshtml")]
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
#line 1 "C:\Users\user\source\repos\TennisAustraliaAssignment\Views\_ViewImports.cshtml"
using TennisAustraliaAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\TennisAustraliaAssignment\Views\_ViewImports.cshtml"
using TennisAustraliaAssignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81cc24c78d02afa02c6f39cd907a9befaa18ac1f", @"/Views/FinaleResults/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9380225f083c4bc01e8a25ad01ce823f9130c22b", @"/Views/_ViewImports.cshtml")]
    public class Views_FinaleResults_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TennisAustraliaAssignment.Models.FinaleResult>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\source\repos\TennisAustraliaAssignment\Views\FinaleResults\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Header of Page -->\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <!-- Header of area -->\r\n    <h4>FinaleResult</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <!-- Column Name -->\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\user\source\repos\TennisAustraliaAssignment\Views\FinaleResults\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Match));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <!-- Information of Column -->\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\user\source\repos\TennisAustraliaAssignment\Views\FinaleResults\Details.cshtml"
       Write(Html.DisplayFor(model => model.Match.Round));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <!-- Column Name -->\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "C:\Users\user\source\repos\TennisAustraliaAssignment\Views\FinaleResults\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WinRegistrationID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <!-- Information of Column -->\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\user\source\repos\TennisAustraliaAssignment\Views\FinaleResults\Details.cshtml"
       Write(Html.DisplayFor(model => model.WinRegistrationID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <!-- Column Name -->\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\user\source\repos\TennisAustraliaAssignment\Views\FinaleResults\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WinRegistrationFinaleScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <!-- Information of Column -->\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\user\source\repos\TennisAustraliaAssignment\Views\FinaleResults\Details.cshtml"
       Write(Html.DisplayFor(model => model.WinRegistrationFinaleScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <!-- Column Name -->\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\user\source\repos\TennisAustraliaAssignment\Views\FinaleResults\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SecondRegistrationID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <!-- Information of Column -->\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Users\user\source\repos\TennisAustraliaAssignment\Views\FinaleResults\Details.cshtml"
       Write(Html.DisplayFor(model => model.SecondRegistrationID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <!-- Column Name -->\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 48 "C:\Users\user\source\repos\TennisAustraliaAssignment\Views\FinaleResults\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SecondPlayerScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <!-- Information of Column -->\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "C:\Users\user\source\repos\TennisAustraliaAssignment\Views\FinaleResults\Details.cshtml"
       Write(Html.DisplayFor(model => model.SecondPlayerScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <!-- Column Name -->\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\user\source\repos\TennisAustraliaAssignment\Views\FinaleResults\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SetsPlayed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <!-- Information of Column -->\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\user\source\repos\TennisAustraliaAssignment\Views\FinaleResults\Details.cshtml"
       Write(Html.DisplayFor(model => model.SetsPlayed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81cc24c78d02afa02c6f39cd907a9befaa18ac1f8689", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\user\source\repos\TennisAustraliaAssignment\Views\FinaleResults\Details.cshtml"
                           WriteLiteral(Model.FinaleResultID);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81cc24c78d02afa02c6f39cd907a9befaa18ac1f10851", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TennisAustraliaAssignment.Models.FinaleResult> Html { get; private set; }
    }
}
#pragma warning restore 1591
