namespace System.Runtime.InteropServices.ComTypes;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
[__DynamicallyInvokable]
public struct IDLDESC
{
	public IntPtr dwReserved;

	[__DynamicallyInvokable]
	public IDLFLAG wIDLFlags;
}
