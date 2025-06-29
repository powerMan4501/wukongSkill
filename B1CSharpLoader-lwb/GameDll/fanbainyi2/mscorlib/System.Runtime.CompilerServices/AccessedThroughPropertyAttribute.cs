using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Field)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AccessedThroughPropertyAttribute : Attribute
{
	private readonly string propertyName;

	[__DynamicallyInvokable]
	public string PropertyName
	{
		[__DynamicallyInvokable]
		get
		{
			return propertyName;
		}
	}

	[__DynamicallyInvokable]
	public AccessedThroughPropertyAttribute(string propertyName)
	{
		this.propertyName = propertyName;
	}
}
