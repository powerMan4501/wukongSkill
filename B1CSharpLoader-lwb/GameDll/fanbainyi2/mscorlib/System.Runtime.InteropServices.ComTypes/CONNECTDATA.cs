namespace System.Runtime.InteropServices.ComTypes;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
[__DynamicallyInvokable]
public struct CONNECTDATA
{
	[MarshalAs(UnmanagedType.Interface)]
	[__DynamicallyInvokable]
	public object pUnk;

	[__DynamicallyInvokable]
	public int dwCookie;
}
