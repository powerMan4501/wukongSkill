using System.Runtime.Serialization;

namespace System.Text;

[Serializable]
[__DynamicallyInvokable]
public sealed class EncoderFallbackException : ArgumentException
{
	private char charUnknown;

	private char charUnknownHigh;

	private char charUnknownLow;

	private int index;

	[__DynamicallyInvokable]
	public char CharUnknown
	{
		[__DynamicallyInvokable]
		get
		{
			return charUnknown;
		}
	}

	[__DynamicallyInvokable]
	public char CharUnknownHigh
	{
		[__DynamicallyInvokable]
		get
		{
			return charUnknownHigh;
		}
	}

	[__DynamicallyInvokable]
	public char CharUnknownLow
	{
		[__DynamicallyInvokable]
		get
		{
			return charUnknownLow;
		}
	}

	[__DynamicallyInvokable]
	public int Index
	{
		[__DynamicallyInvokable]
		get
		{
			return index;
		}
	}

	[__DynamicallyInvokable]
	public EncoderFallbackException()
		: base(Environment.GetResourceString("Arg_ArgumentException"))
	{
		SetErrorCode(-2147024809);
	}

	[__DynamicallyInvokable]
	public EncoderFallbackException(string message)
		: base(message)
	{
		SetErrorCode(-2147024809);
	}

	[__DynamicallyInvokable]
	public EncoderFallbackException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2147024809);
	}

	internal EncoderFallbackException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	internal EncoderFallbackException(string message, char charUnknown, int index)
		: base(message)
	{
		this.charUnknown = charUnknown;
		this.index = index;
	}

	internal EncoderFallbackException(string message, char charUnknownHigh, char charUnknownLow, int index)
		: base(message)
	{
		if (!char.IsHighSurrogate(charUnknownHigh))
		{
			throw new ArgumentOutOfRangeException("charUnknownHigh", Environment.GetResourceString("ArgumentOutOfRange_Range", 55296, 56319));
		}
		if (!char.IsLowSurrogate(charUnknownLow))
		{
			throw new ArgumentOutOfRangeException("CharUnknownLow", Environment.GetResourceString("ArgumentOutOfRange_Range", 56320, 57343));
		}
		this.charUnknownHigh = charUnknownHigh;
		this.charUnknownLow = charUnknownLow;
		this.index = index;
	}

	[__DynamicallyInvokable]
	public bool IsUnknownSurrogate()
	{
		return charUnknownHigh != '\0';
	}
}
