#pragma checksum "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b343111e9678307d258c5da699b8feb2a8249005"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exam_Index), @"mvc.1.0.view", @"/Views/Exam/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Exam/Index.cshtml", typeof(AspNetCore.Views_Exam_Index))]
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
#line 1 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\_ViewImports.cshtml"
using ExamApplication;

#line default
#line hidden
#line 2 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\_ViewImports.cshtml"
using ExamApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b343111e9678307d258c5da699b8feb2a8249005", @"/Views/Exam/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247c12ac0059250ea7cab8b8823a649c69bcac37", @"/Views/_ViewImports.cshtml")]
    public class Views_Exam_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Questions>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 31, false);
#line 2 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
Write(Html.Partial("_LayoutPartial2"));

#line default
#line hidden
            EndContext();
            BeginContext(50, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(95, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
 if (!ViewBag.isStartExam)
{

#line default
#line hidden
            BeginContext(128, 29, true);
            WriteLiteral("    <h2>Start Exam</h2>\r\n    ");
            EndContext();
            BeginContext(157, 558, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15f87f36c8f84387a12e14b09ea8a535", async() => {
                BeginContext(219, 47, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"questions\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 266, "\"", 292, 1);
#line 12 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
WriteAttributeValue("", 274, ViewBag.Questions, 274, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(293, 48, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"counter\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 341, "\"", 373, 1);
#line 13 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
WriteAttributeValue("", 349, ViewBag.QuestionCounter, 349, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(374, 52, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"rightAnswer\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 426, "\"", 454, 1);
#line 14 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
WriteAttributeValue("", 434, ViewBag.RightAnswer, 434, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(455, 48, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"Summary\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 503, "\"", 527, 1);
#line 15 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
WriteAttributeValue("", 511, ViewBag.Summary, 511, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(528, 180, true);
                WriteLiteral(" />\r\n        The quiz contains multiple questions. Each question will expire in one minute.  <br /> <br />\r\n        <input type=\"submit\" class=\"btn btn-info\" value=\"Start\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 11 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
                               WriteLiteral(ViewBag.Questions[0]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(715, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
}
else if (ViewBag.isSummary)
{

#line default
#line hidden
            BeginContext(752, 120, true);
            WriteLiteral("    <br />\r\n    <div class=\"summary\">\r\n        <div class=\"msg\">\r\n            Quiz Complete!! Total correct answers are ");
            EndContext();
            BeginContext(873, 20, false);
#line 25 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
                                                 Write(ViewBag.TotalCorrect);

#line default
#line hidden
            EndContext();
            BeginContext(893, 8, true);
            WriteLiteral(" out of ");
            EndContext();
            BeginContext(902, 22, false);
#line 25 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
                                                                              Write(ViewBag.TotalQuestions);

#line default
#line hidden
            EndContext();
            BeginContext(924, 20, true);
            WriteLiteral("\r\n        </div>\r\n\r\n");
            EndContext();
#line 28 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
         foreach (var summary in ViewBag.Summary)
        {

#line default
#line hidden
            BeginContext(1006, 111, true);
            WriteLiteral("            <div class=\"question\">\r\n                <div class=\"question\">\r\n                    <div>Question# ");
            EndContext();
            BeginContext(1118, 10, false);
#line 32 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
                              Write(summary.id);

#line default
#line hidden
            EndContext();
            BeginContext(1128, 33, true);
            WriteLiteral("</div>\r\n                    <div>");
            EndContext();
            BeginContext(1162, 13, false);
#line 33 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
                    Write(summary.qText);

#line default
#line hidden
            EndContext();
            BeginContext(1175, 46, true);
            WriteLiteral("</div>\r\n                    <div>Your Answer: ");
            EndContext();
            BeginContext(1222, 15, false);
#line 34 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
                                 Write(summary.yourAns);

#line default
#line hidden
            EndContext();
            BeginContext(1237, 49, true);
            WriteLiteral("</div>\r\n                    <div>Correct Answer: ");
            EndContext();
            BeginContext(1287, 19, false);
#line 35 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
                                    Write(summary.rightAnswer);

#line default
#line hidden
            EndContext();
            BeginContext(1306, 41, true);
            WriteLiteral("</div>\r\n                    <div>Result: ");
            EndContext();
            BeginContext(1347, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d9b74cefd994a958867d3ece61a0371", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1357, "~/images/", 1357, 9, true);
#line 36 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
AddHtmlAttributeValue("", 1366, summary.result, 1366, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1385, 72, true);
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n            <hr />\r\n");
            EndContext();
#line 40 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1468, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 42 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1492, 28, true);
            WriteLiteral("    <br />\r\n    <br />\r\n    ");
            EndContext();
            BeginContext(1520, 1493, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "920226ac92a94f19b21e01abd5932e43", async() => {
                BeginContext(1545, 47, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"questions\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1592, "\"", 1618, 1);
#line 48 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
WriteAttributeValue("", 1600, ViewBag.Questions, 1600, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1619, 48, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"counter\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1667, "\"", 1699, 1);
#line 49 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
WriteAttributeValue("", 1675, ViewBag.QuestionCounter, 1675, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1700, 52, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"rightAnswer\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1752, "\"", 1780, 1);
#line 50 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
WriteAttributeValue("", 1760, ViewBag.RightAnswer, 1760, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1781, 48, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"Summary\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1829, "\"", 1853, 1);
#line 51 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
WriteAttributeValue("", 1837, ViewBag.Summary, 1837, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1854, 50, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"QuestText\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1904, "\"", 1943, 1);
#line 52 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
WriteAttributeValue("", 1912, ViewBag.NextQuestion.QuestText, 1912, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1944, 125, true);
                WriteLiteral(" />\r\n\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                <h4>\r\n                    Question ");
                EndContext();
                BeginContext(2070, 23, false);
#line 57 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
                        Write(ViewBag.QuestionCounter);

#line default
#line hidden
                EndContext();
                BeginContext(2093, 198, true);
                WriteLiteral("\r\n                    <span style=\"float:right\" id=\"spRemainingTime\">Remaining Time: 01:00</span>\r\n                </h4>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <p>");
                EndContext();
                BeginContext(2292, 30, false);
#line 62 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
              Write(ViewBag.NextQuestion.QuestText);

#line default
#line hidden
                EndContext();
                BeginContext(2322, 8, true);
                WriteLiteral("</p>\r\n\r\n");
                EndContext();
#line 64 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
                 foreach (var ans in ViewBag.Answers)
                {

#line default
#line hidden
                BeginContext(2404, 150, true);
                WriteLiteral("                    <div class=\"input-group\">\r\n                        <div class=\"input-group-icon\">\r\n                            <input type=\"radio\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2554, "\"", 2572, 2);
                WriteAttributeValue("", 2559, "radio_", 2559, 6, true);
#line 68 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
WriteAttributeValue("", 2565, ans.Id, 2565, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2573, "\"", 2588, 1);
#line 68 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
WriteAttributeValue("", 2581, ans.Id, 2581, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2589, 146, true);
                WriteLiteral(" name=\"radioAnswer\" />\r\n                        </div>\r\n                        <div class=\"input-group-area\">\r\n                            <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 2735, "\"", 2754, 2);
                WriteAttributeValue("", 2741, "radio_", 2741, 6, true);
#line 71 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
WriteAttributeValue("", 2747, ans.Id, 2747, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2755, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2757, 11, false);
#line 71 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
                                                  Write(ans.AnsText);

#line default
#line hidden
                EndContext();
                BeginContext(2768, 70, true);
                WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n");
                EndContext();
#line 74 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(2857, 149, true);
                WriteLiteral("\r\n                <input type=\"submit\" id=\"btnNextQuestion\" class=\"btn btn-info\" value=\"Next Question »\" />\r\n            </div>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3013, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3017, 967, true);
            WriteLiteral(@"    <script>
        window.onload = function () {
            var Minute = 60 * 1,
                display = document.querySelector('#spRemainingTime');
            startTimer(Minute, display);
        };

        function startTimer(duration, display) {
            var timer = duration, minutes, seconds;
            var interval = setInterval(function () {
                minutes = parseInt(timer / 60, 10);
                seconds = parseInt(timer % 60, 10);

                minutes = minutes < 10 ? ""0"" + minutes : minutes; 
                seconds = seconds < 10 ? ""0"" + seconds : seconds;

                display.textContent = 'Remaining Time: ' + minutes + "":"" + seconds;

                if (--timer < 0) {
                    //timer = duration;
                    clearInterval(interval);
                    document.getElementById('btnNextQuestion').click();
                }
            }, 1000);
        }
    </script>
");
            EndContext();
#line 107 "C:\Users\WIN\Desktop\MyProject\ExamApplication\Views\Exam\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3987, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Questions> Html { get; private set; }
    }
}
#pragma warning restore 1591
