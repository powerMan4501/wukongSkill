namespace System.Reflection;

[__DynamicallyInvokable]
public static class IntrospectionExtensions
{
	[__DynamicallyInvokable]
	public static TypeInfo GetTypeInfo(this Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		return ((IReflectableType)type)?.GetTypeInfo();
	}
}
