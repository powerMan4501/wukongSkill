namespace System.Runtime.InteropServices.ComTypes;

[ComImport]
[Guid("0000000e-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[__DynamicallyInvokable]
public interface IBindCtx
{
	[__DynamicallyInvokable]
	void RegisterObjectBound([MarshalAs(UnmanagedType.Interface)] object punk);

	[__DynamicallyInvokable]
	void RevokeObjectBound([MarshalAs(UnmanagedType.Interface)] object punk);

	[__DynamicallyInvokable]
	void ReleaseBoundObjects();

	[__DynamicallyInvokable]
	void SetBindOptions([In] ref BIND_OPTS pbindopts);

	[__DynamicallyInvokable]
	void GetBindOptions(ref BIND_OPTS pbindopts);

	[__DynamicallyInvokable]
	void GetRunningObjectTable(out IRunningObjectTable pprot);

	[__DynamicallyInvokable]
	void RegisterObjectParam([MarshalAs(UnmanagedType.LPWStr)] string pszKey, [MarshalAs(UnmanagedType.Interface)] object punk);

	[__DynamicallyInvokable]
	void GetObjectParam([MarshalAs(UnmanagedType.LPWStr)] string pszKey, [MarshalAs(UnmanagedType.Interface)] out object ppunk);

	[__DynamicallyInvokable]
	void EnumObjectParam(out IEnumString ppenum);

	[PreserveSig]
	[__DynamicallyInvokable]
	int RevokeObjectParam([MarshalAs(UnmanagedType.LPWStr)] string pszKey);
}
