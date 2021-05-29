using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Heroe : Personaje
    {
        private bool esSaiyan;
        private EtransformacionSaiyan transformacion;

        public Heroe(string nombre, int nivelPoder, List<EHabilidades> ataques, bool esSaiyan)
            : base(nombre, nivelPoder, ataques)
        {
            this.esSaiyan = esSaiyan;
        }

        protected override string Descripcion
        {
            get
            {
                if (this.esSaiyan)
                {
                    return "Disfruta los combates. Su poder no tiene limite.";
                }
                else
                {
                    return "Siempre pelea junto a un Saiyan. Fiel amigo.";
                }
            }
        }

        public override string Transformarse()
        {
            string transformacionActual;
            if (this.esSaiyan)
            {
                transformacionActual = this.transformacion.ToString(); ;
                switch (this.transformacion)
                {
                    case EtransformacionSaiyan.Base:
                        this.transformacion++;
                        this.nivelPoder *= 10;
                        break;
                    case EtransformacionSaiyan.SSJ:
                        this.transformacion++;
                        this.nivelPoder *= 20;
                        break;
                    case EtransformacionSaiyan.SSJ2:
                        this.transformacion++;
                        this.nivelPoder *= 30;
                        break;
                    case EtransformacionSaiyan.SSJ3:
                        this.transformacion = EtransformacionSaiyan.Base;
                        this.nivelPoder = 100;
                        break;
                }
            }
            else
            {
                transformacionActual = "No es Saiyan";
            }
            return transformacionActual;
        }

        public override string InfoPersonaje()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.InfoPersonaje());
            if (esSaiyan)
            {
                sb.AppendLine("Es saiyan.");
            }
            else
            {
                sb.AppendLine("No es Saiyan.");
            }
            sb.AppendLine($"Transformacion actual: {this.transformacion}");
            return sb.ToString();
        }
    }
}
