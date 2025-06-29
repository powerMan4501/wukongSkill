using System.Runtime.InteropServices;

namespace System.Security;

[Serializable]
[Flags]
[ComVisible(true)]
public enum HostSecurityManagerOptions
{
	None = 0,
	HostAppDomainEvidence = 1,
	[Obsolete("AppDomain policy levels are obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	HostPolicyLevel = 2,
	HostAssemblyEvidence = 4,
	HostDetermineApplicationTrust = 8,
	HostResolvePolicy = 0x10,
	AllFlags = 0x1F
}
