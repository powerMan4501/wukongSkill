using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32;

namespace System.Diagnostics.Tracing;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
internal class EventProvider : IDisposable
{
	public struct EventData
	{
		internal ulong Ptr;

		internal uint Size;

		internal uint Reserved;
	}

	public struct SessionInfo
	{
		internal int sessionIdBit;

		internal int etwSessionId;

		internal SessionInfo(int sessionIdBit_, int etwSessionId_)
		{
			sessionIdBit = sessionIdBit_;
			etwSessionId = etwSessionId_;
		}
	}

	public enum WriteEventErrorCode
	{
		NoError,
		NoFreeBuffers,
		EventTooBig,
		NullInput,
		TooManyArgs,
		Other
	}

	private static bool m_setInformationMissing;

	[SecurityCritical]
	private UnsafeNativeMethods.ManifestEtw.EtwEnableCallback m_etwCallback;

	private long m_regHandle;

	private byte m_level;

	private long m_anyKeywordMask;

	private long m_allKeywordMask;

	private List<SessionInfo> m_liveSessions;

	private bool m_enabled;

	private Guid m_providerId;

	internal bool m_disposed;

	[ThreadStatic]
	private static WriteEventErrorCode s_returnCode;

	private const int s_basicTypeAllocationBufferSize = 16;

	private const int s_etwMaxNumberArguments = 128;

	private const int s_etwAPIMaxRefObjCount = 8;

	private const int s_maxEventDataDescriptors = 128;

	private const int s_traceEventMaximumSize = 65482;

	private const int s_traceEventMaximumStringSize = 32724;

	private static int[] nibblebits = new int[16]
	{
		0, 1, 1, 2, 1, 2, 2, 3, 1, 2,
		2, 3, 2, 3, 3, 4
	};

	protected EventLevel Level
	{
		get
		{
			return (EventLevel)m_level;
		}
		set
		{
			m_level = (byte)value;
		}
	}

	protected EventKeywords MatchAnyKeyword
	{
		get
		{
			return (EventKeywords)m_anyKeywordMask;
		}
		set
		{
			m_anyKeywordMask = (long)value;
		}
	}

	protected EventKeywords MatchAllKeyword
	{
		get
		{
			return (EventKeywords)m_allKeywordMask;
		}
		set
		{
			m_allKeywordMask = (long)value;
		}
	}

	[SecurityCritical]
	[PermissionSet(SecurityAction.Demand, Unrestricted = true)]
	protected EventProvider(Guid providerGuid)
	{
		m_providerId = providerGuid;
		Register(providerGuid);
	}

	internal EventProvider()
	{
	}

	[SecurityCritical]
	internal unsafe void Register(Guid providerGuid)
	{
		m_providerId = providerGuid;
		m_etwCallback = EtwEnableCallBack;
		uint num = EventRegister(ref m_providerId, m_etwCallback);
		if (num != 0)
		{
			throw new ArgumentException(Win32Native.GetMessage((int)num));
		}
	}

