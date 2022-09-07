using System.ComponentModel.DataAnnotations;

namespace WebAppDETAug2022_.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public decimal Price { get; set; }
    }

    
}

