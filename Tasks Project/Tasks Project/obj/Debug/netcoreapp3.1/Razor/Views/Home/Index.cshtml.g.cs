#pragma checksum "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40a495d5b219cdce101190185357a36b49b254cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\_ViewImports.cshtml"
using Tasks_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\_ViewImports.cshtml"
using Tasks_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a495d5b219cdce101190185357a36b49b254cf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"672cc465d4b0083a68b7c38a7dafd2979518b495", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tasks_Project.Models.Task>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "View Survey";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40a495d5b219cdce101190185357a36b49b254cf3409", async() => {
                WriteLiteral("\r\n    <script src=\"https://kit.fontawesome.com/42daf7d6ae.js\" crossorigin=\"anonymous\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40a495d5b219cdce101190185357a36b49b254cf4476", async() => {
                WriteLiteral("\r\n    <div class=\"treeview\">\r\n        <h6 class=\"pt-3 pl-3\">Tasks</h6>\r\n\r\n        <hr>\r\n        <ul class=\"mb-1 pl-3 pb-2\">\r\n");
#nullable restore
#line 14 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
             foreach (var task in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>\r\n                    ");
#nullable restore
#line 17 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
               Write(task.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
                     if (task.Steps != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <ul class=\"nested\">\r\n");
#nullable restore
#line 21 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
                             foreach (var step in task.Steps)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li> ");
#nullable restore
#line 23 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
                                Write(step.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 23 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
                                             Write(step.Owner);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 24 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"

                                if (step.LittleSteps != null)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <ul class=\"nested\">\r\n");
#nullable restore
#line 28 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
                                         foreach (var littleStep in step.LittleSteps)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <li> ");
#nullable restore
#line 30 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
                                            Write(littleStep.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 30 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
                                                               Write(littleStep.Owner);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 31 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
                                            if (littleStep.LittleSteps != null)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <ul class=\"nested\">\r\n");
#nullable restore
#line 34 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
                                                     foreach (var littleStep2 in littleStep.LittleSteps)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <li>");
#nullable restore
#line 36 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
                                                       Write(littleStep2.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 36 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
                                                                           Write(littleStep2.Owner);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 37 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                </ul>\r\n");
#nullable restore
#line 39 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </ul>\r\n");
#nullable restore
#line 42 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
                                }

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ul>\r\n");
#nullable restore
#line 46 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </li>\r\n");
#nullable restore
#line 48 "C:\Users\Andreea\Desktop\Tasks Project\Tasks Project\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </ul>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tasks_Project.Models.Task>> Html { get; private set; }
    }
}
#pragma warning restore 1591
