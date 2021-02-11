using System;
using System.Collections.Generic;
using System.Text;

namespace ConcesionariaLibrary.Models
{
    public class AutoModel : VehiculoModel
    {
        public int Puertas { get; set; }

        public override string ToString()
        {
            return string.Format($"Marca: {Marca} // Modelo: {Modelo} // Puertas: {Puertas} // Precio: ${PrecioFromateado}");
        }

    }
}
