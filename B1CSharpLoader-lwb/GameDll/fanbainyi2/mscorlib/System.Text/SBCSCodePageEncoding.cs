using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System.Text;

[Serializable]
internal class SBCSCodePageEncoding : BaseCodePageEncoding, ISerializable
{
	[NonSerialized]
	[SecurityCritical]
	private unsafe char* mapBytesToUnicode = null;

	[NonSerialized]
	[SecurityCritical]
	private unsafe byte* mapUnicodeToBytes = null;

	[NonSerialized]
	[SecurityCritical]
	private unsafe int* mapCodePageCached = null;

	private const char UNKNOWN_CHAR = '\ufffd';

	[NonSerialized]
	private byte byteUnknown;

	[NonSerialized]
	private char charUnknown;

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

	public override bool IsSingleByte => true;

	[SecurityCritical]
	public SBCSCodePageEncoding(int codePage)
		: this(codePage, codePage)
	{
	}

	[SecurityCritical]
	internal unsafe SBCSCodePageEncoding(int codePage, int dataCodePage)
		: base(codePage, dataCodePage)
	{
	}

	[SecurityCritical]
	internal unsafe SBCSCodePageEncoding(SerializationInfo info, StreamingContext context)
		: base(0)
	{
		throw new ArgumentNullException("this");
	}

