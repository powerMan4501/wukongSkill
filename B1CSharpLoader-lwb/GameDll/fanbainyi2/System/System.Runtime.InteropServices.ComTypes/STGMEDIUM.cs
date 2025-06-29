namespace System.Runtime.InteropServices.ComTypes;

[global::__DynamicallyInvokable]
public struct STGMEDIUM
{
	[global::__DynamicallyInvokable]
	public TYMED tymed;

	public IntPtr unionmember;

	[MarshalAs(UnmanagedType.IUnknown)]
	[global::__DynamicallyInvokable]
	public object pUnkForRelease;
}
