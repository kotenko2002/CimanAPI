using Entities.Companies;
using System.ComponentModel.DataAnnotations;

namespace Entities.Areas
{
    public class Area : BaseEntity<int>
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}
