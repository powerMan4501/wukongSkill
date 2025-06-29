using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Threading;

[Serializable]
internal sealed class DomainCompressedStack
{
	private PermissionListSet m_pls;

	private bool m_bHaltConstruction;

	internal PermissionListSet PLS => m_pls;

	internal bool ConstructionHalted => m_bHaltConstruction;

	[SecurityCritical]
	private static DomainCompressedStack CreateManagedObject(IntPtr unmanagedDCS)
	{
		DomainCompressedStack domainCompressedStack = new DomainCompressedStack();
		domainCompressedStack.m_pls = PermissionListSet.CreateCompressedState(unmanagedDCS, out domainCompressedStack.m_bHaltConstruction);
		return domainCompressedStack;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int GetDescCount(IntPtr dcs);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void GetDomainPermissionSets(IntPtr dcs, out PermissionSet granted, out PermissionSet refused);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool GetDescriptorInfo(IntPtr dcs, int index, out PermissionSet granted, out PermissionSet refused, out Assembly assembly, out FrameSecurityDescriptor fsd);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool IgnoreDomain(IntPtr dcs);
}
