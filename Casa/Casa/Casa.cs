using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casa.Agregacion;
using Casa.Asociacion;
using Casa.Composicion;

namespace Casa
{
    public class Casa
    {
        public string calle { get; set; }
        public Decoracion decoracion { get; set; }
        public Inquilinos inquilinos { get; set; }
        public Pared pared { get; set; }
        public Puerta puerta { get; set; }
        public Ventana ventana { get; set; }

        Pared pared1 = new Pared()
        {
            color = "Azul",
            metros = 15
        };

        Puerta puerta1 = new Puerta()
        {
            material = "Madera",
            tamaño = 2
        };

        Ventana ventana1 = new Ventana()
        {
            material = "Aluminio",
            tamaño = 3
        };

        public Casa (string calle)
        {
            this.calle = calle;
            this.pared = pared1;
            this.puerta = puerta1;
            this.ventana = ventana1;
        }

        public void ingresarinquilino(Inquilinos inquilinos)
        {
            this.inquilinos = inquilinos;
        }

        public void decorar(Decoracion decoracion)
        {
            this.decoracion = decoracion;
        }

       

    }
}
