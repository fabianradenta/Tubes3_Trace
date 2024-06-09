using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcess;
using database;

public class MainProgram
{
    public static List<string> Search_FingerPrint(List<string> ImageAscii, bool isKMP)
    {
        string ImageAsciiPartial = GetStringToMatch(ImageAscii);
        Database db = new Database();
        db.connect();
        List<string> allFiles = db.selectPathFromSidikJari();
        
        int length = ImageAscii.Count;
        int width = ImageAscii[0].Length;
        int best_value_fp = 0;
        string result = "";
        bool found = false;

        Parallel.ForEach(allFiles, (file, state) =>
        {
            List<string> ImageAscii2 = ImageToString.IntToString(ImageToString.ConvertToBinaryImage(file));
            int Hamming_Result = 0;

            for (int idx = 0; idx < Math.Min(length, ImageAscii2.Count); idx++)
            {
                if (isKMP)
                {
                    if (KMP.KMPCompare(ImageAscii2[idx], ImageAsciiPartial) != -1)
                    {
                        result = file;
                        found = true;
                        state.Break(); // Exit the loop if match is found
                    }
                    else
                    {
                        Hamming_Result += Hamming.hammingDist(ImageAscii2[idx], ImageAscii[idx]);
                    }
                }
                else
                {
                    if (BoyerMoore.BmMatch(ImageAscii2[idx], ImageAsciiPartial) != -1)
                    {
                        result = file;
                        found = true;
                        state.Break(); // Exit the loop if match is found
                    }
                    else
                    {
                        Hamming_Result += Hamming.hammingDist(ImageAscii2[idx], ImageAscii[idx]);
                    }
                }
            }

            Hamming_Result = (length * width - Hamming_Result) * 100 / (length * width);
            if (Hamming_Result > best_value_fp)
            {
                best_value_fp = Hamming_Result;
                result = file;
            }

            if (found)
            {
                state.Break(); // Exit the parallel loop if match is found
            }
        });

        List<string> res = new List<string>
        {
            result
        };

        if (found)
        {
            res.Add("0");
            res.Add("100");
        }
        else
        {
            if (best_value_fp < 55)
            {
                res.Add("-1");
                res.Add(best_value_fp.ToString());
            }
            else
            {
                res.Add("1");
                res.Add(best_value_fp.ToString());
            }
        }

        return res;
    }

    public static string GetStringToMatch(List<string> imageString)
    {
        int colLength = imageString[0].Length;
        int selectedRow = imageString.Count / 2;
        int desiredLength = 8;
        int start = Math.Max(0, (colLength - desiredLength) / 2);
        int end = Math.Min(colLength, start + desiredLength);

        StringBuilder result = new StringBuilder();
        for (int i = start; i < end; i++)
        {
            result.Append(imageString[selectedRow][i]);
        }

        return result.ToString();
    }

    static void Main(string[] args)
    {
        // Test code here
    }
}
