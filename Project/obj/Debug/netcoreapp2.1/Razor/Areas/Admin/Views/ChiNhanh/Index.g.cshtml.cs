#pragma checksum "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "225ffabe5f04638679ef516515f4141a663923f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ChiNhanh_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ChiNhanh/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ChiNhanh/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_ChiNhanh_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"225ffabe5f04638679ef516515f4141a663923f8", @"/Areas/Admin/Views/ChiNhanh/Index.cshtml")]
    public class Areas_Admin_Views_ChiNhanh_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Project.Models.Chinhanh>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ml-4 btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/NHANVIEN/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-bar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("get"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/NHANVIEN/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ml-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/ChiNhanh/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/ChiNhanh/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(152, 323, true);
            WriteLiteral(@"
<div class=""card mt-3"">
    <div class=""card-content"">
        <div class=""row row-group m-0"">
            <div class=""col-12 col-lg-12 col-xl-12 border-light"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-2"">
                            ");
            EndContext();
            BeginContext(475, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0331e5e27bff466bb7a94f9d00a865ec", async() => {
                BeginContext(538, 8, true);
                WriteLiteral("Thêm mới");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(550, 110, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-8\">\r\n                            ");
            EndContext();
            BeginContext(660, 411, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c4629bb83664a17bc41aeca32e709e1", async() => {
                BeginContext(730, 334, true);
                WriteLiteral(@"
                                <input type=""text"" name=""search"" class=""form-control"" placeholder=""Enter keywords"">
                                <button href=""javascript:void();""><i class=""icon-magnifier"" style=""position: absolute;margin-top: -40px;margin-left: 496px;color: #ffffff;""></i></button>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1071, 156, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>    \r\n        \r\n");
            EndContext();
#line 30 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
 if (TempData["OK"] != null)
{

#line default
#line hidden
            BeginContext(1260, 96, true);
            WriteLiteral("    <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n        <strong>");
            EndContext();
            BeginContext(1357, 14, false);
#line 33 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
           Write(TempData["OK"]);

#line default
#line hidden
            EndContext();
            BeginContext(1371, 181, true);
            WriteLiteral("</strong>\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n    </div>\r\n");
            EndContext();
#line 38 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1555, 693, true);
            WriteLiteral(@"
<div class=""row mt-3"">
    <div class=""col-lg-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title"">Danh sách chi nhanh</h5>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th scope=""col"">STT</th>
                                <th scope=""col"">Tenchinhanh</th>
                                <th scope=""col"">Diachi</th>
                                <th scope=""col"">Hành động</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 56 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(2337, 138, true);
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">1</th>\r\n                                    <td>");
            EndContext();
            BeginContext(2476, 16, false);
#line 60 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
                                   Write(item.Tenchinhanh);

#line default
#line hidden
            EndContext();
            BeginContext(2492, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2540, 11, false);
#line 61 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
                                   Write(item.Diachi);

#line default
#line hidden
            EndContext();
            BeginContext(2551, 89, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2640, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0809aea384bc4a06a5e749aaf71b964c", async() => {
                BeginContext(2685, 117, true);
                WriteLiteral("\r\n                                            <i class=\"ti-pencil-alt\"></i>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2649, "~/Admin/ChiNhanh/Index?id=", 2649, 26, true);
#line 63 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
AddHtmlAttributeValue("", 2675, item.Id, 2675, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2806, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2848, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a74a8421a634bc0928674b7863fca95", async() => {
                BeginContext(2907, 112, true);
                WriteLiteral("\r\n                                            <i class=\"ti-trash\"></i>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2870, "~/Admin/ChiNhanh/Delete?id=", 2870, 27, true);
#line 66 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
AddHtmlAttributeValue("", 2897, item.Id, 2897, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3023, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 71 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3138, 231, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-lg-6\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n");
            EndContext();
#line 82 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
                 if (ViewBag.edit.Id == 0)
                {

#line default
#line hidden
            BeginContext(3432, 70, true);
            WriteLiteral("                    <div class=\"card-title\">Thêm mới chi nhánh</div>\r\n");
            EndContext();
#line 85 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3562, 70, true);
            WriteLiteral("                    <div class=\"card-title\">Câp nhật chi nhánh</div>\r\n");
            EndContext();
#line 89 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3651, 40, true);
            WriteLiteral("\r\n                <hr>\r\n                ");
            EndContext();
            BeginContext(3691, 1446, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74399ae4c5db44179dbe3c5b0825b3d6", async() => {
                BeginContext(3744, 102, true);
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3846, "\"", 3870, 1);
#line 94 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
WriteAttributeValue("", 3854, ViewBag.edit.Id, 3854, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3871, 160, true);
                WriteLiteral(" class=\"form-control\" id=\"input-1\" />\r\n                        <label for=\"input-1\">Tên chi nhánh</label>\r\n                        <input type=\"text\" name=\"Ten\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4031, "\"", 4064, 1);
#line 96 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
WriteAttributeValue("", 4039, ViewBag.edit.Tenchinhanh, 4039, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4065, 112, true);
                WriteLiteral(" class=\"form-control\" id=\"input-2\" placeholder=\"Tên chi nhánh\">\r\n                        <b class=\"text-danger\">");
                EndContext();
                BeginContext(4178, 11, false);
#line 97 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
                                          Write(ViewBag.Ten);

#line default
#line hidden
                EndContext();
                BeginContext(4189, 198, true);
                WriteLiteral("</b>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"input-2\">Địa chỉ</label>\r\n                        <input type=\"text\" name=\"Diachi\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4387, "\"", 4415, 1);
#line 101 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
WriteAttributeValue("", 4395, ViewBag.edit.Diachi, 4395, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4416, 135, true);
                WriteLiteral(" class=\"form-control\" id=\"input-3\" placeholder=\"Địa chỉ\">\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n");
                EndContext();
#line 105 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
                         if (ViewBag.edit.Id == 0)
                        {

#line default
#line hidden
                BeginContext(4630, 122, true);
                WriteLiteral("                            <button type=\"submit\" class=\"btn btn-light px-5\"><i class=\"icon-lock\"></i> Thêm mới</button>\r\n");
                EndContext();
#line 108 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(4836, 150, true);
                WriteLiteral("                            <button type=\"submit\" class=\"btn btn-light px-5\"><i class=\"icon-lock\"></i> Cập nhật</button>\r\n                            ");
                EndContext();
                BeginContext(4986, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76899d27e02d4b40bec98f8d5e122412", async() => {
                    BeginContext(5048, 3, true);
                    WriteLiteral("Huỷ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5055, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 113 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\ChiNhanh\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(5084, 46, true);
                WriteLiteral("\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5137, 70, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div><!--End Row-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Project.Models.Chinhanh>> Html { get; private set; }
    }
}
#pragma warning restore 1591
