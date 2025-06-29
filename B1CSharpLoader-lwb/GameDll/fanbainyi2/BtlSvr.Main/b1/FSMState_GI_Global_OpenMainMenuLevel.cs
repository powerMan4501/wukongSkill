using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FSMState_GI_Global_OpenMainMenuLevel : FSMState_GI_GlobalBase
{
	public override void Init(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
	}

	public override void OnEnter()
	{
		string levelPathById = BGUFuncLibMap.GetLevelPathById(BGUFuncLibMap.GetMainMenuLevelId(Context.OwnerUObj));
		BGW_GameLifeTimeMgr.Get(Context.OwnerUObj).StartOpenLevel();
		UGameplayStatics.OpenLevel(Context.OwnerUObj, new FName(levelPathById));
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Context.OwnerUObj);
		bGW_EventCollection.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
	}

	private void OnPostLoadMapWithWorld()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Context.OwnerUObj);
		bGW_EventCollection.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
		base.OwningInstance.TriggerEvent(EGI_Global.StartUp);
	}

	public override int OnTick(float Delta)
	{
		return 100;
	}

	public override void OnExit()
	{
	}
}
