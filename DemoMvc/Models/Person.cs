using System.ComponentModel.DataAnnotations;

namespace DemoMvc.Models
{
    public class Person
    {
       [Key]
        public string CCCD { get; set; }  
        public string HoTen { get; set; }   
        public string QueQuan { get; set; }   
    }
}
// dotnet aspnet-codegenerator controller -name Employeetroller -m Employee -dc DemoMvc.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite
