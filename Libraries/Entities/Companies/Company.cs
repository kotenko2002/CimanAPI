﻿using Entities.Areas;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Companies
{
    public class Company : BaseEntity<int>
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        public virtual ICollection<Area> Areas { get; set; }

    }
}
