using System.Security.Permissions;

namespace System.Management.Instrumentation;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class ManagementConfigurationAttribute : ManagementMemberAttribute
{
	private ManagementConfigurationType updateMode;

	private Type _schema;

	public ManagementConfigurationType Mode
	{
		get
		{
			return updateMode;
		}
		set
		{
			updateMode = value;
		}
	}

	public Type Schema
	{
		get
		{
			return _schema;
		}
		set
		{
			_schema = value;
		}
	}

	public ManagementConfigurationAttribute()
	{
		updateMode = ManagementConfigurationType.Apply;
	}
}
