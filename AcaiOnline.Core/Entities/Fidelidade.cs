using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AcaiOnline.Entities.Models
{
    public class Fidelidade : BaseEntity
    {
        public int Quantidade { get; set; }
        public int? Ganhos { get; set; }
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
