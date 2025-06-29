using System;
using System.Collections.Generic;

namespace b1;

public class EventRegCache
{
	public int EventId;

	public Delegate Del;

	public bool IsNetActive;

	public static Queue<EventRegCache> sEventRegCaches;

	private static void AppendEventRegCacheQueue(int count)
	{
		for (int i = 0; i < count; i++)
		{
			sEventRegCaches.Enqueue(new EventRegCache());
		}
	}

	static EventRegCache()
	{
		sEventRegCaches = new Queue<EventRegCache>();
		AppendEventRegCacheQueue(8000);
	}

	public static EventRegCache AllocEventRegCache(int EventId, Delegate Del, bool IsNetActive)
	{
		if (sEventRegCaches.Count <= 0)
		{
			AppendEventRegCacheQueue(100);
		}
		EventRegCache eventRegCache = sEventRegCaches.Dequeue();
		eventRegCache.EventId = EventId;
		eventRegCache.Del = Del;
		eventRegCache.IsNetActive = IsNetActive;
		return eventRegCache;
	}

	public static void DeAllocEventRegCache(EventRegCache RegCache)
	{
		RegCache.Del = null;
		sEventRegCaches.Enqueue(RegCache);
	}
}
