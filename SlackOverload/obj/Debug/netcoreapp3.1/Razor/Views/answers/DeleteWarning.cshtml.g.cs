#pragma checksum "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\answers\DeleteWarning.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91a20243bae3620c98ab751f11e3da0c007da21f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_answers_DeleteWarning), @"mvc.1.0.view", @"/Views/answers/DeleteWarning.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91a20243bae3620c98ab751f11e3da0c007da21f", @"/Views/answers/DeleteWarning.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fccc81ec1186c9ee2fd540ead68492bd203ae901", @"/Views/_ViewImports.cshtml")]
    public class Views_answers_DeleteWarning : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<answers>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\answers\DeleteWarning.cshtml"
  
    ViewData["Title"] = "DeleteWarning";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"color:red; border-top: 4px solid red; border-bottom: 4px solid red; display:inline\">Delete Warning</h1>\r\n<br />\r\n<br />\r\n<h3>");
#nullable restore
#line 9 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\answers\DeleteWarning.cshtml"
Write(Model.details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\nposted by ");
#nullable restore
#line 10 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\answers\DeleteWarning.cshtml"
     Write(Model.username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" on ");
#nullable restore
#line 10 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\answers\DeleteWarning.cshtml"
                        Write(Model.posted);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<span>Upvoted ");
#nullable restore
#line 12 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\answers\DeleteWarning.cshtml"
         Write(Model.upvotes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" times</span>\r\n<br />\r\n<br />\r\n<h4 style=\"color:red\">Are you sure you want to delete this answer?</h4>\r\n\r\n<br />\r\n<br />\r\n<table width=\"100%\" style=\"text-align:center\">\r\n    <tbody>\r\n        <tr>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 519, "\"", 552, 2);
            WriteAttributeValue("", 526, "/answers/deletea/", 526, 17, true);
#nullable restore
#line 22 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\answers\DeleteWarning.cshtml"
WriteAttributeValue("", 543, Model.id, 543, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Yes, Delete</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 617, "\"", 652, 2);
            WriteAttributeValue("", 624, "/questions/detail/", 624, 18, true);
#nullable restore
#line 23 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\answers\DeleteWarning.cshtml"
WriteAttributeValue("", 642, Model.qid, 642, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light\">No, Go Back</a></td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n");
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
