using System;
using System.Text;

namespace BonusCrypto
{
    public class FeistelCipher
    {
        private const int NumRounds = 16;
        private readonly byte[] key;

        public FeistelCipher(byte[] key)
        {
            this.key = key;
        }

        public string Encrypt(string plaintext)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(plaintext);
            if (bytes.Length % 2 != 0)
            {
                Array.Resize(ref bytes, bytes.Length + 1); // Pad if odd length
            }

            byte[] encryptedBytes = Process(bytes, true);
            return Convert.ToBase64String(encryptedBytes);
        }

        public string Decrypt(string ciphertext)
        {
            byte[] bytes = Convert.FromBase64String(ciphertext);
            byte[] decryptedBytes = Process(bytes, false);
            return Encoding.UTF8.GetString(decryptedBytes).TrimEnd('\0'); // Remove padding
        }

        private byte[] Process(byte[] data, bool isEncrypt)
        {
            int halfLength = data.Length / 2;
            byte[] left = new byte[halfLength];
            byte[] right = new byte[halfLength];
            Array.Copy(data, 0, left, 0, halfLength);
            Array.Copy(data, halfLength, right, 0, halfLength);

            for (int i = 0; i < NumRounds; i++)
            {
                byte[] temp = right;
                right = Xor(left, F(right, isEncrypt ? i : NumRounds - 1 - i));
                left = temp;
            }

            byte[] result = new byte[data.Length];
            Array.Copy(right, 0, result, 0, halfLength);
            Array.Copy(left, 0, result, halfLength, halfLength);

            return result;
        }

        private byte[] F(byte[] data, int round)
        {
            byte[] result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                result[i] = (byte)(data[i] ^ key[round % key.Length]);
            }
            return result;
        }

        private byte[] Xor(byte[] a, byte[] b)
        {
            byte[] result = new byte[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = (byte)(a[i] ^ b[i]);
            }
            return result;
        }
    }
}