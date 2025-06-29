namespace System.Runtime.InteropServices.ComTypes;

[ComImport]
[Guid("00020404-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[__DynamicallyInvokable]
public interface IEnumVARIANT
{
	[PreserveSig]
	int Next(int celt, [Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] object[] rgVar, IntPtr pceltFetched);

	[PreserveSig]
	[__DynamicallyInvokable]
	int Skip(int celt);

	[PreserveSig]
	[__DynamicallyInvokable]
	int Reset();

	[__DynamicallyInvokable]
	IEnumVARIANT Clone();
}
