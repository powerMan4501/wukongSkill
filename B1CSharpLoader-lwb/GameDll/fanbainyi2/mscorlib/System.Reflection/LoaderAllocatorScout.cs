using System.Runtime.InteropServices;
using System.Security;

namespace System.Reflection;

internal sealed class LoaderAllocatorScout
{
	internal IntPtr m_nativeLoaderAllocator;

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	private static extern bool Destroy(IntPtr nativeLoaderAllocator);

	[SecuritySafeCritical]
	~LoaderAllocatorScout()
	{
		if (!m_nativeLoaderAllocator.IsNull() && (!Environment.HasShutdownStarted && (!AppDomain.CurrentDomain.IsFinalizingForUnload() && !Destroy(m_nativeLoaderAllocator))))
		{
			GC.ReRegisterForFinalize(this);
		}
	}
}
