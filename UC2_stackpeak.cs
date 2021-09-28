using System;
using System.Collections.Generic;
using System.Text;

namespace StackNQueue
{
    class UC2_stackpeak
    {
			public static void Main(String[] args)
			{
				UC2_stackpeak s1 = new UC2_stackpeak();
				s1.push(70);
				s1.push(30);
				s1.push(56);
				s1.peek();
				s1.display();
				Console.WriteLine("----------");
				s1.pop();
				Console.WriteLine("----------");
				s1.display();
				Console.WriteLine("----------");
				s1.peek();
				s1.display();
			}

			int[] stack = new int[3];
			int top = 0;

			public void push(int d)
			{
				stack[top] = d;
				top++;
			}

			public void peek()
			{
				int data = stack[top - 1];
				Console.WriteLine(data);
			}
			public void pop()
			{
				for (int i = top - 1; i >= 0; --i)
				{
					int data = stack[i];
					stack[i] = 0;
					Console.WriteLine(data);
				}
			}
			public void display()
			{
				foreach (int n in stack)
				{
					Console.WriteLine(n);
				}
			}
		}
}
