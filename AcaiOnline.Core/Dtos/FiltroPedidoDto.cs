using System;
using System.Collections.Generic;
using System.Text;

namespace AcaiOnline.Entities.Models.Dtos
{
    public class FiltroPedidoDto
    {
        public int mes { get; set; }
        //public int status { get; set; }
        public int id_cliente { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string query { get; set; }
    }
}
