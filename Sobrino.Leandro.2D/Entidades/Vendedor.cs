using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;
        /// <summary>
        /// Inicializa una Vendedor e inicializa su lista de ventas.
        /// </summary>
        private Vendedor() 
        {
            this.ventas = new List<Publicacion>();
        }
        /// <summary>
        /// Inicializa una Vendedor seteando el nombre y sobrecarga el constructor
        /// </summary>
        /// <param name="nombre"></param>
        public Vendedor(string nombre):this()
        {
            this.nombre = nombre;
        }
        /// <summary>
        /// Muestra el nombre, las ventas y la ganancia total del vendedor.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static string InformeDeVentas(Vendedor v) 
        {
            float gananciaTotal = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {v.nombre}");
            foreach (Publicacion p in v.ventas)
            {
                sb.AppendLine($"--------------------------------------");
                sb.AppendLine($"Publicacion: {p.Informacion()}");
                gananciaTotal += p.Importe;
            }
            sb.AppendLine($"Ganancia total: ${gananciaTotal}");
            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga del operador + para agregar una publicacion a la lista
        /// </summary>
        /// <param name="v"></param>
        /// <param name="p"></param>
        /// <returns>Retorna true o false dependiendo si lo agrego</returns>
        public static bool operator +(Vendedor v, Publicacion p) 
        {
            if (p.HayStock == true) 
            {
                v.ventas.Add(p);
                p.Stock--;
                return true;
            }
            return false;
        }
    }
}
