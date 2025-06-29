namespace System.Text;

[Serializable]
internal class InternalEncoderBestFitFallback : EncoderFallback
{
	internal Encoding encoding;

	internal char[] arrayBestFit;

	public override int MaxCharCount => 1;

	internal InternalEncoderBestFitFallback(Encoding encoding)
	{
		this.encoding = encoding;
		bIsMicrosoftBestFitFallback = true;
	}

	public override EncoderFallbackBuffer CreateFallbackBuffer()
	{
		return new InternalEncoderBestFitFallbackBuffer(this);
	}

	public override bool Equals(object value)
	{
		if (value is InternalEncoderBestFitFallback internalEncoderBestFitFallback)
		{
			return encoding.CodePage == internalEncoderBestFitFallback.encoding.CodePage;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return encoding.CodePage;
	}
}
