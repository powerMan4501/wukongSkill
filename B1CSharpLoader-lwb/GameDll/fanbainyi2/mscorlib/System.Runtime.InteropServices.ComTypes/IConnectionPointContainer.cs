namespace System.Runtime.InteropServices.ComTypes;

[ComImport]
[Guid("B196B284-BAB4-101A-B69C-00AA00341D07")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[__DynamicallyInvokable]
public interface IConnectionPointContainer
{
	[__DynamicallyInvokable]
	void EnumConnectionPoints(out IEnumConnectionPoints ppEnum);

	[__DynamicallyInvokable]
	void FindConnectionPoint([In] ref Guid riid, out IConnectionPoint ppCP);
}
