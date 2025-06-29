using System;
using System.Linq;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BIS_PlayerTeleportMgr : GameInstanceSystemBase
{
	private BIC_TeleportData TeleportData { get; set; }

	public override void OnAttach()
	{
		TeleportData = RequireWritableGameInstanceData<BIC_TeleportData>();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		bGW_EventCollection.Evt_TriggerPlayerTeleport = (BGW_EventCollection.Del_TriggerPlayerTeleport)Delegate.Combine(bGW_EventCollection.Evt_TriggerPlayerTeleport, new BGW_EventCollection.Del_TriggerPlayerTeleport(OnTriggerPlayerTeleport));
		BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(base.Owner);
		bGW_EventCollection2.Evt_ResetGameInstanceData = (BGW_EventCollection.Del_BGW_ResetGameInstanceData)Delegate.Combine(bGW_EventCollection2.Evt_ResetGameInstanceData, new BGW_EventCollection.Del_BGW_ResetGameInstanceData(OnResetGameInstanceData));
	}

	private void OnResetGameInstanceData(EGameInstanceResetType ResetType)
	{
		TeleportData.ResetData();
	}

	private void OnTriggerPlayerTeleport(APlayerController PlayerController, ETeleportTypeV2 TeleportType, ValueType UserData, EPlayerTeleportReason Reason)
	{
		if (!PlayerController.IsNullOrDestroyed())
		{
			GSEUtil.Ensure(TeleportData.CurrentInstance == null, $"Request more than twice teleport with type {TeleportType} and reason {Reason}");
			if (TeleportData.CurrentInstance != null)
			{
				TeleportData.CachedTeleportRequests.Enqueue(new Tuple<APlayerController, ETeleportTypeV2, ValueType>(PlayerController, TeleportType, UserData));
			}
			else
			{
				InitAndStartTeleport(PlayerController, TeleportType, UserData);
			}
		}
	}

	private void InitAndStartTeleport(APlayerController PlayerController, ETeleportTypeV2 TeleportType, ValueType UserData)
	{
		if (!PlayerController.IsNullOrDestroyed())
		{
			TeleportData.TeleportFSMContext = new FSMContext_GI_Loading(BGWGameInstanceCS.Get(base.Owner));
			TeleportData.TeleportFSMContext.TeleportTemplate = TeleportTemplateFactory.CreateTeleportTemplate(TeleportType, UserData, PlayerController);
			TeleportData.CurrentInstance = BGW_EventCollection.Get(base.Owner).Evt_BGW_CFSMGStart("/Game/00Main/DataAsset/CFSMG/GI_Loading/CFSMG_GI_Loading_Teleport.CFSMG_GI_Loading_Teleport", TeleportData.TeleportFSMContext, BGWGameInstanceCS.Get(base.Owner), null, OnTeleportGraphFinish) as FSMRuntimeInstance_GI_Loading;
			BGW_EventCollection.Get(base.Owner).Evt_BGW_PlayerTeleportToTriggered(TeleportType);
		}
	}

	private void OnTeleportGraphFinish()
	{
		TeleportData.TeleportFSMContext = null;
		TeleportData.CurrentInstance = null;
		BGW_EventCollection.Get(base.Owner).Evt_BGW_PlayerTeleportToFinished();
		if (TeleportData.CachedTeleportRequests.Any())
		{
			Tuple<APlayerController, ETeleportTypeV2, ValueType> tuple = TeleportData.CachedTeleportRequests.Dequeue();
			InitAndStartTeleport((!tuple.Item1.IsNullOrDestroyed()) ? tuple.Item1 : UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner), tuple.Item2, tuple.Item3);
		}
	}
}
