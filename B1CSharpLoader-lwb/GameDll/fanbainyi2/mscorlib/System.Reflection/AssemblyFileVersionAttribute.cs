using System.Runtime.InteropServices;

namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AssemblyFileVersionAttribute : Attribute
{
	private string _version;

	[__DynamicallyInvokable]
	public string Version
	{
		[__DynamicallyInvokable]
		get
		{
			return _version;
		}
	}

	[__DynamicallyInvokable]
	public AssemblyFileVersionAttribute(string version)
	{
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		_version = version;
	}
}
