using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_de_DA1
{     
    public class JogadorProfissional : JogadorSubscricao
    {
        //Campos
        private bool m_TemHabilidadeSecreta;
        private int m_ApostaAtual;
        private int m_Moedas;

        //Propriedades
        public override bool TemHabilidadeSecreta
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
       
        public int ApostaAtual
        {
            get
            {
                return m_ApostaAtual;
            }
            set
            {
                if (value < 0 || m_ApostaAtual > m_Moedas)
                {
                    m_ApostaAtual = 2;
                }
                else if(value == 0)
                {
                    
                    CombatPower = CombatPower + 100;
                    
                }
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
        //Métodos
        public override string Apresentar()
        {
            string Apresentacao;
            string PowerUP1 = "";
            string PowerUP2 = "";

            Apresentacao = NickName + " tem um CP base de " + CombatPower + ", e está equipado com os power-ups" + PowerUP1 + "e " + PowerUP2 + ", vazio, vazio, vazio.Tem atualmente " + GamePoints + " pontos, obtidos em" + NumeroCombatesRealizados + " combates. A jogar com uma subcricao" + TipoSubscricao + ", pode travar mais" + CombatesRestantes() + "combates. Tem" + Moedas + " Moedas em carteira e aposta" + ApostaAtual + " Moedas em cada combate.";


            return Apresentacao;
        }
        public override int CustoCP(int Unidade)
        {
            int Resultado = Unidade * 5;
            m_GamePoints = m_GamePoints - Resultado;
            return m_GamePoints;
        }
        //Construtor
        public JogadorProfissional(string nickname, int CPInicial, string tiposubscricao, int apostaInicial) : base (nickname, CPInicial,  tiposubscricao)
        {
            m_TemHabilidadeSecreta = true;     //Supondo que os jogadoresProfissionais começam com habilidade Secreta
            m_ApostaAtual = apostaInicial;
            m_Moedas = 10;
        }
    }
}
