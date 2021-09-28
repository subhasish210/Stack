using System;
using System.Collections.Generic;
using System.Text;

namespace StackNQueue
{
    class Queuedelete
    {
		public static void Main(String[] args)
		{
			
			Queuedelete s = new Queuedelete();

			s.enQueue(56);
			s.enQueue(30);
			s.enQueue(70);

			s.display();
			Console.WriteLine("------------");
			s.deQueue();

		}

		int[] queue = new int[3];
		int rear;

		public void enQueue(int d)
		{
			queue[rear] = d;
			rear++;
		}
		public void deQueue()
		{
			for (int front = 0; front < rear; front++)
			{
				int data = queue[front];
				Console.WriteLine(data);
			}
		}
		public void display()
		{
			foreach (int n in queue)
			{
				Console.WriteLine(n);
			}
		}
	}
}
