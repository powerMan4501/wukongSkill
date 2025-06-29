using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation;

[ComImport]
[Guid("6eaf5ace-7917-4f3c-b129-e046a9704766")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IReferenceIdentity
{
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.LPWStr)]
	string GetAttribute([In][MarshalAs(UnmanagedType.LPWStr)] string Namespace, [In][MarshalAs(UnmanagedType.LPWStr)] string Name);

	[SecurityCritical]
	void SetAttribute([In][MarshalAs(UnmanagedType.LPWStr)] string Namespace, [In][MarshalAs(UnmanagedType.LPWStr)] string Name, [In][MarshalAs(UnmanagedType.LPWStr)] string Value);

	[SecurityCritical]
	IEnumIDENTITY_ATTRIBUTE EnumAttributes();

	[SecurityCritical]
	IReferenceIdentity Clone([In] IntPtr cDeltas, [In][MarshalAs(UnmanagedType.LPArray)] IDENTITY_ATTRIBUTE[] Deltas);
}
