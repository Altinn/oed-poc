using Altinn.ApiClients.Dan.Interfaces;
using dan_oed_poc_razor.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dan_oed_poc_razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IDanClient _danClient;

        // Dette er modellen som det deserialiseres mot, og som tilgjengeliggjøres i Razor-viewet (se Index.cshtml)
        public BankResponse BankResponse { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IDanClient danClient)
        {
            _logger = logger;
            _danClient = danClient;

            BankResponse = new BankResponse();
        }

        public async Task OnGetAsync()
        {
            // Her foretas et kall etter datasettet "Banktransaksjoner" for et gitt fnr.
            BankResponse = await _danClient.GetDataSet<BankResponse>("Banktransaksjoner", "07056120453");

            // Eksempel som bruker parametre
            // 
            //BankResponse = await _danClient.GetDataSet<BankResponse>("Banktransaksjoner", "07056120453", parameters: new Dictionary<string, string>()
            //{
            //    { "param1key", "param1value" },
            //    { "param2key",  "param2value" },
            //});
        }
    }
}