using System.Net.WebSockets;
using System;
using System.Text.RegularExpressions;

namespace SSN Validation;

public class Progran
{
    public static void Main() 
    {
        Console.Write("Please Enter a Social Security Number: ");
        string SSN = Console.ReadLine();

        //Creating the Regex:
        string pattern = @"^(?!000|666|(.)*0000)([0-8][0-9]{2})-([0-9][1-9])-([0-9]){4}";
        Regex regex = new Regex(pattern);

        MatchCollection matchedSSN = regex.Matches(SSN);

        if(matchedSSN.Count() == 1){
            Console.WriteLine("Valid Social Security Number");
            return;
        }

        if(string.IsNullOrEmpty(SSN) || string.IsNullOrWhiteSpace(SSN))
        {
            Console.WriteLine("You cannot leave the field empty");
            return;
        }

        if(matchedSSN.Count() > 1){
            Console.WriteLine("Please only enter a social security number.");
            return;
        }

        string[] regexGroups = SSN.Split('-');

        if(regexGroups.Count() > 3)
        {
            Console.WriteLine("The Social Security Number must be in the format xxx-xx-xxxx");
            return;
        }

        if(regexGroups[0] == "000" || regexGroups[0] == "666" || regexGroups[0][0] == '9'){
            Console.WriteLine("Social Security Number cannot start with 000, 666 or between 900 and 999.");
            return;
        }

        if(regexGroups[1] == "00")
        {
            Console.WriteLine("The number between '-' cannot be 00"); 
            return;
        }

        if(regexGroups[2] == "0000")
            Console.WriteLine("The third part of the Social Security Number cannot be 000");
    }
}
