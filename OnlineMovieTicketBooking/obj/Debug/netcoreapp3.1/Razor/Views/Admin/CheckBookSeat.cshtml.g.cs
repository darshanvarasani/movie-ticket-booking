#pragma checksum "C:\Users\AKASH\Downloads\OnlineMovieTicketBooking\OnlineMovieTicketBooking\Views\Admin\CheckBookSeat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b163cee69cf7b5291681a04d5fad205a7a9fc23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CheckBookSeat), @"mvc.1.0.view", @"/Views/Admin/CheckBookSeat.cshtml")]
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
#line 1 "C:\Users\AKASH\Downloads\OnlineMovieTicketBooking\OnlineMovieTicketBooking\Views\_ViewImports.cshtml"
using OnlineMovieTicketBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AKASH\Downloads\OnlineMovieTicketBooking\OnlineMovieTicketBooking\Views\_ViewImports.cshtml"
using OnlineMovieTicketBooking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b163cee69cf7b5291681a04d5fad205a7a9fc23", @"/Views/Admin/CheckBookSeat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"517bdac8bfaf3dce8a29e84d0b6a13d5e3bd5e07", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CheckBookSeat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineMovieTicketBooking.Models.BookingTable>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\AKASH\Downloads\OnlineMovieTicketBooking\OnlineMovieTicketBooking\Views\Admin\CheckBookSeat.cshtml"
  
    ViewData["Title"] = "CheckBookSeat";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CheckBookSeat</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\AKASH\Downloads\OnlineMovieTicketBooking\OnlineMovieTicketBooking\Views\Admin\CheckBookSeat.cshtml"
           Write(Html.DisplayNameFor(model => model.SeatNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\AKASH\Downloads\OnlineMovieTicketBooking\OnlineMovieTicketBooking\Views\Admin\CheckBookSeat.cshtml"
           Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\AKASH\Downloads\OnlineMovieTicketBooking\OnlineMovieTicketBooking\Views\Admin\CheckBookSeat.cshtml"
           Write(Html.DisplayNameFor(model => model.Datetopresent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\AKASH\Downloads\OnlineMovieTicketBooking\OnlineMovieTicketBooking\Views\Admin\CheckBookSeat.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\AKASH\Downloads\OnlineMovieTicketBooking\OnlineMovieTicketBooking\Views\Admin\CheckBookSeat.cshtml"
           Write(Html.DisplayNameFor(model => model.MovieDetailsId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\AKASH\Downloads\OnlineMovieTicketBooking\OnlineMovieTicketBooking\Views\Admin\CheckBookSeat.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\AKASH\Downloads\OnlineMovieTicketBooking\OnlineMovieTicketBooking\Views\Admin\CheckBookSeat.cshtml"
           Write(Html.DisplayFor(modelItem => item.SeatNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\AKASH\Downloads\OnlineMovieTicketBooking\OnlineMovieTicketBooking\Views\Admin\CheckBookSeat.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\AKASH\Downloads\OnlineMovieTicketBooking\OnlineMovieTicketBooking\Views\Admin\CheckBookSeat.cshtml"
           Write(Html.DisplayFor(modelItem => item.Datetopresent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\AKASH\Downloads\OnlineMovieTicketBooking\OnlineMovieTicketBooking\Views\Admin\CheckBookSeat.cshtml"
           Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\AKASH\Downloads\OnlineMovieTicketBooking\OnlineMovieTicketBooking\Views\Admin\CheckBookSeat.cshtml"
           Write(Html.DisplayFor(modelItem => item.MovieDetailsId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\AKASH\Downloads\OnlineMovieTicketBooking\OnlineMovieTicketBooking\Views\Admin\CheckBookSeat.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineMovieTicketBooking.Models.BookingTable>> Html { get; private set; }
    }
}
#pragma warning restore 1591
