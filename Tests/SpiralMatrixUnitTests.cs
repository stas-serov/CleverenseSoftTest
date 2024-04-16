using CleverenseSoftTest;
using System.Linq;

namespace Tests
{
	[TestClass]
	public class SpiralMatrixUnitTests
	{
		[TestMethod]
		public void Clockwise3x3Test()
		{
			//arrange
			int[,] initMatrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
			int[] expectedArray = new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
			//act
			int[] actualArray = SpiralMatrix.SpiralOrderClockwise(initMatrix);
			//assert
			Assert.IsTrue(expectedArray.SequenceEqual(actualArray));
		}
		[TestMethod]
		public void Clockwise3x4Test()
		{
			//arrange
			int[,] initMatrix = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
			int[] expectedArray = new int[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };
			//act
			int[] actualArray = SpiralMatrix.SpiralOrderClockwise(initMatrix);
			//assert
			Assert.IsTrue(expectedArray.SequenceEqual(actualArray));
		}
		[TestMethod]
		public void Counterclockwise3x3Test()
		{
			//arrange
			int[,] initMatrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
			int[] expectedArray = new int[] { 1, 4, 7, 8, 9, 6, 3, 2, 5 };
			//act
			int[] actualArray = SpiralMatrix.SpiralOrderCounterclockwise(initMatrix);
			//assert
			Assert.IsTrue(expectedArray.SequenceEqual(actualArray));
		}
		[TestMethod]
		public void Counterclockwise3x4Test()
		{
			//arrange
			int[,] initMatrix = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
			int[] expectedArray = new int[] { 1, 5, 9, 10, 11, 12, 8, 4, 3, 2, 6, 7 };
			//act
			int[] actualArray = SpiralMatrix.SpiralOrderCounterclockwise(initMatrix);
			//assert
			Assert.IsTrue(expectedArray.SequenceEqual(actualArray));
		}
	}
}