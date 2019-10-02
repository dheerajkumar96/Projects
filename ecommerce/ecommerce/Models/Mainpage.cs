using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.Models
{
    public class Mainpage
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string producttype { get; set; }

    }

    [Table("vegetables")]
    public class vegetables
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string vegetablename { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public int priceperkg { get; set; }
    }

    [Table("mobiles")]
    public class mobiles
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string mobilename { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public int price { get; set; }
    }




}
