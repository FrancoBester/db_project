#pragma checksum "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67fed310b33137cfded1bc4fde5202293ef448ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
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
#line 1 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\_ViewImports.cshtml"
using NeonTrees;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\_ViewImports.cshtml"
using NeonTrees.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67fed310b33137cfded1bc4fde5202293ef448ac", @"/Views/Items/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a233dd4d465801631d196157b503be1fcdde2ed7", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NeonTrees.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
   ViewData["Title"] = "Items"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    fieldset {
        flex: 1;
        background-color: #cccccc;
        box-shadow: #000000 5px 5px 5px 10px;
        width: 90%;
        height: 100%;
        margin-top: 30px;
        margin-bottom: 20px;
        padding: 15px;
    }
</style>
<fieldset>
    <h1>");
#nullable restore
#line 17 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n    <p> This is the page for mother stuff <P>\n\n    <p>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67fed310b33137cfded1bc4fde5202293ef448ac5197", async() => {
                WriteLiteral("View Build");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </p>\n\n    <div>\n\n        <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 531, "", 640, 1);
#nullable restore
#line 27 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 540, Html.ActionLink("Case", "Index", new { sortOrder = "Case", currentFilter = ViewBag.CurrentFilter }), 540, 100, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 668, "", 775, 1);
#nullable restore
#line 28 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 677, Html.ActionLink("CPU", "Index", new { sortOrder = "CPU", currentFilter = ViewBag.CurrentFilter }), 677, 98, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 803, "", 910, 1);
#nullable restore
#line 29 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 812, Html.ActionLink("GPU", "Index", new { sortOrder = "GPU", currentFilter = ViewBag.CurrentFilter }), 812, 98, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n          <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 937, "", 1060, 1);
#nullable restore
#line 30 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 946, Html.ActionLink("Motherboard", "Index", new { sortOrder = "Motherboard", currentFilter = ViewBag.CurrentFilter }), 946, 114, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 1088, "", 1195, 1);
#nullable restore
#line 31 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 1097, Html.ActionLink("Ram", "Index", new { sortOrder = "Ram", currentFilter = ViewBag.CurrentFilter }), 1097, 98, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 1223, "", 1338, 1);
#nullable restore
#line 32 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 1232, Html.ActionLink("Storage", "Index", new { sortOrder = "Storage", currentFilter = ViewBag.CurrentFilter }), 1232, 106, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 1366, "", 1477, 1);
#nullable restore
#line 33 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 1375, Html.ActionLink("Chair", "Index", new { sortOrder = "Chair", currentFilter = ViewBag.CurrentFilter }), 1375, 102, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 1505, "", 1622, 1);
#nullable restore
#line 34 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 1514, Html.ActionLink("MousePad", "Index", new { sortOrder = "MousePad", currentFilter = ViewBag.CurrentFilter }), 1514, 108, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 1650, "", 1765, 1);
#nullable restore
#line 35 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 1659, Html.ActionLink("Headset", "Index", new { sortOrder = "Headset", currentFilter = ViewBag.CurrentFilter }), 1659, 106, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 1793, "", 1918, 1);
#nullable restore
#line 36 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 1802, Html.ActionLink("Gaming Combo", "Index", new { sortOrder = "Gaming Combo", currentFilter = ViewBag.CurrentFilter }), 1802, 116, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 1946, "", 2067, 1);
#nullable restore
#line 37 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 1955, Html.ActionLink("Wrist Rest", "Index", new { sortOrder = "Wrist Rest", currentFilter = ViewBag.CurrentFilter }), 1955, 112, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 2095, "", 2222, 1);
#nullable restore
#line 38 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 2104, Html.ActionLink("Network Cable", "Index", new { sortOrder = "Network Cable", currentFilter = ViewBag.CurrentFilter }), 2104, 118, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 2250, "", 2363, 1);
#nullable restore
#line 39 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 2259, Html.ActionLink("Switch", "Index", new { sortOrder = "Switch", currentFilter = ViewBag.CurrentFilter }), 2259, 104, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 2391, "", 2514, 1);
#nullable restore
#line 40 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 2400, Html.ActionLink("Workstation", "Index", new { sortOrder = "Workstation", currentFilter = ViewBag.CurrentFilter }), 2400, 114, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 2542, "", 2663, 1);
#nullable restore
#line 41 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 2551, Html.ActionLink("UpgradeKit", "Index", new { sortOrder = "UpgradeKit", currentFilter = ViewBag.CurrentFilter }), 2551, 112, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 2691, "", 2808, 1);
#nullable restore
#line 42 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 2700, Html.ActionLink("Speakers", "Index", new { sortOrder = "Speakers", currentFilter = ViewBag.CurrentFilter }), 2700, 108, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 2836, "", 2951, 1);
#nullable restore
#line 43 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 2845, Html.ActionLink("Adapter", "Index", new { sortOrder = "Adapter", currentFilter = ViewBag.CurrentFilter }), 2845, 106, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 2979, "", 3090, 1);
#nullable restore
#line 44 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 2988, Html.ActionLink("Mouse", "Index", new { sortOrder = "Mouse", currentFilter = ViewBag.CurrentFilter }), 2988, 102, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 3118, "", 3231, 1);
#nullable restore
#line 45 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 3127, Html.ActionLink("Keycap", "Index", new { sortOrder = "Keycap", currentFilter = ViewBag.CurrentFilter }), 3127, 104, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 3259, "", 3372, 1);
#nullable restore
#line 46 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 3268, Html.ActionLink("NVLink", "Index", new { sortOrder = "NVLink", currentFilter = ViewBag.CurrentFilter }), 3268, 104, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 3400, "", 3541, 1);
#nullable restore
#line 47 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 3409, Html.ActionLink("Mouse Keyboard combo", "Index", new { sortOrder = "Mouse Keyboard combo", currentFilter = ViewBag.CurrentFilter }), 3409, 132, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n           <a id=\"btn1\"");
            BeginWriteAttribute("onclick", " onclick=", 3569, "", 3686, 1);
#nullable restore
#line 48 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 3578, Html.ActionLink("Keyboard", "Index", new { sortOrder = "Keyboard", currentFilter = ViewBag.CurrentFilter }), 3578, 108, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("</a>\n    </div>\n    <table class=\"table\" style=\"overflow-y:auto;\">\n        <thead>\n            <tr>\n                <th>\n                    ");
#nullable restore
#line 54 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 57 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 60 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 63 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.InventoryValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 66 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PartType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 69 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.URL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th></th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 75 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
             foreach (var item in Model)
            {
                // @if (item.PartType.Contains(ViewBag.Item) || (ViewBag.Item == ""))
                // {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 81 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 84 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 87 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 90 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.InventoryValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 93 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.PartType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        <img");
            BeginWriteAttribute("src", " src=\"", 5058, "\"", 5103, 1);
#nullable restore
#line 96 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 5064, Html.DisplayFor(modelItem => item.URL), 5064, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    </td>\n    <td>\n\n\n    <td style=\"width:100%\">\n        <div class=\"btn-group\" role=\"group\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67fed310b33137cfded1bc4fde5202293ef448ac21923", async() => {
                WriteLiteral("\n                <i class=\"fas fa-plus\"></i>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                                                                      WriteLiteral(item.ID);

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
            WriteLiteral("\n        </div><!-- JOHN PLZ ENTER PLUS-->\n    </td>\n</tr>\n");
#nullable restore
#line 109 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
// }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n\n    </table>\n</fieldset>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NeonTrees.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
