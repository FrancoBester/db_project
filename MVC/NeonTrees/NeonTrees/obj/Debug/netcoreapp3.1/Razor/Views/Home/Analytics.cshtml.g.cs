#pragma checksum "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Home\Analytics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d72e540f7fedef9302fd6bdcab41fe3d18738964"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Analytics), @"mvc.1.0.view", @"/Views/Home/Analytics.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d72e540f7fedef9302fd6bdcab41fe3d18738964", @"/Views/Home/Analytics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a233dd4d465801631d196157b503be1fcdde2ed7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Analytics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Chart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d72e540f7fedef9302fd6bdcab41fe3d187389644136", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d72e540f7fedef9302fd6bdcab41fe3d187389644398", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d72e540f7fedef9302fd6bdcab41fe3d187389645497", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <!--script-- src=""~/lib/bootstrap/dist/js/bootstrap.min.js""></!--script-->
    <!--link href=""~/lib/bootstrap/dist/css/bootstrap.min.css"" rel=""stylesheet"" /-->
    <style>
        

        #chart_container {
            height: 300px;
            width: 500px;
            border: 1px solid #ddd;
            padding: 1px;
            border-radius: 4px;
        }

        #chart_div {
            padding: 3rem;
        }

        #big_chart {
            height: 200px;
            border: 1px solid #ddd;
            padding: 1px;
            border-radius: 4px;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d72e540f7fedef9302fd6bdcab41fe3d187389647928", async() => {
                WriteLiteral(@"
    <P>Prices</P>
    <div id=""big_chart"">
        Total cost of builds
        <canvas id=""build_prices""></canvas>
    </div>

    <p>Month</p>
    <div id=""big_chart"">
        Builds per month
        <canvas id=""build_month""></canvas>
    </div>



    <script>
        var buildArray = ");
#nullable restore
#line 48 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Home\Analytics.cshtml"
                    Write(Html.Raw(Json.Serialize(ViewBag.PRICEREP)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n        var price = ");
#nullable restore
#line 49 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Home\Analytics.cshtml"
               Write(Html.Raw(Json.Serialize(ViewBag.PRICE_INFO)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

        var ctx = $(""#build_prices"");
        var pricechart = new Chart(ctx, {

            type: 'bar',
            data: {
                labels: price,
                datasets: [{
                    data: buildArray,
                    backgroundColor: [""Red"", ""Green"", ""Red"", ""Green"", ""Red"", ""Green""],

                    borderColor: [""Red"", ""Green"", ""Red"", ""Green"", ""Red"", ""Green""],

                    borderWidth: 1,
                    barThickness: 'flex',
                }]
            },
            options: {

                maintainAspectRatio: false,
                scales: {
                    yAxes: [{
                        scaleLabel: {
                            display: true,
                            labelString: 'Amount',
                            fontSize: 25
                        }
                    }],
                    xAxes: [{
                        scaleLabel: {
                            display: true,
                       ");
                WriteLiteral(@"     labelString: 'Prices',
                            fontSize: 25
                        }
                    }],
                    xAxes: [{ ticks: { beginAtZero: true } }],
                    yAxes: [{ ticks: { beginAtZero: true } }]
                },
                legend: { display: false }
            },
        });
    </script>


    <script>
        var monthArray = ");
#nullable restore
#line 95 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Home\Analytics.cshtml"
                    Write(Html.Raw(Json.Serialize(ViewBag.MONTHREP)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n        var month = ");
#nullable restore
#line 96 "C:\Coding\CMPG 321\Backup\db_project\MVC\NeonTrees\NeonTrees\Views\Home\Analytics.cshtml"
               Write(Html.Raw(Json.Serialize(ViewBag.MONTH_INFO)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

        var ctx = $(""#build_month"");
        var pricechart = new Chart(ctx, {

            type: 'bar',
            data: {
                labels: month,
                datasets: [{
                    data: monthArray,
                    backgroundColor: [""Red"", ""Turquoise"", ""Red"", ""Turquoise"", ""Red"", ""Turquoise"", ""Red"", ""Turquoise"", ""Red"", ""Turquoise"", ""Red"", ""Turquoise""],

                    borderColor: [""Red"", ""Turquoise"", ""Red"", ""Turquoise"", ""Red"", ""Turquoise"", ""Red"", ""Turquoise"", ""Red"", ""Turquoise"", ""Red"", ""Turquoise""],

                    borderWidth: 1,
                    barThickness: 'flex',
                }]
            },
            options: {

                maintainAspectRatio: false,
                scales: {
                    yAxes: [{
                        scaleLabel: {
                            display: true,
                            labelString: 'Amount',
                            fontSize: 25
                        }
                   ");
                WriteLiteral(@" }],
                    xAxes: [{
                        scaleLabel: {
                            display: true,
                            labelString: 'Prices',
                            fontSize: 25
                        }
                    }],
                    xAxes: [{ ticks: { beginAtZero: true } }],
                    yAxes: [{ ticks: { beginAtZero: true } }]
                },
                legend: { display: false }
            },
        });
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
