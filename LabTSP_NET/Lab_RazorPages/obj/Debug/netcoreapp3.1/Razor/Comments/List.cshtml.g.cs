#pragma checksum "D:\Info\Anul3\Sem2\TSP_NET\GitProj\TSP_NET_LAB\LabTSP_NET\Lab_RazorPages\Comments\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca6448bf9998940cd04401244c5fea36e4de1d0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Comments_List), @"mvc.1.0.razor-page", @"/Comments/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca6448bf9998940cd04401244c5fea36e4de1d0b", @"/Comments/List.cshtml")]
    public class Comments_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Info\Anul3\Sem2\TSP_NET\GitProj\TSP_NET_LAB\LabTSP_NET\Lab_RazorPages\Comments\List.cshtml"
   ViewData["Title"] = "List"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>List Comments for: ");
#nullable restore
#line 4 "D:\Info\Anul3\Sem2\TSP_NET\GitProj\TSP_NET_LAB\LabTSP_NET\Lab_RazorPages\Comments\List.cshtml"
                  Write(ViewData["Post"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th> ");
#nullable restore
#line 8 "D:\Info\Anul3\Sem2\TSP_NET\GitProj\TSP_NET_LAB\LabTSP_NET\Lab_RazorPages\Comments\List.cshtml"
            Write(Html.DisplayNameFor(model => model.Comments[0].CommentId));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n            <th> ");
#nullable restore
#line 9 "D:\Info\Anul3\Sem2\TSP_NET\GitProj\TSP_NET_LAB\LabTSP_NET\Lab_RazorPages\Comments\List.cshtml"
            Write(Html.DisplayNameFor(model => model.Comments[0].Text));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 13 "D:\Info\Anul3\Sem2\TSP_NET\GitProj\TSP_NET_LAB\LabTSP_NET\Lab_RazorPages\Comments\List.cshtml"
         foreach (var item in Model.Comments)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td> ");
#nullable restore
#line 16 "D:\Info\Anul3\Sem2\TSP_NET\GitProj\TSP_NET_LAB\LabTSP_NET\Lab_RazorPages\Comments\List.cshtml"
                Write(Html.DisplayFor(modelItem => item.CommentId));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 17 "D:\Info\Anul3\Sem2\TSP_NET\GitProj\TSP_NET_LAB\LabTSP_NET\Lab_RazorPages\Comments\List.cshtml"
                Write(Html.DisplayFor(modelItem => item.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> <a asp-page=\"./Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 649, "\"", 679, 1);
#nullable restore
#line 18 "D:\Info\Anul3\Sem2\TSP_NET\GitProj\TSP_NET_LAB\LabTSP_NET\Lab_RazorPages\Comments\List.cshtml"
WriteAttributeValue("", 664, item.CommentId, 664, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> | <a asp-page=\"./Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 714, "\"", 744, 1);
#nullable restore
#line 18 "D:\Info\Anul3\Sem2\TSP_NET\GitProj\TSP_NET_LAB\LabTSP_NET\Lab_RazorPages\Comments\List.cshtml"
WriteAttributeValue("", 729, item.CommentId, 729, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a> | </td>\r\n            </tr>\r\n");
#nullable restore
#line 20 "D:\Info\Anul3\Sem2\TSP_NET\GitProj\TSP_NET_LAB\LabTSP_NET\Lab_RazorPages\Comments\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    <a asp-page=\"/Posts/Index\">Back to List</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asp_Vancsa_Istvan_Rp.Comments.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Asp_Vancsa_Istvan_Rp.Comments.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Asp_Vancsa_Istvan_Rp.Comments.ListModel>)PageContext?.ViewData;
        public Asp_Vancsa_Istvan_Rp.Comments.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
