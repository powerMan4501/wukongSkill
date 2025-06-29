using System.Security.Permissions;

namespace System.Management.Instrumentation;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class ManagementReferenceAttribute : Attribute
{
	private string _Type;

	public string Type
	{
		get
		{
			return _Type;
		}
		set
		{
			_Type = value;
		}
	}
}
