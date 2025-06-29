using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Security.Authentication.ExtendedProtection;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal abstract class SafeFreeContextBufferChannelBinding : ChannelBinding
{
	private int size;

	public override int Size => size;

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal void Set(IntPtr value)
	{
		handle = value;
	}

	internal static SafeFreeContextBufferChannelBinding CreateEmptyHandle(SecurDll dll)
	{
		if (dll == SecurDll.SECURITY)
		{
			return new SafeFreeContextBufferChannelBinding_SECURITY();
		}
		throw new ArgumentException(SR.GetString("net_invalid_enum", "SecurDll"), "dll");
	}

	public unsafe static int QueryContextChannelBinding(SecurDll dll, SafeDeleteContext phContext, ContextAttribute contextAttribute, Bindings* buffer, SafeFreeContextBufferChannelBinding refHandle)
	{
		if (dll == SecurDll.SECURITY)
		{
			return QueryContextChannelBinding_SECURITY(phContext, contextAttribute, buffer, refHandle);
		}
		return -1;
	}

	private unsafe static int QueryContextChannelBinding_SECURITY(SafeDeleteContext phContext, ContextAttribute contextAttribute, Bindings* buffer, SafeFreeContextBufferChannelBinding refHandle)
	{
		int num = -2146893055;
		bool success = false;
		if (contextAttribute != ContextAttribute.EndpointBindings && contextAttribute != ContextAttribute.UniqueBindings)
		{
			return num;
		}
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			phContext.DangerousAddRef(ref success);
		}
		catch (Exception ex)
		{
			if (success)
			{
				phContext.DangerousRelease();
				success = false;
			}
			if (!(ex is ObjectDisposedException))
			{
				throw;
			}
		}
		finally
		{
			if (success)
			{
				num = UnsafeNclNativeMethods.SafeNetHandles_SECURITY.QueryContextAttributesW(ref phContext._handle, contextAttribute, buffer);
				phContext.DangerousRelease();
			}
			if (num == 0 && refHandle != null)
			{
				refHandle.Set(buffer->pBindings);
				refHandle.size = buffer->BindingsLength;
			}
			if (num != 0)
			{
				refHandle?.SetHandleAsInvalid();
			}
		}
		return num;
	}
}
