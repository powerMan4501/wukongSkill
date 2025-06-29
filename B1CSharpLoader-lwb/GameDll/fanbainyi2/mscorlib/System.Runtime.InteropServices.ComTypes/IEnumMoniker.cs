namespace System.Runtime.InteropServices.ComTypes;

[ComImport]
[Guid("00000102-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[__DynamicallyInvokable]
public interface IEnumMoniker
{
	[PreserveSig]
	int Next(int celt, [Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IMoniker[] rgelt, IntPtr pceltFetched);

	[PreserveSig]
	[__DynamicallyInvokable]
	int Skip(int celt);

	[__DynamicallyInvokable]
	void Reset();

	[__DynamicallyInvokable]
	void Clone(out IEnumMoniker ppenum);
}
