#pragma checksum "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\Games\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b179206a5390f08261f0b88fe1b09ff732d52323"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_Index), @"mvc.1.0.view", @"/Views/Games/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Games/Index.cshtml", typeof(AspNetCore.Views_Games_Index))]
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
#line 1 "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\_ViewImports.cshtml"
using GameWebApp;

#line default
#line hidden
#line 2 "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\_ViewImports.cshtml"
using GameWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b179206a5390f08261f0b88fe1b09ff732d52323", @"/Views/Games/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d340887167c8b63f4fc13f00010245399e6ca32f", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GameWebApp.Models.Game>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\Games\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(87, 20, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\Games\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(147, 9, true);
            WriteLiteral("<p>\r\n    ");
            EndContext();
            BeginContext(156, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b179206a5390f08261f0b88fe1b09ff732d523235200", async() => {
                BeginContext(179, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(193, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
#line 14 "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\Games\Index.cshtml"
}

#line default
#line hidden
            BeginContext(204, 84, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(289, 44, false);
#line 19 "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\Games\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GameName));

#line default
#line hidden
            EndContext();
            BeginContext(333, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(389, 47, false);
#line 22 "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\Games\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(436, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(492, 47, false);
#line 25 "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\Games\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GameCreator));

#line default
#line hidden
            EndContext();
            BeginContext(539, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\Games\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(657, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(706, 43, false);
#line 34 "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\Games\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GameName));

#line default
#line hidden
            EndContext();
            BeginContext(749, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(805, 46, false);
#line 37 "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\Games\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(851, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(907, 56, false);
#line 40 "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\Games\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GameCreator.CreatorId));

#line default
#line hidden
            EndContext();
            BeginContext(963, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 42 "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\Games\Index.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
            BeginContext(1048, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(1090, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b179206a5390f08261f0b88fe1b09ff732d5232310499", async() => {
                BeginContext(1139, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\Games\Index.cshtml"
                                           WriteLiteral(item.GameId);

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
            BeginContext(1147, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1171, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b179206a5390f08261f0b88fe1b09ff732d5232312904", async() => {
                BeginContext(1228, 9, true);
                WriteLiteral(" Details ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\Games\Index.cshtml"
                                                  WriteLiteral(item.GameId);

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
            BeginContext(1241, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1265, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b179206a5390f08261f0b88fe1b09ff732d5232315321", async() => {
                BeginContext(1321, 8, true);
                WriteLiteral(" Delete ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\Games\Index.cshtml"
                                                 WriteLiteral(item.GameId);

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
            BeginContext(1333, 47, true);
            WriteLiteral("\r\n                    \r\n                </td>\r\n");
            EndContext();
#line 50 "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\Games\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1395, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 52 "C:\Users\16475\Desktop\GameWebApp.MokshKhanna\GameWebApp.MokshKhanna\GameWebApp\GameWebApp\GameWebApp\Views\Games\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1417, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GameWebApp.Models.Game>> Html { get; private set; }
    }
}
#pragma warning restore 1591