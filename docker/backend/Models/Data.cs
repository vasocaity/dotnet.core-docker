using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("mytable")]
    public class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}