using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation;

[ComImport]
[Guid("d91e12d8-98ed-47fa-9936-39421283d59b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IDefinitionAppId
{
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.LPWStr)]
	string get_SubscriptionId();

	void put_SubscriptionId([In][MarshalAs(UnmanagedType.LPWStr)] string Subscription);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.LPWStr)]
	string get_Codebase();

	[SecurityCritical]
	void put_Codebase([In][MarshalAs(UnmanagedType.LPWStr)] string CodeBase);

	[SecurityCritical]
	IEnumDefinitionIdentity EnumAppPath();

	[SecurityCritical]
	void SetAppPath([In] uint cIDefinitionIdentity, [In][MarshalAs(UnmanagedType.LPArray)] IDefinitionIdentity[] DefinitionIdentity);
}
