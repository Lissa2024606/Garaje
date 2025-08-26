using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaje.clase.cs
{
    internal class ClasesGaraje
    {
        // Atributos
        private int numeroGaraje { get; set; }
        private string descripcion { get; set; }
        private int capacidadEspacios { get; set; }
        private int espaciosOcupados { get; set; }
        public ClasesGaraje(int numeroGaraje, string descripcion, int capacidadEspacios, int espaciosOcupados)
        {
            this.numeroGaraje = numeroGaraje;
            this.descripcion = descripcion;
            this.capacidadEspacios = capacidadEspacios;
            this.espaciosOcupados = espaciosOcupados;
        }
         
        public int obtenerEspaciosDisponibles()
        {
            return capacidadEspacios - espaciosOcupados;
        }
        
        public void ocuparEspacio(int espacioSolicitado )
        {
            espaciosOcupados = espaciosOcupados + espacioSolicitado;
        }
    }
}


