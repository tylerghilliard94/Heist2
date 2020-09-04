using System;
namespace Heist2
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }

        public string Skill { get; set; }
        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore -= SkillLevel;
            Console.WriteLine($"{Name} is hacking the alarm system. Decreased the alarm by {SkillLevel}!");
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"");
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
        }
    }


}