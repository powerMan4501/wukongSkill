using System.Security;

namespace System.Runtime.Remoting.Proxies;

internal sealed class __TransparentProxy
{
	[SecurityCritical]
	private RealProxy _rp;

	private object _stubData;

	private IntPtr _pMT;

	private IntPtr _pInterfaceMT;

	private IntPtr _stub;

	private __TransparentProxy()
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_Constructor"));
	}
}
