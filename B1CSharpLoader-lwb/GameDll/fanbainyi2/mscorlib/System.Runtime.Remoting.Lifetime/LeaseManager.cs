using System.Collections;
using System.Diagnostics;
using System.Security;
using System.Threading;

namespace System.Runtime.Remoting.Lifetime;

internal class LeaseManager
{
	internal class SponsorInfo
	{
		internal Lease lease;

		internal object sponsorId;

		internal DateTime sponsorWaitTime;

		internal SponsorInfo(Lease lease, object sponsorId, DateTime sponsorWaitTime)
		{
			this.lease = lease;
			this.sponsorId = sponsorId;
			this.sponsorWaitTime = sponsorWaitTime;
		}
	}

	private Hashtable leaseToTimeTable = new Hashtable();

	private Hashtable sponsorTable = new Hashtable();

	private TimeSpan pollTime;

	private AutoResetEvent waitHandle;

	private TimerCallback leaseTimeAnalyzerDelegate;

	private volatile Timer leaseTimer;

	private ArrayList tempObjects = new ArrayList(10);

	internal static bool IsInitialized()
	{
		DomainSpecificRemotingData remotingData = Thread.GetDomain().RemotingData;
		LeaseManager leaseManager = remotingData.LeaseManager;
		return leaseManager != null;
	}

	[SecurityCritical]
	internal static LeaseManager GetLeaseManager(TimeSpan pollTime)
	{
		DomainSpecificRemotingData remotingData = Thread.GetDomain().RemotingData;
		LeaseManager leaseManager = remotingData.LeaseManager;
		if (leaseManager == null)
		{
			lock (remotingData)
			{
				if (remotingData.LeaseManager == null)
				{
					remotingData.LeaseManager = new LeaseManager(pollTime);
				}
				leaseManager = remotingData.LeaseManager;
			}
		}
		return leaseManager;
	}

	internal static LeaseManager GetLeaseManager()
	{
		DomainSpecificRemotingData remotingData = Thread.GetDomain().RemotingData;
		return remotingData.LeaseManager;
	}

	[SecurityCritical]
	private LeaseManager(TimeSpan pollTime)
	{
		this.pollTime = pollTime;
		leaseTimeAnalyzerDelegate = LeaseTimeAnalyzer;
		waitHandle = new AutoResetEvent(initialState: false);
		leaseTimer = new Timer(leaseTimeAnalyzerDelegate, null, -1, -1);
		leaseTimer.Change((int)pollTime.TotalMilliseconds, -1);
	}

	internal void ChangePollTime(TimeSpan pollTime)
	{
		this.pollTime = pollTime;
	}

	internal void ActivateLease(Lease lease)
	{
		lock (leaseToTimeTable)
		{
			leaseToTimeTable[lease] = lease.leaseTime;
		}
	}

	internal void DeleteLease(Lease lease)
	{
		lock (leaseToTimeTable)
		{
			leaseToTimeTable.Remove(lease);
		}
	}

	[Conditional("_LOGGING")]
	internal void DumpLeases(Lease[] leases)
	{
		for (int i = 0; i < leases.Length; i++)
		{
		}
	}

	internal ILease GetLease(MarshalByRefObject obj)
	{
		bool fServer = true;
		return MarshalByRefObject.GetIdentity(obj, out fServer)?.Lease;
	}

	internal void ChangedLeaseTime(Lease lease, DateTime newTime)
	{
		lock (leaseToTimeTable)
		{
			leaseToTimeTable[lease] = newTime;
		}
	}

	internal void RegisterSponsorCall(Lease lease, object sponsorId, TimeSpan sponsorshipTimeOut)
	{
		lock (sponsorTable)
		{
			DateTime sponsorWaitTime = DateTime.UtcNow.Add(sponsorshipTimeOut);
			sponsorTable[sponsorId] = new SponsorInfo(lease, sponsorId, sponsorWaitTime);
		}
	}

	internal void DeleteSponsor(object sponsorId)
	{
		lock (sponsorTable)
		{
			sponsorTable.Remove(sponsorId);
		}
	}

	[SecurityCritical]
	private void LeaseTimeAnalyzer(object state)
	{
		DateTime utcNow = DateTime.UtcNow;
		lock (leaseToTimeTable)
		{
			IDictionaryEnumerator enumerator = leaseToTimeTable.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DateTime dateTime = (DateTime)enumerator.Value;
				Lease value = (Lease)enumerator.Key;
				if (dateTime.CompareTo(utcNow) < 0)
				{
					tempObjects.Add(value);
				}
			}
			for (int i = 0; i < tempObjects.Count; i++)
			{
				Lease key = (Lease)tempObjects[i];
				leaseToTimeTable.Remove(key);
			}
		}
		for (int j = 0; j < tempObjects.Count; j++)
		{
			((Lease)tempObjects[j])?.LeaseExpired(utcNow);
		}
		tempObjects.Clear();
		lock (sponsorTable)
		{
			IDictionaryEnumerator enumerator2 = sponsorTable.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				object key2 = enumerator2.Key;
				SponsorInfo sponsorInfo = (SponsorInfo)enumerator2.Value;
				if (sponsorInfo.sponsorWaitTime.CompareTo(utcNow) < 0)
				{
					tempObjects.Add(sponsorInfo);
				}
			}
			for (int k = 0; k < tempObjects.Count; k++)
			{
				SponsorInfo sponsorInfo2 = (SponsorInfo)tempObjects[k];
				sponsorTable.Remove(sponsorInfo2.sponsorId);
			}
		}
		for (int l = 0; l < tempObjects.Count; l++)
		{
			SponsorInfo sponsorInfo3 = (SponsorInfo)tempObjects[l];
			if (sponsorInfo3 != null && sponsorInfo3.lease != null)
			{
				sponsorInfo3.lease.SponsorTimeout(sponsorInfo3.sponsorId);
				tempObjects[l] = null;
			}
		}
		tempObjects.Clear();
		leaseTimer.Change((int)pollTime.TotalMilliseconds, -1);
	}
}
