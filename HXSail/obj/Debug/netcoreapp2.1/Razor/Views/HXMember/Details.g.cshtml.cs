#pragma checksum "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dc0439a5e1b53bedd292565cdd8ccaca808c9a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HXMember_Details), @"mvc.1.0.view", @"/Views/HXMember/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HXMember/Details.cshtml", typeof(AspNetCore.Views_HXMember_Details))]
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
#line 1 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\_ViewImports.cshtml"
using HXSail;

#line default
#line hidden
#line 2 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\_ViewImports.cshtml"
using HXSail.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dc0439a5e1b53bedd292565cdd8ccaca808c9a7", @"/Views/HXMember/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b58746aec14db7b770e0f64807324d41aa4aa932", @"/Views/_ViewImports.cshtml")]
    public class Views_HXMember_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HXSail.Models.Member>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
  
    ViewData["Title"] = "Details of " + TempData["fullName"];

#line default
#line hidden
            BeginContext(101, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Member</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(222, 45, false);
#line 14 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(267, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(311, 41, false);
#line 17 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(352, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(396, 44, false);
#line 20 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(440, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(484, 40, false);
#line 23 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(524, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(568, 51, false);
#line 26 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SpouseFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(619, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(663, 47, false);
#line 29 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.SpouseFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(710, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(754, 50, false);
#line 32 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SpouseLastName));

#line default
#line hidden
            EndContext();
            BeginContext(804, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(848, 46, false);
#line 35 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.SpouseLastName));

#line default
#line hidden
            EndContext();
            BeginContext(894, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(938, 42, false);
#line 38 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Street));

#line default
#line hidden
            EndContext();
            BeginContext(980, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1024, 38, false);
#line 41 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.Street));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1106, 40, false);
#line 44 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1190, 36, false);
#line 47 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1270, 46, false);
#line 50 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1316, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1360, 42, false);
#line 53 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1402, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1446, 45, false);
#line 56 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1491, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1535, 41, false);
#line 59 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1576, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1620, 41, false);
#line 62 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1661, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1705, 37, false);
#line 65 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1742, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1786, 46, false);
#line 68 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YearJoined));

#line default
#line hidden
            EndContext();
            BeginContext(1832, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1876, 42, false);
#line 71 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.YearJoined));

#line default
#line hidden
            EndContext();
            BeginContext(1918, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1962, 43, false);
#line 74 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(2005, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2049, 39, false);
#line 77 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(2088, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2132, 46, false);
#line 80 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TaskExempt));

#line default
#line hidden
            EndContext();
            BeginContext(2178, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2222, 42, false);
#line 83 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.TaskExempt));

#line default
#line hidden
            EndContext();
            BeginContext(2264, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2308, 49, false);
#line 86 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UseCanadaPost));

#line default
#line hidden
            EndContext();
            BeginContext(2357, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2401, 45, false);
#line 89 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.UseCanadaPost));

#line default
#line hidden
            EndContext();
            BeginContext(2446, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2490, 58, false);
#line 92 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProvinceCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2548, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2592, 67, false);
#line 95 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProvinceCodeNavigation.ProvinceCode));

#line default
#line hidden
            EndContext();
            BeginContext(2659, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2706, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d194c3ec96234ae88f43f7c891bf8a17", async() => {
                BeginContext(2758, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 100 "C:\Users\billx\Desktop\PROG 2230\HXSail\HXSail\Views\HXMember\Details.cshtml"
                           WriteLiteral(Model.MemberId);

#line default
#line hidden
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
            EndContext();
            BeginContext(2766, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2774, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "384ca6cd8a424e23a6edb0bbfd06a458", async() => {
                BeginContext(2796, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(2812, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HXSail.Models.Member> Html { get; private set; }
    }
}
#pragma warning restore 1591
