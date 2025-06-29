using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Security;
using System.Security.Permissions;

namespace System.Threading;

internal sealed class PinnableBufferCache
{
	private const int DefaultNumberOfBuffers = 16;

	private string m_CacheName;

	private Func<object> m_factory;

	private ConcurrentStack<object> m_FreeList = new ConcurrentStack<object>();

	private List<object> m_NotGen2;

	private int m_gen1CountAtLastRestock;

	private int m_msecNoUseBeyondFreeListSinceThisTime;

	private bool m_moreThanFreeListNeeded;

	private int m_buffersUnderManagement;

	private int m_restockSize;

	private bool m_trimmingExperimentInProgress;

	private int m_minBufferCount;

	private int m_numAllocCalls;

	public PinnableBufferCache(string cacheName, int numberOfElements)
		: this(cacheName, () => new byte[numberOfElements])
	{
	}

	public byte[] AllocateBuffer()
	{
		return (byte[])Allocate();
	}

	public void FreeBuffer(byte[] buffer)
	{
		Free(buffer);
	}

	[SecuritySafeCritical]
	[EnvironmentPermission(SecurityAction.Assert, Unrestricted = true)]
	internal PinnableBufferCache(string cacheName, Func<object> factory)
	{
		m_NotGen2 = new List<object>(16);
		m_factory = factory;
		string variable = "PinnableBufferCache_" + cacheName + "_Disabled";
		try
		{
			string environmentVariable = Environment.GetEnvironmentVariable(variable);
			if (environmentVariable != null)
			{
				PinnableBufferCacheEventSource.Log.DebugMessage("Creating " + cacheName + " PinnableBufferCacheDisabled=" + environmentVariable);
				int num = environmentVariable.IndexOf(cacheName, StringComparison.OrdinalIgnoreCase);
				if (0 <= num)
				{
					PinnableBufferCacheEventSource.Log.DebugMessage("Disabling " + cacheName);
					return;
				}
			}
		}
		catch
		{
		}
		string variable2 = "PinnableBufferCache_" + cacheName + "_MinCount";
		try
		{
			string environmentVariable2 = Environment.GetEnvironmentVariable(variable2);
			if (environmentVariable2 != null && int.TryParse(environmentVariable2, out m_minBufferCount))
			{
				CreateNewBuffers();
			}
		}
		catch
		{
		}
		PinnableBufferCacheEventSource.Log.Create(cacheName);
		m_CacheName = cacheName;
	}

	[SecuritySafeCritical]
	internal object Allocate()
	{
		if (m_CacheName == null)
		{
			return m_factory();
		}
		if (!m_FreeList.TryPop(out var result))
		{
			Restock(out result);
		}
		if (PinnableBufferCacheEventSource.Log.IsEnabled())
		{
			int num = Interlocked.Increment(ref m_numAllocCalls);
			if (num >= 1024)
			{
				lock (this)
				{
					int num2 = Interlocked.Exchange(ref m_numAllocCalls, 0);
					if (num2 >= 1024)
					{
						int num3 = 0;
						foreach (object free in m_FreeList)
						{
							if (GC.GetGeneration(free) < GC.MaxGeneration)
							{
								num3++;
							}
						}
						PinnableBufferCacheEventSource.Log.WalkFreeListResult(m_CacheName, m_FreeList.Count, num3);
					}
				}
			}
			PinnableBufferCacheEventSource.Log.AllocateBuffer(m_CacheName, PinnableBufferCacheEventSource.AddressOf(result), result.GetHashCode(), GC.GetGeneration(result), m_FreeList.Count);
		}
		return result;
	}

	[SecuritySafeCritical]
	internal void Free(object buffer)
	{
		if (m_CacheName == null)
		{
			return;
		}
		if (PinnableBufferCacheEventSource.Log.IsEnabled())
		{
			PinnableBufferCacheEventSource.Log.FreeBuffer(m_CacheName, PinnableBufferCacheEventSource.AddressOf(buffer), buffer.GetHashCode(), m_FreeList.Count);
		}
		if (buffer == null)
		{
			if (PinnableBufferCacheEventSource.Log.IsEnabled())
			{
				PinnableBufferCacheEventSource.Log.FreeBufferNull(m_CacheName, m_FreeList.Count);
			}
			return;
		}
		if (m_gen1CountAtLastRestock + 3 > GC.CollectionCount(GC.MaxGeneration - 1))
		{
			lock (this)
			{
				if (GC.GetGeneration(buffer) < GC.MaxGeneration)
				{
					m_moreThanFreeListNeeded = true;
					PinnableBufferCacheEventSource.Log.FreeBufferStillTooYoung(m_CacheName, m_NotGen2.Count);
					m_NotGen2.Add(buffer);
					m_gen1CountAtLastRestock = GC.CollectionCount(GC.MaxGeneration - 1);
					return;
				}
			}
		}
		m_FreeList.Push(buffer);
	}

