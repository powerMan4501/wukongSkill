namespace System.Runtime.InteropServices.ComTypes;

[ComImport]
[Guid("00020411-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[__DynamicallyInvokable]
public interface ITypeLib2 : ITypeLib
{
	[PreserveSig]
	[__DynamicallyInvokable]
	new int GetTypeInfoCount();

	[__DynamicallyInvokable]
	new void GetTypeInfo(int index, out ITypeInfo ppTI);

	[__DynamicallyInvokable]
	new void GetTypeInfoType(int index, out TYPEKIND pTKind);

	[__DynamicallyInvokable]
	new void GetTypeInfoOfGuid(ref Guid guid, out ITypeInfo ppTInfo);

	new void GetLibAttr(out IntPtr ppTLibAttr);

	[__DynamicallyInvokable]
	new void GetTypeComp(out ITypeComp ppTComp);

	[__DynamicallyInvokable]
	new void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);

	[__DynamicallyInvokable]
	[return: MarshalAs(UnmanagedType.Bool)]
	new bool IsName([MarshalAs(UnmanagedType.LPWStr)] string szNameBuf, int lHashVal);

	[__DynamicallyInvokable]
	new void FindName([MarshalAs(UnmanagedType.LPWStr)] string szNameBuf, int lHashVal, [Out][MarshalAs(UnmanagedType.LPArray)] ITypeInfo[] ppTInfo, [Out][MarshalAs(UnmanagedType.LPArray)] int[] rgMemId, ref short pcFound);

	[PreserveSig]
	new void ReleaseTLibAttr(IntPtr pTLibAttr);

	[__DynamicallyInvokable]
	void GetCustData(ref Guid guid, out object pVarVal);

	[LCIDConversion(1)]
	[__DynamicallyInvokable]
	void GetDocumentation2(int index, out string pbstrHelpString, out int pdwHelpStringContext, out string pbstrHelpStringDll);

	void GetLibStatistics(IntPtr pcUniqueNames, out int pcchUniqueNames);

	void GetAllCustData(IntPtr pCustData);
}
