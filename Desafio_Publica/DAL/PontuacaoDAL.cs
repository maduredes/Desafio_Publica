using Desafio_Publica.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Publica.DAL
{
    public class PontuacaoDAL
    {
        private ObservableCollection<Pontuacao> Pontuacoes = new ObservableCollection<Pontuacao>();
        private static PontuacaoDAL PontuacaoInstance = new PontuacaoDAL();

        public static PontuacaoDAL GetInstance()
        {
            return PontuacaoInstance;
        }
        public void Add(Pontuacao pontuacao)
        {
            this.Pontuacoes.Add(pontuacao);
        }
        public void Delete(Pontuacao pontuacao)
        {
            this.Pontuacoes.Remove(pontuacao);
        }
        public ObservableCollection<Pontuacao> GetAll()
        {
            return Pontuacoes;
        }
    }
}
