namespace System.Runtime.InteropServices;

[ComImport]
[Obsolete("Use System.Runtime.InteropServices.ComTypes.IEnumMoniker instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
[Guid("00000102-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface UCOMIEnumMoniker
{
	[PreserveSig]
	int Next(int celt, [Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] UCOMIMoniker[] rgelt, out int pceltFetched);

	[PreserveSig]
	int Skip(int celt);

	[PreserveSig]
	int Reset();

	void Clone(out UCOMIEnumMoniker ppenum);
}
