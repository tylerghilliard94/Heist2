using System;
namespace Heist2
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }

        public string Skill { get; set; }
        public int SkillLevel { get; set; }


        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= SkillLevel;
            Console.WriteLine($"{Name} is taking care of the guards. Decreased the guard threat by {SkillLevel}!");
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"");
                Console.WriteLine($"{Name} has nullified the guard threat!");
            }
        }
    }


}