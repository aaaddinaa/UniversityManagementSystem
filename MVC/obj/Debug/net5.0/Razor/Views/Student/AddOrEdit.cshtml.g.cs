#pragma checksum "D:\MyWork\UniversityManagementSystem\MVC\Views\Student\AddOrEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc850f19491a1e7e05e1d9b5f4686a5b1c953870"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_AddOrEdit), @"mvc.1.0.view", @"/Views/Student/AddOrEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc850f19491a1e7e05e1d9b5f4686a5b1c953870", @"/Views/Student/AddOrEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_AddOrEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC.Models.StudentView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\MyWork\UniversityManagementSystem\MVC\Views\Student\AddOrEdit.cshtml"
   
    ViewBag.Title = "AddOrEdit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>AddOrEdit</h1>\r\n\r\n<div class=\"form-body\">\r\n");
#nullable restore
#line 10 "D:\MyWork\UniversityManagementSystem\MVC\Views\Student\AddOrEdit.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\MyWork\UniversityManagementSystem\MVC\Views\Student\AddOrEdit.cshtml"
   Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 15 "D:\MyWork\UniversityManagementSystem\MVC\Views\Student\AddOrEdit.cshtml"
       Write(Html.LabelFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "D:\MyWork\UniversityManagementSystem\MVC\Views\Student\AddOrEdit.cshtml"
       Write(Html.EditorFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 17 "D:\MyWork\UniversityManagementSystem\MVC\Views\Student\AddOrEdit.cshtml"
       Write(Html.ValidationMessageFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 21 "D:\MyWork\UniversityManagementSystem\MVC\Views\Student\AddOrEdit.cshtml"
       Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 22 "D:\MyWork\UniversityManagementSystem\MVC\Views\Student\AddOrEdit.cshtml"
       Write(Html.EditorFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 23 "D:\MyWork\UniversityManagementSystem\MVC\Views\Student\AddOrEdit.cshtml"
       Write(Html.ValidationMessageFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 27 "D:\MyWork\UniversityManagementSystem\MVC\Views\Student\AddOrEdit.cshtml"
       Write(Html.LabelFor(model => model.EnrollmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 28 "D:\MyWork\UniversityManagementSystem\MVC\Views\Student\AddOrEdit.cshtml"
       Write(Html.EditorFor(model => model.EnrollmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 29 "D:\MyWork\UniversityManagementSystem\MVC\Views\Student\AddOrEdit.cshtml"
       Write(Html.ValidationMessageFor(model => model.EnrollmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Submit\" class=\"btn button\" />\r\n            <input type =\"reset\" value=\"Reset\" class=\"btn button\" />\r\n        </div>\r\n");
#nullable restore
#line 36 "D:\MyWork\UniversityManagementSystem\MVC\Views\Student\AddOrEdit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC.Models.StudentView> Html { get; private set; }
    }
}
#pragma warning restore 1591
