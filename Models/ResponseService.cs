using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet02.Models
{
    public class ResponseService<T>
    {
        public T? Data { get; set; }
        public bool Seucces { get; set; }=true;
        public string Messages { get; set; }=string.Empty;
    }
}