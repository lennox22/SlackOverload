#pragma checksum "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\answers\EditForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42bcde417d4462a66e37e0d229ff5b4e88c6c9e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_answers_EditForm), @"mvc.1.0.view", @"/Views/answers/EditForm.cshtml")]
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
#line 1 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\_ViewImports.cshtml"
using SlackOverload;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\_ViewImports.cshtml"
using SlackOverload.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42bcde417d4462a66e37e0d229ff5b4e88c6c9e1", @"/Views/answers/EditForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fccc81ec1186c9ee2fd540ead68492bd203ae901", @"/Views/_ViewImports.cshtml")]
    public class Views_answers_EditForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<answers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\answers\EditForm.cshtml"
  
    ViewData["Title"] = "EditForm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit Your Answer</h1>\r\n<br />\r\n\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42bcde417d4462a66e37e0d229ff5b4e88c6c9e13808", async() => {
                WriteLiteral("\r\n    <table>\r\n        <tbody>\r\n\r\n            <tr>\r\n                <td>Answer Details: </td>\r\n                <td><textarea type=\"text\" name=\"details\" cols=\"75\" rows=\"5\" required>");
#nullable restore
#line 16 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\answers\EditForm.cshtml"
                                                                                Write(Model.details);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea></td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 457, "\"", 474, 1);
#nullable restore
#line 20 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\answers\EditForm.cshtml"
WriteAttributeValue("", 465, Model.id, 465, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"qid\"");
                BeginWriteAttribute("value", " value=\"", 515, "\"", 533, 1);
#nullable restore
#line 21 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\answers\EditForm.cshtml"
WriteAttributeValue("", 523, Model.qid, 523, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"upvotes\"");
                BeginWriteAttribute("value", " value=\"", 578, "\"", 600, 1);
#nullable restore
#line 22 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\answers\EditForm.cshtml"
WriteAttributeValue("", 586, Model.upvotes, 586, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"submit\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 135, "/answers/edit/", 135, 14, true);
#nullable restore
#line 10 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\answers\EditForm.cshtml"
AddHtmlAttributeValue("", 149, Model.id, 149, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<answers> Html { get; private set; }
    }
}
#pragma warning restore 1591