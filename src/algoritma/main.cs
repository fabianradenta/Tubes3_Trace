using System;
using System.Diagnostics;
using System.Text;
using ImageProcess;
using System.Drawing;
using System.Drawing.Imaging;

public class MainProgram{
    public static List<string> Search_FingerPrint(string ImageAscii){
        string folderPath = @"Real";

        string[] allFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
        double best_value_fp = 8;
        string result = "";
        string r = "";
        bool found = false;
        foreach (string file in allFiles){
            List<string> ImageAscii2 = ImageToString.IntToString(ImageToString.ConvertToBinaryImage(file));
            foreach (string row in ImageAscii2) {
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
                    result = file;
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
        List<string> res = new List<string>();
        res.Add(result);
        if (!found){
            Console.WriteLine(r);
            Console.WriteLine(ImageAscii);
            Console.WriteLine(best_value_fp);
            if (best_value_fp > 4) {
                res.Add("\nNot found the image");
                Console.WriteLine("Not found the image");
            } else {
                res.Add("\nNot found the exact same image");
                Console.WriteLine("Not found the exact same image");
                Console.WriteLine(result);
            }
        } else {
            res.Add("");
        }
        return res;
    }
    public static string GetStringToMatch(List<string> imageString)
{
    int colLength = imageString[0].Length;

    // Determine the row to use
    int selectedRow = imageString.Count / 4;
    int selectedRowAlt = imageString.Count * 3 / 4;
    int desiredLength = 8;
    int minLength = 4;
    int start = Math.Max(0, (colLength - desiredLength) / 2);
    // int startAlt = Math.Max(0, (colLength - desiredLength) 2);

    int end = Math.Min(colLength, start + desiredLength);

    if (end - start < minLength)
    {
        start = Math.Max(0, (colLength - minLength) / 4);
        // startAlt = Math.Max(0, (colLength - minLength) / 2);
        end = Math.Min(colLength, start + minLength);
    }

    // Build the result string
    StringBuilder result = new StringBuilder();
    StringBuilder resultAlt = new StringBuilder();
    int count = 0;
    for (int i = start; i < end; i++)
    {
        if (imageString[selectedRow][i] == ' ') {
            count++;
        }
        result.Append(imageString[selectedRow][i]);
        resultAlt.Append(imageString[selectedRowAlt][i]);
    }

    // if (count == (end - start + 1)) {
    //     return resultAlt.ToString();
    // } else {
    //     return result.ToString();
    // }

    return result.ToString();
}

    static void Main(string[] args) {}
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