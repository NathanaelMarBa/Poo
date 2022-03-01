using System;
using System.Collections.Generic;
using System.Linq;
using Casa.Agregacion;
using Casa.Asociacion;
using Casa.Composicion;

namespace Casa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            Casa casa1 = new Casa("Urdilde");

            Inquilinos inquilino = new Inquilinos()
            {
                Nombre = "Tomas",
                apellidos = "Martinez",
                edad = 39,
                tes = "Moreno",
                cabello = "Largo",
                colorojos = "Cafe obscuro"
            };

            Decoracion navidad = new Decoracion()
            {
                temporada = "Navidad",
                tipo = "Luces"
            };

            casa1.ingresarinquilino(inquilino);
            casa1.decorar(navidad);
            
        }
    }
}