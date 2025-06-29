namespace System.Runtime.InteropServices.ComTypes;

[ComImport]
[Guid("00000010-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[__DynamicallyInvokable]
public interface IRunningObjectTable
{
	[__DynamicallyInvokable]
	int Register(int grfFlags, [MarshalAs(UnmanagedType.Interface)] object punkObject, IMoniker pmkObjectName);

	[__DynamicallyInvokable]
	void Revoke(int dwRegister);

	[PreserveSig]
	[__DynamicallyInvokable]
	int IsRunning(IMoniker pmkObjectName);

	[PreserveSig]
	[__DynamicallyInvokable]
	int GetObject(IMoniker pmkObjectName, [MarshalAs(UnmanagedType.Interface)] out object ppunkObject);

	[__DynamicallyInvokable]
	void NoteChangeTime(int dwRegister, ref FILETIME pfiletime);

	[PreserveSig]
	[__DynamicallyInvokable]
	int GetTimeOfLastChange(IMoniker pmkObjectName, out FILETIME pfiletime);

	[__DynamicallyInvokable]
	void EnumRunning(out IEnumMoniker ppenumMoniker);
}
