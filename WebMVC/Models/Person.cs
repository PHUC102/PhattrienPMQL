using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class Person
    {
       [Key]
        public string CCCD { get; set; }  
        public string HoTen { get; set; }   
        public string QueQuan { get; set; }   
    }
}
// dotnet aspnet-codegenerator controller -name EmployeeController -m Employee -dc DemoMvc.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite
