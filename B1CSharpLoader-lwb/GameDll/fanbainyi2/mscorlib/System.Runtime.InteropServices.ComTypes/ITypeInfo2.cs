namespace System.Runtime.InteropServices.ComTypes;

[ComImport]
[Guid("00020412-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[__DynamicallyInvokable]
public interface ITypeInfo2 : ITypeInfo
{
	new void GetTypeAttr(out IntPtr ppTypeAttr);

	[__DynamicallyInvokable]
	new void GetTypeComp(out ITypeComp ppTComp);

	new void GetFuncDesc(int index, out IntPtr ppFuncDesc);

	new void GetVarDesc(int index, out IntPtr ppVarDesc);

	[__DynamicallyInvokable]
	new void GetNames(int memid, [Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] string[] rgBstrNames, int cMaxNames, out int pcNames);

	[__DynamicallyInvokable]
	new void GetRefTypeOfImplType(int index, out int href);

	[__DynamicallyInvokable]
	new void GetImplTypeFlags(int index, out IMPLTYPEFLAGS pImplTypeFlags);

	[__DynamicallyInvokable]
	new void GetIDsOfNames([In][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 1)] string[] rgszNames, int cNames, [Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] int[] pMemId);

	new void Invoke([MarshalAs(UnmanagedType.IUnknown)] object pvInstance, int memid, short wFlags, ref DISPPARAMS pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, out int puArgErr);

	[__DynamicallyInvokable]
	new void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);

	new void GetDllEntry(int memid, INVOKEKIND invKind, IntPtr pBstrDllName, IntPtr pBstrName, IntPtr pwOrdinal);

	[__DynamicallyInvokable]
	new void GetRefTypeInfo(int hRef, out ITypeInfo ppTI);

	new void AddressOfMember(int memid, INVOKEKIND invKind, out IntPtr ppv);

	[__DynamicallyInvokable]
	new void CreateInstance([MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter, [In] ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);

	[__DynamicallyInvokable]
	new void GetMops(int memid, out string pBstrMops);

	[__DynamicallyInvokable]
	new void GetContainingTypeLib(out ITypeLib ppTLB, out int pIndex);

	[PreserveSig]
	new void ReleaseTypeAttr(IntPtr pTypeAttr);

	[PreserveSig]
	new void ReleaseFuncDesc(IntPtr pFuncDesc);

	[PreserveSig]
	new void ReleaseVarDesc(IntPtr pVarDesc);

	[__DynamicallyInvokable]
	void GetTypeKind(out TYPEKIND pTypeKind);

	[__DynamicallyInvokable]
	void GetTypeFlags(out int pTypeFlags);

	[__DynamicallyInvokable]
	void GetFuncIndexOfMemId(int memid, INVOKEKIND invKind, out int pFuncIndex);

	[__DynamicallyInvokable]
	void GetVarIndexOfMemId(int memid, out int pVarIndex);

	[__DynamicallyInvokable]
	void GetCustData(ref Guid guid, out object pVarVal);

	[__DynamicallyInvokable]
	void GetFuncCustData(int index, ref Guid guid, out object pVarVal);

	[__DynamicallyInvokable]
	void GetParamCustData(int indexFunc, int indexParam, ref Guid guid, out object pVarVal);

	[__DynamicallyInvokable]
	void GetVarCustData(int index, ref Guid guid, out object pVarVal);

	[__DynamicallyInvokable]
	void GetImplTypeCustData(int index, ref Guid guid, out object pVarVal);

	[LCIDConversion(1)]
	[__DynamicallyInvokable]
	void GetDocumentation2(int memid, out string pbstrHelpString, out int pdwHelpStringContext, out string pbstrHelpStringDll);

	void GetAllCustData(IntPtr pCustData);

	void GetAllFuncCustData(int index, IntPtr pCustData);

	void GetAllParamCustData(int indexFunc, int indexParam, IntPtr pCustData);

	void GetAllVarCustData(int index, IntPtr pCustData);

	void GetAllImplTypeCustData(int index, IntPtr pCustData);
}
