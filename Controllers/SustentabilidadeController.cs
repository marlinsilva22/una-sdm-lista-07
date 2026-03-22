using Microsoft.AspNetCore.Mvc;

namespace EcoTrackApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SustentabilidadeController : ControllerBase
    {
        private static readonly string[] dicas = new[]
        {
            "Use transporte público sempre que possível.",
            "Evite desperdício de água.",
            "Prefira produtos recicláveis.",
            "Reduza o uso de plástico.",
            "Economize energia desligando aparelhos."
        };

        [HttpGet]
        public string Get()
        {
            Random random = new Random();
            int index = random.Next(dicas.Length);
            return dicas[index];
        }
    }
}