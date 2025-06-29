namespace System.Runtime.InteropServices.ComTypes;

[global::__DynamicallyInvokable]
public struct FORMATETC
{
	[MarshalAs(UnmanagedType.U2)]
	[global::__DynamicallyInvokable]
	public short cfFormat;

	public IntPtr ptd;

	[MarshalAs(UnmanagedType.U4)]
	[global::__DynamicallyInvokable]
	public DVASPECT dwAspect;

	[global::__DynamicallyInvokable]
	public int lindex;

	[MarshalAs(UnmanagedType.U4)]
	[global::__DynamicallyInvokable]
	public TYMED tymed;
}
