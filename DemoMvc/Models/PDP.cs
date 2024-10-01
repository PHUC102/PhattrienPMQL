using System.ComponentModel.DataAnnotations;
namespace DemoMvc.Models;
public class PDP
{
    [Key]
    public string? FullName { get; set;}
    public int Age { get; set;}
    public float Hight { get; set;}

}
