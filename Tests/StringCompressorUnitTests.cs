using CleverenseSoftTest;
using System;
using System.Linq;

namespace Tests
{
	[TestClass]
	public class StringCompressorUnitTests
	{
		[TestMethod]
		public void StringCompressTest1()
		{
			//arrange
			string initString = "aabbccc";
			string expectedCompressedString = "a2b2c3";
			//act
			string actualCompressedString = StringCompressor.Compress(initString);
			//assert
			Assert.IsTrue(expectedCompressedString.Equals(actualCompressedString));
		}
		[TestMethod]
		public void StringCompressTest2()
		{
			//arrange
			string initString = "abbbbbbbbbbbb";
			string expectedCompressedString = "ab12";
			//act
			string actualCompressedString = StringCompressor.Compress(initString);
			//assert
			Assert.IsTrue(expectedCompressedString.Equals(actualCompressedString));
		}
		[TestMethod]
		public void StringDecompressTest1()
		{
			//arrange
			string initString = "a2b2c3";
			string expectedDecompressedString = "aabbccc";
			//act
			string actualDecompressedString = StringCompressor.Decompress(initString);
			//assert
			Assert.IsTrue(expectedDecompressedString.Equals(actualDecompressedString));
		}
		[TestMethod]
		public void StringDecompressTest2()
		{
			//arrange
			string initString = "ab12";
			string expectedDecompressedString = "abbbbbbbbbbbb";
			//act
			string actualDecompressedString = StringCompressor.Decompress(initString);
			//assert
			Assert.IsTrue(expectedDecompressedString.Equals(actualDecompressedString));
		}
	}
}