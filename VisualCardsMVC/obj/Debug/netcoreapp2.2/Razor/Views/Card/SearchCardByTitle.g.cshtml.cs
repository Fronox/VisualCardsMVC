#pragma checksum "/home/fronox/Education/5 course/Enterprise/VisualCardsMVC/VisualCardsMVC/Views/Card/SearchCardByTitle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d7a45da8c8408e8ec5f4eaadbd1b613f8bf3c58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Card_SearchCardByTitle), @"mvc.1.0.view", @"/Views/Card/SearchCardByTitle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Card/SearchCardByTitle.cshtml", typeof(AspNetCore.Views_Card_SearchCardByTitle))]
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
#line 1 "/home/fronox/Education/5 course/Enterprise/VisualCardsMVC/VisualCardsMVC/Views/_ViewImports.cshtml"
using VisualCardsMVC;

#line default
#line hidden
#line 2 "/home/fronox/Education/5 course/Enterprise/VisualCardsMVC/VisualCardsMVC/Views/_ViewImports.cshtml"
using VisualCardsMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a45da8c8408e8ec5f4eaadbd1b613f8bf3c58", @"/Views/Card/SearchCardByTitle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"006bddeb6adb183462727161a82d89a2dde3e2a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Card_SearchCardByTitle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<VisualCardsMVC.Models.CardModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 649, true);
            WriteLiteral(@"
<style>
    .board:after {
        content: """";
        display: table;
        clear: both;
    }
    button {
        font-family: Helvetica;
        font-size: 12px;
    }

    .btn-group button {
        background-color: #118880;
        border: 1px solid skyblue; 
        color: white;
        padding: 5px 10px;
        cursor: pointer;
        float: left;
    }

    .btn-group:after {
        content: """";
        clear: both;
        display: table;
    }

    .btn-group button:not(:last-child) {
        border-right: none;
    }

    .btn-group button:hover {
        background-color: #11AAAA;
    }
</style>

<div class = ""board"">
");
            EndContext();
#line 39 "/home/fronox/Education/5 course/Enterprise/VisualCardsMVC/VisualCardsMVC/Views/Card/SearchCardByTitle.cshtml"
     foreach (var card in Model)
    {

#line default
#line hidden
            BeginContext(760, 47, true);
            WriteLiteral("        <h6>\n            Название:\n            ");
            EndContext();
            BeginContext(808, 39, false);
#line 43 "/home/fronox/Education/5 course/Enterprise/VisualCardsMVC/VisualCardsMVC/Views/Card/SearchCardByTitle.cshtml"
       Write(Html.DisplayFor(cardItem => card.Title));

#line default
#line hidden
            EndContext();
            BeginContext(847, 40, true);
            WriteLiteral(" <br>\n            Описание:\n            ");
            EndContext();
            BeginContext(888, 45, false);
#line 45 "/home/fronox/Education/5 course/Enterprise/VisualCardsMVC/VisualCardsMVC/Views/Card/SearchCardByTitle.cshtml"
       Write(Html.DisplayFor(cardItem => card.Description));

#line default
#line hidden
            EndContext();
            BeginContext(933, 20, true);
            WriteLiteral(" <br>\n        </h6>\n");
            EndContext();
            BeginContext(974, 32, true);
            WriteLiteral("        <div class=\"btn-group\">\n");
            EndContext();
#line 49 "/home/fronox/Education/5 course/Enterprise/VisualCardsMVC/VisualCardsMVC/Views/Card/SearchCardByTitle.cshtml"
             using (Html.BeginForm("EditCard", "Card", FormMethod.Get))
            {
                

#line default
#line hidden
            BeginContext(1109, 34, false);
#line 51 "/home/fronox/Education/5 course/Enterprise/VisualCardsMVC/VisualCardsMVC/Views/Card/SearchCardByTitle.cshtml"
           Write(Html.Hidden("cardId", card.CardId));

#line default
#line hidden
            EndContext();
            BeginContext(1144, 52, true);
            WriteLiteral("                <button type=\"submit\">Edit</button>\n");
            EndContext();
#line 53 "/home/fronox/Education/5 course/Enterprise/VisualCardsMVC/VisualCardsMVC/Views/Card/SearchCardByTitle.cshtml"
            }

#line default
#line hidden
            BeginContext(1210, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 55 "/home/fronox/Education/5 course/Enterprise/VisualCardsMVC/VisualCardsMVC/Views/Card/SearchCardByTitle.cshtml"
             using (Html.BeginForm("HttpDeleteCard", "Card"))
            {
                

#line default
#line hidden
            BeginContext(1304, 34, false);
#line 57 "/home/fronox/Education/5 course/Enterprise/VisualCardsMVC/VisualCardsMVC/Views/Card/SearchCardByTitle.cshtml"
           Write(Html.Hidden("CardId", card.CardId));

#line default
#line hidden
            EndContext();
            BeginContext(1339, 54, true);
            WriteLiteral("                <button type=\"submit\">Delete</button>\n");
            EndContext();
#line 59 "/home/fronox/Education/5 course/Enterprise/VisualCardsMVC/VisualCardsMVC/Views/Card/SearchCardByTitle.cshtml"
            }

#line default
#line hidden
            BeginContext(1407, 15, true);
            WriteLiteral("        </div>\n");
            EndContext();
#line 61 "/home/fronox/Education/5 course/Enterprise/VisualCardsMVC/VisualCardsMVC/Views/Card/SearchCardByTitle.cshtml"
    }   

#line default
#line hidden
            BeginContext(1431, 8, true);
            WriteLiteral("</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<VisualCardsMVC.Models.CardModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591