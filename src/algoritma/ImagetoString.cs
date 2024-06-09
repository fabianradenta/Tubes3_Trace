using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageProcess
{
    public class ImageToString {
        public static List<List<int>> ConvertToBinaryImage(string imagePath)
    {
        Bitmap inputImage = new Bitmap(imagePath);
        int width = inputImage.Width;
        int height = inputImage.Height;
        List<List<int>> binaryMatrix = new List<List<int>>(height);

        for (int y = 0; y < height; y++)
        {
            List<int> row = new List<int>(width);
            for (int x = 0; x < width; x++)
            {
                Color pixelColor = inputImage.GetPixel(x, y);
                int grayValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                row.Add(grayValue >= 150 ? 1 : 0);
            }
            binaryMatrix.Add(row);
        }

        return binaryMatrix;
    }

    public static List<string> IntToString(List<List<int>> binaryMatrix)
    {
        List<string> asciiRows = new List<string>();

        foreach (List<int> row in binaryMatrix)
        {
            StringBuilder asciiString = new StringBuilder();

            for (int i = 0; i < row.Count - row.Count % 8; i += 8)
            {
                int asciiValue = 0;
                for (int j = 0; j < 8; j++)
                {
                    asciiValue = (asciiValue << 1) | row[i + j];
                }
                asciiString.Append((char)asciiValue);
            }
            asciiRows.Add(asciiString.ToString());
        }

        return asciiRows;
    }
    }
}