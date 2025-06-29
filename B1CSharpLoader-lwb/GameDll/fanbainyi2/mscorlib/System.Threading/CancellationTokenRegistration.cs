using System.Runtime.CompilerServices;
using System.Security.Permissions;

namespace System.Threading;

[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable
{
	private readonly CancellationCallbackInfo m_callbackInfo;

	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo;

	internal CancellationTokenRegistration(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo)
	{
		m_callbackInfo = callbackInfo;
		m_registrationInfo = registrationInfo;
	}

	[FriendAccessAllowed]
	internal bool TryDeregister()
	{
		if (m_registrationInfo.Source == null)
		{
			return false;
		}
		CancellationCallbackInfo cancellationCallbackInfo = m_registrationInfo.Source.SafeAtomicRemove(m_registrationInfo.Index, m_callbackInfo);
		if (cancellationCallbackInfo != m_callbackInfo)
		{
			return false;
		}
		return true;
	}

	[__DynamicallyInvokable]
	public void Dispose()
	{
		bool flag = TryDeregister();
		CancellationCallbackInfo callbackInfo = m_callbackInfo;
		if (callbackInfo != null)
		{
			CancellationTokenSource cancellationTokenSource = callbackInfo.CancellationTokenSource;
			if (cancellationTokenSource.IsCancellationRequested && !cancellationTokenSource.IsCancellationCompleted && !flag && cancellationTokenSource.ThreadIDExecutingCallbacks != Thread.CurrentThread.ManagedThreadId)
			{
				cancellationTokenSource.WaitForCallbackToComplete(m_callbackInfo);
			}
		}
	}

	[__DynamicallyInvokable]
	public static bool operator ==(CancellationTokenRegistration left, CancellationTokenRegistration right)
	{
		return left.Equals(right);
	}

	[__DynamicallyInvokable]
	public static bool operator !=(CancellationTokenRegistration left, CancellationTokenRegistration right)
	{
		return !left.Equals(right);
	}

	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (obj is CancellationTokenRegistration)
		{
			return Equals((CancellationTokenRegistration)obj);
		}
		return false;
	}

	[__DynamicallyInvokable]
	public bool Equals(CancellationTokenRegistration other)
	{
		if (m_callbackInfo == other.m_callbackInfo && m_registrationInfo.Source == other.m_registrationInfo.Source)
		{
			return m_registrationInfo.Index == other.m_registrationInfo.Index;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		if (m_registrationInfo.Source != null)
		{
			return m_registrationInfo.Source.GetHashCode() ^ m_registrationInfo.Index.GetHashCode();
		}
		return m_registrationInfo.Index.GetHashCode();
	}
}
