#pragma checksum "C:\Users\калабаева\source\repos\TestProject2\WebApplication4\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9faf6baec935535af339dc411b2a3bfa214f2027"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Edit.cshtml", typeof(AspNetCore.Views_Home_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9faf6baec935535af339dc411b2a3bfa214f2027", @"/Views/Home/Edit.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication4.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 58, true);
            WriteLiteral("\r\n<form method=\"post\">\r\n    <input type=\"hidden\" name=\"Id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 97, "\"", 114, 1);
#line 4 "C:\Users\калабаева\source\repos\TestProject2\WebApplication4\Views\Home\Edit.cshtml"
WriteAttributeValue("", 105, Model.Id, 105, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(115, 45, true);
            WriteLiteral(" />\r\n    Name: <input type=\"text\" name=\"Name\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 160, "\"", 179, 1);
#line 5 "C:\Users\калабаева\source\repos\TestProject2\WebApplication4\Views\Home\Edit.cshtml"
WriteAttributeValue("", 168, Model.Name, 168, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(180, 49, true);
            WriteLiteral(" /><br />\r\n    Age: <input type=\"text\" name=\"Age\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 229, "\"", 247, 1);
#line 6 "C:\Users\калабаева\source\repos\TestProject2\WebApplication4\Views\Home\Edit.cshtml"
WriteAttributeValue("", 237, Model.Age, 237, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(248, 72, true);
            WriteLiteral(" /><br />\r\n    <input type=\"submit\" name=\"name\" value=\"Save\" />\r\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication4.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
