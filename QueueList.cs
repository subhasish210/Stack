using System;
using System.Collections.Generic;
using System.Text;

namespace StackNQueue
{
    class QueueList
    {
		public static void Main(String[] args)
		{
			
			QueueList s = new QueueList();

			s.enQueue(56);
			s.enQueue(30);
			s.enQueue(70);

			s.display();

		}

		int[] queue = new int[3];
		int rear;
		public void enQueue(int d)
		{
			queue[rear] = d;
			rear++;
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
