using System.Security.Permissions;

namespace System.Management.Instrumentation;

[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class ManagementNameAttribute : Attribute
{
	private string _Name;

	public string Name => _Name;

	public ManagementNameAttribute(string name)
	{
		_Name = name;
	}
}
