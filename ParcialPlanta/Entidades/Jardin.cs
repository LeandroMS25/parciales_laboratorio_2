using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jardin
    {
        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;

        static Jardin() 
        {
            Jardin.suelo = Tipo.Terrozo;
        }

        private Jardin() 
        {
            this.plantas = new List<Planta>();
        }

        public Jardin(int espacioTot) : this() 
        {
            this.espacioTotal = espacioTot;
        } 

        public Tipo TipoSuelo 
        {
            set 
            {
                Jardin.suelo = value;
            }
        }

        private int EspacioOcupado() 
        {
            int espacioOcupado = 0;
            foreach (Planta planta  in this.plantas)
            {
                espacioOcupado += planta.Tamanio;
            }
            return espacioOcupado;
        }

        private int EspacioOcupado(Planta planta)
        {
            return this.EspacioOcupado()+planta.Tamanio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Composicion del jardin: {0}",Jardin.suelo));
            /*
            if (Jardin.suelo == Tipo.Terrozo)
            {
                sb.AppendLine(string.Format("Composicion del jardin: TERROZO"));   
            }
            else 
            {
                sb.AppendLine(string.Format("Composicion del jardin: ARENOZO"));
            }
            */
            sb.AppendLine(string.Format("Espacio ocupado {0} de {1}\n",this.EspacioOcupado(),this.espacioTotal));
            sb.AppendLine(string.Format("==================== LISTA DE PLANTAS ===================="));
            foreach (Planta planta in this.plantas)
            {
                sb.AppendLine(planta.ResumenDeDatos());
            }
            return sb.ToString();
        }

        public static bool operator +(Jardin jardin, Planta planta) 
        {
            if (jardin.espacioTotal >= jardin.EspacioOcupado(planta))
            {
                jardin.plantas.Add(planta);
                return true;
            }
            return false;
        }

        public enum Tipo 
        {
            Terrozo,
            Arenozo
        }
    }
}
