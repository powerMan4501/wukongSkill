using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation;

[ComImport]
[Guid("054f0bef-9e45-4363-8f5a-2f8e142d9a3b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IReferenceAppId
{
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.LPWStr)]
	string get_SubscriptionId();

	void put_SubscriptionId([In][MarshalAs(UnmanagedType.LPWStr)] string Subscription);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.LPWStr)]
	string get_Codebase();

	void put_Codebase([In][MarshalAs(UnmanagedType.LPWStr)] string CodeBase);

	[SecurityCritical]
	IEnumReferenceIdentity EnumAppPath();
}
