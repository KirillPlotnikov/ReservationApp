#pragma checksum "C:\Users\ironb\source\repos\Semestralka\Semestralka\Views\Rooms\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b65a124d55a7a7f22ed32dcf29001e687210587"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rooms_Details), @"mvc.1.0.view", @"/Views/Rooms/Details.cshtml")]
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
#line 1 "C:\Users\ironb\source\repos\Semestralka\Semestralka\Views\_ViewImports.cshtml"
using Semestralka;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ironb\source\repos\Semestralka\Semestralka\Views\_ViewImports.cshtml"
using Semestralka.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b65a124d55a7a7f22ed32dcf29001e687210587", @"/Views/Rooms/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54e6cd31bf07bdf841ea8cb80444143582b7e15f", @"/Views/_ViewImports.cshtml")]
    public class Views_Rooms_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SemestralkaDataControl.Models.Room>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/css/rooms/detail.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Rooms", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("back-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/rooms/detail.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ironb\source\repos\Semestralka\Semestralka\Views\Rooms\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            DefineSection("Links", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b65a124d55a7a7f22ed32dcf29001e6872105875720", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 22 "C:\Users\ironb\source\repos\Semestralka\Semestralka\Views\Rooms\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 26 "C:\Users\ironb\source\repos\Semestralka\Semestralka\Views\Rooms\Details.cshtml"
 if (ViewBag.Error != null && ViewBag.Error == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"error\">Someone has already booked reservation at this time</div>\r\n");
#nullable restore
#line 29 "C:\Users\ironb\source\repos\Semestralka\Semestralka\Views\Rooms\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Booking for room: ");
#nullable restore
#line 31 "C:\Users\ironb\source\repos\Semestralka\Semestralka\Views\Rooms\Details.cshtml"
                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<p class=\"room_description\">");
#nullable restore
#line 32 "C:\Users\ironb\source\repos\Semestralka\Semestralka\Views\Rooms\Details.cshtml"
                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n<div class=\"content-container\">\r\n    \r\n        <div id=\"left-side\">\r\n            <label>Date:</label>\r\n            <input type=\"date\" id=\"date-input\" name=\"date\"");
            BeginWriteAttribute("min", " min=\"", 882, "\"", 913, 1);
#nullable restore
#line 39 "C:\Users\ironb\source\repos\Semestralka\Semestralka\Views\Rooms\Details.cshtml"
WriteAttributeValue("", 888, GetTodaysDateFormatted(), 888, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b65a124d55a7a7f22ed32dcf29001e6872105879450", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n        <div id=\"right-side\">\r\n            <div id=\"right-side-content\">\r\n\r\n            </div>\r\n        </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b65a124d55a7a7f22ed32dcf29001e68721058711160", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $(document).ready(function () {

            var selected = null;
            $(""#date-input"").change(function () {
                selected = null;
                var date = new Date($('#date-input').val());
                day = date.getDate();
                month = date.getMonth() + 1;
                year = date.getFullYear();
                $(""#next"").remove();
                $(""#right-side-content"").empty();
                if (Number.isNaN(day) || Number.isNaN(month) || Number.isNaN(year)) {
                    (""#right-side"").empty();
                } else {
                    $.ajax({
                        type: ""POST"",
                        url: """);
#nullable restore
#line 71 "C:\Users\ironb\source\repos\Semestralka\Semestralka\Views\Rooms\Details.cshtml"
                         Write(Url.Action("GetFreeReservationTimes"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                        data: { date: year + \"-\" + month + \"-\" + day, id: ");
#nullable restore
#line 72 "C:\Users\ironb\source\repos\Semestralka\Semestralka\Views\Rooms\Details.cshtml"
                                                                     Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" },
                        dataType: ""text"",
                        success: function (data) {
                            var obj = JSON.parse(data);
                            
                            

                            if (obj.length == 0) {
                                $(""#right-side-content"").append($(""<p>"").addClass(""warning"").text(""There are no free booking times for this date""));
                            } else {
                                obj.forEach(function (entry) {
                                    var toEntry = entry + 1;
                                    $(""#right-side-content"").append(
                                        $(""<div>"").addClass(""freeTime"").text(entry + "":00 - "" + toEntry + "":00"").attr(""id"", entry));
                                });

                                if (obj.length > 0) {
                                    $(""#right-side"").append($(""<button>"").addClass(""btn-primary"").attr(""id"", ""next"").text(""Next""));
        ");
                WriteLiteral(@"                        }
                                $("".freeTime"").click(function () {
                                    $("".freeTime"").removeClass(""selected"");
                                    $(this).addClass(""selected"");
                                    selected = $(this).attr(""id"");
                                });
                                $(""#next"").click(function () {
                                    window.location.replace(""");
#nullable restore
#line 97 "C:\Users\ironb\source\repos\Semestralka\Semestralka\Views\Rooms\Details.cshtml"
                                                        Write(Url.Action("Create", "Reservations"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\" + \"?id=\" +");
#nullable restore
#line 97 "C:\Users\ironb\source\repos\Semestralka\Semestralka\Views\Rooms\Details.cshtml"
                                                                                                         Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"+""&date="" + year + ""/"" + month + ""/"" + day + ""&timeFrom="" + selected);
                                });
                            }



                        }
                    });
                }
            });


        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\ironb\source\repos\Semestralka\Semestralka\Views\Rooms\Details.cshtml"
 
    public string GetTodaysDateFormatted()
    {

        return String.Format("{0:yyyy-MM-dd}", DateTime.Now);
    }
    public string GetTodaysDateFormatted(DateTime datetime)
    {

        return String.Format("{0:yyyy-MM-dd}", datetime);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SemestralkaDataControl.Models.Room> Html { get; private set; }
    }
}
#pragma warning restore 1591
