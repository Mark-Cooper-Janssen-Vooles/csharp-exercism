using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int hammingDistance = 0;

        if(firstStrand == secondStrand)
        {
            hammingDistance = 0;
        }
        else if(firstStrand.Length == secondStrand.Length)
        {
            for(int i = 0; i < firstStrand.Length; i++)
            {
                if(firstStrand[i] != secondStrand[i])
                {
                    hammingDistance++;
                }
            }
        } 
        else 
        {
            throw new System.ArgumentException("Not the same length");
        }



        return hammingDistance;
    }
}
