using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biografia: Publicacion
    {
        /// <summary>
        /// Inicializa una Biografia y sobrecarga el constructor base
        /// </summary>
        /// <param name="nombre"></param>
        public Biografia(string nombre):base(nombre)
        {

        }
        /// <summary>
        /// Inicializa una Biografia y sobrecarga el constructor base
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="stock"></param>
        public Biografia(string nombre, int stock) : base(nombre,stock)
        {

        }
        /// <summary>
        /// Inicializa una Biografia y sobrecarga el constructor base
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="stock"></param>
        /// <param name="importe"></param>
        public Biografia(string nombre, int stock, float importe) : base(nombre, stock, importe)
        {

        }
        /// <summary>
        /// Retorna true si hay stock de la biografia.
        /// Chequea si la cantidad es mayor a 0.
        /// </summary>
        public override bool HayStock 
        {
            get 
            {
                if (this.stock > 0) 
                {
                    return true;
                }
                return false;
            }
        }
        /// <summary>
        /// Indica que la biografia no tiene color.
        /// </summary>
        protected override bool EsColor 
        {
            get 
            {
                return false;
            }
        }
        /// <summary>
        /// Convierte un string en una biografia.
        /// </summary>
        /// <param name="nombre"></param>
        public static explicit operator Biografia(string nombre) 
        {
            return new Biografia(nombre);
        }
    }
}
