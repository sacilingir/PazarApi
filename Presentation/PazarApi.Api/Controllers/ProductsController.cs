using Microsoft.AspNetCore.Mvc;

namespace PazarApi.Api.Controllers
{
    // Bu sınıfın bir API Controller olduğunu ve URL adresinin nasıl olacağını sisteme söylüyoruz.
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET isteği geldiğinde çalışacak metodumuz.
        [HttpGet]
        public IActionResult GetProducts()
        {
            // Şimdilik veritabanı yerine elimizle statik bir liste oluşturuyoruz.
            var urunListesi = new[]
            {
                new { Id = 1, UrunAdi = "Elma", Fiyat = 25.50 },
                new { Id = 2, UrunAdi = "Armut", Fiyat = 30.00 },
                new { Id = 3, UrunAdi = "Muz", Fiyat = 45.99 }
            };

            // 200 OK statü koduyla beraber listeyi JSON olarak müşteriye (Postman) gönder.
            return Ok(urunListesi);
        }
    }
}