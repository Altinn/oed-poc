using Altinn.ApiClients.Dan.Extensions;
using Altinn.ApiClients.Dan.Models;
using Altinn.ApiClients.Maskinporten.Config;
using Altinn.ApiClients.Maskinporten.Services;

var builder = WebApplication.CreateBuilder(args);



/************************************************************************************************/

// Her hentes innstillinger for data.altinn.no, som er valgt miljø ("dev", "staging", "prod") samt subscription key for det aktuelle DAN-miljøet
builder.Services.Configure<DanSettings>(builder.Configuration.GetSection("DanSettings"));

// Her hentes innstillinger for Maskinporten. En "client definition" inneholder miljø, klientid, ønskede scopes, og info om hvordan secret 
// (virksomhetssertifikat eller egendefinert nøkkel) hentes. SettingsJwkClientDefinition henter en base64-enkodet JWK fra settings. I Azure er dette
// typisk en key vault-referanse (https://docs.microsoft.com/en-us/azure/app-service/app-service-key-vault-references) til hvor hemmeligheten ligger
builder.Services.Configure<MaskinportenSettings<SettingsJwkClientDefinition>>(builder.Configuration.GetSection("MaskinportenSettings"));

// Dette tilgjengeliggjør en IDanClient for dependency injection for konfigurasjonen som er oppgitt
// Se Pages/Index.cshtml.cs for eksempel på hvordan denne er brukt
builder.Services.AddDanClient<SettingsJwkClientDefinition>();


// (Alt før og etter denne bolken er boilerplate for poc-webappen.) 

/************************************************************************************************/

builder.Services.AddRazorPages();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();
