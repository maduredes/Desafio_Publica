using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Publica.Modelo
{
   public class Pontuacao
    {
        public int jogo { get; set; }
        public int placar { get; set; }
        public int minTemp { get; set; }
        public int maxTemp { get; set; }
        public bool quebrouRecord { get; set; }
        public int quebraRecordMin { get; set; }
        public int quebraRecordMax { get; set; }
    }
}
