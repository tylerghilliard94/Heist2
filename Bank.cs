using System;

namespace Heist2
{
    public class Bank
    {
        public int CashonHand { get; set; }
        public int AlarmScore { get; set; }

        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }

        public Boolean IsSecure
        {
            get
            {
                if (CashonHand <= 0 && AlarmScore <= 0 && VaultScore <= 0 && SecurityGuardScore <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }


    }
}