namespace System.Runtime.InteropServices.ComTypes;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
[__DynamicallyInvokable]
public struct EXCEPINFO
{
	[__DynamicallyInvokable]
	public short wCode;

	[__DynamicallyInvokable]
	public short wReserved;

	[MarshalAs(UnmanagedType.BStr)]
	[__DynamicallyInvokable]
	public string bstrSource;

	[MarshalAs(UnmanagedType.BStr)]
	[__DynamicallyInvokable]
	public string bstrDescription;

	[MarshalAs(UnmanagedType.BStr)]
	[__DynamicallyInvokable]
	public string bstrHelpFile;

	[__DynamicallyInvokable]
	public int dwHelpContext;

	public IntPtr pvReserved;

	public IntPtr pfnDeferredFillIn;

	[__DynamicallyInvokable]
	public int scode;
}
