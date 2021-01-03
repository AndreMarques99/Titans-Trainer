﻿using System;
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
        public override int Combater(int PosicaoPowerUP1, int PosicaoPowerUP2, int TitanCP_adversario)
        {
            double jogador = TitanCP(PosicaoPowerUP1, PosicaoPowerUP2);
            double resultado;
            int Aposta = m_Moedas - m_ApostaAtual;

            if (m_ApostaAtual <= m_Moedas)
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
                    m_Moedas = Aposta + (ApostaAtual * 2);
                    m_ApostaAtual++;
                    return 1;
                }
                else if (jogador == TitanCP_adversario)
                {
                    if (m_ApostaAtual > 1)
                    {
                        m_ApostaAtual--;
                    }
                    return 0;                
                }
                else if (jogador < TitanCP_adversario)
                {
                   
                        resultado = (TitanCP_adversario - jogador) * 0.1;
                        m_GamePoints = Convert.ToInt32(resultado);
                        m_Moedas = Aposta;
                    if (m_ApostaAtual > 1)
                    {
                        m_ApostaAtual--;
                    }                                       
                    return -1;
                }
                else
                    return Convert.ToInt32("Impossivel");
            }
            else
                return Convert.ToInt32("Impossivel");
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
