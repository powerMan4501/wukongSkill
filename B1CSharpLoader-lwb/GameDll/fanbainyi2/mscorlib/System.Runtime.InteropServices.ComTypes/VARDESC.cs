namespace System.Runtime.InteropServices.ComTypes;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
[__DynamicallyInvokable]
public struct VARDESC
{
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	[__DynamicallyInvokable]
	public struct DESCUNION
	{
		[FieldOffset(0)]
		[__DynamicallyInvokable]
		public int oInst;

		[FieldOffset(0)]
		public IntPtr lpvarValue;
	}

	[__DynamicallyInvokable]
	public int memid;

	[__DynamicallyInvokable]
	public string lpstrSchema;

	[__DynamicallyInvokable]
	public DESCUNION desc;

	[__DynamicallyInvokable]
	public ELEMDESC elemdescVar;

	[__DynamicallyInvokable]
	public short wVarFlags;

	[__DynamicallyInvokable]
	public VARKIND varkind;
}
