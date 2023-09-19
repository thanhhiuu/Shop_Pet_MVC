using System.ComponentModel.DataAnnotations;

namespace Shop_Pet.Models
{
    public class Categorycs
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên !")]
        public String NamePet  { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên !")] 
        public int HienThi { get; set; }
    }
}
