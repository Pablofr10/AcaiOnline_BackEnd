using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AcaiOnline.Entities.Models;

namespace AcaiOnline.Core.Interfaces.Services
{
    public interface IPedidoService
    {
        Task<IEnumerable<Pedido>> GetAllPedidos();
        Task<Pedido> GetPedidoById(int id);
        Task<Pedido> AddPedido(Pedido pedido);
        Task<bool> DeletePedido(Pedido pedido);
        Task<bool> UpdatePedido(Pedido pedido);
    }
}