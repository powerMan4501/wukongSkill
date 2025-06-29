namespace System.Runtime.InteropServices.ComTypes;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
[__DynamicallyInvokable]
public struct DISPPARAMS
{
	[__DynamicallyInvokable]
	public IntPtr rgvarg;

	[__DynamicallyInvokable]
	public IntPtr rgdispidNamedArgs;

	[__DynamicallyInvokable]
	public int cArgs;

	[__DynamicallyInvokable]
	public int cNamedArgs;
}
