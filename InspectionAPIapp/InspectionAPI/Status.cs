using System.ComponentModel.DataAnnotations;

namespace InspectionAPI
{
    public class Status
    {
        // Propiedades
        public int Id { get; set; }

        [StringLength(20)]
        public string StatusOption { get; set; } = String.Empty;
    }
}
