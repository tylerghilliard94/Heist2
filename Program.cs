using System;
using System.Collections.Generic;

namespace Heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker Melody = new Hacker()
            {
                Name = "Melody",
                Skill = "Hacker",
                SkillLevel = 99,
                PercentageCut = 50


            };
            Hacker Marcus = new Hacker()
            {
                Name = "Marcus",
                Skill = "Hacker",
                SkillLevel = 40,
                PercentageCut = 18

            };
            Muscle Michael = new Muscle()
            {
                Name = "Michael",
                Skill = "Muscle",
                SkillLevel = 25,
                PercentageCut = 5

            };
            Muscle Trent = new Muscle()
            {
                Name = "Trent",
                Skill = "Muscle",
                SkillLevel = 80,
                PercentageCut = 15

            };
            LockSpecialist Manila = new LockSpecialist()
            {
                Name = "Manila",
                Skill = "Lock Specialist",
                SkillLevel = 75,
                PercentageCut = 35

            };
            LockSpecialist Latrice = new LockSpecialist()
            {
                Name = "Latrice",
                Skill = "Lock Specialist",
                SkillLevel = 45,
                PercentageCut = 30

            };

            List<IRobber> rolodex = new List<IRobber>()
            {
                Melody, Marcus, Michael, Trent, Manila, Latrice
            };

            Console.WriteLine("Welcome to Heist Version 2!");
            bool inputCheck = true;
            int operativeSpec = 0;
            string operativeName = "a";
            int operativeSkill = 0;
            int operativeCut = 0;
            while (inputCheck == true)
            {
                Console.WriteLine("");
                Console.WriteLine($"There are {rolodex.Count} operatives in your rolodex.");

                Console.WriteLine("");
                Console.Write("Enter a new operatives name: ");
                operativeName = Console.ReadLine();
                if (operativeName == "")
                {
                    inputCheck = false;
                    break;
                }
                Console.WriteLine("");

                Console.WriteLine("1) Hacker (Disables alarms)");
                Console.WriteLine("2) Muscle (Disarms guards)");
                Console.WriteLine("3) Lock Specialist (cracks vault)");
                Console.WriteLine("");
                Console.Write("Choose a specialty for the operative: ");
                try
                {
                    operativeSpec = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Must choose a number!");
                    Console.WriteLine("");
                    Console.Write("Choose a specialty for the operative: ");
                    operativeSpec = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("");
                Console.Write("What is the operatives skill level? (1-100) : ");
                try
                {
                    operativeSkill = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Must choose a number!");
                    Console.WriteLine("");
                    Console.Write("What is the operatives skill level? (1-100) : ");
                    operativeSkill = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("");
                Console.Write("What percentage cut does the operative want? ");


                try
                {
                    operativeCut = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Must choose a number!");
                    Console.WriteLine("");
                    Console.Write("What percentage cut does the operative want? ");
                    operativeCut = int.Parse(Console.ReadLine());
                }
                if (operativeSpec == 1)
                {
                    Hacker hacker = new Hacker()
                    {
                        Name = operativeName,
                        Skill = "Hacker",
                        SkillLevel = operativeSkill,
                        PercentageCut = operativeCut
                    };
                    rolodex.Add(hacker);
                }
                else if (operativeSpec == 2)
                {
                    Muscle muscle = new Muscle()
                    {
                        Name = operativeName,
                        Skill = "Muscle",
                        SkillLevel = operativeSkill,
                        PercentageCut = operativeCut
                    };
                    rolodex.Add(muscle);
                }
                else if (operativeSpec == 3)
                {
                    LockSpecialist lockSpec = new LockSpecialist()
                    {
                        Name = operativeName,
                        Skill = "Lock Specialist",
                        SkillLevel = operativeSkill,
                        PercentageCut = operativeCut
                    };
                    rolodex.Add(lockSpec);
                }



            }
            Random generator = new Random();
            Bank Heist = new Bank()
            {
                AlarmScore = generator.Next(0, 100),
                SecurityGuardScore = generator.Next(0, 100),
                VaultScore = generator.Next(0, 100),
                CashonHand = generator.Next(50000, 1000000)
            };
            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine("Bank Scounting Report:");
            if (Heist.AlarmScore >= Heist.SecurityGuardScore && Heist.AlarmScore >= Heist.VaultScore)
            {
                Console.WriteLine("");

                Console.WriteLine($"Most Secure: Alarm");

            }
            else if (Heist.SecurityGuardScore >= Heist.AlarmScore && Heist.SecurityGuardScore >= Heist.VaultScore)
            {
                Console.WriteLine("");

                Console.WriteLine($"Most Secure: Security");
            }
            else if (Heist.VaultScore >= Heist.AlarmScore && Heist.VaultScore >= Heist.SecurityGuardScore)
            {
                Console.WriteLine("");

                Console.WriteLine($"Most Secure: Vault");
            }

            if (Heist.AlarmScore <= Heist.SecurityGuardScore && Heist.AlarmScore <= Heist.VaultScore)
            {
                Console.WriteLine("");

                Console.WriteLine($"Least Secure: Alarm");
                Console.WriteLine($"");

            }
            else if (Heist.SecurityGuardScore <= Heist.AlarmScore && Heist.SecurityGuardScore <= Heist.VaultScore)
            {
                Console.WriteLine("");

                Console.WriteLine($"Least Secure: Security");
                Console.WriteLine($"");
            }
            else if (Heist.VaultScore <= Heist.AlarmScore && Heist.VaultScore <= Heist.SecurityGuardScore)
            {
                Console.WriteLine("");

                Console.WriteLine($"Least Secure: Vault");
                Console.WriteLine($"");
            }
            List<IRobber> crew = new List<IRobber>();
            int heistPercentage = 0;
            int opSelect = 0;
            string opSelectStr = "a";
            while (opSelectStr != "")
            {


                int count = -1;
                Console.WriteLine($"");
                Console.WriteLine($"Operatives to choose from: ");
                foreach (IRobber operative in rolodex)
                {
                    if ((heistPercentage + operative.PercentageCut) <= 100)
                    {


                        count++;

                        Console.Write($"{count}) ");
                        Console.WriteLine($"Name: {operative.Name}");
                        Console.WriteLine($"Skill Set: {operative.Skill}");
                        Console.WriteLine($"Skill Level: {operative.SkillLevel}");
                        Console.WriteLine($"Percentage Cut Desired: {operative.PercentageCut}");
                        Console.WriteLine("");

                    }
                }


                Console.Write("Select an operative via their number: ");
                opSelectStr = Console.ReadLine();
                if (opSelectStr == "")
                {
                    break;
                }
                try
                {


                    opSelect = int.Parse(opSelectStr);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You have to use a number!");
                    Console.WriteLine("");
                    Console.Write("Select an operative via their number: ");
                    opSelectStr = Console.ReadLine();
                    opSelect = int.Parse(opSelectStr);
                }
                Console.WriteLine("");


                crew.Add(rolodex[opSelect]);
                heistPercentage += rolodex[opSelect].PercentageCut;
                rolodex.Remove(rolodex[opSelect]);



            }
            Console.WriteLine("");
            Console.WriteLine("The Heist has begun!");
            Console.WriteLine("");

            foreach (IRobber crewmem in crew)
            {
                crewmem.PerformSkill(Heist);
                Console.WriteLine($"");
            }
            int finalCash = Heist.CashonHand;
            if (Heist.AlarmScore <= 0 && Heist.SecurityGuardScore <= 0 && Heist.VaultScore <= 0)
            {
                Console.WriteLine("");
                Console.WriteLine("The Heist was a success!");
                Console.WriteLine("");
                Console.WriteLine("Heist Report: ");
                Console.WriteLine("");
                Console.WriteLine($"");
                foreach (IRobber crewmem in crew)
                {
                    int percentMem = (Heist.CashonHand * crewmem.PercentageCut) / 100;
                    Console.WriteLine($"{crewmem.Name} recieved ${ percentMem }");
                    finalCash -= (percentMem);
                    Console.WriteLine($"");
                }
                Console.WriteLine("");
                Console.WriteLine($"${finalCash} is left for your cut!");


            }
            else
            {
                Console.WriteLine($"");
                Console.WriteLine("The Heist was a failure and you and your crew are on your way to jail!");

            }
            Console.WriteLine("");
            Console.WriteLine("Thank you for playing Heist 2");

        }
    }
}
