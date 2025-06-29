using System;
using System.Collections.Generic;
using b1;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class StrongPtrGCCollector
{
	private class WeakRefAllocator
	{
		private Queue<WeakReference<TStrongObjectPtrBase>> weakReferences = new Queue<WeakReference<TStrongObjectPtrBase>>();

		public WeakReference<TStrongObjectPtrBase> AllocWeakRef(TStrongObjectPtrBase Item)
		{
			if (weakReferences.Count > 0)
			{
				WeakReference<TStrongObjectPtrBase> weakReference = weakReferences.Dequeue();
				weakReference.SetTarget(Item);
				return weakReference;
			}
			return new WeakReference<TStrongObjectPtrBase>(Item);
		}

		public void RecycleWeakRef(WeakReference<TStrongObjectPtrBase> Ref)
		{
			Ref.SetTarget(null);
			weakReferences.Enqueue(Ref);
		}
	}

	private static WeakRefAllocator Alloc_AllStrPtrs = new WeakRefAllocator();

	private static WeakRefAllocator Alloc_DeferedSetNullList = new WeakRefAllocator();

	private static UnorderedArray<WeakReference<TStrongObjectPtrBase>> AllStrPtrs = new UnorderedArray<WeakReference<TStrongObjectPtrBase>>();

	private static object FlushNewAllocatedPtr_Locker = new object();

	private static List<TStrongObjectPtrBase> NewAllocatedPtr = new List<TStrongObjectPtrBase>();

	private static List<TStrongObjectPtrBase> NewAllocatedPtr_Threaded = new List<TStrongObjectPtrBase>();

	private static List<TStrongObjectPtrBase> NewAllocatedPtrWaitInThread;

	private static List<IntPtr> DeferedDeleteList = new List<IntPtr>();

	private static List<WeakReference<TStrongObjectPtrBase>> DeferedSetNullList = new List<WeakReference<TStrongObjectPtrBase>>();

	public static bool EnableCollector = true;

	public static bool EnableSetNull = true;

	public static bool ForceInGameThread = false;

	public static bool ForceInGameThread_ThreadValue = ForceInGameThread;

	private const float GC_INTERVAL = 2f;

	private static float GCTimer = 2f;

	public static void AddNewPtr_GameThread(TStrongObjectPtrBase Ptr)
	{
		if (!EnableCollector)
		{
			return;
		}
		if (!Native_FThreading.IsInGameThread())
		{
			lock (FlushNewAllocatedPtr_Locker)
			{
				NewAllocatedPtr_Threaded.Add(Ptr);
				return;
			}
		}
		NewAllocatedPtr.Add(Ptr);
	}

	public static void Tick_GameThread(float DeltaTime)
	{
		FlushDeferedDeleteList_GameThread();
		GCTimer -= DeltaTime;
		if (!(GCTimer <= 0f))
		{
			return;
		}
		GCTimer = 2f;
		if (EnableCollector && NewAllocatedPtrWaitInThread == null)
		{
			lock (FlushNewAllocatedPtr_Locker)
			{
				NewAllocatedPtrWaitInThread = NewAllocatedPtr;
				NewAllocatedPtrWaitInThread.AddRange(NewAllocatedPtr_Threaded);
				NewAllocatedPtr_Threaded.Clear();
			}
			NewAllocatedPtr = new List<TStrongObjectPtrBase>();
			if (ForceInGameThread_ThreadValue)
			{
				CollectInvalidPtr_GS_GCThread(null);
			}
			else
			{
				GSThreadPool.Instance.QueueSlowTask(CollectInvalidPtr_GS_GCThread, null);
			}
		}
	}

	public static void AddDeferDeletePtr_AnyThread(IntPtr Ptr)
	{
		lock (DeferedDeleteList)
		{
			DeferedDeleteList.Add(Ptr);
		}
	}

	private static void CollectInvalidPtr_GS_GCThread(object Arg)
	{
		if (!EnableCollector)
		{
			return;
		}
		AllStrPtrs.BeginItr();
		WeakReference<TStrongObjectPtrBase> output;
		while (AllStrPtrs.NextItr(out output))
		{
			if (output.TryGetTarget(out var target))
			{
				if (target.GetUObject() != null && !target.IsValid())
				{
					lock (DeferedSetNullList)
					{
						WeakReference<TStrongObjectPtrBase> item = Alloc_DeferedSetNullList.AllocWeakRef(target);
						DeferedSetNullList.Add(item);
					}
					AllStrPtrs.Remove(out var RemoveItem);
					Alloc_AllStrPtrs.RecycleWeakRef(RemoveItem);
				}
			}
			else
			{
				AllStrPtrs.Remove(out var RemoveItem2);
				Alloc_AllStrPtrs.RecycleWeakRef(RemoveItem2);
			}
		}
		foreach (TStrongObjectPtrBase item2 in NewAllocatedPtrWaitInThread)
		{
			AllStrPtrs.Add(Alloc_AllStrPtrs.AllocWeakRef(item2));
		}
		lock (FlushNewAllocatedPtr_Locker)
		{
			NewAllocatedPtrWaitInThread.Clear();
			NewAllocatedPtrWaitInThread = null;
		}
		ForceInGameThread_ThreadValue = ForceInGameThread;
	}

	public static void FlushDeferedDeleteList_GameThread()
	{
		if (DeferedDeleteList.Count > 0)
		{
			lock (DeferedDeleteList)
			{
				for (int i = 0; i < DeferedDeleteList.Count; i++)
				{
					IntPtr instance = DeferedDeleteList[i];
					Native_TStrongObjectPtr.Delete(instance);
				}
				DeferedDeleteList.Clear();
			}
		}
		if (DeferedSetNullList.Count <= 0)
		{
			return;
		}
		lock (DeferedSetNullList)
		{
			if (EnableSetNull)
			{
				for (int j = 0; j < DeferedSetNullList.Count; j++)
				{
					WeakReference<TStrongObjectPtrBase> weakReference = DeferedSetNullList[j];
					if (weakReference.TryGetTarget(out var target) && !target.IsValid())
					{
						target.SetNull();
					}
					Alloc_DeferedSetNullList.RecycleWeakRef(weakReference);
				}
			}
			DeferedSetNullList.Clear();
		}
	}
}
