namespace System.Runtime.InteropServices.ComTypes;

[ComImport]
[Guid("B196B285-BAB4-101A-B69C-00AA00341D07")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[__DynamicallyInvokable]
public interface IEnumConnectionPoints
{
	[PreserveSig]
	int Next(int celt, [Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IConnectionPoint[] rgelt, IntPtr pceltFetched);

	[PreserveSig]
	[__DynamicallyInvokable]
	int Skip(int celt);

	[__DynamicallyInvokable]
	void Reset();

	[__DynamicallyInvokable]
	void Clone(out IEnumConnectionPoints ppenum);
}
