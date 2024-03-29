#pragma checksum "D:\MyWork\UniversityManagementSystem\MVC\Views\Office\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e6e00c48ba170fa9394494ee5820b5a598fde23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Office_Index), @"mvc.1.0.view", @"/Views/Office/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e6e00c48ba170fa9394494ee5820b5a598fde23", @"/Views/Office/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Office_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC.Models.OfficeView>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\MyWork\UniversityManagementSystem\MVC\Views\Office\Index.cshtml"
   
    ViewBag.Title = "Offices";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Offices</h1>\r\n\r\n<p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 116, "\"", 157, 1);
#nullable restore
#line 9 "D:\MyWork\UniversityManagementSystem\MVC\Views\Office\Index.cshtml"
WriteAttributeValue("", 123, Url.Action("AddOrEdit", "Office"), 123, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\"><i class=\"fa fa-plus\"></i>Create new</a>\r\n</p>\r\n\r\n<table class=\"table table-striped\">\r\n    <thead class=\"table-healing\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\MyWork\UniversityManagementSystem\MVC\Views\Office\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeacherID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\MyWork\UniversityManagementSystem\MVC\Views\Office\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Actions\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n\r\n");
#nullable restore
#line 27 "D:\MyWork\UniversityManagementSystem\MVC\Views\Office\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "D:\MyWork\UniversityManagementSystem\MVC\Views\Office\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Teacher.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 35 "D:\MyWork\UniversityManagementSystem\MVC\Views\Office\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 914, "\"", 981, 1);
#nullable restore
#line 39 "D:\MyWork\UniversityManagementSystem\MVC\Views\Office\Index.cshtml"
WriteAttributeValue("", 921, Url.ActionLink("AddOrEdit", "Office", new { id = item.ID }), 921, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\"><i class=\"fa fa-pencil\"></i>Edit</a>\r\n                 <a");
            BeginWriteAttribute("onClick", " onClick=\"", 1064, "\"", 1090, 3);
            WriteAttributeValue("", 1074, "Delete(", 1074, 7, true);
#nullable restore
#line 40 "D:\MyWork\UniversityManagementSystem\MVC\Views\Office\Index.cshtml"
WriteAttributeValue("", 1081, item.ID, 1081, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1089, ")", 1089, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\"><i class=\"fa fa-trash\"></i>Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 43 "D:\MyWork\UniversityManagementSystem\MVC\Views\Office\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(" \r\n    <script>\r\n        $(function () {\r\n            var successMessage = \'");
#nullable restore
#line 49 "D:\MyWork\UniversityManagementSystem\MVC\Views\Office\Index.cshtml"
                             Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
            if (successMessage != '')
                alertify.success(successMessage);
        });

        function Delete(id) {
            alertify.confirm('Delete this office', 'Are you sure', function () {
                window.location.href = '");
#nullable restore
#line 56 "D:\MyWork\UniversityManagementSystem\MVC\Views\Office\Index.cshtml"
                                   Write(Url.Action("Delete", "Office"));

#line default
#line hidden
#nullable disable
                WriteLiteral("/\' + id;\r\n            }, null);\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC.Models.OfficeView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
