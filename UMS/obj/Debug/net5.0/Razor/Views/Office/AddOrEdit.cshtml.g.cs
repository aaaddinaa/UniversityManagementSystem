#pragma checksum "D:\MyWork\UniversityManagementSystem\UMS\Views\Office\AddOrEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6308d0bda9ba41615d2643566bf541dbbd519d48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Office_AddOrEdit), @"mvc.1.0.view", @"/Views/Office/AddOrEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6308d0bda9ba41615d2643566bf541dbbd519d48", @"/Views/Office/AddOrEdit.cshtml")]
    public class Views_Office_AddOrEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UMS.Models.OfficeView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\MyWork\UniversityManagementSystem\UMS\Views\Office\AddOrEdit.cshtml"
   
    ViewBag.Title = "AddOrEdit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>AddOrEdit</h1>\r\n\r\n<div class=\"form-body\">\r\n");
#nullable restore
#line 10 "D:\MyWork\UniversityManagementSystem\UMS\Views\Office\AddOrEdit.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\MyWork\UniversityManagementSystem\UMS\Views\Office\AddOrEdit.cshtml"
   Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 15 "D:\MyWork\UniversityManagementSystem\UMS\Views\Office\AddOrEdit.cshtml"
       Write(Html.LabelFor(model => model.TeacherID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "D:\MyWork\UniversityManagementSystem\UMS\Views\Office\AddOrEdit.cshtml"
       Write(Html.EditorFor(model => model.TeacherID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 17 "D:\MyWork\UniversityManagementSystem\UMS\Views\Office\AddOrEdit.cshtml"
       Write(Html.ValidationMessageFor(model => model.TeacherID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 21 "D:\MyWork\UniversityManagementSystem\UMS\Views\Office\AddOrEdit.cshtml"
       Write(Html.LabelFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 22 "D:\MyWork\UniversityManagementSystem\UMS\Views\Office\AddOrEdit.cshtml"
       Write(Html.EditorFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 23 "D:\MyWork\UniversityManagementSystem\UMS\Views\Office\AddOrEdit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Submit\" class=\"btn button\" />\r\n            <input type=\"reset\" value=\"Reset\" class=\"btn button\" />\r\n        </div>\r\n");
#nullable restore
#line 30 "D:\MyWork\UniversityManagementSystem\UMS\Views\Office\AddOrEdit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UMS.Models.OfficeView> Html { get; private set; }
    }
}
#pragma warning restore 1591
