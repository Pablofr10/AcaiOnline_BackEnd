using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AcaiOnline.Entities.Models;

namespace AcaiOnline.Core.Interfaces.Repositories
{
    public interface IPedidoRepository
    {
        Task<IEnumerable<Pedido>> GetAllPedidos();
        Task<Pedido> GetPedidoById(int pedidoId);
    }
}