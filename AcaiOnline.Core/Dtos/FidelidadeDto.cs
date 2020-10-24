using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcaiOnline.Core.Dtos
{
    public class FidelidadeDto : BaseDto
    {
        public int Quantidade { get; set; }
        public int? Ganhos { get; set; }
        public int ClienteId { get; set; }
        public ClienteDto Cliente { get; set; }
    }
}
