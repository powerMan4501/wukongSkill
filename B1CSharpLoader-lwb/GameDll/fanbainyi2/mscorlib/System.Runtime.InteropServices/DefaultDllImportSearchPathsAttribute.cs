namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Method, AllowMultiple = false)]
[ComVisible(false)]
[__DynamicallyInvokable]
public sealed class DefaultDllImportSearchPathsAttribute : Attribute
{
	internal DllImportSearchPath _paths;

	[__DynamicallyInvokable]
	public DllImportSearchPath Paths
	{
		[__DynamicallyInvokable]
		get
		{
			return _paths;
		}
	}

	[__DynamicallyInvokable]
	public DefaultDllImportSearchPathsAttribute(DllImportSearchPath paths)
	{
		_paths = paths;
	}
}
