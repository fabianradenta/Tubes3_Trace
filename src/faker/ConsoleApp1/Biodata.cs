public class Biodata {
    public long nik {get; set;}
    public string nama {get; set;}
    public string tempat_lahir {get; set;}
    public DateOnly tanggal_lahir {get; set;}
    public string jenis_kelamin {get; set;}
    public string golongan_darah {set; get;}
    public string alamat {set; get;}
    public string agama {get; set;}
    public string status {get; set;}
    public string pekerjaan {get; set;}
    public string kewarganegaraan {get; set;}

    public void print() {
        Console.WriteLine($"Nama: {this.nama}");
        Console.WriteLine($"NIK : {this.nik}");
        Console.WriteLine($"Tempat lahir: {this.tempat_lahir}");
        Console.WriteLine($"Tanggal lahir: {this.tanggal_lahir}");
        Console.WriteLine($"Jenis kelamin: {this.jenis_kelamin}");
        Console.WriteLine($"goldar: {this.golongan_darah}");
        Console.WriteLine($"alamat: {this.alamat}");
        Console.WriteLine($"agama: {this.agama}");
        Console.WriteLine($"status: {this.status}");
        Console.WriteLine($"pekerjaan: {this.pekerjaan}");
        Console.WriteLine($"kewarganegaraan: {this.kewarganegaraan}");
        Console.WriteLine(); 
    } 
}