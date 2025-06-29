namespace System.IO.Compression;

internal class GZipDecoder : IFileFormatReader
{
	internal enum GzipHeaderState
	{
		ReadingID1,
		ReadingID2,
		ReadingCM,
		ReadingFLG,
		ReadingMMTime,
		ReadingXFL,
		ReadingOS,
		ReadingXLen1,
		ReadingXLen2,
		ReadingXLenData,
		ReadingFileName,
		ReadingComment,
		ReadingCRC16Part1,
		ReadingCRC16Part2,
		Done,
		ReadingCRC,
		ReadingFileSize
	}

	[Flags]
	internal enum GZipOptionalHeaderFlags
	{
		CRCFlag = 2,
		ExtraFieldsFlag = 4,
		FileNameFlag = 8,
		CommentFlag = 0x10
	}

	private GzipHeaderState gzipHeaderSubstate;

	private GzipHeaderState gzipFooterSubstate;

	private int gzip_header_flag;

	private int gzip_header_xlen;

	private uint expectedCrc32;

	private uint expectedOutputStreamSizeModulo;

	private int loopCounter;

	private uint actualCrc32;

	private long actualStreamSizeModulo;

	public GZipDecoder()
	{
		Reset();
	}

	public void Reset()
	{
		gzipHeaderSubstate = GzipHeaderState.ReadingID1;
		gzipFooterSubstate = GzipHeaderState.ReadingCRC;
		expectedCrc32 = 0u;
		expectedOutputStreamSizeModulo = 0u;
	}

	public bool ReadHeader(InputBuffer input)
	{
		switch (gzipHeaderSubstate)
		{
		case GzipHeaderState.ReadingID1:
		{
			int bits = input.GetBits(8);
			if (bits < 0)
			{
				return false;
			}
			if (bits != 31)
			{
				throw new InvalidDataException(SR.GetString("CorruptedGZipHeader"));
			}
			gzipHeaderSubstate = GzipHeaderState.ReadingID2;
			goto case GzipHeaderState.ReadingID2;
		}
		case GzipHeaderState.ReadingID2:
		{
			int bits = input.GetBits(8);
			if (bits < 0)
			{
				return false;
			}
			if (bits != 139)
			{
				throw new InvalidDataException(SR.GetString("CorruptedGZipHeader"));
			}
			gzipHeaderSubstate = GzipHeaderState.ReadingCM;
			goto case GzipHeaderState.ReadingCM;
		}
		case GzipHeaderState.ReadingCM:
		{
			int bits = input.GetBits(8);
			if (bits < 0)
			{
				return false;
			}
			if (bits != 8)
			{
				throw new InvalidDataException(SR.GetString("UnknownCompressionMode"));
			}
			gzipHeaderSubstate = GzipHeaderState.ReadingFLG;
			goto case GzipHeaderState.ReadingFLG;
		}
		case GzipHeaderState.ReadingFLG:
		{
			int bits = input.GetBits(8);
			if (bits < 0)
			{
				return false;
			}
			gzip_header_flag = bits;
			gzipHeaderSubstate = GzipHeaderState.ReadingMMTime;
			loopCounter = 0;
			goto case GzipHeaderState.ReadingMMTime;
		}
		case GzipHeaderState.ReadingMMTime:
		{
			int bits = 0;
			while (loopCounter < 4)
			{
				bits = input.GetBits(8);
				if (bits < 0)
				{
					return false;
				}
				loopCounter++;
			}
			gzipHeaderSubstate = GzipHeaderState.ReadingXFL;
			loopCounter = 0;
			goto case GzipHeaderState.ReadingXFL;
		}
		case GzipHeaderState.ReadingXFL:
		{
			int bits = input.GetBits(8);
			if (bits < 0)
			{
				return false;
			}
			gzipHeaderSubstate = GzipHeaderState.ReadingOS;
			goto case GzipHeaderState.ReadingOS;
		}
		case GzipHeaderState.ReadingOS:
		{
			int bits = input.GetBits(8);
			if (bits < 0)
			{
				return false;
			}
			gzipHeaderSubstate = GzipHeaderState.ReadingXLen1;
			goto case GzipHeaderState.ReadingXLen1;
		}
		case GzipHeaderState.ReadingXLen1:
			if ((gzip_header_flag & 4) != 0)
			{
				int bits = input.GetBits(8);
				if (bits < 0)
				{
					return false;
				}
				gzip_header_xlen = bits;
				gzipHeaderSubstate = GzipHeaderState.ReadingXLen2;
				goto case GzipHeaderState.ReadingXLen2;
			}
			goto case GzipHeaderState.ReadingFileName;
		case GzipHeaderState.ReadingXLen2:
		{
			int bits = input.GetBits(8);
			if (bits < 0)
			{
				return false;
			}
			gzip_header_xlen |= bits << 8;
			gzipHeaderSubstate = GzipHeaderState.ReadingXLenData;
			loopCounter = 0;
			goto case GzipHeaderState.ReadingXLenData;
		}
		case GzipHeaderState.ReadingXLenData:
		{
			int bits = 0;
			while (loopCounter < gzip_header_xlen)
			{
				bits = input.GetBits(8);
				if (bits < 0)
				{
					return false;
				}
				loopCounter++;
			}
			gzipHeaderSubstate = GzipHeaderState.ReadingFileName;
			loopCounter = 0;
			goto case GzipHeaderState.ReadingFileName;
		}
		case GzipHeaderState.ReadingFileName:
			if ((gzip_header_flag & 8) == 0)
			{
				gzipHeaderSubstate = GzipHeaderState.ReadingComment;
			}
			else
			{
				int bits;
				do
				{
					bits = input.GetBits(8);
					if (bits < 0)
					{
						return false;
					}
				}
				while (bits != 0);
				gzipHeaderSubstate = GzipHeaderState.ReadingComment;
			}
			goto case GzipHeaderState.ReadingComment;
		case GzipHeaderState.ReadingComment:
			if ((gzip_header_flag & 0x10) == 0)
			{
				gzipHeaderSubstate = GzipHeaderState.ReadingCRC16Part1;
			}
			else
			{
				int bits;
				do
				{
					bits = input.GetBits(8);
					if (bits < 0)
					{
						return false;
					}
				}
				while (bits != 0);
				gzipHeaderSubstate = GzipHeaderState.ReadingCRC16Part1;
			}
			goto case GzipHeaderState.ReadingCRC16Part1;
		case GzipHeaderState.ReadingCRC16Part1:
		{
			if ((gzip_header_flag & 2) == 0)
			{
				gzipHeaderSubstate = GzipHeaderState.Done;
				goto case GzipHeaderState.Done;
			}
			int bits = input.GetBits(8);
			if (bits < 0)
			{
				return false;
			}
			gzipHeaderSubstate = GzipHeaderState.ReadingCRC16Part2;
			goto case GzipHeaderState.ReadingCRC16Part2;
		}
		case GzipHeaderState.ReadingCRC16Part2:
		{
			int bits = input.GetBits(8);
			if (bits < 0)
			{
				return false;
			}
			gzipHeaderSubstate = GzipHeaderState.Done;
			goto case GzipHeaderState.Done;
		}
		case GzipHeaderState.Done:
			return true;
		default:
			throw new InvalidDataException(SR.GetString("UnknownState"));
		}
	}

