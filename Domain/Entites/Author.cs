using System.ComponentModel.DataAnnotations;
namespace Domain.Entites;
public class Author
{
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string? Fullname { get; set; }
}
