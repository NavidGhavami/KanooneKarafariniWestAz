#pragma checksum "E:\Programming\Codes and projects\Kanoone Karafarini WestAz\KanooneKarafarini_WestAz\ServiceHost\Pages\StudentEntrepreneur.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffd2a7488e758b8e2dba0b11e9d2f499ad2572c4"
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
#line 1 "E:\Programming\Codes and projects\Kanoone Karafarini WestAz\KanooneKarafarini_WestAz\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffd2a7488e758b8e2dba0b11e9d2f499ad2572c4", @"/Pages/StudentEntrepreneur.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_StudentEntrepreneur : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "E:\Programming\Codes and projects\Kanoone Karafarini WestAz\KanooneKarafarini_WestAz\ServiceHost\Pages\StudentEntrepreneur.cshtml"
  
    ViewData["Title"] = "ثبت نام کارآفرین نوجوان";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""container-fluid mt-3 error404"">
    <div class=""container p-3 box"">
        <div class=""row"">
            <div class=""col-md-12"">
                <h4 class=""bt-color pb-3 IRANSansWeb_Light pr-4"">عضویت کارآفرینان نوجوان کانون کارآفرینی استان آذربایجان غربی</h4>
                <hr />
                <hr />
                <br />
                <div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffd2a7488e758b8e2dba0b11e9d2f499ad2572c44911", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-lg-6 col-md-6"">
                                <label class=""control-label"" for=""studentName"">نام </label>
                                <input class=""form-control"" name=""studentName"" id=""studentName"" type=""text"" placeholder=""نام دانش آموز"" required oninvalid=""this.setCustomValidity('لطفا نام خود را وارد کنید')"">
                            </div>
                            <div class=""col-lg-6 col-md-6"">
                                <label class=""control-label"" for=""studentFamily"">نام خانوادگی</label>
                                <input class=""form-control"" name=""studentFamily"" id=""studentFamily"" type=""text"" placeholder=""نام و نام خانوادگی دانش آموز"" required oninvalid=""this.setCustomValidity('لطفا نام خانوادگی خود را وارد کنید')"">
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-4 col-md-4"">
   ");
                WriteLiteral(@"                             <label class=""control-label"" for=""studentNationalId"">کد ملی </label>
                                <input class=""form-control"" name=""studentNationalId"" id=""studentNationalId"" type=""text"" placeholder=""کد ملی 10 رقمی دانش آموز"" required oninvalid=""this.setCustomValidity('لطفا کد ملی 10 رقمی خود را وارد کنید')"">

                            </div>
                            <div class=""col-lg-4 col-md-4"">
                                <label class=""control-label"" for=""studentBirthDate"">تاریخ تولد</label>
                                <input class=""form-control"" name=""studentBirthDate"" id=""studentBirthDate"" type=""text"" placeholder=""تاریخ تولد: 1372/11/26"" required oninvalid=""this.setCustomValidity('لطفا تاریخ تولد خود را وارد کنید')"">
                            </div>
                            <div class=""col-lg-4 col-md-4"">
                                <label class=""control-label"" for=""education"">مقطع تحصیلی</label>
                                <input class=");
                WriteLiteral(@"""form-control"" name=""education"" id=""education"" type=""text"" placeholder=""مقطع تحصیلی"" required oninvalid=""this.setCustomValidity('لطفا مقطع تحصیلی خود را وارد کنید')"">
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-6 col-md-6"">
                                <label class=""control-label"" for=""studentSchool"">نام مدرسه</label>
                                <input class=""form-control"" name=""studentSchool"" id=""studentSchool"" type=""text"" placeholder=""نام مدرسه"" required oninvalid=""this.setCustomValidity('لطفا نام مدرسه خود را وارد کنید')"">

                            </div>
                            <div class=""col-lg-6 col-md-6"">
                                <label class=""control-label"" for=""studentCity"">شهر محل تحصیل</label>
                                <input class=""form-control"" name=""studentCity"" id=""studentCity"" type=""text"" placeholder=""شهر محل تحصیل"" required oninvalid=""this.setCu");
                WriteLiteral(@"stomValidity('لطفا شهر محل تحصیل خود را وارد کنید')"">
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-4 col-md-4"">
                                <label class=""control-label"" for=""parentFullname"">نام و نام خانوادگی ولی دانش آموز</label>
                                <input class=""form-control"" name=""parentFullname"" id=""parentFullname"" type=""text"" placeholder=""نام و نام خانوادگی ولی دانش آموز"" required oninvalid=""this.setCustomValidity('لطفا نام کامل ولی دانش آموز را وارد کنید')"">

                            </div>
                            <div class=""col-lg-4 col-md-4"">
                                <label class=""control-label"" for=""parentNationalId"">کد ملی ولی</label>
                                <input class=""form-control"" name=""parentNationalId"" id=""parentNationalId"" type=""text"" placeholder=""کد ملی ولی"" required oninvalid=""this.setCustomValidity('لطفا کد ملی ولی خود را وارد کنید");
                WriteLiteral(@"')"">
                            </div>
                            <div class=""col-lg-4 col-md-4"">
                                <label class=""control-label"" for=""parentJob"">شغل ولی</label>
                                <input class=""form-control"" name=""parentJob"" id=""parentJob"" type=""text"" placeholder=""مثال: 09121234567"" required oninvalid=""this.setCustomValidity('لطفا شغل ولی خود را وارد کنید')"">
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-6 col-md-6"">
                                <label class=""control-label"" for=""studentPhone"">تلفن ثابت </label>
                                <input class=""form-control"" name=""studentPhone"" id=""studentPhone"" type=""text"" placeholder=""مثال: 02112345678"" required oninvalid=""this.setCustomValidity('لطفا تلفن ثابت خود را وارد کنید')"">

                            </div>
                            <div class=""col-lg-6 col-md-6"">
                  ");
                WriteLiteral(@"              <label class=""control-label"" for=""studentMobile"">موبایل</label>
                                <input class=""form-control"" name=""studentMobile"" id=""studentMobile"" type=""text"" placeholder=""مثال: 09121234567"" required oninvalid=""this.setCustomValidity('لطفا موبایل خود را وارد کنید')"">
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12 col-md-12"">
                                <label class=""control-label"" for=""studentAddress"">آدرس محل سکونت </label>
                                <input class=""form-control"" name=""studentAddress"" id=""studentAddress"" type=""text"" placeholder=""آدرس محل سکونت"" required oninvalid=""this.setCustomValidity('لطفا آدرس محل سکونت خود را وارد کنید')"">
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12 col-md-12"">
                                <label ");
                WriteLiteral(@"class=""control-label"" for=""studentNationalCardPicture"">آپلود تصویر کارت ملی</label>
                                <br />
                                <label class=""control-label text-danger"" for=""studentNationalCardPicture"">نکته: فایل مورد نظر حتما باید به صورت jpg و یا  png باشد</label>
                                <input");
                BeginWriteAttribute("class", " class=\"", 7096, "\"", 7104, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""studentNationalCardPicture"" id=""studentNationalCardPicture"" type=""file"" required
                                       oninvalid=""this.setCustomValidity('لطفا تصویر کارت ملی خود را آپلود کنید')"" accept="".jpg , .png"">
                            </div>
                        </div>
                        <button class=""btn btn-grad btn-block text-white mb-3 py-2"" type=""submit"">تایید اطلاعات و ثبت نام<i class=""fa fa-chevron-left mr-2""></i> </button>
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.StudentEntrepreneurModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.StudentEntrepreneurModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.StudentEntrepreneurModel>)PageContext?.ViewData;
        public ServiceHost.Pages.StudentEntrepreneurModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
