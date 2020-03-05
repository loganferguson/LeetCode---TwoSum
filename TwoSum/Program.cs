using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = {3, 2, 4};
            int target = 6;


            foreach(int index in TwoSum(list, target))
            {
                Console.Write($"{index}, ");
            }
            
            Console.ReadLine();
        }

        static int[] TwoSum(int[] nums, int target)
        {

            int[] addendsIndex = new int[2];

                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target && nums[i] != nums[j])
                        {
                            addendsIndex[0] = i;
                            addendsIndex[1] = j;
                            return addendsIndex;
                        }                   
                    }
                }
            return null;
        }
    }
}
    

