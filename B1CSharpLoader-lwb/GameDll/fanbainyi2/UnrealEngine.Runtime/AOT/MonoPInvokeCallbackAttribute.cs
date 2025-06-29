using System;

namespace AOT;

[AttributeUsage(AttributeTargets.Method)]
public class MonoPInvokeCallbackAttribute : Attribute
{
	public Type SignatureType;

	public MonoPInvokeCallbackAttribute(Type type)
	{
		SignatureType = type;
	}
}
