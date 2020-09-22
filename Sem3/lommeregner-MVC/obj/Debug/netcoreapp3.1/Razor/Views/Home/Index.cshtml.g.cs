#pragma checksum "/Users/thomasclausen/Documents/GitHub/School/Sem3/lommeregner-MVC/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7186533c642b357709496f8d24f98670e028cd8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/thomasclausen/Documents/GitHub/School/Sem3/lommeregner-MVC/Views/_ViewImports.cshtml"
using lommeregner_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/thomasclausen/Documents/GitHub/School/Sem3/lommeregner-MVC/Views/_ViewImports.cshtml"
using lommeregner_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7186533c642b357709496f8d24f98670e028cd8e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38a7cafd46e39d4b1313afbd0335d74e5d13d8f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-md-12"">
    <div class=""col-md-4 offset-4"">
        <div id=""Calculator"" class=""col-md-12"">
            <h2> Lommeregner </h2>
            <input type=""text"" id=""calculatorInput"" class=""form-control"">
            <div class=""row"">
                <button onclick=""javascript:addNumber(1)"" class=""btn btn-def btn-dark""> 1 </button>
                <button onclick=""javascript:addNumber(2)"" class=""btn btn-def btn-dark""> 2 </button>
                <button onclick=""javascript:addNumber(3)"" class=""btn btn-def btn-dark""> 3 </button>
            </div>
            <div class=""row"">
                <button onclick=""javascript:addNumber(4)"" class=""btn btn-def btn-dark""> 4 </button>
                <button onclick=""javascript:addNumber(5)"" class=""btn btn-def btn-dark""> 5 </button>
                <button onclick=""javascript:addNumber(6)"" class=""btn btn-def btn-dark""> 6 </button>
            </div>
            <div class=""row"">
                <button onclick=""javascript:addNumber(7)"" class");
            WriteLiteral(@"=""btn btn-def btn-dark""> 7 </button>
                <button onclick=""javascript:addNumber(8)"" class=""btn btn-def btn-dark""> 8 </button>
                <button onclick=""javascript:addNumber(9)"" class=""btn btn-def btn-dark""> 9 </button>
            </div>
            <div class=""row"">
                <button onclick=""javascript:addNumber('*')"" class=""btn btn-buttom btn-dark""> * </button>
                <button onclick=""javascript:addNumber('+')"" class=""btn btn-buttom btn-dark""> + </button>
                <button onclick=""javascript:addNumber('-')"" class=""btn btn-buttom btn-dark""> - </button>
                <button onclick=""javascript:addNumber('/')""  class=""btn btn-buttom btn-dark""> / </button>
            </div>
            <button onclick=""javascript:sendRequest()"" class=""btn btn-primary btn-block""> Beregn </button>
        </div>
    </div>
</div>

<script>
    function addNumber(x) {
        var input = document.getElementById('calculatorInput');
        input.value = input.value + x;");
            WriteLiteral(@"
    }

    function sendRequest() {
        var input = document.getElementById('calculatorInput');
        var statement = input.value;
        $.ajax({
            url: 'https://localhost:3002/Home/calculate',
            data: JSON.stringify({ statement: statement }),
            type: 'POST',
            contentType: false,
            processData: false,
            headers: { 
                'Content-Type': 'application/json',
                'Accept': 'application/json'
            },
            success: function(result) {
                input.value = result.statement
            },
            error: function(error) {
                alert(""An error has occured"");
            }
        });
    }
</script>

<style>
    .btn-def {
        width: 30%;
        margin: 5px;
    }

    .btn-buttom {
        width: 21.5%;
        margin: 5px;
    }

    #Calculator {
        border: solid 1px #f9f9f9;
        background-color: #f8f8f8;
        box-shadow: 10px 10px");
            WriteLiteral(" 5px #aaaaaa;\r\n    }\r\n</style>");
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
