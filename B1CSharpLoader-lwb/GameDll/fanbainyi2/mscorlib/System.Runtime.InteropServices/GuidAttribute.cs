namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class GuidAttribute : Attribute
{
	internal string _val;

	[__DynamicallyInvokable]
	public string Value
	{
		[__DynamicallyInvokable]
		get
		{
			return _val;
		}
	}

	[__DynamicallyInvokable]
	public GuidAttribute(string guid)
	{
		_val = guid;
	}
}
