// MercadoPagoController.cs
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MercadoPagoController : ControllerBase
{
    private readonly MercadoPagoService _mercadoPagoService;

    public MercadoPagoController(MercadoPagoService mercadoPagoService)
    {
        _mercadoPagoService = mercadoPagoService;
    }

    [HttpPost("create-preference")]
    public async Task<IActionResult> CreatePreference([FromBody] CreatePreferenceRequest request)
    {
        var preferenceId = await _mercadoPagoService.CreatePreferenceAsync(request.Description, request.Price, request.Quantity);
        return Ok(new { PreferenceId = preferenceId });
    }
}

public class CreatePreferenceRequest
{
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

