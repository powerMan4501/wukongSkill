using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Diagnostics.Tracing;

[FriendAccessAllowed]
[EventSource(Guid = "8E9F5090-2D75-4d03-8A81-E5AFBF85DAF1", Name = "System.Diagnostics.Eventing.FrameworkEventSource")]
internal sealed class FrameworkEventSource : EventSource
{
	public static class Keywords
	{
		public const EventKeywords Loader = (EventKeywords)1L;

		public const EventKeywords ThreadPool = (EventKeywords)2L;

		public const EventKeywords NetClient = (EventKeywords)4L;

		public const EventKeywords DynamicTypeUsage = (EventKeywords)8L;

		public const EventKeywords ThreadTransfer = (EventKeywords)16L;
	}

	[FriendAccessAllowed]
	public static class Tasks
	{
		public const EventTask GetResponse = (EventTask)1;

		public const EventTask GetRequestStream = (EventTask)2;

		public const EventTask ThreadTransfer = (EventTask)3;
	}

	[FriendAccessAllowed]
	public static class Opcodes
	{
		public const EventOpcode ReceiveHandled = (EventOpcode)11;
	}

	public static readonly FrameworkEventSource Log = new FrameworkEventSource();

	public static bool IsInitialized => Log != null;

	private FrameworkEventSource()
		: base(new Guid(2392805520u, 11637, 19715, 138, 129, 229, 175, 191, 133, 218, 241), "System.Diagnostics.Eventing.FrameworkEventSource")
	{
	}

	[NonEvent]
	[SecuritySafeCritical]
	private unsafe void WriteEvent(int eventId, long arg1, int arg2, string arg3, bool arg4)
	{
		if (IsEnabled())
		{
			if (arg3 == null)
			{
				arg3 = "";
			}
			fixed (char* ptr = arg3)
			{
				EventData* ptr2 = stackalloc EventData[4];
				ptr2->DataPointer = (IntPtr)(&arg1);
				ptr2->Size = 8;
				ptr2[1].DataPointer = (IntPtr)(&arg2);
				ptr2[1].Size = 4;
				ptr2[2].DataPointer = (IntPtr)ptr;
				ptr2[2].Size = (arg3.Length + 1) * 2;
				ptr2[3].DataPointer = (IntPtr)(&arg4);
				ptr2[3].Size = 4;
				WriteEventCore(eventId, 4, ptr2);
			}
		}
	}

	[NonEvent]
	[SecuritySafeCritical]
	private unsafe void WriteEvent(int eventId, long arg1, int arg2, string arg3)
	{
		if (IsEnabled())
		{
			if (arg3 == null)
			{
				arg3 = "";
			}
			fixed (char* ptr = arg3)
			{
				EventData* ptr2 = stackalloc EventData[3];
				ptr2->DataPointer = (IntPtr)(&arg1);
				ptr2->Size = 8;
				ptr2[1].DataPointer = (IntPtr)(&arg2);
				ptr2[1].Size = 4;
				ptr2[2].DataPointer = (IntPtr)ptr;
				ptr2[2].Size = (arg3.Length + 1) * 2;
				WriteEventCore(eventId, 3, ptr2);
			}
		}
	}

	[NonEvent]
	[SecuritySafeCritical]
	private unsafe void WriteEvent(int eventId, long arg1, string arg2, bool arg3, bool arg4)
	{
		if (IsEnabled())
		{
			if (arg2 == null)
			{
				arg2 = "";
			}
			fixed (char* ptr = arg2)
			{
				EventData* ptr2 = stackalloc EventData[4];
				ptr2->DataPointer = (IntPtr)(&arg1);
				ptr2->Size = 8;
				ptr2[1].DataPointer = (IntPtr)ptr;
				ptr2[1].Size = (arg2.Length + 1) * 2;
				ptr2[2].DataPointer = (IntPtr)(&arg3);
				ptr2[2].Size = 4;
				ptr2[3].DataPointer = (IntPtr)(&arg4);
				ptr2[3].Size = 4;
				WriteEventCore(eventId, 4, ptr2);
			}
		}
	}

