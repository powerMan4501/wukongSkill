namespace System.Runtime.InteropServices.ComTypes;

[Serializable]
[Flags]
[__DynamicallyInvokable]
public enum INVOKEKIND
{
	[__DynamicallyInvokable]
	INVOKE_FUNC = 1,
	[__DynamicallyInvokable]
	INVOKE_PROPERTYGET = 2,
	[__DynamicallyInvokable]
	INVOKE_PROPERTYPUT = 4,
	[__DynamicallyInvokable]
	INVOKE_PROPERTYPUTREF = 8
}
