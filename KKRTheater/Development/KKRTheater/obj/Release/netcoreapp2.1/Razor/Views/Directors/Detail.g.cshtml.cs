#pragma checksum "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\Directors\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b743be2628bb957953a87b54635e0e5117d4dba0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Directors_Detail), @"mvc.1.0.view", @"/Views/Directors/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Directors/Detail.cshtml", typeof(AspNetCore.Views_Directors_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b743be2628bb957953a87b54635e0e5117d4dba0", @"/Views/Directors/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90101c79123f545a68266916ca0793a6b4a0620b", @"/Views/_ViewImports.cshtml")]
    public class Views_Directors_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DirectorDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Directors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(28, 98, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"page-header clearfix\">\r\n        <h2 class=\"text-muted\">");
            EndContext();
            BeginContext(127, 10, false);
#line 5 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\Directors\Detail.cshtml"
                          Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(137, 52, true);
            WriteLiteral("</h2>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        ");
            EndContext();
            BeginContext(189, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90252cd5ae7e4289a3b51c2eedfe0f4e", async() => {
                BeginContext(293, 28, true);
                WriteLiteral("\r\n            Edit\r\n        ");
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
#line 9 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\Directors\Detail.cshtml"
                                                          WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(325, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(335, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ef877cf6d9e452f9375b13368c260f3", async() => {
                BeginContext(440, 30, true);
                WriteLiteral("\r\n            Delete\r\n        ");
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
#line 12 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\Directors\Detail.cshtml"
                                                            WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(474, 298, true);
            WriteLiteral(@"
    </div>

    <div class=""small-padding"">
        <div class=""panel panel-primary"">
            <div class=""panel-body"">
                <h3>Info</h3>
                <div class=""bg-info group-border"">
                    <div class=""mini-padding""><span class=""panelHeader"">Name:</span> ");
            EndContext();
            BeginContext(773, 10, false);
#line 22 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\Directors\Detail.cshtml"
                                                                                Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(783, 97, true);
            WriteLiteral("</div>\r\n                    <div class=\"mini-padding\"><span class=\"panelHeader\">Birthday:</span> ");
            EndContext();
            BeginContext(881, 14, false);
#line 23 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\Directors\Detail.cshtml"
                                                                                    Write(Model.Birthday);

#line default
#line hidden
            EndContext();
            BeginContext(895, 99, true);
            WriteLiteral("</div>\r\n                    <div class=\"mini-padding\"><span class=\"panelHeader\">Birthplace:</span> ");
            EndContext();
            BeginContext(995, 16, false);
#line 24 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\Directors\Detail.cshtml"
                                                                                      Write(Model.Birthplace);

#line default
#line hidden
            EndContext();
            BeginContext(1011, 92, true);
            WriteLiteral("</div>\r\n                    <div class=\"mini-padding\"><span class=\"panelHeader\">Bio:</span> ");
            EndContext();
            BeginContext(1104, 9, false);
#line 25 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\Directors\Detail.cshtml"
                                                                               Write(Model.Bio);

#line default
#line hidden
            EndContext();
            BeginContext(1113, 137, true);
            WriteLiteral("</div>\r\n                </div>\r\n                <div>\r\n                    <h3>Movies</h3>\r\n                    <ul class=\"list-group\">\r\n");
            EndContext();
#line 30 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\Directors\Detail.cshtml"
                         foreach (KeyValuePair<int, string> movie in Model.Movies)
                        {

#line default
#line hidden
            BeginContext(1361, 90, true);
            WriteLiteral("                            <li class=\"list-group-item\">\r\n                                ");
            EndContext();
            BeginContext(1451, 161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a0cafc7fdb446d3860c983029c42af1", async() => {
                BeginContext(1524, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(1563, 11, false);
#line 34 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\Directors\Detail.cshtml"
                               Write(movie.Value);

#line default
#line hidden
                EndContext();
                BeginContext(1574, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\Directors\Detail.cshtml"
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
            BeginContext(1612, 37, true);
            WriteLiteral("\r\n                            </li>\r\n");
            EndContext();
#line 37 "C:\Users\Jon\Documents\krr\app\KKRTheater\KKRTheater\Views\Directors\Detail.cshtml"
                        }

#line default
#line hidden
            BeginContext(1676, 109, true);
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DirectorDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
