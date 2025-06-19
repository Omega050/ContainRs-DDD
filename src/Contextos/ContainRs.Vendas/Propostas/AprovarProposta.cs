using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContainRs.Vendas.Locacoes;
using System.Transactions;
using ContainRs.Contracts;

namespace ContainRs.Vendas.Propostas;

public class AprovarProposta
{
    public AprovarProposta(Guid idPedido, Guid idProposta)
    {
        IdPedido = idPedido;
        IdProposta = idProposta;
    }

    public Guid IdPedido { get; }
    public Guid IdProposta { get; }
}
