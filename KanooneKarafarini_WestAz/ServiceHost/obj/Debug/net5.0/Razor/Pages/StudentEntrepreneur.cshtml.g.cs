#pragma checksum "E:\Codes and projects\Kanoone Karafarini WestAz\KanooneKarafarini_WestAz\ServiceHost\Pages\StudentEntrepreneur.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0767533d6e73510f3992b6c1ae49bb5ac9bd647d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_StudentEntrepreneur), @"mvc.1.0.razor-page", @"/Pages/StudentEntrepreneur.cshtml")]
namespace ServiceHost.Pages
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
#line 1 "E:\Codes and projects\Kanoone Karafarini WestAz\KanooneKarafarini_WestAz\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0767533d6e73510f3992b6c1ae49bb5ac9bd647d", @"/Pages/StudentEntrepreneur.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_StudentEntrepreneur : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-right: 15px; padding-left: 15px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Codes and projects\Kanoone Karafarini WestAz\KanooneKarafarini_WestAz\ServiceHost\Pages\StudentEntrepreneur.cshtml"
  
    ViewData["Title"] = "?????? ?????? ???????????????? ????????????";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""container-fluid mt-3 error404"">
    <div class=""container p-3 box"">
        <div class=""row"">
            <div class=""col-md-12"">
                <h4 class=""bt-color pb-3 IRANSansWeb_Light pr-4"">?????????? ???????????????????? ???????????? ?????????? ?????????????????? ?????????? ?????????????????? ????????</h4>
                <hr />
                <hr />
                <br />
                <div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0767533d6e73510f3992b6c1ae49bb5ac9bd647d4921", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-lg-6 col-md-6"">
                                <label class=""control-label"" for=""studentName"">?????? </label>
                                <input class=""form-control"" name=""studentName"" id=""studentName"" type=""text"" placeholder=""?????? ???????? ????????"" required oninvalid=""this.setCustomValidity('???????? ?????? ?????? ???? ???????? ????????')"">
                            </div>
                            <div class=""col-lg-6 col-md-6"">
                                <label class=""control-label"" for=""studentFamily"">?????? ????????????????</label>
                                <input class=""form-control"" name=""studentFamily"" id=""studentFamily"" type=""text"" placeholder=""?????? ?? ?????? ???????????????? ???????? ????????"" required oninvalid=""this.setCustomValidity('???????? ?????? ???????????????? ?????? ???? ???????? ????????')"">
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-4 col-md-4"">
   ");
                WriteLiteral(@"                             <label class=""control-label"" for=""studentNationalId"">???? ?????? </label>
                                <input class=""form-control"" name=""studentNationalId"" id=""studentNationalId"" type=""text"" maxlength=""10"" pattern=""[0-9]{10}"" placeholder=""???? ?????? 10 ???????? ???????? ????????"" required oninvalid=""this.setCustomValidity('???????? ???? ?????? 10 ???????? ?????? ???? ???????? ????????')"">

                            </div>
                            <div class=""col-lg-4 col-md-4"">
                                <label class=""control-label"" for=""studentBirthDate"">?????????? ????????</label>
                                <input class=""form-control"" name=""studentBirthDate"" id=""studentBirthDate"" type=""text"" maxlength=""10"" pattern=""([12]\d{3}/(0[1-9]|1[0-2])/(0[1-9]|[12]\d|3[01]))"" placeholder=""????????: 1372/11/26"" required oninvalid=""this.setCustomValidity('???????? ?????????? ???????? ?????? ???? ???????? ????????')"">
                            </div>
                            <div class=""col-lg-4 col-md-4"">
                                <label ");
                WriteLiteral(@"class=""control-label"" for=""education"">???????? ????????????</label>
                                <input class=""form-control"" name=""education"" id=""education"" type=""text"" placeholder=""???????? ????????????"" required oninvalid=""this.setCustomValidity('???????? ???????? ???????????? ?????? ???? ???????? ????????')"">
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-6 col-md-6"">
                                <label class=""control-label"" for=""studentSchool"">?????? ??????????</label>
                                <input class=""form-control"" name=""studentSchool"" id=""studentSchool"" type=""text"" placeholder=""?????? ??????????"" required oninvalid=""this.setCustomValidity('???????? ?????? ?????????? ?????? ???? ???????? ????????')"">

                            </div>
                            <div class=""col-lg-6 col-md-6"">
                                <label class=""control-label"" for=""studentCity"">?????? ?????? ??????????</label>
                                <input class=""form-control"" na");
                WriteLiteral(@"me=""studentCity"" id=""studentCity"" type=""text"" placeholder=""?????? ?????? ??????????"" required oninvalid=""this.setCustomValidity('???????? ?????? ?????? ?????????? ?????? ???? ???????? ????????')"">
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-4 col-md-4"">
                                <label class=""control-label"" for=""parentFullname"">?????? ?? ?????? ???????????????? ?????? ???????? ????????</label>
                                <input class=""form-control"" name=""parentFullname"" id=""parentFullname"" type=""text"" placeholder=""?????? ?? ?????? ???????????????? ?????? ???????? ????????"" required oninvalid=""this.setCustomValidity('???????? ?????? ???????? ?????? ???????? ???????? ???? ???????? ????????')"">

                            </div>
                            <div class=""col-lg-4 col-md-4"">
                                <label class=""control-label"" for=""parentNationalId"">???? ?????? ??????</label>
                                <input class=""form-control"" name=""parentNationalId"" id=""parentNationalId"" type=""tex");
                WriteLiteral(@"t"" maxlength=""10"" pattern=""[0-9]{10}"" placeholder=""???? ?????? 10 ???????? ??????"" required oninvalid=""this.setCustomValidity('???????? ???? ?????? ?????? ?????? ???? ???????? ????????')"">
                            </div>
                            <div class=""col-lg-4 col-md-4"">
                                <label class=""control-label"" for=""parentJob"">?????? ??????</label>
                                <input class=""form-control"" name=""parentJob"" id=""parentJob"" type=""text"" placeholder=""?????? ??????"" required oninvalid=""this.setCustomValidity('???????? ?????? ?????? ?????? ???? ???????? ????????')"">
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-6 col-md-6"">
                                <label class=""control-label"" for=""studentPhone"">???????? ???????? </label>
                                <input class=""form-control"" name=""studentPhone"" id=""studentPhone"" type=""text"" maxlength=""11"" pattern=""[0-9]{11}"" placeholder=""????????: 02112345678"" required oninvalid=""this.s");
                WriteLiteral(@"etCustomValidity('???????? ???????? ???????? ?????? ???? ???????? ????????')"">

                            </div>
                            <div class=""col-lg-6 col-md-6"">
                                <label class=""control-label"" for=""studentMobile"">????????????</label>
                                <input class=""form-control"" name=""studentMobile"" id=""studentMobile"" type=""text"" maxlength=""11"" pattern=""[0-9]{11}"" placeholder=""????????: 09121234567"" required oninvalid=""this.setCustomValidity('???????? ???????????? ?????? ???? ???????? ????????')"">
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12 col-md-12"">
                                <label class=""control-label"" for=""studentAddress"">???????? ?????? ?????????? </label>
                                <textarea class=""form-control area mb-2"" name=""studentAddress"" id=""studentAddress"" cols=""60"" rows=""9"" placeholder=""???????? ?????? ??????????"" style=""height: 150px!important"" required oninvalid=""this.setCustomValidi");
                WriteLiteral(@"ty('???????? ???????? ?????? ?????????? ?????? ???? ???????? ????????')""></textarea>

                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12 col-md-12"">
                                <label class=""control-label"" for=""studentNationalCardPicture"">?????????? ?????????? ???????? ??????</label>
                                <br />
                                <label class=""control-label text-danger"" for=""studentNationalCardPicture"">????????: ???????? ???????? ?????? ???????? ???????? ???? ???????? jpg ?? ????  png ????????</label>
                                <input");
                BeginWriteAttribute("class", " class=\"", 7368, "\"", 7376, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""studentNationalCardPicture"" id=""studentNationalCardPicture"" type=""file"" required
                                       oninvalid=""this.setCustomValidity('???????? ?????????? ???????? ?????? ?????? ???? ?????????? ????????')"" accept="".jpg , .png"">
                            </div>
                        </div>
                        <button class=""btn btn-grad btn-block text-white mb-3 py-2"" type=""submit"">?????????? ?????????????? ?? ?????? ??????<i class=""fa fa-chevron-left mr-2""></i> </button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.StudentEntrepreneurModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.StudentEntrepreneurModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.StudentEntrepreneurModel>)PageContext?.ViewData;
        public ServiceHost.Pages.StudentEntrepreneurModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
