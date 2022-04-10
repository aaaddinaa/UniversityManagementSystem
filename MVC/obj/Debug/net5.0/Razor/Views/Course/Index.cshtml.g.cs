#pragma checksum "D:\MyWork\UniversityManagementSystem\MVC\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d10014a00a6dd8bde5e29ef5106d76a54fd33284"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
#line 1 "D:\MyWork\UniversityManagementSystem\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyWork\UniversityManagementSystem\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d10014a00a6dd8bde5e29ef5106d76a54fd33284", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC.Models.CourseView>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\MyWork\UniversityManagementSystem\MVC\Views\Course\Index.cshtml"
  
    ViewBag.Title = "Course";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Course</h1>\r\n\r\n<p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 113, "\"", 154, 1);
#nullable restore
#line 9 "D:\MyWork\UniversityManagementSystem\MVC\Views\Course\Index.cshtml"
WriteAttributeValue("", 120, Url.Action("AddOrEdit", "Course"), 120, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\"><i class=\"fa fa-plus\"></i>Create new</a>\r\n</p>\r\n\r\n<table class=\"table table-striped\">\r\n    <thead class=\"table-healing\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\MyWork\UniversityManagementSystem\MVC\Views\Course\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\MyWork\UniversityManagementSystem\MVC\Views\Course\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Credits));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th>\r\n                Actions\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n\r\n");
#nullable restore
#line 28 "D:\MyWork\UniversityManagementSystem\MVC\Views\Course\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "D:\MyWork\UniversityManagementSystem\MVC\Views\Course\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "D:\MyWork\UniversityManagementSystem\MVC\Views\Course\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Credits));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 906, "\"", 967, 1);
#nullable restore
#line 39 "D:\MyWork\UniversityManagementSystem\MVC\Views\Course\Index.cshtml"
WriteAttributeValue("", 913, Url.Action("AddOrEdit", "Course", new {id =item.ID }), 913, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\"><i class=\"fa fa-pencil\"></i>Edit</a>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1049, "\"", 1075, 3);
            WriteAttributeValue("", 1059, "Delete(", 1059, 7, true);
#nullable restore
#line 40 "D:\MyWork\UniversityManagementSystem\MVC\Views\Course\Index.cshtml"
WriteAttributeValue("", 1066, item.ID, 1066, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1074, ")", 1074, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\"><i class=\"fa fa-trash\"></i>Delete</a>\r\n            </th>\r\n        </tr>\r\n");
#nullable restore
#line 43 "D:\MyWork\UniversityManagementSystem\MVC\Views\Course\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            var succesMessage = \'");
#nullable restore
#line 49 "D:\MyWork\UniversityManagementSystem\MVC\Views\Course\Index.cshtml"
                            Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
            if (succesMessage != '')
                alertify.success(succesMessage)
        });

        function Delete(id) {
            alertify.confirm('Delete this Course', 'Are you sure?', function () {
                window.location.href = '");
#nullable restore
#line 56 "D:\MyWork\UniversityManagementSystem\MVC\Views\Course\Index.cshtml"
                                   Write(Url.Action("Delete", "Course"));

#line default
#line hidden
#nullable disable
                WriteLiteral("/\' + id\r\n            }, null)\r\n        }\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC.Models.CourseView>> Html { get; private set; }
    }
}
#pragma warning restore 1591