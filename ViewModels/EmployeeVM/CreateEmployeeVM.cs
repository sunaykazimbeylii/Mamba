using Mamba.Models;
using System.ComponentModel.DataAnnotations;

namespace Mamba.ViewModels
{
    public class CreateEmployeeVM
    {
        [MaxLength(100,ErrorMessage ="Limit 100dur")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public IFormFile Photo{ get; set; }
        [Required]
        public int? PositionId { get; set; }
        public List<Position>? Positions { get; set; }
    }
}
