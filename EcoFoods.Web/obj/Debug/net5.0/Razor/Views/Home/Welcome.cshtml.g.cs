#pragma checksum "C:\Users\danie\source\repos\EcoFoods\EcoFoods.Web\Views\Home\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eea578a61c4d62c420bd7b73a3c78b922f7d27db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Welcome), @"mvc.1.0.view", @"/Views/Home/Welcome.cshtml")]
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
#line 1 "C:\Users\danie\source\repos\EcoFoods\EcoFoods.Web\Views\_ViewImports.cshtml"
using SurveyApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\source\repos\EcoFoods\EcoFoods.Web\Views\_ViewImports.cshtml"
using SurveyApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eea578a61c4d62c420bd7b73a3c78b922f7d27db", @"/Views/Home/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4fdad1af42d31f007d7b5e0587ec41c4424c17e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\danie\source\repos\EcoFoods\EcoFoods.Web\Views\Home\Welcome.cshtml"
  
    ViewData["Title"] = "EcoFoods - Main Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome, ");
#nullable restore
#line 8 "C:\Users\danie\source\repos\EcoFoods\EcoFoods.Web\Views\Home\Welcome.cshtml"
                              Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("! You may now place an order on our website!</h1>\r\n    <p asp-controller=\"Home\" asp-action=\"Welcome\">Check out the available products here:</p>\r\n    <input type=\"button\" value=\"View All Available Products\"");
            BeginWriteAttribute("onclick", " onclick=\"", 455, "\"", 512, 3);
            WriteAttributeValue("", 465, "location.href=\'", 465, 15, true);
#nullable restore
#line 10 "C:\Users\danie\source\repos\EcoFoods\EcoFoods.Web\Views\Home\Welcome.cshtml"
WriteAttributeValue("", 480, Url.Action("Index", "Product"), 480, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 511, "\'", 511, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Identity.SignInManager<EcoFoods.DomainEntities.ApplicationUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
