using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proseca.Shared.DTOs
{
    public class VacunaTransaccionDTO
    {
        public int AnimalId { get; set; }
        public string NombreVacuna { get; set; }
        public string Razon { get; set; }

        // Relación con finca
        public int FincaId { get; set; }

        // Evento de Salud relacionado
        public string EventoNombre { get; set; }
        public string Enfermedad { get; set; }
        public DateTime FechaInicio { get; set; } = DateTime.Now;
        public DateTime FechaFin { get; set; } = DateTime.Now;
        public string Descripcion { get; set; }
    }
}
