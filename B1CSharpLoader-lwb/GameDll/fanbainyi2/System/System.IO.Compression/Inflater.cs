namespace System.IO.Compression;

internal class Inflater : IInflater, IDisposable
{
	private static readonly byte[] extraLengthBits = new byte[29]
	{
		0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
		1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
		4, 4, 4, 4, 5, 5, 5, 5, 0
	};

	private static readonly int[] lengthBase = new int[29]
	{
		3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
		15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
		67, 83, 99, 115, 131, 163, 195, 227, 258
	};

	private static readonly int[] distanceBasePosition = new int[32]
	{
		1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
		33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
		1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577,
		0, 0
	};

	private static readonly byte[] codeOrder = new byte[19]
	{
		16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
		11, 4, 12, 3, 13, 2, 14, 1, 15
	};

	private static readonly byte[] staticDistanceTreeTable = new byte[32]
	{
		0, 16, 8, 24, 4, 20, 12, 28, 2, 18,
		10, 26, 6, 22, 14, 30, 1, 17, 9, 25,
		5, 21, 13, 29, 3, 19, 11, 27, 7, 23,
		15, 31
	};

	private OutputWindow output;

	private InputBuffer input;

	private HuffmanTree literalLengthTree;

	private HuffmanTree distanceTree;

	private InflaterState state;

	private bool hasFormatReader;

	private int bfinal;

	private BlockType blockType;

	private byte[] blockLengthBuffer = new byte[4];

	private int blockLength;

	private int length;

	private int distanceCode;

	private int extraBits;

	private int loopCounter;

	private int literalLengthCodeCount;

	private int distanceCodeCount;

	private int codeLengthCodeCount;

	private int codeArraySize;

	private int lengthCode;

	private byte[] codeList;

	private byte[] codeLengthTreeCodeLength;

	private HuffmanTree codeLengthTree;

	private IFileFormatReader formatReader;

	public int AvailableOutput => output.AvailableBytes;

	public Inflater()
		: this(null)
	{
	}

	internal Inflater(IFileFormatReader reader)
	{
		output = new OutputWindow();
		input = new InputBuffer();
		codeList = new byte[320];
		codeLengthTreeCodeLength = new byte[19];
		if (reader != null)
		{
			formatReader = reader;
			hasFormatReader = true;
		}
		Reset();
	}

	internal void SetFileFormatReader(IFileFormatReader reader)
	{
		formatReader = reader;
		hasFormatReader = true;
		Reset();
	}

	private void Reset()
	{
		if (hasFormatReader)
		{
			state = InflaterState.ReadingHeader;
		}
		else
		{
			state = InflaterState.ReadingBFinal;
		}
	}

	public void SetInput(byte[] inputBytes, int offset, int length)
	{
		input.SetInput(inputBytes, offset, length);
	}

	public bool Finished()
	{
		if (state != InflaterState.Done)
		{
			return state == InflaterState.VerifyingFooter;
		}
		return true;
	}

	public bool NeedsInput()
	{
		return input.NeedsInput();
	}

	public int Inflate(byte[] bytes, int offset, int length)
	{
		int num = 0;
		do
		{
			int num2 = output.CopyTo(bytes, offset, length);
			if (num2 > 0)
			{
				if (hasFormatReader)
				{
					formatReader.UpdateWithBytesRead(bytes, offset, num2);
				}
				offset += num2;
				num += num2;
				length -= num2;
			}
		}
		while (length != 0 && !Finished() && Decode());
		if (state == InflaterState.VerifyingFooter && output.AvailableBytes == 0)
		{
			formatReader.Validate();
		}
		return num;
	}

	private bool Decode()
	{
		bool end_of_block = false;
		bool flag = false;
		if (Finished())
		{
			return true;
		}
		if (hasFormatReader)
		{
			if (state == InflaterState.ReadingHeader)
			{
				if (!formatReader.ReadHeader(input))
				{
					return false;
				}
				state = InflaterState.ReadingBFinal;
			}
			else if (state == InflaterState.StartReadingFooter || state == InflaterState.ReadingFooter)
			{
				if (!formatReader.ReadFooter(input))
				{
					return false;
				}
				state = InflaterState.VerifyingFooter;
				return true;
			}
		}
		if (state == InflaterState.ReadingBFinal)
		{
			if (!input.EnsureBitsAvailable(1))
			{
				return false;
			}
			bfinal = input.GetBits(1);
			state = InflaterState.ReadingBType;
		}
		if (state == InflaterState.ReadingBType)
		{
			if (!input.EnsureBitsAvailable(2))
			{
				state = InflaterState.ReadingBType;
				return false;
			}
			blockType = (BlockType)input.GetBits(2);
			if (blockType == BlockType.Dynamic)
			{
				state = InflaterState.ReadingNumLitCodes;
			}
			else if (blockType == BlockType.Static)
			{
				literalLengthTree = HuffmanTree.StaticLiteralLengthTree;
				distanceTree = HuffmanTree.StaticDistanceTree;
				state = InflaterState.DecodeTop;
			}
			else
			{
				if (blockType != BlockType.Uncompressed)
				{
					throw new InvalidDataException(SR.GetString("UnknownBlockType"));
				}
				state = InflaterState.UncompressedAligning;
			}
		}
		if (blockType == BlockType.Dynamic)
		{
			flag = ((state >= InflaterState.DecodeTop) ? DecodeBlock(out end_of_block) : DecodeDynamicBlockHeader());
		}
		else if (blockType == BlockType.Static)
		{
			flag = DecodeBlock(out end_of_block);
		}
		else
		{
			if (blockType != BlockType.Uncompressed)
			{
				throw new InvalidDataException(SR.GetString("UnknownBlockType"));
			}
			flag = DecodeUncompressedBlock(out end_of_block);
		}
		if (end_of_block && bfinal != 0)
		{
			if (hasFormatReader)
			{
				state = InflaterState.StartReadingFooter;
			}
			else
			{
				state = InflaterState.Done;
			}
		}
		return flag;
	}