	[SecurityCritical]
	internal unsafe int SetInformation(UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS eventInfoClass, void* data, int dataSize)
	{
		int result = 50;
		if (!m_setInformationMissing)
		{
			try
			{
				result = UnsafeNativeMethods.ManifestEtw.EventSetInformation(m_regHandle, eventInfoClass, data, dataSize);
			}
			catch (TypeLoadException)
			{
				m_setInformationMissing = true;
			}
		}
		return result;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[SecuritySafeCritical]
	protected virtual void Dispose(bool disposing)
	{
		if (m_disposed)
		{
			return;
		}
		m_enabled = false;
		long num = 0L;
		lock (EventListener.EventListenersLock)
		{
			if (m_disposed)
			{
				return;
			}
			num = m_regHandle;
			m_regHandle = 0L;
			m_disposed = true;
		}
		if (num != 0L)
		{
			EventUnregister(num);
		}
	}

	public virtual void Close()
	{
		Dispose();
	}

	~EventProvider()
	{
		Dispose(disposing: false);
	}

	[SecurityCritical]
	private unsafe void EtwEnableCallBack([In] ref Guid sourceId, [In] int controlCode, [In] byte setLevel, [In] long anyKeyword, [In] long allKeyword, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext)
	{
		try
		{
			ControllerCommand command = ControllerCommand.Update;
			IDictionary<string, string> dictionary = null;
			bool flag = false;
			switch (controlCode)
			{
			case 1:
			{
				m_enabled = true;
				m_level = setLevel;
				m_anyKeywordMask = anyKeyword;
				m_allKeywordMask = allKeyword;
				List<Tuple<SessionInfo, bool>> sessions = GetSessions();
				foreach (Tuple<SessionInfo, bool> item2 in sessions)
				{
					int sessionIdBit = item2.Item1.sessionIdBit;
					int etwSessionId = item2.Item1.etwSessionId;
					bool item = item2.Item2;
					flag = true;
					dictionary = null;
					if (sessions.Count > 1)
					{
						filterData = null;
					}
					if (item && GetDataFromController(etwSessionId, filterData, out command, out var data, out var dataStart))
					{
						dictionary = new Dictionary<string, string>(4);
						while (dataStart < data.Length)
						{
							int num = FindNull(data, dataStart);
							int num2 = num + 1;
							int num3 = FindNull(data, num2);
							if (num3 < data.Length)
							{
								string key = Encoding.UTF8.GetString(data, dataStart, num - dataStart);
								string value = Encoding.UTF8.GetString(data, num2, num3 - num2);
								dictionary[key] = value;
							}
							dataStart = num3 + 1;
						}
					}
					OnControllerCommand(command, dictionary, item ? sessionIdBit : (-sessionIdBit), etwSessionId);
				}
				break;
			}
			case 0:
				m_enabled = false;
				m_level = 0;
				m_anyKeywordMask = 0L;
				m_allKeywordMask = 0L;
				m_liveSessions = null;
				break;
			case 2:
				command = ControllerCommand.SendManifest;
				break;
			default:
				return;
			}
			if (!flag)
			{
				OnControllerCommand(command, dictionary, 0, 0);
			}
		}
		catch (Exception)
		{
		}
	}

	protected virtual void OnControllerCommand(ControllerCommand command, IDictionary<string, string> arguments, int sessionId, int etwSessionId)
	{
	}

	private static int FindNull(byte[] buffer, int idx)
	{
		while (idx < buffer.Length && buffer[idx] != 0)
		{
			idx++;
		}
		return idx;
	}

	[SecuritySafeCritical]
	private List<Tuple<SessionInfo, bool>> GetSessions()
	{
		List<SessionInfo> liveSessionList = null;
		GetSessionInfo(delegate(int etwSessionId, long matchAllKeywords)
		{
			GetSessionInfoCallback(etwSessionId, matchAllKeywords, ref liveSessionList);
		});
		List<Tuple<SessionInfo, bool>> list = new List<Tuple<SessionInfo, bool>>();
		if (m_liveSessions != null)
		{
			foreach (SessionInfo liveSession in m_liveSessions)
			{
				int index;
				if ((index = IndexOfSessionInList(liveSessionList, liveSession.etwSessionId)) < 0 || liveSessionList[index].sessionIdBit != liveSession.sessionIdBit)
				{
					list.Add(Tuple.Create(liveSession, item2: false));
				}
			}
		}
		if (liveSessionList != null)
		{
			foreach (SessionInfo item in liveSessionList)
			{
				int index2;
				if ((index2 = IndexOfSessionInList(m_liveSessions, item.etwSessionId)) < 0 || m_liveSessions[index2].sessionIdBit != item.sessionIdBit)
				{
					list.Add(Tuple.Create(item, item2: true));
				}
			}
		}
		m_liveSessions = liveSessionList;
		return list;
	}

	private static void GetSessionInfoCallback(int etwSessionId, long matchAllKeywords, ref List<SessionInfo> sessionList)
	{
		uint n = (uint)SessionMask.FromEventKeywords((ulong)matchAllKeywords);
		if (bitcount(n) <= 1)
		{
			if (sessionList == null)
			{
				sessionList = new List<SessionInfo>(8);
			}
			if (bitcount(n) == 1)
			{
				sessionList.Add(new SessionInfo(bitindex(n) + 1, etwSessionId));
			}
			else
			{
				sessionList.Add(new SessionInfo(bitcount((uint)SessionMask.All) + 1, etwSessionId));
			}
		}
	}

	[SecurityCritical]
	private unsafe void GetSessionInfo(Action<int, long> action)
	{
		int ReturnLength = 256;
		while (true)
		{
			byte* ptr = stackalloc byte[(int)(uint)ReturnLength];
			byte* ptr2 = ptr;
			int num = 0;
			fixed (Guid* providerId = &m_providerId)
			{
				num = UnsafeNativeMethods.ManifestEtw.EnumerateTraceGuidsEx(UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS.TraceGuidQueryInfo, providerId, sizeof(Guid), ptr2, ReturnLength, ref ReturnLength);
			}
			switch (num)
			{
			case 122:
				break;
			default:
				return;
			case 0:
			{
				UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO* ptr3 = (UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO*)ptr2;
				UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO* ptr4 = (UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO*)(ptr3 + 1);
				int currentProcessId = (int)Win32Native.GetCurrentProcessId();
				for (int i = 0; i < ptr3->InstanceCount; i++)
				{
					if (ptr4->Pid == currentProcessId)
					{
						UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO* ptr5 = (UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO*)(ptr4 + 1);
						for (int j = 0; j < ptr4->EnableCount; j++)
						{
							action(ptr5[j].LoggerId, ptr5[j].MatchAllKeyword);
						}
					}
					if (ptr4->NextOffset != 0)
					{
						byte* ptr6 = (byte*)ptr4;
						ptr4 = (UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO*)(ptr6 + ptr4->NextOffset);
						continue;
					}
					break;
				}
				return;
			}
			}
		}
	}

	private static int IndexOfSessionInList(List<SessionInfo> sessions, int etwSessionId)
	{
		if (sessions == null)
		{
			return -1;
		}
		for (int i = 0; i < sessions.Count; i++)
		{
			if (sessions[i].etwSessionId == etwSessionId)
			{
				return i;
			}
		}
		return -1;
	}

	[SecurityCritical]
	private unsafe bool GetDataFromController(int etwSessionId, UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, out ControllerCommand command, out byte[] data, out int dataStart)
	{
		data = null;
		dataStart = 0;
		if (filterData == null)
		{
			Guid providerId = m_providerId;
			string text = "\\Microsoft\\Windows\\CurrentVersion\\Winevt\\Publishers\\{" + providerId.ToString() + "}";
			text = ((Marshal.SizeOf(typeof(IntPtr)) != 8) ? ("HKEY_LOCAL_MACHINE\\Software" + text) : ("HKEY_LOCAL_MACHINE\\Software\\Wow6432Node" + text));
			string valueName = "ControllerData_Session_" + etwSessionId.ToString(CultureInfo.InvariantCulture);
			new RegistryPermission(RegistryPermissionAccess.Read, text).Assert();
			data = Registry.GetValue(text, valueName, null) as byte[];
			if (data != null)
			{
				command = ControllerCommand.Update;
				return true;
			}
			command = ControllerCommand.Update;
			return false;
		}
		if (filterData->Ptr != 0L && 0 < filterData->Size && filterData->Size <= 1024)
		{
			data = new byte[filterData->Size];
			Marshal.Copy((IntPtr)filterData->Ptr, data, 0, data.Length);
		}
		command = (ControllerCommand)filterData->Type;
		return true;
	}

	public bool IsEnabled()
	{
		return m_enabled;
	}

	public bool IsEnabled(byte level, long keywords)
	{
		if (!m_enabled)
		{
			return false;
		}
		if ((level <= m_level || m_level == 0) && (keywords == 0L || ((keywords & m_anyKeywordMask) != 0L && (keywords & m_allKeywordMask) == m_allKeywordMask)))
		{
			return true;
		}
		return false;
	}

	internal bool IsValid()
	{
		return m_regHandle != 0;
	}

	public static WriteEventErrorCode GetLastWriteEventError()
	{
		return s_returnCode;
	}

	private static void SetLastError(int error)
	{
		switch (error)
		{
		case 234:
		case 534:
			s_returnCode = WriteEventErrorCode.EventTooBig;
			break;
		case 8:
			s_returnCode = WriteEventErrorCode.NoFreeBuffers;
			break;
		}
	}

	[SecurityCritical]
	private unsafe static object EncodeObject(ref object data, ref EventData* dataDescriptor, ref byte* dataBuffer, ref uint totalEventSize)
	{
		string text;
		byte[] array;
		while (true)
		{
			dataDescriptor->Reserved = 0u;
			text = data as string;
			array = null;
			if (text != null)
			{
				dataDescriptor->Size = (uint)((text.Length + 1) * 2);
				break;
			}
			if ((array = data as byte[]) != null)
			{
				*(int*)dataBuffer = array.Length;
				dataDescriptor->Ptr = (ulong)dataBuffer;
				dataDescriptor->Size = 4u;
				totalEventSize += dataDescriptor->Size;
				dataDescriptor++;
				dataBuffer += 16;
				dataDescriptor->Size = (uint)array.Length;
				break;
			}
			if (data is IntPtr)
			{
				dataDescriptor->Size = (uint)sizeof(IntPtr);
				IntPtr* ptr = (IntPtr*)dataBuffer;
				*ptr = (IntPtr)data;
				dataDescriptor->Ptr = (ulong)ptr;
				break;
			}
			if (data is int)
			{
				dataDescriptor->Size = 4u;
				int* ptr2 = (int*)dataBuffer;
				*ptr2 = (int)data;
				dataDescriptor->Ptr = (ulong)ptr2;
				break;
			}
			if (data is long)
			{
				dataDescriptor->Size = 8u;
				long* ptr3 = (long*)dataBuffer;
				*ptr3 = (long)data;
				dataDescriptor->Ptr = (ulong)ptr3;
				break;
			}
			if (data is uint)
			{
				dataDescriptor->Size = 4u;
				uint* ptr4 = (uint*)dataBuffer;
				*ptr4 = (uint)data;
				dataDescriptor->Ptr = (ulong)ptr4;
				break;
			}
			if (data is ulong)
			{
				dataDescriptor->Size = 8u;
				ulong* ptr5 = (ulong*)dataBuffer;
				*ptr5 = (ulong)data;
				dataDescriptor->Ptr = (ulong)ptr5;
				break;
			}
			if (data is char)
			{
				dataDescriptor->Size = 2u;
				char* ptr6 = (char*)dataBuffer;
				*ptr6 = (char)data;
				dataDescriptor->Ptr = (ulong)ptr6;
				break;
			}
			if (data is byte)
			{
				dataDescriptor->Size = 1u;
				byte* ptr7 = dataBuffer;
				*ptr7 = (byte)data;
				dataDescriptor->Ptr = (ulong)ptr7;
				break;
			}
			if (data is short)
			{
				dataDescriptor->Size = 2u;
				short* ptr8 = (short*)dataBuffer;
				*ptr8 = (short)data;
				dataDescriptor->Ptr = (ulong)ptr8;
				break;
			}
			if (data is sbyte)
			{
				dataDescriptor->Size = 1u;
				sbyte* ptr9 = (sbyte*)dataBuffer;
				*ptr9 = (sbyte)data;
				dataDescriptor->Ptr = (ulong)ptr9;
				break;
			}
			if (data is ushort)
			{
				dataDescriptor->Size = 2u;
				ushort* ptr10 = (ushort*)dataBuffer;
				*ptr10 = (ushort)data;
				dataDescriptor->Ptr = (ulong)ptr10;
				break;
			}
			if (data is float)
			{
				dataDescriptor->Size = 4u;
				float* ptr11 = (float*)dataBuffer;
				*ptr11 = (float)data;
				dataDescriptor->Ptr = (ulong)ptr11;
				break;
			}
			if (data is double)
			{
				dataDescriptor->Size = 8u;
				double* ptr12 = (double*)dataBuffer;
				*ptr12 = (double)data;
				dataDescriptor->Ptr = (ulong)ptr12;
				break;
			}
			if (data is bool)
			{
				dataDescriptor->Size = 4u;
				int* ptr13 = (int*)dataBuffer;
				if ((bool)data)
				{
					*ptr13 = 1;
				}
				else
				{
					*ptr13 = 0;
				}
				dataDescriptor->Ptr = (ulong)ptr13;
				break;
			}
			if (data is Guid)
			{
				dataDescriptor->Size = (uint)sizeof(Guid);
				Guid* ptr14 = (Guid*)dataBuffer;
				*ptr14 = (Guid)data;
				dataDescriptor->Ptr = (ulong)ptr14;
				break;
			}
			if (data is decimal)
			{
				dataDescriptor->Size = 16u;
				decimal* ptr15 = (decimal*)dataBuffer;
				*ptr15 = (decimal)data;
				dataDescriptor->Ptr = (ulong)ptr15;
				break;
			}
			if (data is DateTime)
			{
				long num = 0L;
				if (((DateTime)data).Ticks > 504911232000000000L)
				{
					num = ((DateTime)data).ToFileTimeUtc();
				}
				dataDescriptor->Size = 8u;
				long* ptr16 = (long*)dataBuffer;
				*ptr16 = num;
				dataDescriptor->Ptr = (ulong)ptr16;
				break;
			}
			if (data is Enum)
			{
				Type underlyingType = Enum.GetUnderlyingType(data.GetType());
				if (underlyingType == typeof(int))
				{
					data = ((IConvertible)data).ToInt32(null);
					continue;
				}
				if (underlyingType == typeof(long))
				{
					data = ((IConvertible)data).ToInt64(null);
					continue;
				}
			}
			text = ((data != null) ? data.ToString() : "");
			dataDescriptor->Size = (uint)((text.Length + 1) * 2);
			break;
		}
		totalEventSize += dataDescriptor->Size;
		dataDescriptor++;
		dataBuffer += 16;
		return ((object)text) ?? ((object)array);
	}

	[SecurityCritical]
	internal unsafe bool WriteEvent(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* childActivityID, params object[] eventPayload)
	{
		int num = 0;
		if (IsEnabled(eventDescriptor.Level, eventDescriptor.Keywords))
		{
			int num2 = 0;
			num2 = eventPayload.Length;
			if (num2 > 128)
			{
				s_returnCode = WriteEventErrorCode.TooManyArgs;
				return false;
			}
			uint totalEventSize = 0u;
			int i = 0;
			List<int> list = new List<int>(8);
			List<object> list2 = new List<object>(8);
			EventData* ptr = stackalloc EventData[2 * num2];
			EventData* dataDescriptor = ptr;
			byte* ptr2 = stackalloc byte[(int)(uint)(32 * num2)];
			byte* dataBuffer = ptr2;
			bool flag = false;
			for (int j = 0; j < eventPayload.Length; j++)
			{
				if (eventPayload[j] != null)
				{
					object obj = EncodeObject(ref eventPayload[j], ref dataDescriptor, ref dataBuffer, ref totalEventSize);
					if (obj == null)
					{
						continue;
					}
					int num3 = (int)(dataDescriptor - ptr - 1);
					if (!(obj is string))
					{
						if (eventPayload.Length + num3 + 1 - j > 128)
						{
							s_returnCode = WriteEventErrorCode.TooManyArgs;
							return false;
						}
						flag = true;
					}
					list2.Add(obj);
					list.Add(num3);
					i++;
					continue;
				}
				s_returnCode = WriteEventErrorCode.NullInput;
				return false;
			}
			num2 = (int)(dataDescriptor - ptr);
			if (totalEventSize > 65482)
			{
				s_returnCode = WriteEventErrorCode.EventTooBig;
				return false;
			}
			if (!flag && i < 8)
			{
				for (; i < 8; i++)
				{
					list2.Add(null);
				}
				fixed (char* ptr3 = (string)list2[0])
				{
					fixed (char* ptr4 = (string)list2[1])
					{
						fixed (char* ptr5 = (string)list2[2])
						{
							fixed (char* ptr6 = (string)list2[3])
							{
								fixed (char* ptr7 = (string)list2[4])
								{
									fixed (char* ptr8 = (string)list2[5])
									{
										fixed (char* ptr9 = (string)list2[6])
										{
											fixed (char* ptr10 = (string)list2[7])
											{
												dataDescriptor = ptr;
												if (list2[0] != null)
												{
													dataDescriptor[list[0]].Ptr = (ulong)ptr3;
												}
												if (list2[1] != null)
												{
													dataDescriptor[list[1]].Ptr = (ulong)ptr4;
												}
												if (list2[2] != null)
												{
													dataDescriptor[list[2]].Ptr = (ulong)ptr5;
												}
												if (list2[3] != null)
												{
													dataDescriptor[list[3]].Ptr = (ulong)ptr6;
												}
												if (list2[4] != null)
												{
													dataDescriptor[list[4]].Ptr = (ulong)ptr7;
												}
												if (list2[5] != null)
												{
													dataDescriptor[list[5]].Ptr = (ulong)ptr8;
												}
												if (list2[6] != null)
												{
													dataDescriptor[list[6]].Ptr = (ulong)ptr9;
												}
												if (list2[7] != null)
												{
													dataDescriptor[list[7]].Ptr = (ulong)ptr10;
												}
												num = UnsafeNativeMethods.ManifestEtw.EventWriteTransferWrapper(m_regHandle, ref eventDescriptor, activityID, childActivityID, num2, ptr);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			else
			{
				dataDescriptor = ptr;
				GCHandle[] array = new GCHandle[i];
				for (int k = 0; k < i; k++)
				{
					array[k] = GCHandle.Alloc(list2[k], GCHandleType.Pinned);
					if (list2[k] is string)
					{
						fixed (char* ptr11 = (string)list2[k])
						{
							dataDescriptor[list[k]].Ptr = (ulong)ptr11;
						}
					}
					else
					{
						fixed (byte* ptr12 = (byte[])list2[k])
						{
							dataDescriptor[list[k]].Ptr = (ulong)ptr12;
						}
					}
				}
				num = UnsafeNativeMethods.ManifestEtw.EventWriteTransferWrapper(m_regHandle, ref eventDescriptor, activityID, childActivityID, num2, ptr);
				for (int l = 0; l < i; l++)
				{
					array[l].Free();
				}
			}
		}
		if (num != 0)
		{
			SetLastError(num);
			return false;
		}
		return true;
	}

	[SecurityCritical]
	protected internal unsafe bool WriteEvent(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* childActivityID, int dataCount, IntPtr data)
	{
		_ = 0u;
		int num = UnsafeNativeMethods.ManifestEtw.EventWriteTransferWrapper(m_regHandle, ref eventDescriptor, activityID, childActivityID, dataCount, (EventData*)(void*)data);
		if (num != 0)
		{
			SetLastError(num);
			return false;
		}
		return true;
	}

	[SecurityCritical]
	internal unsafe bool WriteEventRaw(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* relatedActivityID, int dataCount, IntPtr data)
	{
		int num = UnsafeNativeMethods.ManifestEtw.EventWriteTransferWrapper(m_regHandle, ref eventDescriptor, activityID, relatedActivityID, dataCount, (EventData*)(void*)data);
		if (num != 0)
		{
			SetLastError(num);
			return false;
		}
		return true;
	}

	[SecurityCritical]
	private unsafe uint EventRegister(ref Guid providerId, UnsafeNativeMethods.ManifestEtw.EtwEnableCallback enableCallback)
	{
		m_providerId = providerId;
		m_etwCallback = enableCallback;
		return UnsafeNativeMethods.ManifestEtw.EventRegister(ref providerId, enableCallback, null, ref m_regHandle);
	}

	[SecurityCritical]
	private uint EventUnregister(long registrationHandle)
	{
		return UnsafeNativeMethods.ManifestEtw.EventUnregister(registrationHandle);
	}

	private static int bitcount(uint n)
	{
		int num = 0;
		while (n != 0)
		{
			num += nibblebits[n & 0xF];
			n >>= 4;
		}
		return num;
	}

	private static int bitindex(uint n)
	{
		int i;
		for (i = 0; (n & (1 << i)) == 0L; i++)
		{
		}
		return i;
	}
}
