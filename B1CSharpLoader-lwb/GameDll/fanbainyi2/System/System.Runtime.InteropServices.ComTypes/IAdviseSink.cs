namespace System.Runtime.InteropServices.ComTypes;

[ComImport]
[Guid("0000010F-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[global::__DynamicallyInvokable]
public interface IAdviseSink
{
	[PreserveSig]
	[global::__DynamicallyInvokable]
	void OnDataChange([In] ref FORMATETC format, [In] ref STGMEDIUM stgmedium);

	[PreserveSig]
	[global::__DynamicallyInvokable]
	void OnViewChange(int aspect, int index);

	[PreserveSig]
	[global::__DynamicallyInvokable]
	void OnRename(IMoniker moniker);

	[PreserveSig]
	[global::__DynamicallyInvokable]
	void OnSave();

	[PreserveSig]
	[global::__DynamicallyInvokable]
	void OnClose();
}
