using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class DragonBall
    {
        private static List<Personaje> listaPersonajes;

        static DragonBall()
        {
            DragonBall.listaPersonajes = new List<Personaje>();
        }

        public static List<Personaje> ListaPersonajes
        {
            get 
            {
                return DragonBall.listaPersonajes;
            }
        }

        public static bool AgregarPersonajes(Personaje p1) 
        {
            if (p1 != DragonBall.listaPersonajes) 
            {
                DragonBall.listaPersonajes.Add(p1);
                return true;
            }
            return false;
        }

        private static void CargarDatosDefault() 
        {
           
        }

        public static string GetPersonajenInfo(int index) 
        {
            return DragonBall.listaPersonajes[index].InfoPersonaje();
        }
    }
}
