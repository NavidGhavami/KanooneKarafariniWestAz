#pragma checksum "E:\Programming\Codes and projects\Kanoone Karafarini WestAz\KanooneKarafarini_WestAz\ServiceHost\Pages\TrueEntrepreneur.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07f5739cc770d23de1200b1aed8e71be3d782850"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_TrueEntrepreneur), @"mvc.1.0.razor-page", @"/Pages/TrueEntrepreneur.cshtml")]
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
#nullable restore
#line 2 "E:\Programming\Codes and projects\Kanoone Karafarini WestAz\KanooneKarafarini_WestAz\ServiceHost\Pages\TrueEntrepreneur.cshtml"
using System.Collections.Specialized;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07f5739cc770d23de1200b1aed8e71be3d782850", @"/Pages/TrueEntrepreneur.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TrueEntrepreneur : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 5 "E:\Programming\Codes and projects\Kanoone Karafarini WestAz\KanooneKarafarini_WestAz\ServiceHost\Pages\TrueEntrepreneur.cshtml"
  
    ViewData["Title"] = "ثبت نام کارآفرین حقیقی";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""container-fluid mt-3 error404"">
    <div class=""container p-3 box"">
        <div class=""row"">
            <div class=""col-md-12"">
                <h4 class=""bt-color pb-3 IRANSansWeb_Light pr-4"">عضویت حقیقی کانون کارآفرینی استان آذربایجان غربی</h4>
                <hr />
                <hr />
                <br />
                <div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07f5739cc770d23de1200b1aed8e71be3d7828505126", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-lg-6 col-md-6"">
                                <label class=""control-label"" for=""name"">نام </label>
                                <input class=""form-control"" name=""name"" id=""name"" type=""text"" placeholder=""نام"" required oninvalid=""this.setCustomValidity('لطفا نام خود را وارد کنید')"">
                            </div>
                            <div class=""col-lg-6 col-md-6"">
                                <label class=""control-label"" for=""family"">نام خانوادگی</label>
                                <input class=""form-control"" name=""family"" id=""family"" type=""text"" placeholder=""نام و نام خانوادگی"" required oninvalid=""this.setCustomValidity('لطفا نام خانوادگی خود را وارد کنید')"">
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-4 col-md-4"">
                                <label class=""control-label"" for=");
                WriteLiteral(@"""nationalId"">کد ملی </label>
                                <input class=""form-control"" name=""nationalId"" id=""nationalId"" type=""text"" maxlength=""10"" pattern=""[0-9]{10}"" placeholder=""کد ملی 10 رقمی"" required oninvalid=""this.setCustomValidity('لطفا کد ملی 10 رقمی خود را وارد کنید')"">

                            </div>
                            <div class=""col-lg-4 col-md-4"">
                                <label class=""control-label"" for=""birthDate"">تاریخ تولد</label>
                                <input class=""form-control"" name=""birthDate"" id=""birthDate"" type=""text"" maxlength=""10"" pattern=""([12]\d{3}/(0[1-9]|1[0-2])/(0[1-9]|[12]\d|3[01]))"" placeholder=""مثال: 1372/11/26"" required oninvalid=""this.setCustomValidity('لطفا تاریخ تولد خود را وارد کنید')"">
                            </div>
                            <div class=""col-lg-4 col-md-4"">
                                <label class=""control-label"" for=""activitySubject"">عنوان فعالیت اقتصادی</label>
                                <input c");
                WriteLiteral(@"lass=""form-control"" name=""activitySubject"" id=""activitySubject"" type=""text"" placeholder=""عنوان فعالیت اقتصادی"" required oninvalid=""this.setCustomValidity('لطفا عنوان فعالیت اقتصادی خود را وارد کنید')"">
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-4 col-md-4"">
                                <label class=""control-label"" for=""city"">شهر محل فعالیت </label>
                                <input class=""form-control"" name=""city"" id=""city"" type=""text"" placeholder=""شهر محل فعالیت"" required oninvalid=""this.setCustomValidity('لطفا شهر محل فعالیت خود را وارد کنید')"">

                            </div>
                            <div class=""col-lg-4 col-md-4"">
                                <label class=""control-label"" for=""phone"">تلفن ثابت</label>
                                <input class=""form-control"" name=""phone"" id=""phone"" type=""text"" maxlength=""11"" pattern=""[0-9]{11}"" placeholder=""مثال: 02");
                WriteLiteral(@"112345678"" required oninvalid=""this.setCustomValidity('لطفا تلفن ثابت خود را وارد کنید')"">
                            </div>
                            <div class=""col-lg-4 col-md-4"">
                                <label class=""control-label"" for=""mobile"">موبایل</label>
                                <input class=""form-control"" name=""mobile"" id=""mobile"" type=""text"" maxlength=""11"" pattern=""[0-9]{11}"" placeholder=""مثال: 09121234567"" required oninvalid=""this.setCustomValidity('لطفا موبایل خود را وارد کنید')"">
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12 col-md-12"">
                                <label class=""control-label"" for=""address"">آدرس محل سکونت </label>
                                <textarea class=""form-control area mb-2"" name=""address"" id=""address"" cols=""60"" rows=""9"" placeholder=""آدرس محل سکونت"" style=""height: 150px!important"" required oninvalid=""this.setCustomValidity('لطف");
                WriteLiteral(@"ا آدرس محل سکونت خود را وارد کنید')""></textarea>

                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-12 col-md-12"">
                                <label class=""control-label"" for=""resume"">آپلود رزومه</label>
                                <br />
                                <label class=""control-label text-danger"" for=""resume"">نکته: فایل مورد نظر حتما باید به صورت pdf باشد</label>
                                <input");
                BeginWriteAttribute("class", " class=\"", 5277, "\"", 5285, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""resume"" id=""resume"" type=""file"" required 
                                       oninvalid=""this.setCustomValidity('لطفا رزومه خود را آپلود کنید')"" accept="".pdf"">
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
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.TrueEntrepreneurModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.TrueEntrepreneurModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.TrueEntrepreneurModel>)PageContext?.ViewData;
        public ServiceHost.Pages.TrueEntrepreneurModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
