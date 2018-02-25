using System;
using System.Collections.Generic;
using System.Linq;

namespace CrimeSiteInvestigation.Model
{
    public class InvestigacaoModel
    {
        private static int[] jogoAtual;
        public int[] InicialNovoJogo(int suspeitos, int locais, int armas)
        {
            Random rnd = new Random();
            jogoAtual = new[] {
                rnd.Next(0, suspeitos),
                rnd.Next(0, locais),
                rnd.Next(0, armas) };
            return jogoAtual;
        }

        public int TentarResolver(int suspeito, int local, int arma)
        {
            Random rnd = new Random();

            var solucao = new Dictionary<int, bool>();
            solucao.Add(1, suspeito == jogoAtual[0]);
            solucao.Add(2, local == jogoAtual[1]);
            solucao.Add(3, arma == jogoAtual[2]);

            var erros = solucao.Where(x => !x.Value).Select(x => x.Key).ToArray();
            if (!erros.Any())
            {
                // acertou todos
                this.InicialNovoJogo(jogoAtual.Count(), jogoAtual.Count(), jogoAtual.Count());
                return 0;
            }
            
            // retorna um dos erros
            return erros[rnd.Next(0, erros.Count())];
        }
    }
}
