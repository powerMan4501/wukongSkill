using System.IO;
using System.Text;

namespace System.Net.Mime;

internal class QuotedPrintableStream : DelegatedStream, IEncodableStream
{
	private class ReadStateInfo
	{
		private bool isEscaped;

		private short b1 = -1;

		internal bool IsEscaped
		{
			get
			{
				return isEscaped;
			}
			set
			{
				isEscaped = value;
			}
		}

		internal short Byte
		{
			get
			{
				return b1;
			}
			set
			{
				b1 = value;
			}
		}
	}

	private class WriteAsyncResult : LazyAsyncResult
	{
		private QuotedPrintableStream parent;

		private byte[] buffer;

		private int offset;

		private int count;

		private static AsyncCallback onWrite = OnWrite;

		private int written;

		internal WriteAsyncResult(QuotedPrintableStream parent, byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			: base(null, state, callback)
		{
			this.parent = parent;
			this.buffer = buffer;
			this.offset = offset;
			this.count = count;
		}

		private void CompleteWrite(IAsyncResult result)
		{
			parent.BaseStream.EndWrite(result);
			parent.WriteState.BufferFlushed();
		}

		internal static void End(IAsyncResult result)
		{
			WriteAsyncResult writeAsyncResult = (WriteAsyncResult)result;
			writeAsyncResult.InternalWaitForCompletion();
		}

		private static void OnWrite(IAsyncResult result)
		{
			if (!result.CompletedSynchronously)
			{
				WriteAsyncResult writeAsyncResult = (WriteAsyncResult)result.AsyncState;
				try
				{
					writeAsyncResult.CompleteWrite(result);
					writeAsyncResult.Write();
				}
				catch (Exception result2)
				{
					writeAsyncResult.InvokeCallback(result2);
				}
			}
		}

		internal void Write()
		{
			while (true)
			{
				written += parent.EncodeBytes(buffer, offset + written, count - written);
				if (written < count)
				{
					IAsyncResult asyncResult = parent.BaseStream.BeginWrite(parent.WriteState.Buffer, 0, parent.WriteState.Length, onWrite, this);
					if (asyncResult.CompletedSynchronously)
					{
						CompleteWrite(asyncResult);
						continue;
					}
					break;
				}
				InvokeCallback();
				break;
			}
		}
	}

	private bool encodeCRLF;

	private const int sizeOfSoftCRLF = 3;

	private const int sizeOfEncodedChar = 3;

	private const int sizeOfEncodedCRLF = 6;

	private const int sizeOfNonEncodedCRLF = 2;

	private static byte[] hexDecodeMap = new byte[256]
	{
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 0, 1,
		2, 3, 4, 5, 6, 7, 8, 9, 255, 255,
		255, 255, 255, 255, 255, 10, 11, 12, 13, 14,
		15, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 10, 11, 12,
		13, 14, 15, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
		255, 255, 255, 255, 255, 255
	};

	private static byte[] hexEncodeMap = new byte[16]
	{
		48, 49, 50, 51, 52, 53, 54, 55, 56, 57,
		65, 66, 67, 68, 69, 70
	};

	private int lineLength;

	private ReadStateInfo readState;

	private WriteStateInfoBase writeState;

	private ReadStateInfo ReadState
	{
		get
		{
			if (readState == null)
			{
				readState = new ReadStateInfo();
			}
			return readState;
		}
	}

	internal WriteStateInfoBase WriteState
	{
		get
		{
			if (writeState == null)
			{
				writeState = new WriteStateInfoBase(1024, null, null, lineLength);
			}
			return writeState;
		}
	}

	internal QuotedPrintableStream(Stream stream, int lineLength)
		: base(stream)
	{
		if (lineLength < 0)
		{
			throw new ArgumentOutOfRangeException("lineLength");
		}
		this.lineLength = lineLength;
	}

