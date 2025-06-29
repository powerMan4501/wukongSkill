namespace System.Text;

public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer
{
	public override int Remaining => 0;

	public override bool Fallback(char charUnknown, int index)
	{
		throw new EncoderFallbackException(Environment.GetResourceString("Argument_InvalidCodePageConversionIndex", (int)charUnknown, index), charUnknown, index);
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
		int num = char.ConvertToUtf32(charUnknownHigh, charUnknownLow);
		throw new EncoderFallbackException(Environment.GetResourceString("Argument_InvalidCodePageConversionIndex", num, index), charUnknownHigh, charUnknownLow, index);
	}

	public override char GetNextChar()
	{
		return '\0';
	}

	public override bool MovePrevious()
	{
		return false;
	}
}
