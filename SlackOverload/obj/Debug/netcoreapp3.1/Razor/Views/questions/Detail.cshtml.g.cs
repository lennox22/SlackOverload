#pragma checksum "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "356c01f49631290c4be48739afe90791f1b42e75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_questions_Detail), @"mvc.1.0.view", @"/Views/questions/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"356c01f49631290c4be48739afe90791f1b42e75", @"/Views/questions/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fccc81ec1186c9ee2fd540ead68492bd203ae901", @"/Views/_ViewImports.cshtml")]
    public class Views_questions_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<questions>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n<h3>");
#nullable restore
#line 8 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
Write(Model.details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<br />\r\nposted by ");
#nullable restore
#line 10 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
     Write(Model.username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" on ");
#nullable restore
#line 10 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
                        Write(Model.posted);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
 if (DAL.CurrentUser != null && (DAL.CurrentUser.ToLower() == "admin" || DAL.CurrentUser == Model.username))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>\r\n        &nbsp;&nbsp;&nbsp;&nbsp;\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 339, "\"", 375, 2);
            WriteAttributeValue("", 346, "/questions/editform/", 346, 20, true);
#nullable restore
#line 15 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
WriteAttributeValue("", 366, Model.id, 366, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light\"> Edit </a>\r\n    </span>\r\n    <span>\r\n        &nbsp;&nbsp;&nbsp;&nbsp;\r\n");
#nullable restore
#line 19 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
         if (Model.status == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 528, "\"", 562, 2);
            WriteAttributeValue("", 535, "/questions/closeq/", 535, 18, true);
#nullable restore
#line 21 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
WriteAttributeValue("", 553, Model.id, 553, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light\">Close Question</a>\r\n");
#nullable restore
#line 22 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 656, "\"", 689, 2);
            WriteAttributeValue("", 663, "/questions/openq/", 663, 17, true);
#nullable restore
#line 25 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
WriteAttributeValue("", 680, Model.id, 680, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light\">Open Question</a>\r\n");
#nullable restore
#line 26 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </span>\r\n    <span>&nbsp;&nbsp;&nbsp;&nbsp;<a");
            BeginWriteAttribute("href", " href=\"", 794, "\"", 835, 2);
            WriteAttributeValue("", 801, "/questions/deletewarning/", 801, 25, true);
#nullable restore
#line 29 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
WriteAttributeValue("", 826, Model.id, 826, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></span>\r\n");
#nullable restore
#line 30 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 33 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
 if (Model.status == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>Not Closed</span>\r\n");
#nullable restore
#line 36 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>Closed</span>\r\n");
#nullable restore
#line 40 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n<h3>Answers&nbsp; &nbsp; &nbsp; &nbsp;<a");
            BeginWriteAttribute("href", " href=\"", 1045, "\"", 1081, 2);
            WriteAttributeValue("", 1052, "/answers/createform/", 1052, 20, true);
#nullable restore
#line 43 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
WriteAttributeValue("", 1072, Model.id, 1072, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light\">Submit New Answer</a></h3>\r\n<br />\r\n");
#nullable restore
#line 45 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
 foreach (answers a in ViewBag.answers)
{
    if (a.qid == Model.id)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
   Write(a.details);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <span>posted by </span>");
#nullable restore
#line 51 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
                          Write(a.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>on </span>");
#nullable restore
#line 52 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
                   Write(a.posted);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <span>upvoted </span>");
#nullable restore
#line 54 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
                        Write(a.upvotes);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>times</span><span>&nbsp; &nbsp; &nbsp; &nbsp;</span>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1470, "\"", 1498, 2);
            WriteAttributeValue("", 1477, "/answers/upvote/", 1477, 16, true);
#nullable restore
#line 56 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
WriteAttributeValue("", 1493, a.id, 1493, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Upvote</a>\r\n        <span>&nbsp; &nbsp; &nbsp; &nbsp;</span>\r\n");
#nullable restore
#line 58 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
         if (DAL.CurrentUser != null && (DAL.CurrentUser.ToLower() == "admin" || DAL.CurrentUser == a.username))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>\r\n                \r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1775, "\"", 1805, 2);
            WriteAttributeValue("", 1782, "/answers/editform/", 1782, 18, true);
#nullable restore
#line 62 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
WriteAttributeValue("", 1800, a.id, 1800, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light\"> Edit </a>\r\n            </span>\r\n");
            WriteLiteral("            <span>&nbsp;&nbsp;&nbsp;&nbsp;<a");
            BeginWriteAttribute("href", " href=\"", 1920, "\"", 1955, 2);
            WriteAttributeValue("", 1927, "/answers/deletewarning/", 1927, 23, true);
#nullable restore
#line 65 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
WriteAttributeValue("", 1950, a.id, 1950, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></span>\r\n");
#nullable restore
#line 66 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <br />\r\n");
#nullable restore
#line 69 "C:\Users\lbrown4\dev\Week12\week12project\SlackOverload\Views\questions\Detail.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<questions> Html { get; private set; }
    }
}
#pragma warning restore 1591
