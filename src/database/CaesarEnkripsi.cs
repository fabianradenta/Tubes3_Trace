using System;

namespace Enkripsi;
public class Enkripsi {
    private int shift = 112;

    public void encryptDecryptBiodata(Biodata biodata, bool isEncrypt) {
        // biodata.nik = encryptDecrypt(biodata.nik);
        biodata.nama = encryptDecrypt(biodata.nama, isEncrypt);
        biodata.tempat_lahir = encryptDecrypt(biodata.tempat_lahir, isEncrypt);
        biodata.alamat = encryptDecrypt(biodata.alamat, isEncrypt);
        biodata.agama = encryptDecrypt(biodata.agama, isEncrypt);
        biodata.pekerjaan = encryptDecrypt(biodata.pekerjaan, isEncrypt);
        biodata.kewarganegaraan = encryptDecrypt(biodata.kewarganegaraan, isEncrypt);
    }

    public string encryptDecrypt(string data, bool isEncrypt){
        char[] buffer = data.ToCharArray();

        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];
            if (isEncrypt) {
                letter = (char)(letter + shift);
            } else {
                letter = (char)(letter - shift);
            }

            if (letter > 126)
            {
                letter = (char)(letter - 95);
            }
            else if (letter < 32)
            {
                letter = (char)(letter + 95);
            }

            buffer[i] = letter;
        }

        return new string(buffer);
    }
}