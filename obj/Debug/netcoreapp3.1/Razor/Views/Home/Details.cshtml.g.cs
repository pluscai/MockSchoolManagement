#pragma checksum "C:\Users\sxcai\Desktop\MockSchoolManagement\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9adc41895be1f61e2d58d975c45f3010f91ee4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\sxcai\Desktop\MockSchoolManagement\Views\_ViewImports.cshtml"
using MockSchoolManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sxcai\Desktop\MockSchoolManagement\Views\_ViewImports.cshtml"
using MockSchoolManagement.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9adc41895be1f61e2d58d975c45f3010f91ee4a", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e94bd80df7d5c75591d3ac821af33b12dc6ce03", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MockSchoolManagement.ViewModels.HomeDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sxcai\Desktop\MockSchoolManagement\Views\Home\Details.cshtml"
  ViewBag.Title = "学生详情";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 3 "C:\Users\sxcai\Desktop\MockSchoolManagement\Views\Home\Details.cshtml"
Write(Model.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<div class=\"row justify-content-center m-3\">\r\n    <div class=\"col-sm-6\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                <h1>");
#nullable restore
#line 9 "C:\Users\sxcai\Desktop\MockSchoolManagement\Views\Home\Details.cshtml"
               Write(Model.Student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n            <div class=\"card-body text-center\">\r\n                <img class=\"card-img-top  \" src=\"～/images/noimage.png\" />\r\n                <h4>学生ID:");
#nullable restore
#line 13 "C:\Users\sxcai\Desktop\MockSchoolManagement\Views\Home\Details.cshtml"
                    Write(Model.Student.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4>邮箱 :");
#nullable restore
#line 14 "C:\Users\sxcai\Desktop\MockSchoolManagement\Views\Home\Details.cshtml"
                   Write(Model.Student.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4>主修科目 :");
#nullable restore
#line 15 "C:\Users\sxcai\Desktop\MockSchoolManagement\Views\Home\Details.cshtml"
                     Write(Model.Student.Major);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
            </div>
            <div class=""card-footer text-center"">
                <a href=""#"" class=""btn btn-primary"">返回</a>
                <a href=""#"" class=""btn btn-primary"">编辑</a>
                <a href=""#"" class=""btn btn-danger"">删除</a>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts2", async() => {
                WriteLiteral("\r\n    <script src=\"～/js/CustomScript2.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MockSchoolManagement.ViewModels.HomeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
