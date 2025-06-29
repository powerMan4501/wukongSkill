using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation;

[ComImport]
[Guid("5fa4f590-a416-4b22-ac79-7c3f0d31f303")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IEnumSTORE_DEPLOYMENT_METADATA_PROPERTY
{
	[SecurityCritical]
	uint Next([In] uint celt, [Out][MarshalAs(UnmanagedType.LPArray)] StoreOperationMetadataProperty[] AppIds);

	[SecurityCritical]
	void Skip([In] uint celt);

	[SecurityCritical]
	void Reset();

	[SecurityCritical]
	IEnumSTORE_DEPLOYMENT_METADATA_PROPERTY Clone();
}
