using System.Collections.Generic;
using System.Threading.Tasks;
using AcaiOnline.Core.Entities;
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
        public async Task<IEnumerable<Pedido>> GetAllPedidos()
        {
            return await _repository.PedidoRepository.GetAllPedidos();
        }

        public async Task<Pedido> GetPedidoById(int id)
        {
            return await _repository.PedidoRepository.GetPedidoById(id);
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