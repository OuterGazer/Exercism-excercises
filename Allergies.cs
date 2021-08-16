using System;
using System.Collections.Generic;

[Flags]
public enum Allergen
{
    Eggs            = 1,
    Peanuts         = 2,
    Shellfish       = 4,
    Strawberries    = 8,
    Tomatoes        = 16,
    Chocolate       = 32,
    Pollen          = 64,
    Cats            = 128
}

public class Allergies
{
    int allergyScore;
    Allergen castedAllergyScore;
    Allergen incomingAllergies;

    List<Allergen> allergenList = new List<Allergen>();

    public Allergies(int mask)
    {
        if(mask > 255)
        {
            do
            {
                mask -= 256;
            } while (mask > 255); 
        }
        
        allergyScore = mask;        
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        incomingAllergies = allergen;
        castedAllergyScore = (Allergen)allergyScore;
        
        if(castedAllergyScore.HasFlag(allergen))
        {
            return true;
        }
        else
        {
            return false;
        }        
    }

    public Allergen[] List()
    {
        
        castedAllergyScore = (Allergen)allergyScore;
        string[] splitList = new string[] { };        

        if ((castedAllergyScore.HasFlag(incomingAllergies)) && (allergyScore != 0))
        {            
            allergenList.Add(castedAllergyScore);

            for (int i = 0; i < allergenList.Count; i++)
            {
                splitList = allergenList[i].ToString()
                    .Split(new Char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            allergenList.Clear();

            foreach (string s in splitList)
            {
                allergenList.Add((Allergen)Enum.Parse(typeof(Allergen), s));
            }
        }

        return allergenList.ToArray();
    }
}