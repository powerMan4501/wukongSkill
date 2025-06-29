namespace System.Runtime.InteropServices.ComTypes;

[ComImport]
[Guid("00000103-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[global::__DynamicallyInvokable]
public interface IEnumFORMATETC
{
	[PreserveSig]
	[global::__DynamicallyInvokable]
	int Next(int celt, [Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] FORMATETC[] rgelt, [Out][MarshalAs(UnmanagedType.LPArray)] int[] pceltFetched);

	[PreserveSig]
	[global::__DynamicallyInvokable]
	int Skip(int celt);

	[PreserveSig]
	[global::__DynamicallyInvokable]
	int Reset();

	[global::__DynamicallyInvokable]
	void Clone(out IEnumFORMATETC newEnum);
}
