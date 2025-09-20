using System.Collections.Generic;

namespace GarajeMVC.Models
{
    public class Garage
    {
        public int NumerodeGaraje;
        public string Descripcion;
        public int CapacidadEspacios;
        public int EspaciosOcupados;
        public List<Auto> Autos;

        public Garage(int numerodeGaraje, string descripcion, int capacidadEspacios, int espaciosOcupados)
        {
            NumerodeGaraje = numerodeGaraje;
            Descripcion = descripcion;
            CapacidadEspacios = capacidadEspacios;
            EspaciosOcupados = espaciosOcupados;
            Autos = new List<Auto>();
        }

        public void IngresarAuto(Auto auto)
        {
            this.Autos.Add(auto);
            EspaciosOcupados++;
        }

        public List<Auto> getAutos()
        {
            return this.Autos;
        }
    }
}
