using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_de_DA1
{
    public class Jogador
    {
        
        private int m_CombatPower;
        private int m_GamePoints;
        private string m_NickName;
        private int m_NumeroCombatesRealizados;
        private string m_Powerups;

        Powerup[] PowerUP = new Powerup[5];
        
       
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
        public int Praticar(int tempo)          //Falta indicar ao cliente se o treino foi realizado ou nao!
        {
            int Unidades = 0;  

        if (tempo == 5)
            {
                Unidades = tempo * 2;
                return Unidades;
            }
        else if (tempo == 10)
            {
                Unidades = tempo * 2;
                return Unidades;
            }
        else if (tempo == 15)
            {
                Unidades = tempo * 2;
                return Unidades;
            }
        else if (tempo == 20)
            {
                Unidades = tempo * 2;
                return Unidades;
            }
        else if (tempo == 25)
            {
                Unidades = tempo * 2;
                return Unidades;
            }
        else if (tempo == 30)
            {
                Unidades = tempo * 2;
                return Unidades;
            }
            m_CombatPower = m_CombatPower + Unidades;
            return m_CombatPower;
            
        } 

        public int Praticar()
        {
            m_CombatPower = m_CombatPower + 60;
            return m_CombatPower;
        }

       public virtual int CustoCP(int unidade)
        {
            int Resultado = unidade * 5;
            int ResultadoFinal = m_GamePoints - Resultado;
            return ResultadoFinal;
        }

        public virtual double ApplyPower(int bonusPowerUp1, int bonusPowerUp2)
        {
           
            double Bonus1 = PowerUP[bonusPowerUp1].Bonus;
            double Bonus2 = PowerUP[bonusPowerUp2].Bonus;

            double resultado = Bonus1 + Bonus2;
            double resultadoFInal = CombatPower + (CombatPower * resultado);
            return resultadoFInal;

        }

          public virtual double TitanCP(double powerUp1, double powerUp2)             
        {
            double Valor = powerUp1 + powerUp2 + 1;
            double Resultado;
            Resultado = CombatPower * Valor;

            return Resultado;
        }
        public virtual string Apresentar()
        {
            string Apresentacao;
            string PowerUp1 = "";
            string PowerUp2 = "";

            Apresentacao = NickName + " tem um CP base de " + CombatPower + ", e está equipado com os power-ups" + PowerUp1 + "e " + PowerUp2 + ", vazio, vazio, vazio.Tem atualmente " + GamePoints + " pontos, obtidos em" + NumeroCombatesRealizados + " combates.";

            return Apresentacao;
        }
      /*  public virtual string Combater(int PosicaoPowerUP1, int PosicaoPowerUP2, int TitanCP)
        {

        } 
      */
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
