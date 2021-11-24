using System;

namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] nums)
        {

            int missingNumber, Totalsum;
            Totalsum = (nums.Length + 1) * (nums.Length + 2) / 2;
                        
            foreach (int item in nums)
            {
                Totalsum = Totalsum - item;
            }
            missingNumber = Totalsum;

            return missingNumber;
        }
    }
}
