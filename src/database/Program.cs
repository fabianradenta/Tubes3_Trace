﻿using System.CodeDom;
using System.Data.SQLite;
using faker;

namespace database;
class Program {
    static void Main() {
        Database data = new Database();
        data.connect();
        data.importSQL("C:\\Users\\abdul\\OneDrive\\Documents\\Coding\\STIMA\\Tubes3\\Tubes3_Trace\\Test Case\\tubes3_stima24.sql");
        //data.runQuery("UPDATE biodata SET nama='NIckolAS ruTherfOrd' WHERE nama='Nickolas Rutherford'");
        //data.runQuery("UPDATE biodata SET nama='V1nc3n24 Bor3r' WHERE nama='Vincenza Borer'");
        //data.runQuery("UPDATE biodata SET nama='Alx Fdel' WHERE nama='Alex Fadel'");
        //data.runQuery("UPDATE biodata SET nama='frncsc0 5chn3DeR' WHERE nama='Francisco Schneider'");
        //data.dropBiodataTable();
        //data.dropSidikJariTable();
        //data.createBiodataTable();
        //data.createSidikJariTable();
        // data.importSQL("../../tubes3_stima24.sql");
        // string relativePath = @"..\..\test";
        //data.insertIntoBiodata(3277030303030303, "Jack Hanma", "Surabaya", new DateOnly(), "Laki-Laki", "A", "Jl. Bandung", "Kristen", "Menikah", "PNS", "Japanese");
        //data.insertIntoSidikJari(@"..\..\test\7__M_Left_index_finger.BMP", "Jack Hanma");
        //data.insertIntoSidikJari(@"..\..\test\7__M_Left_little_finger.BMP", "Jack Hanma");
        //data.insertIntoSidikJari(@"..\..\test\7__M_Left_middle_finger.BMP", "Jack Hanma");
        //data.insertIntoSidikJari(@"..\..\test\7__M_Left_ring_finger.BMP", "Jack Hanma");
        //data.insertIntoSidikJari(@"..\..\test\7__M_Left_thumb_finger.BMP", "Jack Hanma");
        //data.insertIntoSidikJari(@"..\..\test\7__M_Right_index_finger.BMP", "Jack Hanma");
        //data.insertIntoSidikJari(@"..\..\test\7__M_Right_little_finger.BMP", "Jack Hanma");
        //data.insertIntoSidikJari(@"..\..\test\7__M_Right_middle_finger.BMP", "Jack Hanma");
        //data.insertIntoSidikJari(@"..\..\test\7__M_Right_ring_finger.BMP", "Jack Hanma");
        //data.insertIntoSidikJari(@"..\..\test\7__M_Right_thumb_finger.BMP", "Jack Hanma");
        //List<string> pictureList =  new List<string>(Directory.GetFiles(relativePath));
        //for (int i = 0; i < pictureList.Count; i++)
        //{
        //   Biodata temp = FakerBiodata.generateBiodata();
        //   try {
        //       data.insertIntoBiodata(temp.nik, temp.nama, temp.tempat_lahir, temp.tanggal_lahir, temp.jenis_kelamin, temp.golongan_darah, temp.alamat, temp.agama, temp.status, temp.pekerjaan, temp.kewarganegaraan);
        //   } catch (Exception e) {
        //        Console.WriteLine(e.Message);
        //       //Console.WriteLine("Biodata error");
        //       //Console.WriteLine(e.Message);
        //       //Console.WriteLine($"Nama: {temp.nama}");
        //       //Console.WriteLine($"NIK : {temp.nik}");
        //       //Console.WriteLine($"Tempat lahir: {temp.tempat_lahir}");
        //       //Console.WriteLine($"Tanggal lahir: {temp.tanggal_lahir}");
        //       //Console.WriteLine($"Jenis kelamin: {temp.jenis_kelamin}");
        //       //Console.WriteLine($"goldar: {temp.golongan_darah}");
        //       //Console.WriteLine($"alamat: {temp.alamat}");
        //       //Console.WriteLine($"agama: {temp.agama}");
        //       //Console.WriteLine($"status: {temp.status}");
        //       //Console.WriteLine($"pekerjaan: {temp.pekerjaan}");
        //       //Console.WriteLine($"kewarganegaraan: {temp.kewarganegaraan}");
        //       //Console.WriteLine();
        //   }
        //   try {
        //       for (int j = 0; j < 10; j++)
        //       {
        //           data.insertIntoSidikJari(pictureList.ElementAt(0), temp.nama);
        //           pictureList.RemoveAt(0);
        //       }
        //   } catch (Exception e) {
        //        Console.WriteLine(e.Message);
        //       //Console.WriteLine("Sidik jari error");
        //       //Console.WriteLine(e.Message);
        //       //Console.WriteLine($"Nama: {temp.nama}");
        //       //Console.WriteLine($"NIK : {temp.nik}");
        //       //Console.WriteLine($"Tempat lahir: {temp.tempat_lahir}");
        //       //Console.WriteLine($"Tanggal lahir: {temp.tanggal_lahir}");
        //       //Console.WriteLine($"Jenis kelamin: {temp.jenis_kelamin}");
        //       //Console.WriteLine($"goldar: {temp.golongan_darah}");
        //       //Console.WriteLine($"alamat: {temp.alamat}");
        //       //Console.WriteLine($"agama: {temp.agama}");
        //       //Console.WriteLine($"status: {temp.status}");
        //       //Console.WriteLine($"pekerjaan: {temp.pekerjaan}");
        //       //Console.WriteLine($"kewarganegaraan: {temp.kewarganegaraan}");
        //       //Console.WriteLine();
        //   }//
        //}
        ////data.convertSQLtoSQLite("../../tubes3_stima24.sql");
        //Console.WriteLine("Database created!");
    }
}