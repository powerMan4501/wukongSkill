namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class ComVisibleAttribute : Attribute
{
	internal bool _val;

	[__DynamicallyInvokable]
	public bool Value
	{
		[__DynamicallyInvokable]
		get
		{
			return _val;
		}
	}

	[__DynamicallyInvokable]
	public ComVisibleAttribute(bool visibility)
	{
		_val = visibility;
	}
}
