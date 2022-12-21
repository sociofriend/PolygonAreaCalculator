using System;
namespace Homework_1
{
	internal class Polygon
	{
		public int AreaFinder(int n)
		{

			int middleRowArea = 2 * n - 1;
			int totalArea = middleRowArea;

			if (n == 0)
				{
					return n;
				}
			else if (n < 0)
			{
				Console.WriteLine("a positive sign intereger is required");
			}
			else
			{
				while (2 * n - 1 != 0)
				{

					n--;
					if (n != 0)
					{
						int nextRowsArea = 2 * (2 * n - 1);
						totalArea += nextRowsArea;
					}

					else
						return totalArea;
				}
            }

            return totalArea;


        }
		
	}
}

