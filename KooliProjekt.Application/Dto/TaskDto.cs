using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Dto
{
    public class TaskDto
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime start { get; set; }
        public decimal estimatedHours { get; set; }
        public string responsiblePerson { get; set; }
        public string description { get; set; }
        public bool IsCompleted { get; set; }
        public decimal FixedPrice { get; set; }
    }
}
