using System.Numerics;
using System.Text.RegularExpressions;

namespace GarajeMVC.Models
{
    public class Auto
    {
        public int  NumeroAuto;
        public string Marca;
        public string Placa;

        public Auto(int numeroAuto, string marca, string placa)
        {
            NumeroAuto = numeroAuto;
            Marca = marca;
            Placa = placa;
        }

    }
}
