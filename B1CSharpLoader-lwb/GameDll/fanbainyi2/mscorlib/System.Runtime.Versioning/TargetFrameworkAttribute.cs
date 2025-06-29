namespace System.Runtime.Versioning;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
[__DynamicallyInvokable]
public sealed class TargetFrameworkAttribute : Attribute
{
	private string _frameworkName;

	private string _frameworkDisplayName;

	[__DynamicallyInvokable]
	public string FrameworkName
	{
		[__DynamicallyInvokable]
		get
		{
			return _frameworkName;
		}
	}

	[__DynamicallyInvokable]
	public string FrameworkDisplayName
	{
		[__DynamicallyInvokable]
		get
		{
			return _frameworkDisplayName;
		}
		[__DynamicallyInvokable]
		set
		{
			_frameworkDisplayName = value;
		}
	}

	[__DynamicallyInvokable]
	public TargetFrameworkAttribute(string frameworkName)
	{
		if (frameworkName == null)
		{
			throw new ArgumentNullException("frameworkName");
		}
		_frameworkName = frameworkName;
	}
}