	public bool ReadFooter(InputBuffer input)
	{
		input.SkipToByteBoundary();
		if (gzipFooterSubstate == GzipHeaderState.ReadingCRC)
		{
			while (loopCounter < 4)
			{
				int bits = input.GetBits(8);
				if (bits < 0)
				{
					return false;
				}
				expectedCrc32 |= (uint)(bits << 8 * loopCounter);
				loopCounter++;
			}
			gzipFooterSubstate = GzipHeaderState.ReadingFileSize;
			loopCounter = 0;
		}
		if (gzipFooterSubstate == GzipHeaderState.ReadingFileSize)
		{
			if (loopCounter == 0)
			{
				expectedOutputStreamSizeModulo = 0u;
			}
			while (loopCounter < 4)
			{
				int bits2 = input.GetBits(8);
				if (bits2 < 0)
				{
					return false;
				}
				expectedOutputStreamSizeModulo |= (uint)(bits2 << 8 * loopCounter);
				loopCounter++;
			}
		}
		return true;
	}

	public void UpdateWithBytesRead(byte[] buffer, int offset, int copied)
	{
		actualCrc32 = Crc32Helper.UpdateCrc32(actualCrc32, buffer, offset, copied);
		long num = actualStreamSizeModulo + (uint)copied;
		if (num >= 4294967296L)
		{
			num %= 4294967296L;
		}
		actualStreamSizeModulo = num;
	}

	public void Validate()
	{
		if (expectedCrc32 != actualCrc32)
		{
			throw new InvalidDataException(SR.GetString("InvalidCRC"));
		}
		if (actualStreamSizeModulo != expectedOutputStreamSizeModulo)
		{
			throw new InvalidDataException(SR.GetString("InvalidStreamSize"));
		}
	}
}
