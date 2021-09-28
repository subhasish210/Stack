using System;
using System.Collections.Generic;
using System.Text;

namespace StackNQueue
{
    class UC1_StackCreate
    {
			public static void Main(String[] args)
			{

				UC1_StackCreate s1 = new UC1_StackCreate();
				s1.push(70);
				s1.push(30);
				s1.push(56);

				s1.display();
			}

			int[] stack = new int[3];
			int top = 0;

			public void push(int d)
			{
				stack[top] = d;
				top++;
			}

			public void display()
			{
				foreach(int n in stack)
				{
					Console.WriteLine(n);
				}
			}

	}
}
