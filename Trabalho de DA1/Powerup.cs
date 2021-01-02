using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_de_DA1
{
    public class Powerup
    {   
        //Campos
        private string m_Nome;
        private double m_Bonus;

        //Propriedades
       public string Nome
        {
            get
            {
                return m_Nome;
            }
            set
            {
                m_Nome = value;
            }
        }
        public double Bonus
        {
            get
            {
                return m_Bonus;
            }
            set
            {
                if (value >= 0.0 && value <= 0.5)
                { 
                    m_Bonus = value; 
                }
            }
        }
       
        //Construtor
        public Powerup(string nome, double bonus)
        {
            m_Nome = nome;
            m_Bonus = bonus;
        }
    }
}
