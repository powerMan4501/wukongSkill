using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Text;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class UTF8Encoding : Encoding
{
	internal sealed class UTF8EncodingSealed : UTF8Encoding
	{
		public UTF8EncodingSealed(bool encoderShouldEmitUTF8Identifier)
			: base(encoderShouldEmitUTF8Identifier)
		{
		}
	}

	[Serializable]
	internal class UTF8Encoder : EncoderNLS, ISerializable
	{
		internal int surrogateChar;

		internal override bool HasState => surrogateChar != 0;

		public UTF8Encoder(UTF8Encoding encoding)
			: base(encoding)
		{
		}

		internal UTF8Encoder(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			m_encoding = (Encoding)info.GetValue("encoding", typeof(Encoding));
			surrogateChar = (int)info.GetValue("surrogateChar", typeof(int));
			try
			{
				m_fallback = (EncoderFallback)info.GetValue("m_fallback", typeof(EncoderFallback));
			}
			catch (SerializationException)
			{
				m_fallback = null;
			}
		}

		[SecurityCritical]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("encoding", m_encoding);
			info.AddValue("surrogateChar", surrogateChar);
			info.AddValue("m_fallback", m_fallback);
			info.AddValue("storedSurrogate", surrogateChar > 0);
			info.AddValue("mustFlush", value: false);
		}

		public override void Reset()
		{
			surrogateChar = 0;
			if (m_fallbackBuffer != null)
			{
				m_fallbackBuffer.Reset();
			}
		}
	}

	[Serializable]
	internal class UTF8Decoder : DecoderNLS, ISerializable
	{
		internal int bits;

		internal override bool HasState => bits != 0;

		public UTF8Decoder(UTF8Encoding encoding)
			: base(encoding)
		{
		}

		internal UTF8Decoder(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			m_encoding = (Encoding)info.GetValue("encoding", typeof(Encoding));
			try
			{
				bits = (int)info.GetValue("wbits", typeof(int));
				m_fallback = (DecoderFallback)info.GetValue("m_fallback", typeof(DecoderFallback));
			}
			catch (SerializationException)
			{
				bits = 0;
				m_fallback = null;
			}
		}

		[SecurityCritical]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("encoding", m_encoding);
			info.AddValue("wbits", bits);
			info.AddValue("m_fallback", m_fallback);
			info.AddValue("bits", 0);
			info.AddValue("trailCount", 0);
			info.AddValue("isSurrogate", value: false);
			info.AddValue("byteSequence", 0);
		}

		public override void Reset()
		{
			bits = 0;
			if (m_fallbackBuffer != null)
			{
				m_fallbackBuffer.Reset();
			}
		}
	}

	private const int UTF8_CODEPAGE = 65001;

	private bool emitUTF8Identifier;

	private bool isThrowException;

	private const int FinalByte = 536870912;

	private const int SupplimentarySeq = 268435456;

	private const int ThreeByteSeq = 134217728;

	[__DynamicallyInvokable]
	public UTF8Encoding()
		: this(encoderShouldEmitUTF8Identifier: false)
	{
	}

	[__DynamicallyInvokable]
	public UTF8Encoding(bool encoderShouldEmitUTF8Identifier)
		: this(encoderShouldEmitUTF8Identifier, throwOnInvalidBytes: false)
	{
	}

	[__DynamicallyInvokable]
	public UTF8Encoding(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes)
		: base(65001)
	{
		emitUTF8Identifier = encoderShouldEmitUTF8Identifier;
		isThrowException = throwOnInvalidBytes;
		if (isThrowException)
		{
			SetDefaultFallbacks();
		}
	}

	internal override void SetDefaultFallbacks()
	{
		if (isThrowException)
		{
			encoderFallback = EncoderFallback.ExceptionFallback;
			decoderFallback = DecoderFallback.ExceptionFallback;
		}
		else
		{
			encoderFallback = new EncoderReplacementFallback("\ufffd");
			decoderFallback = new DecoderReplacementFallback("\ufffd");
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe override int GetByteCount(char[] chars, int index, int count)
	{
		if (chars == null)
		{
			throw new ArgumentNullException("chars", Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (index < 0 || count < 0)
		{
			throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (chars.Length - index < count)
		{
			throw new ArgumentOutOfRangeException("chars", Environment.GetResourceString("ArgumentOutOfRange_IndexCountBuffer"));
		}
		if (chars.Length == 0)
		{
			return 0;
		}
		fixed (char* ptr = chars)
		{
			return GetByteCount(ptr + index, count, null);
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe override int GetByteCount(string chars)
	{
		if (chars == null)
		{
			throw new ArgumentNullException("s");
		}
		fixed (char* chars2 = chars)
		{
			return GetByteCount(chars2, chars.Length, null);
		}
	}

	[SecurityCritical]
	[CLSCompliant(false)]
	[ComVisible(false)]
	public unsafe override int GetByteCount(char* chars, int count)
	{
		if (chars == null)
		{
			throw new ArgumentNullException("chars", Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		return GetByteCount(chars, count, null);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
	{
		if (s == null || bytes == null)
		{
			throw new ArgumentNullException((s == null) ? "s" : "bytes", Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (charIndex < 0 || charCount < 0)
		{
			throw new ArgumentOutOfRangeException((charIndex < 0) ? "charIndex" : "charCount", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (s.Length - charIndex < charCount)
		{
			throw new ArgumentOutOfRangeException("s", Environment.GetResourceString("ArgumentOutOfRange_IndexCount"));
		}
		if (byteIndex < 0 || byteIndex > bytes.Length)
		{
			throw new ArgumentOutOfRangeException("byteIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		int byteCount = bytes.Length - byteIndex;
		if (bytes.Length == 0)
		{
			bytes = new byte[1];
		}
		fixed (char* ptr = s)
		{
			fixed (byte* ptr2 = bytes)
			{
				return GetBytes(ptr + charIndex, charCount, ptr2 + byteIndex, byteCount, null);
			}
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
	{
		if (chars == null || bytes == null)
		{
			throw new ArgumentNullException((chars == null) ? "chars" : "bytes", Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (charIndex < 0 || charCount < 0)
		{
			throw new ArgumentOutOfRangeException((charIndex < 0) ? "charIndex" : "charCount", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (chars.Length - charIndex < charCount)
		{
			throw new ArgumentOutOfRangeException("chars", Environment.GetResourceString("ArgumentOutOfRange_IndexCountBuffer"));
		}
		if (byteIndex < 0 || byteIndex > bytes.Length)
		{
			throw new ArgumentOutOfRangeException("byteIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (chars.Length == 0)
		{
			return 0;
		}
		int byteCount = bytes.Length - byteIndex;
		if (bytes.Length == 0)
		{
			bytes = new byte[1];
		}
		fixed (char* ptr = chars)
		{
			fixed (byte* ptr2 = bytes)
			{
				return GetBytes(ptr + charIndex, charCount, ptr2 + byteIndex, byteCount, null);
			}
		}
	}

	[SecurityCritical]
	[CLSCompliant(false)]
	[ComVisible(false)]
	public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
	{
		if (bytes == null || chars == null)
		{
			throw new ArgumentNullException((bytes == null) ? "bytes" : "chars", Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (charCount < 0 || byteCount < 0)
		{
			throw new ArgumentOutOfRangeException((charCount < 0) ? "charCount" : "byteCount", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		return GetBytes(chars, charCount, bytes, byteCount, null);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe override int GetCharCount(byte[] bytes, int index, int count)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes", Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (index < 0 || count < 0)
		{
			throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (bytes.Length - index < count)
		{
			throw new ArgumentOutOfRangeException("bytes", Environment.GetResourceString("ArgumentOutOfRange_IndexCountBuffer"));
		}
		if (bytes.Length == 0)
		{
			return 0;
		}
		fixed (byte* ptr = bytes)
		{
			return GetCharCount(ptr + index, count, null);
		}
	}

	[SecurityCritical]
	[CLSCompliant(false)]
	[ComVisible(false)]
	public unsafe override int GetCharCount(byte* bytes, int count)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes", Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		return GetCharCount(bytes, count, null);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
	{
		if (bytes == null || chars == null)
		{
			throw new ArgumentNullException((bytes == null) ? "bytes" : "chars", Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (byteIndex < 0 || byteCount < 0)
		{
			throw new ArgumentOutOfRangeException((byteIndex < 0) ? "byteIndex" : "byteCount", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (bytes.Length - byteIndex < byteCount)
		{
			throw new ArgumentOutOfRangeException("bytes", Environment.GetResourceString("ArgumentOutOfRange_IndexCountBuffer"));
		}
		if (charIndex < 0 || charIndex > chars.Length)
		{
			throw new ArgumentOutOfRangeException("charIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (bytes.Length == 0)
		{
			return 0;
		}
		int charCount = chars.Length - charIndex;
		if (chars.Length == 0)
		{
			chars = new char[1];
		}
		fixed (byte* ptr = bytes)
		{
			fixed (char* ptr2 = chars)
			{
				return GetChars(ptr + byteIndex, byteCount, ptr2 + charIndex, charCount, null);
			}
		}
	}

	[SecurityCritical]
	[CLSCompliant(false)]
	[ComVisible(false)]
	public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
	{
		if (bytes == null || chars == null)
		{
			throw new ArgumentNullException((bytes == null) ? "bytes" : "chars", Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (charCount < 0 || byteCount < 0)
		{
			throw new ArgumentOutOfRangeException((charCount < 0) ? "charCount" : "byteCount", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		return GetChars(bytes, byteCount, chars, charCount, null);
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	[__DynamicallyInvokable]
	public unsafe override string GetString(byte[] bytes, int index, int count)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes", Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (index < 0 || count < 0)
		{
			throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (bytes.Length - index < count)
		{
			throw new ArgumentOutOfRangeException("bytes", Environment.GetResourceString("ArgumentOutOfRange_IndexCountBuffer"));
		}
		if (bytes.Length == 0)
		{
			return string.Empty;
		}
		fixed (byte* ptr = bytes)
		{
			return string.CreateStringFromEncoding(ptr + index, count, this);
		}
	}

	[SecurityCritical]
	internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder)
	{
		EncoderFallbackBuffer encoderFallbackBuffer = null;
		char* chars2 = chars;
		char* ptr = chars2 + count;
		int num = count;
		int num2 = 0;
		if (baseEncoder != null)
		{
			UTF8Encoder uTF8Encoder = (UTF8Encoder)baseEncoder;
			num2 = uTF8Encoder.surrogateChar;
			if (uTF8Encoder.InternalHasFallbackBuffer)
			{
				encoderFallbackBuffer = uTF8Encoder.FallbackBuffer;
				if (encoderFallbackBuffer.Remaining > 0)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_EncoderFallbackNotEmpty", EncodingName, uTF8Encoder.Fallback.GetType()));
				}
				encoderFallbackBuffer.InternalInitialize(chars, ptr, uTF8Encoder, setEncoder: false);
			}
		}
		while (true)
		{
			if (chars2 >= ptr)
			{
				if (num2 == 0)
				{
					num2 = encoderFallbackBuffer?.InternalGetNextChar() ?? '\0';
					if (num2 <= 0)
					{
						goto IL_00e6;
					}
					num++;
				}
				else
				{
					if (encoderFallbackBuffer == null || !encoderFallbackBuffer.bFallingBack)
					{
						goto IL_00e6;
					}
					num2 = encoderFallbackBuffer.InternalGetNextChar();
					num++;
					if (InRange(num2, 56320, 57343))
					{
						num2 = 65533;
						num++;
						goto IL_0169;
					}
					if (num2 <= 0)
					{
						num--;
						break;
					}
				}
			}
			else
			{
				if (num2 > 0)
				{
					int ch = *chars2;
					num++;
					if (InRange(ch, 56320, 57343))
					{
						num2 = 65533;
						chars2++;
					}
					goto IL_0169;
				}
				if (encoderFallbackBuffer != null)
				{
					num2 = encoderFallbackBuffer.InternalGetNextChar();
					if (num2 > 0)
					{
						num++;
						goto IL_014d;
					}
				}
				num2 = *chars2;
				chars2++;
			}
			goto IL_014d;
			IL_014d:
			if (InRange(num2, 55296, 56319))
			{
				num--;
				continue;
			}
			goto IL_0169;
			IL_0169:
			if (InRange(num2, 55296, 57343))
			{
				if (encoderFallbackBuffer == null)
				{
					encoderFallbackBuffer = ((baseEncoder != null) ? baseEncoder.FallbackBuffer : encoderFallback.CreateFallbackBuffer());
					encoderFallbackBuffer.InternalInitialize(chars, chars + count, baseEncoder, setEncoder: false);
				}
				encoderFallbackBuffer.InternalFallback((char)num2, ref chars2);
				num--;
				num2 = 0;
				continue;
			}
			if (num2 > 127)
			{
				if (num2 > 2047)
				{
					num++;
				}
				num++;
			}
			if (encoderFallbackBuffer != null && (num2 = encoderFallbackBuffer.InternalGetNextChar()) != 0)
			{
				num++;
				goto IL_014d;
			}
			int num3 = PtrDiff(ptr, chars2);
			if (num3 <= 13)
			{
				char* ptr2 = ptr;
				while (chars2 < ptr2)
				{
					num2 = *chars2;
					chars2++;
					if (num2 <= 127)
					{
						continue;
					}
					goto IL_014d;
				}
				break;
			}
			char* ptr3 = chars2 + num3 - 7;
			while (chars2 < ptr3)
			{
				num2 = *chars2;
				chars2++;
				if (num2 > 127)
				{
					if (num2 > 2047)
					{
						if ((num2 & 0xF800) == 55296)
						{
							goto IL_0389;
						}
						num++;
					}
					num++;
				}
				if (((int)chars2 & 2) != 0)
				{
					num2 = *chars2;
					chars2++;
					if (num2 > 127)
					{
						if (num2 > 2047)
						{
							if ((num2 & 0xF800) == 55296)
							{
								goto IL_0389;
							}
							num++;
						}
						num++;
					}
				}
				for (; chars2 < ptr3; chars2 += 4)
				{
					num2 = *(int*)chars2;
					int num4 = *(int*)(chars2 + 2);
					if (((num2 | num4) & -8323200) != 0)
					{
						if (((num2 | num4) & -134154240) != 0)
						{
							goto IL_037a;
						}
						if ((num2 & -8388608) != 0)
						{
							num++;
						}
						if ((num2 & 0xFF80) != 0)
						{
							num++;
						}
						if ((num4 & -8388608) != 0)
						{
							num++;
						}
						if ((num4 & 0xFF80) != 0)
						{
							num++;
						}
					}
					chars2 += 4;
					num2 = *(int*)chars2;
					num4 = *(int*)(chars2 + 2);
					if (((num2 | num4) & -8323200) == 0)
					{
						continue;
					}
					if (((num2 | num4) & -134154240) == 0)
					{
						if ((num2 & -8388608) != 0)
						{
							num++;
						}
						if ((num2 & 0xFF80) != 0)
						{
							num++;
						}
						if ((num4 & -8388608) != 0)
						{
							num++;
						}
						if ((num4 & 0xFF80) != 0)
						{
							num++;
						}
						continue;
					}
					goto IL_037a;
				}
				break;
				IL_0389:
				if (num2 > 2047)
				{
					if (InRange(num2, 55296, 57343))
					{
						int ch2 = *chars2;
						if (num2 > 56319 || !InRange(ch2, 56320, 57343))
						{
							chars2--;
							break;
						}
						chars2++;
					}
					num++;
				}
				num++;
				continue;
				IL_037a:
				num2 = (ushort)num2;
				chars2++;
				if (num2 <= 127)
				{
					continue;
				}
				goto IL_0389;
			}
			num2 = 0;
			continue;
			IL_00e6:
			if (num2 <= 0 || (baseEncoder != null && !baseEncoder.MustFlush))
			{
				break;
			}
			num++;
			goto IL_0169;
		}
		return num;
	}

	[SecurityCritical]
	private unsafe static int PtrDiff(char* a, char* b)
	{
		return (int)((uint)((byte*)a - (byte*)b) >> 1);
	}

	[SecurityCritical]
	private unsafe static int PtrDiff(byte* a, byte* b)
	{
		return (int)(a - b);
	}

	private static bool InRange(int ch, int start, int end)
	{
		return (uint)(ch - start) <= (uint)(end - start);
	}

	[SecurityCritical]
	internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder)
	{
		UTF8Encoder uTF8Encoder = null;
		EncoderFallbackBuffer encoderFallbackBuffer = null;
		char* chars2 = chars;
		byte* ptr = bytes;
		char* ptr2 = chars2 + charCount;
		byte* ptr3 = ptr + byteCount;
		int num = 0;
		if (baseEncoder != null)
		{
			uTF8Encoder = (UTF8Encoder)baseEncoder;
			num = uTF8Encoder.surrogateChar;
			if (uTF8Encoder.InternalHasFallbackBuffer)
			{
				encoderFallbackBuffer = uTF8Encoder.FallbackBuffer;
				if (encoderFallbackBuffer.Remaining > 0 && uTF8Encoder.m_throwOnOverflow)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_EncoderFallbackNotEmpty", EncodingName, uTF8Encoder.Fallback.GetType()));
				}
				encoderFallbackBuffer.InternalInitialize(chars, ptr2, uTF8Encoder, setEncoder: true);
			}
		}
		while (true)
		{
			if (chars2 >= ptr2)
			{
				if (num == 0)
				{
					num = encoderFallbackBuffer?.InternalGetNextChar() ?? '\0';
					if (num <= 0)
					{
						goto IL_00ef;
					}
				}
				else
				{
					if (encoderFallbackBuffer == null || !encoderFallbackBuffer.bFallingBack)
					{
						goto IL_00ef;
					}
					int num2 = num;
					num = encoderFallbackBuffer.InternalGetNextChar();
					if (InRange(num, 56320, 57343))
					{
						num = num + (num2 << 10) + -56613888;
						goto IL_0167;
					}
					if (num <= 0)
					{
						break;
					}
				}
			}
			else
			{
				if (num > 0)
				{
					int num3 = *chars2;
					if (InRange(num3, 56320, 57343))
					{
						num = num3 + (num << 10) + -56613888;
						chars2++;
					}
					goto IL_0167;
				}
				if (encoderFallbackBuffer != null)
				{
					num = encoderFallbackBuffer.InternalGetNextChar();
					if (num > 0)
					{
						goto IL_0151;
					}
				}
				num = *chars2;
				chars2++;
			}
			goto IL_0151;
			IL_0167:
			if (InRange(num, 55296, 57343))
			{
				if (encoderFallbackBuffer == null)
				{
					encoderFallbackBuffer = ((baseEncoder != null) ? baseEncoder.FallbackBuffer : encoderFallback.CreateFallbackBuffer());
					encoderFallbackBuffer.InternalInitialize(chars, ptr2, baseEncoder, setEncoder: true);
				}
				encoderFallbackBuffer.InternalFallback((char)num, ref chars2);
				num = 0;
				continue;
			}
			int num4 = 1;
			if (num > 127)
			{
				if (num > 2047)
				{
					if (num > 65535)
					{
						num4++;
					}
					num4++;
				}
				num4++;
			}
			if (ptr > ptr3 - num4)
			{
				if (encoderFallbackBuffer != null && encoderFallbackBuffer.bFallingBack)
				{
					encoderFallbackBuffer.MovePrevious();
					if (num > 65535)
					{
						encoderFallbackBuffer.MovePrevious();
					}
				}
				else
				{
					chars2--;
					if (num > 65535)
					{
						chars2--;
					}
				}
				ThrowBytesOverflow(uTF8Encoder, ptr == bytes);
				num = 0;
				break;
			}
			if (num <= 127)
			{
				*ptr = (byte)num;
			}
			else
			{
				int num5;
				if (num <= 2047)
				{
					num5 = (byte)(-64 | (num >> 6));
				}
				else
				{
					if (num <= 65535)
					{
						num5 = (byte)(-32 | (num >> 12));
					}
					else
					{
						*ptr = (byte)(-16 | (num >> 18));
						ptr++;
						num5 = -128 | ((num >> 12) & 0x3F);
					}
					*ptr = (byte)num5;
					ptr++;
					num5 = -128 | ((num >> 6) & 0x3F);
				}
				*ptr = (byte)num5;
				ptr++;
				*ptr = (byte)(-128 | (num & 0x3F));
			}
			ptr++;
			if (encoderFallbackBuffer == null || (num = encoderFallbackBuffer.InternalGetNextChar()) == 0)
			{
				int num6 = PtrDiff(ptr2, chars2);
				int num7 = PtrDiff(ptr3, ptr);
				if (num6 <= 13)
				{
					if (num7 < num6)
					{
						num = 0;
						continue;
					}
					char* ptr4 = ptr2;
					while (chars2 < ptr4)
					{
						num = *chars2;
						chars2++;
						if (num <= 127)
						{
							*ptr = (byte)num;
							ptr++;
							continue;
						}
						goto IL_0151;
					}
					num = 0;
					break;
				}
				if (num7 < num6)
				{
					num6 = num7;
				}
				char* ptr5 = chars2 + num6 - 5;
				while (chars2 < ptr5)
				{
					num = *chars2;
					chars2++;
					if (num <= 127)
					{
						*ptr = (byte)num;
						ptr++;
						if (((int)chars2 & 2) != 0)
						{
							num = *chars2;
							chars2++;
							if (num > 127)
							{
								goto IL_03dd;
							}
							*ptr = (byte)num;
							ptr++;
						}
						while (chars2 < ptr5)
						{
							num = *(int*)chars2;
							int num8 = *(int*)(chars2 + 2);
							if (((num | num8) & -8323200) == 0)
							{
								*ptr = (byte)num;
								ptr[1] = (byte)(num >> 16);
								chars2 += 4;
								ptr[2] = (byte)num8;
								ptr[3] = (byte)(num8 >> 16);
								ptr += 4;
								continue;
							}
							goto IL_03c0;
						}
						continue;
					}
					goto IL_03dd;
					IL_03c0:
					num = (ushort)num;
					chars2++;
					if (num <= 127)
					{
						*ptr = (byte)num;
						ptr++;
						continue;
					}
					goto IL_03dd;
					IL_03dd:
					int num9;
					if (num <= 2047)
					{
						num9 = -64 | (num >> 6);
					}
					else
					{
						if (!InRange(num, 55296, 57343))
						{
							num9 = -32 | (num >> 12);
						}
						else
						{
							if (num > 56319)
							{
								chars2--;
								break;
							}
							num9 = *chars2;
							chars2++;
							if (!InRange(num9, 56320, 57343))
							{
								chars2 -= 2;
								break;
							}
							num = num9 + (num << 10) + -56613888;
							*ptr = (byte)(-16 | (num >> 18));
							ptr++;
							num9 = -128 | ((num >> 12) & 0x3F);
						}
						*ptr = (byte)num9;
						ptr5--;
						ptr++;
						num9 = -128 | ((num >> 6) & 0x3F);
					}
					*ptr = (byte)num9;
					ptr5--;
					ptr++;
					*ptr = (byte)(-128 | (num & 0x3F));
					ptr++;
				}
				num = 0;
				continue;
			}
			goto IL_0151;
			IL_00ef:
			if (num <= 0 || (uTF8Encoder != null && !uTF8Encoder.MustFlush))
			{
				break;
			}
			goto IL_0167;
			IL_0151:
			if (InRange(num, 55296, 56319))
			{
				continue;
			}
			goto IL_0167;
		}
		if (uTF8Encoder != null)
		{
			uTF8Encoder.surrogateChar = num;
			uTF8Encoder.m_charsUsed = (int)(chars2 - chars);
		}
		return (int)(ptr - bytes);
	}

	[SecurityCritical]
	internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
	{
		byte* ptr = bytes;
		byte* ptr2 = ptr + count;
		int num = count;
		int num2 = 0;
		DecoderFallbackBuffer decoderFallbackBuffer = null;
		if (baseDecoder != null)
		{
			UTF8Decoder uTF8Decoder = (UTF8Decoder)baseDecoder;
			num2 = uTF8Decoder.bits;
			num -= num2 >> 30;
		}
		while (ptr < ptr2)
		{
			if (num2 != 0)
			{
				int num3 = *ptr;
				ptr++;
				if ((num3 & -64) != 128)
				{
					ptr--;
					num += num2 >> 30;
				}
				else
				{
					num2 = (num2 << 6) | (num3 & 0x3F);
					if ((num2 & 0x20000000) != 0)
					{
						if ((num2 & 0x101F0000) == 268435456)
						{
							num--;
						}
						goto IL_0180;
					}
					if ((num2 & 0x10000000) != 0)
					{
						if ((num2 & 0x800000) != 0 || InRange(num2 & 0x1F0, 16, 256))
						{
							continue;
						}
					}
					else if ((num2 & 0x3E0) != 0 && (num2 & 0x3E0) != 864)
					{
						continue;
					}
				}
				goto IL_00c7;
			}
			num2 = *ptr;
			ptr++;
			goto IL_010a;
			IL_0180:
			int num4 = PtrDiff(ptr2, ptr);
			if (num4 <= 13)
			{
				byte* ptr3 = ptr2;
				while (ptr < ptr3)
				{
					num2 = *ptr;
					ptr++;
					if (num2 <= 127)
					{
						continue;
					}
					goto IL_010a;
				}
				num2 = 0;
				break;
			}
			byte* ptr4 = ptr + num4 - 7;
			while (true)
			{
				if (ptr < ptr4)
				{
					num2 = *ptr;
					ptr++;
					if (num2 > 127)
					{
						goto IL_024d;
					}
					if (((int)ptr & 1) != 0)
					{
						num2 = *ptr;
						ptr++;
						if (num2 > 127)
						{
							goto IL_024d;
						}
					}
					if (((int)ptr & 2) != 0)
					{
						num2 = *(ushort*)ptr;
						if ((num2 & 0x8080) != 0)
						{
							goto IL_0239;
						}
						ptr += 2;
					}
					while (ptr < ptr4)
					{
						num2 = *(int*)ptr;
						int num5 = ((int*)ptr)[1];
						if (((num2 | num5) & -2139062144) == 0)
						{
							ptr += 8;
							if (ptr >= ptr4)
							{
								break;
							}
							num2 = *(int*)ptr;
							num5 = ((int*)ptr)[1];
							if (((num2 | num5) & -2139062144) == 0)
							{
								ptr += 8;
								continue;
							}
						}
						goto IL_0239;
					}
				}
				num2 = 0;
				break;
				IL_024d:
				int num6 = *ptr;
				ptr++;
				if ((num2 & 0x40) != 0 && (num6 & -64) == 128)
				{
					num6 &= 0x3F;
					if ((num2 & 0x20) != 0)
					{
						num6 |= (num2 & 0xF) << 6;
						if ((num2 & 0x10) != 0)
						{
							num2 = *ptr;
							if (InRange(num6 >> 4, 1, 16) && (num2 & -64) == 128)
							{
								num6 = (num6 << 6) | (num2 & 0x3F);
								num2 = ptr[1];
								if ((num2 & -64) == 128)
								{
									ptr += 2;
									num--;
									goto IL_0306;
								}
							}
						}
						else
						{
							num2 = *ptr;
							if ((num6 & 0x3E0) != 0 && (num6 & 0x3E0) != 864 && (num2 & -64) == 128)
							{
								ptr++;
								num--;
								goto IL_0306;
							}
						}
					}
					else if ((num2 & 0x1E) != 0)
					{
						goto IL_0306;
					}
				}
				ptr -= 2;
				num2 = 0;
				break;
				IL_0306:
				num--;
				continue;
				IL_0239:
				num2 &= 0xFF;
				ptr++;
				if (num2 <= 127)
				{
					continue;
				}
				goto IL_024d;
			}
			continue;
			IL_00c7:
			if (decoderFallbackBuffer == null)
			{
				decoderFallbackBuffer = ((baseDecoder != null) ? baseDecoder.FallbackBuffer : decoderFallback.CreateFallbackBuffer());
				decoderFallbackBuffer.InternalInitialize(bytes, null);
			}
			num += FallbackInvalidByteSequence(ptr, num2, decoderFallbackBuffer);
			num2 = 0;
			continue;
			IL_010a:
			if (num2 > 127)
			{
				num--;
				if ((num2 & 0x40) != 0)
				{
					if ((num2 & 0x20) != 0)
					{
						if ((num2 & 0x10) == 0)
						{
							num2 = (num2 & 0xF) | 0x48228000;
							num--;
							continue;
						}
						num2 &= 0xF;
						if (num2 <= 4)
						{
							num2 |= 0x504D0C00;
							num--;
							continue;
						}
						num2 |= 0xF0;
					}
					else
					{
						num2 &= 0x1F;
						if (num2 > 1)
						{
							num2 |= 0x800000;
							continue;
						}
						num2 |= 0xC0;
					}
				}
				goto IL_00c7;
			}
			goto IL_0180;
		}
		if (num2 != 0)
		{
			num += num2 >> 30;
			if (baseDecoder == null || baseDecoder.MustFlush)
			{
				if (decoderFallbackBuffer == null)
				{
					decoderFallbackBuffer = ((baseDecoder != null) ? baseDecoder.FallbackBuffer : decoderFallback.CreateFallbackBuffer());
					decoderFallbackBuffer.InternalInitialize(bytes, null);
				}
				num += FallbackInvalidByteSequence(ptr, num2, decoderFallbackBuffer);
			}
		}
		return num;
	}

	[SecurityCritical]
	internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
	{
		byte* pSrc = bytes;
		char* pTarget = chars;
		byte* ptr = pSrc + byteCount;
		char* ptr2 = pTarget + charCount;
		int num = 0;
		DecoderFallbackBuffer decoderFallbackBuffer = null;
		if (baseDecoder != null)
		{
			UTF8Decoder uTF8Decoder = (UTF8Decoder)baseDecoder;
			num = uTF8Decoder.bits;
		}
		while (pSrc < ptr)
		{
			if (num != 0)
			{
				int num2 = *pSrc;
				pSrc++;
				if ((num2 & -64) != 128)
				{
					pSrc--;
				}
				else
				{
					num = (num << 6) | (num2 & 0x3F);
					if ((num & 0x20000000) != 0)
					{
						if ((num & 0x101F0000) > 268435456 && pTarget < ptr2)
						{
							*pTarget = (char)(((num >> 10) & 0x7FF) + -10304);
							pTarget++;
							num = (num & 0x3FF) + 56320;
						}
						goto IL_01e2;
					}
					if ((num & 0x10000000) != 0)
					{
						if ((num & 0x800000) != 0 || InRange(num & 0x1F0, 16, 256))
						{
							continue;
						}
					}
					else if ((num & 0x3E0) != 0 && (num & 0x3E0) != 864)
					{
						continue;
					}
				}
				goto IL_00fd;
			}
			num = *pSrc;
			pSrc++;
			goto IL_0161;
			IL_01e2:
			if (pTarget >= ptr2)
			{
				num &= 0x1FFFFF;
				if (num > 127)
				{
					if (num > 2047)
					{
						if (num >= 56320 && num <= 57343)
						{
							pSrc--;
							pTarget--;
						}
						else if (num > 65535)
						{
							pSrc--;
						}
						pSrc--;
					}
					pSrc--;
				}
				pSrc--;
				ThrowCharsOverflow(baseDecoder, pTarget == chars);
				num = 0;
				break;
			}
			*pTarget = (char)num;
			pTarget++;
			int num3 = PtrDiff(ptr2, pTarget);
			int num4 = PtrDiff(ptr, pSrc);
			if (num4 <= 13)
			{
				if (num3 < num4)
				{
					num = 0;
					continue;
				}
				byte* ptr3 = ptr;
				while (pSrc < ptr3)
				{
					num = *pSrc;
					pSrc++;
					if (num <= 127)
					{
						*pTarget = (char)num;
						pTarget++;
						continue;
					}
					goto IL_0161;
				}
				num = 0;
				break;
			}
			if (num3 < num4)
			{
				num4 = num3;
			}
			char* ptr4 = pTarget + num4 - 7;
			while (true)
			{
				if (pTarget < ptr4)
				{
					num = *pSrc;
					pSrc++;
					if (num > 127)
					{
						goto IL_03fc;
					}
					*pTarget = (char)num;
					pTarget++;
					if (((int)pSrc & 1) != 0)
					{
						num = *pSrc;
						pSrc++;
						if (num > 127)
						{
							goto IL_03fc;
						}
						*pTarget = (char)num;
						pTarget++;
					}
					if (((int)pSrc & 2) != 0)
					{
						num = *(ushort*)pSrc;
						if ((num & 0x8080) != 0)
						{
							goto IL_03da;
						}
						*pTarget = (char)(num & 0x7F);
						pSrc += 2;
						pTarget[1] = (char)((num >> 8) & 0x7F);
						pTarget += 2;
					}
					while (pTarget < ptr4)
					{
						num = *(int*)pSrc;
						int num5 = ((int*)pSrc)[1];
						if (((num | num5) & -2139062144) == 0)
						{
							*pTarget = (char)(num & 0x7F);
							pTarget[1] = (char)((num >> 8) & 0x7F);
							pTarget[2] = (char)((num >> 16) & 0x7F);
							pTarget[3] = (char)((num >> 24) & 0x7F);
							pSrc += 8;
							pTarget[4] = (char)(num5 & 0x7F);
							pTarget[5] = (char)((num5 >> 8) & 0x7F);
							pTarget[6] = (char)((num5 >> 16) & 0x7F);
							pTarget[7] = (char)((num5 >> 24) & 0x7F);
							pTarget += 8;
							continue;
						}
						goto IL_03da;
					}
				}
				num = 0;
				break;
				IL_03fc:
				int num6 = *pSrc;
				pSrc++;
				if ((num & 0x40) != 0 && (num6 & -64) == 128)
				{
					num6 &= 0x3F;
					if ((num & 0x20) != 0)
					{
						num6 |= (num & 0xF) << 6;
						if ((num & 0x10) != 0)
						{
							num = *pSrc;
							if (InRange(num6 >> 4, 1, 16) && (num & -64) == 128)
							{
								num6 = (num6 << 6) | (num & 0x3F);
								num = pSrc[1];
								if ((num & -64) == 128)
								{
									pSrc += 2;
									num = (num6 << 6) | (num & 0x3F);
									*pTarget = (char)(((num >> 10) & 0x7FF) + -10304);
									pTarget++;
									num = (num & 0x3FF) + -9216;
									ptr4--;
									goto IL_051f;
								}
							}
						}
						else
						{
							num = *pSrc;
							if ((num6 & 0x3E0) != 0 && (num6 & 0x3E0) != 864 && (num & -64) == 128)
							{
								pSrc++;
								num = (num6 << 6) | (num & 0x3F);
								ptr4--;
								goto IL_051f;
							}
						}
					}
					else
					{
						num &= 0x1F;
						if (num > 1)
						{
							num = (num << 6) | num6;
							goto IL_051f;
						}
					}
				}
				pSrc -= 2;
				num = 0;
				break;
				IL_051f:
				*pTarget = (char)num;
				pTarget++;
				ptr4--;
				continue;
				IL_03da:
				num &= 0xFF;
				pSrc++;
				if (num <= 127)
				{
					*pTarget = (char)num;
					pTarget++;
					continue;
				}
				goto IL_03fc;
			}
			continue;
			IL_0161:
			if (num > 127)
			{
				if ((num & 0x40) != 0)
				{
					if ((num & 0x20) != 0)
					{
						if ((num & 0x10) == 0)
						{
							num = (num & 0xF) | 0x48228000;
							continue;
						}
						num &= 0xF;
						if (num <= 4)
						{
							num |= 0x504D0C00;
							continue;
						}
						num |= 0xF0;
					}
					else
					{
						num &= 0x1F;
						if (num > 1)
						{
							num |= 0x800000;
							continue;
						}
						num |= 0xC0;
					}
				}
				goto IL_00fd;
			}
			goto IL_01e2;
			IL_00fd:
			if (decoderFallbackBuffer == null)
			{
				decoderFallbackBuffer = ((baseDecoder != null) ? baseDecoder.FallbackBuffer : decoderFallback.CreateFallbackBuffer());
				decoderFallbackBuffer.InternalInitialize(bytes, ptr2);
			}
			if (!FallbackInvalidByteSequence(ref pSrc, num, decoderFallbackBuffer, ref pTarget))
			{
				decoderFallbackBuffer.InternalReset();
				ThrowCharsOverflow(baseDecoder, pTarget == chars);
				num = 0;
				break;
			}
			num = 0;
		}
		if (num != 0 && (baseDecoder == null || baseDecoder.MustFlush))
		{
			if (decoderFallbackBuffer == null)
			{
				decoderFallbackBuffer = ((baseDecoder != null) ? baseDecoder.FallbackBuffer : decoderFallback.CreateFallbackBuffer());
				decoderFallbackBuffer.InternalInitialize(bytes, ptr2);
			}
			if (!FallbackInvalidByteSequence(ref pSrc, num, decoderFallbackBuffer, ref pTarget))
			{
				decoderFallbackBuffer.InternalReset();
				ThrowCharsOverflow(baseDecoder, pTarget == chars);
			}
			num = 0;
		}
		if (baseDecoder != null)
		{
			UTF8Decoder uTF8Decoder2 = (UTF8Decoder)baseDecoder;
			uTF8Decoder2.bits = num;
			baseDecoder.m_bytesUsed = (int)(pSrc - bytes);
		}
		return PtrDiff(pTarget, chars);
	}

	[SecurityCritical]
	private unsafe bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget)
	{
		byte* pSrc2 = pSrc;
		byte[] bytesUnknown = GetBytesUnknown(ref pSrc2, ch);
		if (!fallback.InternalFallback(bytesUnknown, pSrc, ref pTarget))
		{
			pSrc = pSrc2;
			return false;
		}
		return true;
	}

	[SecurityCritical]
	private unsafe int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback)
	{
		byte[] bytesUnknown = GetBytesUnknown(ref pSrc, ch);
		return fallback.InternalFallback(bytesUnknown, pSrc);
	}

	[SecurityCritical]
	private unsafe byte[] GetBytesUnknown(ref byte* pSrc, int ch)
	{
		byte[] array = null;
		if (ch < 256 && ch >= 0)
		{
			pSrc--;
			return new byte[1] { (byte)ch };
		}
		if ((ch & 0x18000000) == 0)
		{
			pSrc--;
			return new byte[1] { (byte)((ch & 0x1F) | 0xC0) };
		}
		if ((ch & 0x10000000) != 0)
		{
			if ((ch & 0x800000) != 0)
			{
				pSrc -= 3;
				return new byte[3]
				{
					(byte)(((ch >> 12) & 7) | 0xF0),
					(byte)(((ch >> 6) & 0x3F) | 0x80),
					(byte)((ch & 0x3F) | 0x80)
				};
			}
			if ((ch & 0x20000) != 0)
			{
				pSrc -= 2;
				return new byte[2]
				{
					(byte)(((ch >> 6) & 7) | 0xF0),
					(byte)((ch & 0x3F) | 0x80)
				};
			}
			pSrc--;
			return new byte[1] { (byte)((ch & 7) | 0xF0) };
		}
		if ((ch & 0x800000) != 0)
		{
			pSrc -= 2;
			return new byte[2]
			{
				(byte)(((ch >> 6) & 0xF) | 0xE0),
				(byte)((ch & 0x3F) | 0x80)
			};
		}
		pSrc--;
		return new byte[1] { (byte)((ch & 0xF) | 0xE0) };
	}

	[__DynamicallyInvokable]
	public override Decoder GetDecoder()
	{
		return new UTF8Decoder(this);
	}

	[__DynamicallyInvokable]
	public override Encoder GetEncoder()
	{
		return new UTF8Encoder(this);
	}

	[__DynamicallyInvokable]
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
		num *= 3;
		if (num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("charCount", Environment.GetResourceString("ArgumentOutOfRange_GetByteCountOverflow"));
		}
		return (int)num;
	}

	[__DynamicallyInvokable]
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

	[__DynamicallyInvokable]
	public override byte[] GetPreamble()
	{
		if (emitUTF8Identifier)
		{
			return new byte[3] { 239, 187, 191 };
		}
		return EmptyArray<byte>.Value;
	}

	[__DynamicallyInvokable]
	public override bool Equals(object value)
	{
		if (value is UTF8Encoding uTF8Encoding)
		{
			if (emitUTF8Identifier == uTF8Encoding.emitUTF8Identifier && base.EncoderFallback.Equals(uTF8Encoding.EncoderFallback))
			{
				return base.DecoderFallback.Equals(uTF8Encoding.DecoderFallback);
			}
			return false;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return base.EncoderFallback.GetHashCode() + base.DecoderFallback.GetHashCode() + 65001 + (emitUTF8Identifier ? 1 : 0);
	}
}
