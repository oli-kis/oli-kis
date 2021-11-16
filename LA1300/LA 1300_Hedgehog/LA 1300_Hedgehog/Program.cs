using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace LA_1300_Hedgehog
{
    class Program
    {
        static void Main(string[] args)
        {

            int z = 0;
            int d = 0;
            int r = 0;
            int u = 0;
            int counter = 0;

            string[] user;
            user = new string[10000];
            string[] prio1;
            prio1 = new string[10000];
            string[] prio2;
            prio2 = new string[10000];
            string[] prio3;
            prio3 = new string[10000];

            string fileO = @"../../../Workshop.csv";
            string file = File.ReadAllText(fileO);
            string[] subs = file.Split("\r\n");

            for (int i = 0; i < subs.Length; i++)
            {
                string[] words = subs[i].Split(";");

                for (int j = 0; j < words.Length; j++)
                {
                    if (j == 0)
                    {
                        user[z] = words[j];
                        z++;
                        counter++;
                    }
                    if (j == 1)
                    {
                        prio1[d] = words[j];
                        d++;
                    }
                    if (j == 2)
                    {
                        prio2[r] = words[j];
                        r++;
                    }
                    if (j == 3)
                    {
                        prio3[u] = words[j];
                        u++;
                    }
                }
            }
            //oli
            string[] soccer;
            soccer = new string[25];

            string[] basketball;
            basketball = new string[25];

            string[] hockey;
            hockey = new string[25];

            string[] tennis;
            tennis = new string[25];

            Random rnd = new Random();

            List<int> listNumbers = new List<int>();
            int number;
            int f = -1;
            int b = -1;
            int h = -1;
            int t = -1;

            for (int i = 0; i < counter-1; i++)
            {
                do
                {
                    number = rnd.Next(0, counter-1);
                } while (listNumbers.Contains(number));
                listNumbers.Add(number);

                Console.WriteLine(number + " " + user[number]);
                string userInput = prio1[number];

                switch (userInput)
                {
                    case "fussball":
                        try
                        {
                            f++;
                            Array.Copy(user, number, soccer, f, 1);
                        }
                        catch (Exception)
                        {
                            if (prio2[number] == "basketball")
                            {
                                goto case "basketball";
                            }
                            if (prio2[number] == "tennis")
                            {
                                goto case "tennis";
                            }
                            if (prio2[number] == "hockey")
                            {
                                goto case "hockey";
                            }
                            if (prio2[number] == "fussball")
                            {
                                if (prio3[number] == "basketball")
                                {
                                    goto case "basketball";
                                }
                                if (prio3[number] == "tennis")
                                {
                                    goto case "tennis";
                                }
                                if (prio3[number] == "hockey")
                                {
                                    goto case "hockey";
                                }
                            }
                        }
                        break;

                    case "basketball":
                        try
                        {
                            b++;
                            Array.Copy(user, number, basketball, b, 1);
                        }
                        catch (Exception)
                        {
                            if (prio2[number] == "fussball")
                            {
                                goto case "fussball";
                            }
                            if (prio2[number] == "tennis")
                            {
                                goto case "tennis";
                            }
                            if (prio2[number] == "hockey")
                            {
                                goto case "hockey";
                            }
                            if (prio2[number] == "basketball")
                            {
                                if (prio3[number] == "fussball")
                                {
                                    goto case "fussball";
                                }
                                if (prio3[number] == "tennis")
                                {
                                    goto case "tennis";
                                }
                                if (prio3[number] == "hockey")
                                {
                                    goto case "hockey";
                                }
                            }
                        }
                        break;

                    case "hockey":
                        try
                        {
                            h++;
                            Array.Copy(user, number, hockey, h, 1);
                        }
                        catch (Exception)
                        {
                            if (prio2[number] == "fussball")
                            {
                                goto case "fussball";
                            }
                            if (prio2[number] == "tennis")
                            {
                                goto case "tennis";
                            }
                            if (prio2[number] == "basketball")
                            {
                                goto case "basketball";
                            }
                            if (prio2[number] == "hockey")
                            {
                                if (prio3[number] == "fussball")
                                {
                                    goto case "fussball";
                                }
                                if (prio3[number] == "tennis")
                                {
                                    goto case "tennis";
                                }
                                if (prio3[number] == "basketball")
                                {
                                    goto case "basketball";
                                }
                            }
                        }
                        break;

                    case "tennis":
                        try
                        {
                            t++;
                            Array.Copy(user, number, tennis, t, 1);
                        }
                        catch (Exception)
                        {
                            if (prio2[number] == "fussball")
                            {
                                goto case "fussball";
                            }
                            if (prio2[number] == "tennis")
                            {
                                goto case "tennis";
                            }
                            if (prio2[number] == "basketball")
                            {
                                goto case "basketball";
                            }
                            if (prio2[number] == "tennis")
                            {
                                if (prio3[number] == "fussball")
                                {
                                    goto case "fussball";
                                }
                                if (prio3[number] == "baketball")
                                {
                                    goto case "basketball";
                                }
                                if (prio3[number] == "hockey")
                                {
                                    goto case "hockey";
                                }
                            }
                        }
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine("\n\nTeilnehmer Fussball: ");
            foreach (var item in soccer)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Teilnehmer Basketball: ");
            foreach (var item in basketball)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Teilnehmer Hockey: ");
            foreach (var item in hockey)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Teilnehmer Tennis: ");
            foreach (var item in tennis)
            {
                Console.WriteLine(item);
            }

            //lukas
            string[] workshop = { "fussball", "basketball", "hockey", "tennis" };

            if (f >= 5)
            {
                workshop[0] += " (°.°)";
            }
            else if (f >= 3)
            {
                workshop[0] += " (¬.¬)";
            }
            else
            {
                workshop[0] += " (¬_¬)";
            }
            if (b >= 5)
            {
                workshop[1] += " (° v °)";
            }
            else if (b >= 3)
            {
                workshop[1] += " (°o°)";
            }
            else
            {
                workshop[1] += " (- v -)";
            }
            if (h >= 5)
            {
                workshop[2] += " (-o-)";
            }
            else if (h >= 3)
            {
                workshop[2] += " (^<>^)";
            }
            else
            {
                workshop[2] += " (-_-)[zzz]";
            }
            if (t >= 5)
            {
                workshop[3] += " ( ^-^ )";
            }
            else if (t >= 3)
            {
                workshop[3] += " ( U w U )";
            }
            else
            {
                workshop[3] += " (o_o)";
            }

            Console.WriteLine("\n-------------------------------------------------------------");
            for (int i = 0; i < workshop.Length; i++)
            {
                Console.WriteLine(workshop[i]);
            }
        }
    }
}
