#pragma checksum "C:\Users\auysa\source\repos\ReadGPSData\ReadGPSData\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "341a5127453036b47bf1cdb2d271376d2266e1da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\auysa\source\repos\ReadGPSData\ReadGPSData\Views\_ViewImports.cshtml"
using ReadGPSData;

#line default
#line hidden
#line 2 "C:\Users\auysa\source\repos\ReadGPSData\ReadGPSData\Views\_ViewImports.cshtml"
using ReadGPSData.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"341a5127453036b47bf1cdb2d271376d2266e1da", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08273e556e973ea0deeac26da29dc21836f93e07", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\auysa\source\repos\ReadGPSData\ReadGPSData\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 207, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n    <p>\r\n        <title>");
            EndContext();
            BeginContext(253, 13, false);
#line 9 "C:\Users\auysa\source\repos\ReadGPSData\ReadGPSData\Views\Home\Index.cshtml"
          Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(266, 959, true);
            WriteLiteral(@"</title>

        <h2 style=""background-color: rgb(73,171,210);color: white; text-align: center; height:50px;padding-top:10px"">ASP.NET Core – Google Maps API</h2>
        <fieldset>
            <legend style=""font-family: 'Segoe UI'; color: rgb(73,171,210); font-size: large;"">Fotoğraf Adresim;</legend>
            <meta charset=""utf-8"">
            <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

            <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">

            <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
            <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>

            <div id=""googleMap"" style=""height:500px;width:100%;""></div>

            <script>
            
                function myMap() {
                    var myCenter = new google.maps.LatLng(");
            EndContext();
            BeginContext(1226, 11, false);
#line 27 "C:\Users\auysa\source\repos\ReadGPSData\ReadGPSData\Views\Home\Index.cshtml"
                                                     Write(ViewBag.Lat);

#line default
#line hidden
            EndContext();
            BeginContext(1237, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1240, 11, false);
#line 27 "C:\Users\auysa\source\repos\ReadGPSData\ReadGPSData\Views\Home\Index.cshtml"
                                                                   Write(ViewBag.Lon);

#line default
#line hidden
            EndContext();
            BeginContext(1251, 722, true);
            WriteLiteral(@");
                    var mapProp = { center: myCenter, zoom: 12, scrollwheel: false, draggable: true, mapTypeId: google.maps.MapTypeId.ROADMAP };
                    var map = new google.maps.Map(document.getElementById(""googleMap""), mapProp);
                    var marker = new google.maps.Marker({ position: myCenter });
                    marker.setMap(map);
                }
            </script>
            <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyBNcZT99OU-jkEIChyYfDCUhlhsA_pE1oE&callback=myMap""></script>
        </fieldset>
        <footer>
    <p style=""background-color: rgb(73,171,210); font-weight: bold; color:white; text-align: center;height:50px; padding-top:15px"">© ");
            EndContext();
            BeginContext(1974, 26, false);
#line 37 "C:\Users\auysa\source\repos\ReadGPSData\ReadGPSData\Views\Home\Index.cshtml"
                                                                                                                                Write(DateTime.Now.ToLocalTime());

#line default
#line hidden
            EndContext();
            BeginContext(2000, 33, true);
            WriteLiteral("</p>\r\n    </footer></p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591