using System;
 
class LevenshteinDistance {
    // Function to calculate Levenshtein distance between
    // two strings
    public static int LevenshteinTwoMatrixRows(string str1,
                                        string str2)
    {
        int m = str1.Length;
        int n = str2.Length;
 
        // Initialize two rows for dynamic programming
        int[] prevRow = new int[n + 1];
        int[] currRow = new int[n + 1];
 
        // Initialization of the first row
        for (int j = 0; j <= n; j++) {
            prevRow[j] = j;
        }
 
        // Dynamic programming to calculate Levenshtein
        // distance
        for (int i = 1; i <= m; i++) {
            // Initialize the current row with the value of
            // i
            currRow[0] = i;
 
            for (int j = 1; j <= n; j++) {
                // If characters are the same, no operation
                // is needed
                if (str1[i - 1] == str2[j - 1]) {
                    currRow[j] = prevRow[j - 1];
                }
                else {
                    // Choose the minimum of three
                    // operations: insert, remove, or
                    // replace
                    currRow[j] = 1
                                 + Math.Min(
                                     // Insert
                                     currRow[j - 1],
                                     Math.Min(
                                         // Remove
                                         prevRow[j],
 
                                         // Replace
                                         prevRow[j - 1]));
                }
            }
 
            // Update the previous row for the next
            // iteration
            Array.Copy(currRow, prevRow, n + 1);
        }
 
        // The bottom-right cell contains the Levenshtein
        // distance
        return currRow[n];
    }
}