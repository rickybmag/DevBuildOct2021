#pragma checksum "C:\Users\Tommy\Desktop\Dev Build Class Repo\Week 9 - Front End\Calculator\Calculator\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b95ed2e71e6292de73fbaeab80a9c8bde064fe4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
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
#line 1 "C:\Users\Tommy\Desktop\Dev Build Class Repo\Week 9 - Front End\Calculator\Calculator\Views\_ViewImports.cshtml"
using Calculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tommy\Desktop\Dev Build Class Repo\Week 9 - Front End\Calculator\Calculator\Views\_ViewImports.cshtml"
using Calculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b95ed2e71e6292de73fbaeab80a9c8bde064fe4a", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25c9aefe488587b7ec0bf416a8f02fe7761a75ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Calc>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<p>Number 1: ");
#nullable restore
#line 5 "C:\Users\Tommy\Desktop\Dev Build Class Repo\Week 9 - Front End\Calculator\Calculator\Views\Home\Result.cshtml"
        Write(Model.Num1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Number 2: ");
#nullable restore
#line 6 "C:\Users\Tommy\Desktop\Dev Build Class Repo\Week 9 - Front End\Calculator\Calculator\Views\Home\Result.cshtml"
        Write(Model.Num2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Operation: ");
#nullable restore
#line 7 "C:\Users\Tommy\Desktop\Dev Build Class Repo\Week 9 - Front End\Calculator\Calculator\Views\Home\Result.cshtml"
         Write(Model.Operation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Result: ");
#nullable restore
#line 8 "C:\Users\Tommy\Desktop\Dev Build Class Repo\Week 9 - Front End\Calculator\Calculator\Views\Home\Result.cshtml"
      Write(Model.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Calc> Html { get; private set; }
    }
}
#pragma warning restore 1591
