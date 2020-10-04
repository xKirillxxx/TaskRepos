using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemosTask.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        [Required]
        public string Name { get; set; }
        [Column(TypeName ="int")]
        public int Rating { get; set; }
        [Column(TypeName ="int")]
        public int Price { get; set; }
        [Column(TypeName ="int")]
        public int Time { get; set; }
    }
}
