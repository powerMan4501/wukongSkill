using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation.Manifest;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("24abe1f7-a396-4a03-9adf-1d5b86a5569f")]
internal interface IMuiResourceIdLookupMapEntry
{
	MuiResourceIdLookupMapEntry AllData
	{
		[SecurityCritical]
		get;
	}

	uint Count
	{
		[SecurityCritical]
		get;
	}
}
