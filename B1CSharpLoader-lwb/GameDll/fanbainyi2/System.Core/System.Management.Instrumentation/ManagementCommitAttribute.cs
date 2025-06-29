using System.Security.Permissions;

namespace System.Management.Instrumentation;

[AttributeUsage(AttributeTargets.Method)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class ManagementCommitAttribute : ManagementMemberAttribute
{
}
