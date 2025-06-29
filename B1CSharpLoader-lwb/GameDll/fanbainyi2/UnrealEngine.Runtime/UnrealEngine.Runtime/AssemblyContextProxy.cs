using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace UnrealEngine.Runtime;

internal static class AssemblyContextProxy
{
	private delegate bool IsFullyUnloadedDel(KeyValuePair<long, long> contextRef);

	private delegate int GetContextStateDel(KeyValuePair<long, long> contextRef);

	private delegate void UnloadDel(KeyValuePair<long, long> contextRef);

	private delegate Assembly[] GetAssembliesDel(KeyValuePair<long, long> contextRef);

	private delegate Assembly LoadFromDel(KeyValuePair<long, long> contextRef, string assemblyPath);

	private delegate Assembly LoadFromStreamDel(KeyValuePair<long, long> contextRef, Stream assembly, Stream assemblySymbols);

	private delegate KeyValuePair<long, long> GetContextRefDel(Assembly assembly);

	private delegate KeyValuePair<long, long> CreateDel(KeyValuePair<long, long> currentContextRef);

	private delegate void AddUnloadingEventDel(KeyValuePair<long, long> contextRef, Action<KeyValuePair<long, long>> callback);

	private delegate void RemoveUnloadingEventDel(KeyValuePair<long, long> contextRef, Action<KeyValuePair<long, long>> callback);

	private delegate void AddResolvingEventDel(KeyValuePair<long, long> contextRef, Func<KeyValuePair<long, long>, AssemblyName, Assembly> callback);

	private delegate void RemoveResolvingEventDel(KeyValuePair<long, long> contextRef, Func<KeyValuePair<long, long>, AssemblyName, Assembly> callback);

	private static bool initialized;

	private static IsFullyUnloadedDel internalIsFullyUnloaded;

	private static GetContextStateDel internalGetContextState;

	private static UnloadDel internalUnload;

	private static GetAssembliesDel internalGetAssemblies;

	private static LoadFromDel internalLoadFrom;

	private static LoadFromStreamDel internalLoadFromStream;

	private static GetContextRefDel internalGetContextRef;

	private static CreateDel internalCreate;

	private static AddUnloadingEventDel internalAddUnloadingEvent;

	private static RemoveUnloadingEventDel internalRemoveUnloadingEvent;

	private static AddResolvingEventDel internalAddResolvingEvent;

	private static RemoveResolvingEventDel internalRemoveResolvingEvent;

	public static void Initialize(bool isContextMaintainer)
	{
		if (AssemblyContext.IsCoreCLR)
		{
			if (isContextMaintainer)
			{
				object[] data = new object[12]
				{
					internalIsFullyUnloaded = InternalIsFullyUnloaded,
					internalGetContextState = InternalGetContextState,
					internalUnload = InternalUnload,
					internalGetAssemblies = InternalGetAssemblies,
					internalLoadFrom = InternalLoadFrom,
					internalLoadFromStream = InternalLoadFromStream,
					internalGetContextRef = InternalGetContextRef,
					internalCreate = InternalCreate,
					internalAddUnloadingEvent = InternalAddUnloadingEvent,
					internalRemoveUnloadingEvent = InternalRemoveUnloadingEvent,
					internalAddResolvingEvent = InternalAddResolvingEvent,
					internalRemoveResolvingEvent = InternalRemoveResolvingEvent
				};
				AppDomain.CurrentDomain.SetData("AssemblyContextProxyCoreCLR", data);
				initialized = true;
			}
			else if (AppDomain.CurrentDomain.GetData("AssemblyContextProxyCoreCLR") is object[] array)
			{
				internalIsFullyUnloaded = (IsFullyUnloadedDel)Delegate.CreateDelegate(typeof(IsFullyUnloadedDel), (array[0] as Delegate).Method);
				internalGetContextState = (GetContextStateDel)Delegate.CreateDelegate(typeof(GetContextStateDel), (array[1] as Delegate).Method);
				internalUnload = (UnloadDel)Delegate.CreateDelegate(typeof(UnloadDel), (array[2] as Delegate).Method);
				internalGetAssemblies = (GetAssembliesDel)Delegate.CreateDelegate(typeof(GetAssembliesDel), (array[3] as Delegate).Method);
				internalLoadFrom = (LoadFromDel)Delegate.CreateDelegate(typeof(LoadFromDel), (array[4] as Delegate).Method);
				internalLoadFromStream = (LoadFromStreamDel)Delegate.CreateDelegate(typeof(LoadFromStreamDel), (array[5] as Delegate).Method);
				internalGetContextRef = (GetContextRefDel)Delegate.CreateDelegate(typeof(GetContextRefDel), (array[6] as Delegate).Method);
				internalCreate = (CreateDel)Delegate.CreateDelegate(typeof(CreateDel), (array[7] as Delegate).Method);
				internalAddUnloadingEvent = (AddUnloadingEventDel)Delegate.CreateDelegate(typeof(AddUnloadingEventDel), (array[8] as Delegate).Method);
				internalRemoveUnloadingEvent = (RemoveUnloadingEventDel)Delegate.CreateDelegate(typeof(RemoveUnloadingEventDel), (array[9] as Delegate).Method);
				internalAddResolvingEvent = (AddResolvingEventDel)Delegate.CreateDelegate(typeof(AddResolvingEventDel), (array[10] as Delegate).Method);
				internalRemoveResolvingEvent = (RemoveResolvingEventDel)Delegate.CreateDelegate(typeof(RemoveResolvingEventDel), (array[11] as Delegate).Method);
				initialized = true;
			}
		}
	}

