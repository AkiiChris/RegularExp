using System;
using System.Text.RegularExpressions;

namespace RegExp
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "Please enter a valid name:";
            Console.WriteLine(text1);
            Console.ReadLine();

            if (Regex.Match(text1, "^[A - Z]{ 1}[A-Za - z]{ 30,}*$").Success)
            {
                Console.WriteLine("Name is valid.");
            }
            else
            {
                Console.WriteLine("Your name is invalid.");
            }

            string text2 = "Please enter a valid email:";
            Console.WriteLine(text2);
            Console.ReadLine();

            if (Regex.Match(text2, " ^[0-9a-zA-Z]+[.+-]{0,1}[0-9a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-z]{2,3}){,1}").Success)
            {
                Console.WriteLine("Email is valid.");
            }
            else
            {
                Console.WriteLine("Email is not valid.");
            }

            string text3 = "Please enter a valid phone number:";
            Console.WriteLine(text3);
            Console.ReadLine();

            if (Regex.Match(text3, "^[6-9]{1}[0-9]{9}$").Success)
            {
                Console.WriteLine("The number you entered is valid.");
            }
            else
            {
                Console.WriteLine("The number you entered is invalid.");
            }
            string text4 = "Please enter a valid date:";
            Console.WriteLine(text4);
            Console.ReadLine();

            if (Regex.Match(text4, @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$").Success) 
            {
                Console.WriteLine("The date you entered is valid.");
            }
            else
            {
                Console.WriteLine("The date you entered is invalid.");
            }
        }
    }
}
//public static string Name_Regex = "^[A-Z]{1}[A-Za-z]{30,}$";
//public static string Email_Regex = "^[6-9]{1}[0-9]{9}$";     ^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$
//public static string PhoneNumb_Regex = "^[0-9a-zA-Z]+[.+-]{0,1}[0-9a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-z]{2,3}){,1}";
//public static string Month_Regex = "";




