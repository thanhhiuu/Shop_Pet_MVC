using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shop_Pet.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string ChuThich { get; set; }
        [Required]
        public double Gia { get; set; }
        public int CategoryId { get; set; }

        // Khai báo mối kết hợp 1-n
        [ForeignKey("CategoryId")]
        public virtual Categorycs Category { get; set; }
        public string ImageUrl { get; set; }

    }
}
