using System;
using System.Data.SQLite;

class Program
{
    static void Main()
    {
        using (SQLiteConnection con = new SQLiteConnection("Data Source=fingerprint.db;Version=3;"))
        {
            con.Open();

            // Membuat tabel biodata
            string sqlBiodata = @"
                CREATE TABLE IF NOT EXISTS biodata (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    nama VARCHAR(100) DEFAULT NULL,
                    tempat_lahir VARCHAR(50) NOT NULL,
                    tanggal_lahir DATE DEFAULT NULL,
                    jenis_kelamin TEXT DEFAULT NULL,
                    golongan_darah VARCHAR(5) DEFAULT NULL,
                    alamat VARCHAR(255) DEFAULT NULL,
                    agama VARCHAR(50) DEFAULT NULL,
                    status_perkawinan TEXT DEFAULT NULL,
                    pekerjaan VARCHAR(100) DEFAULT NULL,
                    kewarganegaraan VARCHAR(50) DEFAULT NULL
                )";
            using (SQLiteCommand cmd = new SQLiteCommand(sqlBiodata, con))
            {
                cmd.ExecuteNonQuery();
            }

            // Membuat tabel sidik_jari
            string sqlSidikJari = @"
                CREATE TABLE IF NOT EXISTS sidik_jari (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    berkas_citra TEXT,
                    id_biodata INTEGER,
                    FOREIGN KEY (id_biodata) REFERENCES biodata(id)
                )";
            using (SQLiteCommand cmd = new SQLiteCommand(sqlSidikJari, con))
            {
                cmd.ExecuteNonQuery();
            }

            con.Close();
        }

        Console.WriteLine("Tables created successfully.");
    }
}
