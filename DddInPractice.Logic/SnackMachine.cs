using System;

namespace DddInPractice.Logic
{
    public sealed class SnackMachine
    {
        public int OneCentCount { get; private set; }
        public int TenCentCount { get; private set; }
        public int QuarterCount { get; private set; }
        public int OneDollarCentCount { get; private set; }
        public int FiveDollarCount { get; private set; }
        public int TwentyDollarCount { get; private set; }

        public int OneCentCountInTransaction { get; private set; }
        public int TenCentCountInTransaction { get; private set; }
        public int QuarterCountInTransaction { get; private set; }
        public int OneDollarCentCountInTransaction { get; private set; }
        public int FiveDollarCountInTransaction { get; private set; }
        public int TwentyDollarCountInTransaction { get; private set; }

        public SnackMachine(int oneCentCount, 
            int tenCentCount,
            int quarterCount,
            int oneDollarCentCount,
            int fiveDollarCount,
            int twentyDollarCount)
        {
            OneCentCountInTransaction += oneCentCount;
            TenCentCountInTransaction += tenCentCount;
            QuarterCountInTransaction += quarterCount;
            OneDollarCentCountInTransaction += oneDollarCentCount;
            FiveDollarCountInTransaction += fiveDollarCount;
            TwentyDollarCountInTransaction += twentyDollarCount;
        }

        public void ReturnMoney()
        {
            OneCentCountInTransaction = 0;
            TenCentCountInTransaction = 0;
            QuarterCountInTransaction = 0;
            OneDollarCentCountInTransaction = 0;
            FiveDollarCountInTransaction = 0;
            TwentyDollarCountInTransaction = 0;
        }

        public void BuySnack()
        {
            OneCentCount += OneCentCountInTransaction;
            TenCentCount += TenCentCountInTransaction;
            QuarterCount += QuarterCountInTransaction;
            OneDollarCentCount += OneDollarCentCountInTransaction;
            FiveDollarCount += FiveDollarCountInTransaction;
            TwentyDollarCount += TwentyDollarCountInTransaction;

            OneCentCountInTransaction = 0;
            TenCentCountInTransaction = 0;
            QuarterCountInTransaction = 0;
            OneDollarCentCountInTransaction = 0;
            FiveDollarCountInTransaction = 0;
            TwentyDollarCountInTransaction = 0;
        }
    }
}
