using System; 
  
class Hamming { 
    public static int hammingDist(String str1,  
                        String str2) 
    { 
        if (str1.Length == str2.Length) {
            int i = 0, count = 0; 
            while (i < str1.Length) 
            { 
                if (str1[i] != str2[i]) 
                    count++; 
                i++; 
            } 
            return count; 
        } else {
            return str1.Length;
        }
    }  
}