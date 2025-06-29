namespace System.Runtime.InteropServices.ComTypes;

[ComImport]
[Guid("0000010b-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[__DynamicallyInvokable]
public interface IPersistFile
{
	[__DynamicallyInvokable]
	void GetClassID(out Guid pClassID);

	[PreserveSig]
	[__DynamicallyInvokable]
	int IsDirty();

	[__DynamicallyInvokable]
	void Load([MarshalAs(UnmanagedType.LPWStr)] string pszFileName, int dwMode);

	[__DynamicallyInvokable]
	void Save([MarshalAs(UnmanagedType.LPWStr)] string pszFileName, [MarshalAs(UnmanagedType.Bool)] bool fRemember);

	[__DynamicallyInvokable]
	void SaveCompleted([MarshalAs(UnmanagedType.LPWStr)] string pszFileName);

	[__DynamicallyInvokable]
	void GetCurFile([MarshalAs(UnmanagedType.LPWStr)] out string ppszFileName);
}
