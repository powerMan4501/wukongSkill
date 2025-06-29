using System.Collections.Generic;
using System.Globalization;
using System.Security;
using Microsoft.Win32;

namespace System.Diagnostics.Eventing.Reader;

internal class ProviderMetadataCachedInformation
{
	private class ProviderMetadataId
	{
		private string providerName;

		private CultureInfo cultureInfo;

		public string ProviderName => providerName;

		public CultureInfo TheCultureInfo => cultureInfo;

		public ProviderMetadataId(string providerName, CultureInfo cultureInfo)
		{
			this.providerName = providerName;
			this.cultureInfo = cultureInfo;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is ProviderMetadataId providerMetadataId))
			{
				return false;
			}
			if (providerName.Equals(providerMetadataId.providerName) && cultureInfo == providerMetadataId.cultureInfo)
			{
				return true;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return providerName.GetHashCode() ^ cultureInfo.GetHashCode();
		}
	}

	private class CacheItem
	{
		private ProviderMetadata pm;

		private DateTime theTime;

		public DateTime TheTime
		{
			get
			{
				return theTime;
			}
			set
			{
				theTime = value;
			}
		}

		public ProviderMetadata ProviderMetadata => pm;

		public CacheItem(ProviderMetadata pm)
		{
			this.pm = pm;
			theTime = DateTime.Now;
		}
	}

	private Dictionary<ProviderMetadataId, CacheItem> cache;

	private int maximumCacheSize;

	private EventLogSession session;

	private string logfile;

	public ProviderMetadataCachedInformation(EventLogSession session, string logfile, int maximumCacheSize)
	{
		this.session = session;
		this.logfile = logfile;
		cache = new Dictionary<ProviderMetadataId, CacheItem>();
		this.maximumCacheSize = maximumCacheSize;
	}

	private bool IsCacheFull()
	{
		return cache.Count == maximumCacheSize;
	}

	private bool IsProviderinCache(ProviderMetadataId key)
	{
		return cache.ContainsKey(key);
	}

	private void DeleteCacheEntry(ProviderMetadataId key)
	{
		if (IsProviderinCache(key))
		{
			CacheItem cacheItem = cache[key];
			cache.Remove(key);
			cacheItem.ProviderMetadata.Dispose();
		}
	}

	private void AddCacheEntry(ProviderMetadataId key, ProviderMetadata pm)
	{
		if (IsCacheFull())
		{
			FlushOldestEntry();
		}
		CacheItem value = new CacheItem(pm);
		cache.Add(key, value);
	}

	private void FlushOldestEntry()
	{
		double num = -10.0;
		DateTime now = DateTime.Now;
		ProviderMetadataId providerMetadataId = null;
		foreach (KeyValuePair<ProviderMetadataId, CacheItem> item in cache)
		{
			TimeSpan timeSpan = now.Subtract(item.Value.TheTime);
			if (timeSpan.TotalMilliseconds >= num)
			{
				num = timeSpan.TotalMilliseconds;
				providerMetadataId = item.Key;
			}
		}
		if (providerMetadataId != null)
		{
			DeleteCacheEntry(providerMetadataId);
		}
	}

	private static void UpdateCacheValueInfoForHit(CacheItem cacheItem)
	{
		cacheItem.TheTime = DateTime.Now;
	}

	private ProviderMetadata GetProviderMetadata(ProviderMetadataId key)
	{
		if (!IsProviderinCache(key))
		{
			ProviderMetadata providerMetadata;
			try
			{
				providerMetadata = new ProviderMetadata(key.ProviderName, session, key.TheCultureInfo, logfile);
			}
			catch (EventLogNotFoundException)
			{
				providerMetadata = new ProviderMetadata(key.ProviderName, session, key.TheCultureInfo);
			}
			AddCacheEntry(key, providerMetadata);
			return providerMetadata;
		}
		CacheItem cacheItem = cache[key];
		ProviderMetadata providerMetadata2 = cacheItem.ProviderMetadata;
		try
		{
			providerMetadata2.CheckReleased();
			UpdateCacheValueInfoForHit(cacheItem);
		}
		catch (EventLogException)
		{
			DeleteCacheEntry(key);
			try
			{
				providerMetadata2 = new ProviderMetadata(key.ProviderName, session, key.TheCultureInfo, logfile);
			}
			catch (EventLogNotFoundException)
			{
				providerMetadata2 = new ProviderMetadata(key.ProviderName, session, key.TheCultureInfo);
			}
			AddCacheEntry(key, providerMetadata2);
		}
		return providerMetadata2;
	}

	[SecuritySafeCritical]
	public string GetFormatDescription(string ProviderName, EventLogHandle eventHandle)
	{
		lock (this)
		{
			ProviderMetadataId key = new ProviderMetadataId(ProviderName, CultureInfo.CurrentCulture);
			try
			{
				ProviderMetadata providerMetadata = GetProviderMetadata(key);
				return NativeWrapper.EvtFormatMessageRenderName(providerMetadata.Handle, eventHandle, Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessageFlags.EvtFormatMessageEvent);
			}
			catch (EventLogNotFoundException)
			{
				return null;
			}
		}
	}

	public string GetFormatDescription(string ProviderName, EventLogHandle eventHandle, string[] values)
	{
		lock (this)
		{
			ProviderMetadataId key = new ProviderMetadataId(ProviderName, CultureInfo.CurrentCulture);
			ProviderMetadata providerMetadata = GetProviderMetadata(key);
			try
			{
				return NativeWrapper.EvtFormatMessageFormatDescription(providerMetadata.Handle, eventHandle, values);
			}
			catch (EventLogNotFoundException)
			{
				return null;
			}
		}
	}

	[SecuritySafeCritical]
	public string GetLevelDisplayName(string ProviderName, EventLogHandle eventHandle)
	{
		lock (this)
		{
			ProviderMetadataId key = new ProviderMetadataId(ProviderName, CultureInfo.CurrentCulture);
			ProviderMetadata providerMetadata = GetProviderMetadata(key);
			return NativeWrapper.EvtFormatMessageRenderName(providerMetadata.Handle, eventHandle, Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessageFlags.EvtFormatMessageLevel);
		}
	}

	[SecuritySafeCritical]
	public string GetOpcodeDisplayName(string ProviderName, EventLogHandle eventHandle)
	{
		lock (this)
		{
			ProviderMetadataId key = new ProviderMetadataId(ProviderName, CultureInfo.CurrentCulture);
			ProviderMetadata providerMetadata = GetProviderMetadata(key);
			return NativeWrapper.EvtFormatMessageRenderName(providerMetadata.Handle, eventHandle, Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessageFlags.EvtFormatMessageOpcode);
		}
	}

	[SecuritySafeCritical]
	public string GetTaskDisplayName(string ProviderName, EventLogHandle eventHandle)
	{
		lock (this)
		{
			ProviderMetadataId key = new ProviderMetadataId(ProviderName, CultureInfo.CurrentCulture);
			ProviderMetadata providerMetadata = GetProviderMetadata(key);
			return NativeWrapper.EvtFormatMessageRenderName(providerMetadata.Handle, eventHandle, Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessageFlags.EvtFormatMessageTask);
		}
	}

	[SecuritySafeCritical]
	public IEnumerable<string> GetKeywordDisplayNames(string ProviderName, EventLogHandle eventHandle)
	{
		lock (this)
		{
			ProviderMetadataId key = new ProviderMetadataId(ProviderName, CultureInfo.CurrentCulture);
			ProviderMetadata providerMetadata = GetProviderMetadata(key);
			return NativeWrapper.EvtFormatMessageRenderKeywords(providerMetadata.Handle, eventHandle, Microsoft.Win32.UnsafeNativeMethods.EvtFormatMessageFlags.EvtFormatMessageKeyword);
		}
	}
}
