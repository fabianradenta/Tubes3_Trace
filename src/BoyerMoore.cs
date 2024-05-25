// public class BoyerMoore {
//     public static int[] BuildLast(string pattern){
//         int[] last = new int[128];
//         for (int i = 0; i < 128; i++) {
//             last[i] = -1;
//         }

//         for (int i = 0; i < pattern.Length; i++) {
//             last[pattern[i]] = i;
//         }
//         return last;
//     }
// }

// class Program {
//     static void Main() {
//         string pattern = "example";
//         int[] last = BoyerMoore.BuildLast(pattern);

//         Console.WriteLine("Last occurrence array:");
//         for (int i = 0; i < last.Length; i++) {
//             if (last[i] != -1) {
//                 Console.WriteLine($"Character: {(char)i}, Index: {last[i]}");
//             }
//         }
//     }
// }