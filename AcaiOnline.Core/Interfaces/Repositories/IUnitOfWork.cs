using System.Threading.Tasks;

namespace AcaiOnline.Core.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        IPedidoRepository PedidoRepository { get;  }
        IProdutoRepository ProdutoRepository { get;  }
        Task<bool> SaveAll();
    }
}