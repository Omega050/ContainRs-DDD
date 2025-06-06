using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainRs.Clientes.Cadastro
{
    public interface IAcessoManager
    {
        Task AdicionarClienteAsync(string email, CancellationToken cancellationToken);
        Task RemoverClienteAsync(string email, CancellationToken cancellationToken);
        Task<bool?> ClientePossuiAcessoAsync(string email, CancellationToken cancellationToken);
        Task BloquearClienteAsync(string email, CancellationToken cancellationToken);
    }
}
