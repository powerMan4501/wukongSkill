using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation.Manifest;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("1583EFE9-832F-4d08-B041-CAC5ACEDB948")]
internal interface IEntryPointEntry
{
	EntryPointEntry AllData
	{
		[SecurityCritical]
		get;
	}

	string Name
	{
		[SecurityCritical]
		[return: MarshalAs(UnmanagedType.LPWStr)]
		get;
	}

	string CommandLine_File
	{
		[SecurityCritical]
		[return: MarshalAs(UnmanagedType.LPWStr)]
		get;
	}

	string CommandLine_Parameters
	{
		[SecurityCritical]
		[return: MarshalAs(UnmanagedType.LPWStr)]
		get;
	}

	IReferenceIdentity Identity
	{
		[SecurityCritical]
		get;
	}

	uint Flags
	{
		[SecurityCritical]
		get;
	}
}
