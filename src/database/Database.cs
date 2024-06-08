using System;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Globalization;

namespace database;
public class Database {

    private SQLiteConnection connection;
    private SQLiteCommand cmd;
    private string dataPath = "Data Source=../../data.db";

    public Database() {

    }

    public void connect() {
        connection = new SQLiteConnection(dataPath);
        connection.Open();
        cmd = new SQLiteCommand(connection);
    }

    public void createBiodataTable() {
        cmd.CommandText = @"
            CREATE TABLE IF NOT EXISTS biodata (  
                `nik`  VARCHAR(16) PRIMARY KEY,
                `nama` VARCHAR(255) DEFAULT NULL,
                `tempat_lahir` VARCHAR(255) DEFAULT NULL,
                `tanggal_lahir` DATE DEFAULT NULL,
                `jenis_kelamin` VARCHAR(10) CHECK(jenis_kelamin IN ('Laki-Laki', 'Perempuan')) DEFAULT NULL,
                `golongan_darah` VARCHAR(5) DEFAULT NULL,
                `alamat` VARCHAR(255) DEFAULT NULL,
                `agama` VARCHAR(50) DEFAULT NULL,
                `status_perkawinan` VARCHAR(20) CHECK(status_perkawinan IN ('Belum Menikah', 'Menikah', 'Cerai')) DEFAULT NULL,
                `pekerjaan` VARCHAR(100) DEFAULT NULL,
                `kewarganegaraan` VARCHAR(50) DEFAULT NULL
        )";
        cmd.ExecuteNonQuery();
    }

    public void createSidikJariTable() {
        cmd.CommandText = @"
            CREATE TABLE IF NOT EXISTS sidik_jari (
                `berkas_citra` TEXT,
                `nama` VARCHAR(255) DEFAULT NULL
            )";
        cmd.ExecuteNonQuery();
    }

    public void dropBiodataTable() {
        cmd.CommandText = @"
            DROP TABLE IF EXISTS biodata
        ";
        cmd.ExecuteNonQuery();
    }

    public void dropSidikJariTable() {
        cmd.CommandText = @"
            DROP TABLE IF EXISTS sidik_jari
        ";
        cmd.ExecuteNonQuery();
    }

    public void insertIntoBiodata(
        long nik, 
        string nama, 
        string tempat_lahir, 
        DateOnly tanggal_lahir, 
        string jenis_kelamin, 
        string golongan_darah, 
        string alamat, 
        string agama, 
        string status, 
        string pekerjaan, 
        string kewarganegaraan
    ) {
        cmd.CommandText = @$"
            INSERT INTO biodata(nik, nama, tempat_lahir, tanggal_lahir, jenis_kelamin, golongan_darah, alamat, agama, status_perkawinan, pekerjaan, kewarganegaraan)
            VALUES(""{nik}"", ""{nama}"", ""{tempat_lahir}"", ""{tanggal_lahir}"", ""{jenis_kelamin}"", ""{golongan_darah}"", ""{alamat}"", ""{agama}"", ""{status}"", ""{pekerjaan}"", ""{kewarganegaraan}"")
        ";
        cmd.ExecuteNonQuery();
    }

    public void insertIntoSidikJari(string path, string nama) {
        cmd.CommandText = @$"
            INSERT INTO sidik_jari(berkas_citra, nama)
            VALUES(""{path}"", ""{nama}"")
        ";
        cmd.ExecuteNonQuery();
    }

    public List<string> selectPathFromSidikJari() {
        List<string> result = new List<string>();
        cmd.CommandText = @"SELECT berkas_citra FROM sidik_jari";
        SQLiteDataReader data = cmd.ExecuteReader();
        while (data.Read()) {
            result.Add(Convert.ToString(data["berkas_citra"]));
        }
        return result;
    } 
    public Biodata selectAllFromBiodata(string nama) {
        cmd.CommandText = @$"
            SELECT * FROM biodata
            WHERE biodata.nama='{nama}'
        ";
        SQLiteDataReader data = cmd.ExecuteReader();
        data.Read();
        int tanggal_lahir_idx = data.GetOrdinal("tanggal_lahir");
        Biodata biodata = new Biodata
        {
            nik = Convert.ToInt64(data["nik"]),
            nama = Convert.ToString(data["nama"]),
            tempat_lahir = Convert.ToString(data["tempat_lahir"]),
            tanggal_lahir = DateOnly.FromDateTime(DateTime.ParseExact(data.GetString(tanggal_lahir_idx), "dd/MM/yyyy", CultureInfo.InvariantCulture)),
            jenis_kelamin = Convert.ToString(data["jenis_kelamin"]),
            golongan_darah = Convert.ToString(data["golongan_darah"]),
            alamat = Convert.ToString(data["alamat"]),
            agama = Convert.ToString(data["agama"]),
            status = Convert.ToString(data["status_perkawinan"]),
            pekerjaan = Convert.ToString(data["pekerjaan"]),
            kewarganegaraan = Convert.ToString(data["kewarganegaraan"])
        };
        data.Close();
        return biodata;
    }

    public List<string> getAllName() {
        cmd.CommandText = @$"
            SELECT nama FROM biodata
        ";
        SQLiteDataReader data = cmd.ExecuteReader();
        List<string> listNama = new List<string>();
        while (data.Read()) {
            listNama.Add(Convert.ToString(data["nama"]));
        }
        data.Close();
        return listNama;
    }

    public string getNameFromSidikJari(string berkas_citra) {
        cmd.CommandText = @$"
            SELECT nama FROM sidik_jari
            WHERE sidik_jari.berkas_citra='{berkas_citra}'
        ";
        SQLiteDataReader data = cmd.ExecuteReader();
        data.Read();
        string result = Convert.ToString(data["nama"]);
        data.Close();
        return result;
    }

    public Biodata getBiodataFromName(string nama) {
        cmd.CommandText = @$"
            SELECT * FROM biodata
            WHERE biodata.nama='{nama}'
        ";
        SQLiteDataReader data = cmd.ExecuteReader();
        if (data.HasRows) {
            data.Close();
            Biodata biodata = selectAllFromBiodata(nama);
            return biodata;
        }
        else {
            string pattern = CustomRegex.MakePattern(nama);
            data.Close();
            List<string> listNama = getAllName();
            foreach (string name in listNama)
            {
                if (CustomRegex.PatternMatching(pattern, name))
                {
                    Biodata biodata = selectAllFromBiodata(name);
                    biodata.nama = nama;
                    return biodata;
                }
            }
            return null;
        }
    }

    public void runQuery(string query) {
        cmd.CommandText = query;
        cmd.ExecuteNonQuery();
    }
}