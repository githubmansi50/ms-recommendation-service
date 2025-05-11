using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecommendationService.Models
{
    [Table("Recommendations")]
    public class Recommendation
    {
        [Key]
        public int RecommendationID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public float Score { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
