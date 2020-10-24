using System.Collections.Generic;
using System.Threading.Tasks;
using AcaiOnline.Core.Interfaces.Repositories;
using AcaiOnline.Core.Interfaces.Services;
using AcaiOnline.Entities.Models;

namespace AcaiOnline.Application.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IUnitOfWork _repository;

        public PedidoService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        public Task<IEnumerable<Pedido>> GetAllPedidos()
        {
            return _repository.PedidoRepository.GetAll();
        }

        public Task<Pedido> GetPedidoById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Pedido> AddPedido(Pedido pedido)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeletePedido(Pedido pedido)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdatePedido(Pedido pedido)
        {
            throw new System.NotImplementedException();
        }
    }
}