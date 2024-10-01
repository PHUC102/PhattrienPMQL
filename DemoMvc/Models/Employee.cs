using System.ComponentModel.DataAnnotations;
namespace DemoMvc.Models
{
    public class Employee : Person
    {
        public int Tuoi { get; set; } 
        public string GioiTinh { get; set; }  
        
    }
}