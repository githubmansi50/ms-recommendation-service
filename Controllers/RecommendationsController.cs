using Microsoft.AspNetCore.Mvc;
using RecommendationService.Data;
using RecommendationService.Models;

namespace RecommendationService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecommendationsController : ControllerBase
    {
        private readonly RecommendationContext _context;

        public RecommendationsController(RecommendationContext context) => _context = context;

        [HttpGet]
        public IActionResult GetAll() => Ok(_context.Recommendations.ToList());

        [HttpPost]
        public IActionResult Add(Recommendation rec)
        {
            _context.Recommendations.Add(rec);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAll), new { id = rec.RecommendationID }, rec);
        }
    }
}
