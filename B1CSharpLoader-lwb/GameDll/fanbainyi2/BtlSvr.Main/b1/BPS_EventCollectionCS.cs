using System;
using b1.EventDelDefine;
using GUR.Runtime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BPS_EventCollectionCS")]
public class BPS_EventCollectionCS : UBUS_EventCollection
{
	public Del_Void Evt_BPS_BreakInteract;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	[UINeedEvent]
	public Del_Void_Int Evt_BPS_TestPlayerState;

	public Del_Void_Int Evt_BPS_TestPlayerController;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_BPS_TeleportTo Evt_BPS_TeleportTo;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ServerInternal)]
	public Del_BPS_AddPredictionKeyState Evt_BPS_AddPredictionKeyState;

	public Del_BPS_GetPredictionKeyState Evt_BPS_GetPredictionKeyState;

	public Del_CollectReplicateData Evt_BPS_CollectReplicateData;

	public Del_DoReplicateData Evt_BPS_DoReplicateData;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Server, Reliable = true)]
	public Del_ServerActivateTamer Evt_BPS_ServerActivateTamer;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Client, Reliable = true)]
	public Del_ClientInitCharacterNetRole Evt_BPS_ClientInitCharacterNetRole;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Server, Reliable = true)]
	public Del_ServerNotifyClientTamerBackToLoad Evt_BPS_ServerNotifyClientTamerBackToLoad;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Server, Reliable = true)]
	public Del_ServerNotifyClientAuthorityTamerDead Evt_BPS_ServerNotifyClientAuthorityTamerDead;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Server, Reliable = true)]
	public Del_ServerSpawnDynamicTamer Evt_BPS_ServerSpawnDynamicTamer;

	public Del_ClientInternalReqSpawnDynamicTamer Evt_BPS_ClientInternalReqSpawnDynamicTamer;

	public Del_Void_Actor Evt_BPS_BGUCharaterNetReceiveRole;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ServerInternal)]
	public Del_AddTransaction Evt_BPS_StartTransaction;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void_BoolBoolBool Evt_BPS_BeginCinematicIgnoreMode;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void Evt_BPS_EndCinematicIgnoreMode;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Server, Reliable = true)]
	public Del_Void_SummonRequest Evt_RequestSummon = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_Void_ServantReq Evt_SendServantReq = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_AddPostProcessMat Evt_AddPostProcessMat = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_RemovePostProcessMat Evt_RemovePostProcessMat = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void_Int Evt_EnterSkillCameraConversionParam = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void_Int Evt_ExitSkillCameraConversionParam = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void_Int Evt_SetResIDCameraConversionParam = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void_ActorInt Evt_EnterSkillCam = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void_Actor Evt_ExitSkillCam = delegate
	{
	};

	public Del_Void_IntInt Evt_OnEnterSkillCameraGroup;

	public Del_Void_IntInt Evt_OnExitSkillCameraGroup;

	public Del_Void_Int Evt_EnterCameraGroup;

	public Del_Void_Int Evt_ExitCameraGroup;

	public Del_Void_IntFloatFloat Evt_OnSwitchCameraGroupVolumeTo;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void_ActorActor Evt_NotifyControlPawnChanged = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.Server, Reliable = true)]
	public Del_Param_RoleData Evt_BPS_SyncRoleDataTmp;

	public Del_Param_APawn Evt_BPS_OnControlledPawnChange;

	public Del_Param_Actor_Actor Evt_OnControlledPawnChange_Local;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_OnTriggerDropItem Evt_OnTriggerDropItem;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_RequestDropSpecialItem Evt_RequestDropSpecialItem;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_SpawnDropItemOnLoad Evt_SpawnDropItemOnLoad;

	public Del_Void_IntBool Evt_ActiveRebirthPoint = delegate
	{
	};

	public Del_Void_IntBool Evt_BlockRebirthPoint = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.Server, Reliable = true)]
	public Del_Void_Int Evt_TmpTransSendDropItem = delegate
	{
	};

	public Del_Void_Int Evt_SetCurrentBirthPoint = delegate
	{
	};

	public Del_Void_IntList Evt_RegSpecialRebirthPoint;

	public Del_Void_IntList Evt_UnregSpecialRebirthPoint;

	public Del_Void_Int Evt_ForceSetRebirthPoint = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_SwitchPlayerTransState Evt_BPS_SwitchPlayerTransState;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_SetSpellType Evt_BPS_SetDefaultSpellType;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	[UINeedEvent]
	public Del_ChangeAttrByEquip Evt_BPS_ChangeAttrByEquip;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void Evt_BPS_PauseCostEnergy;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void Evt_BPS_ResumeCostEnergy;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void Evt_PlayerActorSpawn;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_PostTransBindData Evt_PostTransBindData;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void_Int Evt_SetCurrentRebirthPoint;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_SetMapSymbolState Evt_SetMapSymbolState;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_SetMapSymbolActiveState Evt_SetMapSymbolActiveState;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void_FVector Evt_SetSelfDestination;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_TeamerSetDestination Evt_TeamerSetDestination;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_PlayerTransBegin Evt_TriggerPlayerTransBegin;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_PlayerTransEnd Evt_TriggerPlayerTransEnd;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void_IntInt Evt_ChangePlayerItem;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_ChangePlayerTaskStage Evt_ChangePlayerTaskStage;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_DefeatedStateChange Evt_DefeatedStateChange;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void_String Evt_TryRemoveBossBarInfo;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void_String Evt_TryRemoveEliteBarInfo;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void Evt_Close_RoleMain;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void_IntInt Evt_ActiveGeoInfoArea;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void_IntInt Evt_ExploreGeoInfoArea;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void_GeoInfoCustom Evt_AddGeoInfoCustom;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void_Int Evt_RemoveGeoInfoCustom;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void Evt_ClearAllGeoInfoCustom;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void Evt_GMClearAllArea;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void_Int Evt_GMActiveRebirthPointArea;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void Evt_GMCheckRebirthPointArea;

	public Del_Void_IntInt Evt_SetOSSSlevelLeaveData;

	public Del_BPS_PlayerTagTrigger Evt_BPS_PlayerTagTrigger;

	public Del_OSSRebirthPoint Evt_SetOSSRebirthPointData;

	public Del_Void_Int_Str Evt_SetOSSSceneWidgetData;

	public Del_Void Evt_SetOSSGameCompleteData;

	public Del_OSSItemChange Evt_SetOSSItemChangeData;

	public Del_Void_Bool Evt_TriggerAllowRide;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Client, Reliable = true)]
	public Del_CloseConnectionWithResult Evt_CloseConnectionWithResult;

	public Del_Void Evt_RebirthTeleportEnd;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_SetBossBar Evt_SetBossBar;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_SetBossBar Evt_SetEilteBar;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_SetBossBar Evt_UpdateHPPercent;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void Evt_BPS_UnitRebirthFinished;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void Evt_BPS_UnitTriggerFallDying;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_MoveToAction Evt_BPS_MoveToSceneItem;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_MoveToAction Evt_BPS_MoveToPos;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_EQSRunAction Evt_BPS_EQSRun;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_ComboAction Evt_BPS_Combo;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void Evt_BPS_StopCurrentAction;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_ActionTimeOut Evt_BPS_MoveToActionTimeOut;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_ActionTimeOut Evt_BPS_EQSRunActionTimeOut;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void_Actor Evt_BPS_ComboActionTimeOut;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_ActionNodeFinish Evt_BPS_ActionNodeFinish;

	public Del_Void_Int Evt_EnterWeakPerformState = delegate
	{
	};

	public Del_Void Evt_ExitWeakPerformState = delegate
	{
	};

	public Del_Void_Bool Evt_BPS_EnableCameraFoliageFade = delegate
	{
	};

	public Del_Void_Float Evt_BPS_SetCameraFoliageFadeValue = delegate
	{
	};

	public Del_Void_Float Evt_BPS_SetPlayerDeathUIDelayTime = delegate
	{
	};

	public Del_Void_Bool Evt_BPS_SetInputDrawDebug;

	public Del_Void Evt_BPS_SkipInteract = delegate
	{
	};

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_Void Evt_OnTriggerStopSimpleDropping = delegate
	{
	};

	public Del_Void_String Evt_BPS_OnKeyMonsterFightWithLocalPlayer = delegate
	{
	};

	public Del_Void_String Evt_BPS_OnPlayerDeadWhenBattleWithKeyMonster = delegate
	{
	};

	public Del_Void Evt_ViewTargetBlendComplete = delegate
	{
	};

	public static BPS_GSEventCollection Get(APlayerState PlayerState)
	{
		return (PlayerState as BGP_PlayerStateCS)?.PlayerEventCollection;
	}

	public static BPS_GSEventCollection Get(APlayerController PlayerController)
	{
		return (PlayerController.PlayerState as BGP_PlayerStateCS)?.PlayerEventCollection;
	}

	public static BPS_GSEventCollection GetLocal(UObject WorldContext)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		if (firstLocalPlayerController != null)
		{
			return Get(firstLocalPlayerController);
		}
		return null;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BPS_EventCollectionCS");
	}

	static BPS_EventCollectionCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BPS_EventCollectionCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BPS_EventCollectionCS));
	}
}
