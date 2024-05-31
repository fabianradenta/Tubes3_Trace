using System.CodeDom;
using System.Data.SQLite;
using faker;

namespace database;
class Program {
    static void Main() {
        Database data = new Database();
        data.connect();
        data.dropBiodataTable();
        data.dropSidikJariTable();
        data.createBiodataTable();
        data.createSidikJariTable();
        string relativePath = @"..\..\test";
        List<string> pictureList =  new List<string>(Directory.GetFiles(relativePath));
        for (int i = 0; i < 10; i++)
        {
           Biodata temp = FakerBiodata.generateBiodata();
           
           try {
               data.insertIntoBiodata(temp.nik, temp.nama, temp.tempat_lahir, temp.tanggal_lahir, temp.jenis_kelamin, temp.golongan_darah, temp.alamat, temp.agama, temp.status, temp.pekerjaan, temp.kewarganegaraan);
           } catch (Exception e) {
               Console.WriteLine("Biodata error");
               Console.WriteLine(e.Message);
               Console.WriteLine($"Nama: {temp.nama}");
               Console.WriteLine($"NIK : {temp.nik}");
               Console.WriteLine($"Tempat lahir: {temp.tempat_lahir}");
               Console.WriteLine($"Tanggal lahir: {temp.tanggal_lahir}");
               Console.WriteLine($"Jenis kelamin: {temp.jenis_kelamin}");
               Console.WriteLine($"goldar: {temp.golongan_darah}");
               Console.WriteLine($"alamat: {temp.alamat}");
               Console.WriteLine($"agama: {temp.agama}");
               Console.WriteLine($"status: {temp.status}");
               Console.WriteLine($"pekerjaan: {temp.pekerjaan}");
               Console.WriteLine($"kewarganegaraan: {temp.kewarganegaraan}");
               Console.WriteLine();
           }
           try {
               for (int j = 0; j < 10; j++)
               {
                   data.insertIntoSidikJari(pictureList.ElementAt(0), temp.nama);
                   pictureList.RemoveAt(0);
               }
           } catch (Exception e) {
               Console.WriteLine("Sidik jari error");
               Console.WriteLine(e.Message);
               Console.WriteLine($"Nama: {temp.nama}");
               Console.WriteLine($"NIK : {temp.nik}");
               Console.WriteLine($"Tempat lahir: {temp.tempat_lahir}");
               Console.WriteLine($"Tanggal lahir: {temp.tanggal_lahir}");
               Console.WriteLine($"Jenis kelamin: {temp.jenis_kelamin}");
               Console.WriteLine($"goldar: {temp.golongan_darah}");
               Console.WriteLine($"alamat: {temp.alamat}");
               Console.WriteLine($"agama: {temp.agama}");
               Console.WriteLine($"status: {temp.status}");
               Console.WriteLine($"pekerjaan: {temp.pekerjaan}");
               Console.WriteLine($"kewarganegaraan: {temp.kewarganegaraan}");
               Console.WriteLine();
           }
        }
        Console.WriteLine("Database created!");
    }
}
