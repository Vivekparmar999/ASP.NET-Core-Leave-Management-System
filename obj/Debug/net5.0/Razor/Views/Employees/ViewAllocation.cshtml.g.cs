#pragma checksum "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\Employees\ViewAllocation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aea563078ba96414e9e52625a1e5d0142a5d161b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_ViewAllocation), @"mvc.1.0.view", @"/Views/Employees/ViewAllocation.cshtml")]
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
#line 1 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\_ViewImports.cshtml"
using LeaveManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\_ViewImports.cshtml"
using LeaveManagement.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\_ViewImports.cshtml"
using LeaveManagement.Web.Constants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aea563078ba96414e9e52625a1e5d0142a5d161b", @"/Views/Employees/ViewAllocation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14106cfe753bd565de78e7384333a4c8b08b115c", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_ViewAllocation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LeaveManagement.Web.Models.EmployeeAllocationVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditAllocation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:#FFFFFF;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\Employees\ViewAllocation.cshtml"
  
    ViewData["Title"] = "ViewAllocation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewAllocation</h1>\r\n\r\n<div>\r\n    <h4>View Allocation for ");
#nullable restore
#line 10 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\Employees\ViewAllocation.cshtml"
                       Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\Employees\ViewAllocation.cshtml"
                                        Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\Employees\ViewAllocation.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\Employees\ViewAllocation.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\Employees\ViewAllocation.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\Employees\ViewAllocation.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\Employees\ViewAllocation.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\Employees\ViewAllocation.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\Employees\ViewAllocation.cshtml"
       Write(Html.DisplayNameFor(model => model.DateJoined));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\Employees\ViewAllocation.cshtml"
       Write(Html.DisplayFor(model => model.DateJoined));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
</div>
<hr/>

<div class=""card"" style=""width: 100%;"">
    <div class=""card-header"">
        <h4>Leave Allocations</h4>
    </div>
    <ul class=""list-group list-group-flush"">
        <li class=""list-group-item"">
            <div class=""row"">
                <div class=""col"">Leave Name</div>
                <div class=""col"">Original Allocation</div>
                <div class=""col"">Current Allocation</div>
                <div class=""col"">Action</div>
            </div>
        </li>
");
#nullable restore
#line 54 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\Employees\ViewAllocation.cshtml"
         foreach (var allocation in Model.leaveAllocations) 
        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item\">\r\n            <div class=\"row\">\r\n                <div class=\"col\">");
#nullable restore
#line 58 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\Employees\ViewAllocation.cshtml"
                            Write(allocation.LeaveType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"col\">\r\n                    <button type=\"button\" class=\"btn btn-primary\">\r\n                        Allocated Days <span class=\"badge bg-secondary\">");
#nullable restore
#line 61 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\Employees\ViewAllocation.cshtml"
                                                                   Write(allocation.LeaveType.DefaultDays);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </button>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <button type=\"button\" class=\"btn btn-primary\">\r\n                        Remaining Days <span class=\"badge bg-secondary\">");
#nullable restore
#line 66 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\Employees\ViewAllocation.cshtml"
                                                                   Write(allocation.NumberOfDays);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </button>\r\n                </div>\r\n                <div class=\"col\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aea563078ba96414e9e52625a1e5d0142a5d161b10923", async() => {
                WriteLiteral("<i class=\"fa-solid fa-pen-to-square\"></i>&nbsp;Edit Allocation");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\Employees\ViewAllocation.cshtml"
                                                                             WriteLiteral(allocation.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("        </li>    \r\n");
#nullable restore
#line 85 "C:\Users\146734\source\repos\LeaveManagementNet6\LeaveManagement.Web\Views\Employees\ViewAllocation.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aea563078ba96414e9e52625a1e5d0142a5d161b13738", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeaveManagement.Web.Models.EmployeeAllocationVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
