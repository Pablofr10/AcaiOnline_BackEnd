using System;
using System.Collections.Generic;

namespace AcaiOnline.Core.Dtos
{
    public class ClienteDto : BaseDto
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Telefone { get; set; }
        public FidelidadeDto Fidelidade { get; set; }
        public ICollection<PedidoDto> Pedidos { get; set; }
        public DateTime? DataExclusao { get; set; }
    }
}
