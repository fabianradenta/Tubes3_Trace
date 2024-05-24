// See https://aka.ms/new-console-template for more information
using System;
using BoyerMoore;
class Program{

    public static void Main(string[] args){
        string pattern = "example";
        int[] last = MyBoyerMoore.Last(pattern);

        Console.WriteLine("Last occurrence indices for characters in the pattern:");
        for (int i = 0; i < 128; i++){
            if (last[i] != -1){
                Console.WriteLine($"Character {(char)i}: Index {last[i]}");
            }
        }
    }   
}
