using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConcesionariaLibrary.Models
{
    public class VehiculoModel
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }

        protected string PrecioFromateado
        {
            get 
            {
                var culture = CultureInfo.GetCultureInfo("de-DE");
                return string.Format(culture, "{0:n}", Precio);
            }
        }

    }
}
