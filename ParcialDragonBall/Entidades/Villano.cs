using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Villano:Personaje
    {
        private bool maximoPoder;
        private EOrigen origen;

        public Villano(string nombre, int nivelPoder, List<EHabilidades> ataques, EOrigen origen)
            : base(nombre, nivelPoder, ataques) 
        {
            this.origen = origen;
        }

        protected override string Descripcion 
        {
            get 
            {
                return "Soy malisimo. Diabolico. Asi como los profes de labo de la noche.";            
            }
        }

        public override string Transformarse()
        {
            if (this.maximoPoder == false)
            {
                this.nivelPoder *= 180/100;
                this.maximoPoder = true;
                return "Poder aumentado al máximo.";
            }
            return "El poder ya está al límite.";
        }

        public override string InfoPersonaje()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.InfoPersonaje());
            if (maximoPoder) 
            {
                sb.AppendLine("Maximo poder alcanzado.");
            }
            else
            {
                sb.AppendLine("Maximo poder incompleto. ");
            }
            sb.AppendLine($"Origen del villano: {this.origen}");
            return sb.ToString();
        }
    }
}
