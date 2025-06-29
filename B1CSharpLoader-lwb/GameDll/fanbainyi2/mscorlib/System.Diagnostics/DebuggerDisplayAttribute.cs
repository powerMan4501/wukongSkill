using System.Runtime.InteropServices;

namespace System.Diagnostics;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Delegate, AllowMultiple = true)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class DebuggerDisplayAttribute : Attribute
{
	private string name;

	private string value;

	private string type;

	private string targetName;

	private Type target;

	[__DynamicallyInvokable]
	public string Value
	{
		[__DynamicallyInvokable]
		get
		{
			return value;
		}
	}

	[__DynamicallyInvokable]
	public string Name
	{
		[__DynamicallyInvokable]
		get
		{
			return name;
		}
		[__DynamicallyInvokable]
		set
		{
			name = value;
		}
	}

	[__DynamicallyInvokable]
	public string Type
	{
		[__DynamicallyInvokable]
		get
		{
			return type;
		}
		[__DynamicallyInvokable]
		set
		{
			type = value;
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
	public DebuggerDisplayAttribute(string value)
	{
		if (value == null)
		{
			this.value = "";
		}
		else
		{
			this.value = value;
		}
		name = "";
		type = "";
	}
}
