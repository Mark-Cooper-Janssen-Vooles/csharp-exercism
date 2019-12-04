using System;
using System.Collections.Generic;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        // if(nucleotide.Length == 1) {
        //     switch(nucleotide)
        //     {
        //         case "":
        //             return "";
        //             break;
        //         case "A":
        //             return "U";
        //             break;
        //         case "C":
        //             return "G";
        //             break;
        //         case "G":
        //             return "C";
        //             break;
        //         case "T":
        //             return "A";
        //             break;
        //     }
        // } 
        // else 
        // {

            List<string> newList = new List<string>();

            for(int i = 0; i < nucleotide.Length; i++)
            {
                // Console.WriteLine(nucleotide[i].ToString().GetType());
                switch(nucleotide[i].ToString())
                {
                    // case "":
                    //     return "";
                    //     break;
                    case "A":
                        newList.Add("U");
                        break;
                    case "C":
                        newList.Add("G");
                        break;
                    case "G":
                        newList.Add("C");
                        break;
                    case "T":
                        newList.Add("A");
                        break;
                }
            }
            var returnThis = String.Join("", newList);
            Console.WriteLine("==========");
            Console.WriteLine(returnThis);
            return returnThis;
    //     }
            
    //     return "";
    }
}