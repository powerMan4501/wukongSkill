using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System.Text;

[Serializable]
internal class DBCSCodePageEncoding : BaseCodePageEncoding, ISerializable
{
	[Serializable]
	internal class DBCSDecoder : DecoderNLS
	{
		internal byte bLeftOver;

		internal override bool HasState => bLeftOver != 0;

		public DBCSDecoder(DBCSCodePageEncoding encoding)
			: base(encoding)
		{
		}

		public override void Reset()
		{
			bLeftOver = 0;
			if (m_fallbackBuffer != null)
			{
				m_fallbackBuffer.Reset();
			}
		}
	}

	[NonSerialized]
	[SecurityCritical]
	protected unsafe char* mapBytesToUnicode = null;

	[NonSerialized]
	[SecurityCritical]
	protected unsafe ushort* mapUnicodeToBytes = null;

	[NonSerialized]
	[SecurityCritical]
	protected unsafe int* mapCodePageCached = null;

	[NonSerialized]
	protected const char UNKNOWN_CHAR_FLAG = '\0';

	[NonSerialized]
	protected const char UNICODE_REPLACEMENT_CHAR = '\ufffd';

	[NonSerialized]
	protected const char LEAD_BYTE_CHAR = '\ufffe';

	[NonSerialized]
	private ushort bytesUnknown;

	[NonSerialized]
	private int byteCountUnknown;

	[NonSerialized]
	protected char charUnknown;

	private static object s_InternalSyncObject;

	private static object InternalSyncObject
	{
		get
		{
			if (s_InternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange<object>(ref s_InternalSyncObject, value, (object)null);
			}
			return s_InternalSyncObject;
		}
	}

	[SecurityCritical]
	public DBCSCodePageEncoding(int codePage)
		: this(codePage, codePage)
	{
	}

	[SecurityCritical]
	internal unsafe DBCSCodePageEncoding(int codePage, int dataCodePage)
		: base(codePage, dataCodePage)
	{
	}

	[SecurityCritical]
	internal unsafe DBCSCodePageEncoding(SerializationInfo info, StreamingContext context)
		: base(0)
	{
		throw new ArgumentNullException("this");
	}

