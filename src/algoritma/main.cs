using System;
using System.Diagnostics;
using System.Text;
using ImageProcess;
using System.Drawing;
using System.Drawing.Imaging;
using database;

public class MainProgram{
    // public static List<string> Search_FingerPrint(string ImageAscii, bool isKMP){
    //     Database db = new Database();
    //     db.connect();
    //     List<string> allFiles = db.selectPathFromSidikJari();
    //     Console.WriteLine(allFiles[0]);
        
    //     int best_value_fp = 8;
    //     string result = "";
    //     string r = "";
    //     bool found = false;
    //     foreach (string file in allFiles){
    //         List<string> ImageAscii2 = ImageToString.IntToString(ImageToString.ConvertToBinaryImage(file));
    //         foreach (string row in ImageAscii2) {
    //             if (isKMP){
    //                 if (KMP.KMPCompare(row, ImageAscii) == -1) {
    //                     for (int i = 0; i <= row.Length - ImageAscii.Length; i++) {
    //                         string substring = row.Substring(i, ImageAscii.Length);
    //                         int Hamming_Result = Hamming.hammingDist(ImageAscii, substring);
    //                         if (Hamming_Result < best_value_fp)
    //                         {
    //                             best_value_fp = Hamming_Result;
    //                             result = file;
    //                             r = substring;
    //                         }
    //                     }
    //                 } else {
    //                     r = row;
    //                     result = file;
    //                     found = true;
    //                     break;
    //                 }
    //             }
    //             else {
    //                 if (BoyerMoore.BmMatch(row, ImageAscii) == -1) {
    //                     for (int i = 0; i <= row.Length - ImageAscii.Length; i++) {
    //                         string substring = row.Substring(i, ImageAscii.Length);
    //                         int Hamming_Result = Hamming.hammingDist(ImageAscii, substring);
    //                         if (Hamming_Result < best_value_fp)
    //                         {
    //                             best_value_fp = Hamming_Result;
    //                             result = file;
    //                             r = substring;
    //                         }
    //                     }
    //                 } else {
    //                     r = row;
    //                     result = file;
    //                     found = true;
    //                     break;
    //                 }
    //             }
    //         }
    //         if (found) {
    //             break;
    //         }
    //     }
    //     List<string> res = new List<string>();
    //     res.Add(result);
    //     if (!found){
    //         Console.WriteLine(r);
    //         Console.WriteLine(ImageAscii);
    //         Console.WriteLine(best_value_fp);
    //         if (best_value_fp > 5) {
    //             res.Add("\nNot found the image\n");
    //             res.Add(Convert.ToString(best_value_fp));
    //         } else {
    //             res.Add("\nNot found the exact same image\n");
    //             res.Add(Convert.ToString(best_value_fp));
    //         }
    //     } else {
    //         res.Add("\n");
    //         res.Add("0");
    //     }
    //     return res;
    // }
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
        string r = "";
        bool found = false;
        foreach (string file in allFiles){
            List<string> ImageAscii2 = ImageToString.IntToString(ImageToString.ConvertToBinaryImage(file));
            int Hamming_Result = 0;
            for (int idx = 0; idx < ImageAscii.Count; idx++) {
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
        if (!found){
            if (best_value_fp < 55) {
                res.Add("\nNot found the image\n");
                res.Add(Convert.ToString(best_value_fp));
            } else {
                res.Add("\nNot found the exact same image\n");
                res.Add(Convert.ToString(best_value_fp));
            }
        } else {
            res.Add("\n");
            res.Add("0");
        }
        return res;
    }
    public static string GetStringToMatch(List<string> imageString)
    {
        int colLength = imageString[0].Length;

        // Determine the row to use
        int selectedRow = imageString.Count / 2;
        int desiredLength = 8;
        int minLength = 4;
        int start = Math.Max(0, (colLength - desiredLength) / 2);

        int end = Math.Min(colLength, start + desiredLength);

        if (end - start < minLength)
        {
            start = Math.Max(0, (colLength - minLength) / 4);
            end = Math.Min(colLength, start + minLength);
        }

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
    //     string imagePath = "Real/3__M_Right_ring_finger.BMP";
    //     // string imagePath2 = "Real/172__M_Right_ring_finger.BMP";
    //     // List<List<int>> binaryMatrix2 = ImageToString.ConvertToBinaryImage(imagePath2);
    //     // List<String> StringPattern2 = ImageToString.IntToString(binaryMatrix2);
    //     // String ImageAscii = GetStringToMatch(StringPattern2);
    //     // foreach (List<int> row in binaryMatrix)
    //     // {
    //     //     foreach (int value in row)
    //     //     {
    //     //         Console.Write(value);
    //     //     }
    //     //     Console.WriteLine();
    //     // }
    //     // foreach (String str in StringPattern)
    //     // {
    //     //     Console.WriteLine(str);
    //     // }
    //     Stopwatch stopwatch = new Stopwatch();
    //     stopwatch.Start();
    //     stopwatch.Stop();
    //     Console.WriteLine($"Time: {stopwatch.Elapsed.TotalMilliseconds} ms");
    // }
}
// String r = "";
// Boolean found = false;
// int best_value_fp = 8;
// foreach (String row in StringPattern) {
//     if (KMP.KMPCompare(row, ImageAscii) == -1) {
//         for (int i = 0; i <= row.Length - ImageAscii.Length; i++) {
//             string substring = row.Substring(i, ImageAscii.Length);
//             int LCS_Result = LCS.LongestCommonSubsequence(ImageAscii, substring);
//             if (LCS_Result < best_value_fp)
//             {
//                 r = substring;
//                 best_value_fp = LCS_Result;
//             }
//         }
//     } else {
//         r = row;
//         Console.WriteLine(row);
//         Console.WriteLine(ImageAscii);
//         found = true;
//         break;
//     }
// }
// if (!found) {
//     Console.WriteLine(r);
//     Console.WriteLine(ImageAscii);
//     Console.WriteLine(best_value_fp);
//     if (best_value_fp > 4) {
//         Console.WriteLine("Not found the image");
//     } else {
//         Console.WriteLine("Not found the exact same image");
//     }
// }