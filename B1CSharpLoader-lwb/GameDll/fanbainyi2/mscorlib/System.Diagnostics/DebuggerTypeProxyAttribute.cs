using System.Runtime.InteropServices;

namespace System.Diagnostics;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class DebuggerTypeProxyAttribute : Attribute
{
	private string typeName;

	private string targetName;

	private Type target;

	[__DynamicallyInvokable]
	public string ProxyTypeName
	{
		[__DynamicallyInvokable]
		get
		{
			return typeName;
		}
	}

	[__DynamicallyInvokable]
	public Type Target
	{
		[__DynamicallyInvokable]
		get
		{
			return target;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			targetName = value.AssemblyQualifiedName;
			target = value;
		}
	}

	[__DynamicallyInvokable]
	public string TargetTypeName
	{
		[__DynamicallyInvokable]
		get
		{
			return targetName;
		}
		[__DynamicallyInvokable]
		set
		{
			targetName = value;
		}
	}

	[__DynamicallyInvokable]
	public DebuggerTypeProxyAttribute(Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		typeName = type.AssemblyQualifiedName;
	}

	[__DynamicallyInvokable]
	public DebuggerTypeProxyAttribute(string typeName)
	{
		this.typeName = typeName;
	}
}
