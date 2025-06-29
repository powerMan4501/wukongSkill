namespace System.Runtime.InteropServices;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum ComInterfaceType
{
	[__DynamicallyInvokable]
	InterfaceIsDual,
	[__DynamicallyInvokable]
	InterfaceIsIUnknown,
	[__DynamicallyInvokable]
	InterfaceIsIDispatch,
	[ComVisible(false)]
	[__DynamicallyInvokable]
	InterfaceIsIInspectable
}
