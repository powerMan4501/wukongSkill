namespace System.Runtime.InteropServices.ComTypes;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
[__DynamicallyInvokable]
public struct PARAMDESC
{
	public IntPtr lpVarValue;

	[__DynamicallyInvokable]
	public PARAMFLAG wParamFlags;
}
