using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace velocidadeDoRobo.Models
{
    public class Robo
    {
        public Robo (int vmin, int vmax)
        {
            VelocidadeMinima = vmin;
            VelocidadeMaxima = vmax;
            VelocidadeAtual = vmin;
        }

        public int VelocidadeAtual { get; set; } = 0;
        public int VelocidadeMaxima { get; }
        public int VelocidadeMinima { get; }

        public void Acelerar()
        {
            if (VelocidadeAtual < VelocidadeMaxima)
            {
                VelocidadeAtual++;
            }
        }

        public void Desacelerar()
        {
            if (VelocidadeAtual >= VelocidadeMinima)
            {
                VelocidadeAtual--;
            }
        }
    }
}