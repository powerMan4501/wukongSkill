namespace System.Runtime.InteropServices.ComTypes;

[ComImport]
[Guid("0000000f-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[__DynamicallyInvokable]
public interface IMoniker
{
	[__DynamicallyInvokable]
	void GetClassID(out Guid pClassID);

	[PreserveSig]
	[__DynamicallyInvokable]
	int IsDirty();

	[__DynamicallyInvokable]
	void Load(IStream pStm);

	[__DynamicallyInvokable]
	void Save(IStream pStm, [MarshalAs(UnmanagedType.Bool)] bool fClearDirty);

	[__DynamicallyInvokable]
	void GetSizeMax(out long pcbSize);

	[__DynamicallyInvokable]
	void BindToObject(IBindCtx pbc, IMoniker pmkToLeft, [In] ref Guid riidResult, [MarshalAs(UnmanagedType.Interface)] out object ppvResult);

	[__DynamicallyInvokable]
	void BindToStorage(IBindCtx pbc, IMoniker pmkToLeft, [In] ref Guid riid, [MarshalAs(UnmanagedType.Interface)] out object ppvObj);

	[__DynamicallyInvokable]
	void Reduce(IBindCtx pbc, int dwReduceHowFar, ref IMoniker ppmkToLeft, out IMoniker ppmkReduced);

	[__DynamicallyInvokable]
	void ComposeWith(IMoniker pmkRight, [MarshalAs(UnmanagedType.Bool)] bool fOnlyIfNotGeneric, out IMoniker ppmkComposite);

	[__DynamicallyInvokable]
	void Enum([MarshalAs(UnmanagedType.Bool)] bool fForward, out IEnumMoniker ppenumMoniker);

	[PreserveSig]
	[__DynamicallyInvokable]
	int IsEqual(IMoniker pmkOtherMoniker);

	[__DynamicallyInvokable]
	void Hash(out int pdwHash);

	[PreserveSig]
	[__DynamicallyInvokable]
	int IsRunning(IBindCtx pbc, IMoniker pmkToLeft, IMoniker pmkNewlyRunning);

	[__DynamicallyInvokable]
	void GetTimeOfLastChange(IBindCtx pbc, IMoniker pmkToLeft, out FILETIME pFileTime);

	[__DynamicallyInvokable]
	void Inverse(out IMoniker ppmk);

	[__DynamicallyInvokable]
	void CommonPrefixWith(IMoniker pmkOther, out IMoniker ppmkPrefix);

	[__DynamicallyInvokable]
	void RelativePathTo(IMoniker pmkOther, out IMoniker ppmkRelPath);

	[__DynamicallyInvokable]
	void GetDisplayName(IBindCtx pbc, IMoniker pmkToLeft, [MarshalAs(UnmanagedType.LPWStr)] out string ppszDisplayName);

	[__DynamicallyInvokable]
	void ParseDisplayName(IBindCtx pbc, IMoniker pmkToLeft, [MarshalAs(UnmanagedType.LPWStr)] string pszDisplayName, out int pchEaten, out IMoniker ppmkOut);

	[PreserveSig]
	[__DynamicallyInvokable]
	int IsSystemMoniker(out int pdwMksys);
}
