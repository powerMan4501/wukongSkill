using Microsoft.Win32.SafeHandles;

namespace System.Security.Authentication.ExtendedProtection;

[global::__DynamicallyInvokable]
public abstract class ChannelBinding : SafeHandleZeroOrMinusOneIsInvalid
{
	[global::__DynamicallyInvokable]
	public abstract int Size
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	protected ChannelBinding()
		: base(ownsHandle: true)
	{
	}

	[global::__DynamicallyInvokable]
	protected ChannelBinding(bool ownsHandle)
		: base(ownsHandle)
	{
	}
}
