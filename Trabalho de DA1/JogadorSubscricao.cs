using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_de_DA1
{
    public class JogadorSubscricao : Jogador
    {
        //Campos
        private bool m_TemHabilidadeSecreta;
        private string m_TipoSubscricao;

        //Propriedades
        public int MyProperty { get; set; }
        public virtual bool TemHabilidadeSecreta
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
            {   if(value == "Bronze" || value == "Silver" || value == "Gold")
                m_TipoSubscricao = value;
            }
        }
        //Métodos
        public override double TitanCP(double Valor1, double Valor2)
        {
            if (m_TemHabilidadeSecreta == false)
            {
                double Valor = Valor1 + Valor2 + 1;
                double Resultado;
                Resultado = CombatPower * (Valor + 0.1);

                return Resultado;
            }
            else
            {
                double Valor = Valor1 + Valor2 + 1;
                double Resultado;
                Resultado = CombatPower * (Valor + 0.2);

                return Resultado;
            }

        }
        public int NumeroCombatesPermitidos()
        {
            if (TipoSubscricao == "Bronze")
            {
                return 1000;
            }
            else if (TipoSubscricao == "Silver")
            {
                return 5000;
            }
            else if (TipoSubscricao == "Gold")
            {
                return 10000;
            }
            else
                return 0;

        }
        public override int Combater(int PosicaoPowerUP1, int PosicaoPowerUP2, int TitanCP_adversario)
        {
            double jogador = TitanCP(PosicaoPowerUP1, PosicaoPowerUP2);
            double resultado;

            if (CombatesRestantes() >= 1)
            {
                if (jogador > TitanCP_adversario)
                {
                    if (m_CombatPower > TitanCP_adversario)
                    {
                        resultado = (jogador - TitanCP_adversario) * 0.1;
                        m_GamePoints = Convert.ToInt32(resultado * 2);
                    }
                    else
                    {
                        resultado = (jogador - TitanCP_adversario) * 0.1;
                        m_GamePoints = Convert.ToInt32(resultado);
                    }
                    return 1;
                }
                else if (jogador == TitanCP_adversario)
                {
                    return 0;
                }
                else if (jogador > TitanCP_adversario)
                {
                    resultado = (TitanCP_adversario - jogador) * 0.1;
                    m_GamePoints = Convert.ToInt32(resultado);
                    return -1;
                }
                else
                    return Convert.ToInt32("Impossivel");
            }
            else
                return Convert.ToInt32("Impossivel");
        }

        //(Metodo Auxiliar)
        public int CombatesRestantes()
        {
            if (TipoSubscricao == "Bronze")
            {
                int resultado;
                resultado = 1000 - NumeroCombatesRealizados;
                return resultado;
            }
            else if (TipoSubscricao == "Silver")
            {
                int resultado;
                resultado = 5000 - NumeroCombatesRealizados;
                return resultado;
            }
            else if (TipoSubscricao == "Gold")
            {
                int resultado;
                resultado = 10000 - NumeroCombatesRealizados;
                return resultado;
            }
            else
                return 0;
        }      
        
        public override int CustoCP(int Unidade)
        {
            int Resultado = Unidade * 7;
            m_GamePoints = m_GamePoints - Resultado;
            return m_GamePoints;
        }
        public override string Apresentar()
        {
            string Apresentacao;
            string PowerUP1 = "";
            string PowerUP2 = "";

            Apresentacao = NickName + " tem um CP base de " + CombatPower + ", e está equipado com os power-ups" + PowerUP1 + "e " + PowerUP2 + ", vazio, vazio, vazio.Tem atualmente " + GamePoints + " pontos, obtidos em" + NumeroCombatesRealizados + " combates. A jogar com uma subcricao" + TipoSubscricao + ", pode travar mais" + CombatesRestantes() + "combates.";


            return Apresentacao;
        }
        //Construtor
        public JogadorSubscricao(string nickname, int CPInicial, string tiposubscricao) : base(nickname, CPInicial)
        {
            m_TemHabilidadeSecreta = false;
            m_TipoSubscricao = tiposubscricao;
        }
    }
}
