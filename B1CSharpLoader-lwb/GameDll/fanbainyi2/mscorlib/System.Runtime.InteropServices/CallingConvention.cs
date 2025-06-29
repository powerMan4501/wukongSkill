namespace System.Runtime.InteropServices;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum CallingConvention
{
	[__DynamicallyInvokable]
	Winapi = 1,
	[__DynamicallyInvokable]
	Cdecl,
	[__DynamicallyInvokable]
	StdCall,
	[__DynamicallyInvokable]
	ThisCall,
	FastCall
}
