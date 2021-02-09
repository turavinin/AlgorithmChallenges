using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConcesionariaLibrary.Models
{
    public class VehiculoModel
    {
        public decimal _precio;

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Precio
        {
            get 
            {
                var culture = CultureInfo.GetCultureInfo("de-DE");
                return string.Format(culture, "{0:n}", _precio); 
            }
        }

    }
}
