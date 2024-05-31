using System;
using System.Data.SQLite;

namespace database;
public class Database {

    private SQLiteConnection connection;
    private SQLiteCommand cmd;
    private string dataPath = "Data Source=data.db";

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
}