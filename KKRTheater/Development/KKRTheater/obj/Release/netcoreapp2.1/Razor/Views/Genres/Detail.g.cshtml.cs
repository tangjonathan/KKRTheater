#pragma checksum "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\Genres\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "422c0653b383805593a9d93da6231037be457a99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Genres_Detail), @"mvc.1.0.view", @"/Views/Genres/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Genres/Detail.cshtml", typeof(AspNetCore.Views_Genres_Detail))]
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
#line 1 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\_ViewImports.cshtml"
using KKRTheater;

#line default
#line hidden
#line 2 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\_ViewImports.cshtml"
using KKRTheater.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\_ViewImports.cshtml"
using KKRTheater.ViewModels.Actors;

#line default
#line hidden
#line 4 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\_ViewImports.cshtml"
using KKRTheater.ViewModels.Movies;

#line default
#line hidden
#line 5 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\_ViewImports.cshtml"
using KKRTheater.ViewModels.Genres;

#line default
#line hidden
#line 6 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\_ViewImports.cshtml"
using KKRTheater.ViewModels.Directors;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"422c0653b383805593a9d93da6231037be457a99", @"/Views/Genres/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90101c79123f545a68266916ca0793a6b4a0620b", @"/Views/_ViewImports.cshtml")]
    public class Views_Genres_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenreDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(25, 223, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"page-header clearfix\">\r\n        <h2 class=\"text-muted\">View Genre</h2>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"\">\r\n    <div class=\"\">\r\n        <div class=\"col\">\r\n            <p id=\"\">");
            EndContext();
            BeginContext(249, 10, false);
#line 13 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\Genres\Detail.cshtml"
                Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(259, 82, true);
            WriteLiteral("</p>\r\n\r\n            <div>\r\n                <h3>Movies</h3>\r\n                <ul>\r\n");
            EndContext();
#line 18 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\Genres\Detail.cshtml"
                     foreach (KeyValuePair<int,string> movie in Model.Movies)
                    {

#line default
#line hidden
            BeginContext(443, 58, true);
            WriteLiteral("                        <li>\r\n                            ");
            EndContext();
            BeginContext(501, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44c660c332704c59a760c30cd42911c1", async() => {
                BeginContext(574, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(609, 11, false);
#line 22 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\Genres\Detail.cshtml"
                           Write(movie.Value);

#line default
#line hidden
                EndContext();
                BeginContext(620, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\Genres\Detail.cshtml"
                                                                             WriteLiteral(movie.Key);

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
            BeginContext(654, 33, true);
            WriteLiteral("\r\n                        </li>\r\n");
            EndContext();
#line 25 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\Genres\Detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(710, 81, true);
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenreDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
