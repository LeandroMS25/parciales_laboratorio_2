using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comic:Publicacion
    {
        private bool esColor;
        /// <summary>
        /// Inicializa una Publicacion seteando esColor y sobrecargando el constructor base.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="esColor"></param>
        /// <param name="stock"></param>
        /// <param name="importe"></param>
        public Comic(string nombre, bool esColor, int stock, float importe) : base(nombre, stock, importe)
        {
            this.esColor = esColor;
        }
        /// <summary>
        /// Indica si el comic es o no de color.
        /// </summary>
        protected override bool EsColor
        {
            get
            {
                return this.esColor;
            }
        }
    }
}