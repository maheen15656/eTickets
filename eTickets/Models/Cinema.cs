using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int ID { get; set; }

        public string logo { get; set; }

        public string Name { get; set; }
        public string description { get; set; }
    }
}
