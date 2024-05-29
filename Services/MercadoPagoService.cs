    // MercadoPagoService.cs
using System.Threading.Tasks;
using MercadoPago.Client.Preference;
using MercadoPago.Config;
using MercadoPago.Resource.Preference;
using System.Collections.Generic;

public class MercadoPagoService
{
    public MercadoPagoService()
    {
        MercadoPagoConfig.AccessToken = "TEST-4088124765466751-091611-1713541c064c4444455910f1201da0c5-388501957";
    }

    public async Task<PreferenceData> CreatePreferenceAsync(string description, decimal price, int quantity)
    {
        var request = new PreferenceRequest
        {
            Items = new List<PreferenceItemRequest>
            {
                new PreferenceItemRequest
                {
                    Title = description,
                    Quantity = quantity,
                    CurrencyId = "COP",
                    UnitPrice = price,
                },
            },
            BackUrls = new PreferenceBackUrlsRequest
            {
                Success = "https://localhost:44349/thank-you-page/",
                Failure = "https://localhost:44349/error-page/",
                Pending = "https://localhost:44349/error-page/",
            },
            AutoReturn = "approved",
        };

        var client = new PreferenceClient();
        Preference preference = await client.CreateAsync(request);
        return new PreferenceData { PreferenceId = preference.Id, InitPoint = preference.InitPoint };
    }

    public class PreferenceData
    {
        public string PreferenceId { get; set; }
        public string InitPoint { get; set; }
    }
}
