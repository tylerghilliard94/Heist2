using System;
namespace Heist2
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }

        public string Skill { get; set; }
        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.VaultScore -= SkillLevel;
            Console.WriteLine($"{Name} is working on the vault lock. Decreased the vault integrity by {SkillLevel}!");
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"");
                Console.WriteLine($"{Name} has broken into the vault!");
            }
        }
    }


}