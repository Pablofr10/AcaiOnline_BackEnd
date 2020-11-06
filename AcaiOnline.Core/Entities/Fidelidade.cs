using System.ComponentModel.DataAnnotations.Schema;

namespace AcaiOnline.Core.Entities
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
