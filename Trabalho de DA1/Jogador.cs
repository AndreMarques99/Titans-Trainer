using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_de_DA1
{
    public class Jogador
    {
        //Campos
        protected int m_CombatPower;
        protected int m_GamePoints;
        private string m_NickName;
        protected int m_NumeroCombatesRealizados;
        private string m_Powerups;

        //Array
       protected Powerup[] PowerUP = new Powerup[5];


        //Propriedades
        public int CombatPower
        {
            get
            {
                return m_CombatPower;
            }
            set
            {
                if (value >= 1000 && value <= 2000)
                { 
                    m_CombatPower = value; 
                }
                else if (value < 1000)
                {
                    m_CombatPower = 1000;
                }
                else if (value > 2000)
                {
                    m_CombatPower = 2000;
                }

            }
        }
        public int GamePoints
        {
            get
            {
                return m_GamePoints;
            }        
        }
        
        public string NickName
        {
            get
            {
                return m_NickName;
            }
            set
            {
                m_NickName = value;
            }
        }
        public int NumeroCombatesRealizados
        {
            get
            {
                return m_NumeroCombatesRealizados;
            }       
        }
        public string Powerups
        {
            get
            {
                return m_Powerups;
            }
            set
            {
                m_Powerups = value;
            }
        }
        //Métodos
        public int Praticar(int tempo)      
        {
            int Unidades = 0;

            if (tempo >= 5)    //Tempo máximo de treino será de 45 minutos!!
            {
                if (tempo >= 5 && tempo < 10)
                {
                    tempo = 5;
                    Unidades = tempo * 2;
                    return Unidades;
                }
                else if (tempo >= 10 && tempo < 15)
                {
                    tempo = 10;
                    Unidades = tempo * 2;
                    return Unidades;
                }
                else if (tempo >= 15 && tempo < 20)
                {
                    tempo = 15;
                    Unidades = tempo * 2;
                    return Unidades;
                }
                else if (tempo >= 20 && tempo < 25)
                {
                    tempo = 20;
                    Unidades = tempo * 2;
                    return Unidades;
                }
                else if (tempo >= 25 && tempo < 30)
                {
                    tempo = 25;
                    Unidades = tempo * 2;
                    return Unidades;
                }
                else if (tempo >= 30 && tempo < 35)
                {
                    tempo = 30;
                    Unidades = tempo * 2;
                    return Unidades;
                }
                else if (tempo >= 35 && tempo < 40)
                {
                    tempo = 35;
                    Unidades = tempo * 2;
                    return Unidades;
                }
                else if (tempo >= 40 && tempo < 45)
                {
                    tempo = 40;
                    Unidades = tempo * 2;
                    return Unidades;
                }
                else if (tempo >= 45)
                {
                    tempo = 45;
                    Unidades = tempo * 2;
                    return Unidades;
                }

                m_GamePoints = CustoCP(Unidades);
                m_CombatPower = m_CombatPower + Unidades;
                return Convert.ToInt32("O treino foi realizado com Sucesso!");
            }
            else
            {
                return Convert.ToInt32("O treino não foi realizado!");
            }
        } 

        public int Praticar()
        {
            int unidades = 60;

            if (m_GamePoints >= 300)
            {
                m_GamePoints = CustoCP(unidades);
                m_CombatPower = m_CombatPower + 60;
                return m_CombatPower;
            }
        else
            {
                return Convert.ToInt32("GamePoints Insuficientes!");
            }
        }

        public virtual int CustoCP(int unidade)
        {
            int Resultado = unidade * 5;

            if (m_GamePoints > Resultado)
            { 
                m_GamePoints = m_GamePoints - Resultado;
                return m_GamePoints;
            }
            else
            {
                return Convert.ToInt32("GamePoints Insuficientes!");
            }
        }


          public virtual double TitanCP(int bonusPowerUp1, int bonusPowerUp2)             
        {
            double Bonus1 = PowerUP[bonusPowerUp1].Bonus;
            double Bonus2 = PowerUP[bonusPowerUp2].Bonus;

            double resultado = Bonus1 + Bonus2;
            double resultadoFInal = CombatPower + (CombatPower * resultado);
            m_CombatPower = CombatPower + (CombatPower * Convert.ToInt32(resultado));
            return resultadoFInal;
        }
        public virtual string Apresentar()
        {
            string Apresentacao;
            string PowerUp1 = "";
            string PowerUp2 = "";

            Apresentacao = NickName + " tem um CP base de " + CombatPower + ", e está equipado com os power-ups" + PowerUp1 + "e " + PowerUp2 + ", vazio, vazio, vazio.Tem atualmente " + GamePoints + " pontos, obtidos em" + NumeroCombatesRealizados + " combates.";

            return Apresentacao;
        }
        public virtual int Combater(int PosicaoPowerUP1, int PosicaoPowerUP2, int TitanCP_adversario)
        {
            double jogador = TitanCP(PosicaoPowerUP1, PosicaoPowerUP2);
            double resultado;

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
        public string Combater500Vezes()
        {
            
            
            int titanCPOponente = 1500;
            int Valor = 100;
            int resultado  = Combater(0, 1, titanCPOponente);
            int vitoria = 0;
            int empate = 0;
            int derrota = 0;
            int pontos = m_GamePoints;
            string enunciado;

            for (int i =0; i < 500; i++)
            {   
               

                if (titanCPOponente <= 4000)
                {
                    titanCPOponente = titanCPOponente + Valor;
                    Valor = Valor + 100;

                    if (resultado == 1)
                    {
                        vitoria++;
                    }
                    else if (resultado == 0)
                    {
                        empate++;
                    }
                    else if (resultado == -1)
                    {
                        derrota++;
                    }


                }
                else
                {
                    titanCPOponente = 1500;
                }
            }
                enunciado = "Vitorias:" + vitoria + " ,Derrotas:" + derrota + " ,Empates:" + empate + " ,Pontos:" + pontos;
                return enunciado;
        }
        public string CombaterAte1000Pontos()
        {
            int titanCPOponente = 1500;
            int Valor = 100;
            int resultado = Combater(0, 1, titanCPOponente);
            int vitoria = 0;
            int empate = 0;
            int derrota = 0;
            int pontos = m_GamePoints;
            string enunciado;
            
            for (int i = 0; i < 1000; i++)
            {
               
                if (titanCPOponente <= 4000)
                {
                    titanCPOponente = titanCPOponente + Valor;
                    Valor = Valor + 100;

                    if (resultado == 1)
                    {
                        vitoria++;
                    }
                    else if (resultado == 0)
                    {
                        empate++;
                    }
                    else if (resultado == -1)
                    {
                        derrota++;
                    }
                    if (m_GamePoints == 1000)
                    {
                        break;
                    }
                }
                else
                {
                    titanCPOponente = 1500;
                }
            }
            enunciado = "Vitorias:" + vitoria + " ,Derrotas:" + derrota + " ,Empates:" + empate + " ,Pontos:" + pontos;
            return enunciado;
        }
        public virtual int TrocarPowerup(int novoPowerUP, int PosicaoNovoPowerUP)
        {
            if (PosicaoNovoPowerUP >= 0 && PosicaoNovoPowerUP < 5)
            {
                m_CombatPower = m_CombatPower - (200 * (Convert.ToInt32(PowerUP[novoPowerUP].Bonus)));
                return m_CombatPower;
            }
            else
            { 
                return Convert.ToInt32("Impossivel"); 
            }
        }

        //Construtor
        public Jogador (string nickname, int CPInicial)
        {
            
            m_CombatPower = CPInicial;
            m_GamePoints = 0;
            m_NickName = nickname;
            m_NumeroCombatesRealizados = 0;
           
            for (int i = 0; i < 5; i++)
            {
                PowerUP[i] = new Powerup("vazio", 0);
            }


        }
        
        


    }
}
