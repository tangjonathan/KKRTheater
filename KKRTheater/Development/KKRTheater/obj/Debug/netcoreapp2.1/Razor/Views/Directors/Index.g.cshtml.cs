#pragma checksum "C:\Users\Jon\Documents\kkr\app\KKRTheater\KKRTheater\Views\Directors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4f51d854cf1b909253c719af0fe834784a0113f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Directors_Index), @"mvc.1.0.view", @"/Views/Directors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Directors/Index.cshtml", typeof(AspNetCore.Views_Directors_Index))]
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
#line 1 "C:\Users\Jon\Documents\kkr\app\KKRTheater\KKRTheater\Views\_ViewImports.cshtml"
using KKRTheater;

#line default
#line hidden
#line 2 "C:\Users\Jon\Documents\kkr\app\KKRTheater\KKRTheater\Views\_ViewImports.cshtml"
using KKRTheater.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Jon\Documents\kkr\app\KKRTheater\KKRTheater\Views\_ViewImports.cshtml"
using KKRTheater.ViewModels.Actors;

#line default
#line hidden
#line 4 "C:\Users\Jon\Documents\kkr\app\KKRTheater\KKRTheater\Views\_ViewImports.cshtml"
using KKRTheater.ViewModels.Movies;

#line default
#line hidden
#line 5 "C:\Users\Jon\Documents\kkr\app\KKRTheater\KKRTheater\Views\_ViewImports.cshtml"
using KKRTheater.ViewModels.Genres;

#line default
#line hidden
#line 6 "C:\Users\Jon\Documents\kkr\app\KKRTheater\KKRTheater\Views\_ViewImports.cshtml"
using KKRTheater.ViewModels.Directors;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4f51d854cf1b909253c719af0fe834784a0113f", @"/Views/Directors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90101c79123f545a68266916ca0793a6b4a0620b", @"/Views/_ViewImports.cshtml")]
    public class Views_Directors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DirectorIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Directors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 94, true);
            WriteLiteral("<div class=\"container-fluid\">\r\n    <h3>Director Catalog</h3>\r\n    <div class=\"mt-2\">\r\n        ");
            EndContext();
            BeginContext(121, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0b8709e09794ba191ba71f7a79731dd", async() => {
                BeginContext(199, 36, true);
                WriteLiteral("\r\n            Add Director\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(239, 363, true);
            WriteLiteral(@"
    </div>
    <div class=""mt-2"">
        <table class=""table-striped table-condensed table-hover table-bordered"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 19 "C:\Users\Jon\Documents\kkr\app\KKRTheater\KKRTheater\Views\Directors\Index.cshtml"
                  
                    int counter = 1;
                    

#line default
#line hidden
#line 21 "C:\Users\Jon\Documents\kkr\app\KKRTheater\KKRTheater\Views\Directors\Index.cshtml"
                     foreach (var director in Model.Directors)
                    {


#line default
#line hidden
            BeginContext(749, 83, true);
            WriteLiteral("                        <tr class=\"\">\r\n                            <td class=\"row\">");
            EndContext();
            BeginContext(833, 7, false);
#line 25 "C:\Users\Jon\Documents\kkr\app\KKRTheater\KKRTheater\Views\Directors\Index.cshtml"
                                       Write(counter);

#line default
#line hidden
            EndContext();
            BeginContext(840, 48, true);
            WriteLiteral("</td>\r\n                            <td class=\"\">");
            EndContext();
            BeginContext(889, 13, false);
#line 26 "C:\Users\Jon\Documents\kkr\app\KKRTheater\KKRTheater\Views\Directors\Index.cshtml"
                                    Write(director.Name);

#line default
#line hidden
            EndContext();
            BeginContext(902, 82, true);
            WriteLiteral("</td>\r\n                            <td class=\"\">\r\n                                ");
            EndContext();
            BeginContext(984, 161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c64ccdd6d699494b8b8f9d0b730a7bad", async() => {
                BeginContext(1062, 79, true);
                WriteLiteral("\r\n                                    Details\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\Jon\Documents\kkr\app\KKRTheater\KKRTheater\Views\Directors\Index.cshtml"
                                                                                    WriteLiteral(director.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1145, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 33 "C:\Users\Jon\Documents\kkr\app\KKRTheater\KKRTheater\Views\Directors\Index.cshtml"

                        counter++;
                    }

#line default
#line hidden
            BeginContext(1293, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DirectorIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
