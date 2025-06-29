using System.Security.Permissions;

namespace System.Management.Instrumentation;

[AttributeUsage(AttributeTargets.All)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public abstract class ManagementMemberAttribute : Attribute
{
	private string _Name;

	public string Name
	{
		get
		{
			return _Name;
		}
		set
		{
			_Name = value;
		}
	}
}
