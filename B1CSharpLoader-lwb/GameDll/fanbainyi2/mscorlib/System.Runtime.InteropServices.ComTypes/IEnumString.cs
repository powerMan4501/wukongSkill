namespace System.Runtime.InteropServices.ComTypes;

[ComImport]
[Guid("00000101-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[__DynamicallyInvokable]
public interface IEnumString
{
	[PreserveSig]
	int Next(int celt, [Out][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 0)] string[] rgelt, IntPtr pceltFetched);

	[PreserveSig]
	[__DynamicallyInvokable]
	int Skip(int celt);

	[__DynamicallyInvokable]
	void Reset();

	[__DynamicallyInvokable]
	void Clone(out IEnumString ppenum);
}
