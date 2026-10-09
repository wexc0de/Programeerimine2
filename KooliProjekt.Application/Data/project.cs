using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KooliProjekt.Application.Data
{
    [Index(nameof(name), IsUnique = true)]

    internal class project

    {
        public int id { get; set;  }

        [Required]
        [StringLength(25)]
        public string name { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime start { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime Deadline { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal buget { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal hourlyRate { get; set; }

        [Required]
        [StringLength(100)]
        public string team { get; set; }
    }
}
