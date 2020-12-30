using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_de_DA1
{
    public class JogadorProfissional : Jogador
    {
        private bool m_TemHabilidadeSecreta;
        private string m_TipoSubscricao;
        private double m_ApostaAtual;
        private int m_Moedas;

        public bool TemHabilidadeSecreta
        {
            get
            {
                return m_TemHabilidadeSecreta;
            }
            set
            {
                m_TemHabilidadeSecreta = value;
            }
        }
        public string TipoSubscricao
        {
            get
            {
                return m_TipoSubscricao;
            }
            set
            {
                m_TipoSubscricao = value;
            }
        }
        public double ApostaAtual
        {
            get
            {
                return m_ApostaAtual;
            }
            set
            {
                m_ApostaAtual = value;
            }
        }
        public int Moedas
        {
            get
            {
                return m_Moedas;
            }
            set
            {
                m_Moedas = value;
            }
        }
        public JogadorProfissional(string nickname, int CPInicial) : base(nickname, CPInicial)
        {
            TemHabilidadeSecreta = true;
            TipoSubscricao = "";
            ApostaAtual = 2;
            Moedas = 10;
        }
    }
}
