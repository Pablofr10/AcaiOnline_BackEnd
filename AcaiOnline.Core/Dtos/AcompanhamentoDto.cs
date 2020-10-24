

namespace AcaiOnline.Core.Dtos
{
    public class AcompanhamentoDto : BaseDto
    {
        public string Nome { get; set; }
        public bool IsDisponivel { get; set; }
        public decimal? Valor { get; set; }
    }
}
