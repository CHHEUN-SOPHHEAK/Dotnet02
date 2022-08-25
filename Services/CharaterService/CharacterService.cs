using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet02.Models;

namespace Dotnet02.Services.CharaterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Book> Books =new List<Book>{
            new Book(),
            new Book{id =1, Name="The Morning"},
            new Book{id =2, Name="The new World"}
        };
    }
}