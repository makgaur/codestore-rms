#pragma checksum "C:\Users\Bitniti-IND-011\source\repos\sample-rms\sample-rms\Views\Home\_DisplayReservations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9921db3ce285a2742bf9d30df2fb3e54c959a26e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__DisplayReservations), @"mvc.1.0.view", @"/Views/Home/_DisplayReservations.cshtml")]
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
#line 1 "C:\Users\Bitniti-IND-011\source\repos\sample-rms\sample-rms\Views\_ViewImports.cshtml"
using sample_rms;

#line default
#line hidden
#line 2 "C:\Users\Bitniti-IND-011\source\repos\sample-rms\sample-rms\Views\_ViewImports.cshtml"
using sample_rms.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9921db3ce285a2742bf9d30df2fb3e54c959a26e", @"/Views/Home/_DisplayReservations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f053830c2887f4301fb3fb54dae47fd13e1f9c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__DisplayReservations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ReservationDataTableViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#line 3 "C:\Users\Bitniti-IND-011\source\repos\sample-rms\sample-rms\Views\Home\_DisplayReservations.cshtml"
 if (Model != null && Model.Count > 0)
{


#line default
#line hidden
            WriteLiteral(@"    <table class=""table table-sm"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Table</th>
                <th scope=""col"">Size</th>
                <th scope=""col"">Time</th>
            </tr>
        </thead>
        <tbody>
");
#line 16 "C:\Users\Bitniti-IND-011\source\repos\sample-rms\sample-rms\Views\Home\_DisplayReservations.cshtml"
             for (int i = 1; i <= Model.Count; i++)
            {

#line default
#line hidden
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#line 19 "C:\Users\Bitniti-IND-011\source\repos\sample-rms\sample-rms\Views\Home\_DisplayReservations.cshtml"
                               Write(i);

#line default
#line hidden
            WriteLiteral("</th>\r\n                    <td>");
#line 20 "C:\Users\Bitniti-IND-011\source\repos\sample-rms\sample-rms\Views\Home\_DisplayReservations.cshtml"
                   Write(Model[i-1].TableName);

#line default
#line hidden
            WriteLiteral("</td>\r\n                    <td>");
#line 21 "C:\Users\Bitniti-IND-011\source\repos\sample-rms\sample-rms\Views\Home\_DisplayReservations.cshtml"
                   Write(Model[i-1].Size);

#line default
#line hidden
            WriteLiteral("</td>\r\n                    <td>");
#line 22 "C:\Users\Bitniti-IND-011\source\repos\sample-rms\sample-rms\Views\Home\_DisplayReservations.cshtml"
                   Write(Model[i-1].Timing);

#line default
#line hidden
            WriteLiteral("</td>\r\n                </tr>\r\n");
#line 24 "C:\Users\Bitniti-IND-011\source\repos\sample-rms\sample-rms\Views\Home\_DisplayReservations.cshtml"
            }

#line default
#line hidden
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#line 27 "C:\Users\Bitniti-IND-011\source\repos\sample-rms\sample-rms\Views\Home\_DisplayReservations.cshtml"
}
else
{

#line default
#line hidden
            WriteLiteral(@"    <table class=""table table-sm"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Table</th>
                <th scope=""col"">Size</th>
                <th scope=""col"">Time</th>
            </tr>
        </thead>
        <tbody>
           <tr>
               <th colspan=""4"" class=""text-center"">No Data! Start By Making Reservations! </th>
           </tr>
        </tbody>
    </table>
");
#line 45 "C:\Users\Bitniti-IND-011\source\repos\sample-rms\sample-rms\Views\Home\_DisplayReservations.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ReservationDataTableViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
