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
        private int m_Powerups;
       

       
        public int CombatPower
        {
            get
            {
                return m_CombatPower;
            }
            set
            {
                m_CombatPower = value;
            }
        }
        public int GamePoints
        {
            get
            {
                return m_GamePoints;
            }
            set
            {
                m_GamePoints = value;
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
            set
            {
                m_NumeroCombatesRealizados = value;
            }
        }
        public int Powerups
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
        
        public Jogador (string nickname, int CPInicial)
        {
            
            CombatPower = CPInicial;
            GamePoints = 0;
            NickName = nickname;
            NumeroCombatesRealizados = 0;
            Powerups = 0;
         
        }


    }
}