	private bool DecodeUncompressedBlock(out bool end_of_block)
	{
		end_of_block = false;
		while (true)
		{
			switch (state)
			{
			case InflaterState.UncompressedAligning:
				input.SkipToByteBoundary();
				state = InflaterState.UncompressedByte1;
				goto case InflaterState.UncompressedByte1;
			case InflaterState.UncompressedByte1:
			case InflaterState.UncompressedByte2:
			case InflaterState.UncompressedByte3:
			case InflaterState.UncompressedByte4:
			{
				int bits = input.GetBits(8);
				if (bits < 0)
				{
					return false;
				}
				blockLengthBuffer[(int)(state - 16)] = (byte)bits;
				if (state == InflaterState.UncompressedByte4)
				{
					blockLength = blockLengthBuffer[0] + blockLengthBuffer[1] * 256;
					int num2 = blockLengthBuffer[2] + blockLengthBuffer[3] * 256;
					if ((ushort)blockLength != (ushort)(~num2))
					{
						throw new InvalidDataException(SR.GetString("InvalidBlockLength"));
					}
				}
				break;
			}
			case InflaterState.DecodingUncompressed:
			{
				int num = output.CopyFrom(input, blockLength);
				blockLength -= num;
				if (blockLength == 0)
				{
					state = InflaterState.ReadingBFinal;
					end_of_block = true;
					return true;
				}
				if (output.FreeBytes == 0)
				{
					return true;
				}
				return false;
			}
			default:
				throw new InvalidDataException(SR.GetString("UnknownState"));
			}
			state++;
		}
	}

	private bool DecodeBlock(out bool end_of_block_code_seen)
	{
		end_of_block_code_seen = false;
		int num = output.FreeBytes;
		while (num > 258)
		{
			switch (state)
			{
			case InflaterState.DecodeTop:
			{
				int nextSymbol = literalLengthTree.GetNextSymbol(input);
				if (nextSymbol < 0)
				{
					return false;
				}
				if (nextSymbol < 256)
				{
					output.Write((byte)nextSymbol);
					num--;
					break;
				}
				if (nextSymbol == 256)
				{
					end_of_block_code_seen = true;
					state = InflaterState.ReadingBFinal;
					return true;
				}
				nextSymbol -= 257;
				if (nextSymbol < 8)
				{
					nextSymbol += 3;
					extraBits = 0;
				}
				else if (nextSymbol == 28)
				{
					nextSymbol = 258;
					extraBits = 0;
				}
				else
				{
					if (nextSymbol < 0 || nextSymbol >= extraLengthBits.Length)
					{
						throw new InvalidDataException(SR.GetString("GenericInvalidData"));
					}
					extraBits = extraLengthBits[nextSymbol];
				}
				length = nextSymbol;
				goto case InflaterState.HaveInitialLength;
			}
			case InflaterState.HaveInitialLength:
				if (extraBits > 0)
				{
					state = InflaterState.HaveInitialLength;
					int bits2 = input.GetBits(extraBits);
					if (bits2 < 0)
					{
						return false;
					}
					if (length < 0 || length >= lengthBase.Length)
					{
						throw new InvalidDataException(SR.GetString("GenericInvalidData"));
					}
					length = lengthBase[length] + bits2;
				}
				state = InflaterState.HaveFullLength;
				goto case InflaterState.HaveFullLength;
			case InflaterState.HaveFullLength:
				if (blockType == BlockType.Dynamic)
				{
					distanceCode = distanceTree.GetNextSymbol(input);
				}
				else
				{
					distanceCode = input.GetBits(5);
					if (distanceCode >= 0)
					{
						distanceCode = staticDistanceTreeTable[distanceCode];
					}
				}
				if (distanceCode < 0)
				{
					return false;
				}
				state = InflaterState.HaveDistCode;
				goto case InflaterState.HaveDistCode;
			case InflaterState.HaveDistCode:
			{
				int distance;
				if (distanceCode > 3)
				{
					extraBits = distanceCode - 2 >> 1;
					int bits = input.GetBits(extraBits);
					if (bits < 0)
					{
						return false;
					}
					distance = distanceBasePosition[distanceCode] + bits;
				}
				else
				{
					distance = distanceCode + 1;
				}
				output.WriteLengthDistance(length, distance);
				num -= length;
				state = InflaterState.DecodeTop;
				break;
			}
			default:
				throw new InvalidDataException(SR.GetString("UnknownState"));
			}
		}
		return true;
	}

