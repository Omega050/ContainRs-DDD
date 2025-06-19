using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContainRs.Vendas.Locacoes;
using System.Transactions;
using ContainRs.Contracts;

namespace ContainRs.Vendas.Propostas
{
    public class PropostaService : IPropostaService
    {
        private readonly IRepository<Proposta> repoProposta;
        private readonly IRepository<Locacao> repoLocacao;

        public PropostaService(IRepository<Proposta> repoProposta, IRepository<Locacao> repoLocacao)
        {
            this.repoProposta = repoProposta;
            this.repoLocacao = repoLocacao;
        }

        public async Task<Proposta?> AprovarAsync(AprovarProposta comando)
        {
            var proposta = await repoProposta
                .GetFirstAsync(
                    p => p.Id == comando.IdProposta && p.SolicitacaoId == comando.IdPedido,
                    p => p.Id);
            if (proposta is null) return null;

            proposta.Situacao = SituacaoProposta.Aceita;

            // criar locação a partir da proposta aceita
            var locacao = new Locacao()
            {
                PropostaId = proposta.Id,
                DataInicio = DateTime.Now,
                DataPrevistaEntrega = proposta.Solicitacao.DataInicioOperacao.AddDays(-proposta.Solicitacao.DisponibilidadePrevia),
                DataTermino = proposta.Solicitacao.DataInicioOperacao.AddDays(proposta.Solicitacao.DuracaoPrevistaLocacao)
            };

            using var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);

            await repoProposta.UpdateAsync(proposta);
            await repoLocacao.AddAsync(locacao);

            scope.Complete();
            return proposta;
        }
    }
}
