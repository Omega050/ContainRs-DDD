using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainRs.Vendas.Propostas;

public class ComentarioProposta
{
    public ComentarioProposta(Guid idPedido, Guid idProposta, string mensagem, string pessoa)
    {
        IdPedido = idPedido;
        IdProposta = idProposta;
        Mensagem = mensagem;
        Pessoa = pessoa;
    }

    public Guid IdPedido { get; }
    public Guid IdProposta { get; }
    public string Mensagem { get; set; }
    public string Pessoa { get; set; }

}
