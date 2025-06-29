namespace System.Runtime.InteropServices.ComTypes;

[ComImport]
[Guid("00020402-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[__DynamicallyInvokable]
public interface ITypeLib
{
	[PreserveSig]
	[__DynamicallyInvokable]
	int GetTypeInfoCount();

	[__DynamicallyInvokable]
	void GetTypeInfo(int index, out ITypeInfo ppTI);

	[__DynamicallyInvokable]
	void GetTypeInfoType(int index, out TYPEKIND pTKind);

	[__DynamicallyInvokable]
	void GetTypeInfoOfGuid(ref Guid guid, out ITypeInfo ppTInfo);

	void GetLibAttr(out IntPtr ppTLibAttr);

	[__DynamicallyInvokable]
	void GetTypeComp(out ITypeComp ppTComp);

	[__DynamicallyInvokable]
	void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);

	[__DynamicallyInvokable]
	[return: MarshalAs(UnmanagedType.Bool)]
	bool IsName([MarshalAs(UnmanagedType.LPWStr)] string szNameBuf, int lHashVal);

	[__DynamicallyInvokable]
	void FindName([MarshalAs(UnmanagedType.LPWStr)] string szNameBuf, int lHashVal, [Out][MarshalAs(UnmanagedType.LPArray)] ITypeInfo[] ppTInfo, [Out][MarshalAs(UnmanagedType.LPArray)] int[] rgMemId, ref short pcFound);

	[PreserveSig]
	void ReleaseTLibAttr(IntPtr pTLibAttr);
}