	public static bool IsFullyUnloaded(AssemblyContextRef contextRef)
	{
		return internalIsFullyUnloaded(contextRef);
	}

	public static int GetContextState(AssemblyContextRef contextRef)
	{
		return internalGetContextState(contextRef);
	}

	public static void Unload(AssemblyContextRef contextRef)
	{
		internalUnload(contextRef);
	}

	public static Assembly[] GetAssemblies(AssemblyContextRef contextRef)
	{
		return internalGetAssemblies(contextRef);
	}

	public static Assembly LoadFrom(AssemblyContextRef contextRef, string assemblyPath)
	{
		return internalLoadFrom(contextRef, assemblyPath);
	}

	public static Assembly LoadFromStream(AssemblyContextRef contextRef, Stream assembly, Stream assemblySymbols)
	{
		return internalLoadFromStream(contextRef, assembly, assemblySymbols);
	}

	public static AssemblyContextRef GetContextRef(Assembly assembly)
	{
		if (AssemblyContext.IsCoreCLR && initialized)
		{
			return internalGetContextRef(assembly);
		}
		object data = AppDomain.CurrentDomain.GetData("CurrentAppDomainContextRef");
		if (data != null)
		{
			return AssemblyContextRef.Parse(data as string);
		}
		return AssemblyContextRef.Invalid;
	}

	public static AssemblyContextRef Create(AssemblyContextRef currentContext)
	{
		return internalCreate(currentContext);
	}

	public static void AddUnloadingEvent(KeyValuePair<long, long> contextRef, Action<KeyValuePair<long, long>> callback)
	{
		internalAddUnloadingEvent(contextRef, callback);
	}

	public static void RemoveUnloadingEvent(KeyValuePair<long, long> contextRef, Action<KeyValuePair<long, long>> callback)
	{
		internalRemoveUnloadingEvent(contextRef, callback);
	}

	public static void AddUnloadingResolving(KeyValuePair<long, long> contextRef, Func<KeyValuePair<long, long>, AssemblyName, Assembly> callback)
	{
		internalAddResolvingEvent(contextRef, callback);
	}

	public static void RemoveUnloadingResolving(KeyValuePair<long, long> contextRef, Func<KeyValuePair<long, long>, AssemblyName, Assembly> callback)
	{
		internalRemoveResolvingEvent(contextRef, callback);
	}

	private static bool InternalIsFullyUnloaded(KeyValuePair<long, long> contextRef)
	{
		return InternalGetContext(contextRef).IsFullyUnloaded;
	}

	private static int InternalGetContextState(KeyValuePair<long, long> contextRef)
	{
		return (int)InternalGetContext(contextRef).State;
	}

	private static void InternalUnload(KeyValuePair<long, long> contextRef)
	{
		InternalGetContext(contextRef).Unload();
	}

	private static Assembly[] InternalGetAssemblies(KeyValuePair<long, long> contextRef)
	{
		return InternalGetContext(contextRef).GetAssemblies();
	}

	private static Assembly InternalLoadFrom(KeyValuePair<long, long> contextRef, string assemblyPath)
	{
		return InternalGetContext(contextRef).LoadFrom(assemblyPath);
	}

	private static Assembly InternalLoadFromStream(KeyValuePair<long, long> contextRef, Stream assembly, Stream assemblySymbols)
	{
		return InternalGetContext(contextRef).LoadFromStream(assembly, assemblySymbols);
	}

	private static KeyValuePair<long, long> InternalGetContextRef(Assembly assembly)
	{
		return AssemblyContext.GetContextRef(assembly);
	}

	private static KeyValuePair<long, long> InternalCreate(KeyValuePair<long, long> currentContextRef)
	{
		return AssemblyContext.Create(currentContextRef);
	}

	private static void InternalAddUnloadingEvent(KeyValuePair<long, long> contextRef, Action<KeyValuePair<long, long>> callback)
	{
		InternalGetContext(contextRef).Unloading += callback;
	}

	private static void InternalRemoveUnloadingEvent(KeyValuePair<long, long> contextRef, Action<KeyValuePair<long, long>> callback)
	{
		InternalGetContext(contextRef).Unloading -= callback;
	}

	private static void InternalAddResolvingEvent(KeyValuePair<long, long> contextRef, Func<KeyValuePair<long, long>, AssemblyName, Assembly> callback)
	{
		InternalGetContext(contextRef).Resolving += callback;
	}

	private static void InternalRemoveResolvingEvent(KeyValuePair<long, long> contextRef, Func<KeyValuePair<long, long>, AssemblyName, Assembly> callback)
	{
		InternalGetContext(contextRef).Resolving -= callback;
	}

	private static AssemblyContext InternalGetContext(AssemblyContextRef contextRef)
	{
		return AssemblyContext.InternalGetContext(contextRef);
	}
}
