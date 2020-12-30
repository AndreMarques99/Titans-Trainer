using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_de_DA1
{
    public class JogadorSubscricao : Jogador
    {

        private bool m_TemHabilidadeSecreta;
        private string m_TipoSubscricao;

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
        public JogadorSubscricao(string nickname, int CPInicial) : base(nickname, CPInicial)
        {
            TemHabilidadeSecreta = false;
            TipoSubscricao = "";
        }
    }
}
