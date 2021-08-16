using System;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string[] temp;
        string cleanNumber = null;

        temp = phoneNumber.Split(new char[] {'.', '-', '(', ')', ' ', '+'}); //Split string erasing all non-valid characters and put them in an array

        foreach (string item in temp) //Put the strings from the array into a proper string
            cleanNumber += item;


        if ((cleanNumber.Length == 11) && cleanNumber[0] != '1') //check the country code is correct
        {
            throw new ArgumentException("Country code must start with 1");
        }
        else if ((cleanNumber.Length < 10) || (cleanNumber.Length > 11)) //Check the phone number length is correct
        {
            throw new ArgumentException("The phone number length is invalid. It can't be less than 10 or greater than 11 characters long.");
        }
        else if (!long.TryParse(cleanNumber, out long result)) //check for invalid characters. Must use long as numbers greater than 32 bits
        {
            throw new ArgumentException("The phone number contains invalid characters.");
        }    

        
        if (cleanNumber.Length == 11) //if number is correct and includes country code "1", remove country code
            cleanNumber = cleanNumber.Remove(0, 1);


        if ((cleanNumber[0] == '0') || (cleanNumber[0] == '1') ||
            (cleanNumber[3] == '0') || (cleanNumber[3] == '1'))
            throw new ArgumentException("Area/Exchange code must be between 2 and 9."); //Check at last for correct Area and Exchange codes


        return cleanNumber;
    }
}