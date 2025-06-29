using System.Net.WebSockets;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal sealed class SafeWebSocketHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal SafeWebSocketHandle()
		: base(ownsHandle: true)
	{
	}

	protected override bool ReleaseHandle()
	{
		if (IsInvalid)
		{
			return true;
		}
		WebSocketProtocolComponent.WebSocketDeleteHandle(handle);
		return true;
	}
}
