using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetdocker.Models
{
    [Table("mytable")]
    public class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}