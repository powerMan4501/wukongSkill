using System.Runtime.InteropServices;

namespace System.Deployment.Internal.Isolation;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("00000100-0000-0000-C000-000000000046")]
internal interface IEnumUnknown
{
	[PreserveSig]
	int Next(uint celt, [Out][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.IUnknown)] object[] rgelt, ref uint celtFetched);

	[PreserveSig]
	int Skip(uint celt);

	[PreserveSig]
	int Reset();

	[PreserveSig]
	int Clone(out IEnumUnknown enumUnknown);
}
