namespace System.Runtime.InteropServices.ComTypes;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
[__DynamicallyInvokable]
public struct ELEMDESC
{
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	[__DynamicallyInvokable]
	public struct DESCUNION
	{
		[FieldOffset(0)]
		[__DynamicallyInvokable]
		public IDLDESC idldesc;

		[FieldOffset(0)]
		[__DynamicallyInvokable]
		public PARAMDESC paramdesc;
	}

	[__DynamicallyInvokable]
	public TYPEDESC tdesc;

	[__DynamicallyInvokable]
	public DESCUNION desc;
}
