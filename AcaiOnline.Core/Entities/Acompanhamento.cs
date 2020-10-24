using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcaiOnline.Entities.Models
{
    public class Acompanhamento : BaseEntity
    {
        public string Nome { get; set; }
        public bool IsDisponivel { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Valor { get; set; }
        public DateTime? DataExclusao { get; set; }
        public ICollection<Adicional> Adicionals { get; set; }
    }
}
