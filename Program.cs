using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _21_7_23_Assign_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a piece of text:");
            string inputText = Console.ReadLine();
            int wordCount = CountWords(inputText);
            Console.WriteLine($"Word Count: {wordCount}");
            List<string> emailAddresses = ExtractEmailAddresses(inputText);
            Console.WriteLine("Email Addresses Found:");
            foreach (var email in emailAddresses)
            {
                Console.WriteLine(email);
            }           
            List<string> mobileNumbers = ExtractMobileNumbers(inputText);
            Console.WriteLine("Mobile Numbers Found:");
            foreach (var number in mobileNumbers)
            {
                Console.WriteLine(number);
            }           
            Console.WriteLine("Enter a custom regular expression:");
            string customRegexPattern = Console.ReadLine();
            List<string> customRegexMatches = PerformCustomRegexSearch(inputText, customRegexPattern);
            Console.WriteLine("Custom Regex Matches Found:");
            foreach (var match in customRegexMatches)
            {
                Console.WriteLine(match);
            }          
        }
        static int CountWords(string input)
        {
            return input.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        static List<string> ExtractEmailAddresses(string input)
        {
            var emailPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
            var matches = Regex.Matches(input, emailPattern);
            return matches.Cast<Match>().Select(match => match.Value).ToList();
        }
        static List<string> ExtractMobileNumbers(string input)
        {
            var mobilePattern = @"\b\d{10}\b";
            var matches = Regex.Matches(input, mobilePattern);
            return matches.Cast<Match>().Select(match => match.Value).ToList();
        }    
        static List<string> PerformCustomRegexSearch(string input, string regexPattern)
        {
            var matches = Regex.Matches(input, regexPattern);
            return matches.Cast<Match>().Select(match => match.Value).ToList();
            Console.ReadKey();
        }
    }
}

