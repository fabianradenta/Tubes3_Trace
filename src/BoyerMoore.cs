using System;

public class BoyerMoore {
namespace BoyerMoore{
    public static int[] Last(string pattern){
        int[] last = new int[128];

        for (int i=0; i<128; i++){
            last[i] = -1;
        }

        for (int i=0; i<pattern.Length; i++){
            last[pattern[i]] = i;
        }
        return last;
    }
    // public static void Main(string[] args){
    //     string pattern = "example";
    //     int[] last = Last(pattern);

    //     Console.WriteLine("Last occurrence indices for characters in the pattern:");
    //     for (int i = 0; i < 128; i++){
    //         if (last[i] != -1){
    //             Console.WriteLine($"Character {(char)i}: Index {last[i]}");
    //         }
    //     }
    // }
}
}
