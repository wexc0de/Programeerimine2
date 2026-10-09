using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KooliProjekt.Application.Data
{
    internal class logs
    {
        public int id { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime date { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal hours { get; set; }

        [Required]
        [StringLength(255)]
        public string worker { get; set; }

        [Required]
        [StringLength(255)]
        public string description { get; set; }
    }
}
