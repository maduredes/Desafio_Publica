using Desafio_Publica.DAL;
using Desafio_Publica.Modelo;
using System;
using System.Collections.Generic;

using System.Windows.Forms;
//By:Maria Eduarda Dias Correa Redes


namespace Desafio_Publica
{
    public partial class Form1 : Form
    {

        private PontuacaoDAL pontuacaoDAL = PontuacaoDAL.GetInstance();


        public Form1()
        {
            InitializeComponent();

        }

    

        private void Form1_load(object sender, EventArgs e)
        {
            //aqui seto os dados que foram passados no problema
            InserirJogos();
            var jogos = pontuacaoDAL.GetAll();
            foreach(var item in jogos)
            {
                var row = new string[] { item.jogo.ToString(),item.placar.ToString(), item.minTemp.ToString(), item.maxTemp.ToString(), item.quebraRecordMin.ToString(), item.quebraRecordMax.ToString() };
                var list = new ListViewItem(row);
                list.Tag = item;
                listViewPontos.Items.Add(list);
               
            }

        }

  

        
     

        private void InserirJogos()
        {
            pontuacaoDAL.Add(new Pontuacao
            {
                jogo = 1,
                placar = 12,
                minTemp = 12,
                maxTemp = 12,
                quebraRecordMin = 0,
                quebraRecordMax = 0
            });
            pontuacaoDAL.Add(new Pontuacao
            {
                jogo = 2,
                placar = 24,
                minTemp = 12,
                maxTemp = 24,
                quebraRecordMin = 0,
                quebraRecordMax = 1
            });

            pontuacaoDAL.Add(new Pontuacao
            {
                jogo = 3,
                placar = 10,
                minTemp = 10,
                maxTemp = 24,
                quebraRecordMin = 1,
                quebraRecordMax = 1
            });

            pontuacaoDAL.Add(new Pontuacao
            {
                jogo = 4,
                placar = 24,
                minTemp = 10,
                maxTemp = 24,
                quebraRecordMin = 1,
                quebraRecordMax = 1
            });


           

        }

        private void AtualizaDados()
        {

            var jogos = pontuacaoDAL.GetAll();

            foreach (var item in jogos)
            {
                var row = new string[] { item.jogo.ToString(), item.placar.ToString(), item.minTemp.ToString(), item.maxTemp.ToString(), item.quebraRecordMin.ToString(), item.quebraRecordMax.ToString() };
                var list = new ListViewItem(row);
                list.Tag = item;
                listViewPontos.Items.Add(list);
            }

        }

        private int CalcRecordMinTemp(int placar)
        {
            int minTemporada = 10;
            //verifico se o minimo da temporada é igual o minimo requirido
            if (placar == minTemporada)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        private int CalcRecordMaxTemp(int placar)
        {
            int maxTemporada = 24;
            //verifico se o maximo da temporada é igual o maximo requirido

            if (placar == maxTemporada)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //verifico se existem campos vazios
            if (txtplacar.Text.Trim() == "" || txtJogo.Text.Trim() == "" || txt_maxTemp.Text.Trim() == "" || txt_minTemp.Text.Trim() == "")
            {
                MessageBox.Show("Preencha Todos os campos!","Erro");
                return;
                
            }

         
            int placar = Convert.ToInt32(txtplacar.Text.Trim());

            var quantidadeMin=CalcRecordMinTemp(Convert.ToInt32(txt_minTemp.Text.Trim()));
            var quantidadeMax = CalcRecordMaxTemp(Convert.ToInt32(txt_maxTemp.Text.Trim()));

            if (placar >= 1000)
            {
                MessageBox.Show("O placar deve ser menor que 1000!");
                return;
            }
            if (placar < 0)
            {
                MessageBox.Show("O placar não pode ser negativo");
                return;
            }

            pontuacaoDAL.Add(new Pontuacao
            {
                jogo = Convert.ToInt32(txtJogo.Text.Trim()),
                placar=Convert.ToInt32(txtplacar.Text.Trim()),
                maxTemp=Convert.ToInt32(txt_maxTemp.Text.Trim()),
                minTemp=Convert.ToInt32(txt_minTemp.Text.Trim()),
                quebraRecordMin=quantidadeMin,
                quebraRecordMax=quantidadeMax
            });

            //tenho que limpar os dados antigos para evitar duplicidade
            listViewPontos.Items.Clear();

            AtualizaDados();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }



      
        //evento de click do mouse da linha para poder deletar a linha que quiser
       
    }
}
