#pragma checksum "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c094ec94fd8f5e2a0a3ca58c2963dc5357063f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetUser), @"mvc.1.0.view", @"/Views/User/GetUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/GetUser.cshtml", typeof(AspNetCore.Views_User_GetUser))]
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
#line 1 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\_ViewImports.cshtml"
using WebClient;

#line default
#line hidden
#line 2 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c094ec94fd8f5e2a0a3ca58c2963dc5357063f7", @"/Views/User/GetUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eabcf7e030352eff2473b217adffa5ad5752fa", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebClient.Models.Users>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
  
    ViewData["Title"] = "GetUser";

#line default
#line hidden
            BeginContext(76, 119, true);
            WriteLiteral("\r\n<h2>GetUser</h2>\r\n\r\n<div>\r\n    <h4>Users</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(196, 44, false);
#line 14 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(240, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(284, 40, false);
#line 17 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(324, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(368, 45, false);
#line 20 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserEmail));

#line default
#line hidden
            EndContext();
            BeginContext(413, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(457, 41, false);
#line 23 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayFor(model => model.UserEmail));

#line default
#line hidden
            EndContext();
            BeginContext(498, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(542, 48, false);
#line 26 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserPassword));

#line default
#line hidden
            EndContext();
            BeginContext(590, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(634, 44, false);
#line 29 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayFor(model => model.UserPassword));

#line default
#line hidden
            EndContext();
            BeginContext(678, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(722, 55, false);
#line 32 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(777, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(821, 51, false);
#line 35 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayFor(model => model.UserConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(872, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(916, 45, false);
#line 38 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserPhone));

#line default
#line hidden
            EndContext();
            BeginContext(961, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1005, 41, false);
#line 41 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayFor(model => model.UserPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1046, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1090, 47, false);
#line 44 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1137, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1181, 43, false);
#line 47 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayFor(model => model.UserAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1268, 50, false);
#line 50 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserActiveCode));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1362, 46, false);
#line 53 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayFor(model => model.UserActiveCode));

#line default
#line hidden
            EndContext();
            BeginContext(1408, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1452, 48, false);
#line 56 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserIsActive));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1544, 44, false);
#line 59 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayFor(model => model.UserIsActive));

#line default
#line hidden
            EndContext();
            BeginContext(1588, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1632, 38, false);
#line 62 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1670, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1714, 34, false);
#line 65 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1748, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1792, 48, false);
#line 68 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayNameFor(model => model.RegisterDate));

#line default
#line hidden
            EndContext();
            BeginContext(1840, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1884, 44, false);
#line 71 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayFor(model => model.RegisterDate));

#line default
#line hidden
            EndContext();
            BeginContext(1928, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1972, 52, false);
#line 74 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayNameFor(model => model.MotificationDate));

#line default
#line hidden
            EndContext();
            BeginContext(2024, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2068, 48, false);
#line 77 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
       Write(Html.DisplayFor(model => model.MotificationDate));

#line default
#line hidden
            EndContext();
            BeginContext(2116, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2164, 68, false);
#line 82 "D:\Project\MVCProject\EShopWebAPI\WebClient\Views\User\GetUser.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2232, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2240, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7601acd6a9b4406a835a510e46b5ab44", async() => {
                BeginContext(2262, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2278, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebClient.Models.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
