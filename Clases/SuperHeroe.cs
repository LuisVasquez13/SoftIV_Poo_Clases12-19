using SoftIV_Poo_Clases12_19.Clases;
using SoftIV_Poo_Clases12_19.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftIV_Poo_Clases12_19.Clases
{
    // Definicion de la clase SuperHeroe
    class SuperHeroe : Heroe, ISuperHeroe
    {
        // Atributos de la clase SuperHeroe

        private string _Nombre; // Campo privado para el nombre
        public int Id { get; set; } = 1;
        public override string Nombre
        {
            get { 
                return _Nombre; 
            }
            set { 
                _Nombre = value.Trim(); 
            }
        }

        public string NombreEIdentidadSecreta // Propiedad que concatena el nombre y la identidad secreta
        {
            get { 
                return $"{Nombre} ({IdentidadSecreta})"; 
            }
        }

        public string IdentidadSecreta { get; set; } ="";
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        // Constructor de la clase SuperHeroe
        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        public string UsarSuperPoderes() // Metodo para usar los super poderes
        {
            StringBuilder sb = new StringBuilder(); // Usar StringBuilder para construir la cadena de texto
            foreach (var item in SuperPoderes) // Recorrer la lista de super poderes
            {
                sb.AppendLine($"{NombreEIdentidadSecreta} esta usando el superpoder {item.Nombre}"); // Agregar el super poder a la cadena de texto
            }

            return sb.ToString(); // Retornar la cadena de texto
        }

        public override string SalvarElMundo() // Implementacion del metodo abstracto de la clase base Heroe
        {
            return $"{NombreEIdentidadSecreta} ha salvado el mundo.";
        }

        public override string SalvarLaTierra() // Sobrescribir el metodo virtual de la clase base Heroe
        {
            return $"{NombreEIdentidadSecreta} ha salvado la Tierra.";
        }
    }
}
