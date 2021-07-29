using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndDragon
{
    class Personaje
    {
        public float Fuerza, Agilidad, Aguante, FuerzaDelArma, PesoDelArma, Escudo, Vida;

        public float AtackBase()
        {
            float DanioAtaque = ((Fuerza + Agilidad) - (PesoDelArma % Aguante));
            if (Fuerza<PesoDelArma)
            {
                Console.WriteLine("Penalidad por exceso de peso.");
                FuerzaDelArma = FuerzaDelArma * 0.98f;
            }
            if (PesoDelArma % FuerzaDelArma == 0)
            {
                Console.WriteLine("Obtuviste Bonificacion por arma equilibrada");
                DanioAtaque = DanioAtaque * 1.03f;
            }
            return DanioAtaque;
        }

        public float Defence(bool EstatusEscudo)
        {
            float defensa=0;
            if (EstatusEscudo==true)
            {
                defensa = (Aguante * Agilidad);
            }
            else
            {
                defensa = ((Aguante * Agilidad) + (Escudo + (Escudo * 1.50f)));
            }
            return defensa;
        }



    }
}
