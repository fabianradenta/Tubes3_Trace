using System;

class KMP {
    public static int KMPCompare(string text, string pattern) {
        int i = 0;
        int j = 0;
        int patternLength = pattern.Length;
        int textLength = text.Length;
        int[] b = computeBorder(pattern);

        while (i < textLength) {
            if (pattern[j] == text[i]) {
                if (j == patternLength - 1) {
                    return i - patternLength + 1;
                }
                i++;
                j++;
            } else if (j > 0) {
                j = b[j - 1];
            } else {
                i++;
            }
        }
        return -1;
    }
    public static int[] computeBorder(string pattern) {
        int i = 1;
        int j = 0;
        int patternLength = pattern.Length;
        int[] b = new int[patternLength];
        b[0] = 0;
        while (i < patternLength) {
            if (pattern[j] == pattern[i]) {
                b[i] = j + 1;
                i++;
                j++;
            } else if (j > 0) {
                j = b[j - 1];
            } else {
                b[i] = 0;
                i++;
            }
        }
        return b;
    }
}