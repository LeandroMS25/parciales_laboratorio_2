using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;
        /// <summary>
        /// Inicializa una Publicacion seteando el nombre
        /// </summary>
        /// <param name="nombre"></param>
        public Publicacion(string nombre) 
        {
            this.nombre = nombre;
        }
        /// <summary>
        /// Inicializa una Publicacion seteando el stock y sobrecargando el constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="stock"></param>
        public Publicacion(string nombre, int stock) : this(nombre)
        {
            this.Stock = stock;
        }
        /// <summary>
        /// Inicializa una Publicacion seteando el importe y sobrecargando el constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="stock"></param>
        /// <param name="importe"></param>
        public Publicacion(string nombre, int stock, float importe) :this(nombre,stock)
        {
            this.importe = importe;
        }
        /// <summary>
        /// Muestra si la publicacion tiene color
        /// </summary>
        protected abstract bool EsColor
        {
            get;
        }
        /// <summary>
        /// Retorna true si hay stock de la publicacion
        /// Chequea si la cantidad es mayor a 0 y si tiene importe.
        /// </summary>
        public virtual bool HayStock
        {
            get 
            {
                if(this.stock > 0 && this.importe > 0)
                {
                    return true;
                }
                return false;
            }
        }
        /// <summary>
        /// Muestra el importe de la publicacion
        /// </summary>
        public float Importe
        {
            get
            {
                return this.importe;
            }
        }
        /// <summary>
        /// get: retorna el stock - set: Guarda el stock
        /// </summary>
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value > 0)
                {
                    this.stock = value;
                }
                else 
                {
                    this.stock = 0;
                }
            }
        }
        /// <summary>
        /// Muestra la informacion de cada publicacion
        /// </summary>
        /// <returns>Retorna la informacion como string</returns>
        public string Informacion() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendFormat("Stock: {0}\n", this.Stock);
            if (EsColor)
            {
                sb.AppendLine($"Color: SI");
            }
            else 
            {
                sb.AppendLine($"Color: NO");
            }
            sb.Append($"Valor: ${this.Importe}\n");
            return sb.ToString();
        }
        /// <summary>
        /// Sobreescribe el metodo ToString para retornar el nombre
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.nombre;
        }
    }
}
