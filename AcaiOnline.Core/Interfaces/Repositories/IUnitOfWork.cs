using System.Threading.Tasks;

namespace AcaiOnline.Core.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        IPedidoRepository PedidoRepository { get;  }
        Task<bool> SaveAll();
    }
}