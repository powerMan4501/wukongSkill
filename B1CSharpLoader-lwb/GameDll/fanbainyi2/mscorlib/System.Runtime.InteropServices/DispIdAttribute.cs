namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class DispIdAttribute : Attribute
{
	internal int _val;

	[__DynamicallyInvokable]
	public int Value
	{
		[__DynamicallyInvokable]
		get
		{
			return _val;
		}
	}

	[__DynamicallyInvokable]
	public DispIdAttribute(int dispId)
	{
		_val = dispId;
	}
}
