#pragma checksum "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\NHANVIEN\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "676fe39bbd46f0ff876847abfe43764b4200dc42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_NHANVIEN_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/NHANVIEN/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/NHANVIEN/Create.cshtml", typeof(AspNetCore.Areas_Admin_Views_NHANVIEN_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"676fe39bbd46f0ff876847abfe43764b4200dc42", @"/Areas/Admin/Views/NHANVIEN/Create.cshtml")]
    public class Areas_Admin_Views_NHANVIEN_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project.Models.Taikhoan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/NHANVIEN/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\NHANVIEN\Create.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(139, 257, true);
            WriteLiteral(@"
<div class=""row mt-3"">
    <div class=""col-md-2""></div>
    <div class=""col-lg-8"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""card-title"">Thêm mới nhân viên</div>
                <hr>
                ");
            EndContext();
            BeginContext(396, 5070, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a25a8d5ecaf547b49fd9e93245a6296e", async() => {
                BeginContext(479, 381, true);
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""form-group col-md-12"">
                            <label for=""input-1"">Tên nhân viên <span style=""color:red"">(*)</span></label>
                            <input type=""text"" name=""Ten"" class=""form-control"" id=""input-1"" placeholder=""Tên nhân viên"">
                            <b class=""text-danger"">");
                EndContext();
                BeginContext(861, 11, false);
#line 20 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\NHANVIEN\Create.cshtml"
                                              Write(ViewBag.Ten);

#line default
#line hidden
                EndContext();
                BeginContext(872, 379, true);
                WriteLiteral(@"</b>
                        </div>
                        <div class=""form-group col-md-6"">
                            <label for=""input-2"">Số điện thoại <span style=""color:red"">(*)</span></label>
                            <input type=""number"" name=""Sdt"" class=""form-control"" id=""input-2"" placeholder=""Số điện thoại"">
                            <b class=""text-danger"">");
                EndContext();
                BeginContext(1252, 11, false);
#line 25 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\NHANVIEN\Create.cshtml"
                                              Write(ViewBag.Sdt);

#line default
#line hidden
                EndContext();
                BeginContext(1263, 57, true);
                WriteLiteral("</b>\r\n                            <b class=\"text-danger\">");
                EndContext();
                BeginContext(1321, 12, false);
#line 26 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\NHANVIEN\Create.cshtml"
                                              Write(ViewBag.Sdtt);

#line default
#line hidden
                EndContext();
                BeginContext(1333, 374, true);
                WriteLiteral(@"</b>
                        </div>
                        <div class=""form-group col-md-6"">
                            <label for=""input-2"">Ngày sinh <span style=""color:red"">(*)</span></label>
                            <input type=""date"" name=""Ngaysinh"" class=""form-control"" id=""input-2"" placeholder=""Ngày sinh"">
                            <b class=""text-danger"">");
                EndContext();
                BeginContext(1708, 16, false);
#line 31 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\NHANVIEN\Create.cshtml"
                                              Write(ViewBag.Ngaysinh);

#line default
#line hidden
                EndContext();
                BeginContext(1724, 364, true);
                WriteLiteral(@"</b>
                        </div>
                        <div class=""form-group col-md-12"">
                            <label for=""input-3"">Email <span style=""color:red"">(*)</span></label>
                            <input type=""text"" name=""Email"" class=""form-control"" id=""input-3"" placeholder=""Email"">
                            <b class=""text-danger"">");
                EndContext();
                BeginContext(2089, 13, false);
#line 36 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\NHANVIEN\Create.cshtml"
                                              Write(ViewBag.Email);

#line default
#line hidden
                EndContext();
                BeginContext(2102, 419, true);
                WriteLiteral(@"</b>
                        </div>
                        <div class=""form-group col-md-8"">
                            <label for=""input-2"">Số căn cước công dân/chứng minh <span style=""color:red"">(*)</span></label>
                            <input type=""number"" name=""Socmtnd"" class=""form-control"" id=""input-2"" placeholder=""Số căn cước công dân/chứng minh"">
                            <b class=""text-danger"">");
                EndContext();
                BeginContext(2522, 15, false);
#line 41 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\NHANVIEN\Create.cshtml"
                                              Write(ViewBag.Socmtnd);

#line default
#line hidden
                EndContext();
                BeginContext(2537, 57, true);
                WriteLiteral("</b>\r\n                            <b class=\"text-danger\">");
                EndContext();
                BeginContext(2595, 16, false);
#line 42 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\NHANVIEN\Create.cshtml"
                                              Write(ViewBag.Socmtndd);

#line default
#line hidden
                EndContext();
                BeginContext(2611, 665, true);
                WriteLiteral(@"</b>
                        </div>
                        <div class=""form-group col-md-4"">
                            <label for=""input-2"">Ảnh đại diện</label>
                            <input type=""file"" name=""Files"" class=""form-control"" id=""input-2"" placeholder=""Enter Your Email Address"">
                        </div>
                        <div class=""form-group col-md-8"">
                            <label for=""input-3"">Địa chỉ <span style=""color:red"">(*)</span></label>
                            <input type=""text"" name=""Diachi"" class=""form-control"" id=""input-3"" placeholder=""Địa chỉ"">
                            <b class=""text-danger"">");
                EndContext();
                BeginContext(3277, 14, false);
#line 51 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\NHANVIEN\Create.cshtml"
                                              Write(ViewBag.Diachi);

#line default
#line hidden
                EndContext();
                BeginContext(3291, 370, true);
                WriteLiteral(@"</b>
                        </div>
                        <div class=""form-group col-md-6"">
                            <label for=""input-2"">Mật khẩu <span style=""color:red"">(*)</span></label>
                            <input type=""text"" name=""Makhau"" class=""form-control"" id=""input-2"" placeholder=""Mật khẩu"">
                            <b class=""text-danger"">");
                EndContext();
                BeginContext(3662, 14, false);
#line 56 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\NHANVIEN\Create.cshtml"
                                              Write(ViewBag.MaKhau);

#line default
#line hidden
                EndContext();
                BeginContext(3676, 305, true);
                WriteLiteral(@"</b>
                        </div>
                        <div class=""form-group col-md-6"">
                            <label for=""input-2"">Chi nhánh<span style=""color:red"">(*)</span></label>
                            <select class=""form-control"" name=""Chinhanh"" id=""exampleFormControlSelect1"">
");
                EndContext();
#line 61 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\NHANVIEN\Create.cshtml"
                                 foreach (var item in ViewBag.Chinhanh)
                                {

#line default
#line hidden
                BeginContext(4089, 43, true);
                WriteLiteral("                                    <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4132, "\"", 4148, 1);
#line 63 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\NHANVIEN\Create.cshtml"
WriteAttributeValue("", 4140, item.Id, 4140, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4149, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(4151, 16, false);
#line 63 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\NHANVIEN\Create.cshtml"
                                                        Write(item.Tenchinhanh);

#line default
#line hidden
                EndContext();
                BeginContext(4167, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 64 "C:\Users\Tien\Documents\Project\Project\Project\Areas\Admin\Views\NHANVIEN\Create.cshtml"
                                }

#line default
#line hidden
                BeginContext(4213, 1246, true);
                WriteLiteral(@"                            </select>
                        </div>
                        <div class=""col-md-3"">
                            <div class=""custom-control custom-radio custom-control-inline"">
                                <input type=""radio"" value=""1"" id=""customRadioInline1"" name=""Trangthai"" class=""custom-control-input"" checked>
                                <label class=""custom-control-label"" for=""customRadioInline1"">Hoạt động</label>
                            </div>
                        </div>
                        <div class=""col.md-3"">
                            <div class=""custom-control custom-radio custom-control-inline"">
                                <input type=""radio"" value=""2"" id=""customRadioInline2"" name=""Trangthai"" class=""custom-control-input"">
                                <label class=""custom-control-label"" for=""customRadioInline2"">Không hoạt động</label>
                            </div>
                        </div>
                    </div>   ");
                WriteLiteral("        \r\n                    <div class=\"form-group mt-4\">\r\n                        <button type=\"submit\" class=\"btn btn-light px-5\"><i class=\"icon-lock\"></i>Thêm mới</button>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5466, 106, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-2\"></div>\r\n</div><!--End Row-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.Models.Taikhoan> Html { get; private set; }
    }
}
#pragma warning restore 1591