namespace System.Runtime.InteropServices.ComTypes;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
[__DynamicallyInvokable]
public struct TYPEDESC
{
	public IntPtr lpValue;

	[__DynamicallyInvokable]
	public short vt;
}
