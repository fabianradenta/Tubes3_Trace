# Trace

> Source Code ini dibuat untuk memenuhi Tugas Besar 3 Mata kuliah Strategi Algoritma IF2211 yaitu "Pemanfaatan Pattern Matching dalam Membangun Sistem Deteksi Individu Berbasis Biometrik Melalui Citra Sidik Jari".

## Daftar Isi

- [Algoritma Knuth Morris Pratt ](#algoritma-knuth-morris--ratt)
- [Algoritma Boyer Moore](#algoritma-boyer-moore)
- [Regular Expression](#regular-expression)
- [Requirements](#requirements)
- [Petunjuk Penggunaan](#petunjuk-penggunaan)
- [Authors](#authors)

## Algoritma Knuth-Morris-Pratt 
Algoritma Knuth-Morris-Pratt (KMP) adalah algoritma yang bertujuan melakukan pencocokan antara string pattern dengan string text. Dalam penerapannya pada program ini, <i>authors</i> menggunakan algoritma KMP untuk mencari apakah string pattern yang merupakan potongan dari citra sidik jari yang dicari ada pada string teks yang merupakan citra sidik jari yang ada pada <i>database</i>.

## Algoritma Boyer-Moore
Algoritma Boyer-Moore (BM) adalah algoritma yang bertujuan melakukan pencocokan antara string pattern dengan string text. Penerapan algoritma BM pada program ini sama seperti KMP, <i>authors</i> menggunakan algoritma BM untuk mencari apakah string pattern yang merupakan potongan dari citra sidik jari yang dicari ada pada string teks yang merupakan citra sidik jari yang ada pada <i>database</i>.


## Regular Expression
Regular Expression (Regex) merupakan sebuah string yang mendefinisikan sebuah pola pencarian sehingga dapat membantu penggunanya untuk melakukan matching (pencocokan), locate (pencarian), dan manipulasi teks. Pada program ini, regex diterapkan untuk mengatasi data yang korup. Pada <i>database</i> ini,  data korup berupa bahasa alay Indonesia. Manipulasi teks pada kasus ini dapat berupa huruf besar-kecil, penggunaan angka, penyingkatan, atau kombinasinya.

## Requirements

- C#
- .NET
- mySQL

## Petunjuk Penggunaan

1. <i>Clone</i> repository dengan <i>command</i>

   ```bash
   git clone https://github.com/fabianradenta/Tubes3_Trace.git
   ```

2. Pada terminal, masuk ke directory Tubes3_Trace yang sudah di-<i>clone</i>


   ```bash
   cd path/to/Tubes3_Trace
   ```

   Pastikan "path to" diubah menjadi <i>path</i> yang benar

3. Jalankan mySQL dan buat database baru dengan nama tubes_stima3

4. Setelah database berhasil dibuat, masuk ke folder database dan jalankan perintah berikut
   ```bash
   cd src/database
   dotnet run
   ```

5. Selanjutnya edit file .env pada root folder dengan mengubah DB_PASSWORD menjadi password mySQL yang Anda miliki
   
5. Pada terminal, masuk ke folder GUI

   ```bash
   cd src/gui
   ```

6. Jalankan program dengan <i>command</i>
    ```bash
    dotnet run
    ```

7. Aplikasi Desktop akan terbuka pada komputer dan siap menerima masukan citra sidik jari untuk dicocokkan dengan sidik jari pada <i>database</i>.

8. Setelah memasukkan citra sidik jari yang ingin dicocokkan, silakan pilih metode pencarian (KMP atau BM).

9. Klik tombol "search" untuk memulai pencarian.

10. Program akan melakukan pencarian dan menampilkan hasilnya di layar komputer.

## Authors

<!-- nama dan nim -->

| Name                             | ID       |
| -------------------------------- | -------- |
| Karunia Syukur Baeha             | 10023478 |
| Muhamad Rafli Rasyiidin          | 13522088 |
| Abdullah Mubarak                 | 13522101 |
| Fabian Radenta Bangun            | 13522105 |

