using System.Security;

namespace System.Text;

public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
{
	private string strDefault;

	private int fallbackCount = -1;

	private int fallbackIndex = -1;

	public override int Remaining
	{
		get
		{
			if (fallbackCount >= 0)
			{
				return fallbackCount;
			}
			return 0;
		}
	}

	public DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback)
	{
		strDefault = fallback.DefaultString;
	}

	public override bool Fallback(byte[] bytesUnknown, int index)
	{
		if (fallbackCount >= 1)
		{
			ThrowLastBytesRecursive(bytesUnknown);
		}
		if (strDefault.Length == 0)
		{
			return false;
		}
		fallbackCount = strDefault.Length;
		fallbackIndex = -1;
		return true;
	}

	public override char GetNextChar()
	{
		fallbackCount--;
		fallbackIndex++;
		if (fallbackCount < 0)
		{
			return '\0';
		}
		if (fallbackCount == int.MaxValue)
		{
			fallbackCount = -1;
			return '\0';
		}
		return strDefault[fallbackIndex];
	}

	public override bool MovePrevious()
	{
		if (fallbackCount >= -1 && fallbackIndex >= 0)
		{
			fallbackIndex--;
			fallbackCount++;
			return true;
		}
		return false;
	}

	[SecuritySafeCritical]
	public unsafe override void Reset()
	{
		fallbackCount = -1;
		fallbackIndex = -1;
		byteStart = null;
	}

	[SecurityCritical]
	internal unsafe override int InternalFallback(byte[] bytes, byte* pBytes)
	{
		return strDefault.Length;
	}
}
