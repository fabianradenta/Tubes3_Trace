using System;
using System.Diagnostics;
using System.Text;
using ImageProcess;
using System.Drawing;
using System.Drawing.Imaging;

class MainProgram{
    public static void Search_FingerPrint(String ImageAscii){
        string folderPath = @"Real";

        string[] allFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
        double best_value_fp = 8;
        string result = "";
        String r = "";
        bool found = false;
        foreach (string file in allFiles){
            List<String> ImageAscii2 = ImageToString.IntToString(ImageToString.ConvertToBinaryImage(file));
            foreach (String row in ImageAscii2) {
                if (KMP.KMPCompare(row, ImageAscii) == -1) {
                    for (int i = 0; i <= row.Length - ImageAscii.Length; i++) {
                        string substring = row.Substring(i, ImageAscii.Length);
                        // int LCS_Result = LCS.LongestCommonSubsequence(ImageAscii, substring);
                        int LCS_Result = Hamming.hammingDist(ImageAscii, substring);
                        if (LCS_Result < best_value_fp)
                        {
                            // Console.WriteLine(r);
                            // Console.WriteLine(file);
                            best_value_fp = LCS_Result;
                            result = file;
                            r = substring;
                        }
                    }
                } else {
                    r = row;
                    Console.WriteLine(file);
                    Console.WriteLine(row);
                    Console.WriteLine(ImageAscii);
                    found = true;
                    break;
                }
            }
            if (found) {
                break;
            }
        }
        if (!found){
            Console.WriteLine(r);
            Console.WriteLine(ImageAscii);
            Console.WriteLine(best_value_fp);
            if (best_value_fp > 4) {
                Console.WriteLine("Not found the image");
            } else {
                Console.WriteLine("Not found the exact same image");
                Console.WriteLine(result);
            }
        }
    }
    public static string GetStringToMatch(List<string> imageString)
    {
        int row = imageString.Count / 2;
        int rowLength = imageString[0].Length;
        int desiredLength = 8;
        int minLength = 4;

        // Calculate the start index to center the desired length part of the row
        int start = Math.Max(0, (rowLength - desiredLength) / 2);
        int end = Math.Min(rowLength, start + desiredLength);

        // Ensure the resulting string is at least minLength long
        if (end - start < minLength)
        {
            start = Math.Max(0, (rowLength - minLength) / 2);
            end = Math.Min(rowLength, start + minLength);
        }

        StringBuilder result = new StringBuilder();
        for (int i = start; i < end; i++)
        {
            result.Append(imageString[row][i]);
        }

        return result.ToString();
    }
    // static void Main(string[] args) {
    //     // string imagePath = "Real/253__F_Left_index_finger.BMP";
    //     string imagePath = "Real/3__M_Right_ring_finger.BMP";
    //     // string imagePath2 = "Real/172__M_Right_ring_finger.BMP";
    //     List<List<int>> binaryMatrix = ImageToString.ConvertToBinaryImage(imagePath);
    //     List<String> StringPattern = ImageToString.IntToString(binaryMatrix);
    //     Search_FingerPrint(GetStringToMatch(StringPattern));
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