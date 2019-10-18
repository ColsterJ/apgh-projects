using System;

/*Morse code assignment!

make a program that translates text that a user gives into Morse code.

Example run:
What is your message?
> sos
Your message in Morse code is:
... --- ...

Morse:
* doesn't deal with capitals
* longer spaces mean more pause.
  * 1 space between letters
  * 2 spaces between words
  * 3 spaces between sentences
* can do just letters first, numbers later.
 */

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string regularChars = " .abcdefghijklmnopqrstuvwxyz1234567890";
            string[] morseChars = {
                // 1 space between letters, 2 spaces between words, 3 spaces between sentences
                // Assumes people write sentences followed by a period and a space. 
                // Assumes words have one space between them
                // src for letters - https://upload.wikimedia.org/wikipedia/commons/b/b5/International_Morse_Code.svg
                " ",   // ' ' - becomes two spaces (already 1 space after letter)
                " ",  // '.' - becomes three spaces (already 1 space after letter)
                ".---",     // a
                "---...",   // b
                "---.---.", // c
                "---..",    // d
                ".",        // e
                "..---.",   // f
                "------.",  // g
                "....",     // h
                "..",       // i
                ".---------",// j
                "---.---",  // k
                ".---..",   // l
                "------",   // m
                "---.",     // n
                "---------",// o
                ".------.", // p
                "------.---",   // q
                ".---.",    // r
                "...",      // s
                "---",      // t
                "..---",    // u
                "...---",   // v
                ".------",  // w
                "---..---", // x
                "---.------",// y
                "------..",  // z
                ".------------", // 1
                "..---------", // 2
                "...------", // 3
                "....---",  // 4
                ".....",    // 5
                "---....",  // 6
                "------...",    // 7
                "---------..",  // 8
                "------------.", // 9
                "---------------"   // 0
            };
            string original, converted = "";

            // get string from user
            Console.WriteLine("Enter some text:");
            original = Console.ReadLine().ToLower();
            original = original.Replace('!', '.').Replace('?', '.');  // Replace non-periods with periods

            // for each character in string, convert character to morse code
            for (int i = 0; i < original.Length; i++)
            {
                if (!regularChars.Contains(original[i]))
                {
                    continue;  // Simply ignore unsupported characters
                }
                // transcribe corresponding morse code sequence from array
                // with morse code 'regularChars' in same order as alphabet
                if (regularChars.Contains(original[i]) && morseChars.Length == regularChars.Length)
                {
                    converted += morseChars[regularChars.IndexOf(original[i])];
                    if (Char.IsLetterOrDigit(original[i]))
                    {
                        converted += ' ';
                    }
                }
            }

            // Show the result to user
            Console.WriteLine("Your message in morse code becomes:");
            Console.WriteLine('\"' + converted + '\"');

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
