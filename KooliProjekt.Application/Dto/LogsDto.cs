using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KooliProjekt.Application.Dto
{
    public class LogsDto
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public decimal hours { get; set; }
        public string worker { get; set; }
        public string description { get; set; }

    }
}