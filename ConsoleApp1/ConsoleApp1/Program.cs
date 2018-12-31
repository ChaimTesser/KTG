using System;
using System.Collections.Generic;

class Solution
	{
		static int solution(int[] A)
		{
		int MinNum = 0;
		if (IsSorted(A))
		{
			return 0;
		}
		for (int i = 0; i < A.Length; i++)
		{
			List<int> SortNeeded = new List<int>();
			if (i + 1 < A.Length)
			{
				if (A[i] > A[i + 1])
				{
					int Length;
					if (i == 0)
						Length = A.Length - 1;
					else
						Length = A.Length - i;
					SortNeeded.Add(A[i]);
					for (int x = i + 1; x < Length; x++)
					{

						if (A[x] > A[x + 1] || A[x] == A[x+1])
						{
							if (A[x + 1] != A[x + 2] && A[x + 1] < A[x + 2])
							{
								SortNeeded.Add(A[x]);
								SortNeeded.Add(A[x + 1]);

							}
							else
								SortNeeded.Add(A[x]);
						}
					}

					return SortNeeded.Count;
				}
			}
		}
		return MinNum;
	}

	public static bool IsSorted(int[] sort)
	{
		for (int i = 1; i < sort.Length; i++)
		{
			if (sort[i - 1] > sort[i])
			{
				return false;
			}
		}
		return true;
	}
	static void Main()
	{
		int[] b = { 1,2,6,5,5,5,9 };
		Console.WriteLine(solution(b));
	}
	}