	[SecurityCritical]
	protected unsafe override void LoadManagedCodePage()
	{
		if (pCodePage->ByteCount != 2)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_NoCodepageData", CodePage));
		}
		bytesUnknown = pCodePage->ByteReplace;
		charUnknown = pCodePage->UnicodeReplace;
		if (base.DecoderFallback.IsMicrosoftBestFitFallback)
		{
			((InternalDecoderBestFitFallback)base.DecoderFallback).cReplacement = charUnknown;
		}
		byteCountUnknown = 1;
		if (bytesUnknown > 255)
		{
			byteCountUnknown++;
		}
		byte* ptr = (byte*)(mapBytesToUnicode = (char*)GetSharedMemory(262148 + iExtraBytes));
		mapUnicodeToBytes = (ushort*)ptr + 65536;
		mapCodePageCached = (int*)(ptr + 262144 + iExtraBytes);
		if (*mapCodePageCached != 0)
		{
			if ((*mapCodePageCached != dataTableCodePage && bFlagDataTable) || (*mapCodePageCached != CodePage && !bFlagDataTable))
			{
				throw new OutOfMemoryException(Environment.GetResourceString("Arg_OutOfMemoryException"));
			}
			return;
		}
		char* ptr2 = (char*)(&pCodePage->FirstDataWord);
		int num = 0;
		int num2 = 0;
		while (num < 65536)
		{
			char c = *ptr2;
			ptr2++;
			switch (c)
			{
			case '\u0001':
				num = *ptr2;
				ptr2++;
				continue;
			case '\u0002':
			case '\u0003':
			case '\u0004':
			case '\u0005':
			case '\u0006':
			case '\a':
			case '\b':
			case '\t':
			case '\n':
			case '\v':
			case '\f':
			case '\r':
			case '\u000e':
			case '\u000f':
			case '\u0010':
			case '\u0011':
			case '\u0012':
			case '\u0013':
			case '\u0014':
			case '\u0015':
			case '\u0016':
			case '\u0017':
			case '\u0018':
			case '\u0019':
			case '\u001a':
			case '\u001b':
			case '\u001c':
			case '\u001d':
			case '\u001e':
			case '\u001f':
				num += c;
				continue;
			}
			switch (c)
			{
			case '\uffff':
				num2 = num;
				c = (char)num;
				break;
			case '\ufffe':
				num2 = num;
				break;
			case '\ufffd':
				num++;
				continue;
			default:
				num2 = num;
				break;
			}
			if (CleanUpBytes(ref num2))
			{
				if (c != '\ufffe')
				{
					mapUnicodeToBytes[(int)c] = (ushort)num2;
				}
				mapBytesToUnicode[num2] = c;
			}
			num++;
		}
		CleanUpEndBytes(mapBytesToUnicode);
		if (bFlagDataTable)
		{
			*mapCodePageCached = dataTableCodePage;
		}
	}

	protected virtual bool CleanUpBytes(ref int bytes)
	{
		return true;
	}

	[SecurityCritical]
	protected unsafe virtual void CleanUpEndBytes(char* chars)
	{
	}

	[SecurityCritical]
	protected unsafe override void ReadBestFitTable()
	{
		lock (InternalSyncObject)
		{
			if (arrayUnicodeBestFit != null)
			{
				return;
			}
			char* ptr = (char*)(&pCodePage->FirstDataWord);
			int num = 0;
			while (num < 65536)
			{
				char c = *ptr;
				ptr++;
				switch (c)
				{
				case '\u0001':
					num = *ptr;
					ptr++;
					break;
				case '\u0002':
				case '\u0003':
				case '\u0004':
				case '\u0005':
				case '\u0006':
				case '\a':
				case '\b':
				case '\t':
				case '\n':
				case '\v':
				case '\f':
				case '\r':
				case '\u000e':
				case '\u000f':
				case '\u0010':
				case '\u0011':
				case '\u0012':
				case '\u0013':
				case '\u0014':
				case '\u0015':
				case '\u0016':
				case '\u0017':
				case '\u0018':
				case '\u0019':
				case '\u001a':
				case '\u001b':
				case '\u001c':
				case '\u001d':
				case '\u001e':
				case '\u001f':
					num += c;
					break;
				default:
					num++;
					break;
				}
			}
			char* ptr2 = ptr;
			int num2 = 0;
			num = *ptr;
			ptr++;
			while (num < 65536)
			{
				char c2 = *ptr;
				ptr++;
				switch (c2)
				{
				case '\u0001':
					num = *ptr;
					ptr++;
					continue;
				case '\u0002':
				case '\u0003':
				case '\u0004':
				case '\u0005':
				case '\u0006':
				case '\a':
				case '\b':
				case '\t':
				case '\n':
				case '\v':
				case '\f':
				case '\r':
				case '\u000e':
				case '\u000f':
				case '\u0010':
				case '\u0011':
				case '\u0012':
				case '\u0013':
				case '\u0014':
				case '\u0015':
				case '\u0016':
				case '\u0017':
				case '\u0018':
				case '\u0019':
				case '\u001a':
				case '\u001b':
				case '\u001c':
				case '\u001d':
				case '\u001e':
				case '\u001f':
					num += c2;
					continue;
				}
				if (c2 != '\ufffd')
				{
					int bytes = num;
					if (CleanUpBytes(ref bytes) && mapBytesToUnicode[bytes] != c2)
					{
						num2++;
					}
				}
				num++;
			}
			char[] array = new char[num2 * 2];
			num2 = 0;
			ptr = ptr2;
			num = *ptr;
			ptr++;
			bool flag = false;
			while (num < 65536)
			{
				char c3 = *ptr;
				ptr++;
				switch (c3)
				{
				case '\u0001':
					num = *ptr;
					ptr++;
					continue;
				case '\u0002':
				case '\u0003':
				case '\u0004':
				case '\u0005':
				case '\u0006':
				case '\a':
				case '\b':
				case '\t':
				case '\n':
				case '\v':
				case '\f':
				case '\r':
				case '\u000e':
				case '\u000f':
				case '\u0010':
				case '\u0011':
				case '\u0012':
				case '\u0013':
				case '\u0014':
				case '\u0015':
				case '\u0016':
				case '\u0017':
				case '\u0018':
				case '\u0019':
				case '\u001a':
				case '\u001b':
				case '\u001c':
				case '\u001d':
				case '\u001e':
				case '\u001f':
					num += c3;
					continue;
				}
				if (c3 != '\ufffd')
				{
					int bytes2 = num;
					if (CleanUpBytes(ref bytes2) && mapBytesToUnicode[bytes2] != c3)
					{
						if (bytes2 != num)
						{
							flag = true;
						}
						array[num2++] = (char)bytes2;
						array[num2++] = c3;
					}
				}
				num++;
			}
			if (flag)
			{
				for (int i = 0; i < array.Length - 2; i += 2)
				{
					int num3 = i;
					char c4 = array[i];
					for (int j = i + 2; j < array.Length; j += 2)
					{
						if (c4 > array[j])
						{
							c4 = array[j];
							num3 = j;
						}
					}
					if (num3 != i)
					{
						char c5 = array[num3];
						array[num3] = array[i];
						array[i] = c5;
						c5 = array[num3 + 1];
						array[num3 + 1] = array[i + 1];
						array[i + 1] = c5;
					}
				}
			}
			arrayBytesBestFit = array;
			char* ptr3 = ptr;
			int num4 = *(ptr++);
			num2 = 0;
			while (num4 < 65536)
			{
				char c6 = *ptr;
				ptr++;
				switch (c6)
				{
				case '\u0001':
					num4 = *ptr;
					ptr++;
					continue;
				case '\u0002':
				case '\u0003':
				case '\u0004':
				case '\u0005':
				case '\u0006':
				case '\a':
				case '\b':
				case '\t':
				case '\n':
				case '\v':
				case '\f':
				case '\r':
				case '\u000e':
				case '\u000f':
				case '\u0010':
				case '\u0011':
				case '\u0012':
				case '\u0013':
				case '\u0014':
				case '\u0015':
				case '\u0016':
				case '\u0017':
				case '\u0018':
				case '\u0019':
				case '\u001a':
				case '\u001b':
				case '\u001c':
				case '\u001d':
				case '\u001e':
				case '\u001f':
					num4 += c6;
					continue;
				}
				if (c6 > '\0')
				{
					num2++;
				}
				num4++;
			}
			array = new char[num2 * 2];
			ptr = ptr3;
			num4 = *(ptr++);
			num2 = 0;
			while (num4 < 65536)
			{
				char c7 = *ptr;
				ptr++;
				switch (c7)
				{
				case '\u0001':
					num4 = *ptr;
					ptr++;
					continue;
				case '\u0002':
				case '\u0003':
				case '\u0004':
				case '\u0005':
				case '\u0006':
				case '\a':
				case '\b':
				case '\t':
				case '\n':
				case '\v':
				case '\f':
				case '\r':
				case '\u000e':
				case '\u000f':
				case '\u0010':
				case '\u0011':
				case '\u0012':
				case '\u0013':
				case '\u0014':
				case '\u0015':
				case '\u0016':
				case '\u0017':
				case '\u0018':
				case '\u0019':
				case '\u001a':
				case '\u001b':
				case '\u001c':
				case '\u001d':
				case '\u001e':
				case '\u001f':
					num4 += c7;
					continue;
				}
				if (c7 > '\0')
				{
					int bytes3 = c7;
					if (CleanUpBytes(ref bytes3))
					{
						array[num2++] = (char)num4;
						array[num2++] = mapBytesToUnicode[bytes3];
					}
				}
				num4++;
			}
			arrayUnicodeBestFit = array;
		}
	}

	[SecurityCritical]
	internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS encoder)
	{
		CheckMemorySection();
		char c = '\0';
		if (encoder != null)
		{
			c = encoder.charLeftOver;
			if (encoder.InternalHasFallbackBuffer && encoder.FallbackBuffer.Remaining > 0)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_EncoderFallbackNotEmpty", EncodingName, encoder.Fallback.GetType()));
			}
		}
		int num = 0;
		char* ptr = chars + count;
		EncoderFallbackBuffer encoderFallbackBuffer = null;
		if (c > '\0')
		{
			encoderFallbackBuffer = encoder.FallbackBuffer;
			encoderFallbackBuffer.InternalInitialize(chars, ptr, encoder, setEncoder: false);
			encoderFallbackBuffer.InternalFallback(c, ref chars);
		}
		while (true)
		{
			char num2 = encoderFallbackBuffer?.InternalGetNextChar() ?? '\0';
			char c2 = num2;
			if (num2 == '\0' && chars >= ptr)
			{
				break;
			}
			if (c2 == '\0')
			{
				c2 = *chars;
				chars++;
			}
			ushort num3 = mapUnicodeToBytes[(int)c2];
			if (num3 == 0 && c2 != 0)
			{
				if (encoderFallbackBuffer == null)
				{
					encoderFallbackBuffer = ((encoder != null) ? encoder.FallbackBuffer : encoderFallback.CreateFallbackBuffer());
					encoderFallbackBuffer.InternalInitialize(ptr - count, ptr, encoder, setEncoder: false);
				}
				encoderFallbackBuffer.InternalFallback(c2, ref chars);
			}
			else
			{
				num++;
				if (num3 >= 256)
				{
					num++;
				}
			}
		}
		return num;
	}

	[SecurityCritical]
	internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
	{
		CheckMemorySection();
		EncoderFallbackBuffer encoderFallbackBuffer = null;
		char* ptr = chars + charCount;
		char* ptr2 = chars;
		byte* ptr3 = bytes;
		byte* ptr4 = bytes + byteCount;
		char c = '\0';
		if (encoder != null)
		{
			c = encoder.charLeftOver;
			encoderFallbackBuffer = encoder.FallbackBuffer;
			encoderFallbackBuffer.InternalInitialize(chars, ptr, encoder, setEncoder: true);
			if (encoder.m_throwOnOverflow && encoderFallbackBuffer.Remaining > 0)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_EncoderFallbackNotEmpty", EncodingName, encoder.Fallback.GetType()));
			}
			if (c > '\0')
			{
				encoderFallbackBuffer.InternalFallback(c, ref chars);
			}
		}
		while (true)
		{
			char num = encoderFallbackBuffer?.InternalGetNextChar() ?? '\0';
			char c2 = num;
			if (num == '\0' && chars >= ptr)
			{
				break;
			}
			if (c2 == '\0')
			{
				c2 = *chars;
				chars++;
			}
			ushort num2 = mapUnicodeToBytes[(int)c2];
			if (num2 == 0 && c2 != 0)
			{
				if (encoderFallbackBuffer == null)
				{
					encoderFallbackBuffer = encoderFallback.CreateFallbackBuffer();
					encoderFallbackBuffer.InternalInitialize(ptr - charCount, ptr, encoder, setEncoder: true);
				}
				encoderFallbackBuffer.InternalFallback(c2, ref chars);
				continue;
			}
			if (num2 >= 256)
			{
				if (bytes + 1 >= ptr4)
				{
					if (encoderFallbackBuffer == null || !encoderFallbackBuffer.bFallingBack)
					{
						chars--;
					}
					else
					{
						encoderFallbackBuffer.MovePrevious();
					}
					ThrowBytesOverflow(encoder, chars == ptr2);
					break;
				}
				*bytes = (byte)(num2 >> 8);
				bytes++;
			}
			else if (bytes >= ptr4)
			{
				if (encoderFallbackBuffer == null || !encoderFallbackBuffer.bFallingBack)
				{
					chars--;
				}
				else
				{
					encoderFallbackBuffer.MovePrevious();
				}
				ThrowBytesOverflow(encoder, chars == ptr2);
				break;
			}
			*bytes = (byte)(num2 & 0xFF);
			bytes++;
		}
		if (encoder != null)
		{
			if (encoderFallbackBuffer != null && !encoderFallbackBuffer.bUsedEncoder)
			{
				encoder.charLeftOver = '\0';
			}
			encoder.m_charsUsed = (int)(chars - ptr2);
		}
		return (int)(bytes - ptr3);
	}

	[SecurityCritical]
	internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
	{
		CheckMemorySection();
		DBCSDecoder dBCSDecoder = (DBCSDecoder)baseDecoder;
		DecoderFallbackBuffer decoderFallbackBuffer = null;
		byte* ptr = bytes + count;
		int num = count;
		if (dBCSDecoder != null && dBCSDecoder.bLeftOver > 0)
		{
			if (count == 0)
			{
				if (!dBCSDecoder.MustFlush)
				{
					return 0;
				}
				decoderFallbackBuffer = dBCSDecoder.FallbackBuffer;
				decoderFallbackBuffer.InternalInitialize(bytes, null);
				byte[] bytes2 = new byte[1] { dBCSDecoder.bLeftOver };
				return decoderFallbackBuffer.InternalFallback(bytes2, bytes);
			}
			int num2 = dBCSDecoder.bLeftOver << 8;
			num2 |= *bytes;
			bytes++;
			if (mapBytesToUnicode[num2] == '\0' && num2 != 0)
			{
				num--;
				decoderFallbackBuffer = dBCSDecoder.FallbackBuffer;
				decoderFallbackBuffer.InternalInitialize(ptr - count, null);
				byte[] bytes3 = new byte[2]
				{
					(byte)(num2 >> 8),
					(byte)num2
				};
				num += decoderFallbackBuffer.InternalFallback(bytes3, bytes);
			}
		}
		while (bytes < ptr)
		{
			int num3 = *bytes;
			bytes++;
			char c = mapBytesToUnicode[num3];
			if (c == '\ufffe')
			{
				num--;
				if (bytes < ptr)
				{
					num3 <<= 8;
					num3 |= *bytes;
					bytes++;
					c = mapBytesToUnicode[num3];
				}
				else
				{
					if (dBCSDecoder != null && !dBCSDecoder.MustFlush)
					{
						break;
					}
					num++;
					c = '\0';
				}
			}
			if (c == '\0' && num3 != 0)
			{
				if (decoderFallbackBuffer == null)
				{
					decoderFallbackBuffer = ((dBCSDecoder != null) ? dBCSDecoder.FallbackBuffer : base.DecoderFallback.CreateFallbackBuffer());
					decoderFallbackBuffer.InternalInitialize(ptr - count, null);
				}
				num--;
				byte[] array = null;
				array = ((num3 >= 256) ? new byte[2]
				{
					(byte)(num3 >> 8),
					(byte)num3
				} : new byte[1] { (byte)num3 });
				num += decoderFallbackBuffer.InternalFallback(array, bytes);
			}
		}
		return num;
	}

	[SecurityCritical]
	internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
	{
		CheckMemorySection();
		DBCSDecoder dBCSDecoder = (DBCSDecoder)baseDecoder;
		byte* ptr = bytes;
		byte* ptr2 = bytes + byteCount;
		char* ptr3 = chars;
		char* ptr4 = chars + charCount;
		bool flag = false;
		DecoderFallbackBuffer decoderFallbackBuffer = null;
		if (dBCSDecoder != null && dBCSDecoder.bLeftOver > 0)
		{
			if (byteCount == 0)
			{
				if (!dBCSDecoder.MustFlush)
				{
					return 0;
				}
				decoderFallbackBuffer = dBCSDecoder.FallbackBuffer;
				decoderFallbackBuffer.InternalInitialize(bytes, ptr4);
				byte[] bytes2 = new byte[1] { dBCSDecoder.bLeftOver };
				if (!decoderFallbackBuffer.InternalFallback(bytes2, bytes, ref chars))
				{
					ThrowCharsOverflow(dBCSDecoder, nothingDecoded: true);
				}
				dBCSDecoder.bLeftOver = 0;
				return (int)(chars - ptr3);
			}
			int num = dBCSDecoder.bLeftOver << 8;
			num |= *bytes;
			bytes++;
			char c = mapBytesToUnicode[num];
			if (c == '\0' && num != 0)
			{
				decoderFallbackBuffer = dBCSDecoder.FallbackBuffer;
				decoderFallbackBuffer.InternalInitialize(ptr2 - byteCount, ptr4);
				byte[] bytes3 = new byte[2]
				{
					(byte)(num >> 8),
					(byte)num
				};
				if (!decoderFallbackBuffer.InternalFallback(bytes3, bytes, ref chars))
				{
					ThrowCharsOverflow(dBCSDecoder, nothingDecoded: true);
				}
			}
			else
			{
				if (chars >= ptr4)
				{
					ThrowCharsOverflow(dBCSDecoder, nothingDecoded: true);
				}
				*(chars++) = c;
			}
		}
		while (bytes < ptr2)
		{
			int num2 = *bytes;
			bytes++;
			char c2 = mapBytesToUnicode[num2];
			if (c2 == '\ufffe')
			{
				if (bytes < ptr2)
				{
					num2 <<= 8;
					num2 |= *bytes;
					bytes++;
					c2 = mapBytesToUnicode[num2];
				}
				else
				{
					if (dBCSDecoder != null && !dBCSDecoder.MustFlush)
					{
						flag = true;
						dBCSDecoder.bLeftOver = (byte)num2;
						break;
					}
					c2 = '\0';
				}
			}
			if (c2 == '\0' && num2 != 0)
			{
				if (decoderFallbackBuffer == null)
				{
					decoderFallbackBuffer = ((dBCSDecoder != null) ? dBCSDecoder.FallbackBuffer : base.DecoderFallback.CreateFallbackBuffer());
					decoderFallbackBuffer.InternalInitialize(ptr2 - byteCount, ptr4);
				}
				byte[] array = null;
				array = ((num2 >= 256) ? new byte[2]
				{
					(byte)(num2 >> 8),
					(byte)num2
				} : new byte[1] { (byte)num2 });
				if (!decoderFallbackBuffer.InternalFallback(array, bytes, ref chars))
				{
					bytes -= array.Length;
					decoderFallbackBuffer.InternalReset();
					ThrowCharsOverflow(dBCSDecoder, bytes == ptr);
					break;
				}
				continue;
			}
			if (chars >= ptr4)
			{
				bytes--;
				if (num2 >= 256)
				{
					bytes--;
				}
				ThrowCharsOverflow(dBCSDecoder, bytes == ptr);
				break;
			}
			*(chars++) = c2;
		}
		if (dBCSDecoder != null)
		{
			if (!flag)
			{
				dBCSDecoder.bLeftOver = 0;
			}
			dBCSDecoder.m_bytesUsed = (int)(bytes - ptr);
		}
		return (int)(chars - ptr3);
	}

	public override int GetMaxByteCount(int charCount)
	{
		if (charCount < 0)
		{
			throw new ArgumentOutOfRangeException("charCount", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		long num = (long)charCount + 1L;
		if (base.EncoderFallback.MaxCharCount > 1)
		{
			num *= base.EncoderFallback.MaxCharCount;
		}
		num *= 2;
		if (num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("charCount", Environment.GetResourceString("ArgumentOutOfRange_GetByteCountOverflow"));
		}
		return (int)num;
	}

	public override int GetMaxCharCount(int byteCount)
	{
		if (byteCount < 0)
		{
			throw new ArgumentOutOfRangeException("byteCount", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		long num = (long)byteCount + 1L;
		if (base.DecoderFallback.MaxCharCount > 1)
		{
			num *= base.DecoderFallback.MaxCharCount;
		}
		if (num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("byteCount", Environment.GetResourceString("ArgumentOutOfRange_GetCharCountOverflow"));
		}
		return (int)num;
	}

	public override Decoder GetDecoder()
	{
		return new DBCSDecoder(this);
	}
}
