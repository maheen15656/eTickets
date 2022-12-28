using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int ID { get; set; }

        [Display(Name="Cinema Logo")]
        public string logo { get; set; }

        [Display(Name = "Cinema Name")]
        public string Name { get; set; }
        [Display(Name = "Cinema Description")]
        public string description { get; set; }

        //
    }
}
