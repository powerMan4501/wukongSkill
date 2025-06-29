using System.Runtime.InteropServices;

namespace System.Deployment.Internal.Isolation;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("285a8876-c84a-11d7-850f-005cd062464f")]
internal interface ISectionWithReferenceIdentityKey
{
	void Lookup(IReferenceIdentity ReferenceIdentityKey, [MarshalAs(UnmanagedType.Interface)] out object ppUnknown);
}