	[NonEvent]
	[SecuritySafeCritical]
	private unsafe void WriteEvent(int eventId, long arg1, bool arg2, bool arg3)
	{
		if (IsEnabled())
		{
			EventData* ptr = stackalloc EventData[3];
			ptr->DataPointer = (IntPtr)(&arg1);
			ptr->Size = 8;
			ptr[1].DataPointer = (IntPtr)(&arg2);
			ptr[1].Size = 4;
			ptr[2].DataPointer = (IntPtr)(&arg3);
			ptr[2].Size = 4;
			WriteEventCore(eventId, 3, ptr);
		}
	}

	[NonEvent]
	[SecuritySafeCritical]
	private unsafe void WriteEvent(int eventId, long arg1, bool arg2, bool arg3, int arg4)
	{
		if (IsEnabled())
		{
			EventData* ptr = stackalloc EventData[4];
			ptr->DataPointer = (IntPtr)(&arg1);
			ptr->Size = 8;
			ptr[1].DataPointer = (IntPtr)(&arg2);
			ptr[1].Size = 4;
			ptr[2].DataPointer = (IntPtr)(&arg3);
			ptr[2].Size = 4;
			ptr[3].DataPointer = (IntPtr)(&arg4);
			ptr[3].Size = 4;
			WriteEventCore(eventId, 4, ptr);
		}
	}

