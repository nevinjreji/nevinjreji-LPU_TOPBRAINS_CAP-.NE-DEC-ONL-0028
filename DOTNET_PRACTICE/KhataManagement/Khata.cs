using System;
namespace KhataManagement
{
    public class Khata
    {
        public Dictionary<string, int> record;
        public Khata(Dictionary<string, int> record)
        {
            this.record = record;
        }

        public int GetTotal()
        {
            int total = 0;
            foreach (var item in record)
            {
                total += item.Value;
            }
            return total;
        }

        public int GetRepeatedAmount()
        {
            Dictionary<int, int> count = new Dictionary<int, int>();

            foreach (var item in record)
            {
                int amount = item.Value;

                if (count.ContainsKey(amount))
                {
                    count[amount]++;
                }
                else
                {
                    count[amount] = 1;
                }
            }

            int repeatedCount = 0;

            foreach (var item in count)
            {
                if (item.Value > 1)
                {
                    repeatedCount++;
                }
            }

            return repeatedCount;
        }

    }
}