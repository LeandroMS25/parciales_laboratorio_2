using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;

        public Planta(string nombre, int tamanio) 
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }

        public int Tamanio 
        {
            get 
            {
                return this.tamanio;
            }
        }

        public abstract bool TieneFlores 
        {
            get;
        }

        public abstract bool TieneFruto
        {
            get;
        }

        public virtual string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("{0} tiene un tamaño de {1}", this.nombre, this.tamanio));
            if (this.TieneFlores)
            {
                sb.AppendLine(string.Format("Tiene flores: SI"));
            }
            else 
            {
                sb.AppendLine(string.Format("Tiene flores: NO"));
            }
            if (this.TieneFruto)
            {
                sb.AppendLine(string.Format("Tiene fruto: SI"));
            }
            else
            {
                sb.AppendLine(string.Format("Tiene fruto: NO"));
            }
            return sb.ToString();
        }
    }
}
