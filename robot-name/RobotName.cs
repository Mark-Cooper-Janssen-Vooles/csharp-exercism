using System;
using System.Collections.Generic;

public class Robot
{
    private static List<string> NameList = new List<string>(); //needs to be a non-instance data type
    public string Name { get; private set; }

    public Robot() {
        this.Name = RandomName();
    }

    public void Reset()
    {
        Robot.NameList.Remove(this.Name);
        this.Name = RandomName();
    }

    private string RandomName() 
    {
        var checkName = true;
        string newName = null;

        while (checkName)
        {
            newName = GenerateName();

            if(!Robot.NameList.Contains(newName)) //if doesn't contain the new name
            {
                checkName = false; //breaks out of loop
            } 
        }

        Robot.NameList.Add(newName);

        System.Console.WriteLine(Robot.NameList.Count);
        return newName;    
    }

    private string GenerateName() 
    {
        //generate random letter between A and Z, twice
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Random rand1 = new Random();
        Random rand2 = new Random();
        //first num
        int num1 = rand1.Next(0, chars.Length -1);
        //second num
        int num2 = rand2.Next(0, chars.Length -1);
        // return chars[num];

        //generate random number between 1 and 9, three times. 
            string numbers = "0123456789";
            Random rand3 = new Random();
            Random rand4 = new Random();
            Random rand5 = new Random();
            //first letter
            int num3 = rand3.Next(0, numbers.Length -1);
            //second letter
            int num4 = rand4.Next(0, numbers.Length -1);
            //third letter
            int num5 = rand5.Next(0, numbers.Length -1);
            // return numbers[num];

            //check if it exists in the NameList, if not add it to it and return. 
            // if it does, loop again and try again. 

            var aName = new Char[5];
            aName[0] = chars[num1];
            aName[1] = chars[num2];
            aName[2] = numbers[num3];
            aName[3] = numbers[num4];
            aName[4] = numbers[num5];

            var newName = new String(aName);
            // System.Console.WriteLine(  newName );

            return newName;
    }
}