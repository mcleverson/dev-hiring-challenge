#pragma checksum "/Users/cleversongallego/Projects/DevHiring/dev-hiring-challenge/AteliwareGitHub.Client/Pages/FetchLangs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c310f1bd85119dbf6cca8e47489745e28f17b290"
// <auto-generated/>
#pragma warning disable 1591
namespace AteliwareGitHub.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using AteliwareGitHub.Client;
    using AteliwareGitHub.Client.Shared;
    using AteliwareGitHub.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/fetchLangs")]
    public class FetchLangs : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Languages</h1>\n\n");
            builder.OpenComponent<AteliwareGitHub.Client.Shared.DevelopmentStuff>(1);
            builder.AddAttribute(2, "Title", "We will be here filtering following languages...");
            builder.AddAttribute(3, "ShowSpecs", Microsoft.AspNetCore.Blazor.Components.RuntimeHelpers.TypeCheck<System.Boolean>(false));
            builder.CloseComponent();
            builder.AddContent(4, "\n\n");
#line 11 "/Users/cleversongallego/Projects/DevHiring/dev-hiring-challenge/AteliwareGitHub.Client/Pages/FetchLangs.cshtml"
 if (languages == null)
{

#line default
#line hidden
            builder.AddContent(5, "    ");
            builder.AddMarkupContent(6, "<p><em>Loading...</em></p>\n");
#line 14 "/Users/cleversongallego/Projects/DevHiring/dev-hiring-challenge/AteliwareGitHub.Client/Pages/FetchLangs.cshtml"
}
else
{


#line default
#line hidden
            builder.AddContent(7, "    ");
            builder.OpenElement(8, "select");
            builder.AddAttribute(9, "id", "languages");
            builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIChangeEventArgs>(LangSelectionChanged));
            builder.AddContent(11, "\n        ");
            builder.AddMarkupContent(12, "<option value=\"0\">Pick a Language</option>\n");
#line 20 "/Users/cleversongallego/Projects/DevHiring/dev-hiring-challenge/AteliwareGitHub.Client/Pages/FetchLangs.cshtml"
         foreach (var lang in languages)
        {

#line default
#line hidden
            builder.AddContent(13, "            ");
            builder.OpenElement(14, "option");
            builder.AddAttribute(15, "value", lang.name);
            builder.AddContent(16, lang.name);
            builder.CloseElement();
            builder.AddContent(17, "\n");
#line 23 "/Users/cleversongallego/Projects/DevHiring/dev-hiring-challenge/AteliwareGitHub.Client/Pages/FetchLangs.cshtml"
        }

#line default
#line hidden
            builder.AddContent(18, "    ");
            builder.CloseElement();
            builder.AddContent(19, "\n");
            builder.AddContent(20, "    ");
            builder.OpenElement(21, "table");
            builder.AddAttribute(22, "class", "table");
            builder.AddContent(23, "\n        ");
            builder.AddMarkupContent(24, "<thead>\n            <tr>\n                <th>Name</th>\n            </tr>\n        </thead>\n        ");
            builder.OpenElement(25, "tbody");
            builder.AddContent(26, "\n");
#line 34 "/Users/cleversongallego/Projects/DevHiring/dev-hiring-challenge/AteliwareGitHub.Client/Pages/FetchLangs.cshtml"
             foreach (var lang in langsSelected)
            {

#line default
#line hidden
            builder.AddContent(27, "                ");
            builder.OpenElement(28, "tr");
            builder.AddContent(29, "\n                    ");
            builder.OpenElement(30, "td");
            builder.AddContent(31, lang.name);
            builder.CloseElement();
            builder.AddContent(32, "\n                ");
            builder.CloseElement();
            builder.AddContent(33, "\n");
#line 39 "/Users/cleversongallego/Projects/DevHiring/dev-hiring-challenge/AteliwareGitHub.Client/Pages/FetchLangs.cshtml"
            }

#line default
#line hidden
            builder.AddContent(34, "        ");
            builder.CloseElement();
            builder.AddContent(35, "\n    ");
            builder.CloseElement();
            builder.AddContent(36, "\n");
#line 42 "/Users/cleversongallego/Projects/DevHiring/dev-hiring-challenge/AteliwareGitHub.Client/Pages/FetchLangs.cshtml"
}

#line default
#line hidden
            builder.AddContent(37, "\n");
            builder.OpenElement(38, "button");
            builder.AddAttribute(39, "class", "btn btn-primary");
            builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(GoForResults));
            builder.AddContent(41, "Results");
            builder.CloseElement();
            builder.AddContent(42, "\n\n");
            builder.OpenElement(43, "button");
            builder.AddAttribute(44, "class", "btn btn-primary");
            builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(ClearResults));
            builder.AddContent(46, "Clear");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 48 "/Users/cleversongallego/Projects/DevHiring/dev-hiring-challenge/AteliwareGitHub.Client/Pages/FetchLangs.cshtml"
            
    LanguagesDTO[] languages;
    List<LanguagesDTO> langsSelected = new List<LanguagesDTO>();
    int qtdLangs = 0;
    List<string> langsuri = new List<string>();

    protected override async Task OnInitAsync()
    {
        languages = await Http.GetJsonAsync<LanguagesDTO[]>("api/GitHub/Languages");
        langsuri.Clear();
        langsSelected.Clear();
    }

    void LangSelectionChanged(UIChangeEventArgs e)
    {
        if (qtdLangs < 5)
        {
            var alreadypicked = from b in langsSelected
                                where b.name == e.Value.ToString()
                                select b;

            if (alreadypicked.Count() <= 0)
            {
                langsSelected.Add(new LanguagesDTO() { name = e.Value.ToString(), qtd = 0 });

                langsuri.Add("lang=" + e.Value.ToString());

                qtdLangs++;
            }
        }
    }

    void ClearResults()
    {
        langsSelected.Clear();
        qtdLangs = 0;
        langsuri.Clear();
    }

    async void GoForResults()
    {
        if (langsuri.Count() > 0)
        {
            string url = $"/fetchData/{string.Join("&", langsuri)}";

            uriHelper.NavigateTo(url);
        }
        else
        {
            await JsRuntime.InvokeAsync<bool>("utilJSFunctions.showMessage", "Select one language at least to proceed.");
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
