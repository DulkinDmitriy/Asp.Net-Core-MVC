#pragma checksum "C:\Users\dulck\source\repos\Asp.Net Core MVC\CoreBB.Web\CoreBB.Web\Views\Topic\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80602cc8697f817b4a5fe1e60d41d81998ed100a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topic_Detail), @"mvc.1.0.view", @"/Views/Topic/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Topic/Detail.cshtml", typeof(AspNetCore.Views_Topic_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80602cc8697f817b4a5fe1e60d41d81998ed100a", @"/Views/Topic/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Topic_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreBB.Web.Models.Topic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\dulck\source\repos\Asp.Net Core MVC\CoreBB.Web\CoreBB.Web\Views\Topic\Detail.cshtml"
  
    ViewBag.Title = Model.Title;

#line default
#line hidden
            BeginContext(73, 21, true);
            WriteLiteral("\r\n<h3>Original</h3>\r\n");
            EndContext();
            BeginContext(95, 47, false);
#line 7 "C:\Users\dulck\source\repos\Asp.Net Core MVC\CoreBB.Web\CoreBB.Web\Views\Topic\Detail.cshtml"
Write(await Html.PartialAsync("_TopicReading", Model));

#line default
#line hidden
            EndContext();
            BeginContext(142, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 9 "C:\Users\dulck\source\repos\Asp.Net Core MVC\CoreBB.Web\CoreBB.Web\Views\Topic\Detail.cshtml"
 if (Model.InverseReplyToTopic.Count != 0)
{

#line default
#line hidden
            BeginContext(193, 34, true);
            WriteLiteral("    <hr />\r\n    <h3>Replies</h3>\r\n");
            EndContext();
#line 13 "C:\Users\dulck\source\repos\Asp.Net Core MVC\CoreBB.Web\CoreBB.Web\Views\Topic\Detail.cshtml"
     foreach (var t in Model.InverseReplyToTopic)
    {
        

#line default
#line hidden
            BeginContext(294, 43, false);
#line 15 "C:\Users\dulck\source\repos\Asp.Net Core MVC\CoreBB.Web\CoreBB.Web\Views\Topic\Detail.cshtml"
   Write(await Html.PartialAsync("_TopicReading", t));

#line default
#line hidden
            EndContext();
#line 15 "C:\Users\dulck\source\repos\Asp.Net Core MVC\CoreBB.Web\CoreBB.Web\Views\Topic\Detail.cshtml"
                                                    ;
    }

#line default
#line hidden
#line 16 "C:\Users\dulck\source\repos\Asp.Net Core MVC\CoreBB.Web\CoreBB.Web\Views\Topic\Detail.cshtml"
     
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreBB.Web.Models.Topic> Html { get; private set; }
    }
}
#pragma warning restore 1591
