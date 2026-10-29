using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KooliProjekt.Application.Dto
{
    public class ProjectDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime start { get; set; }
        public DateTime deadline { get; set; }
        public decimal budget { get; set; }

    }
}