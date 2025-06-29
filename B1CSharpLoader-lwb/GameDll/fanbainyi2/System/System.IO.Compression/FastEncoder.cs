namespace System.IO.Compression;

internal class FastEncoder
{
	private FastEncoderWindow inputWindow;

	private Match currentMatch;

	private double lastCompressionRatio;

	internal int BytesInHistory => inputWindow.BytesAvailable;

	internal DeflateInput UnprocessedInput => inputWindow.UnprocessedInput;

	internal double LastCompressionRatio => lastCompressionRatio;

	public FastEncoder()
	{
		inputWindow = new FastEncoderWindow();
		currentMatch = new Match();
	}

	internal void FlushInput()
	{
		inputWindow.FlushWindow();
	}

	internal void GetBlock(DeflateInput input, OutputBuffer output, int maxBytesToCopy)
	{
		WriteDeflatePreamble(output);
		GetCompressedOutput(input, output, maxBytesToCopy);
		WriteEndOfBlock(output);
	}

	internal void GetCompressedData(DeflateInput input, OutputBuffer output)
	{
		GetCompressedOutput(input, output, -1);
	}

	internal void GetBlockHeader(OutputBuffer output)
	{
		WriteDeflatePreamble(output);
	}

	internal void GetBlockFooter(OutputBuffer output)
	{
		WriteEndOfBlock(output);
	}

	private void GetCompressedOutput(DeflateInput input, OutputBuffer output, int maxBytesToCopy)
	{
		int bytesWritten = output.BytesWritten;
		int num = 0;
		int num2 = BytesInHistory + input.Count;
		do
		{
			int num3 = ((input.Count < inputWindow.FreeWindowSpace) ? input.Count : inputWindow.FreeWindowSpace);
			if (maxBytesToCopy >= 1)
			{
				num3 = Math.Min(num3, maxBytesToCopy - num);
			}
			if (num3 > 0)
			{
				inputWindow.CopyBytes(input.Buffer, input.StartIndex, num3);
				input.ConsumeBytes(num3);
				num += num3;
			}
			GetCompressedOutput(output);
		}
		while (SafeToWriteTo(output) && InputAvailable(input) && (maxBytesToCopy < 1 || num < maxBytesToCopy));
		int bytesWritten2 = output.BytesWritten;
		int num4 = bytesWritten2 - bytesWritten;
		int num5 = BytesInHistory + input.Count;
		int num6 = num2 - num5;
		if (num4 != 0)
		{
			lastCompressionRatio = (double)num4 / (double)num6;
		}
	}

	private void GetCompressedOutput(OutputBuffer output)
	{
		while (inputWindow.BytesAvailable > 0 && SafeToWriteTo(output))
		{
			inputWindow.GetNextSymbolOrMatch(currentMatch);
			if (currentMatch.State == MatchState.HasSymbol)
			{
				WriteChar(currentMatch.Symbol, output);
				continue;
			}
			if (currentMatch.State == MatchState.HasMatch)
			{
				WriteMatch(currentMatch.Length, currentMatch.Position, output);
				continue;
			}
			WriteChar(currentMatch.Symbol, output);
			WriteMatch(currentMatch.Length, currentMatch.Position, output);
		}
	}

	private bool InputAvailable(DeflateInput input)
	{
		if (input.Count <= 0)
		{
			return BytesInHistory > 0;
		}
		return true;
	}

	private bool SafeToWriteTo(OutputBuffer output)
	{
		return output.FreeBytes > 16;
	}

	private void WriteEndOfBlock(OutputBuffer output)
	{
		uint num = FastEncoderStatics.FastEncoderLiteralCodeInfo[256];
		int n = (int)(num & 0x1F);
		output.WriteBits(n, num >> 5);
	}

	internal static void WriteMatch(int matchLen, int matchPos, OutputBuffer output)
	{
		uint num = FastEncoderStatics.FastEncoderLiteralCodeInfo[254 + matchLen];
		int num2 = (int)(num & 0x1F);
		if (num2 <= 16)
		{
			output.WriteBits(num2, num >> 5);
		}
		else
		{
			output.WriteBits(16, (num >> 5) & 0xFFFF);
			output.WriteBits(num2 - 16, num >> 21);
		}
		num = FastEncoderStatics.FastEncoderDistanceCodeInfo[FastEncoderStatics.GetSlot(matchPos)];
		output.WriteBits((int)(num & 0xF), num >> 8);
		int num3 = (int)((num >> 4) & 0xF);
		if (num3 != 0)
		{
			output.WriteBits(num3, (uint)matchPos & FastEncoderStatics.BitMask[num3]);
		}
	}

	internal static void WriteChar(byte b, OutputBuffer output)
	{
		uint num = FastEncoderStatics.FastEncoderLiteralCodeInfo[b];
		output.WriteBits((int)(num & 0x1F), num >> 5);
	}

	internal static void WriteDeflatePreamble(OutputBuffer output)
	{
		output.WriteBytes(FastEncoderStatics.FastEncoderTreeStructureData, 0, FastEncoderStatics.FastEncoderTreeStructureData.Length);
		output.WriteBits(9, 34u);
	}
}
