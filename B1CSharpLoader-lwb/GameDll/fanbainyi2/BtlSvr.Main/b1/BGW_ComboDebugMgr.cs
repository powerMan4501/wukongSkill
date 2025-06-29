using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_ComboDebugMgr")]
public class BGW_ComboDebugMgr : GameInstanceSystemBaseUObj
{
	public static WeakReference<BGW_ComboDebugMgr> InstanceRef;

	public bool IsBindDelegateForDebug;

	public bool IsBindDelegateForDebug2;

	private ComboDebugWorker CurrentWorker;

	public override bool bTickEnabled => true;

	public override void OnAttach()
	{
		base.OnAttach();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		bGW_EventCollection.Evt_ComboTest = (Del_Void_String)Delegate.Combine(bGW_EventCollection.Evt_ComboTest, new Del_Void_String(ConvertParam));
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		InstanceRef = null;
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		bGW_EventCollection.Evt_ComboTest = (Del_Void_String)Delegate.Remove(bGW_EventCollection.Evt_ComboTest, new Del_Void_String(ConvertParam));
	}

	public override void OnInit()
	{
		InstanceRef = new WeakReference<BGW_ComboDebugMgr>(this);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		if (TickGroup == 1024 && CurrentWorker != null)
		{
			if (CurrentWorker.Finish)
			{
				CurrentWorker = null;
			}
			else
			{
				CurrentWorker.OnTick();
			}
		}
	}

	private void ConvertParam(string ComboParam)
	{
		ComboDebugCommand comboDebugCommand = new ComboDebugCommand();
		if (string.IsNullOrEmpty(ComboParam))
		{
			comboDebugCommand.LoadFromDisk();
		}
		else
		{
			comboDebugCommand.LoadFromString(ComboParam);
		}
		AActor aActor = null;
		if (int.TryParse(comboDebugCommand.CasterID, out var result))
		{
			BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(this);
			float num = float.MaxValue;
			BGUCharacterCS[] array = allActorsOfClass;
			foreach (BGUCharacterCS bGUCharacterCS in array)
			{
				if (BGU_DataUtil.GetActorResID(bGUCharacterCS) == result)
				{
					IBUC_TickRateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_TickRateData, BUC_TickRateData>(bGUCharacterCS);
					if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.GetDistanceToPlayer() < num)
					{
						aActor = bGUCharacterCS;
					}
				}
			}
		}
		else
		{
			aActor = BGU_DataUtil.GetActorByGuid(this, comboDebugCommand.CasterID);
		}
		if (aActor.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("[ComboDebugger] 没有匹配到合适的施法者");
		}
		if (CurrentWorker != null && !CurrentWorker.Finish)
		{
			CurrentWorker.FinishWorker();
		}
		CurrentWorker = new ComboDebugWorker(aActor, comboDebugCommand.DisableCBG, new Queue<ComboDebugConfig>(comboDebugCommand.Combo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_ComboDebugMgr");
	}

	static BGW_ComboDebugMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_ComboDebugMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_ComboDebugMgr));
	}
}
