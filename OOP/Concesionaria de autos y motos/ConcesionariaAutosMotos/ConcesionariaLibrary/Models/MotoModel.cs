using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConcesionariaLibrary.Models
{
    public class MotoModel : VehiculoModel
    {
        public string Cilindrada { get; set; }

        public override string ToString()
        {
            return string.Format($"Marca: {Marca} // Modelo: {Modelo} // Cilindrada: {Cilindrada} // Precio: ${PrecioFromateado}");
        }
    }
}
