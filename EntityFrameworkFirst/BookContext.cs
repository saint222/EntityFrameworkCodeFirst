using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFirst
{
    // 3. Создаем контекстный класс BookContext : DbContext (из пространства имен System.Data.Entity)
    public class BookContext : DbContext
    {
        public BookContext() // конструктор
            : base("DbConnection") // 4. - это имя будущей строки подключения к базе данных.
        { }
        public DbSet<Book> Books { get; set; } // - это свойство будет осуществляться связь с таблицей объектов books
    }
    // находим файл App.config и закидываем после тега </configSections> вот эту кодяру
//    <connectionStrings>
//   <add name = "DBConnection" connectionString="data source=(localdb)\MSSQLLocalDB;Initial Catalog=userstore;Integrated Security=True;"
//providerName="System.Data.SqlClient"/>
// </connectionStrings>
}
