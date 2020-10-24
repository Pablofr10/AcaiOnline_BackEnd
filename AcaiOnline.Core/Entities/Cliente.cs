using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AcaiOnline.Entities.Models
{
    public class Cliente : BaseEntity
    {
        [Required(ErrorMessage = "O nome do cliente é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O endereço é obrigatório", AllowEmptyStrings = false)]
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Telefone { get; set; }
        public Fidelidade Fidelidade { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
        public DateTime? DataExclusao { get; set; }

    }
}