	[Event(1, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
	public void ResourceManagerLookupStarted(string baseName, string mainAssemblyName, string cultureName)
	{
		WriteEvent(1, baseName, mainAssemblyName, cultureName);
	}

	[Event(2, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
	public void ResourceManagerLookingForResourceSet(string baseName, string mainAssemblyName, string cultureName)
	{
		if (IsEnabled())
		{
			WriteEvent(2, baseName, mainAssemblyName, cultureName);
		}
	}

	[Event(3, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
	public void ResourceManagerFoundResourceSetInCache(string baseName, string mainAssemblyName, string cultureName)
	{
		if (IsEnabled())
		{
			WriteEvent(3, baseName, mainAssemblyName, cultureName);
		}
	}

	[Event(4, Level = EventLevel.Warning, Keywords = (EventKeywords)1L)]
	public void ResourceManagerFoundResourceSetInCacheUnexpected(string baseName, string mainAssemblyName, string cultureName)
	{
		if (IsEnabled())
		{
			WriteEvent(4, baseName, mainAssemblyName, cultureName);
		}
	}

	[Event(5, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
	public void ResourceManagerStreamFound(string baseName, string mainAssemblyName, string cultureName, string loadedAssemblyName, string resourceFileName)
	{
		if (IsEnabled())
		{
			WriteEvent(5, baseName, mainAssemblyName, cultureName, loadedAssemblyName, resourceFileName);
		}
	}

	[Event(6, Level = EventLevel.Warning, Keywords = (EventKeywords)1L)]
	public void ResourceManagerStreamNotFound(string baseName, string mainAssemblyName, string cultureName, string loadedAssemblyName, string resourceFileName)
	{
		if (IsEnabled())
		{
			WriteEvent(6, baseName, mainAssemblyName, cultureName, loadedAssemblyName, resourceFileName);
		}
	}

	[Event(7, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
	public void ResourceManagerGetSatelliteAssemblySucceeded(string baseName, string mainAssemblyName, string cultureName, string assemblyName)
	{
		if (IsEnabled())
		{
			WriteEvent(7, baseName, mainAssemblyName, cultureName, assemblyName);
		}
	}

	[Event(8, Level = EventLevel.Warning, Keywords = (EventKeywords)1L)]
	public void ResourceManagerGetSatelliteAssemblyFailed(string baseName, string mainAssemblyName, string cultureName, string assemblyName)
	{
		if (IsEnabled())
		{
			WriteEvent(8, baseName, mainAssemblyName, cultureName, assemblyName);
		}
	}

	[Event(9, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
	public void ResourceManagerCaseInsensitiveResourceStreamLookupSucceeded(string baseName, string mainAssemblyName, string assemblyName, string resourceFileName)
	{
		if (IsEnabled())
		{
			WriteEvent(9, baseName, mainAssemblyName, assemblyName, resourceFileName);
		}
	}

	[Event(10, Level = EventLevel.Warning, Keywords = (EventKeywords)1L)]
	public void ResourceManagerCaseInsensitiveResourceStreamLookupFailed(string baseName, string mainAssemblyName, string assemblyName, string resourceFileName)
	{
		if (IsEnabled())
		{
			WriteEvent(10, baseName, mainAssemblyName, assemblyName, resourceFileName);
		}
	}

	[Event(11, Level = EventLevel.Error, Keywords = (EventKeywords)1L)]
	public void ResourceManagerManifestResourceAccessDenied(string baseName, string mainAssemblyName, string assemblyName, string canonicalName)
	{
		if (IsEnabled())
		{
			WriteEvent(11, baseName, mainAssemblyName, assemblyName, canonicalName);
		}
	}

	[Event(12, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
	public void ResourceManagerNeutralResourcesSufficient(string baseName, string mainAssemblyName, string cultureName)
	{
		if (IsEnabled())
		{
			WriteEvent(12, baseName, mainAssemblyName, cultureName);
		}
	}

	[Event(13, Level = EventLevel.Warning, Keywords = (EventKeywords)1L)]
	public void ResourceManagerNeutralResourceAttributeMissing(string mainAssemblyName)
	{
		if (IsEnabled())
		{
			WriteEvent(13, mainAssemblyName);
		}
	}

	[Event(14, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
	public void ResourceManagerCreatingResourceSet(string baseName, string mainAssemblyName, string cultureName, string fileName)
	{
		if (IsEnabled())
		{
			WriteEvent(14, baseName, mainAssemblyName, cultureName, fileName);
		}
	}

	[Event(15, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
	public void ResourceManagerNotCreatingResourceSet(string baseName, string mainAssemblyName, string cultureName)
	{
		if (IsEnabled())
		{
			WriteEvent(15, baseName, mainAssemblyName, cultureName);
		}
	}

	[Event(16, Level = EventLevel.Warning, Keywords = (EventKeywords)1L)]
	public void ResourceManagerLookupFailed(string baseName, string mainAssemblyName, string cultureName)
	{
		if (IsEnabled())
		{
			WriteEvent(16, baseName, mainAssemblyName, cultureName);
		}
	}

	[Event(17, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
	public void ResourceManagerReleasingResources(string baseName, string mainAssemblyName)
	{
		if (IsEnabled())
		{
			WriteEvent(17, baseName, mainAssemblyName);
		}
	}

	[Event(18, Level = EventLevel.Warning, Keywords = (EventKeywords)1L)]
	public void ResourceManagerNeutralResourcesNotFound(string baseName, string mainAssemblyName, string resName)
	{
		if (IsEnabled())
		{
			WriteEvent(18, baseName, mainAssemblyName, resName);
		}
	}

	[Event(19, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
	public void ResourceManagerNeutralResourcesFound(string baseName, string mainAssemblyName, string resName)
	{
		if (IsEnabled())
		{
			WriteEvent(19, baseName, mainAssemblyName, resName);
		}
	}

	[Event(20, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
	public void ResourceManagerAddingCultureFromConfigFile(string baseName, string mainAssemblyName, string cultureName)
	{
		if (IsEnabled())
		{
			WriteEvent(20, baseName, mainAssemblyName, cultureName);
		}
	}

	[Event(21, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
	public void ResourceManagerCultureNotFoundInConfigFile(string baseName, string mainAssemblyName, string cultureName)
	{
		if (IsEnabled())
		{
			WriteEvent(21, baseName, mainAssemblyName, cultureName);
		}
	}

	[Event(22, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
	public void ResourceManagerCultureFoundInConfigFile(string baseName, string mainAssemblyName, string cultureName)
	{
		if (IsEnabled())
		{
			WriteEvent(22, baseName, mainAssemblyName, cultureName);
		}
	}

	[NonEvent]
	public void ResourceManagerLookupStarted(string baseName, Assembly mainAssembly, string cultureName)
	{
		if (IsEnabled())
		{
			ResourceManagerLookupStarted(baseName, GetName(mainAssembly), cultureName);
		}
	}

	[NonEvent]
	public void ResourceManagerLookingForResourceSet(string baseName, Assembly mainAssembly, string cultureName)
	{
		if (IsEnabled())
		{
			ResourceManagerLookingForResourceSet(baseName, GetName(mainAssembly), cultureName);
		}
	}

	[NonEvent]
	public void ResourceManagerFoundResourceSetInCache(string baseName, Assembly mainAssembly, string cultureName)
	{
		if (IsEnabled())
		{
			ResourceManagerFoundResourceSetInCache(baseName, GetName(mainAssembly), cultureName);
		}
	}

	[NonEvent]
	public void ResourceManagerFoundResourceSetInCacheUnexpected(string baseName, Assembly mainAssembly, string cultureName)
	{
		if (IsEnabled())
		{
			ResourceManagerFoundResourceSetInCacheUnexpected(baseName, GetName(mainAssembly), cultureName);
		}
	}

	[NonEvent]
	public void ResourceManagerStreamFound(string baseName, Assembly mainAssembly, string cultureName, Assembly loadedAssembly, string resourceFileName)
	{
		if (IsEnabled())
		{
			ResourceManagerStreamFound(baseName, GetName(mainAssembly), cultureName, GetName(loadedAssembly), resourceFileName);
		}
	}

	[NonEvent]
	public void ResourceManagerStreamNotFound(string baseName, Assembly mainAssembly, string cultureName, Assembly loadedAssembly, string resourceFileName)
	{
		if (IsEnabled())
		{
			ResourceManagerStreamNotFound(baseName, GetName(mainAssembly), cultureName, GetName(loadedAssembly), resourceFileName);
		}
	}

	[NonEvent]
	public void ResourceManagerGetSatelliteAssemblySucceeded(string baseName, Assembly mainAssembly, string cultureName, string assemblyName)
	{
		if (IsEnabled())
		{
			ResourceManagerGetSatelliteAssemblySucceeded(baseName, GetName(mainAssembly), cultureName, assemblyName);
		}
	}

	[NonEvent]
	public void ResourceManagerGetSatelliteAssemblyFailed(string baseName, Assembly mainAssembly, string cultureName, string assemblyName)
	{
		if (IsEnabled())
		{
			ResourceManagerGetSatelliteAssemblyFailed(baseName, GetName(mainAssembly), cultureName, assemblyName);
		}
	}

	[NonEvent]
	public void ResourceManagerCaseInsensitiveResourceStreamLookupSucceeded(string baseName, Assembly mainAssembly, string assemblyName, string resourceFileName)
	{
		if (IsEnabled())
		{
			ResourceManagerCaseInsensitiveResourceStreamLookupSucceeded(baseName, GetName(mainAssembly), assemblyName, resourceFileName);
		}
	}

	[NonEvent]
	public void ResourceManagerCaseInsensitiveResourceStreamLookupFailed(string baseName, Assembly mainAssembly, string assemblyName, string resourceFileName)
	{
		if (IsEnabled())
		{
			ResourceManagerCaseInsensitiveResourceStreamLookupFailed(baseName, GetName(mainAssembly), assemblyName, resourceFileName);
		}
	}

	[NonEvent]
	public void ResourceManagerManifestResourceAccessDenied(string baseName, Assembly mainAssembly, string assemblyName, string canonicalName)
	{
		if (IsEnabled())
		{
			ResourceManagerManifestResourceAccessDenied(baseName, GetName(mainAssembly), assemblyName, canonicalName);
		}
	}

	[NonEvent]
	public void ResourceManagerNeutralResourcesSufficient(string baseName, Assembly mainAssembly, string cultureName)
	{
		if (IsEnabled())
		{
			ResourceManagerNeutralResourcesSufficient(baseName, GetName(mainAssembly), cultureName);
		}
	}

	[NonEvent]
	public void ResourceManagerNeutralResourceAttributeMissing(Assembly mainAssembly)
	{
		if (IsEnabled())
		{
			ResourceManagerNeutralResourceAttributeMissing(GetName(mainAssembly));
		}
	}

	[NonEvent]
	public void ResourceManagerCreatingResourceSet(string baseName, Assembly mainAssembly, string cultureName, string fileName)
	{
		if (IsEnabled())
		{
			ResourceManagerCreatingResourceSet(baseName, GetName(mainAssembly), cultureName, fileName);
		}
	}

	[NonEvent]
	public void ResourceManagerNotCreatingResourceSet(string baseName, Assembly mainAssembly, string cultureName)
	{
		if (IsEnabled())
		{
			ResourceManagerNotCreatingResourceSet(baseName, GetName(mainAssembly), cultureName);
		}
	}

	[NonEvent]
	public void ResourceManagerLookupFailed(string baseName, Assembly mainAssembly, string cultureName)
	{
		if (IsEnabled())
		{
			ResourceManagerLookupFailed(baseName, GetName(mainAssembly), cultureName);
		}
	}

	[NonEvent]
	public void ResourceManagerReleasingResources(string baseName, Assembly mainAssembly)
	{
		if (IsEnabled())
		{
			ResourceManagerReleasingResources(baseName, GetName(mainAssembly));
		}
	}

	[NonEvent]
	public void ResourceManagerNeutralResourcesNotFound(string baseName, Assembly mainAssembly, string resName)
	{
		if (IsEnabled())
		{
			ResourceManagerNeutralResourcesNotFound(baseName, GetName(mainAssembly), resName);
		}
	}

	[NonEvent]
	public void ResourceManagerNeutralResourcesFound(string baseName, Assembly mainAssembly, string resName)
	{
		if (IsEnabled())
		{
			ResourceManagerNeutralResourcesFound(baseName, GetName(mainAssembly), resName);
		}
	}

	[NonEvent]
	public void ResourceManagerAddingCultureFromConfigFile(string baseName, Assembly mainAssembly, string cultureName)
	{
		if (IsEnabled())
		{
			ResourceManagerAddingCultureFromConfigFile(baseName, GetName(mainAssembly), cultureName);
		}
	}

	[NonEvent]
	public void ResourceManagerCultureNotFoundInConfigFile(string baseName, Assembly mainAssembly, string cultureName)
	{
		if (IsEnabled())
		{
			ResourceManagerCultureNotFoundInConfigFile(baseName, GetName(mainAssembly), cultureName);
		}
	}

	[NonEvent]
	public void ResourceManagerCultureFoundInConfigFile(string baseName, Assembly mainAssembly, string cultureName)
	{
		if (IsEnabled())
		{
			ResourceManagerCultureFoundInConfigFile(baseName, GetName(mainAssembly), cultureName);
		}
	}

	private static string GetName(Assembly assembly)
	{
		if (assembly == null)
		{
			return "<<NULL>>";
		}
		return assembly.FullName;
	}

	[Event(30, Level = EventLevel.Verbose, Keywords = (EventKeywords)18L)]
	public void ThreadPoolEnqueueWork(long workID)
	{
		WriteEvent(30, workID);
	}

	[NonEvent]
	[SecuritySafeCritical]
	public unsafe void ThreadPoolEnqueueWorkObject(object workID)
	{
		ThreadPoolEnqueueWork((long)(nuint)(*(nint*)(void*)JitHelpers.UnsafeCastToStackPointer(ref workID)));
	}

	[Event(31, Level = EventLevel.Verbose, Keywords = (EventKeywords)18L)]
	public void ThreadPoolDequeueWork(long workID)
	{
		WriteEvent(31, workID);
	}

	[NonEvent]
	[SecuritySafeCritical]
	public unsafe void ThreadPoolDequeueWorkObject(object workID)
	{
		ThreadPoolDequeueWork((long)(nuint)(*(nint*)(void*)JitHelpers.UnsafeCastToStackPointer(ref workID)));
	}

	[Event(140, Level = EventLevel.Informational, Keywords = (EventKeywords)4L, ActivityOptions = EventActivityOptions.Disable, Task = (EventTask)1, Opcode = EventOpcode.Start, Version = 1)]
	private void GetResponseStart(long id, string uri, bool success, bool synchronous)
	{
		WriteEvent(140, id, uri, success, synchronous);
	}

	[Event(141, Level = EventLevel.Informational, Keywords = (EventKeywords)4L, ActivityOptions = EventActivityOptions.Disable, Task = (EventTask)1, Opcode = EventOpcode.Stop, Version = 1)]
	private void GetResponseStop(long id, bool success, bool synchronous, int statusCode)
	{
		WriteEvent(141, id, success, synchronous, statusCode);
	}

	[Event(142, Level = EventLevel.Informational, Keywords = (EventKeywords)4L, ActivityOptions = EventActivityOptions.Disable, Task = (EventTask)2, Opcode = EventOpcode.Start, Version = 1)]
	private void GetRequestStreamStart(long id, string uri, bool success, bool synchronous)
	{
		WriteEvent(142, id, uri, success, synchronous);
	}

	[Event(143, Level = EventLevel.Informational, Keywords = (EventKeywords)4L, ActivityOptions = EventActivityOptions.Disable, Task = (EventTask)2, Opcode = EventOpcode.Stop, Version = 1)]
	private void GetRequestStreamStop(long id, bool success, bool synchronous)
	{
		WriteEvent(143, id, success, synchronous);
	}

	[NonEvent]
	[SecuritySafeCritical]
	public void BeginGetResponse(object id, string uri, bool success, bool synchronous)
	{
		if (IsEnabled())
		{
			GetResponseStart(IdForObject(id), uri, success, synchronous);
		}
	}

	[NonEvent]
	[SecuritySafeCritical]
	public void EndGetResponse(object id, bool success, bool synchronous, int statusCode)
	{
		if (IsEnabled())
		{
			GetResponseStop(IdForObject(id), success, synchronous, statusCode);
		}
	}

	[NonEvent]
	[SecuritySafeCritical]
	public void BeginGetRequestStream(object id, string uri, bool success, bool synchronous)
	{
		if (IsEnabled())
		{
			GetRequestStreamStart(IdForObject(id), uri, success, synchronous);
		}
	}

	[NonEvent]
	[SecuritySafeCritical]
	public void EndGetRequestStream(object id, bool success, bool synchronous)
	{
		if (IsEnabled())
		{
			GetRequestStreamStop(IdForObject(id), success, synchronous);
		}
	}

	[Event(150, Level = EventLevel.Informational, Keywords = (EventKeywords)16L, Task = (EventTask)3, Opcode = EventOpcode.Send)]
	public void ThreadTransferSend(long id, int kind, string info, bool multiDequeues)
	{
		if (IsEnabled())
		{
			WriteEvent(150, id, kind, info, multiDequeues);
		}
	}

	[NonEvent]
	[SecuritySafeCritical]
	public unsafe void ThreadTransferSendObj(object id, int kind, string info, bool multiDequeues)
	{
		ThreadTransferSend((long)(nuint)(*(nint*)(void*)JitHelpers.UnsafeCastToStackPointer(ref id)), kind, info, multiDequeues);
	}

	[Event(151, Level = EventLevel.Informational, Keywords = (EventKeywords)16L, Task = (EventTask)3, Opcode = EventOpcode.Receive)]
	public void ThreadTransferReceive(long id, int kind, string info)
	{
		if (IsEnabled())
		{
			WriteEvent(151, id, kind, info);
		}
	}

	[NonEvent]
	[SecuritySafeCritical]
	public unsafe void ThreadTransferReceiveObj(object id, int kind, string info)
	{
		ThreadTransferReceive((long)(nuint)(*(nint*)(void*)JitHelpers.UnsafeCastToStackPointer(ref id)), kind, info);
	}

	[Event(152, Level = EventLevel.Informational, Keywords = (EventKeywords)16L, Task = (EventTask)3, Opcode = (EventOpcode)11)]
	public void ThreadTransferReceiveHandled(long id, int kind, string info)
	{
		if (IsEnabled())
		{
			WriteEvent(152, id, kind, info);
		}
	}

	[NonEvent]
	[SecuritySafeCritical]
	public unsafe void ThreadTransferReceiveHandledObj(object id, int kind, string info)
	{
		ThreadTransferReceive((long)(nuint)(*(nint*)(void*)JitHelpers.UnsafeCastToStackPointer(ref id)), kind, info);
	}

	private static long IdForObject(object obj)
	{
		return obj.GetHashCode() + 9223372032559808512L;
	}
}
