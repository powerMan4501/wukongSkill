using System.Security;

namespace System.Text;

public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
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

	public EncoderReplacementFallbackBuffer(EncoderReplacementFallback fallback)
	{
		strDefault = fallback.DefaultString + fallback.DefaultString;
	}

	public override bool Fallback(char charUnknown, int index)
	{
		if (fallbackCount >= 1)
		{
			if (char.IsHighSurrogate(charUnknown) && fallbackCount >= 0 && char.IsLowSurrogate(strDefault[fallbackIndex + 1]))
			{
				ThrowLastCharRecursive(char.ConvertToUtf32(charUnknown, strDefault[fallbackIndex + 1]));
			}
			ThrowLastCharRecursive(charUnknown);
		}
		fallbackCount = strDefault.Length / 2;
		fallbackIndex = -1;
		return fallbackCount != 0;
	}

	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
	{
		if (!char.IsHighSurrogate(charUnknownHigh))
		{
			throw new ArgumentOutOfRangeException("charUnknownHigh", Environment.GetResourceString("ArgumentOutOfRange_Range", 55296, 56319));
		}
		if (!char.IsLowSurrogate(charUnknownLow))
		{
			throw new ArgumentOutOfRangeException("CharUnknownLow", Environment.GetResourceString("ArgumentOutOfRange_Range", 56320, 57343));
		}
		if (fallbackCount >= 1)
		{
			ThrowLastCharRecursive(char.ConvertToUtf32(charUnknownHigh, charUnknownLow));
		}
		fallbackCount = strDefault.Length;
		fallbackIndex = -1;
		return fallbackCount != 0;
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
		fallbackIndex = 0;
		charStart = null;
		bFallingBack = false;
	}
}
