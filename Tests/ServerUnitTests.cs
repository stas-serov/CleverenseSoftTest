using CleverenseSoftTest;
using System.Threading;

namespace Tests
{
	[TestClass]
	public class ServerUnitTests
	{
		[TestMethod]
		public void ParallelServerAccessTest()
		{
			Thread[] threads = new Thread[10];
			for (int i = 0; i < 10; i++)
			{
				threads[i] = new Thread(() =>
				{
					Server.GetCount();
					Server.AddToCount(i);
				});
				threads[i].Name = $"Поток №{i}";
			}
			foreach (Thread thread in threads)
			{
				thread.Start();
			}
		}
	}
}