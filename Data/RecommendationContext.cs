using Microsoft.EntityFrameworkCore;
using RecommendationService.Models;

namespace RecommendationService.Data
{
    public class RecommendationContext : DbContext
    {
        public RecommendationContext(DbContextOptions<RecommendationContext> options) : base(options) { }

        public DbSet<Recommendation> Recommendations { get; set; }
    }
}
