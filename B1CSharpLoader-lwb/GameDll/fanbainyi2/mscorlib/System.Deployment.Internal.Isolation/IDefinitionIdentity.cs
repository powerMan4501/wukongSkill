using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation;

[ComImport]
[Guid("587bf538-4d90-4a3c-9ef1-58a200a8a9e7")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IDefinitionIdentity
{
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.LPWStr)]
	string GetAttribute([In][MarshalAs(UnmanagedType.LPWStr)] string Namespace, [In][MarshalAs(UnmanagedType.LPWStr)] string Name);

	[SecurityCritical]
	void SetAttribute([In][MarshalAs(UnmanagedType.LPWStr)] string Namespace, [In][MarshalAs(UnmanagedType.LPWStr)] string Name, [In][MarshalAs(UnmanagedType.LPWStr)] string Value);

	[SecurityCritical]
	IEnumIDENTITY_ATTRIBUTE EnumAttributes();

	[SecurityCritical]
	IDefinitionIdentity Clone([In] IntPtr cDeltas, [In][MarshalAs(UnmanagedType.LPArray)] IDENTITY_ATTRIBUTE[] Deltas);
}
