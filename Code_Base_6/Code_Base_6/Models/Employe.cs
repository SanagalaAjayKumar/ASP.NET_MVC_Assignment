using System.ComponentModel.DataAnnotations;

namespace Code_Base_6.Models
{
    public class Employe
    {
        [Key]
        public int Employe_Id { get; set; }
        [Required]
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Location { get; set; }
        public string Adress { get; set; }
    }
}
