using ConcesionariaLibrary;
using ConcesionariaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConcesionariaAutosMotos
{
    class Program
    {
        static void Main(string[] args)
        {

            AutoModel auto = new AutoModel();
            auto.Marca = "Ford";
            auto.Modelo = "Fiesta";
            auto.Puertas = 4;
            auto.Precio = 30000.00M;

            MotoModel moto = new MotoModel();
            moto.Marca = "Honda";
            moto.Modelo = "Titan";
            moto.Cilindrada = "125cc";
            moto.Precio = 200000.00M;

            List<VehiculoModel> vehiculos = new List<VehiculoModel>();
            vehiculos.Add(auto);
            vehiculos.Add(moto);


            foreach (var item in vehiculos)
            {

                Console.WriteLine(item) ;
            }





            Console.ReadLine();
        }

    }

}
