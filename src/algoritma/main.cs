using System;
using System.Diagnostics;
using System.Text;
using ImageProcess;
using System.Drawing;
using System.Drawing.Imaging;
using database;

public class MainProgram{
    public static List<string> Search_FingerPrint(List<string> ImageAscii, bool isKMP){
        string ImageAsciiPartial = GetStringToMatch(ImageAscii);
        Database db = new Database();
        db.connect();
        List<string> allFiles = db.selectPathFromSidikJari();
        Console.WriteLine(allFiles[0]);
        
        int length = ImageAscii.Count;
        int width = ImageAscii.ElementAt(0).Length;
        int best_value_fp = 0;
        string result = "";
        bool found = false;
        foreach (string file in allFiles){
            List<string> ImageAscii2 = ImageToString.IntToString(ImageToString.ConvertToBinaryImage(file));
            int Hamming_Result = 0;
            for (int idx = 0; idx < (length < ImageAscii2.Count ? length : ImageAscii2.Count); idx++) {
                if (isKMP){
                    if ((KMP.KMPCompare(ImageAscii2.ElementAt(idx), ImageAsciiPartial) != -1)) {
                        result = file;
                        found = true;
                        break;
                    } else {
                        Hamming_Result += Hamming.hammingDist(ImageAscii2.ElementAt(idx), ImageAscii.ElementAt(idx));
                    }
                }
                else {
                    if ((BoyerMoore.BmMatch(ImageAscii2.ElementAt(idx), ImageAsciiPartial) != -1)) {
                        result = file;
                        found = true;
                        break;
                    } else {
                        Hamming_Result += Hamming.hammingDist(ImageAscii2.ElementAt(idx), ImageAscii.ElementAt(idx));
                    }
                }
            }
            Hamming_Result = (length * width - Hamming_Result) * 100 / (length * width);
            if (Hamming_Result > best_value_fp)
            {
                best_value_fp = Hamming_Result;
                result = file;
            }
            if (found) {
                break;
            }
        }
        List<string> res = new List<string>();
        res.Add(result);
        if (found){
            res.Add("0");
            res.Add("100");
        } else {
            if (best_value_fp < 50) {
                res.Add("-1");
                res.Add(Convert.ToString(best_value_fp));
            } else {
                res.Add("1");
                res.Add(Convert.ToString(best_value_fp));
            }
        }
        return res;
    }
    public static string GetStringToMatch(List<string> imageString)
    {
        int colLength = imageString[0].Length;

        // Determine the row to use
        int selectedRow = imageString.Count / 2;
        int desiredLength = 8;
        int start = Math.Max(0, (colLength - desiredLength) / 2);

        int end = Math.Min(colLength, start + desiredLength);

        // Build the result string
        StringBuilder result = new StringBuilder();
        for (int i = start; i < end; i++)
        {
            result.Append(imageString[selectedRow][i]);
        }

        return result.ToString();
    }

    static void Main(string[] args) {
    }
}