	internal QuotedPrintableStream(Stream stream, bool encodeCRLF)
		: this(stream, EncodedStreamFactory.DefaultMaxLineLength)
	{
		this.encodeCRLF = encodeCRLF;
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (offset + count > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		WriteAsyncResult writeAsyncResult = new WriteAsyncResult(this, buffer, offset, count, callback, state);
		writeAsyncResult.Write();
		return writeAsyncResult;
	}

	public override void Close()
	{
		FlushInternal();
		base.Close();
	}

	public unsafe int DecodeBytes(byte[] buffer, int offset, int count)
	{
		fixed (byte* ptr = buffer)
		{
			byte* ptr2 = ptr + offset;
			byte* ptr3 = ptr2;
			byte* ptr4 = ptr2;
			byte* ptr5 = ptr2 + count;
			if (ReadState.IsEscaped)
			{
				if (ReadState.Byte == -1)
				{
					if (count == 1)
					{
						ReadState.Byte = *ptr3;
						return 0;
					}
					if (*ptr3 != 13 || ptr3[1] != 10)
					{
						byte b = hexDecodeMap[*ptr3];
						byte b2 = hexDecodeMap[ptr3[1]];
						if (b == byte.MaxValue)
						{
							throw new FormatException(SR.GetString("InvalidHexDigit", b));
						}
						if (b2 == byte.MaxValue)
						{
							throw new FormatException(SR.GetString("InvalidHexDigit", b2));
						}
						*(ptr4++) = (byte)((b << 4) + b2);
					}
					ptr3 += 2;
				}
				else
				{
					if (ReadState.Byte != 13 || *ptr3 != 10)
					{
						byte b3 = hexDecodeMap[ReadState.Byte];
						byte b4 = hexDecodeMap[*ptr3];
						if (b3 == byte.MaxValue)
						{
							throw new FormatException(SR.GetString("InvalidHexDigit", b3));
						}
						if (b4 == byte.MaxValue)
						{
							throw new FormatException(SR.GetString("InvalidHexDigit", b4));
						}
						*(ptr4++) = (byte)((b3 << 4) + b4);
					}
					ptr3++;
				}
				ReadState.IsEscaped = false;
				ReadState.Byte = -1;
			}
			while (ptr3 < ptr5)
			{
				if (*ptr3 != 61)
				{
					*(ptr4++) = *(ptr3++);
					continue;
				}
				long num = ptr5 - ptr3;
				if (num != 1)
				{
					if (num != 2)
					{
						if (ptr3[1] != 13 || ptr3[2] != 10)
						{
							byte b5 = hexDecodeMap[ptr3[1]];
							byte b6 = hexDecodeMap[ptr3[2]];
							if (b5 == byte.MaxValue)
							{
								throw new FormatException(SR.GetString("InvalidHexDigit", b5));
							}
							if (b6 == byte.MaxValue)
							{
								throw new FormatException(SR.GetString("InvalidHexDigit", b6));
							}
							*(ptr4++) = (byte)((b5 << 4) + b6);
						}
						ptr3 += 3;
						continue;
					}
					ReadState.Byte = ptr3[1];
				}
				ReadState.IsEscaped = true;
				break;
			}
			count = (int)(ptr4 - ptr2);
		}
		return count;
	}

	public int EncodeBytes(byte[] buffer, int offset, int count)
	{
		int i;
		for (i = offset; i < count + offset; i++)
		{
			if ((lineLength != -1 && WriteState.CurrentLineLength + 3 + 2 >= lineLength && (buffer[i] == 32 || buffer[i] == 9 || buffer[i] == 13 || buffer[i] == 10)) || writeState.CurrentLineLength + 3 + 2 >= EncodedStreamFactory.DefaultMaxLineLength)
			{
				if (WriteState.Buffer.Length - WriteState.Length < 3)
				{
					return i - offset;
				}
				WriteState.Append(61);
				WriteState.AppendCRLF(includeSpace: false);
			}
			if (buffer[i] == 13 && i + 1 < count + offset && buffer[i + 1] == 10)
			{
				if (WriteState.Buffer.Length - WriteState.Length < (encodeCRLF ? 6 : 2))
				{
					return i - offset;
				}
				i++;
				if (encodeCRLF)
				{
					WriteState.Append(61, 48, 68, 61, 48, 65);
				}
				else
				{
					WriteState.AppendCRLF(includeSpace: false);
				}
				continue;
			}
			if ((buffer[i] < 32 && buffer[i] != 9) || buffer[i] == 61 || buffer[i] > 126)
			{
				if (WriteState.Buffer.Length - WriteState.Length < 3)
				{
					return i - offset;
				}
				WriteState.Append(61);
				WriteState.Append(hexEncodeMap[buffer[i] >> 4]);
				WriteState.Append(hexEncodeMap[buffer[i] & 0xF]);
				continue;
			}
			if (WriteState.Buffer.Length - WriteState.Length < 1)
			{
				return i - offset;
			}
			if ((buffer[i] == 9 || buffer[i] == 32) && i + 1 >= count + offset)
			{
				if (WriteState.Buffer.Length - WriteState.Length < 3)
				{
					return i - offset;
				}
				WriteState.Append(61);
				WriteState.Append(hexEncodeMap[buffer[i] >> 4]);
				WriteState.Append(hexEncodeMap[buffer[i] & 0xF]);
			}
			else
			{
				WriteState.Append(buffer[i]);
			}
		}
		return i - offset;
	}

	public Stream GetStream()
	{
		return this;
	}

	public string GetEncodedString()
	{
		return Encoding.ASCII.GetString(WriteState.Buffer, 0, WriteState.Length);
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
		WriteAsyncResult.End(asyncResult);
	}

	public override void Flush()
	{
		FlushInternal();
		base.Flush();
	}

	private void FlushInternal()
	{
		if (writeState != null && writeState.Length > 0)
		{
			base.Write(WriteState.Buffer, 0, WriteState.Length);
			WriteState.BufferFlushed();
		}
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (offset + count > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		int num = 0;
		while (true)
		{
			num += EncodeBytes(buffer, offset + num, count - num);
			if (num < count)
			{
				FlushInternal();
				continue;
			}
			break;
		}
	}
}
