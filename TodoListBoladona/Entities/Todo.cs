using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListBoladona.Entities
{
    [Table("Todo")]
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public bool IsCompleted { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
