using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Runtime.Remoting.Lifetime;

[SecurityCritical]
[ComVisible(true)]
public sealed class LifetimeServices
{
	private static bool s_isLeaseTime = false;

	private static bool s_isRenewOnCallTime = false;

	private static bool s_isSponsorshipTimeout = false;

	private static long s_leaseTimeTicks = TimeSpan.FromMinutes(5.0).Ticks;

	private static long s_renewOnCallTimeTicks = TimeSpan.FromMinutes(2.0).Ticks;

	private static long s_sponsorshipTimeoutTicks = TimeSpan.FromMinutes(2.0).Ticks;

	private static long s_pollTimeTicks = TimeSpan.FromMilliseconds(10000.0).Ticks;

	private static object s_LifetimeSyncObject = null;

	private static object LifetimeSyncObject
	{
		get
		{
			if (s_LifetimeSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref s_LifetimeSyncObject, value, null);
			}
			return s_LifetimeSyncObject;
		}
	}

	public static TimeSpan LeaseTime
	{
		get
		{
			return GetTimeSpan(ref s_leaseTimeTicks);
		}
		[SecurityCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
		set
		{
			lock (LifetimeSyncObject)
			{
				if (s_isLeaseTime)
				{
					throw new RemotingException(Environment.GetResourceString("Remoting_Lifetime_SetOnce", "LeaseTime"));
				}
				SetTimeSpan(ref s_leaseTimeTicks, value);
				s_isLeaseTime = true;
			}
		}
	}

	public static TimeSpan RenewOnCallTime
	{
		get
		{
			return GetTimeSpan(ref s_renewOnCallTimeTicks);
		}
		[SecurityCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
		set
		{
			lock (LifetimeSyncObject)
			{
				if (s_isRenewOnCallTime)
				{
					throw new RemotingException(Environment.GetResourceString("Remoting_Lifetime_SetOnce", "RenewOnCallTime"));
				}
				SetTimeSpan(ref s_renewOnCallTimeTicks, value);
				s_isRenewOnCallTime = true;
			}
		}
	}

	public static TimeSpan SponsorshipTimeout
	{
		get
		{
			return GetTimeSpan(ref s_sponsorshipTimeoutTicks);
		}
		[SecurityCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
		set
		{
			lock (LifetimeSyncObject)
			{
				if (s_isSponsorshipTimeout)
				{
					throw new RemotingException(Environment.GetResourceString("Remoting_Lifetime_SetOnce", "SponsorshipTimeout"));
				}
				SetTimeSpan(ref s_sponsorshipTimeoutTicks, value);
				s_isSponsorshipTimeout = true;
			}
		}
	}

	public static TimeSpan LeaseManagerPollTime
	{
		get
		{
			return GetTimeSpan(ref s_pollTimeTicks);
		}
		[SecurityCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
		set
		{
			lock (LifetimeSyncObject)
			{
				SetTimeSpan(ref s_pollTimeTicks, value);
				if (LeaseManager.IsInitialized())
				{
					LeaseManager.GetLeaseManager().ChangePollTime(value);
				}
			}
		}
	}

	private static TimeSpan GetTimeSpan(ref long ticks)
	{
		return TimeSpan.FromTicks(Volatile.Read(ref ticks));
	}

	private static void SetTimeSpan(ref long ticks, TimeSpan value)
	{
		Volatile.Write(ref ticks, value.Ticks);
	}

	[Obsolete("Do not create instances of the LifetimeServices class.  Call the static methods directly on this type instead", true)]
	public LifetimeServices()
	{
	}

	[SecurityCritical]
	internal static ILease GetLeaseInitial(MarshalByRefObject obj)
	{
		ILease lease = null;
		LeaseManager leaseManager = LeaseManager.GetLeaseManager(LeaseManagerPollTime);
		lease = leaseManager.GetLease(obj);
		if (lease == null)
		{
			lease = CreateLease(obj);
		}
		return lease;
	}

	[SecurityCritical]
	internal static ILease GetLease(MarshalByRefObject obj)
	{
		ILease lease = null;
		LeaseManager leaseManager = LeaseManager.GetLeaseManager(LeaseManagerPollTime);
		return leaseManager.GetLease(obj);
	}

	[SecurityCritical]
	internal static ILease CreateLease(MarshalByRefObject obj)
	{
		return CreateLease(LeaseTime, RenewOnCallTime, SponsorshipTimeout, obj);
	}

	[SecurityCritical]
	internal static ILease CreateLease(TimeSpan leaseTime, TimeSpan renewOnCallTime, TimeSpan sponsorshipTimeout, MarshalByRefObject obj)
	{
		LeaseManager.GetLeaseManager(LeaseManagerPollTime);
		return new Lease(leaseTime, renewOnCallTime, sponsorshipTimeout, obj);
	}
}
