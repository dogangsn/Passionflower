#pragma checksum "D:\Dogan\Project\Passionflower\Passionflower\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaa66570ee213ab1ce90b308aefc8760ee5a72b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
#line 1 "D:\Dogan\Project\Passionflower\Passionflower\Views\_ViewImports.cshtml"
using Passionflower;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dogan\Project\Passionflower\Passionflower\Views\_ViewImports.cshtml"
using Passionflower.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaa66570ee213ab1ce90b308aefc8760ee5a72b0", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a29cde8797095dfeaffa151540fdef77297bf8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Dogan\Project\Passionflower\Passionflower\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LoginLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"logo\">\r\n    <a href=\"index.html\">\r\n        <img src=\"../assets/pages/img/logo-big.png\"");
            BeginWriteAttribute("alt", " alt=\"", 199, "\"", 205, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </a>\r\n</div>\r\n<!-- END LOGO -->\r\n<!-- BEGIN LOGIN -->\r\n<div id=\"app\">\r\n    <div class=\"content\">\r\n        <!-- BEGIN LOGIN FORM -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaa66570ee213ab1ce90b308aefc8760ee5a72b04242", async() => {
                WriteLiteral(@"
            <h3 class=""form-title"">Login to your account</h3>
            <div class=""alert alert-danger display-hide"">
                <button class=""close"" data-close=""alert""></button>
                <span> Enter any username and password. </span>
            </div>
            <div class=""form-group"">
                <!--ie8, ie9 does not support html5 placeholder, so we just show field title for that-->
                <label class=""control-label visible-ie8 visible-ie9"">Username</label>
                <div class=""input-icon"">
                    <i class=""fa fa-user""></i>
                    <input class=""form-control placeholder-no-fix"" type=""text"" autocomplete=""off"" placeholder=""Username"" name=""username"" />
                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label visible-ie8 visible-ie9"">Password</label>
                <div class=""input-icon"">
                    <i class=""fa fa-lock""></i>
                    <input");
                WriteLiteral(@" class=""form-control placeholder-no-fix"" type=""password"" autocomplete=""off"" placeholder=""Password"" name=""password"" />
                </div>
            </div>
            <div class=""form-actions"">
                <label class=""rememberme mt-checkbox mt-checkbox-outline"">
                    <input type=""checkbox"" name=""remember"" value=""1"" /> Remember me
                    <span></span>
                </label>
                <button v-on:click=""greet""> {{name}} </button>

            </div>


        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <!-- END REGISTRATION FORM -->
    </div>

</div>
<script src=""https://unpkg.com/axios/dist/axios.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/vue""></script>
<script>

    //var app = new Vue({
    //    el: '#app',
    //    data: {
    //        message: 'Hello'
    //    },
    //    method: {
    //        login: function (event) {
    //            //axios({
    //            //    method: 'post',
    //            //    url: '/Auth/Token',
    //            //    data: {
    //            //        firstName: 'Fred',
    //            //        lastName: 'Flintstone'
    //            //    }
    //            //});
    //            alert('Hello')
    //            if (event) {
    //                alert(event.target.tagName)
    //            }
    //        }
    //    }
    //})
    var app = new Vue({
        el: '#app',
        data: {
           name: 'Vue.js'
        },
        method: {
            greet: function () {

           ");
            WriteLiteral("     alert(\'Hello \' + this.name + \'!\')\r\n             \r\n            }\r\n        }\r\n    })\r\n\r\n\r\n</script>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
