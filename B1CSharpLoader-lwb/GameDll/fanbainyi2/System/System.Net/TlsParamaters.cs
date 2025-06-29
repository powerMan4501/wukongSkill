namespace System.Net;

internal struct TlsParamaters
{
	[Flags]
	public enum Flags
	{
		Zero = 0,
		TLS_PARAMS_OPTIONAL = 1
	}

	public int cAlpnIds;

	public IntPtr rgstrAlpnIds;

	public uint grbitDisabledProtocols;

	public int cDisabledCrypto;

	public IntPtr pDisabledCrypto;

	public Flags dwFlags;

	public TlsParamaters(SchProtocols protocols)
	{
		cAlpnIds = (cDisabledCrypto = 0);
		pDisabledCrypto = (rgstrAlpnIds = IntPtr.Zero);
		dwFlags = Flags.Zero;
		if (protocols != SchProtocols.Zero)
		{
			grbitDisabledProtocols = (uint)(protocols ^ (SchProtocols)(-1));
		}
		else
		{
			grbitDisabledProtocols = 0u;
		}
	}
}
