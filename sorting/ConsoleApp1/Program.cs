using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array1 = { 1,3,5,4,7};
					   
			for (int pointer1 = 0; pointer1 < array1.Length - 1;)
			{

				int pointer2 = pointer1 + 1;
				
				if (array1[pointer1] > array1[pointer2])
				{
					int temp = array1[pointer1];
					array1[pointer1] = array1[pointer2];
					array1[pointer2] = temp;
					pointer1 = 0;
				}
				
				else
				{
					pointer1++;
				}
								
			}
			foreach (int val in array1)
			{
				Console.WriteLine(val);
			}

		}

		
	}
}
