using System.Runtime.InteropServices;

namespace System.Text;

[ComVisible(true)]
[__DynamicallyInvokable]
public abstract class EncodingProvider
{
	private static object s_InternalSyncObject = new object();

	private static volatile EncodingProvider[] s_providers;

	[__DynamicallyInvokable]
	public EncodingProvider()
	{
	}

	[__DynamicallyInvokable]
	public abstract Encoding GetEncoding(string name);

	[__DynamicallyInvokable]
	public abstract Encoding GetEncoding(int codepage);

	[__DynamicallyInvokable]
	public virtual Encoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
	{
		Encoding encoding = GetEncoding(name);
		if (encoding != null)
		{
			encoding = (Encoding)GetEncoding(name).Clone();
			encoding.EncoderFallback = encoderFallback;
			encoding.DecoderFallback = decoderFallback;
		}
		return encoding;
	}

	[__DynamicallyInvokable]
	public virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
	{
		Encoding encoding = GetEncoding(codepage);
		if (encoding != null)
		{
			encoding = (Encoding)GetEncoding(codepage).Clone();
			encoding.EncoderFallback = encoderFallback;
			encoding.DecoderFallback = decoderFallback;
		}
		return encoding;
	}

	internal static void AddProvider(EncodingProvider provider)
	{
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		lock (s_InternalSyncObject)
		{
			if (s_providers == null)
			{
				s_providers = new EncodingProvider[1] { provider };
			}
			else if (Array.IndexOf(s_providers, provider) < 0)
			{
				EncodingProvider[] array = new EncodingProvider[s_providers.Length + 1];
				Array.Copy(s_providers, array, s_providers.Length);
				array[array.Length - 1] = provider;
				s_providers = array;
			}
		}
	}

	internal static Encoding GetEncodingFromProvider(int codepage)
	{
		if (s_providers == null)
		{
			return null;
		}
		EncodingProvider[] array = s_providers;
		EncodingProvider[] array2 = array;
		foreach (EncodingProvider encodingProvider in array2)
		{
			Encoding encoding = encodingProvider.GetEncoding(codepage);
			if (encoding != null)
			{
				return encoding;
			}
		}
		return null;
	}

	internal static Encoding GetEncodingFromProvider(string encodingName)
	{
		if (s_providers == null)
		{
			return null;
		}
		EncodingProvider[] array = s_providers;
		EncodingProvider[] array2 = array;
		foreach (EncodingProvider encodingProvider in array2)
		{
			Encoding encoding = encodingProvider.GetEncoding(encodingName);
			if (encoding != null)
			{
				return encoding;
			}
		}
		return null;
	}

	internal static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec)
	{
		if (s_providers == null)
		{
			return null;
		}
		EncodingProvider[] array = s_providers;
		EncodingProvider[] array2 = array;
		foreach (EncodingProvider encodingProvider in array2)
		{
			Encoding encoding = encodingProvider.GetEncoding(codepage, enc, dec);
			if (encoding != null)
			{
				return encoding;
			}
		}
		return null;
	}

	internal static Encoding GetEncodingFromProvider(string encodingName, EncoderFallback enc, DecoderFallback dec)
	{
		if (s_providers == null)
		{
			return null;
		}
		EncodingProvider[] array = s_providers;
		EncodingProvider[] array2 = array;
		foreach (EncodingProvider encodingProvider in array2)
		{
			Encoding encoding = encodingProvider.GetEncoding(encodingName, enc, dec);
			if (encoding != null)
			{
				return encoding;
			}
		}
		return null;
	}
}
