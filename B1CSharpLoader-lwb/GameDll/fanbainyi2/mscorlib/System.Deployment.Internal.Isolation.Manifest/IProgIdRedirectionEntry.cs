using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation.Manifest;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("54F198EC-A63A-45ea-A984-452F68D9B35B")]
internal interface IProgIdRedirectionEntry
{
	ProgIdRedirectionEntry AllData
	{
		[SecurityCritical]
		get;
	}

	string ProgId
	{
		[SecurityCritical]
		[return: MarshalAs(UnmanagedType.LPWStr)]
		get;
	}

	Guid RedirectedGuid
	{
		[SecurityCritical]
		get;
	}
}
