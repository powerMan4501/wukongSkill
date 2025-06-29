using System.Runtime.InteropServices;

namespace System.Net;

internal struct SSL_EXTRA_CERT_CHAIN_POLICY_PARA
{
	[StructLayout(LayoutKind.Explicit)]
	internal struct U
	{
		[FieldOffset(0)]
		internal uint cbStruct;

		[FieldOffset(0)]
		internal uint cbSize;
	}

	internal U u;

	internal int dwAuthType;

	internal uint fdwChecks;

	internal unsafe char* pwszServerName;

	private static readonly uint StructSize = (uint)Marshal.SizeOf(typeof(SSL_EXTRA_CERT_CHAIN_POLICY_PARA));

	internal unsafe SSL_EXTRA_CERT_CHAIN_POLICY_PARA(bool amIServer)
	{
		u.cbStruct = StructSize;
		u.cbSize = StructSize;
		dwAuthType = (amIServer ? 1 : 2);
		fdwChecks = 0u;
		pwszServerName = null;
	}
}
