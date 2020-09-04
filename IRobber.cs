using System;

namespace Heist2
{
    public interface IRobber
    {
        string Name { get; set; }
        int SkillLevel { get; set; }

        string Skill { get; set; }
        int PercentageCut { get; set; }

        void PerformSkill(Bank bank)
        {

        }
    }
}