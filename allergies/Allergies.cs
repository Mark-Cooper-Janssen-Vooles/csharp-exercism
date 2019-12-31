using System;
using System.Collections.Generic;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    public int Score;

    public Allergies(int mask)
    {
        this.Score = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        var allergenList = AllergyCalculator();

        if(allergenList.Contains(allergen))
        {
            return true;
        }

        return false;
    }

    public Allergen[] List()
    {
        //this wants  an array of allergens 

        //a list:
        var allergenList = AllergyCalculator();

        var allergenArray = allergenList.ToArray();

        Array.Sort(allergenArray, delegate(Allergen allergen1, Allergen allergen2) {
            return allergen1.CompareTo(allergen2);
        });

        return allergenArray;
    }

    public List<Allergen> AllergyCalculator()
    {
        var currentScore = this.Score;
        var keepLooping = true;

        var allergenList = new List<Allergen>();

        while (keepLooping)
        {
            if(currentScore > 255 )
            {
                allergenList.Add(Allergen.Cats);
                allergenList.Add(Allergen.Pollen);
                allergenList.Add(Allergen.Chocolate);
                allergenList.Add(Allergen.Tomatoes);
                allergenList.Add(Allergen.Strawberries);
                allergenList.Add(Allergen.Shellfish);
                // allergenList.Add(Allergen.Peanuts);
                allergenList.Add(Allergen.Eggs);

                keepLooping = false;
            } else 
            if (currentScore <= 255 && currentScore >= 128)
            {
                currentScore -= (int)Allergen.Cats; //128
                allergenList.Add(Allergen.Cats);
            } else if (currentScore <= 127 && currentScore >= 64)
            {
                currentScore -= (int)Allergen.Pollen; //64
                allergenList.Add(Allergen.Pollen);
            } else if (currentScore <= 63 && currentScore >= 32)
            {
                currentScore -= (int)Allergen.Chocolate; //32
                allergenList.Add(Allergen.Chocolate);
            } else if (currentScore <= 31 && currentScore >= 16)
            {
                currentScore -= (int)Allergen.Tomatoes; //16
                allergenList.Add(Allergen.Tomatoes);
            } else if (currentScore <= 15 && currentScore >= 8)
            {
                currentScore -= (int)Allergen.Strawberries; //8
                allergenList.Add(Allergen.Strawberries);
            } else if (currentScore <= 7 && currentScore >= 4)
            {
                currentScore -= (int)Allergen.Shellfish; //4
                allergenList.Add(Allergen.Shellfish);
            } else if (currentScore <= 3 && currentScore >= 2)
            {
                currentScore -= (int)Allergen.Peanuts; //2
                allergenList.Add(Allergen.Peanuts);
            } else if (currentScore <= 1 && currentScore >= 1) {
                currentScore -= (int)Allergen.Eggs; //1 
                allergenList.Add(Allergen.Eggs);
            } else {
                keepLooping = false;
            }
        }

        return allergenList;
    }
}