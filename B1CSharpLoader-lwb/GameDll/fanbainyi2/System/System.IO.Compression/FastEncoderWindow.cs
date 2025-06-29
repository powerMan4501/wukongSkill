using System.Diagnostics;

namespace System.IO.Compression;

internal class FastEncoderWindow
{
	private byte[] window;

	private int bufPos;

	private int bufEnd;

	private const int FastEncoderHashShift = 4;

	private const int FastEncoderHashtableSize = 2048;

	private const int FastEncoderHashMask = 2047;

	private const int FastEncoderWindowSize = 8192;

	private const int FastEncoderWindowMask = 8191;

	private const int FastEncoderMatch3DistThreshold = 16384;

	internal const int MaxMatch = 258;

	internal const int MinMatch = 3;

	private const int SearchDepth = 32;

	private const int GoodLength = 4;

	private const int NiceLength = 32;

	private const int LazyMatchThreshold = 6;

	private ushort[] prev;

	private ushort[] lookup;

	public int BytesAvailable => bufEnd - bufPos;

	public DeflateInput UnprocessedInput
	{
		get
		{
			DeflateInput deflateInput = new DeflateInput();
			deflateInput.Buffer = window;
			deflateInput.StartIndex = bufPos;
			deflateInput.Count = bufEnd - bufPos;
			return deflateInput;
		}
	}

	public int FreeWindowSpace => 16384 - bufEnd;

	public FastEncoderWindow()
	{
		ResetWindow();
	}

	public void FlushWindow()
	{
		ResetWindow();
	}

	private void ResetWindow()
	{
		window = new byte[16646];
		prev = new ushort[8450];
		lookup = new ushort[2048];
		bufPos = 8192;
		bufEnd = bufPos;
	}

	public void CopyBytes(byte[] inputBuffer, int startIndex, int count)
	{
		Array.Copy(inputBuffer, startIndex, window, bufEnd, count);
		bufEnd += count;
	}

	public void MoveWindows()
	{
		Array.Copy(window, bufPos - 8192, window, 0, 8192);
		for (int i = 0; i < 2048; i++)
		{
			int num = lookup[i] - 8192;
			if (num <= 0)
			{
				lookup[i] = 0;
			}
			else
			{
				lookup[i] = (ushort)num;
			}
		}
		for (int i = 0; i < 8192; i++)
		{
			long num2 = (long)prev[i] - 8192L;
			if (num2 <= 0)
			{
				prev[i] = 0;
			}
			else
			{
				prev[i] = (ushort)num2;
			}
		}
		bufPos = 8192;
		bufEnd = bufPos;
	}

	private uint HashValue(uint hash, byte b)
	{
		return (hash << 4) ^ b;
	}

	private uint InsertString(ref uint hash)
	{
		hash = HashValue(hash, window[bufPos + 2]);
		uint num = lookup[hash & 0x7FF];
		lookup[hash & 0x7FF] = (ushort)bufPos;
		prev[bufPos & 0x1FFF] = (ushort)num;
		return num;
	}

	private void InsertStrings(ref uint hash, int matchLen)
	{
		if (bufEnd - bufPos <= matchLen)
		{
			bufPos += matchLen - 1;
			return;
		}
		while (--matchLen > 0)
		{
			InsertString(ref hash);
			bufPos++;
		}
	}

	internal bool GetNextSymbolOrMatch(Match match)
	{
		uint hash = HashValue(0u, window[bufPos]);
		hash = HashValue(hash, window[bufPos + 1]);
		int matchPos = 0;
		int num;
		if (bufEnd - bufPos <= 3)
		{
			num = 0;
		}
		else
		{
			int num2 = (int)InsertString(ref hash);
			if (num2 != 0)
			{
				num = FindMatch(num2, out matchPos, 32, 32);
				if (bufPos + num > bufEnd)
				{
					num = bufEnd - bufPos;
				}
			}
			else
			{
				num = 0;
			}
		}
		if (num < 3)
		{
			match.State = MatchState.HasSymbol;
			match.Symbol = window[bufPos];
			bufPos++;
		}
		else
		{
			bufPos++;
			if (num <= 6)
			{
				int matchPos2 = 0;
				int num3 = (int)InsertString(ref hash);
				int num4;
				if (num3 != 0)
				{
					num4 = FindMatch(num3, out matchPos2, (num < 4) ? 32 : 8, 32);
					if (bufPos + num4 > bufEnd)
					{
						num4 = bufEnd - bufPos;
					}
				}
				else
				{
					num4 = 0;
				}
				if (num4 > num)
				{
					match.State = MatchState.HasSymbolAndMatch;
					match.Symbol = window[bufPos - 1];
					match.Position = matchPos2;
					match.Length = num4;
					bufPos++;
					num = num4;
					InsertStrings(ref hash, num);
				}
				else
				{
					match.State = MatchState.HasMatch;
					match.Position = matchPos;
					match.Length = num;
					num--;
					bufPos++;
					InsertStrings(ref hash, num);
				}
			}
			else
			{
				match.State = MatchState.HasMatch;
				match.Position = matchPos;
				match.Length = num;
				InsertStrings(ref hash, num);
			}
		}
		if (bufPos == 16384)
		{
			MoveWindows();
		}
		return true;
	}

	private int FindMatch(int search, out int matchPos, int searchDepth, int niceLength)
	{
		int num = 0;
		int num2 = 0;
		int num3 = bufPos - 8192;
		byte b = window[bufPos];
		while (search > num3)
		{
			if (window[search + num] == b)
			{
				int i;
				for (i = 0; i < 258 && window[bufPos + i] == window[search + i]; i++)
				{
				}
				if (i > num)
				{
					num = i;
					num2 = search;
					if (i > 32)
					{
						break;
					}
					b = window[bufPos + i];
				}
			}
			if (--searchDepth == 0)
			{
				break;
			}
			search = prev[search & 0x1FFF];
		}
		matchPos = bufPos - num2 - 1;
		if (num == 3 && matchPos >= 16384)
		{
			return 0;
		}
		return num;
	}

	[Conditional("DEBUG")]
	private void VerifyHashes()
	{
		for (int i = 0; i < 2048; i++)
		{
			ushort num = lookup[i];
			while (num != 0 && bufPos - num < 8192)
			{
				ushort num2 = prev[num & 0x1FFF];
				if (bufPos - num2 >= 8192)
				{
					break;
				}
				num = num2;
			}
		}
	}

	private uint RecalculateHash(int position)
	{
		return (uint)(((window[position] << 8) ^ (window[position + 1] << 4) ^ window[position + 2]) & 0x7FF);
	}
}
