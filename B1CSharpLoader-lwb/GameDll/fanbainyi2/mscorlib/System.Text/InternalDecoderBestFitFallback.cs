namespace System.Text;

[Serializable]
internal sealed class InternalDecoderBestFitFallback : DecoderFallback
{
	internal Encoding encoding;

	internal char[] arrayBestFit;

	internal char cReplacement = '?';

	public override int MaxCharCount => 1;

	internal InternalDecoderBestFitFallback(Encoding encoding)
	{
		this.encoding = encoding;
		bIsMicrosoftBestFitFallback = true;
	}

	public override DecoderFallbackBuffer CreateFallbackBuffer()
	{
		return new InternalDecoderBestFitFallbackBuffer(this);
	}

	public override bool Equals(object value)
	{
		if (value is InternalDecoderBestFitFallback internalDecoderBestFitFallback)
		{
			return encoding.CodePage == internalDecoderBestFitFallback.encoding.CodePage;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return encoding.CodePage;
	}
}
