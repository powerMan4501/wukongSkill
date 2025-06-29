using System;
using System.Reflection;
using UnrealEngine.Runtime;

namespace b1;

public class GS_GCHelper
{
	private bool RunningTask;

	private WeakReferenceList_PingPong<object> ObjectsToClearStrongPtr_PingPong = new WeakReferenceList_PingPong<object>();

	public const float CleanStrongPtrDelayTime = 35f;

	public bool Enable = true;

	private float CleanStrongPtrTimer = 35f;

	public bool VerboseLog;

	public bool KillAllField;

	public static GS_GCHelper Instance { get; private set; }

	static GS_GCHelper()
	{
		Instance = new GS_GCHelper();
	}

	public GS_GCHelper()
	{
		GCHelper.OnRemoveListener = (GCHelper.Del_VoidUObj)Delegate.Combine(GCHelper.OnRemoveListener, new GCHelper.Del_VoidUObj(OnUsharpRemoveObj));
	}

	public void OnUsharpRemoveObj(UObject Obj)
	{
		if (KillAllField)
		{
			FieldInfo[] fields = Obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			for (int i = 0; i < fields.Length; i++)
			{
				fields[i].SetValue(Obj, null);
			}
		}
	}

	public void AddObjectToClearTStrongPtr(object Obj)
	{
		if (Enable && Obj != null)
		{
			ObjectsToClearStrongPtr_PingPong.GetAddList().Add(Obj);
		}
	}

	public void Tick(float DeltaTime)
	{
		if (!Enable)
		{
			return;
		}
		CleanStrongPtrTimer -= DeltaTime;
		if (CleanStrongPtrTimer < 0f)
		{
			CleanStrongPtrTimer = 35f;
			ObjectsToClearStrongPtr_PingPong.Switch_GameThread();
			if (!RunningTask)
			{
				RunningTask = true;
				GSThreadPool.Instance.QueueSlowTask(TStrongPtrClearTask, this);
			}
		}
		StrongPtrGCCollector.Tick_GameThread(DeltaTime);
	}

	private static void TStrongPtrClearTask(object MySelf)
	{
		GS_GCHelper gS_GCHelper = (GS_GCHelper)MySelf;
		bool verboseLog = gS_GCHelper.VerboseLog;
		WeakReferenceList<object> clearList = gS_GCHelper.ObjectsToClearStrongPtr_PingPong.GetClearList();
		int count = clearList.Count;
		for (int i = 0; i < count; i++)
		{
			if (!clearList.Items[i].TryGetTarget(out var target))
			{
				continue;
			}
			FieldInfo[] fields = target.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (FieldInfo fieldInfo in fields)
			{
				if (fieldInfo.FieldType.IsSubclassOf(typeof(TStrongObjectPtrBase)))
				{
					((TStrongObjectPtrBase)fieldInfo.GetValue(target)).GCClear();
				}
				if (fieldInfo.FieldType.FullName.Contains("EntitySharedRef"))
				{
					fieldInfo.SetValue(target, null);
				}
			}
		}
		clearList.Clear();
		gS_GCHelper.RunningTask = false;
	}
}
