using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

public class FSMState_GI_Loading_TeleportTemplateBegin : FSMState_GI_LoadingBase
{
	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
	}

	public override void OnEnter()
	{
		UAkGameplayStatics.SetRTPCValue(null, 0f, 0, null, new FName("RTPC_Block_Sp"));
		Context.TeleportTemplate.OnBegin();
		int curLevelId = BGUFuncLibMap.GetCurLevelId(Context.GameInst);
		int targetLevelId = Context.TeleportTemplate.GetTargetLevelId();
		if (curLevelId != 0 && targetLevelId != 0 && curLevelId != targetLevelId && Context.TeleportTemplate.PlayerPawn != null && Context.TeleportTemplate.PlayerPawn.PlayerState != null && Context.TeleportTemplate.PlayerController != null)
		{
			int areaId = BGUFuncLibMap.GetAreaId(Context.TeleportTemplate.PlayerPawn);
			if (areaId != 0)
			{
				BPS_EventCollectionCS.Get(Context.TeleportTemplate.PlayerPawn.PlayerState)?.Evt_SetOSSSlevelLeaveData.Invoke(curLevelId, areaId);
				BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(Context.TeleportTemplate.PlayerController);
				if (readOnlyData != null)
				{
					readOnlyData.BeginAreaStayTime = readOnlyData.GetGameTotalTime();
				}
			}
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Context.TeleportTemplate.PlayerPawn);
		bUS_GSEventCollection?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.TeleportBegin, -1f);
		bUS_GSEventCollection?.Evt_TeleportBegin.Invoke();
		Context.TeleportTemplate.GrassTickInterval_CvarHandle = CVarFuncLib.CreateHandle("grass.TickInterval");
		CVarFuncLib.SetByHandle(Context.TeleportTemplate.GrassTickInterval_CvarHandle, 1f);
		if (Context.TeleportTemplate.TickPreTeleportAction(0f))
		{
			base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
		}
	}

	public override int OnTick(float Delta)
	{
		if (Context.TeleportTemplate.TickPreTeleportAction(Delta))
		{
			base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
			return 100;
		}
		return 0;
	}

	public override void OnExit()
	{
	}
}
