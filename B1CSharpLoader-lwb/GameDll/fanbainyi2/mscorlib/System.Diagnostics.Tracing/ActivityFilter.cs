using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Security;
using System.Threading;

namespace System.Diagnostics.Tracing;

internal sealed class ActivityFilter : IDisposable
{
	private ConcurrentDictionary<Guid, int> m_activeActivities;

	private ConcurrentDictionary<Guid, Tuple<Guid, int>> m_rootActiveActivities;

	private Guid m_providerGuid;

	private int m_eventId;

	private int m_samplingFreq;

	private int m_curSampleCount;

	private int m_perEventSourceSessionId;

	private const int MaxActivityTrackCount = 100000;

	private ActivityFilter m_next;

	private Action<Guid> m_myActivityDelegate;

	public static void DisableFilter(ref ActivityFilter filterList, EventSource source)
	{
		if (filterList == null)
		{
			return;
		}
		ActivityFilter activityFilter = filterList;
		ActivityFilter next = activityFilter.m_next;
		while (next != null)
		{
			if (next.m_providerGuid == source.Guid)
			{
				if (next.m_eventId >= 0 && next.m_eventId < source.m_eventData.Length)
				{
					source.m_eventData[next.m_eventId].TriggersActivityTracking--;
				}
				activityFilter.m_next = next.m_next;
				next.Dispose();
				next = activityFilter.m_next;
			}
			else
			{
				activityFilter = next;
				next = activityFilter.m_next;
			}
		}
		if (filterList.m_providerGuid == source.Guid)
		{
			if (filterList.m_eventId >= 0 && filterList.m_eventId < source.m_eventData.Length)
			{
				source.m_eventData[filterList.m_eventId].TriggersActivityTracking--;
			}
			ActivityFilter activityFilter2 = filterList;
			filterList = activityFilter2.m_next;
			activityFilter2.Dispose();
		}
		if (filterList != null)
		{
			EnsureActivityCleanupDelegate(filterList);
		}
	}