	[SecuritySafeCritical]
	private void Restock(out object returnBuffer)
	{
		lock (this)
		{
			if (!m_FreeList.TryPop(out returnBuffer))
			{
				if (m_restockSize == 0)
				{
					Gen2GcCallback.Register(Gen2GcCallbackFunc, this);
				}
				m_moreThanFreeListNeeded = true;
				PinnableBufferCacheEventSource.Log.AllocateBufferFreeListEmpty(m_CacheName, m_NotGen2.Count);
				if (m_NotGen2.Count == 0)
				{
					CreateNewBuffers();
				}
				int index = m_NotGen2.Count - 1;
				if (GC.GetGeneration(m_NotGen2[index]) < GC.MaxGeneration && GC.GetGeneration(m_NotGen2[0]) == GC.MaxGeneration)
				{
					index = 0;
				}
				returnBuffer = m_NotGen2[index];
				m_NotGen2.RemoveAt(index);
				if (PinnableBufferCacheEventSource.Log.IsEnabled() && GC.GetGeneration(returnBuffer) < GC.MaxGeneration)
				{
					PinnableBufferCacheEventSource.Log.AllocateBufferFromNotGen2(m_CacheName, m_NotGen2.Count);
				}
				if (!AgePendingBuffers() && m_NotGen2.Count == m_restockSize / 2)
				{
					PinnableBufferCacheEventSource.Log.DebugMessage("Proactively adding more buffers to aging pool");
					CreateNewBuffers();
				}
			}
		}
	}

	[SecuritySafeCritical]
	private bool AgePendingBuffers()
	{
		if (m_gen1CountAtLastRestock < GC.CollectionCount(GC.MaxGeneration - 1))
		{
			int num = 0;
			List<object> list = new List<object>();
			PinnableBufferCacheEventSource.Log.AllocateBufferAged(m_CacheName, m_NotGen2.Count);
			for (int i = 0; i < m_NotGen2.Count; i++)
			{
				object obj = m_NotGen2[i];
				if (GC.GetGeneration(obj) >= GC.MaxGeneration)
				{
					m_FreeList.Push(obj);
					num++;
				}
				else
				{
					list.Add(obj);
				}
			}
			PinnableBufferCacheEventSource.Log.AgePendingBuffersResults(m_CacheName, num, list.Count);
			m_NotGen2 = list;
			return true;
		}
		return false;
	}

	private void CreateNewBuffers()
	{
		if (m_restockSize == 0)
		{
			m_restockSize = 4;
		}
		else if (m_restockSize < 16)
		{
			m_restockSize = 16;
		}
		else if (m_restockSize < 256)
		{
			m_restockSize *= 2;
		}
		else if (m_restockSize < 4096)
		{
			m_restockSize = m_restockSize * 3 / 2;
		}
		else
		{
			m_restockSize = 4096;
		}
		if (m_minBufferCount > m_buffersUnderManagement)
		{
			m_restockSize = Math.Max(m_restockSize, m_minBufferCount - m_buffersUnderManagement);
		}
		PinnableBufferCacheEventSource.Log.AllocateBufferCreatingNewBuffers(m_CacheName, m_buffersUnderManagement, m_restockSize);
		for (int i = 0; i < m_restockSize; i++)
		{
			object item = m_factory();
			object obj = new object();
			m_NotGen2.Add(item);
		}
		m_buffersUnderManagement += m_restockSize;
		m_gen1CountAtLastRestock = GC.CollectionCount(GC.MaxGeneration - 1);
	}

	[SecuritySafeCritical]
	private static bool Gen2GcCallbackFunc(object targetObj)
	{
		return ((PinnableBufferCache)targetObj).TrimFreeListIfNeeded();
	}

	[SecuritySafeCritical]
	private bool TrimFreeListIfNeeded()
	{
		int tickCount = Environment.TickCount;
		int num = tickCount - m_msecNoUseBeyondFreeListSinceThisTime;
		PinnableBufferCacheEventSource.Log.TrimCheck(m_CacheName, m_buffersUnderManagement, m_moreThanFreeListNeeded, num);
		if (m_moreThanFreeListNeeded)
		{
			m_moreThanFreeListNeeded = false;
			m_trimmingExperimentInProgress = false;
			m_msecNoUseBeyondFreeListSinceThisTime = tickCount;
			return true;
		}
		if (0 <= num && num < 10000)
		{
			return true;
		}
		lock (this)
		{
			if (m_moreThanFreeListNeeded)
			{
				m_moreThanFreeListNeeded = false;
				m_trimmingExperimentInProgress = false;
				m_msecNoUseBeyondFreeListSinceThisTime = tickCount;
				return true;
			}
			int count = m_FreeList.Count;
			if (m_NotGen2.Count > 0)
			{
				if (!m_trimmingExperimentInProgress)
				{
					PinnableBufferCacheEventSource.Log.TrimFlush(m_CacheName, m_buffersUnderManagement, count, m_NotGen2.Count);
					AgePendingBuffers();
					m_trimmingExperimentInProgress = true;
					return true;
				}
				PinnableBufferCacheEventSource.Log.TrimFree(m_CacheName, m_buffersUnderManagement, count, m_NotGen2.Count);
				m_buffersUnderManagement -= m_NotGen2.Count;
				int num2 = m_buffersUnderManagement / 4;
				if (num2 < m_restockSize)
				{
					m_restockSize = Math.Max(num2, 16);
				}
				m_NotGen2.Clear();
				m_trimmingExperimentInProgress = false;
				return true;
			}
			int num3 = count / 4 + 1;
			if (count * 15 <= m_buffersUnderManagement || m_buffersUnderManagement - num3 <= m_minBufferCount)
			{
				PinnableBufferCacheEventSource.Log.TrimFreeSizeOK(m_CacheName, m_buffersUnderManagement, count);
				return true;
			}
			PinnableBufferCacheEventSource.Log.TrimExperiment(m_CacheName, m_buffersUnderManagement, count, num3);
			for (int i = 0; i < num3; i++)
			{
				if (m_FreeList.TryPop(out var result))
				{
					m_NotGen2.Add(result);
				}
			}
			m_msecNoUseBeyondFreeListSinceThisTime = tickCount;
			m_trimmingExperimentInProgress = true;
		}
		return true;
	}
}
