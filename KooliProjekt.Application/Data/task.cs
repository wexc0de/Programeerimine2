using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KooliProjekt.Application.Data
{
    internal class task
    {
        public int id { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime start { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal estimatedhours { get; set; }
        [Required]
        [StringLength(25)]
        public string responsiblePerson { get; set; }
        [Required]
        [StringLength(255)]
        public string description { get; set; }
        [Required]
        public bool IsCompleted { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal FixedPrice { get; set; }
    }
}
