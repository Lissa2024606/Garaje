using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaje.clase.cs
{
    internal class ClasesGaraje
    {
        private int numeroGaraje;
        private string descripcion;
        private int capacidadEspacios;
        private int espaciosOcupados;
        public ClasesGaraje(int numeroGaraje, string descripcion, int capacidadEspacios, int espaciosOcupados)
        {
            this.numeroGaraje = numeroGaraje;
            this.descripcion = descripcion;
            this.capacidadEspacios = capacidadEspacios;
            this.espaciosOcupados = espaciosOcupados;
        }
        // Método para retornar el número de espacios disponibles
        public int obtenerEspaciosDisponibles()
        {
            return capacidadEspacios - espaciosOcupados;
        }   


    }
    
    