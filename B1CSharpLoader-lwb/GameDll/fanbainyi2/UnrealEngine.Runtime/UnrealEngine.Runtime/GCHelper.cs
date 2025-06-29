using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using AOT;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class GCHelper
{
	public delegate void Del_VoidUObj(UObject Obj);

	private class GCHelperHotReloadData : HotReload.DataItem
	{
		public List<FWeakObjectPtr> Objects = new List<FWeakObjectPtr>();

		public override void Load()
		{
			int num = ReadInt32();
			for (int i = 0; i < num; i++)
			{
				Objects.Add(new FWeakObjectPtr
				{
					ObjectIndex = ReadInt32(),
					ObjectSerialNumber = ReadInt32()
				});
			}
		}

		public override void Save()
		{
			WriteInt32(Objects.Count);
			foreach (FWeakObjectPtr @object in Objects)
			{
				WriteInt32(@object.ObjectIndex);
				WriteInt32(@object.ObjectSerialNumber);
			}
		}
	}

	private class UObjectRefPool
	{
		private Stack<UObjectRef> pool = new Stack<UObjectRef>();

		public UObjectRef New(IntPtr native, Type type, bool isKnownType, int internalIndex)
		{
			UObjectRef uObjectRef = null;
			if (pool.Count > 0)
			{
				uObjectRef = pool.Pop();
			}
			if (uObjectRef == null)
			{
				uObjectRef = new UObjectRef();
			}
			uObjectRef.Initialize(native, type, isKnownType, internalIndex);
			return uObjectRef;
		}

		public void ReturnObject(UObjectRef obj)
		{
			obj.Reset();
			pool.Push(obj);
		}
	}

	private static Dictionary<long, UObjectRef> References = new Dictionary<long, UObjectRef>();

	private static int objectInternalIndexOffset;

	internal static IntPtr ManagedObjectBeingInitialized;

	private static UObjectRefPool objRefPool = new UObjectRefPool();

	private static object ThreadLocker = new object();

	public static Del_VoidUObj OnAddListener;

	public static Del_VoidUObj OnRemoveListener;

	private static Native_GCHelper.Del_Add onAdd;

	private static Native_GCHelper.Del_Remove onRemove;

	private static Native_GCHelper.Del_Void_Void OnPostGarbageCollectDele = OnPostGarbageCollect;

	public static EObjectFlags GarbageCollectionKeepFlags
	{
		get
		{
			if (!FGlobals.IsEditor)
			{
				return EObjectFlags.NoFlags;
			}
			return EObjectFlags.Standalone;
		}
	}

	internal static bool Available { get; set; }

	public static int ReferenceCount => References.Count;

	[Conditional("DEBUG")]
	public static void LogDebug(string LogStr)
	{
	}

	[Conditional("DEBUG")]
	private static void CheckAvailable()
	{
		if (!Available)
		{
			throw new Exception("GCHelper accessed before UObject classes loaded.");
		}
	}

	public static T FindInterface<T>(IntPtr native) where T : class, IInterface
	{
		UObject uObject = FindInternal<UObject>(native);
		if (uObject != null)
		{
			return uObject.GetInterface<T>();
		}
		return null;
	}

	public static T Find<T>(IntPtr native) where T : UObject
	{
		return FindInternal<T>(native);
	}

	private static T FindInternal<T>(IntPtr native) where T : class
	{
		UObjectRef uObjectRef = FindRef(native);
		if (uObjectRef != null)
		{
			return uObjectRef.Managed as T;
		}
		return null;
	}

	public static UObjectRef FindRef(IntPtr native)
	{
		if (native == IntPtr.Zero)
		{
			return null;
		}
		if (!References.TryGetValue(native.ToInt64(), out var value))
		{
			IntPtr intPtr = Add(native);
			if (intPtr != IntPtr.Zero)
			{
				return (UObjectRef)GCHandle.FromIntPtr(intPtr).Target;
			}
		}
		return value;
	}

	public static UObjectRef FindExistingRef(UObject obj)
	{
		return obj.objRef;
	}

	private static IntPtr Add(IntPtr native)
	{
		return Native_GCHelper.Add(native);
	}

	public static void Remove(IntPtr native)
	{
		Native_GCHelper.Remove(native);
	}

	[HandleProcessCorruptedStateExceptions]
	[MonoPInvokeCallback(typeof(Del_IntPtrIntPtr))]
	private unsafe static IntPtr OnAdd(IntPtr native)
	{
		UObjectRef value = null;
		int internalIndex = *(int*)(void*)(native + objectInternalIndexOffset);
		if (!References.TryGetValue(native.ToInt64(), out value))
		{
			bool isKnownType;
			Type type = UClass.GetFirstKnownType(native, out isKnownType, includeAbstract: false);
			if (type == null)
			{
				string text = string.Empty;
				string text2 = string.Empty;
				try
				{
					using FStringUnsafe fStringUnsafe = new FStringUnsafe();
					Native_UObjectBaseUtility.GetName(Native_UObjectBase.GetClass(native), ref fStringUnsafe.Array);
					text = fStringUnsafe.Value;
				}
				catch
				{
				}
				try
				{
					using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
					Native_UObjectBaseUtility.GetFullName(native, IntPtr.Zero, ref fStringUnsafe2.Array);
					text2 = fStringUnsafe2.Value;
				}
				catch
				{
				}
				StackTrace stackTrace = null;
				try
				{
					stackTrace = new StackTrace(4);
				}
				catch
				{
				}
				string message = string.Format("[GCHelper-Error] Couldn't find type for requested UObject. Address: {0} (0x{1}) Name: \"{2}\" FullName: \"{3}\" Stack:\r\n{4}", native.ToInt32(), native.ToInt32().ToString("X8"), text, text2, stackTrace);
				FMessage.Log(ELogVerbosity.Error, message);
				return IntPtr.Zero;
			}
			if (type.IsInterface)
			{
				type = typeof(UInterface);
			}
			value = objRefPool.New(native, type, isKnownType, internalIndex);
			References.Add(native.ToInt64(), value);
			OnAddListener?.Invoke(value.Managed);
			return GCHandle.ToIntPtr(value.ManagedHandle);
		}
		return GCHandle.ToIntPtr(value.ManagedHandle);
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	[HandleProcessCorruptedStateExceptions]
	private static void OnRemove(IntPtr gcHandlePtr)
	{
		try
		{
			GCHandle gCHandle = GCHandle.FromIntPtr(gcHandlePtr);
			UObjectRef uObjectRef = (UObjectRef)gCHandle.Target;
			OnRemoveListener?.Invoke(uObjectRef.Managed);
			Coroutine.RemoveObjectByGC(uObjectRef.Managed);
			uObjectRef.Managed.ReleaseInjectedInterfaces();
			uObjectRef.Managed.objRef = null;
			uObjectRef.Managed.Address = IntPtr.Zero;
			References.Remove(uObjectRef.Native.ToInt64());
			gCHandle.Free();
			objRefPool.ReturnObject(uObjectRef);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			throw;
		}
	}

	[MonoPInvokeCallback(typeof(Del_Void))]
	private static void OnPostGarbageCollect()
	{
		Native_GCHelper.CollectGarbage();
	}

	public static void CollectGarbage(bool managedOnly)
	{
		if (managedOnly)
		{
			Native_GCHelper.CollectGarbage();
		}
		else
		{
			UObject.CollectGarbage();
		}
	}

	public static Dictionary<Type, int> GetObjectTypeCounterList(bool PrintLog)
	{
		Dictionary<Type, int> dictionary = new Dictionary<Type, int>();
		foreach (KeyValuePair<long, UObjectRef> reference in References)
		{
			Type type = reference.Value.Managed.GetType();
			if (dictionary.TryGetValue(type, out var value))
			{
				dictionary[type] = value + 1;
			}
			else
			{
				dictionary.Add(type, 1);
			}
		}
		if (PrintLog)
		{
			foreach (KeyValuePair<Type, int> item in dictionary)
			{
				_ = item;
			}
		}
		return dictionary;
	}

	internal static void OnNativeFunctionsRegistered()
	{
		onAdd = OnAdd;
		onRemove = OnRemove;
		Native_GCHelper.Set_OnAdd(onAdd);
		Native_GCHelper.Set_OnRemove(onRemove);
		objectInternalIndexOffset = Native_GCHelper.GetInternalIndexOffset();
		if (SharedRuntimeState.IsAOT)
		{
			Native_GCHelper.Set_OnPostGarbageCollect(OnPostGarbageCollectDele);
		}
		else
		{
			FCoreUObjectDelegates.PostGarbageCollect.Bind(OnPostGarbageCollect);
		}
	}

	internal static void OnUnload()
	{
		Dictionary<Type, bool> dictionary = new Dictionary<Type, bool>();
		List<long> list = new List<long>();
		Dictionary<long, UObjectRef> dictionary2 = new Dictionary<long, UObjectRef>(References);
		Dictionary<long, UObjectRef> dictionary3 = new Dictionary<long, UObjectRef>(dictionary2);
		while (dictionary3.Count > 0)
		{
			foreach (KeyValuePair<long, UObjectRef> item in dictionary3)
			{
				UObject managed = item.Value.Managed;
				if (!(managed != null) || managed.IsDestroyed)
				{
					continue;
				}
				Type type = managed.GetType();
				if (!dictionary.TryGetValue(type, out var value))
				{
					if (type.GetMethod("OnAssemblyUnload").DeclaringType != typeof(UObject))
					{
						value = true;
					}
					else if (type.GetMethod("OnAssemblyReload").DeclaringType != typeof(UObject))
					{
						value = true;
					}
					dictionary.Add(type, value);
				}
				if (value)
				{
					item.Value.Managed.OnAssemblyUnload();
					list.Add(item.Key);
				}
			}
			dictionary3.Clear();
			foreach (KeyValuePair<long, UObjectRef> reference in References)
			{
				if (!dictionary2.ContainsKey(reference.Key))
				{
					dictionary2.Add(reference.Key, reference.Value);
					dictionary3.Add(reference.Key, reference.Value);
				}
			}
		}
		GCHelperHotReloadData gCHelperHotReloadData = HotReload.Data.Create<GCHelperHotReloadData>();
		foreach (long item2 in list)
		{
			IntPtr objAddress = (IntPtr)item2;
			gCHelperHotReloadData.Objects.Add(new FWeakObjectPtr(objAddress));
		}
		Native_GCHelper.Clear();
	}

	internal static void OnReload()
	{
		GCHelperHotReloadData gCHelperHotReloadData = HotReload.Data.Get<GCHelperHotReloadData>();
		if (gCHelperHotReloadData == null)
		{
			return;
		}
		foreach (FWeakObjectPtr @object in gCHelperHotReloadData.Objects)
		{
			if (@object.IsValid())
			{
				UObject uObject = Find<UObject>(@object.GetPtr());
				if (uObject != null)
				{
					uObject.OnAssemblyReload();
				}
			}
		}
	}
}
