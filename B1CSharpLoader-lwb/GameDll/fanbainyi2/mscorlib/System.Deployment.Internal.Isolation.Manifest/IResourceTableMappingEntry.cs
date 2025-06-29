using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation.Manifest;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("70A4ECEE-B195-4c59-85BF-44B6ACA83F07")]
internal interface IResourceTableMappingEntry
{
	ResourceTableMappingEntry AllData
	{
		[SecurityCritical]
		get;
	}

	string id
	{
		[SecurityCritical]
		[return: MarshalAs(UnmanagedType.LPWStr)]
		get;
	}

	string FinalStringMapped
	{
		[SecurityCritical]
		[return: MarshalAs(UnmanagedType.LPWStr)]
		get;
	}
}
