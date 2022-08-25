using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dotnet02.Models
{
  
    public class Book
    {
        public int id { get; set; }
        public string Name { get; set; }="Book Name";
        public string Author { get; set; }="AuthorName";
        public string YearCreate { get; set; }="YearCreate";
        public string publicYear { get; set; }="PublicYear";
        public int Remak { get; set; }=0;
    }
}