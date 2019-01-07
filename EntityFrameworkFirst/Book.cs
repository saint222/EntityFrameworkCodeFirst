using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFirst
{
    // 1. Создается класс с пропертями будущего объект
    // 2. С Manage NuGet Packages качаем EntityFramework
    public class Book 
    {
        public int BookID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
