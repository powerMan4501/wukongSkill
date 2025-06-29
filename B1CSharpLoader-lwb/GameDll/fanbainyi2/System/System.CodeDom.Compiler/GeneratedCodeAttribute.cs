namespace System.CodeDom.Compiler;

[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
[global::__DynamicallyInvokable]
public sealed class GeneratedCodeAttribute : Attribute
{
	private readonly string tool;

	private readonly string version;

	[global::__DynamicallyInvokable]
	public string Tool
	{
		[global::__DynamicallyInvokable]
		get
		{
			return tool;
		}
	}

	[global::__DynamicallyInvokable]
	public string Version
	{
		[global::__DynamicallyInvokable]
		get
		{
			return version;
		}
	}

	[global::__DynamicallyInvokable]
	public GeneratedCodeAttribute(string tool, string version)
	{
		this.tool = tool;
		this.version = version;
	}
}
