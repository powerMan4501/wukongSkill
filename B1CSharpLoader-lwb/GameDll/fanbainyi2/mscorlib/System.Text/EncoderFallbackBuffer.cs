using System.Security;

namespace System.Text;

[__DynamicallyInvokable]
public abstract class EncoderFallbackBuffer
{
	[SecurityCritical]
	internal unsafe char* charStart;

	[SecurityCritical]
	internal unsafe char* charEnd;

	internal EncoderNLS encoder;

	internal bool setEncoder;

	internal bool bUsedEncoder;

	internal bool bFallingBack;

	internal int iRecursionCount;

	private const int iMaxRecursion = 250;

	[__DynamicallyInvokable]
	public abstract int Remaining
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public abstract bool Fallback(char charUnknown, int index);

	[__DynamicallyInvokable]
	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);

	[__DynamicallyInvokable]
	public abstract char GetNextChar();

	[__DynamicallyInvokable]
	public abstract bool MovePrevious();

	[__DynamicallyInvokable]
	public virtual void Reset()
	{
		while (GetNextChar() != 0)
		{
		}
	}

	[SecurityCritical]
	internal unsafe void InternalReset()
	{
		charStart = null;
		bFallingBack = false;
		iRecursionCount = 0;
		Reset();
	}

	[SecurityCritical]
	internal unsafe void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder)
	{
		this.charStart = charStart;
		this.charEnd = charEnd;
		this.encoder = encoder;
		this.setEncoder = setEncoder;
		bUsedEncoder = false;
		bFallingBack = false;
		iRecursionCount = 0;
	}

	internal char InternalGetNextChar()
	{
		char nextChar = GetNextChar();
		bFallingBack = nextChar != '\0';
		if (nextChar == '\0')
		{
			iRecursionCount = 0;
		}
		return nextChar;
	}

	[SecurityCritical]
	internal unsafe virtual bool InternalFallback(char ch, ref char* chars)
	{
		int index = (int)(chars - charStart) - 1;
		if (char.IsHighSurrogate(ch))
		{
			if (chars >= charEnd)
			{
				if (encoder != null && !encoder.MustFlush)
				{
					if (setEncoder)
					{
						bUsedEncoder = true;
						encoder.charLeftOver = ch;
					}
					bFallingBack = false;
					return false;
				}
			}
			else
			{
				char c = *chars;
				if (char.IsLowSurrogate(c))
				{
					if (bFallingBack && iRecursionCount++ > 250)
					{
						ThrowLastCharRecursive(char.ConvertToUtf32(ch, c));
					}
					chars++;
					bFallingBack = Fallback(ch, c, index);
					return bFallingBack;
				}
			}
		}
		if (bFallingBack && iRecursionCount++ > 250)
		{
			ThrowLastCharRecursive(ch);
		}
		bFallingBack = Fallback(ch, index);
		return bFallingBack;
	}

	internal void ThrowLastCharRecursive(int charRecursive)
	{
		throw new ArgumentException(Environment.GetResourceString("Argument_RecursiveFallback", charRecursive), "chars");
	}

	[__DynamicallyInvokable]
	protected EncoderFallbackBuffer()
	{
	}
}
