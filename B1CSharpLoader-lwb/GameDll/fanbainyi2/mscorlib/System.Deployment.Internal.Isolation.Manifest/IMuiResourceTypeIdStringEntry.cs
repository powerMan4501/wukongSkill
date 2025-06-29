using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation.Manifest;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("11df5cad-c183-479b-9a44-3842b71639ce")]
internal interface IMuiResourceTypeIdStringEntry
{
	MuiResourceTypeIdStringEntry AllData
	{
		[SecurityCritical]
		get;
	}

	object StringIds
	{
		[SecurityCritical]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	object IntegerIds
	{
		[SecurityCritical]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