	public static void UpdateFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, string startEvents)
	{
		DisableFilter(ref filterList, source);
		if (string.IsNullOrEmpty(startEvents))
		{
			return;
		}
		string[] array = startEvents.Split(' ');
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i];
			int result = 1;
			int result2 = -1;
			int num = text.IndexOf(':');
			if (num < 0)
			{
				source.ReportOutOfBandMessage("ERROR: Invalid ActivitySamplingStartEvent specification: " + text, flush: false);
				continue;
			}
			string text2 = text.Substring(num + 1);
			if (!int.TryParse(text2, out result))
			{
				source.ReportOutOfBandMessage("ERROR: Invalid sampling frequency specification: " + text2, flush: false);
				continue;
			}
			text = text.Substring(0, num);
			if (!int.TryParse(text, out result2))
			{
				result2 = -1;
				for (int j = 0; j < source.m_eventData.Length; j++)
				{
					EventSource.EventMetadata[] eventData = source.m_eventData;
					if (eventData[j].Name != null && eventData[j].Name.Length == text.Length && string.Compare(eventData[j].Name, text, StringComparison.OrdinalIgnoreCase) == 0)
					{
						result2 = eventData[j].Descriptor.EventId;
						break;
					}
				}
			}
			if (result2 < 0 || result2 >= source.m_eventData.Length)
			{
				source.ReportOutOfBandMessage("ERROR: Invalid eventId specification: " + text, flush: false);
			}
			else
			{
				EnableFilter(ref filterList, source, perEventSourceSessionId, result2, result);
			}
		}
	}

	public static ActivityFilter GetFilter(ActivityFilter filterList, EventSource source)
	{
		for (ActivityFilter activityFilter = filterList; activityFilter != null; activityFilter = activityFilter.m_next)
		{
			if (activityFilter.m_providerGuid == source.Guid && activityFilter.m_samplingFreq != -1)
			{
				return activityFilter;
			}
		}
		return null;
	}

	[SecurityCritical]
	public unsafe static bool PassesActivityFilter(ActivityFilter filterList, Guid* childActivityID, bool triggeringEvent, EventSource source, int eventId)
	{
		bool flag = false;
		if (triggeringEvent)
		{
			for (ActivityFilter activityFilter = filterList; activityFilter != null; activityFilter = activityFilter.m_next)
			{
				if (eventId == activityFilter.m_eventId && source.Guid == activityFilter.m_providerGuid)
				{
					int curSampleCount;
					do
					{
						curSampleCount = activityFilter.m_curSampleCount;
					}
					while (Interlocked.CompareExchange(value: (curSampleCount > 1) ? (curSampleCount - 1) : activityFilter.m_samplingFreq, location1: ref activityFilter.m_curSampleCount, comparand: curSampleCount) != curSampleCount);
					if (curSampleCount <= 1)
					{
						Guid internalCurrentThreadActivityId = EventSource.InternalCurrentThreadActivityId;
						if (!activityFilter.m_rootActiveActivities.TryGetValue(internalCurrentThreadActivityId, out var _))
						{
							flag = true;
							activityFilter.m_activeActivities[internalCurrentThreadActivityId] = Environment.TickCount;
							activityFilter.m_rootActiveActivities[internalCurrentThreadActivityId] = Tuple.Create(source.Guid, eventId);
						}
					}
					else
					{
						Guid internalCurrentThreadActivityId2 = EventSource.InternalCurrentThreadActivityId;
						if (activityFilter.m_rootActiveActivities.TryGetValue(internalCurrentThreadActivityId2, out var value2) && value2.Item1 == source.Guid && value2.Item2 == eventId)
						{
							activityFilter.m_activeActivities.TryRemove(internalCurrentThreadActivityId2, out var _);
						}
					}
					break;
				}
			}
		}
		ConcurrentDictionary<Guid, int> activeActivities = GetActiveActivities(filterList);
		if (activeActivities != null)
		{
			if (!flag)
			{
				flag = !activeActivities.IsEmpty && activeActivities.ContainsKey(EventSource.InternalCurrentThreadActivityId);
			}
			if (flag && childActivityID != null && source.m_eventData[eventId].Descriptor.Opcode == 9)
			{
				FlowActivityIfNeeded(filterList, null, childActivityID);
			}
		}
		return flag;
	}

	[SecuritySafeCritical]
	public static bool IsCurrentActivityActive(ActivityFilter filterList)
	{
		ConcurrentDictionary<Guid, int> activeActivities = GetActiveActivities(filterList);
		if (activeActivities != null && activeActivities.ContainsKey(EventSource.InternalCurrentThreadActivityId))
		{
			return true;
		}
		return false;
	}

	[SecurityCritical]
	public unsafe static void FlowActivityIfNeeded(ActivityFilter filterList, Guid* currentActivityId, Guid* childActivityID)
	{
		ConcurrentDictionary<Guid, int> activeActivities = GetActiveActivities(filterList);
		if (currentActivityId == null || activeActivities.ContainsKey(*currentActivityId))
		{
			if (activeActivities.Count > 100000)
			{
				TrimActiveActivityStore(activeActivities);
				activeActivities[EventSource.InternalCurrentThreadActivityId] = Environment.TickCount;
			}
			activeActivities[*childActivityID] = Environment.TickCount;
		}
	}

	public static void UpdateKwdTriggers(ActivityFilter activityFilter, Guid sourceGuid, EventSource source, EventKeywords sessKeywords)
	{
		for (ActivityFilter activityFilter2 = activityFilter; activityFilter2 != null; activityFilter2 = activityFilter2.m_next)
		{
			if (sourceGuid == activityFilter2.m_providerGuid && (source.m_eventData[activityFilter2.m_eventId].TriggersActivityTracking > 0 || source.m_eventData[activityFilter2.m_eventId].Descriptor.Opcode == 9))
			{
				source.m_keywordTriggers |= (long)((ulong)source.m_eventData[activityFilter2.m_eventId].Descriptor.Keywords & (ulong)sessKeywords);
			}
		}
	}

	public IEnumerable<Tuple<int, int>> GetFilterAsTuple(Guid sourceGuid)
	{
		for (ActivityFilter af = this; af != null; af = af.m_next)
		{
			if (af.m_providerGuid == sourceGuid)
			{
				yield return Tuple.Create(af.m_eventId, af.m_samplingFreq);
			}
		}
	}

	public void Dispose()
	{
		if (m_myActivityDelegate != null)
		{
			EventSource.s_activityDying = (Action<Guid>)Delegate.Remove(EventSource.s_activityDying, m_myActivityDelegate);
			m_myActivityDelegate = null;
		}
	}

	private ActivityFilter(EventSource source, int perEventSourceSessionId, int eventId, int samplingFreq, ActivityFilter existingFilter = null)
	{
		m_providerGuid = source.Guid;
		m_perEventSourceSessionId = perEventSourceSessionId;
		m_eventId = eventId;
		m_samplingFreq = samplingFreq;
		m_next = existingFilter;
		ConcurrentDictionary<Guid, int> concurrentDictionary = null;
		if (existingFilter == null || (concurrentDictionary = GetActiveActivities(existingFilter)) == null)
		{
			m_activeActivities = new ConcurrentDictionary<Guid, int>();
			m_rootActiveActivities = new ConcurrentDictionary<Guid, Tuple<Guid, int>>();
			m_myActivityDelegate = GetActivityDyingDelegate(this);
			EventSource.s_activityDying = (Action<Guid>)Delegate.Combine(EventSource.s_activityDying, m_myActivityDelegate);
		}
		else
		{
			m_activeActivities = concurrentDictionary;
			m_rootActiveActivities = existingFilter.m_rootActiveActivities;
		}
	}

	private static void EnsureActivityCleanupDelegate(ActivityFilter filterList)
	{
		if (filterList == null)
		{
			return;
		}
		for (ActivityFilter activityFilter = filterList; activityFilter != null; activityFilter = activityFilter.m_next)
		{
			if (activityFilter.m_myActivityDelegate != null)
			{
				return;
			}
		}
		filterList.m_myActivityDelegate = GetActivityDyingDelegate(filterList);
		EventSource.s_activityDying = (Action<Guid>)Delegate.Combine(EventSource.s_activityDying, filterList.m_myActivityDelegate);
	}

	private static Action<Guid> GetActivityDyingDelegate(ActivityFilter filterList)
	{
		return delegate(Guid oldActivity)
		{
			filterList.m_activeActivities.TryRemove(oldActivity, out var _);
			filterList.m_rootActiveActivities.TryRemove(oldActivity, out var _);
		};
	}

	private static bool EnableFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, int eventId, int samplingFreq)
	{
		filterList = new ActivityFilter(source, perEventSourceSessionId, eventId, samplingFreq, filterList);
		if (0 <= eventId && eventId < source.m_eventData.Length)
		{
			source.m_eventData[eventId].TriggersActivityTracking++;
		}
		return true;
	}

	private static void TrimActiveActivityStore(ConcurrentDictionary<Guid, int> activities)
	{
		if (activities.Count > 100000)
		{
			KeyValuePair<Guid, int>[] array = activities.ToArray();
			int tickNow = Environment.TickCount;
			Array.Sort(array, (KeyValuePair<Guid, int> x, KeyValuePair<Guid, int> y) => (0x7FFFFFFF & (tickNow - y.Value)) - (0x7FFFFFFF & (tickNow - x.Value)));
			for (int num = 0; num < array.Length / 2; num++)
			{
				activities.TryRemove(array[num].Key, out var _);
			}
		}
	}

	private static ConcurrentDictionary<Guid, int> GetActiveActivities(ActivityFilter filterList)
	{
		for (ActivityFilter activityFilter = filterList; activityFilter != null; activityFilter = activityFilter.m_next)
		{
			if (activityFilter.m_activeActivities != null)
			{
				return activityFilter.m_activeActivities;
			}
		}
		return null;
	}
}
