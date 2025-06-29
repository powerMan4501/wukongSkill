using System.Security.Permissions;

namespace System.Management.Instrumentation;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class ManagementEnumeratorAttribute : ManagementNewInstanceAttribute
{
	private Type _schema;

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
}
