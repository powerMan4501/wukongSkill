namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Interface, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class CoClassAttribute : Attribute
{
	internal Type _CoClass;

	[__DynamicallyInvokable]
	public Type CoClass
	{
		[__DynamicallyInvokable]
		get
		{
			return _CoClass;
		}
	}

	[__DynamicallyInvokable]
	public CoClassAttribute(Type coClass)
	{
		_CoClass = coClass;
	}
}