	private bool DecodeDynamicBlockHeader()
	{
		switch (state)
		{
		case InflaterState.ReadingNumLitCodes:
			literalLengthCodeCount = input.GetBits(5);
			if (literalLengthCodeCount < 0)
			{
				return false;
			}
			literalLengthCodeCount += 257;
			state = InflaterState.ReadingNumDistCodes;
			goto case InflaterState.ReadingNumDistCodes;
		case InflaterState.ReadingNumDistCodes:
			distanceCodeCount = input.GetBits(5);
			if (distanceCodeCount < 0)
			{
				return false;
			}
			distanceCodeCount++;
			state = InflaterState.ReadingNumCodeLengthCodes;
			goto case InflaterState.ReadingNumCodeLengthCodes;
		case InflaterState.ReadingNumCodeLengthCodes:
			codeLengthCodeCount = input.GetBits(4);
			if (codeLengthCodeCount < 0)
			{
				return false;
			}
			codeLengthCodeCount += 4;
			loopCounter = 0;
			state = InflaterState.ReadingCodeLengthCodes;
			goto case InflaterState.ReadingCodeLengthCodes;
		case InflaterState.ReadingCodeLengthCodes:
		{
			while (loopCounter < codeLengthCodeCount)
			{
				int bits = input.GetBits(3);
				if (bits < 0)
				{
					return false;
				}
				codeLengthTreeCodeLength[codeOrder[loopCounter]] = (byte)bits;
				loopCounter++;
			}
			for (int l = codeLengthCodeCount; l < codeOrder.Length; l++)
			{
				codeLengthTreeCodeLength[codeOrder[l]] = 0;
			}
			codeLengthTree = new HuffmanTree(codeLengthTreeCodeLength);
			codeArraySize = literalLengthCodeCount + distanceCodeCount;
			loopCounter = 0;
			state = InflaterState.ReadingTreeCodesBefore;
			goto case InflaterState.ReadingTreeCodesBefore;
		}
		case InflaterState.ReadingTreeCodesBefore:
		case InflaterState.ReadingTreeCodesAfter:
		{
			while (loopCounter < codeArraySize)
			{
				if (state == InflaterState.ReadingTreeCodesBefore && (lengthCode = codeLengthTree.GetNextSymbol(input)) < 0)
				{
					return false;
				}
				if (lengthCode <= 15)
				{
					codeList[loopCounter++] = (byte)lengthCode;
				}
				else
				{
					if (!input.EnsureBitsAvailable(7))
					{
						state = InflaterState.ReadingTreeCodesAfter;
						return false;
					}
					if (lengthCode == 16)
					{
						if (loopCounter == 0)
						{
							throw new InvalidDataException();
						}
						byte b = codeList[loopCounter - 1];
						int num = input.GetBits(2) + 3;
						if (loopCounter + num > codeArraySize)
						{
							throw new InvalidDataException();
						}
						for (int i = 0; i < num; i++)
						{
							codeList[loopCounter++] = b;
						}
					}
					else if (lengthCode == 17)
					{
						int num = input.GetBits(3) + 3;
						if (loopCounter + num > codeArraySize)
						{
							throw new InvalidDataException();
						}
						for (int j = 0; j < num; j++)
						{
							codeList[loopCounter++] = 0;
						}
					}
					else
					{
						int num = input.GetBits(7) + 11;
						if (loopCounter + num > codeArraySize)
						{
							throw new InvalidDataException();
						}
						for (int k = 0; k < num; k++)
						{
							codeList[loopCounter++] = 0;
						}
					}
				}
				state = InflaterState.ReadingTreeCodesBefore;
			}
			byte[] array = new byte[288];
			byte[] array2 = new byte[32];
			Array.Copy(codeList, array, literalLengthCodeCount);
			Array.Copy(codeList, literalLengthCodeCount, array2, 0, distanceCodeCount);
			if (array[256] == 0)
			{
				throw new InvalidDataException();
			}
			literalLengthTree = new HuffmanTree(array);
			distanceTree = new HuffmanTree(array2);
			state = InflaterState.DecodeTop;
			return true;
		}
		default:
			throw new InvalidDataException(SR.GetString("UnknownState"));
		}
	}

	public void Dispose()
	{
	}
}
