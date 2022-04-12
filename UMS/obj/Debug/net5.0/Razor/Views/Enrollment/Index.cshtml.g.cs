#pragma checksum "D:\MyWork\UniversityManagementSystem\UMS\Views\Enrollment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f8e1bcb306880941167f70bfc2ef2c91094c328"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Enrollment_Index), @"mvc.1.0.view", @"/Views/Enrollment/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f8e1bcb306880941167f70bfc2ef2c91094c328", @"/Views/Enrollment/Index.cshtml")]
    public class Views_Enrollment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UMS.Models.EnrollmentView>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\MyWork\UniversityManagementSystem\UMS\Views\Enrollment\Index.cshtml"
   
    ViewBag.Title = "Entrolments";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Enrollments</h1>\r\n\r\n<p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 128, "\"", 173, 1);
#nullable restore
#line 9 "D:\MyWork\UniversityManagementSystem\UMS\Views\Enrollment\Index.cshtml"
WriteAttributeValue("", 135, Url.Action("AddOrEdit", "Enrollment"), 135, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\"><i class=\"fa fa-plus\"></i>Create new</a>\r\n</p>\r\n\r\n<table class=\"table table-striped\">\r\n    <thead class=\"table-healing\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\MyWork\UniversityManagementSystem\UMS\Views\Enrollment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Student.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\MyWork\UniversityManagementSystem\UMS\Views\Enrollment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Course.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Actions\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n\r\n");
#nullable restore
#line 27 "D:\MyWork\UniversityManagementSystem\UMS\Views\Enrollment\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\MyWork\UniversityManagementSystem\UMS\Views\Enrollment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Student.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "D:\MyWork\UniversityManagementSystem\UMS\Views\Enrollment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Course.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 943, "\"", 1008, 1);
#nullable restore
#line 38 "D:\MyWork\UniversityManagementSystem\UMS\Views\Enrollment\Index.cshtml"
WriteAttributeValue("", 950, Url.Action("AddOrEdit", "Enrollment", new {id =item.ID }), 950, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\"><i class=\"fa fa-pencil\"></i>Edit</a>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1090, "\"", 1116, 3);
            WriteAttributeValue("", 1100, "Delete(", 1100, 7, true);
#nullable restore
#line 39 "D:\MyWork\UniversityManagementSystem\UMS\Views\Enrollment\Index.cshtml"
WriteAttributeValue("", 1107, item.ID, 1107, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1115, ")", 1115, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\"><i class=\"fa fa-trash\"></i>Delete</a>\r\n            </th>\r\n        </tr>\r\n");
#nullable restore
#line 42 "D:\MyWork\UniversityManagementSystem\UMS\Views\Enrollment\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(" \r\n    <script>\r\n        $(function () {\r\n            var succesMessage = \'");
#nullable restore
#line 48 "D:\MyWork\UniversityManagementSystem\UMS\Views\Enrollment\Index.cshtml"
                            Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
            if (succesMessage != '') 
                alertify.success(succesMessage)
        });

        function Delete(id) {
            alertify.confirm('Delete this Enrollment', 'Are you sure?', function () {
                window.location.href = '");
#nullable restore
#line 55 "D:\MyWork\UniversityManagementSystem\UMS\Views\Enrollment\Index.cshtml"
                                   Write(Url.Action("Delete", "Enrollment"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UMS.Models.EnrollmentView>> Html { get; private set; }
    }
}
#pragma warning restore 1591