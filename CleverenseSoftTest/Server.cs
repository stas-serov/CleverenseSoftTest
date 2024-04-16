using System;
using System.Threading;

namespace CleverenseSoftTest
{
	public static class Server
	{
		private static int count;

		private static readonly object locker = new object();

		public static int GetCount()
		{
			lock (locker)
			{
				Console.WriteLine($"Поток {Thread.CurrentThread.Name} выполняет чтение переменной \"count\" сервера");
				Console.WriteLine($"Переменная \"count\" равна: {count}");
				return count;
			}
		}

		public static void AddToCount(int value)
		{
			lock (locker)
			{
				Console.WriteLine($"Поток {Thread.CurrentThread.Name} выполняет запись  в переменную \"count\" сервера");
				count += value;
				Console.WriteLine($"Переменная \"count\" равна: {count}");
			}
		}
	}
}