using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QrCodeExample;
using System.Text.Json;

namespace QrCodeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QrCodeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GenerateQrCoce([FromQuery] Product product)
        {
            string serializedProduct = JsonSerializer.Serialize(product);
            QrCoder qrCode = new();
            byte[] generatedQrCode = qrCode.GenerateQrCode(serializedProduct);
            return File(generatedQrCode, "image/png");
        }
    }
}
