#pragma checksum "D:\Desktop\final3\Pages\Contacts\Details2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d940c78c36d04ce555da56825d0a21dc218b45c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContactManager.Pages.Contacts.Pages_Contacts_Details2), @"mvc.1.0.razor-page", @"/Pages/Contacts/Details2.cshtml")]
namespace ContactManager.Pages.Contacts
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
#line 1 "D:\Desktop\final3\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Desktop\final3\Pages\_ViewImports.cshtml"
using ContactManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Desktop\final3\Pages\_ViewImports.cshtml"
using ContactManager.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Desktop\final3\Pages\_ViewImports.cshtml"
using ContactManager.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Desktop\final3\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Desktop\final3\Pages\_ViewImports.cshtml"
using ContactManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d940c78c36d04ce555da56825d0a21dc218b45c", @"/Pages/Contacts/Details2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f2d28eb2d16e0aeab529dd95dd3b202b7ba0732", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contacts_Details2 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 4 "D:\Desktop\final3\Pages\Contacts\Details2.cshtml"
  
    ViewData["Title"] = "Details2";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Details2</h2>\n\n<div>\n    <h4>Contact</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
#nullable restore
#line 15 "D:\Desktop\final3\Pages\Contacts\Details2.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 18 "D:\Desktop\final3\Pages\Contacts\Details2.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 21 "D:\Desktop\final3\Pages\Contacts\Details2.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 24 "D:\Desktop\final3\Pages\Contacts\Details2.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 27 "D:\Desktop\final3\Pages\Contacts\Details2.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 30 "D:\Desktop\final3\Pages\Contacts\Details2.cshtml"
       Write(Html.DisplayFor(model => model.Contact.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 33 "D:\Desktop\final3\Pages\Contacts\Details2.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 36 "D:\Desktop\final3\Pages\Contacts\Details2.cshtml"
       Write(Html.DisplayFor(model => model.Contact.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 39 "D:\Desktop\final3\Pages\Contacts\Details2.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 42 "D:\Desktop\final3\Pages\Contacts\Details2.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 45 "D:\Desktop\final3\Pages\Contacts\Details2.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 48 "D:\Desktop\final3\Pages\Contacts\Details2.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 51 "D:\Desktop\final3\Pages\Contacts\Details2.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 54 "D:\Desktop\final3\Pages\Contacts\Details2.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d940c78c36d04ce555da56825d0a21dc218b45c8164", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactManager.Pages.Contacts.Details2Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactManager.Pages.Contacts.Details2Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactManager.Pages.Contacts.Details2Model>)PageContext?.ViewData;
        public ContactManager.Pages.Contacts.Details2Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
