#pragma checksum "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9153f763238553b39c509866b98ee7f4e041a167"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9153f763238553b39c509866b98ee7f4e041a167", @"/Views/Items/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a233dd4d465801631d196157b503be1fcdde2ed7", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NeonTrees.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
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
            WriteLiteral("\n<style>\n    button a{\n        color:white;\n    }\n</style>\n<h1>");
#nullable restore
#line 9 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<p> This is the page for mother stuff <P>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9153f763238553b39c509866b98ee7f4e041a1675124", async() => {
                WriteLiteral("View Build");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n\n<div>\n\n    <button id=\"btn1\">");
#nullable restore
#line 19 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("Case", "Index", new { sortOrder = "Case", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 20 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("CPU", "Index", new { sortOrder = "CPU", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 21 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("GPU", "Index", new { sortOrder = "GPU", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 22 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("Motherboard", "Index", new { sortOrder = "Motherboard", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 23 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("Ram", "Index", new { sortOrder = "Ram", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 24 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("Storage", "Index", new { sortOrder = "Storage", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 25 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("Chair", "Index", new { sortOrder = "Chair", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 26 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("MousePad", "Index", new { sortOrder = "MousePad", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 27 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("Headset", "Index", new { sortOrder = "Headset", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 28 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("Gaming Combo", "Index", new { sortOrder = "Gaming Combo", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 29 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("Wrist Rest", "Index", new { sortOrder = "Wrist Rest", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 30 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("Network Cable", "Index", new { sortOrder = "Network Cable", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 31 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("Switch", "Index", new { sortOrder = "Switch", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 32 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("Workstation", "Index", new { sortOrder = "Workstation", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 33 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("UpgradeKit", "Index", new { sortOrder = "UpgradeKit", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 34 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("Speakers", "Index", new { sortOrder = "Speakers", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 35 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("Adapter", "Index", new { sortOrder = "Adapter", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 36 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("Mouse", "Index", new { sortOrder = "Mouse", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 37 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("Keycap", "Index", new { sortOrder = "Keycap", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 38 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("NVLink", "Index", new { sortOrder = "NVLink", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 39 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("Mouse Keyboard combo", "Index", new { sortOrder = "Mouse Keyboard combo", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button id=\"btn1\">");
#nullable restore
#line 40 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
                 Write(Html.ActionLink("Keyboard", "Index", new { sortOrder = "Keyboard", currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n</div>\n<table class=\"table\" style=\"flex:1;overflow-y:auto; width:100%\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 46 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 49 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 52 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 55 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InventoryValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 58 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PartType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 61 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.URL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody style=\"flex:1;overflow-y:auto; width:100%\">\n");
#nullable restore
#line 67 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
         foreach (var item in Model)
        {
            // @if (item.PartType.Contains(ViewBag.Item) || (ViewBag.Item == ""))
            // {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 73 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 76 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 79 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 82 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.InventoryValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 85 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.PartType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        <img");
            BeginWriteAttribute("src", " src=\"", 4681, "\"", 4726, 1);
#nullable restore
#line 88 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
WriteAttributeValue("", 4687, Html.DisplayFor(modelItem => item.URL), 4687, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    </td>\n    <td>\n\n\n    <td style=\"justify-content:flex-end\">\n        <div class=\"btn-group\" role=\"group\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9153f763238553b39c509866b98ee7f4e041a16718914", async() => {
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
#line 95 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
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
            WriteLiteral("\n        </div><!-- JOHN PLZ ENTER PLUS-->\n    </td>\n</tr>");
#nullable restore
#line 100 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Items\Index.cshtml"
     // }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n\n</table>\n");
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
