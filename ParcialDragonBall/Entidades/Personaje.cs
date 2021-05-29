using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personaje
    {
        protected List<EHabilidades> ataques;
        protected int nivelPoder;
        protected string nombre;

        private Personaje()
        {
            this.ataques = new List<EHabilidades>();
        }

        protected Personaje(string nombre, int nivelPoder):this()
        {
            this.nombre = nombre;
            this.nivelPoder = nivelPoder;
        }

        protected Personaje(string nombre, int nivelPoder, List<EHabilidades> ataques)
            : this(nombre, nivelPoder)
        {
            this.ataques = ataques;
        }

        protected abstract string Descripcion
        {
            get;
        }

        public virtual string InfoPersonaje()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Lista de ataques: {this.ataques}");
            sb.AppendLine($"Nivel de poder: {this.nivelPoder}");
            sb.AppendLine($"Descripcion: {this.Descripcion}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public abstract string Transformarse();

        public static bool operator ==(Personaje p1, List<Personaje> listaPersonajes)
        {
            foreach (Personaje pj in listaPersonajes)
            {
                if (pj.Equals(p1) && pj.nombre == p1.nombre)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Personaje p1, List<Personaje> listaPersonajes)
        {
            return !(p1 == listaPersonajes);
        }

        public static bool operator ==(Personaje p1, Personaje p2)
        {
            if (p1.GetType() == p2.GetType() && p1.nombre == p2.nombre)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Personaje p1, Personaje p2)
        {
            return !(p1 == p2);
        }
    }
}
