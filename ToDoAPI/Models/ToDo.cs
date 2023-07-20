using System.ComponentModel.DataAnnotations;

namespace ToDoAPI.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}