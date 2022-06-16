using System.ComponentModel.DataAnnotations;

namespace deer_stalker.Models
{
    public class Hunt
    {
        public string? Location { get; set; }
        public string? Species { get; set; }
        public int ConfirmedShot { get; set; }
        public bool NZDAMember { get; set; } = false;
        // I'll want one of these soon enough
        // [DataType(DataType.Date)]
        // public DateTime ReleaseDate { get; set; }
    }
}