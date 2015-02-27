using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;


public class GridGenerator
{
	public int generate(int[] row, int[] col)
	{
		int [,] grid = new int [row.Length,col.Length];


		for (int j = 0; j < col.Length; j++)
			{
				grid[0,j] = row[j];
			}


		for (int i = 1; i < row.Length; i++)
			{
			    grid[i , 0] = col[i];
			}

		for (int i = 0; i < row.Length; i++)
		{
			for (int j = 1; j < col.Length; j++)
			{

				int left=0 , upper=0 , upperleft = 0;

				if (j !=0)
				{
					left = grid[i,j-1];

				}

                if (i !=0)
	            {
		             upper = grid[i-1 , j];
	            }

                if (i !=0 && j!=0)
	            {
		             upperleft = grid[i-1, j-1];
	            }
                grid[i,j] = left + upper + upperleft;
			}
		}
		return grid[row.Length - 1 , col.Length - 1];
	}

	// BEGIN KAWIGIEDIT TESTING
	// Generated by KawigiEdit 2.1.4 (beta) modified by pivanof
	#region Testing code generated by KawigiEdit
	[STAThread]
	private static Boolean KawigiEdit_RunTest(int testNum, int[] p0, int[] p1, Boolean hasAnswer, int p2) {
		Debug.Write("Test " + testNum + ": [" + "{");
		for (int i = 0; p0.Length > i; ++i) {
			if (i > 0) {
				Debug.Write(",");
			}
			Debug.Write(p0[i]);
		}
		Debug.Write("}" + "," + "{");
		for (int i = 0; p1.Length > i; ++i) {
			if (i > 0) {
				Debug.Write(",");
			}
			Debug.Write(p1[i]);
		}
		Debug.Write("}");
		Debug.WriteLine("]");
		GridGenerator obj;
		int answer;
		obj = new GridGenerator();
		DateTime startTime = DateTime.Now;
		answer = obj.generate(p0, p1);
		DateTime endTime = DateTime.Now;
		Boolean res;
		res = true;
		Debug.WriteLine("Time: " + (endTime - startTime).TotalSeconds + " seconds");
		if (hasAnswer) {
			Debug.WriteLine("Desired answer:");
			Debug.WriteLine("\t" + p2);
		}
		Debug.WriteLine("Your answer:");
		Debug.WriteLine("\t" + answer);
		if (hasAnswer) {
			res = answer == p2;
		}
		if (!res) {
			Debug.WriteLine("DOESN'T MATCH!!!!");
		} else if ((endTime - startTime).TotalSeconds >= 2) {
			Debug.WriteLine("FAIL the timeout");
			res = false;
		} else if (hasAnswer) {
			Debug.WriteLine("Match :-)");
		} else {
			Debug.WriteLine("OK, but is it right?");
		}
		Debug.WriteLine("");
		return res;
	}
	public static void Main(string[] args) {
		Boolean all_right;
		all_right = true;
		
		int[] p0;
		int[] p1;
		int p2;
		
		// ----- test 0 -----
		p0 = new int[]{1,0,3,4,1};
		p1 = new int[]{1,4,1,0,3};
		p2 = 579;
		all_right = KawigiEdit_RunTest(0, p0, p1, true, p2) && all_right;
		// ------------------
		
		// ----- test 1 -----
		p0 = new int[]{9,9,9,9,9,9,9,9,9,9};
		p1 = new int[]{9,9,9,9,9,9,9,9,9,9};
		p2 = 13163067;
		all_right = KawigiEdit_RunTest(1, p0, p1, true, p2) && all_right;
		// ------------------
		
		// ----- test 2 -----
		p0 = new int[]{0,0,0,0,0,0,0,0,0};
		p1 = new int[]{0,0,0,0,0,0,0,0,0};
		p2 = 0;
		all_right = KawigiEdit_RunTest(2, p0, p1, true, p2) && all_right;
		// ------------------
		
		if (all_right) {
			Debug.WriteLine("You're a stud (at least on the example cases)!");
		} else {
			Debug.WriteLine("Some of the test cases had errors.");
		}
	}
	#endregion
	// END KAWIGIEDIT TESTING
}
//Powered by KawigiEdit 2.1.4 (beta) modified by pivanof!
