using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Method)]
public class UFunctionInvokerAttribute : Attribute
{
	public string Path { get; set; }

	public UFunctionInvokerAttribute(string path)
	{
		Path = path;
	}
}
