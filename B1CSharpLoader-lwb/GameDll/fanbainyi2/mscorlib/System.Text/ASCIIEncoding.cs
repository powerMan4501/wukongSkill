using System.Runtime.InteropServices;
using System.Security;

namespace System.Text;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class ASCIIEncoding : Encoding
{
	[ComVisible(false)]
	[__DynamicallyInvokable]
	public override bool IsSingleByte
	{
		[__DynamicallyInvokable]
		get
		{
			return true;
		}
	}

	[__DynamicallyInvokable]
	public ASCIIEncoding()
		: base(20127)
	{
	}

	internal override void SetDefaultFallbacks()
	{
		encoderFallback = EncoderFallback.ReplacementFallback;
		decoderFallback = DecoderFallback.ReplacementFallback;
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
			throw new ArgumentNullException("chars");
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
	public unsafe override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
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
			throw new ArgumentOutOfRangeException("chars", Environment.GetResourceString("ArgumentOutOfRange_IndexCount"));
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
		fixed (char* ptr = chars)
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
	[__DynamicallyInvokable]
	public unsafe override string GetString(byte[] bytes, int byteIndex, int byteCount)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes", Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (byteIndex < 0 || byteCount < 0)
		{
			throw new ArgumentOutOfRangeException((byteIndex < 0) ? "byteIndex" : "byteCount", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (bytes.Length - byteIndex < byteCount)
		{
			throw new ArgumentOutOfRangeException("bytes", Environment.GetResourceString("ArgumentOutOfRange_IndexCountBuffer"));
		}
		if (bytes.Length == 0)
		{
			return string.Empty;
		}
		fixed (byte* ptr = bytes)
		{
			return string.CreateStringFromEncoding(ptr + byteIndex, byteCount, this);
		}
	}

	[SecurityCritical]
	internal unsafe override int GetByteCount(char* chars, int charCount, EncoderNLS encoder)
	{
		char c = '\0';
		EncoderReplacementFallback encoderReplacementFallback = null;
		char* ptr = chars + charCount;
		EncoderFallbackBuffer encoderFallbackBuffer = null;
		if (encoder != null)
		{
			c = encoder.charLeftOver;
			encoderReplacementFallback = encoder.Fallback as EncoderReplacementFallback;
			if (encoder.InternalHasFallbackBuffer)
			{
				encoderFallbackBuffer = encoder.FallbackBuffer;
				if (encoderFallbackBuffer.Remaining > 0 && encoder.m_throwOnOverflow)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_EncoderFallbackNotEmpty", EncodingName, encoder.Fallback.GetType()));
				}
				encoderFallbackBuffer.InternalInitialize(chars, ptr, encoder, setEncoder: false);
			}
		}
		else
		{
			encoderReplacementFallback = base.EncoderFallback as EncoderReplacementFallback;
		}
		if (encoderReplacementFallback != null && encoderReplacementFallback.MaxCharCount == 1)
		{
			if (c > '\0')
			{
				charCount++;
			}
			return charCount;
		}
		int num = 0;
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
			if (c2 > '\u007f')
			{
				if (encoderFallbackBuffer == null)
				{
					encoderFallbackBuffer = ((encoder != null) ? encoder.FallbackBuffer : encoderFallback.CreateFallbackBuffer());
					encoderFallbackBuffer.InternalInitialize(ptr - charCount, ptr, encoder, setEncoder: false);
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
		char c = '\0';
		EncoderReplacementFallback encoderReplacementFallback = null;
		EncoderFallbackBuffer encoderFallbackBuffer = null;
		char* ptr = chars + charCount;
		byte* ptr2 = bytes;
		char* ptr3 = chars;
		if (encoder != null)
		{
			c = encoder.charLeftOver;
			encoderReplacementFallback = encoder.Fallback as EncoderReplacementFallback;
			if (encoder.InternalHasFallbackBuffer)
			{
				encoderFallbackBuffer = encoder.FallbackBuffer;
				if (encoderFallbackBuffer.Remaining > 0 && encoder.m_throwOnOverflow)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_EncoderFallbackNotEmpty", EncodingName, encoder.Fallback.GetType()));
				}
				encoderFallbackBuffer.InternalInitialize(ptr3, ptr, encoder, setEncoder: true);
			}
		}
		else
		{
			encoderReplacementFallback = base.EncoderFallback as EncoderReplacementFallback;
		}
		if (encoderReplacementFallback != null && encoderReplacementFallback.MaxCharCount == 1)
		{
			char c2 = encoderReplacementFallback.DefaultString[0];
			if (c2 <= '\u007f')
			{
				if (c > '\0')
				{
					if (byteCount == 0)
					{
						ThrowBytesOverflow(encoder, nothingEncoded: true);
					}
					*(bytes++) = (byte)c2;
					byteCount--;
				}
				if (byteCount < charCount)
				{
					ThrowBytesOverflow(encoder, byteCount < 1);
					ptr = chars + byteCount;
				}
				while (chars < ptr)
				{
					char c3 = *(chars++);
					if (c3 >= '\u0080')
					{
						*(bytes++) = (byte)c2;
					}
					else
					{
						*(bytes++) = (byte)c3;
					}
				}
				if (encoder != null)
				{
					encoder.charLeftOver = '\0';
					encoder.m_charsUsed = (int)(chars - ptr3);
				}
				return (int)(bytes - ptr2);
			}
		}
		byte* ptr4 = bytes + byteCount;
		if (c > '\0')
		{
			encoderFallbackBuffer = encoder.FallbackBuffer;
			encoderFallbackBuffer.InternalInitialize(chars, ptr, encoder, setEncoder: true);
			encoderFallbackBuffer.InternalFallback(c, ref chars);
		}
		while (true)
		{
			char num = encoderFallbackBuffer?.InternalGetNextChar() ?? '\0';
			char c4 = num;
			if (num == '\0' && chars >= ptr)
			{
				break;
			}
			if (c4 == '\0')
			{
				c4 = *chars;
				chars++;
			}
			if (c4 > '\u007f')
			{
				if (encoderFallbackBuffer == null)
				{
					encoderFallbackBuffer = ((encoder != null) ? encoder.FallbackBuffer : encoderFallback.CreateFallbackBuffer());
					encoderFallbackBuffer.InternalInitialize(ptr - charCount, ptr, encoder, setEncoder: true);
				}
				encoderFallbackBuffer.InternalFallback(c4, ref chars);
				continue;
			}
			if (bytes >= ptr4)
			{
				if (encoderFallbackBuffer == null || !encoderFallbackBuffer.bFallingBack)
				{
					chars--;
				}
				else
				{
					encoderFallbackBuffer.MovePrevious();
				}
				ThrowBytesOverflow(encoder, bytes == ptr2);
				break;
			}
			*bytes = (byte)c4;
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
		DecoderReplacementFallback decoderReplacementFallback = null;
		decoderReplacementFallback = ((decoder != null) ? (decoder.Fallback as DecoderReplacementFallback) : (base.DecoderFallback as DecoderReplacementFallback));
		if (decoderReplacementFallback != null && decoderReplacementFallback.MaxCharCount == 1)
		{
			return count;
		}
		DecoderFallbackBuffer decoderFallbackBuffer = null;
		int num = count;
		byte[] array = new byte[1];
		byte* ptr = bytes + count;
		while (bytes < ptr)
		{
			byte b = *bytes;
			bytes++;
			if (b >= 128)
			{
				if (decoderFallbackBuffer == null)
				{
					decoderFallbackBuffer = ((decoder != null) ? decoder.FallbackBuffer : base.DecoderFallback.CreateFallbackBuffer());
					decoderFallbackBuffer.InternalInitialize(ptr - count, null);
				}
				array[0] = b;
				num--;
				num += decoderFallbackBuffer.InternalFallback(array, bytes);
			}
		}
		return num;
	}

	[SecurityCritical]
	internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
	{
		byte* ptr = bytes + byteCount;
		byte* ptr2 = bytes;
		char* ptr3 = chars;
		DecoderReplacementFallback decoderReplacementFallback = null;
		decoderReplacementFallback = ((decoder != null) ? (decoder.Fallback as DecoderReplacementFallback) : (base.DecoderFallback as DecoderReplacementFallback));
		if (decoderReplacementFallback != null && decoderReplacementFallback.MaxCharCount == 1)
		{
			char c = decoderReplacementFallback.DefaultString[0];
			if (charCount < byteCount)
			{
				ThrowCharsOverflow(decoder, charCount < 1);
				ptr = bytes + charCount;
			}
			while (bytes < ptr)
			{
				byte b = *(bytes++);
				if (b >= 128)
				{
					*(chars++) = c;
				}
				else
				{
					*(chars++) = (char)b;
				}
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
			byte b2 = *bytes;
			bytes++;
			if (b2 >= 128)
			{
				if (decoderFallbackBuffer == null)
				{
					decoderFallbackBuffer = ((decoder != null) ? decoder.FallbackBuffer : base.DecoderFallback.CreateFallbackBuffer());
					decoderFallbackBuffer.InternalInitialize(ptr - byteCount, ptr4);
				}
				array[0] = b2;
				if (!decoderFallbackBuffer.InternalFallback(array, bytes, ref chars))
				{
					bytes--;
					decoderFallbackBuffer.InternalReset();
					ThrowCharsOverflow(decoder, chars == ptr3);
					break;
				}
			}
			else
			{
				if (chars >= ptr4)
				{
					bytes--;
					ThrowCharsOverflow(decoder, chars == ptr3);
					break;
				}
				*chars = (char)b2;
				chars++;
			}
		}
		if (decoder != null)
		{
			decoder.m_bytesUsed = (int)(bytes - ptr2);
		}
		return (int)(chars - ptr3);
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
	[__DynamicallyInvokable]
	public override Decoder GetDecoder()
	{
		return new DecoderNLS(this);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public override Encoder GetEncoder()
	{
		return new EncoderNLS(this);
	}
}
