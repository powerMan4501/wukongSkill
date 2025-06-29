namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Field, Inherited = false)]
[__DynamicallyInvokable]
public sealed class FixedBufferAttribute : Attribute
{
	private Type elementType;

	private int length;

	[__DynamicallyInvokable]
	public Type ElementType
	{
		[__DynamicallyInvokable]
		get
		{
			return elementType;
		}
	}

	[__DynamicallyInvokable]
	public int Length
	{
		[__DynamicallyInvokable]
		get
		{
			return length;
		}
	}

	[__DynamicallyInvokable]
	public FixedBufferAttribute(Type elementType, int length)
	{
		this.elementType = elementType;
		this.length = length;
	}
}
