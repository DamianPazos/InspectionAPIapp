using System.ComponentModel.DataAnnotations;

namespace InspectionAPI
{
    public class InspectionType
    {
        // Propiedades
        public int Id { get; set; }

        [StringLength(20)] // Especifica la longitud mínima y máxima de los caracteres permitidos en un campo de datos.
        public string InspectionName { get; set; } = String.Empty; // Inicializa una variable de cadena en una cadena vacía (String.Empty).

    }
}
