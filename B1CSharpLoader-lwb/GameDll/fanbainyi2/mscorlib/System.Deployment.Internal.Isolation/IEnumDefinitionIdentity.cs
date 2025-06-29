using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation;

[ComImport]
[Guid("f3549d9c-fc73-4793-9c00-1cd204254c0c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IEnumDefinitionIdentity
{
	[SecurityCritical]
	uint Next([In] uint celt, [Out][MarshalAs(UnmanagedType.LPArray)] IDefinitionIdentity[] DefinitionIdentity);

	[SecurityCritical]
	void Skip([In] uint celt);

	[SecurityCritical]
	void Reset();

	[SecurityCritical]
	IEnumDefinitionIdentity Clone();
}
