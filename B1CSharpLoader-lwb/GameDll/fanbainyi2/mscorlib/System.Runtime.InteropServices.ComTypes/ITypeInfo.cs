namespace System.Runtime.InteropServices.ComTypes;

[ComImport]
[Guid("00020401-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[__DynamicallyInvokable]
public interface ITypeInfo
{
	void GetTypeAttr(out IntPtr ppTypeAttr);

	[__DynamicallyInvokable]
	void GetTypeComp(out ITypeComp ppTComp);

	void GetFuncDesc(int index, out IntPtr ppFuncDesc);

	void GetVarDesc(int index, out IntPtr ppVarDesc);

	[__DynamicallyInvokable]
	void GetNames(int memid, [Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] string[] rgBstrNames, int cMaxNames, out int pcNames);

	[__DynamicallyInvokable]
	void GetRefTypeOfImplType(int index, out int href);

	[__DynamicallyInvokable]
	void GetImplTypeFlags(int index, out IMPLTYPEFLAGS pImplTypeFlags);

	[__DynamicallyInvokable]
	void GetIDsOfNames([In][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 1)] string[] rgszNames, int cNames, [Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] int[] pMemId);

	void Invoke([MarshalAs(UnmanagedType.IUnknown)] object pvInstance, int memid, short wFlags, ref DISPPARAMS pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, out int puArgErr);

	[__DynamicallyInvokable]
	void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);

	void GetDllEntry(int memid, INVOKEKIND invKind, IntPtr pBstrDllName, IntPtr pBstrName, IntPtr pwOrdinal);

	[__DynamicallyInvokable]
	void GetRefTypeInfo(int hRef, out ITypeInfo ppTI);

	void AddressOfMember(int memid, INVOKEKIND invKind, out IntPtr ppv);

	[__DynamicallyInvokable]
	void CreateInstance([MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter, [In] ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);

	[__DynamicallyInvokable]
	void GetMops(int memid, out string pBstrMops);

	[__DynamicallyInvokable]
	void GetContainingTypeLib(out ITypeLib ppTLB, out int pIndex);

	[PreserveSig]
	void ReleaseTypeAttr(IntPtr pTypeAttr);

	[PreserveSig]
	void ReleaseFuncDesc(IntPtr pFuncDesc);

	[PreserveSig]
	void ReleaseVarDesc(IntPtr pVarDesc);
}
