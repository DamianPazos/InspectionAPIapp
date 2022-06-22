using System.ComponentModel.DataAnnotations;

namespace InspectionAPI
{
    public class Inspection
    {
        
        // Propiedades
        public int Id { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = String.Empty;

        [StringLength(200)]
        public string Comments { get; set; } = String.Empty;

        public int InspectionTypeId { get; set; }

        public InspectionType? InspectionType { get; set; } // El signo de pregunta significa que se trata de un atributo anulable


    }
}
