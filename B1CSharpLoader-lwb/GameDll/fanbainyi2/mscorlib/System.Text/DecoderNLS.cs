using System.Globalization;
using System.Runtime.Serialization;
using System.Security;

namespace System.Text;

[Serializable]
internal class DecoderNLS : Decoder, ISerializable
{
	protected Encoding m_encoding;

	[NonSerialized]
	protected bool m_mustFlush;

	[NonSerialized]
	internal bool m_throwOnOverflow;

	[NonSerialized]
	internal int m_bytesUsed;

	public bool MustFlush => m_mustFlush;

	internal virtual bool HasState => false;

	internal DecoderNLS(SerializationInfo info, StreamingContext context)
	{
		throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("NotSupported_TypeCannotDeserialized"), GetType()));
	}

	[SecurityCritical]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		SerializeDecoder(info);
		info.AddValue("encoding", m_encoding);
		info.SetType(typeof(Encoding.DefaultDecoder));
	}

	internal DecoderNLS(Encoding encoding)
	{
		m_encoding = encoding;
		m_fallback = m_encoding.DecoderFallback;
		Reset();
	}

	internal DecoderNLS()
	{
		m_encoding = null;
		Reset();
	}

	public override void Reset()
	{
		if (m_fallbackBuffer != null)
		{
			m_fallbackBuffer.Reset();
		}
	}

	public override int GetCharCount(byte[] bytes, int index, int count)
	{
		return GetCharCount(bytes, index, count, flush: false);
	}

	[SecuritySafeCritical]
	public unsafe override int GetCharCount(byte[] bytes, int index, int count, bool flush)
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
			bytes = new byte[1];
		}
		fixed (byte* ptr = bytes)
		{
			return GetCharCount(ptr + index, count, flush);
		}
	}

	[SecurityCritical]
	public unsafe override int GetCharCount(byte* bytes, int count, bool flush)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes", Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		m_mustFlush = flush;
		m_throwOnOverflow = true;
		return m_encoding.GetCharCount(bytes, count, this);
	}

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
	{
		return GetChars(bytes, byteIndex, byteCount, chars, charIndex, flush: false);
	}

	[SecuritySafeCritical]
	public unsafe override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
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
			bytes = new byte[1];
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
				return GetChars(ptr + byteIndex, byteCount, ptr2 + charIndex, charCount, flush);
			}
		}
	}

	[SecurityCritical]
	public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
	{
		if (chars == null || bytes == null)
		{
			throw new ArgumentNullException((chars == null) ? "chars" : "bytes", Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (byteCount < 0 || charCount < 0)
		{
			throw new ArgumentOutOfRangeException((byteCount < 0) ? "byteCount" : "charCount", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		m_mustFlush = flush;
		m_throwOnOverflow = true;
		return m_encoding.GetChars(bytes, byteCount, chars, charCount, this);
	}

	[SecuritySafeCritical]
	public unsafe override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
	{
		if (bytes == null || chars == null)
		{
			throw new ArgumentNullException((bytes == null) ? "bytes" : "chars", Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (byteIndex < 0 || byteCount < 0)
		{
			throw new ArgumentOutOfRangeException((byteIndex < 0) ? "byteIndex" : "byteCount", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (charIndex < 0 || charCount < 0)
		{
			throw new ArgumentOutOfRangeException((charIndex < 0) ? "charIndex" : "charCount", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (bytes.Length - byteIndex < byteCount)
		{
			throw new ArgumentOutOfRangeException("bytes", Environment.GetResourceString("ArgumentOutOfRange_IndexCountBuffer"));
		}
		if (chars.Length - charIndex < charCount)
		{
			throw new ArgumentOutOfRangeException("chars", Environment.GetResourceString("ArgumentOutOfRange_IndexCountBuffer"));
		}
		if (bytes.Length == 0)
		{
			bytes = new byte[1];
		}
		if (chars.Length == 0)
		{
			chars = new char[1];
		}
		fixed (byte* ptr = bytes)
		{
			fixed (char* ptr2 = chars)
			{
				Convert(ptr + byteIndex, byteCount, ptr2 + charIndex, charCount, flush, out bytesUsed, out charsUsed, out completed);
			}
		}
	}

	[SecurityCritical]
	public unsafe override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
	{
		if (chars == null || bytes == null)
		{
			throw new ArgumentNullException((chars == null) ? "chars" : "bytes", Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (byteCount < 0 || charCount < 0)
		{
			throw new ArgumentOutOfRangeException((byteCount < 0) ? "byteCount" : "charCount", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		m_mustFlush = flush;
		m_throwOnOverflow = false;
		m_bytesUsed = 0;
		charsUsed = m_encoding.GetChars(bytes, byteCount, chars, charCount, this);
		bytesUsed = m_bytesUsed;
		completed = bytesUsed == byteCount && (!flush || !HasState) && (m_fallbackBuffer == null || m_fallbackBuffer.Remaining == 0);
	}

	internal void ClearMustFlush()
	{
		m_mustFlush = false;
	}
}
