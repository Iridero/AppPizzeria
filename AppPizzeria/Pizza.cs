using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPizzeria
{
    class Pizza
    {

        private string tamaño;
        /// <summary>
        /// Obtiene o establece el tamaño de la pizza.
        /// El tamaño puede ser Individual, Mediana o
        /// Familiar
        /// </summary>
        public string Tamaño
        {
            set // Establecer
            {
                tamaño = value;
            }
            get // Obtener
            {
                return tamaño;
            }
        }
        private string[] ingredientes = new string[7];
        /// <summary>
        /// Obtiene la lista de ingredientes adicionales.
        /// </summary>
        public string[] Ingredientes
        {
            get
            {
                return ingredientes;
            }
        }
        int numIngredientes = 0;
        public void AgregarIngrediente(string ingrediente)
        {
            ingredientes[numIngredientes] = ingrediente;
            numIngredientes++;
        }
        private bool tieneQuesoExtra;
        
        /// <summary>
        /// Obtiene o establece si la pizza tiene
        /// queso extra.
        /// </summary>
        public bool TieneQuesoExtra
        {
            set
            {
                tieneQuesoExtra = value;
            }
            get
            {
                return tieneQuesoExtra;
            }
        }
        private bool esMasaDelgada;
        /// <summary>
        /// Obtiene o establece si la pizza es de
        /// masa delgada
        /// </summary>
        public bool EsMasaDelgada
        {
            set
            {
                esMasaDelgada = value;
            }
            get
            {
                return esMasaDelgada;
            }
        }
        private decimal costo;
        /// <summary>
        /// Obtiene el costo de la pizza
        /// </summary>
        public decimal Costo
        {
            get
            {
                switch (tamaño.ToUpper())
                {
                    case "INDIVIDUAL":
                        costo = 49;
                        break;
                    case "MEDIANA":
                        costo = 79;
                        break;
                    default:
                        costo = 149;
                        break;
                }
                costo += (numIngredientes > 1) ? (numIngredientes - 1) * 20 : 0;
                costo += (tieneQuesoExtra) ? 15 : 0;
                costo += (esMasaDelgada) ? 40 : 0;
                return costo;
            }
        }

    }
}
