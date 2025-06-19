using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainRs.Vendas.Propostas;

public interface IPropostaService
{
    Task<Proposta?> AprovarAsync(AprovarProposta comando);
}
