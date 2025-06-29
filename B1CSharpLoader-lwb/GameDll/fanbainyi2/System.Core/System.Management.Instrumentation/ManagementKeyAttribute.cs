using System.Security.Permissions;

namespace System.Management.Instrumentation;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class ManagementKeyAttribute : ManagementMemberAttribute
{
}
