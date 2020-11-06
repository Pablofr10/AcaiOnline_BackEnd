using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AcaiOnline.Entities.Models;

namespace AcaiOnline.Core.Entities
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
