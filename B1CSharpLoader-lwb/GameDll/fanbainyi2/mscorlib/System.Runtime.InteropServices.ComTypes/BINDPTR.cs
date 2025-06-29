namespace System.Runtime.InteropServices.ComTypes;

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
[__DynamicallyInvokable]
public struct BINDPTR
{
	[FieldOffset(0)]
	public IntPtr lpfuncdesc;

	[FieldOffset(0)]
	public IntPtr lpvardesc;

	[FieldOffset(0)]
	public IntPtr lptcomp;
}
