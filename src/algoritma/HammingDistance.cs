using System; 
  
class Hamming { 
    public static int hammingDist(String str1,  
                        String str2) 
    { 
        int i = 0, count = 0; 
        while (i < str1.Length) 
        { 
            if (str1[i] != str2[i]) 
                count++; 
            i++; 
        } 
        return count; 
    }  
}