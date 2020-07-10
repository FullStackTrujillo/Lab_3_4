using System;
using System.Text.RegularExpressions;

public class Lab_3_4
{
    public static void Main()
    {
        Console.WriteLine("2A");
        string pattern = @"[d-e]";
        string swtext = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy....";
        RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(swtext, pattern, options))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);

            Console.WriteLine("2B");
            string pattern2 = @"[d-e][*d]";
            RegexOptions options2 = RegexOptions.Multiline;

            foreach (Match m2 in Regex.Matches(swtext, pattern2, options2))
            {
                Console.WriteLine("'{0}' found at index {1}.", m2.Value, m2.Index);

                Console.WriteLine("2C");
                string pattern3 = @"[a][a-z][a]";
                RegexOptions options3 = RegexOptions.Multiline;

                foreach (Match m3 in Regex.Matches(swtext, pattern3, options3))
                {
                    Console.WriteLine("'{0}' found at index {1}.", m3.Value, m3.Index);

                    Console.WriteLine("2D");
                    string pattern4 = @"[ ][p][a-z]*";
                    RegexOptions options4 = RegexOptions.Multiline;

                    foreach (Match m4 in Regex.Matches(swtext, pattern4, options4))
                    {
                        Console.WriteLine("'{0}' found at index {1}.", m4.Value, m4.Index);

                        Console.WriteLine("2E");
                        string pattern5 = @"[a-z]*[e][ ]";
                        RegexOptions options5 = RegexOptions.Multiline;

                        foreach (Match m5 in Regex.Matches(swtext, pattern5, options5))
                        {
                            Console.WriteLine("'{0}' found at index {1}.", m5.Value, m5.Index);


                            Console.WriteLine("2F");
                            string pattern6 = @"[A-Z]";
                            RegexOptions options6 = RegexOptions.Multiline;

                            foreach (Match m6 in Regex.Matches(swtext, pattern6, options6))
                            {
                                Console.WriteLine("'{0}' found at index {1}.", m6.Value, m6.Index);






                            }
                        }
                    }
                }
            }
        }
    }
}