using System.CodeDom;
using System.Data.SQLite;

namespace database;
class Program {
    static void Main() {
        Database data = new Database();
        data.connect();
        data.dropBiodataTable();
        data.dropSidikJariTable();
        data.createBiodataTable();
        data.createSidikJariTable();
        Console.WriteLine("azz");
    }
}
