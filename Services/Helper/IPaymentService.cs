using PCMarketIA.Models;

namespace PCMarketIA.Services.Helper
{
    public interface IPaymentService
    {
        Task<string> CreatePaymentPreferenceAsync(PaymentPreferenceModel model);
    }
}