	[SecurityCritical]
	protected unsafe override void LoadManagedCodePage()
	{
		if (pCodePage->ByteCount != 1)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_NoCodepageData", CodePage));
		}
		byteUnknown = (byte)pCodePage->ByteReplace;
		charUnknown = pCodePage->UnicodeReplace;
		byte* ptr = (byte*)(mapBytesToUnicode = (char*)GetSharedMemory(66052 + iExtraBytes));
		mapUnicodeToBytes = ptr + 512;
		mapCodePageCached = (int*)(ptr + 512 + 65536 + iExtraBytes);
		if (*mapCodePageCached != 0)
		{
			if (*mapCodePageCached != dataTableCodePage)
			{
				throw new OutOfMemoryException(Environment.GetResourceString("Arg_OutOfMemoryException"));
			}
			return;
		}
		char* ptr2 = (char*)(&pCodePage->FirstDataWord);
		for (int i = 0; i < 256; i++)
		{
			if (ptr2[i] != 0 || i == 0)
			{
				mapBytesToUnicode[i] = ptr2[i];
				if (ptr2[i] != '\ufffd')
				{
					mapUnicodeToBytes[(int)ptr2[i]] = (byte)i;
				}
			}
			else
			{
				mapBytesToUnicode[i] = '\ufffd';
			}
		}
		*mapCodePageCached = dataTableCodePage;
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
			byte* ptr = (byte*)(&pCodePage->FirstDataWord);
			ptr += 512;
			char[] array = new char[256];
			for (int i = 0; i < 256; i++)
			{
				array[i] = mapBytesToUnicode[i];
			}
			ushort num;
			while ((num = *(ushort*)ptr) != 0)
			{
				ptr += 2;
				array[num] = *(char*)ptr;
				ptr += 2;
			}
			arrayBytesBestFit = array;
			ptr += 2;
			byte* ptr2 = ptr;
			int num2 = 0;
			int num3 = *(ushort*)ptr;
			ptr += 2;
			while (num3 < 65536)
			{
				byte b = *ptr;
				ptr++;
				switch (b)
				{
				case 1:
					num3 = *(ushort*)ptr;
					ptr += 2;
					continue;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
				case 11:
				case 12:
				case 13:
				case 14:
				case 15:
				case 16:
				case 17:
				case 18:
				case 19:
				case 20:
				case 21:
				case 22:
				case 23:
				case 24:
				case 25:
				case 26:
				case 27:
				case 28:
				case 29:
				case 31:
					num3 += b;
					continue;
				}
				if (b > 0)
				{
					num2++;
				}
				num3++;
			}
			array = new char[num2 * 2];
			ptr = ptr2;
			num3 = *(ushort*)ptr;
			ptr += 2;
			num2 = 0;
			while (num3 < 65536)
			{
				byte b2 = *ptr;
				ptr++;
				switch (b2)
				{
				case 1:
					num3 = *(ushort*)ptr;
					ptr += 2;
					continue;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
				case 11:
				case 12:
				case 13:
				case 14:
				case 15:
				case 16:
				case 17:
				case 18:
				case 19:
				case 20:
				case 21:
				case 22:
				case 23:
				case 24:
				case 25:
				case 26:
				case 27:
				case 28:
				case 29:
				case 31:
					num3 += b2;
					continue;
				}
				if (b2 == 30)
				{
					b2 = *ptr;
					ptr++;
				}
				if (b2 > 0)
				{
					array[num2++] = (char)num3;
					array[num2++] = mapBytesToUnicode[(int)b2];
				}
				num3++;
			}
			arrayUnicodeBestFit = array;
		}
	}

	[SecurityCritical]
	internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS encoder)
	{
		CheckMemorySection();
		EncoderReplacementFallback encoderReplacementFallback = null;
		char c = '\0';
		if (encoder != null)
		{
			c = encoder.charLeftOver;
			encoderReplacementFallback = encoder.Fallback as EncoderReplacementFallback;
		}
		else
		{
			encoderReplacementFallback = base.EncoderFallback as EncoderReplacementFallback;
		}
		if (encoderReplacementFallback != null && encoderReplacementFallback.MaxCharCount == 1)
		{
			if (c > '\0')
			{
				count++;
			}
			return count;
		}
		EncoderFallbackBuffer encoderFallbackBuffer = null;
		int num = 0;
		char* ptr = chars + count;
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
			if (mapUnicodeToBytes[(int)c2] == 0 && c2 != 0)
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
			}
		}
		return num;
	}

	[SecurityCritical]
	internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
	{
		CheckMemorySection();
		EncoderReplacementFallback encoderReplacementFallback = null;
		char c = '\0';
		if (encoder != null)
		{
			c = encoder.charLeftOver;
			encoderReplacementFallback = encoder.Fallback as EncoderReplacementFallback;
		}
		else
		{
			encoderReplacementFallback = base.EncoderFallback as EncoderReplacementFallback;
		}
		char* ptr = chars + charCount;
		byte* ptr2 = bytes;
		char* ptr3 = chars;
		if (encoderReplacementFallback != null && encoderReplacementFallback.MaxCharCount == 1)
		{
			byte b = mapUnicodeToBytes[(int)encoderReplacementFallback.DefaultString[0]];
			if (b != 0)
			{
				if (c > '\0')
				{
					if (byteCount == 0)
					{
						ThrowBytesOverflow(encoder, nothingEncoded: true);
					}
					*(bytes++) = b;
					byteCount--;
				}
				if (byteCount < charCount)
				{
					ThrowBytesOverflow(encoder, byteCount < 1);
					ptr = chars + byteCount;
				}
				while (chars < ptr)
				{
					char c2 = *chars;
					chars++;
					byte b2 = mapUnicodeToBytes[(int)c2];
					if (b2 == 0 && c2 != 0)
					{
						*bytes = b;
					}
					else
					{
						*bytes = b2;
					}
					bytes++;
				}
				if (encoder != null)
				{
					encoder.charLeftOver = '\0';
					encoder.m_charsUsed = (int)(chars - ptr3);
				}
				return (int)(bytes - ptr2);
			}
		}
		EncoderFallbackBuffer encoderFallbackBuffer = null;
		byte* ptr4 = bytes + byteCount;
		if (c > '\0')
		{
			encoderFallbackBuffer = encoder.FallbackBuffer;
			encoderFallbackBuffer.InternalInitialize(chars, ptr, encoder, setEncoder: true);
			encoderFallbackBuffer.InternalFallback(c, ref chars);
			if (encoderFallbackBuffer.Remaining > ptr4 - bytes)
			{
				ThrowBytesOverflow(encoder, nothingEncoded: true);
			}
		}
		while (true)
		{
			char num = encoderFallbackBuffer?.InternalGetNextChar() ?? '\0';
			char c3 = num;
			if (num == '\0' && chars >= ptr)
			{
				break;
			}
			if (c3 == '\0')
			{
				c3 = *chars;
				chars++;
			}
			byte b3 = mapUnicodeToBytes[(int)c3];
			if (b3 == 0 && c3 != 0)
			{
				if (encoderFallbackBuffer == null)
				{
					encoderFallbackBuffer = ((encoder != null) ? encoder.FallbackBuffer : encoderFallback.CreateFallbackBuffer());
					encoderFallbackBuffer.InternalInitialize(ptr - charCount, ptr, encoder, setEncoder: true);
				}
				encoderFallbackBuffer.InternalFallback(c3, ref chars);
				if (encoderFallbackBuffer.Remaining > ptr4 - bytes)
				{
					chars--;
					encoderFallbackBuffer.InternalReset();
					ThrowBytesOverflow(encoder, chars == ptr3);
					break;
				}
				continue;
			}
			if (bytes >= ptr4)
			{
				if (encoderFallbackBuffer == null || !encoderFallbackBuffer.bFallingBack)
				{
					chars--;
				}
				ThrowBytesOverflow(encoder, chars == ptr3);
				break;
			}
			*bytes = b3;
			bytes++;
		}
		if (encoder != null)
		{
			if (encoderFallbackBuffer != null && !encoderFallbackBuffer.bUsedEncoder)
			{
				encoder.charLeftOver = '\0';
			}
			encoder.m_charsUsed = (int)(chars - ptr3);
		}
		return (int)(bytes - ptr2);
	}

	[SecurityCritical]
	internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
	{
		CheckMemorySection();
		bool flag = false;
		DecoderReplacementFallback decoderReplacementFallback = null;
		if (decoder == null)
		{
			decoderReplacementFallback = base.DecoderFallback as DecoderReplacementFallback;
			flag = base.DecoderFallback.IsMicrosoftBestFitFallback;
		}
		else
		{
			decoderReplacementFallback = decoder.Fallback as DecoderReplacementFallback;
			flag = decoder.Fallback.IsMicrosoftBestFitFallback;
		}
		if (flag || (decoderReplacementFallback != null && decoderReplacementFallback.MaxCharCount == 1))
		{
			return count;
		}
		DecoderFallbackBuffer decoderFallbackBuffer = null;
		int num = count;
		byte[] array = new byte[1];
		byte* ptr = bytes + count;
		while (bytes < ptr)
		{
			char c = mapBytesToUnicode[(int)(*bytes)];
			bytes++;
			if (c == '\ufffd')
			{
				if (decoderFallbackBuffer == null)
				{
					decoderFallbackBuffer = ((decoder != null) ? decoder.FallbackBuffer : base.DecoderFallback.CreateFallbackBuffer());
					decoderFallbackBuffer.InternalInitialize(ptr - count, null);
				}
				array[0] = *(bytes - 1);
				num--;
				num += decoderFallbackBuffer.InternalFallback(array, bytes);
			}
		}
		return num;
	}

	[SecurityCritical]
	internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
	{
		CheckMemorySection();
		bool flag = false;
		byte* ptr = bytes + byteCount;
		byte* ptr2 = bytes;
		char* ptr3 = chars;
		DecoderReplacementFallback decoderReplacementFallback = null;
		if (decoder == null)
		{
			decoderReplacementFallback = base.DecoderFallback as DecoderReplacementFallback;
			flag = base.DecoderFallback.IsMicrosoftBestFitFallback;
		}
		else
		{
			decoderReplacementFallback = decoder.Fallback as DecoderReplacementFallback;
			flag = decoder.Fallback.IsMicrosoftBestFitFallback;
		}
		if (flag || (decoderReplacementFallback != null && decoderReplacementFallback.MaxCharCount == 1))
		{
			char c = decoderReplacementFallback?.DefaultString[0] ?? '?';
			if (charCount < byteCount)
			{
				ThrowCharsOverflow(decoder, charCount < 1);
				ptr = bytes + charCount;
			}
			while (bytes < ptr)
			{
				char c2;
				if (flag)
				{
					if (arrayBytesBestFit == null)
					{
						ReadBestFitTable();
					}
					c2 = arrayBytesBestFit[*bytes];
				}
				else
				{
					c2 = mapBytesToUnicode[(int)(*bytes)];
				}
				bytes++;
				if (c2 == '\ufffd')
				{
					*chars = c;
				}
				else
				{
					*chars = c2;
				}
				chars++;
			}
			if (decoder != null)
			{
				decoder.m_bytesUsed = (int)(bytes - ptr2);
			}
			return (int)(chars - ptr3);
		}
		DecoderFallbackBuffer decoderFallbackBuffer = null;
		byte[] array = new byte[1];
		char* ptr4 = chars + charCount;
		while (bytes < ptr)
		{
			char c3 = mapBytesToUnicode[(int)(*bytes)];
			bytes++;
			if (c3 == '\ufffd')
			{
				if (decoderFallbackBuffer == null)
				{
					decoderFallbackBuffer = ((decoder != null) ? decoder.FallbackBuffer : base.DecoderFallback.CreateFallbackBuffer());
					decoderFallbackBuffer.InternalInitialize(ptr - byteCount, ptr4);
				}
				array[0] = *(bytes - 1);
				if (!decoderFallbackBuffer.InternalFallback(array, bytes, ref chars))
				{
					bytes--;
					decoderFallbackBuffer.InternalReset();
					ThrowCharsOverflow(decoder, bytes == ptr2);
					break;
				}
			}
			else
			{
				if (chars >= ptr4)
				{
					bytes--;
					ThrowCharsOverflow(decoder, bytes == ptr2);
					break;
				}
				*chars = c3;
				chars++;
			}
		}
		if (decoder != null)
		{
			decoder.m_bytesUsed = (int)(bytes - ptr2);
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
		long num = byteCount;
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

	[ComVisible(false)]
	public override bool IsAlwaysNormalized(NormalizationForm form)
	{
		if (form == NormalizationForm.FormC)
		{
			switch (CodePage)
			{
			case 37:
			case 437:
			case 500:
			case 720:
			case 737:
			case 775:
			case 850:
			case 852:
			case 855:
			case 858:
			case 860:
			case 861:
			case 862:
			case 863:
			case 865:
			case 866:
			case 869:
			case 870:
			case 1026:
			case 1047:
			case 1140:
			case 1141:
			case 1142:
			case 1143:
			case 1144:
			case 1145:
			case 1146:
			case 1147:
			case 1148:
			case 1149:
			case 1250:
			case 1251:
			case 1252:
			case 1254:
			case 1256:
			case 10007:
			case 10017:
			case 10029:
			case 20273:
			case 20277:
			case 20278:
			case 20280:
			case 20284:
			case 20285:
			case 20297:
			case 20866:
			case 20871:
			case 20880:
			case 20924:
			case 21025:
			case 21866:
			case 28591:
			case 28592:
			case 28594:
			case 28595:
			case 28599:
			case 28603:
			case 28605:
				return true;
			}
		}
		return false;
	}
}
