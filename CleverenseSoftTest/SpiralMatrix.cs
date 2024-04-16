namespace CleverenseSoftTest
{
	public static class SpiralMatrix
	{
		public static int[] SpiralOrderCounterclockwise(int[,] matrix)
		{
			int topBoundary = 0;
			int bottomBoundary = matrix.GetLength(0) - 1;
			int leftBoundary = 0;
			int rightBoundary = matrix.GetLength(1) - 1;
			int counter = 0;
			int[] result = new int[matrix.GetLength(0) * matrix.GetLength(1)];
			while (true)
			{
				if (topBoundary > bottomBoundary)
				{
					break;
				}
				for (int i = topBoundary; i <= bottomBoundary; i++)
				{
					result[counter++] = matrix[i, leftBoundary];
				}
				leftBoundary++;
				if (leftBoundary > rightBoundary)
				{
					break;
				}
				for (int i = leftBoundary; i <= rightBoundary; i++)
				{
					result[counter++] = matrix[bottomBoundary, i];
				}
				bottomBoundary--;
				if (topBoundary > bottomBoundary)
				{
					break;
				}
				for (int i = bottomBoundary; i >= topBoundary; i--)
				{
					result[counter++] = matrix[i, rightBoundary];
				}
				rightBoundary--;
				if (leftBoundary > rightBoundary)
				{
					break;
				}
				for (int i = rightBoundary; i >= leftBoundary; i--)
				{
					result[counter++] = matrix[topBoundary, i];
				}
				topBoundary++;
			}
			return result;
		}
		public static int[] SpiralOrderClockwise(int[,] matrix)
		{
			int topBoundary = 0;
			int bottomBoundary = matrix.GetLength(0) - 1;
			int leftBoundary = 0;
			int rightBoundary = matrix.GetLength(1) - 1;
			int counter = 0;
			int[] result = new int[matrix.GetLength(0) * matrix.GetLength(1)];
			while (true)
			{
				if (leftBoundary > rightBoundary)
				{
					break;
				}
				for (int i = leftBoundary; i <= rightBoundary; i++)
				{
					result[counter++] = matrix[topBoundary,i];
				}
				topBoundary++;
				if (topBoundary > bottomBoundary)
				{
					break;
				}
				for (int i = topBoundary; i <= bottomBoundary; i++)
				{
					result[counter++] = matrix[i,rightBoundary];
				}
				rightBoundary--;
				if (leftBoundary > rightBoundary)
				{
					break;
				}
				for (int i = rightBoundary; i >= leftBoundary; i--)
				{
					result[counter++] = matrix[bottomBoundary,i];
				}
				bottomBoundary--;
				if (topBoundary > bottomBoundary)
				{
					break;
				}
				for (int i = bottomBoundary; i >= topBoundary; i--)
				{
					result[counter++] = matrix[i,leftBoundary];
				}
				leftBoundary++;
			}
			return result;
		}
	}
}
