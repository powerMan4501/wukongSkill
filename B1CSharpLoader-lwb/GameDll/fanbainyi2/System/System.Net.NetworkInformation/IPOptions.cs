namespace System.Net.NetworkInformation;

internal struct IPOptions
{
	internal byte ttl;

	internal byte tos;

	internal byte flags;

	internal byte optionsSize;

	internal IntPtr optionsData;

	internal IPOptions(PingOptions options)
	{
		ttl = 128;
		tos = 0;
		flags = 0;
		optionsSize = 0;
		optionsData = IntPtr.Zero;
		if (options != null)
		{
			ttl = (byte)options.Ttl;
			if (options.DontFragment)
			{
				flags = 2;
			}
		}
	}
}
