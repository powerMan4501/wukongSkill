using System;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGS_GSEventCollection")]
public class BGS_GSEventCollection : GSEventCollectionBase
{
	public delegate bool Del_Evt_BGS_TriggerShortcutServer_Validate(bool B1, int P2);

	public delegate bool Del_Evt_PostMulticastAkEventServer_Validate(UAkAudioEvent AkEvent);

	private Del_Void_Int Evt_BGS_TestGameState_imp;

	private Del_Void_Int Evt_BGS_SwitchTickRateLogic_imp;

	private Del_Void_StringDeadReason Evt_BGS_UnitDead_imp;

	private Del_BGS_OnUnitTransited Evt_BGS_OnUnitTransited_imp;

	private Del_BGS_NotifySwitchTarget Evt_BGS_NotifySwitchTarget_imp;

	private Del_BGS_NotifyCopyHatredInfo Evt_BGS_NotifyCopyHatredInfo_imp;

	private Del_BGS_BoolInt Evt_BGS_TriggerShortcut_imp;

	private Del_Void_ServantInstance Evt_RegisterServantSvr_imp;

	private Del_Void_AkEvent Evt_PostMulticastAkEvent_imp;

	private Del_Void Evt_TeamWipeOut_imp;

	private Del_Void Evt_CrusadeSuccess_imp;

	private Del_SendOnlineScreenMsg Evt_BGS_SendOnlineScreenMsg_imp;

	private Del_OnPlayerLogOut Evt_BGS_OnPlayerLogOut_imp;

	private Del_OnPlayerPostLogin Evt_BGS_OnPlayerPostLogin_imp;

	private Del_Void Evt_OnlineDebugInfoEnd_imp;

	private Del_Void_Int Evt_BGS_ItemFullOnline_imp;

	private Del_Void_IntInt Evt_BGS_OnlineChallengeStateTrigger_imp;

	private Del_PlayerState Evt_BGS_PlayerJoin_imp;

	private Del_PlayerState Evt_BGS_PlayerLogOut_imp;

	private static bool EndPlayInCS_IsValid;

	private static IntPtr EndPlayInCS_FunctionAddress;

	private static int EndPlayInCS_ParamsSize;

	private static bool EndPlayInCS_EndPlayReason_IsValid;

	private static int EndPlayInCS_EndPlayReason_Offset;

	private static FFieldAddress EndPlayInCS_EndPlayReason_PropertyAddress;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	private static bool Evt_BGS_TriggerShortcutServer_IsValid;

	private static IntPtr Evt_BGS_TriggerShortcutServer_FunctionAddress;

	private static int Evt_BGS_TriggerShortcutServer_ParamsSize;

	private static bool Evt_BGS_TriggerShortcutServer_B1_IsValid;

	private static int Evt_BGS_TriggerShortcutServer_B1_Offset;

	private static FFieldAddress Evt_BGS_TriggerShortcutServer_B1_PropertyAddress;

	private static bool Evt_BGS_TriggerShortcutServer_P2_IsValid;

	private static int Evt_BGS_TriggerShortcutServer_P2_Offset;

	private static bool Evt_PostMulticastAkEventServer_IsValid;

	private static IntPtr Evt_PostMulticastAkEventServer_FunctionAddress;

	private static int Evt_PostMulticastAkEventServer_ParamsSize;

	private static bool Evt_PostMulticastAkEventServer_AkEvent_IsValid;

	private static int Evt_PostMulticastAkEventServer_AkEvent_Offset;

	private static bool Evt_TeamWipeOut_Multicast_Invoke_IsValid;

	private static IntPtr Evt_TeamWipeOut_Multicast_Invoke_FunctionAddress;

	private static int Evt_TeamWipeOut_Multicast_Invoke_ParamsSize;

	private static bool Evt_BGS_TriggerShortcutMultiCast_IsValid;

	private static IntPtr Evt_BGS_TriggerShortcutMultiCast_FunctionAddress;

	private static int Evt_BGS_TriggerShortcutMultiCast_ParamsSize;

	private static bool Evt_BGS_TriggerShortcutMultiCast_B1_IsValid;

	private static int Evt_BGS_TriggerShortcutMultiCast_B1_Offset;

	private static FFieldAddress Evt_BGS_TriggerShortcutMultiCast_B1_PropertyAddress;

	private static bool Evt_BGS_TriggerShortcutMultiCast_P2_IsValid;

	private static int Evt_BGS_TriggerShortcutMultiCast_P2_Offset;

	private static bool Evt_PostMulticastAkEventMultiCast_IsValid;

	private static IntPtr Evt_PostMulticastAkEventMultiCast_FunctionAddress;

	private static int Evt_PostMulticastAkEventMultiCast_ParamsSize;

	private static bool Evt_PostMulticastAkEventMultiCast_AkEvent_IsValid;

	private static int Evt_PostMulticastAkEventMultiCast_AkEvent_Offset;

	private static bool Evt_BGS_UnitDead_Multicast_Invoke_IsValid;

	private static IntPtr Evt_BGS_UnitDead_Multicast_Invoke_FunctionAddress;

	private static int Evt_BGS_UnitDead_Multicast_Invoke_ParamsSize;

	private static bool Evt_BGS_UnitDead_Multicast_Invoke_UnitGuid_IsValid;

	private static int Evt_BGS_UnitDead_Multicast_Invoke_UnitGuid_Offset;

	private static FFieldAddress Evt_BGS_UnitDead_Multicast_Invoke_UnitGuid_PropertyAddress;

	private static bool Evt_BGS_UnitDead_Multicast_Invoke_DeadReason_IsValid;

	private static int Evt_BGS_UnitDead_Multicast_Invoke_DeadReason_Offset;

	private static FFieldAddress Evt_BGS_UnitDead_Multicast_Invoke_DeadReason_PropertyAddress;

	private static bool Evt_CrusadeSuccess_Multicast_Invoke_IsValid;

	private static IntPtr Evt_CrusadeSuccess_Multicast_Invoke_FunctionAddress;

	private static int Evt_CrusadeSuccess_Multicast_Invoke_ParamsSize;

	private static bool Evt_BGS_PlayerJoin_Multicast_Invoke_IsValid;

	private static IntPtr Evt_BGS_PlayerJoin_Multicast_Invoke_FunctionAddress;

	private static int Evt_BGS_PlayerJoin_Multicast_Invoke_ParamsSize;

	private static bool Evt_BGS_PlayerJoin_Multicast_Invoke_PlayerState_IsValid;

	private static int Evt_BGS_PlayerJoin_Multicast_Invoke_PlayerState_Offset;

	private static bool Evt_BGS_PlayerLogOut_Multicast_Invoke_IsValid;

	private static IntPtr Evt_BGS_PlayerLogOut_Multicast_Invoke_FunctionAddress;

	private static int Evt_BGS_PlayerLogOut_Multicast_Invoke_ParamsSize;

	private static bool Evt_BGS_PlayerLogOut_Multicast_Invoke_PlayerState_IsValid;

	private static int Evt_BGS_PlayerLogOut_Multicast_Invoke_PlayerState_Offset;

	private static bool Evt_BGS_TestGameState_Multicast_Invoke_IsValid;

	private static IntPtr Evt_BGS_TestGameState_Multicast_Invoke_FunctionAddress;

	private static int Evt_BGS_TestGameState_Multicast_Invoke_ParamsSize;

	private static bool Evt_BGS_TestGameState_Multicast_Invoke_P1_IsValid;

	private static int Evt_BGS_TestGameState_Multicast_Invoke_P1_Offset;

	private static bool Evt_OnlineDebugInfoEnd_Multicast_Invoke_IsValid;

	private static IntPtr Evt_OnlineDebugInfoEnd_Multicast_Invoke_FunctionAddress;

	private static int Evt_OnlineDebugInfoEnd_Multicast_Invoke_ParamsSize;

	private static bool Evt_BGS_OnPlayerLogOut_Multicast_Invoke_IsValid;

	private static IntPtr Evt_BGS_OnPlayerLogOut_Multicast_Invoke_FunctionAddress;

	private static int Evt_BGS_OnPlayerLogOut_Multicast_Invoke_ParamsSize;

	private static bool Evt_BGS_OnPlayerLogOut_Multicast_Invoke_Exitting_IsValid;

	private static int Evt_BGS_OnPlayerLogOut_Multicast_Invoke_Exitting_Offset;

	private static bool Evt_BGS_ItemFullOnline_Multicast_Invoke_IsValid;

	private static IntPtr Evt_BGS_ItemFullOnline_Multicast_Invoke_FunctionAddress;

	private static int Evt_BGS_ItemFullOnline_Multicast_Invoke_ParamsSize;

	private static bool Evt_BGS_ItemFullOnline_Multicast_Invoke_P1_IsValid;

	private static int Evt_BGS_ItemFullOnline_Multicast_Invoke_P1_Offset;

	private static bool Evt_BGS_OnUnitTransited_Multicast_Invoke_IsValid;

	private static IntPtr Evt_BGS_OnUnitTransited_Multicast_Invoke_FunctionAddress;

	private static int Evt_BGS_OnUnitTransited_Multicast_Invoke_ParamsSize;

	private static bool Evt_BGS_OnUnitTransited_Multicast_Invoke_OldUnit_IsValid;

	private static int Evt_BGS_OnUnitTransited_Multicast_Invoke_OldUnit_Offset;

	private static bool Evt_BGS_OnUnitTransited_Multicast_Invoke_NewlySpawnedUnit_IsValid;

	private static int Evt_BGS_OnUnitTransited_Multicast_Invoke_NewlySpawnedUnit_Offset;

	private static bool Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_IsValid;

	private static IntPtr Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_FunctionAddress;

	private static int Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_ParamsSize;

	private static bool Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_NewPlayer_IsValid;

	private static int Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_NewPlayer_Offset;

	private static bool Evt_BGS_NotifySwitchTarget_Multicast_Invoke_IsValid;

	private static IntPtr Evt_BGS_NotifySwitchTarget_Multicast_Invoke_FunctionAddress;

	private static int Evt_BGS_NotifySwitchTarget_Multicast_Invoke_ParamsSize;

	private static bool Evt_BGS_NotifySwitchTarget_Multicast_Invoke_OldTarget_IsValid;

	private static int Evt_BGS_NotifySwitchTarget_Multicast_Invoke_OldTarget_Offset;

	private static bool Evt_BGS_NotifySwitchTarget_Multicast_Invoke_NewTarget_IsValid;

	private static int Evt_BGS_NotifySwitchTarget_Multicast_Invoke_NewTarget_Offset;

	private static bool Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TriggerTaunt_IsValid;

	private static int Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TriggerTaunt_Offset;

	private static FFieldAddress Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TriggerTaunt_PropertyAddress;

	private static bool Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TargetSourceType_IsValid;

	private static int Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TargetSourceType_Offset;

	private static FFieldAddress Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TargetSourceType_PropertyAddress;

	private static bool Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_IsValid;

	private static IntPtr Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_FunctionAddress;

	private static int Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_ParamsSize;

	private static bool Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_P1_IsValid;

	private static int Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_P1_Offset;

	private static bool Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_IsValid;

	private static IntPtr Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_FunctionAddress;

	private static int Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_ParamsSize;

	private static bool Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_ScreenMsgType_IsValid;

	private static int Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_ScreenMsgType_Offset;

	private static FFieldAddress Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_ScreenMsgType_PropertyAddress;

	private static bool Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_Msg_IsValid;

	private static int Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_Msg_Offset;

	private static FFieldAddress Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_Msg_PropertyAddress;

	private static bool Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_TipsDuration_IsValid;

	private static int Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_TipsDuration_Offset;

	private static bool Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_IsValid;

	private static IntPtr Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_FunctionAddress;

	private static int Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_ParamsSize;

	private static bool Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_OriginActor_IsValid;

	private static int Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_OriginActor_Offset;

	private static bool Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_CopyActor_IsValid;

	private static int Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_CopyActor_Offset;

	private static bool Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_bRemoveOriginHatredInfo_IsValid;

	private static int Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_bRemoveOriginHatredInfo_Offset;

	private static FFieldAddress Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_bRemoveOriginHatredInfo_PropertyAddress;

	private static bool Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_IsValid;

	private static IntPtr Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_FunctionAddress;

	private static int Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_ParamsSize;

	private static bool Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_P1_IsValid;

	private static int Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_P1_Offset;

	private static bool Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_P2_IsValid;

	private static int Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_P2_Offset;

	public GSDel_Void_Int_ICB Evt_BGS_TestGameState
	{
		get
		{
			if (!_EventObjCache.TryGetValue(1, out var value))
			{
				value = new GSDel_Void_Int_ICB(Evt_BGS_TestGameState_Invoke, Evt_BGS_TestGameState_DelChg);
				(value as GSDel_Void_Int_ICB).EventId = 1;
				(value as GSDel_Void_Int_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[1] = value;
			}
			return value as GSDel_Void_Int_ICB;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_BGS_TestGameMode
	{
		get
		{
			if (!_EventObjCache.TryGetValue(2, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 2;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[2] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_Void_Int_ICB Evt_BGS_SwitchTickRateLogic
	{
		get
		{
			if (!_EventObjCache.TryGetValue(3, out var value))
			{
				value = new GSDel_Void_Int_ICB(Evt_BGS_SwitchTickRateLogic_Invoke, Evt_BGS_SwitchTickRateLogic_DelChg);
				(value as GSDel_Void_Int_ICB).EventId = 3;
				(value as GSDel_Void_Int_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[3] = value;
			}
			return value as GSDel_Void_Int_ICB;
		}
		set
		{
		}
	}

	public GSDel_AllocPredictionKey Evt_BGS_AllocPredictionKey
	{
		get
		{
			if (!_EventObjCache.TryGetValue(4, out var value))
			{
				value = new GSDel_AllocPredictionKey();
				(value as GSDel_AllocPredictionKey).EventId = 4;
				(value as GSDel_AllocPredictionKey)._OwnerEventCollectionCS = this;
				_EventObjCache[4] = value;
			}
			return value as GSDel_AllocPredictionKey;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_BGS_ConfirmPredictionKey
	{
		get
		{
			if (!_EventObjCache.TryGetValue(5, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 5;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[5] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_BGS_RollBackPredictionKey
	{
		get
		{
			if (!_EventObjCache.TryGetValue(6, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 6;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[6] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_BeginPredictionScope Evt_BGS_BeginPredictionScope
	{
		get
		{
			if (!_EventObjCache.TryGetValue(7, out var value))
			{
				value = new GSDel_BeginPredictionScope();
				(value as GSDel_BeginPredictionScope).EventId = 7;
				(value as GSDel_BeginPredictionScope)._OwnerEventCollectionCS = this;
				_EventObjCache[7] = value;
			}
			return value as GSDel_BeginPredictionScope;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_EndPredictionScope
	{
		get
		{
			if (!_EventObjCache.TryGetValue(8, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 8;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[8] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_GetPredictionKeyById Evt_BGS_GetPredictionKeyById
	{
		get
		{
			if (!_EventObjCache.TryGetValue(9, out var value))
			{
				value = new GSDel_GetPredictionKeyById();
				(value as GSDel_GetPredictionKeyById).EventId = 9;
				(value as GSDel_GetPredictionKeyById)._OwnerEventCollectionCS = this;
				_EventObjCache[9] = value;
			}
			return value as GSDel_GetPredictionKeyById;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_BGS_ServerRejectPredictionKey
	{
		get
		{
			if (!_EventObjCache.TryGetValue(10, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 10;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[10] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_Bool_Int Evt_BGS_ServerHasPredictionKeyInRejectedSet
	{
		get
		{
			if (!_EventObjCache.TryGetValue(11, out var value))
			{
				value = new GSDel_Bool_Int();
				(value as GSDel_Bool_Int).EventId = 11;
				(value as GSDel_Bool_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[11] = value;
			}
			return value as GSDel_Bool_Int;
		}
		set
		{
		}
	}

	public GSDel_Void_Chr Evt_BGS_MasterChangeTeam
	{
		get
		{
			if (!_EventObjCache.TryGetValue(12, out var value))
			{
				value = new GSDel_Void_Chr();
				(value as GSDel_Void_Chr).EventId = 12;
				(value as GSDel_Void_Chr)._OwnerEventCollectionCS = this;
				_EventObjCache[12] = value;
			}
			return value as GSDel_Void_Chr;
		}
		set
		{
		}
	}

	public GSDel_Void_IntInt Evt_BGS_AddPartner
	{
		get
		{
			if (!_EventObjCache.TryGetValue(13, out var value))
			{
				value = new GSDel_Void_IntInt();
				(value as GSDel_Void_IntInt).EventId = 13;
				(value as GSDel_Void_IntInt)._OwnerEventCollectionCS = this;
				_EventObjCache[13] = value;
			}
			return value as GSDel_Void_IntInt;
		}
		set
		{
		}
	}

	public GSDel_Void_IntInt Evt_BGS_RemovePartner
	{
		get
		{
			if (!_EventObjCache.TryGetValue(14, out var value))
			{
				value = new GSDel_Void_IntInt();
				(value as GSDel_Void_IntInt).EventId = 14;
				(value as GSDel_Void_IntInt)._OwnerEventCollectionCS = this;
				_EventObjCache[14] = value;
			}
			return value as GSDel_Void_IntInt;
		}
		set
		{
		}
	}

	public GSDel_Void_StringDeadReason_ICB Evt_BGS_UnitDead
	{
		get
		{
			if (!_EventObjCache.TryGetValue(15, out var value))
			{
				value = new GSDel_Void_StringDeadReason_ICB(Evt_BGS_UnitDead_Invoke, Evt_BGS_UnitDead_DelChg);
				(value as GSDel_Void_StringDeadReason_ICB).EventId = 15;
				(value as GSDel_Void_StringDeadReason_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[15] = value;
			}
			return value as GSDel_Void_StringDeadReason_ICB;
		}
		set
		{
		}
	}

	public GSDel_BGS_OnUnitTransited_ICB Evt_BGS_OnUnitTransited
	{
		get
		{
			if (!_EventObjCache.TryGetValue(16, out var value))
			{
				value = new GSDel_BGS_OnUnitTransited_ICB(Evt_BGS_OnUnitTransited_Invoke, Evt_BGS_OnUnitTransited_DelChg);
				(value as GSDel_BGS_OnUnitTransited_ICB).EventId = 16;
				(value as GSDel_BGS_OnUnitTransited_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[16] = value;
			}
			return value as GSDel_BGS_OnUnitTransited_ICB;
		}
		set
		{
		}
	}

	public GSDel_Void_ActorActor Evt_BGS_OnBattlePlayerTransited
	{
		get
		{
			if (!_EventObjCache.TryGetValue(17, out var value))
			{
				value = new GSDel_Void_ActorActor();
				(value as GSDel_Void_ActorActor).EventId = 17;
				(value as GSDel_Void_ActorActor)._OwnerEventCollectionCS = this;
				_EventObjCache[17] = value;
			}
			return value as GSDel_Void_ActorActor;
		}
		set
		{
		}
	}

	public GSDel_BGS_DrawUseMatPainter Evt_BGS_DrawUseMatPainter
	{
		get
		{
			if (!_EventObjCache.TryGetValue(18, out var value))
			{
				value = new GSDel_BGS_DrawUseMatPainter();
				(value as GSDel_BGS_DrawUseMatPainter).EventId = 18;
				(value as GSDel_BGS_DrawUseMatPainter)._OwnerEventCollectionCS = this;
				_EventObjCache[18] = value;
			}
			return value as GSDel_BGS_DrawUseMatPainter;
		}
		set
		{
		}
	}

	public GSDel_BGS_AddOrUpdateEndTickGameTimeForSurfaceType Evt_BGS_AddOrUpdateEndTickGameTimeForSurfaceType
	{
		get
		{
			if (!_EventObjCache.TryGetValue(19, out var value))
			{
				value = new GSDel_BGS_AddOrUpdateEndTickGameTimeForSurfaceType();
				(value as GSDel_BGS_AddOrUpdateEndTickGameTimeForSurfaceType).EventId = 19;
				(value as GSDel_BGS_AddOrUpdateEndTickGameTimeForSurfaceType)._OwnerEventCollectionCS = this;
				_EventObjCache[19] = value;
			}
			return value as GSDel_BGS_AddOrUpdateEndTickGameTimeForSurfaceType;
		}
		set
		{
		}
	}

	public GSDel_BGS_PushParamsToMaterial Evt_BGS_PushParamsToPainterMaterial
	{
		get
		{
			if (!_EventObjCache.TryGetValue(20, out var value))
			{
				value = new GSDel_BGS_PushParamsToMaterial();
				(value as GSDel_BGS_PushParamsToMaterial).EventId = 20;
				(value as GSDel_BGS_PushParamsToMaterial)._OwnerEventCollectionCS = this;
				_EventObjCache[20] = value;
			}
			return value as GSDel_BGS_PushParamsToMaterial;
		}
		set
		{
		}
	}

	public GSDel_BGS_PushParamsToMaterial Evt_BGS_PushParamsToCanvasMaterial
	{
		get
		{
			if (!_EventObjCache.TryGetValue(21, out var value))
			{
				value = new GSDel_BGS_PushParamsToMaterial();
				(value as GSDel_BGS_PushParamsToMaterial).EventId = 21;
				(value as GSDel_BGS_PushParamsToMaterial)._OwnerEventCollectionCS = this;
				_EventObjCache[21] = value;
			}
			return value as GSDel_BGS_PushParamsToMaterial;
		}
		set
		{
		}
	}

	public GSDel_BGS_AddCameraShakeWithControl Evt_BGS_AddCameraShakeWithControl
	{
		get
		{
			if (!_EventObjCache.TryGetValue(22, out var value))
			{
				value = new GSDel_BGS_AddCameraShakeWithControl();
				(value as GSDel_BGS_AddCameraShakeWithControl).EventId = 22;
				(value as GSDel_BGS_AddCameraShakeWithControl)._OwnerEventCollectionCS = this;
				_EventObjCache[22] = value;
			}
			return value as GSDel_BGS_AddCameraShakeWithControl;
		}
		set
		{
		}
	}

	public GSDel_BGS_StopCamShakeByReqID Evt_BGS_StopCamShakeByReqID
	{
		get
		{
			if (!_EventObjCache.TryGetValue(23, out var value))
			{
				value = new GSDel_BGS_StopCamShakeByReqID();
				(value as GSDel_BGS_StopCamShakeByReqID).EventId = 23;
				(value as GSDel_BGS_StopCamShakeByReqID)._OwnerEventCollectionCS = this;
				_EventObjCache[23] = value;
			}
			return value as GSDel_BGS_StopCamShakeByReqID;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_IncreaseBuffDispGlobalTriggerCounter
	{
		get
		{
			if (!_EventObjCache.TryGetValue(24, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 24;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[24] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_BGS_SubmitFoliageInteractSound Evt_BGS_SubmitFoliageInteractSound
	{
		get
		{
			if (!_EventObjCache.TryGetValue(25, out var value))
			{
				value = new GSDel_BGS_SubmitFoliageInteractSound();
				(value as GSDel_BGS_SubmitFoliageInteractSound).EventId = 25;
				(value as GSDel_BGS_SubmitFoliageInteractSound)._OwnerEventCollectionCS = this;
				_EventObjCache[25] = value;
			}
			return value as GSDel_BGS_SubmitFoliageInteractSound;
		}
		set
		{
		}
	}

	public GSDel_BGS_BeginAnimationSyncPreCheck Evt_BGS_BeginAnimationSyncPreCheck
	{
		get
		{
			if (!_EventObjCache.TryGetValue(26, out var value))
			{
				value = new GSDel_BGS_BeginAnimationSyncPreCheck();
				(value as GSDel_BGS_BeginAnimationSyncPreCheck).EventId = 26;
				(value as GSDel_BGS_BeginAnimationSyncPreCheck)._OwnerEventCollectionCS = this;
				_EventObjCache[26] = value;
			}
			return value as GSDel_BGS_BeginAnimationSyncPreCheck;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BGS_EndAnimationSyncPreCheck
	{
		get
		{
			if (!_EventObjCache.TryGetValue(27, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 27;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[27] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_BGS_BeginSyncAnimation Evt_BGS_BeginSyncAnimation
	{
		get
		{
			if (!_EventObjCache.TryGetValue(28, out var value))
			{
				value = new GSDel_BGS_BeginSyncAnimation();
				(value as GSDel_BGS_BeginSyncAnimation).EventId = 28;
				(value as GSDel_BGS_BeginSyncAnimation)._OwnerEventCollectionCS = this;
				_EventObjCache[28] = value;
			}
			return value as GSDel_BGS_BeginSyncAnimation;
		}
		set
		{
		}
	}

	public GSDel_BGS_EndSyncAnimation Evt_BGS_EndSyncAnimation
	{
		get
		{
			if (!_EventObjCache.TryGetValue(29, out var value))
			{
				value = new GSDel_BGS_EndSyncAnimation();
				(value as GSDel_BGS_EndSyncAnimation).EventId = 29;
				(value as GSDel_BGS_EndSyncAnimation)._OwnerEventCollectionCS = this;
				_EventObjCache[29] = value;
			}
			return value as GSDel_BGS_EndSyncAnimation;
		}
		set
		{
		}
	}

	public GSDel_BGS_BeginInteractSyncAnimation Evt_BGS_BeginInteractSyncAnimation
	{
		get
		{
			if (!_EventObjCache.TryGetValue(30, out var value))
			{
				value = new GSDel_BGS_BeginInteractSyncAnimation();
				(value as GSDel_BGS_BeginInteractSyncAnimation).EventId = 30;
				(value as GSDel_BGS_BeginInteractSyncAnimation)._OwnerEventCollectionCS = this;
				_EventObjCache[30] = value;
			}
			return value as GSDel_BGS_BeginInteractSyncAnimation;
		}
		set
		{
		}
	}

	public GSDel_Void_ActorBool Evt_BGS_EndInteractSyncAnimation
	{
		get
		{
			if (!_EventObjCache.TryGetValue(31, out var value))
			{
				value = new GSDel_Void_ActorBool();
				(value as GSDel_Void_ActorBool).EventId = 31;
				(value as GSDel_Void_ActorBool)._OwnerEventCollectionCS = this;
				_EventObjCache[31] = value;
			}
			return value as GSDel_Void_ActorBool;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BGS_NotifyHostToEndInteractSyncAnimation
	{
		get
		{
			if (!_EventObjCache.TryGetValue(32, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 32;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[32] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BGS_RemoveInteractParticipants
	{
		get
		{
			if (!_EventObjCache.TryGetValue(33, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 33;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[33] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_BGS_ProcessDeathInAnimationSync Evt_BGS_ProcessDeathInAnimationSync
	{
		get
		{
			if (!_EventObjCache.TryGetValue(34, out var value))
			{
				value = new GSDel_BGS_ProcessDeathInAnimationSync();
				(value as GSDel_BGS_ProcessDeathInAnimationSync).EventId = 34;
				(value as GSDel_BGS_ProcessDeathInAnimationSync)._OwnerEventCollectionCS = this;
				_EventObjCache[34] = value;
			}
			return value as GSDel_BGS_ProcessDeathInAnimationSync;
		}
		set
		{
		}
	}

	public GSDel_Void_Bool Evt_BGS_SetMoveCameraSpringArmRotToNearestAfterAS
	{
		get
		{
			if (!_EventObjCache.TryGetValue(35, out var value))
			{
				value = new GSDel_Void_Bool();
				(value as GSDel_Void_Bool).EventId = 35;
				(value as GSDel_Void_Bool)._OwnerEventCollectionCS = this;
				_EventObjCache[35] = value;
			}
			return value as GSDel_Void_Bool;
		}
		set
		{
		}
	}

	public GSDel_BGS_NotifySwitchTarget_ICB Evt_BGS_NotifySwitchTarget
	{
		get
		{
			if (!_EventObjCache.TryGetValue(36, out var value))
			{
				value = new GSDel_BGS_NotifySwitchTarget_ICB(Evt_BGS_NotifySwitchTarget_Invoke, Evt_BGS_NotifySwitchTarget_DelChg);
				(value as GSDel_BGS_NotifySwitchTarget_ICB).EventId = 36;
				(value as GSDel_BGS_NotifySwitchTarget_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[36] = value;
			}
			return value as GSDel_BGS_NotifySwitchTarget_ICB;
		}
		set
		{
		}
	}

	public GSDel_BGS_NotifyCopyHatredInfo_ICB Evt_BGS_NotifyCopyHatredInfo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(37, out var value))
			{
				value = new GSDel_BGS_NotifyCopyHatredInfo_ICB(Evt_BGS_NotifyCopyHatredInfo_Invoke, Evt_BGS_NotifyCopyHatredInfo_DelChg);
				(value as GSDel_BGS_NotifyCopyHatredInfo_ICB).EventId = 37;
				(value as GSDel_BGS_NotifyCopyHatredInfo_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[37] = value;
			}
			return value as GSDel_BGS_NotifyCopyHatredInfo_ICB;
		}
		set
		{
		}
	}

	public GSDel_BGS_FightVanished Evt_BGS_FightVanished
	{
		get
		{
			if (!_EventObjCache.TryGetValue(38, out var value))
			{
				value = new GSDel_BGS_FightVanished();
				(value as GSDel_BGS_FightVanished).EventId = 38;
				(value as GSDel_BGS_FightVanished)._OwnerEventCollectionCS = this;
				_EventObjCache[38] = value;
			}
			return value as GSDel_BGS_FightVanished;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BGS_ComeCloseToFollowPartnerInteractiveArea
	{
		get
		{
			if (!_EventObjCache.TryGetValue(39, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 39;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[39] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BGS_EnterFollowPartnerInteractArea
	{
		get
		{
			if (!_EventObjCache.TryGetValue(40, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 40;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[40] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BGS_LeaveFollowPartnerInteractArea
	{
		get
		{
			if (!_EventObjCache.TryGetValue(41, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 41;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[41] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BGS_FollowPartnerFinishInteract
	{
		get
		{
			if (!_EventObjCache.TryGetValue(42, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 42;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[42] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_BGS_EliminationCurrentFollowPartner
	{
		get
		{
			if (!_EventObjCache.TryGetValue(43, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 43;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[43] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_RemovePerformerInList Evt_BGS_RemovePerformerInList
	{
		get
		{
			if (!_EventObjCache.TryGetValue(44, out var value))
			{
				value = new GSDel_RemovePerformerInList();
				(value as GSDel_RemovePerformerInList).EventId = 44;
				(value as GSDel_RemovePerformerInList)._OwnerEventCollectionCS = this;
				_EventObjCache[44] = value;
			}
			return value as GSDel_RemovePerformerInList;
		}
		set
		{
		}
	}

	public GSDel_SetNewConfigDataAsset Evt_BGS_SetNewConfigDataAsset
	{
		get
		{
			if (!_EventObjCache.TryGetValue(45, out var value))
			{
				value = new GSDel_SetNewConfigDataAsset();
				(value as GSDel_SetNewConfigDataAsset).EventId = 45;
				(value as GSDel_SetNewConfigDataAsset)._OwnerEventCollectionCS = this;
				_EventObjCache[45] = value;
			}
			return value as GSDel_SetNewConfigDataAsset;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BGS_Try2RecoverDefaultConfigDataAsset
	{
		get
		{
			if (!_EventObjCache.TryGetValue(46, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 46;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[46] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_RecoverAttackToken Evt_BGS_RecoverAttackToken
	{
		get
		{
			if (!_EventObjCache.TryGetValue(47, out var value))
			{
				value = new GSDel_RecoverAttackToken();
				(value as GSDel_RecoverAttackToken).EventId = 47;
				(value as GSDel_RecoverAttackToken)._OwnerEventCollectionCS = this;
				_EventObjCache[47] = value;
			}
			return value as GSDel_RecoverAttackToken;
		}
		set
		{
		}
	}

	public GSDel_InitiatePriorityActionQue Evt_BGS_InitiatePriorityActionQue
	{
		get
		{
			if (!_EventObjCache.TryGetValue(48, out var value))
			{
				value = new GSDel_InitiatePriorityActionQue();
				(value as GSDel_InitiatePriorityActionQue).EventId = 48;
				(value as GSDel_InitiatePriorityActionQue)._OwnerEventCollectionCS = this;
				_EventObjCache[48] = value;
			}
			return value as GSDel_InitiatePriorityActionQue;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BGS_AddPerformerInfoToList
	{
		get
		{
			if (!_EventObjCache.TryGetValue(49, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 49;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[49] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_Void_Bool Evt_BGS_SetCanTriggerGroupAI
	{
		get
		{
			if (!_EventObjCache.TryGetValue(50, out var value))
			{
				value = new GSDel_Void_Bool();
				(value as GSDel_Void_Bool).EventId = 50;
				(value as GSDel_Void_Bool)._OwnerEventCollectionCS = this;
				_EventObjCache[50] = value;
			}
			return value as GSDel_Void_Bool;
		}
		set
		{
		}
	}

	public GSDel_ChangeHotZonePointSelectionStatus Evt_BGS_ChangeHotZonePointSelectionStatus
	{
		get
		{
			if (!_EventObjCache.TryGetValue(51, out var value))
			{
				value = new GSDel_ChangeHotZonePointSelectionStatus();
				(value as GSDel_ChangeHotZonePointSelectionStatus).EventId = 51;
				(value as GSDel_ChangeHotZonePointSelectionStatus)._OwnerEventCollectionCS = this;
				_EventObjCache[51] = value;
			}
			return value as GSDel_ChangeHotZonePointSelectionStatus;
		}
		set
		{
		}
	}

	public GSDel_NotifyAiBreakInteractAction Evt_BGS_NotifyAiBreakInteractAction
	{
		get
		{
			if (!_EventObjCache.TryGetValue(52, out var value))
			{
				value = new GSDel_NotifyAiBreakInteractAction();
				(value as GSDel_NotifyAiBreakInteractAction).EventId = 52;
				(value as GSDel_NotifyAiBreakInteractAction)._OwnerEventCollectionCS = this;
				_EventObjCache[52] = value;
			}
			return value as GSDel_NotifyAiBreakInteractAction;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_BGS_NotifyTriggerWeakAiInteract
	{
		get
		{
			if (!_EventObjCache.TryGetValue(53, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 53;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[53] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_BGS_MarkGroupCastSkill Evt_BGS_MarkGroupCastSkill
	{
		get
		{
			if (!_EventObjCache.TryGetValue(54, out var value))
			{
				value = new GSDel_BGS_MarkGroupCastSkill();
				(value as GSDel_BGS_MarkGroupCastSkill).EventId = 54;
				(value as GSDel_BGS_MarkGroupCastSkill)._OwnerEventCollectionCS = this;
				_EventObjCache[54] = value;
			}
			return value as GSDel_BGS_MarkGroupCastSkill;
		}
		set
		{
		}
	}

	public GSDel_BGS_StartTortoiseFakeMove Evt_BGS_StartTortoiseFakeMove
	{
		get
		{
			if (!_EventObjCache.TryGetValue(55, out var value))
			{
				value = new GSDel_BGS_StartTortoiseFakeMove();
				(value as GSDel_BGS_StartTortoiseFakeMove).EventId = 55;
				(value as GSDel_BGS_StartTortoiseFakeMove)._OwnerEventCollectionCS = this;
				_EventObjCache[55] = value;
			}
			return value as GSDel_BGS_StartTortoiseFakeMove;
		}
		set
		{
		}
	}

	public GSDel_BGS_Void Evt_BGS_StopTortoiseFakeMove
	{
		get
		{
			if (!_EventObjCache.TryGetValue(56, out var value))
			{
				value = new GSDel_BGS_Void();
				(value as GSDel_BGS_Void).EventId = 56;
				(value as GSDel_BGS_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[56] = value;
			}
			return value as GSDel_BGS_Void;
		}
		set
		{
		}
	}

	public GSDel_BGS_UnitBattleStateUpdate Evt_BGS_UnitBattleStateUpdate
	{
		get
		{
			if (!_EventObjCache.TryGetValue(57, out var value))
			{
				value = new GSDel_BGS_UnitBattleStateUpdate();
				(value as GSDel_BGS_UnitBattleStateUpdate).EventId = 57;
				(value as GSDel_BGS_UnitBattleStateUpdate)._OwnerEventCollectionCS = this;
				_EventObjCache[57] = value;
			}
			return value as GSDel_BGS_UnitBattleStateUpdate;
		}
		set
		{
		}
	}

	public GSDel_BGS_UnitEnterFight Evt_BGS_UnitEnterFight
	{
		get
		{
			if (!_EventObjCache.TryGetValue(58, out var value))
			{
				value = new GSDel_BGS_UnitEnterFight();
				(value as GSDel_BGS_UnitEnterFight).EventId = 58;
				(value as GSDel_BGS_UnitEnterFight)._OwnerEventCollectionCS = this;
				_EventObjCache[58] = value;
			}
			return value as GSDel_BGS_UnitEnterFight;
		}
		set
		{
		}
	}

	public GSDel_BGS_UnitLeaveFight Evt_BGS_UnitLeaveFight
	{
		get
		{
			if (!_EventObjCache.TryGetValue(59, out var value))
			{
				value = new GSDel_BGS_UnitLeaveFight();
				(value as GSDel_BGS_UnitLeaveFight).EventId = 59;
				(value as GSDel_BGS_UnitLeaveFight)._OwnerEventCollectionCS = this;
				_EventObjCache[59] = value;
			}
			return value as GSDel_BGS_UnitLeaveFight;
		}
		set
		{
		}
	}

	public GSDel_BGS_Void Evt_BGS_TortoiseStartRotate
	{
		get
		{
			if (!_EventObjCache.TryGetValue(60, out var value))
			{
				value = new GSDel_BGS_Void();
				(value as GSDel_BGS_Void).EventId = 60;
				(value as GSDel_BGS_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[60] = value;
			}
			return value as GSDel_BGS_Void;
		}
		set
		{
		}
	}

	public GSDel_BGS_Void Evt_BGS_TortoiseEndRotate
	{
		get
		{
			if (!_EventObjCache.TryGetValue(61, out var value))
			{
				value = new GSDel_BGS_Void();
				(value as GSDel_BGS_Void).EventId = 61;
				(value as GSDel_BGS_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[61] = value;
			}
			return value as GSDel_BGS_Void;
		}
		set
		{
		}
	}

	public GSDel_BGS_RegisterSpiderNavMesh Evt_BGS_RegisterSpiderNavMesh
	{
		get
		{
			if (!_EventObjCache.TryGetValue(62, out var value))
			{
				value = new GSDel_BGS_RegisterSpiderNavMesh();
				(value as GSDel_BGS_RegisterSpiderNavMesh).EventId = 62;
				(value as GSDel_BGS_RegisterSpiderNavMesh)._OwnerEventCollectionCS = this;
				_EventObjCache[62] = value;
			}
			return value as GSDel_BGS_RegisterSpiderNavMesh;
		}
		set
		{
		}
	}

	public GSDel_BGS_RegisterSceneInactiveActor Evt_BGS_RegisterSceneInactiveActor
	{
		get
		{
			if (!_EventObjCache.TryGetValue(63, out var value))
			{
				value = new GSDel_BGS_RegisterSceneInactiveActor();
				(value as GSDel_BGS_RegisterSceneInactiveActor).EventId = 63;
				(value as GSDel_BGS_RegisterSceneInactiveActor)._OwnerEventCollectionCS = this;
				_EventObjCache[63] = value;
			}
			return value as GSDel_BGS_RegisterSceneInactiveActor;
		}
		set
		{
		}
	}

	public GSDel_BGS_ReleaseSceneInactiveActor Evt_BGS_ReleaseSceneInactiveActor
	{
		get
		{
			if (!_EventObjCache.TryGetValue(64, out var value))
			{
				value = new GSDel_BGS_ReleaseSceneInactiveActor();
				(value as GSDel_BGS_ReleaseSceneInactiveActor).EventId = 64;
				(value as GSDel_BGS_ReleaseSceneInactiveActor)._OwnerEventCollectionCS = this;
				_EventObjCache[64] = value;
			}
			return value as GSDel_BGS_ReleaseSceneInactiveActor;
		}
		set
		{
		}
	}

	public GSDel_BGS_SetSceneInactiveActorForceActivateTicks Evt_BGS_SetSceneInactiveActorForceActivateTicks
	{
		get
		{
			if (!_EventObjCache.TryGetValue(65, out var value))
			{
				value = new GSDel_BGS_SetSceneInactiveActorForceActivateTicks();
				(value as GSDel_BGS_SetSceneInactiveActorForceActivateTicks).EventId = 65;
				(value as GSDel_BGS_SetSceneInactiveActorForceActivateTicks)._OwnerEventCollectionCS = this;
				_EventObjCache[65] = value;
			}
			return value as GSDel_BGS_SetSceneInactiveActorForceActivateTicks;
		}
		set
		{
		}
	}

	public GSDel_BGS_RegisterRuntimeMeshActor Evt_BGS_RegisterRuntimeMeshActor
	{
		get
		{
			if (!_EventObjCache.TryGetValue(66, out var value))
			{
				value = new GSDel_BGS_RegisterRuntimeMeshActor();
				(value as GSDel_BGS_RegisterRuntimeMeshActor).EventId = 66;
				(value as GSDel_BGS_RegisterRuntimeMeshActor)._OwnerEventCollectionCS = this;
				_EventObjCache[66] = value;
			}
			return value as GSDel_BGS_RegisterRuntimeMeshActor;
		}
		set
		{
		}
	}

	public GSDel_BGS_TrySliceRuntimeActors Evt_BGS_TrySliceRuntimeActors
	{
		get
		{
			if (!_EventObjCache.TryGetValue(67, out var value))
			{
				value = new GSDel_BGS_TrySliceRuntimeActors();
				(value as GSDel_BGS_TrySliceRuntimeActors).EventId = 67;
				(value as GSDel_BGS_TrySliceRuntimeActors)._OwnerEventCollectionCS = this;
				_EventObjCache[67] = value;
			}
			return value as GSDel_BGS_TrySliceRuntimeActors;
		}
		set
		{
		}
	}

	public GSDel_BGS_AddUnitToPatrolGroup Evt_BGS_AddUnitToPatrolGroup
	{
		get
		{
			if (!_EventObjCache.TryGetValue(68, out var value))
			{
				value = new GSDel_BGS_AddUnitToPatrolGroup();
				(value as GSDel_BGS_AddUnitToPatrolGroup).EventId = 68;
				(value as GSDel_BGS_AddUnitToPatrolGroup)._OwnerEventCollectionCS = this;
				_EventObjCache[68] = value;
			}
			return value as GSDel_BGS_AddUnitToPatrolGroup;
		}
		set
		{
		}
	}

	public GSDel_BGS_RemoveUnitFromPatrolGroup Evt_BGS_RemoveUnitFromPatrolGroup
	{
		get
		{
			if (!_EventObjCache.TryGetValue(69, out var value))
			{
				value = new GSDel_BGS_RemoveUnitFromPatrolGroup();
				(value as GSDel_BGS_RemoveUnitFromPatrolGroup).EventId = 69;
				(value as GSDel_BGS_RemoveUnitFromPatrolGroup)._OwnerEventCollectionCS = this;
				_EventObjCache[69] = value;
			}
			return value as GSDel_BGS_RemoveUnitFromPatrolGroup;
		}
		set
		{
		}
	}

	public GSDel_BGS_GroupPatrolLeaderPathMoveComplete Evt_BGS_GroupPatrolLeaderPathMoveComplete
	{
		get
		{
			if (!_EventObjCache.TryGetValue(70, out var value))
			{
				value = new GSDel_BGS_GroupPatrolLeaderPathMoveComplete();
				(value as GSDel_BGS_GroupPatrolLeaderPathMoveComplete).EventId = 70;
				(value as GSDel_BGS_GroupPatrolLeaderPathMoveComplete)._OwnerEventCollectionCS = this;
				_EventObjCache[70] = value;
			}
			return value as GSDel_BGS_GroupPatrolLeaderPathMoveComplete;
		}
		set
		{
		}
	}

	public GSDel_BGS_GroupPatrolWaitPointEnd Evt_BGS_GroupPatrolWaitPointEnd
	{
		get
		{
			if (!_EventObjCache.TryGetValue(71, out var value))
			{
				value = new GSDel_BGS_GroupPatrolWaitPointEnd();
				(value as GSDel_BGS_GroupPatrolWaitPointEnd).EventId = 71;
				(value as GSDel_BGS_GroupPatrolWaitPointEnd)._OwnerEventCollectionCS = this;
				_EventObjCache[71] = value;
			}
			return value as GSDel_BGS_GroupPatrolWaitPointEnd;
		}
		set
		{
		}
	}

	public GSDel_BGS_PlayerEnterBgmVolume Evt_BGS_PlayerEnterBgmVolume
	{
		get
		{
			if (!_EventObjCache.TryGetValue(72, out var value))
			{
				value = new GSDel_BGS_PlayerEnterBgmVolume();
				(value as GSDel_BGS_PlayerEnterBgmVolume).EventId = 72;
				(value as GSDel_BGS_PlayerEnterBgmVolume)._OwnerEventCollectionCS = this;
				_EventObjCache[72] = value;
			}
			return value as GSDel_BGS_PlayerEnterBgmVolume;
		}
		set
		{
		}
	}

	public GSDel_BGS_PlayerLeaveBgmVolume Evt_BGS_PlayerLeaveBgmVolume
	{
		get
		{
			if (!_EventObjCache.TryGetValue(73, out var value))
			{
				value = new GSDel_BGS_PlayerLeaveBgmVolume();
				(value as GSDel_BGS_PlayerLeaveBgmVolume).EventId = 73;
				(value as GSDel_BGS_PlayerLeaveBgmVolume)._OwnerEventCollectionCS = this;
				_EventObjCache[73] = value;
			}
			return value as GSDel_BGS_PlayerLeaveBgmVolume;
		}
		set
		{
		}
	}

	public GSDel_BGS_BGMVolumeInfoUpdate Evt_BGS_BGMVolumeInfoUpdate
	{
		get
		{
			if (!_EventObjCache.TryGetValue(74, out var value))
			{
				value = new GSDel_BGS_BGMVolumeInfoUpdate();
				(value as GSDel_BGS_BGMVolumeInfoUpdate).EventId = 74;
				(value as GSDel_BGS_BGMVolumeInfoUpdate)._OwnerEventCollectionCS = this;
				_EventObjCache[74] = value;
			}
			return value as GSDel_BGS_BGMVolumeInfoUpdate;
		}
		set
		{
		}
	}

	public GSDel_BGS_TryPlayBattleBGM Evt_BGS_TryPlayBattleBGM
	{
		get
		{
			if (!_EventObjCache.TryGetValue(75, out var value))
			{
				value = new GSDel_BGS_TryPlayBattleBGM();
				(value as GSDel_BGS_TryPlayBattleBGM).EventId = 75;
				(value as GSDel_BGS_TryPlayBattleBGM)._OwnerEventCollectionCS = this;
				_EventObjCache[75] = value;
			}
			return value as GSDel_BGS_TryPlayBattleBGM;
		}
		set
		{
		}
	}

	public GSDel_BGS_TryStopBattleBGM Evt_BGS_TryStopBattleBGM
	{
		get
		{
			if (!_EventObjCache.TryGetValue(76, out var value))
			{
				value = new GSDel_BGS_TryStopBattleBGM();
				(value as GSDel_BGS_TryStopBattleBGM).EventId = 76;
				(value as GSDel_BGS_TryStopBattleBGM)._OwnerEventCollectionCS = this;
				_EventObjCache[76] = value;
			}
			return value as GSDel_BGS_TryStopBattleBGM;
		}
		set
		{
		}
	}

	public GSDel_BGS_SetBattleBgmCanTick Evt_BGS_SetBattleBgmCanTick
	{
		get
		{
			if (!_EventObjCache.TryGetValue(77, out var value))
			{
				value = new GSDel_BGS_SetBattleBgmCanTick();
				(value as GSDel_BGS_SetBattleBgmCanTick).EventId = 77;
				(value as GSDel_BGS_SetBattleBgmCanTick)._OwnerEventCollectionCS = this;
				_EventObjCache[77] = value;
			}
			return value as GSDel_BGS_SetBattleBgmCanTick;
		}
		set
		{
		}
	}

	public GSDel_BGS_PauseDefaultBGM Evt_BGS_PauseDefaultBGM
	{
		get
		{
			if (!_EventObjCache.TryGetValue(78, out var value))
			{
				value = new GSDel_BGS_PauseDefaultBGM();
				(value as GSDel_BGS_PauseDefaultBGM).EventId = 78;
				(value as GSDel_BGS_PauseDefaultBGM)._OwnerEventCollectionCS = this;
				_EventObjCache[78] = value;
			}
			return value as GSDel_BGS_PauseDefaultBGM;
		}
		set
		{
		}
	}

	public GSDel_BGS_ResumeDefaultBGM Evt_BGS_ResumeDefaultBGM
	{
		get
		{
			if (!_EventObjCache.TryGetValue(79, out var value))
			{
				value = new GSDel_BGS_ResumeDefaultBGM();
				(value as GSDel_BGS_ResumeDefaultBGM).EventId = 79;
				(value as GSDel_BGS_ResumeDefaultBGM)._OwnerEventCollectionCS = this;
				_EventObjCache[79] = value;
			}
			return value as GSDel_BGS_ResumeDefaultBGM;
		}
		set
		{
		}
	}

	public GSDel_BGS_TryPlayTransMusic Evt_BGS_TryPlayTransMusic
	{
		get
		{
			if (!_EventObjCache.TryGetValue(80, out var value))
			{
				value = new GSDel_BGS_TryPlayTransMusic();
				(value as GSDel_BGS_TryPlayTransMusic).EventId = 80;
				(value as GSDel_BGS_TryPlayTransMusic)._OwnerEventCollectionCS = this;
				_EventObjCache[80] = value;
			}
			return value as GSDel_BGS_TryPlayTransMusic;
		}
		set
		{
		}
	}

	public GSDel_BGS_TryStopTransMusic Evt_BGS_TryStopTransMusic
	{
		get
		{
			if (!_EventObjCache.TryGetValue(81, out var value))
			{
				value = new GSDel_BGS_TryStopTransMusic();
				(value as GSDel_BGS_TryStopTransMusic).EventId = 81;
				(value as GSDel_BGS_TryStopTransMusic)._OwnerEventCollectionCS = this;
				_EventObjCache[81] = value;
			}
			return value as GSDel_BGS_TryStopTransMusic;
		}
		set
		{
		}
	}

	public GSDel_BGS_OnLevelsStateRequestBatchFinished Evt_BGS_OnLevelsStateRequestBatchFinished
	{
		get
		{
			if (!_EventObjCache.TryGetValue(82, out var value))
			{
				value = new GSDel_BGS_OnLevelsStateRequestBatchFinished();
				(value as GSDel_BGS_OnLevelsStateRequestBatchFinished).EventId = 82;
				(value as GSDel_BGS_OnLevelsStateRequestBatchFinished)._OwnerEventCollectionCS = this;
				_EventObjCache[82] = value;
			}
			return value as GSDel_BGS_OnLevelsStateRequestBatchFinished;
		}
		set
		{
		}
	}

	public GSDel_BGS_SetEnvironmentSurfaceVolumeEnabled Evt_BGS_SetEnvironmentSurfaceVolumeEnabled
	{
		get
		{
			if (!_EventObjCache.TryGetValue(83, out var value))
			{
				value = new GSDel_BGS_SetEnvironmentSurfaceVolumeEnabled();
				(value as GSDel_BGS_SetEnvironmentSurfaceVolumeEnabled).EventId = 83;
				(value as GSDel_BGS_SetEnvironmentSurfaceVolumeEnabled)._OwnerEventCollectionCS = this;
				_EventObjCache[83] = value;
			}
			return value as GSDel_BGS_SetEnvironmentSurfaceVolumeEnabled;
		}
		set
		{
		}
	}

	public GSDel_BGS_TriggerTransEffect Evt_TriggerTransEffect
	{
		get
		{
			if (!_EventObjCache.TryGetValue(84, out var value))
			{
				value = new GSDel_BGS_TriggerTransEffect();
				(value as GSDel_BGS_TriggerTransEffect).EventId = 84;
				(value as GSDel_BGS_TriggerTransEffect)._OwnerEventCollectionCS = this;
				_EventObjCache[84] = value;
			}
			return value as GSDel_BGS_TriggerTransEffect;
		}
		set
		{
		}
	}

	public GSDel_BGS_TransEffectUnitChange Evt_TransEffectUnitChange
	{
		get
		{
			if (!_EventObjCache.TryGetValue(85, out var value))
			{
				value = new GSDel_BGS_TransEffectUnitChange();
				(value as GSDel_BGS_TransEffectUnitChange).EventId = 85;
				(value as GSDel_BGS_TransEffectUnitChange)._OwnerEventCollectionCS = this;
				_EventObjCache[85] = value;
			}
			return value as GSDel_BGS_TransEffectUnitChange;
		}
		set
		{
		}
	}

	public GSDel_BGS_SendZBBCreationInfo Evt_SendZBBCreationInfo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(86, out var value))
			{
				value = new GSDel_BGS_SendZBBCreationInfo();
				(value as GSDel_BGS_SendZBBCreationInfo).EventId = 86;
				(value as GSDel_BGS_SendZBBCreationInfo)._OwnerEventCollectionCS = this;
				_EventObjCache[86] = value;
			}
			return value as GSDel_BGS_SendZBBCreationInfo;
		}
		set
		{
		}
	}

	public GSDel_BGS_OnSpawnDropItem Evt_BGS_OnSpawnDropItem
	{
		get
		{
			if (!_EventObjCache.TryGetValue(87, out var value))
			{
				value = new GSDel_BGS_OnSpawnDropItem();
				(value as GSDel_BGS_OnSpawnDropItem).EventId = 87;
				(value as GSDel_BGS_OnSpawnDropItem)._OwnerEventCollectionCS = this;
				_EventObjCache[87] = value;
			}
			return value as GSDel_BGS_OnSpawnDropItem;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_OnCollectionPendingSoul
	{
		get
		{
			if (!_EventObjCache.TryGetValue(88, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 88;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[88] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_BGS_Void Evt_BGS_SwitchHero
	{
		get
		{
			if (!_EventObjCache.TryGetValue(89, out var value))
			{
				value = new GSDel_BGS_Void();
				(value as GSDel_BGS_Void).EventId = 89;
				(value as GSDel_BGS_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[89] = value;
			}
			return value as GSDel_BGS_Void;
		}
		set
		{
		}
	}

	public GSDel_BGS_Void Evt_BGS_PlayerInitComplete
	{
		get
		{
			if (!_EventObjCache.TryGetValue(90, out var value))
			{
				value = new GSDel_BGS_Void();
				(value as GSDel_BGS_Void).EventId = 90;
				(value as GSDel_BGS_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[90] = value;
			}
			return value as GSDel_BGS_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BGS_SeqPlayEnd
	{
		get
		{
			if (!_EventObjCache.TryGetValue(91, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 91;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[91] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_BGS_Int Evt_BGS_Meditation
	{
		get
		{
			if (!_EventObjCache.TryGetValue(92, out var value))
			{
				value = new GSDel_BGS_Int();
				(value as GSDel_BGS_Int).EventId = 92;
				(value as GSDel_BGS_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[92] = value;
			}
			return value as GSDel_BGS_Int;
		}
		set
		{
		}
	}

	public GSDel_BGS_Int Evt_BGS_ShowMeditationAward
	{
		get
		{
			if (!_EventObjCache.TryGetValue(93, out var value))
			{
				value = new GSDel_BGS_Int();
				(value as GSDel_BGS_Int).EventId = 93;
				(value as GSDel_BGS_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[93] = value;
			}
			return value as GSDel_BGS_Int;
		}
		set
		{
		}
	}

	public GSDel_BGS_AttrInsuff Evt_BGS_AttrInsuff
	{
		get
		{
			if (!_EventObjCache.TryGetValue(94, out var value))
			{
				value = new GSDel_BGS_AttrInsuff();
				(value as GSDel_BGS_AttrInsuff).EventId = 94;
				(value as GSDel_BGS_AttrInsuff)._OwnerEventCollectionCS = this;
				_EventObjCache[94] = value;
			}
			return value as GSDel_BGS_AttrInsuff;
		}
		set
		{
		}
	}

	public GSDel_BGS_Int Evt_BGS_ShowRebirthPointUI
	{
		get
		{
			if (!_EventObjCache.TryGetValue(95, out var value))
			{
				value = new GSDel_BGS_Int();
				(value as GSDel_BGS_Int).EventId = 95;
				(value as GSDel_BGS_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[95] = value;
			}
			return value as GSDel_BGS_Int;
		}
		set
		{
		}
	}

	public GSDel_BGS_Void Evt_BGS_HideRebirthPointUI
	{
		get
		{
			if (!_EventObjCache.TryGetValue(96, out var value))
			{
				value = new GSDel_BGS_Void();
				(value as GSDel_BGS_Void).EventId = 96;
				(value as GSDel_BGS_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[96] = value;
			}
			return value as GSDel_BGS_Void;
		}
		set
		{
		}
	}

	public GSDel_BGS_BoolInt_ICB Evt_BGS_TriggerShortcut
	{
		get
		{
			if (!_EventObjCache.TryGetValue(97, out var value))
			{
				value = new GSDel_BGS_BoolInt_ICB(Evt_BGS_TriggerShortcut_Invoke, Evt_BGS_TriggerShortcut_DelChg);
				(value as GSDel_BGS_BoolInt_ICB).EventId = 97;
				(value as GSDel_BGS_BoolInt_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[97] = value;
			}
			return value as GSDel_BGS_BoolInt_ICB;
		}
		set
		{
		}
	}

	public GSDel_BGS_Void Evt_BGS_GMInitTeam
	{
		get
		{
			if (!_EventObjCache.TryGetValue(98, out var value))
			{
				value = new GSDel_BGS_Void();
				(value as GSDel_BGS_Void).EventId = 98;
				(value as GSDel_BGS_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[98] = value;
			}
			return value as GSDel_BGS_Void;
		}
		set
		{
		}
	}

	public GSDel_BGS_Void Evt_BGS_GMInitTopBar
	{
		get
		{
			if (!_EventObjCache.TryGetValue(99, out var value))
			{
				value = new GSDel_BGS_Void();
				(value as GSDel_BGS_Void).EventId = 99;
				(value as GSDel_BGS_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[99] = value;
			}
			return value as GSDel_BGS_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_BGS_ResetActorDestroy
	{
		get
		{
			if (!_EventObjCache.TryGetValue(100, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 100;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[100] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_EnterSeqMove
	{
		get
		{
			if (!_EventObjCache.TryGetValue(101, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 101;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[101] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_LeftSeqMove
	{
		get
		{
			if (!_EventObjCache.TryGetValue(102, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 102;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[102] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_BGS_Int Evt_BGS_TriggerSaveData
	{
		get
		{
			if (!_EventObjCache.TryGetValue(103, out var value))
			{
				value = new GSDel_BGS_Int();
				(value as GSDel_BGS_Int).EventId = 103;
				(value as GSDel_BGS_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[103] = value;
			}
			return value as GSDel_BGS_Int;
		}
		set
		{
		}
	}

	public GSDel_RequestDropSpecialItem Evt_RequestDropSpecialItem
	{
		get
		{
			if (!_EventObjCache.TryGetValue(104, out var value))
			{
				value = new GSDel_RequestDropSpecialItem();
				(value as GSDel_RequestDropSpecialItem).EventId = 104;
				(value as GSDel_RequestDropSpecialItem)._OwnerEventCollectionCS = this;
				_EventObjCache[104] = value;
			}
			return value as GSDel_RequestDropSpecialItem;
		}
		set
		{
		}
	}

	public GSDel_RegisterFamilyTree Evt_RegisterFamilyTree
	{
		get
		{
			if (!_EventObjCache.TryGetValue(105, out var value))
			{
				value = new GSDel_RegisterFamilyTree();
				(value as GSDel_RegisterFamilyTree).EventId = 105;
				(value as GSDel_RegisterFamilyTree)._OwnerEventCollectionCS = this;
				_EventObjCache[105] = value;
			}
			return value as GSDel_RegisterFamilyTree;
		}
		set
		{
		}
	}

	public GSDel_String_Actor Evt_OnTriggerWakeBroadCastToFamily
	{
		get
		{
			if (!_EventObjCache.TryGetValue(106, out var value))
			{
				value = new GSDel_String_Actor();
				(value as GSDel_String_Actor).EventId = 106;
				(value as GSDel_String_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[106] = value;
			}
			return value as GSDel_String_Actor;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_InteractGroup_Refresh
	{
		get
		{
			if (!_EventObjCache.TryGetValue(107, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 107;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[107] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_StringGameplayTag Evt_BGS_RecordLastNotifyGraph
	{
		get
		{
			if (!_EventObjCache.TryGetValue(108, out var value))
			{
				value = new GSDel_Void_StringGameplayTag();
				(value as GSDel_Void_StringGameplayTag).EventId = 108;
				(value as GSDel_Void_StringGameplayTag)._OwnerEventCollectionCS = this;
				_EventObjCache[108] = value;
			}
			return value as GSDel_Void_StringGameplayTag;
		}
		set
		{
		}
	}

	public GSDel_Void_StringGameplayTag Evt_BGS_NotifyGraph
	{
		get
		{
			if (!_EventObjCache.TryGetValue(109, out var value))
			{
				value = new GSDel_Void_StringGameplayTag();
				(value as GSDel_Void_StringGameplayTag).EventId = 109;
				(value as GSDel_Void_StringGameplayTag)._OwnerEventCollectionCS = this;
				_EventObjCache[109] = value;
			}
			return value as GSDel_Void_StringGameplayTag;
		}
		set
		{
		}
	}

	public GSDel_Void_IObserveNodeInstanceString Evt_BGS_StartObserve
	{
		get
		{
			if (!_EventObjCache.TryGetValue(110, out var value))
			{
				value = new GSDel_Void_IObserveNodeInstanceString();
				(value as GSDel_Void_IObserveNodeInstanceString).EventId = 110;
				(value as GSDel_Void_IObserveNodeInstanceString)._OwnerEventCollectionCS = this;
				_EventObjCache[110] = value;
			}
			return value as GSDel_Void_IObserveNodeInstanceString;
		}
		set
		{
		}
	}

	public GSDel_Void_IObserveNodeInstance Evt_BGS_StopObserve
	{
		get
		{
			if (!_EventObjCache.TryGetValue(111, out var value))
			{
				value = new GSDel_Void_IObserveNodeInstance();
				(value as GSDel_Void_IObserveNodeInstance).EventId = 111;
				(value as GSDel_Void_IObserveNodeInstance)._OwnerEventCollectionCS = this;
				_EventObjCache[111] = value;
			}
			return value as GSDel_Void_IObserveNodeInstance;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_SerializeQuestArchiveData
	{
		get
		{
			if (!_EventObjCache.TryGetValue(112, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 112;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[112] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_Bool Evt_BGS_PauseQuestSystem
	{
		get
		{
			if (!_EventObjCache.TryGetValue(113, out var value))
			{
				value = new GSDel_Void_Bool();
				(value as GSDel_Void_Bool).EventId = 113;
				(value as GSDel_Void_Bool)._OwnerEventCollectionCS = this;
				_EventObjCache[113] = value;
			}
			return value as GSDel_Void_Bool;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_BGS_SwitchRootQuestGraph
	{
		get
		{
			if (!_EventObjCache.TryGetValue(114, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 114;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[114] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_BattleMonsterData Evt_BGS_SetOSSAiPartnerInfo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(115, out var value))
			{
				value = new GSDel_BattleMonsterData();
				(value as GSDel_BattleMonsterData).EventId = 115;
				(value as GSDel_BattleMonsterData)._OwnerEventCollectionCS = this;
				_EventObjCache[115] = value;
			}
			return value as GSDel_BattleMonsterData;
		}
		set
		{
		}
	}

	public GSDel_BattleMonsterData Evt_BGS_SetOSSMonstInfo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(116, out var value))
			{
				value = new GSDel_BattleMonsterData();
				(value as GSDel_BattleMonsterData).EventId = 116;
				(value as GSDel_BattleMonsterData)._OwnerEventCollectionCS = this;
				_EventObjCache[116] = value;
			}
			return value as GSDel_BattleMonsterData;
		}
		set
		{
		}
	}

	public GSDel_Void_IntActor Evt_BGS_OnPlayerIntoBattle
	{
		get
		{
			if (!_EventObjCache.TryGetValue(117, out var value))
			{
				value = new GSDel_Void_IntActor();
				(value as GSDel_Void_IntActor).EventId = 117;
				(value as GSDel_Void_IntActor)._OwnerEventCollectionCS = this;
				_EventObjCache[117] = value;
			}
			return value as GSDel_Void_IntActor;
		}
		set
		{
		}
	}

	public GSDel_OnPlayerLeaveBattle Evt_BGS_OnPlayerLeaveBattle
	{
		get
		{
			if (!_EventObjCache.TryGetValue(118, out var value))
			{
				value = new GSDel_OnPlayerLeaveBattle();
				(value as GSDel_OnPlayerLeaveBattle).EventId = 118;
				(value as GSDel_OnPlayerLeaveBattle)._OwnerEventCollectionCS = this;
				_EventObjCache[118] = value;
			}
			return value as GSDel_OnPlayerLeaveBattle;
		}
		set
		{
		}
	}

	public GSDel_OnTaskStageChange Evt_BGS_OnTaskStageChange
	{
		get
		{
			if (!_EventObjCache.TryGetValue(119, out var value))
			{
				value = new GSDel_OnTaskStageChange();
				(value as GSDel_OnTaskStageChange).EventId = 119;
				(value as GSDel_OnTaskStageChange)._OwnerEventCollectionCS = this;
				_EventObjCache[119] = value;
			}
			return value as GSDel_OnTaskStageChange;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_Demo820OSSEndLevel
	{
		get
		{
			if (!_EventObjCache.TryGetValue(120, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 120;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[120] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_EarlyTerminateAiUnitBattleRecord
	{
		get
		{
			if (!_EventObjCache.TryGetValue(121, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 121;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[121] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_LocalPlayerDead_ForOSS
	{
		get
		{
			if (!_EventObjCache.TryGetValue(122, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 122;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[122] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_RegisterTamer Evt_RegisterTamer
	{
		get
		{
			if (!_EventObjCache.TryGetValue(123, out var value))
			{
				value = new GSDel_RegisterTamer();
				(value as GSDel_RegisterTamer).EventId = 123;
				(value as GSDel_RegisterTamer)._OwnerEventCollectionCS = this;
				_EventObjCache[123] = value;
			}
			return value as GSDel_RegisterTamer;
		}
		set
		{
		}
	}

	public GSDel_Void_Tamer Evt_UnregisterTamer
	{
		get
		{
			if (!_EventObjCache.TryGetValue(124, out var value))
			{
				value = new GSDel_Void_Tamer();
				(value as GSDel_Void_Tamer).EventId = 124;
				(value as GSDel_Void_Tamer)._OwnerEventCollectionCS = this;
				_EventObjCache[124] = value;
			}
			return value as GSDel_Void_Tamer;
		}
		set
		{
		}
	}

	public GSDel_TamerPhaseChanged Evt_TamerPhaseChanged
	{
		get
		{
			if (!_EventObjCache.TryGetValue(125, out var value))
			{
				value = new GSDel_TamerPhaseChanged();
				(value as GSDel_TamerPhaseChanged).EventId = 125;
				(value as GSDel_TamerPhaseChanged)._OwnerEventCollectionCS = this;
				_EventObjCache[125] = value;
			}
			return value as GSDel_TamerPhaseChanged;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_NotifyTamerSpawnUnit
	{
		get
		{
			if (!_EventObjCache.TryGetValue(126, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 126;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[126] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_RequestDestroyUnit
	{
		get
		{
			if (!_EventObjCache.TryGetValue(127, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 127;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[127] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void_Tamer Evt_MarkTamerNeverSpawn
	{
		get
		{
			if (!_EventObjCache.TryGetValue(128, out var value))
			{
				value = new GSDel_Void_Tamer();
				(value as GSDel_Void_Tamer).EventId = 128;
				(value as GSDel_Void_Tamer)._OwnerEventCollectionCS = this;
				_EventObjCache[128] = value;
			}
			return value as GSDel_Void_Tamer;
		}
		set
		{
		}
	}

	public GSDel_Void_Tamer Evt_UnMarkTamerNeverSpawn
	{
		get
		{
			if (!_EventObjCache.TryGetValue(129, out var value))
			{
				value = new GSDel_Void_Tamer();
				(value as GSDel_Void_Tamer).EventId = 129;
				(value as GSDel_Void_Tamer)._OwnerEventCollectionCS = this;
				_EventObjCache[129] = value;
			}
			return value as GSDel_Void_Tamer;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_MarkTamerAlwaysSpawn
	{
		get
		{
			if (!_EventObjCache.TryGetValue(130, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 130;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[130] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_UnMarkTamerAlwaysSpawn
	{
		get
		{
			if (!_EventObjCache.TryGetValue(131, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 131;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[131] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_MarkTamerBlockingSpawn
	{
		get
		{
			if (!_EventObjCache.TryGetValue(132, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 132;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[132] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_UnMarkTamerBlockingSpawn
	{
		get
		{
			if (!_EventObjCache.TryGetValue(133, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 133;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[133] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_TamerBlockingSpawnImmediately
	{
		get
		{
			if (!_EventObjCache.TryGetValue(134, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 134;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[134] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void_StringList Evt_EnableTamerOnlyMode
	{
		get
		{
			if (!_EventObjCache.TryGetValue(135, out var value))
			{
				value = new GSDel_Void_StringList();
				(value as GSDel_Void_StringList).EventId = 135;
				(value as GSDel_Void_StringList)._OwnerEventCollectionCS = this;
				_EventObjCache[135] = value;
			}
			return value as GSDel_Void_StringList;
		}
		set
		{
		}
	}

	public GSDel_Void_StringList Evt_DisableTamerOnlyMode
	{
		get
		{
			if (!_EventObjCache.TryGetValue(136, out var value))
			{
				value = new GSDel_Void_StringList();
				(value as GSDel_Void_StringList).EventId = 136;
				(value as GSDel_Void_StringList)._OwnerEventCollectionCS = this;
				_EventObjCache[136] = value;
			}
			return value as GSDel_Void_StringList;
		}
		set
		{
		}
	}

	public GSDel_Void_ResetActorReason Evt_TriggerResetAllTamers
	{
		get
		{
			if (!_EventObjCache.TryGetValue(137, out var value))
			{
				value = new GSDel_Void_ResetActorReason();
				(value as GSDel_Void_ResetActorReason).EventId = 137;
				(value as GSDel_Void_ResetActorReason)._OwnerEventCollectionCS = this;
				_EventObjCache[137] = value;
			}
			return value as GSDel_Void_ResetActorReason;
		}
		set
		{
		}
	}

	public GSDel_Void_Bool Evt_EnableTamerBack2Load
	{
		get
		{
			if (!_EventObjCache.TryGetValue(138, out var value))
			{
				value = new GSDel_Void_Bool();
				(value as GSDel_Void_Bool).EventId = 138;
				(value as GSDel_Void_Bool)._OwnerEventCollectionCS = this;
				_EventObjCache[138] = value;
			}
			return value as GSDel_Void_Bool;
		}
		set
		{
		}
	}

	public GSDel_UnMarkSocketTamerNeverSpawn Evt_UnMarkSocketTamerNeverSpawn
	{
		get
		{
			if (!_EventObjCache.TryGetValue(139, out var value))
			{
				value = new GSDel_UnMarkSocketTamerNeverSpawn();
				(value as GSDel_UnMarkSocketTamerNeverSpawn).EventId = 139;
				(value as GSDel_UnMarkSocketTamerNeverSpawn)._OwnerEventCollectionCS = this;
				_EventObjCache[139] = value;
			}
			return value as GSDel_UnMarkSocketTamerNeverSpawn;
		}
		set
		{
		}
	}

	public GSDel_Void_SetTamerStrategyArea Evt_SetTamerStrategyArea
	{
		get
		{
			if (!_EventObjCache.TryGetValue(140, out var value))
			{
				value = new GSDel_Void_SetTamerStrategyArea();
				(value as GSDel_Void_SetTamerStrategyArea).EventId = 140;
				(value as GSDel_Void_SetTamerStrategyArea)._OwnerEventCollectionCS = this;
				_EventObjCache[140] = value;
			}
			return value as GSDel_Void_SetTamerStrategyArea;
		}
		set
		{
		}
	}

	public GSDel_Void_Bool Evt_SetBossRushSpawnUnitAllowable
	{
		get
		{
			if (!_EventObjCache.TryGetValue(141, out var value))
			{
				value = new GSDel_Void_Bool();
				(value as GSDel_Void_Bool).EventId = 141;
				(value as GSDel_Void_Bool)._OwnerEventCollectionCS = this;
				_EventObjCache[141] = value;
			}
			return value as GSDel_Void_Bool;
		}
		set
		{
		}
	}

	public GSDel_Void_SummonRequest Evt_RequestSummonSvr
	{
		get
		{
			if (!_EventObjCache.TryGetValue(142, out var value))
			{
				value = new GSDel_Void_SummonRequest();
				(value as GSDel_Void_SummonRequest).EventId = 142;
				(value as GSDel_Void_SummonRequest)._OwnerEventCollectionCS = this;
				_EventObjCache[142] = value;
			}
			return value as GSDel_Void_SummonRequest;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_ClearAllSummon
	{
		get
		{
			if (!_EventObjCache.TryGetValue(143, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 143;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[143] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_ServantInstance_ICB Evt_RegisterServantSvr
	{
		get
		{
			if (!_EventObjCache.TryGetValue(144, out var value))
			{
				value = new GSDel_Void_ServantInstance_ICB(Evt_RegisterServantSvr_Invoke, Evt_RegisterServantSvr_DelChg);
				(value as GSDel_Void_ServantInstance_ICB).EventId = 144;
				(value as GSDel_Void_ServantInstance_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[144] = value;
			}
			return value as GSDel_Void_ServantInstance_ICB;
		}
		set
		{
		}
	}

	public GSDel_Void_ServantReq Evt_SendServantReq
	{
		get
		{
			if (!_EventObjCache.TryGetValue(145, out var value))
			{
				value = new GSDel_Void_ServantReq();
				(value as GSDel_Void_ServantReq).EventId = 145;
				(value as GSDel_Void_ServantReq)._OwnerEventCollectionCS = this;
				_EventObjCache[145] = value;
			}
			return value as GSDel_Void_ServantReq;
		}
		set
		{
		}
	}

	public GSDel_Void_ServantReq Evt_NotifyReceiveServantReq
	{
		get
		{
			if (!_EventObjCache.TryGetValue(146, out var value))
			{
				value = new GSDel_Void_ServantReq();
				(value as GSDel_Void_ServantReq).EventId = 146;
				(value as GSDel_Void_ServantReq)._OwnerEventCollectionCS = this;
				_EventObjCache[146] = value;
			}
			return value as GSDel_Void_ServantReq;
		}
		set
		{
		}
	}

	public GSDel_Void_FNameFNameFloat Evt_RequestSetGlobalFXFloatParam
	{
		get
		{
			if (!_EventObjCache.TryGetValue(147, out var value))
			{
				value = new GSDel_Void_FNameFNameFloat();
				(value as GSDel_Void_FNameFNameFloat).EventId = 147;
				(value as GSDel_Void_FNameFNameFloat)._OwnerEventCollectionCS = this;
				_EventObjCache[147] = value;
			}
			return value as GSDel_Void_FNameFNameFloat;
		}
		set
		{
		}
	}

	public GSDel_Int_FNameFNameVector Evt_RequestAddGlobalFXVectorParam
	{
		get
		{
			if (!_EventObjCache.TryGetValue(148, out var value))
			{
				value = new GSDel_Int_FNameFNameVector();
				(value as GSDel_Int_FNameFNameVector).EventId = 148;
				(value as GSDel_Int_FNameFNameVector)._OwnerEventCollectionCS = this;
				_EventObjCache[148] = value;
			}
			return value as GSDel_Int_FNameFNameVector;
		}
		set
		{
		}
	}

	public GSDel_Void_FNameFNameInt Evt_RequestRemoveGlobalFXVectorParam
	{
		get
		{
			if (!_EventObjCache.TryGetValue(149, out var value))
			{
				value = new GSDel_Void_FNameFNameInt();
				(value as GSDel_Void_FNameFNameInt).EventId = 149;
				(value as GSDel_Void_FNameFNameInt)._OwnerEventCollectionCS = this;
				_EventObjCache[149] = value;
			}
			return value as GSDel_Void_FNameFNameInt;
		}
		set
		{
		}
	}

	public GSDel_Void_FNameActorFloatVector Evt_AddMFSphereInfo2GlobalFX
	{
		get
		{
			if (!_EventObjCache.TryGetValue(150, out var value))
			{
				value = new GSDel_Void_FNameActorFloatVector();
				(value as GSDel_Void_FNameActorFloatVector).EventId = 150;
				(value as GSDel_Void_FNameActorFloatVector)._OwnerEventCollectionCS = this;
				_EventObjCache[150] = value;
			}
			return value as GSDel_Void_FNameActorFloatVector;
		}
		set
		{
		}
	}

	public GSDel_Void_FNameActor Evt_RemoveMFSphereInfo2GlobalFX
	{
		get
		{
			if (!_EventObjCache.TryGetValue(151, out var value))
			{
				value = new GSDel_Void_FNameActor();
				(value as GSDel_Void_FNameActor).EventId = 151;
				(value as GSDel_Void_FNameActor)._OwnerEventCollectionCS = this;
				_EventObjCache[151] = value;
			}
			return value as GSDel_Void_FNameActor;
		}
		set
		{
		}
	}

	public GSDel_Void_FNameActorFloatVector Evt_AddMFAvoidanceSphereInfo2GlobalFX
	{
		get
		{
			if (!_EventObjCache.TryGetValue(152, out var value))
			{
				value = new GSDel_Void_FNameActorFloatVector();
				(value as GSDel_Void_FNameActorFloatVector).EventId = 152;
				(value as GSDel_Void_FNameActorFloatVector)._OwnerEventCollectionCS = this;
				_EventObjCache[152] = value;
			}
			return value as GSDel_Void_FNameActorFloatVector;
		}
		set
		{
		}
	}

	public GSDel_Void_FNameActor Evt_RemoveMFAvoidanceSphereInfo2GlobalFX
	{
		get
		{
			if (!_EventObjCache.TryGetValue(153, out var value))
			{
				value = new GSDel_Void_FNameActor();
				(value as GSDel_Void_FNameActor).EventId = 153;
				(value as GSDel_Void_FNameActor)._OwnerEventCollectionCS = this;
				_EventObjCache[153] = value;
			}
			return value as GSDel_Void_FNameActor;
		}
		set
		{
		}
	}

	public GSDel_Void_FNameActorVector Evt_AddOrUpdateBulletPosition2GlobalFX
	{
		get
		{
			if (!_EventObjCache.TryGetValue(154, out var value))
			{
				value = new GSDel_Void_FNameActorVector();
				(value as GSDel_Void_FNameActorVector).EventId = 154;
				(value as GSDel_Void_FNameActorVector)._OwnerEventCollectionCS = this;
				_EventObjCache[154] = value;
			}
			return value as GSDel_Void_FNameActorVector;
		}
		set
		{
		}
	}

	public GSDel_Void_FNameActor Evt_RemoveBulletPosition2GlobalFX
	{
		get
		{
			if (!_EventObjCache.TryGetValue(155, out var value))
			{
				value = new GSDel_Void_FNameActor();
				(value as GSDel_Void_FNameActor).EventId = 155;
				(value as GSDel_Void_FNameActor)._OwnerEventCollectionCS = this;
				_EventObjCache[155] = value;
			}
			return value as GSDel_Void_FNameActor;
		}
		set
		{
		}
	}

	public GSDel_StreamingLevelStateChanged Evt_UpdateStreamingLevelState
	{
		get
		{
			if (!_EventObjCache.TryGetValue(156, out var value))
			{
				value = new GSDel_StreamingLevelStateChanged();
				(value as GSDel_StreamingLevelStateChanged).EventId = 156;
				(value as GSDel_StreamingLevelStateChanged)._OwnerEventCollectionCS = this;
				_EventObjCache[156] = value;
			}
			return value as GSDel_StreamingLevelStateChanged;
		}
		set
		{
		}
	}

	public GSDel_Void_IntAction Evt_PreviewMovie
	{
		get
		{
			if (!_EventObjCache.TryGetValue(157, out var value))
			{
				value = new GSDel_Void_IntAction();
				(value as GSDel_Void_IntAction).EventId = 157;
				(value as GSDel_Void_IntAction)._OwnerEventCollectionCS = this;
				_EventObjCache[157] = value;
			}
			return value as GSDel_Void_IntAction;
		}
		set
		{
		}
	}

	public GSDel_Void_PlayMovieInstance Evt_PlayMovieInstance
	{
		get
		{
			if (!_EventObjCache.TryGetValue(158, out var value))
			{
				value = new GSDel_Void_PlayMovieInstance();
				(value as GSDel_Void_PlayMovieInstance).EventId = 158;
				(value as GSDel_Void_PlayMovieInstance)._OwnerEventCollectionCS = this;
				_EventObjCache[158] = value;
			}
			return value as GSDel_Void_PlayMovieInstance;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_OnSequenceFinished
	{
		get
		{
			if (!_EventObjCache.TryGetValue(159, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 159;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[159] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_IntInt Evt_MovieInstanceFinish
	{
		get
		{
			if (!_EventObjCache.TryGetValue(160, out var value))
			{
				value = new GSDel_Void_IntInt();
				(value as GSDel_Void_IntInt).EventId = 160;
				(value as GSDel_Void_IntInt)._OwnerEventCollectionCS = this;
				_EventObjCache[160] = value;
			}
			return value as GSDel_Void_IntInt;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_PauseCurrentMovie
	{
		get
		{
			if (!_EventObjCache.TryGetValue(161, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 161;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[161] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_ResumeCurrentMovie
	{
		get
		{
			if (!_EventObjCache.TryGetValue(162, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 162;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[162] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_CurrentMovieNotifyEnd
	{
		get
		{
			if (!_EventObjCache.TryGetValue(163, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 163;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[163] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_MarkCanFinishLoopMovie
	{
		get
		{
			if (!_EventObjCache.TryGetValue(164, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 164;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[164] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_MovieGraphFlowFinish
	{
		get
		{
			if (!_EventObjCache.TryGetValue(165, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 165;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[165] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_SkipCurrentMovie
	{
		get
		{
			if (!_EventObjCache.TryGetValue(166, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 166;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[166] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_ICamera Evt_RegisterCameraObj
	{
		get
		{
			if (!_EventObjCache.TryGetValue(167, out var value))
			{
				value = new GSDel_Void_ICamera();
				(value as GSDel_Void_ICamera).EventId = 167;
				(value as GSDel_Void_ICamera)._OwnerEventCollectionCS = this;
				_EventObjCache[167] = value;
			}
			return value as GSDel_Void_ICamera;
		}
		set
		{
		}
	}

	public GSDel_Void_ICamera Evt_UnregisterCameraObj
	{
		get
		{
			if (!_EventObjCache.TryGetValue(168, out var value))
			{
				value = new GSDel_Void_ICamera();
				(value as GSDel_Void_ICamera).EventId = 168;
				(value as GSDel_Void_ICamera)._OwnerEventCollectionCS = this;
				_EventObjCache[168] = value;
			}
			return value as GSDel_Void_ICamera;
		}
		set
		{
		}
	}

	public GSDel_Void_IntGameplayTag Evt_TriggerCustomMovieEvent
	{
		get
		{
			if (!_EventObjCache.TryGetValue(169, out var value))
			{
				value = new GSDel_Void_IntGameplayTag();
				(value as GSDel_Void_IntGameplayTag).EventId = 169;
				(value as GSDel_Void_IntGameplayTag)._OwnerEventCollectionCS = this;
				_EventObjCache[169] = value;
			}
			return value as GSDel_Void_IntGameplayTag;
		}
		set
		{
		}
	}

	public GSDel_Void_IntBool Evt_MarkMovieCanBeSkipped
	{
		get
		{
			if (!_EventObjCache.TryGetValue(170, out var value))
			{
				value = new GSDel_Void_IntBool();
				(value as GSDel_Void_IntBool).EventId = 170;
				(value as GSDel_Void_IntBool)._OwnerEventCollectionCS = this;
				_EventObjCache[170] = value;
			}
			return value as GSDel_Void_IntBool;
		}
		set
		{
		}
	}

	public GSDel_Void_ConvertToNoCameraMovie Evt_ConvertToNoCameraMovie
	{
		get
		{
			if (!_EventObjCache.TryGetValue(171, out var value))
			{
				value = new GSDel_Void_ConvertToNoCameraMovie();
				(value as GSDel_Void_ConvertToNoCameraMovie).EventId = 171;
				(value as GSDel_Void_ConvertToNoCameraMovie)._OwnerEventCollectionCS = this;
				_EventObjCache[171] = value;
			}
			return value as GSDel_Void_ConvertToNoCameraMovie;
		}
		set
		{
		}
	}

	public GSDel_Void_GiveBackControlRightForMonster Evt_GiveBackControlRightForMonster
	{
		get
		{
			if (!_EventObjCache.TryGetValue(172, out var value))
			{
				value = new GSDel_Void_GiveBackControlRightForMonster();
				(value as GSDel_Void_GiveBackControlRightForMonster).EventId = 172;
				(value as GSDel_Void_GiveBackControlRightForMonster)._OwnerEventCollectionCS = this;
				_EventObjCache[172] = value;
			}
			return value as GSDel_Void_GiveBackControlRightForMonster;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_TerminateAllMovies
	{
		get
		{
			if (!_EventObjCache.TryGetValue(173, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 173;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[173] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_DetachCameraInSkillSeq
	{
		get
		{
			if (!_EventObjCache.TryGetValue(174, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 174;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[174] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_BeginDefeatSlowTime Evt_BeginDefeatSlowTime
	{
		get
		{
			if (!_EventObjCache.TryGetValue(175, out var value))
			{
				value = new GSDel_BeginDefeatSlowTime();
				(value as GSDel_BeginDefeatSlowTime).EventId = 175;
				(value as GSDel_BeginDefeatSlowTime)._OwnerEventCollectionCS = this;
				_EventObjCache[175] = value;
			}
			return value as GSDel_BeginDefeatSlowTime;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_EndDefeatSlowTime
	{
		get
		{
			if (!_EventObjCache.TryGetValue(176, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 176;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[176] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_Void_IntInt Evt_NotifyMovieBegin
	{
		get
		{
			if (!_EventObjCache.TryGetValue(177, out var value))
			{
				value = new GSDel_Void_IntInt();
				(value as GSDel_Void_IntInt).EventId = 177;
				(value as GSDel_Void_IntInt)._OwnerEventCollectionCS = this;
				_EventObjCache[177] = value;
			}
			return value as GSDel_Void_IntInt;
		}
		set
		{
		}
	}

	public GSDel_Void_IntInt Evt_NotifyMovieEnd
	{
		get
		{
			if (!_EventObjCache.TryGetValue(178, out var value))
			{
				value = new GSDel_Void_IntInt();
				(value as GSDel_Void_IntInt).EventId = 178;
				(value as GSDel_Void_IntInt)._OwnerEventCollectionCS = this;
				_EventObjCache[178] = value;
			}
			return value as GSDel_Void_IntInt;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_ReliveAllImmobilized
	{
		get
		{
			if (!_EventObjCache.TryGetValue(179, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 179;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[179] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_SpawnStaticMeshActor Evt_OnSpawnStaticMeshActor
	{
		get
		{
			if (!_EventObjCache.TryGetValue(180, out var value))
			{
				value = new GSDel_SpawnStaticMeshActor();
				(value as GSDel_SpawnStaticMeshActor).EventId = 180;
				(value as GSDel_SpawnStaticMeshActor)._OwnerEventCollectionCS = this;
				_EventObjCache[180] = value;
			}
			return value as GSDel_SpawnStaticMeshActor;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_RegisterSceneItem
	{
		get
		{
			if (!_EventObjCache.TryGetValue(181, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 181;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[181] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_UnregisterSceneItem
	{
		get
		{
			if (!_EventObjCache.TryGetValue(182, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 182;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[182] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_OnProjectileBeginAttach
	{
		get
		{
			if (!_EventObjCache.TryGetValue(183, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 183;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[183] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_OnProjectileDestroyed
	{
		get
		{
			if (!_EventObjCache.TryGetValue(184, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 184;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[184] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_RequestSpawnAProjectile Evt_RequestSpawnAProjectile
	{
		get
		{
			if (!_EventObjCache.TryGetValue(185, out var value))
			{
				value = new GSDel_RequestSpawnAProjectile();
				(value as GSDel_RequestSpawnAProjectile).EventId = 185;
				(value as GSDel_RequestSpawnAProjectile)._OwnerEventCollectionCS = this;
				_EventObjCache[185] = value;
			}
			return value as GSDel_RequestSpawnAProjectile;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_ClearAllAttachedProjectiles
	{
		get
		{
			if (!_EventObjCache.TryGetValue(186, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 186;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[186] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BGS_ClearAttachedProjectiles_OnUnit
	{
		get
		{
			if (!_EventObjCache.TryGetValue(187, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 187;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[187] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_RequestAsyncLineTrace_ByObjectTypeSingle Evt_RequestAsyncLineTrace_ByObjectTypeSingle
	{
		get
		{
			if (!_EventObjCache.TryGetValue(188, out var value))
			{
				value = new GSDel_RequestAsyncLineTrace_ByObjectTypeSingle();
				(value as GSDel_RequestAsyncLineTrace_ByObjectTypeSingle).EventId = 188;
				(value as GSDel_RequestAsyncLineTrace_ByObjectTypeSingle)._OwnerEventCollectionCS = this;
				_EventObjCache[188] = value;
			}
			return value as GSDel_RequestAsyncLineTrace_ByObjectTypeSingle;
		}
		set
		{
		}
	}

	public GSDel_RequestAsyncLineTrace_ByChannelSingle Evt_RequestAsyncLineTrace_ByChannelSingle
	{
		get
		{
			if (!_EventObjCache.TryGetValue(189, out var value))
			{
				value = new GSDel_RequestAsyncLineTrace_ByChannelSingle();
				(value as GSDel_RequestAsyncLineTrace_ByChannelSingle).EventId = 189;
				(value as GSDel_RequestAsyncLineTrace_ByChannelSingle)._OwnerEventCollectionCS = this;
				_EventObjCache[189] = value;
			}
			return value as GSDel_RequestAsyncLineTrace_ByChannelSingle;
		}
		set
		{
		}
	}

	public GSDel_RequestAsyncLineTrace_ByObjectTypeSingle_Batch Evt_RequestAsyncLineTrace_ByObjectTypeSingle_Batch
	{
		get
		{
			if (!_EventObjCache.TryGetValue(190, out var value))
			{
				value = new GSDel_RequestAsyncLineTrace_ByObjectTypeSingle_Batch();
				(value as GSDel_RequestAsyncLineTrace_ByObjectTypeSingle_Batch).EventId = 190;
				(value as GSDel_RequestAsyncLineTrace_ByObjectTypeSingle_Batch)._OwnerEventCollectionCS = this;
				_EventObjCache[190] = value;
			}
			return value as GSDel_RequestAsyncLineTrace_ByObjectTypeSingle_Batch;
		}
		set
		{
		}
	}

	public GSDel_RequestAsyncLineTrace_ByChannelSingle_Batch Evt_RequestAsyncLineTrace_ByChannelSingle_Batch
	{
		get
		{
			if (!_EventObjCache.TryGetValue(191, out var value))
			{
				value = new GSDel_RequestAsyncLineTrace_ByChannelSingle_Batch();
				(value as GSDel_RequestAsyncLineTrace_ByChannelSingle_Batch).EventId = 191;
				(value as GSDel_RequestAsyncLineTrace_ByChannelSingle_Batch)._OwnerEventCollectionCS = this;
				_EventObjCache[191] = value;
			}
			return value as GSDel_RequestAsyncLineTrace_ByChannelSingle_Batch;
		}
		set
		{
		}
	}

	public GSDel_OnAiConversationCastSuccess Evt_OnAiConversationCastSuccess
	{
		get
		{
			if (!_EventObjCache.TryGetValue(192, out var value))
			{
				value = new GSDel_OnAiConversationCastSuccess();
				(value as GSDel_OnAiConversationCastSuccess).EventId = 192;
				(value as GSDel_OnAiConversationCastSuccess)._OwnerEventCollectionCS = this;
				_EventObjCache[192] = value;
			}
			return value as GSDel_OnAiConversationCastSuccess;
		}
		set
		{
		}
	}

	public GSDel_Void_Uint Evt_OnConversationChainEnd
	{
		get
		{
			if (!_EventObjCache.TryGetValue(193, out var value))
			{
				value = new GSDel_Void_Uint();
				(value as GSDel_Void_Uint).EventId = 193;
				(value as GSDel_Void_Uint)._OwnerEventCollectionCS = this;
				_EventObjCache[193] = value;
			}
			return value as GSDel_Void_Uint;
		}
		set
		{
		}
	}

	public GSDel_Void_Uint Evt_OnConversationChainInterrupt
	{
		get
		{
			if (!_EventObjCache.TryGetValue(194, out var value))
			{
				value = new GSDel_Void_Uint();
				(value as GSDel_Void_Uint).EventId = 194;
				(value as GSDel_Void_Uint)._OwnerEventCollectionCS = this;
				_EventObjCache[194] = value;
			}
			return value as GSDel_Void_Uint;
		}
		set
		{
		}
	}

	public GSDel_PocessEventByContentIDList Evt_PocessEventByContentIDList
	{
		get
		{
			if (!_EventObjCache.TryGetValue(195, out var value))
			{
				value = new GSDel_PocessEventByContentIDList();
				(value as GSDel_PocessEventByContentIDList).EventId = 195;
				(value as GSDel_PocessEventByContentIDList)._OwnerEventCollectionCS = this;
				_EventObjCache[195] = value;
			}
			return value as GSDel_PocessEventByContentIDList;
		}
		set
		{
		}
	}

	public GSDel_PocessEventByContentIDList_ByGuid Evt_PocessEventByContentIDList_ByGuid
	{
		get
		{
			if (!_EventObjCache.TryGetValue(196, out var value))
			{
				value = new GSDel_PocessEventByContentIDList_ByGuid();
				(value as GSDel_PocessEventByContentIDList_ByGuid).EventId = 196;
				(value as GSDel_PocessEventByContentIDList_ByGuid)._OwnerEventCollectionCS = this;
				_EventObjCache[196] = value;
			}
			return value as GSDel_PocessEventByContentIDList_ByGuid;
		}
		set
		{
		}
	}

	public GSDel_OnAiConversationEnded Evt_OnAiConversationEnded
	{
		get
		{
			if (!_EventObjCache.TryGetValue(197, out var value))
			{
				value = new GSDel_OnAiConversationEnded();
				(value as GSDel_OnAiConversationEnded).EventId = 197;
				(value as GSDel_OnAiConversationEnded)._OwnerEventCollectionCS = this;
				_EventObjCache[197] = value;
			}
			return value as GSDel_OnAiConversationEnded;
		}
		set
		{
		}
	}

	public GSDel_StopAiConversation Evt_BGS_StopAiConversation
	{
		get
		{
			if (!_EventObjCache.TryGetValue(198, out var value))
			{
				value = new GSDel_StopAiConversation();
				(value as GSDel_StopAiConversation).EventId = 198;
				(value as GSDel_StopAiConversation)._OwnerEventCollectionCS = this;
				_EventObjCache[198] = value;
			}
			return value as GSDel_StopAiConversation;
		}
		set
		{
		}
	}

	public GSDel_StopAiConversation_ByGUID Evt_BGS_StopAiConversation_ByGUID
	{
		get
		{
			if (!_EventObjCache.TryGetValue(199, out var value))
			{
				value = new GSDel_StopAiConversation_ByGUID();
				(value as GSDel_StopAiConversation_ByGUID).EventId = 199;
				(value as GSDel_StopAiConversation_ByGUID)._OwnerEventCollectionCS = this;
				_EventObjCache[199] = value;
			}
			return value as GSDel_StopAiConversation_ByGUID;
		}
		set
		{
		}
	}

	public GSDel_StopAllAiConversation Evt_BGS_StopAllAiConversation
	{
		get
		{
			if (!_EventObjCache.TryGetValue(200, out var value))
			{
				value = new GSDel_StopAllAiConversation();
				(value as GSDel_StopAllAiConversation).EventId = 200;
				(value as GSDel_StopAllAiConversation)._OwnerEventCollectionCS = this;
				_EventObjCache[200] = value;
			}
			return value as GSDel_StopAllAiConversation;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_BGS_UnregisterAiConversationProxy
	{
		get
		{
			if (!_EventObjCache.TryGetValue(201, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 201;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[201] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BGS_JumpToNextSubtitleMarkerPos
	{
		get
		{
			if (!_EventObjCache.TryGetValue(202, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 202;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[202] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_PlayPigsyStory
	{
		get
		{
			if (!_EventObjCache.TryGetValue(203, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 203;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[203] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_InterruptPigsyStory Evt_InterruptPigsyStory
	{
		get
		{
			if (!_EventObjCache.TryGetValue(204, out var value))
			{
				value = new GSDel_InterruptPigsyStory();
				(value as GSDel_InterruptPigsyStory).EventId = 204;
				(value as GSDel_InterruptPigsyStory)._OwnerEventCollectionCS = this;
				_EventObjCache[204] = value;
			}
			return value as GSDel_InterruptPigsyStory;
		}
		set
		{
		}
	}

	public GSDel_IntoSpecificStoryArea Evt_IntoSpecificStoryArea
	{
		get
		{
			if (!_EventObjCache.TryGetValue(205, out var value))
			{
				value = new GSDel_IntoSpecificStoryArea();
				(value as GSDel_IntoSpecificStoryArea).EventId = 205;
				(value as GSDel_IntoSpecificStoryArea)._OwnerEventCollectionCS = this;
				_EventObjCache[205] = value;
			}
			return value as GSDel_IntoSpecificStoryArea;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_ExitSpecificStoryArea
	{
		get
		{
			if (!_EventObjCache.TryGetValue(206, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 206;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[206] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_OnCurStoryFinished
	{
		get
		{
			if (!_EventObjCache.TryGetValue(207, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 207;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[207] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_OnActorIntoField Evt_OnActorIntoField
	{
		get
		{
			if (!_EventObjCache.TryGetValue(208, out var value))
			{
				value = new GSDel_Void_OnActorIntoField();
				(value as GSDel_Void_OnActorIntoField).EventId = 208;
				(value as GSDel_Void_OnActorIntoField)._OwnerEventCollectionCS = this;
				_EventObjCache[208] = value;
			}
			return value as GSDel_Void_OnActorIntoField;
		}
		set
		{
		}
	}

	public GSDel_Void_ActorActor Evt_OnActorLeaveField
	{
		get
		{
			if (!_EventObjCache.TryGetValue(209, out var value))
			{
				value = new GSDel_Void_ActorActor();
				(value as GSDel_Void_ActorActor).EventId = 209;
				(value as GSDel_Void_ActorActor)._OwnerEventCollectionCS = this;
				_EventObjCache[209] = value;
			}
			return value as GSDel_Void_ActorActor;
		}
		set
		{
		}
	}

	public GSDel_Void_IntFloat Evt_BGS_HandleSpawnWaveGroupCD
	{
		get
		{
			if (!_EventObjCache.TryGetValue(210, out var value))
			{
				value = new GSDel_Void_IntFloat();
				(value as GSDel_Void_IntFloat).EventId = 210;
				(value as GSDel_Void_IntFloat)._OwnerEventCollectionCS = this;
				_EventObjCache[210] = value;
			}
			return value as GSDel_Void_IntFloat;
		}
		set
		{
		}
	}

	public GSDel_Void_EntityEntity Evt_NotifyPossessEntityChanged
	{
		get
		{
			if (!_EventObjCache.TryGetValue(211, out var value))
			{
				value = new GSDel_Void_EntityEntity();
				(value as GSDel_Void_EntityEntity).EventId = 211;
				(value as GSDel_Void_EntityEntity)._OwnerEventCollectionCS = this;
				_EventObjCache[211] = value;
			}
			return value as GSDel_Void_EntityEntity;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BGS_BattleFieldPerformanceOptUnit
	{
		get
		{
			if (!_EventObjCache.TryGetValue(212, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 212;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[212] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_Void_StringString Evt_AkRoomSetSwitch
	{
		get
		{
			if (!_EventObjCache.TryGetValue(213, out var value))
			{
				value = new GSDel_Void_StringString();
				(value as GSDel_Void_StringString).EventId = 213;
				(value as GSDel_Void_StringString)._OwnerEventCollectionCS = this;
				_EventObjCache[213] = value;
			}
			return value as GSDel_Void_StringString;
		}
		set
		{
		}
	}

	public GSDel_Void_StringAudioEmitter Evt_RegisterAudioEmitter
	{
		get
		{
			if (!_EventObjCache.TryGetValue(214, out var value))
			{
				value = new GSDel_Void_StringAudioEmitter();
				(value as GSDel_Void_StringAudioEmitter).EventId = 214;
				(value as GSDel_Void_StringAudioEmitter)._OwnerEventCollectionCS = this;
				_EventObjCache[214] = value;
			}
			return value as GSDel_Void_StringAudioEmitter;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_UnRegisterAudioEmitter
	{
		get
		{
			if (!_EventObjCache.TryGetValue(215, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 215;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[215] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Bool_Void Evt_QueryIsPlayingCameraMovie
	{
		get
		{
			if (!_EventObjCache.TryGetValue(216, out var value))
			{
				value = new GSDel_Bool_Void();
				(value as GSDel_Bool_Void).EventId = 216;
				(value as GSDel_Bool_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[216] = value;
			}
			return value as GSDel_Bool_Void;
		}
		set
		{
		}
	}

	public GSDel_Int_Void Evt_QueryPlayingSequenceID
	{
		get
		{
			if (!_EventObjCache.TryGetValue(217, out var value))
			{
				value = new GSDel_Int_Void();
				(value as GSDel_Int_Void).EventId = 217;
				(value as GSDel_Int_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[217] = value;
			}
			return value as GSDel_Int_Void;
		}
		set
		{
		}
	}

	public GSDel_OnRegistTreeFXAnimalInfo Evt_OnRegistTreeFXAnimalInfo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(218, out var value))
			{
				value = new GSDel_OnRegistTreeFXAnimalInfo();
				(value as GSDel_OnRegistTreeFXAnimalInfo).EventId = 218;
				(value as GSDel_OnRegistTreeFXAnimalInfo)._OwnerEventCollectionCS = this;
				_EventObjCache[218] = value;
			}
			return value as GSDel_OnRegistTreeFXAnimalInfo;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BGS_OnFXAnimalDisappear
	{
		get
		{
			if (!_EventObjCache.TryGetValue(219, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 219;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[219] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_Void_ReqSpawnAnimals Evt_BGS_ReqSpawnAnimals
	{
		get
		{
			if (!_EventObjCache.TryGetValue(220, out var value))
			{
				value = new GSDel_Void_ReqSpawnAnimals();
				(value as GSDel_Void_ReqSpawnAnimals).EventId = 220;
				(value as GSDel_Void_ReqSpawnAnimals)._OwnerEventCollectionCS = this;
				_EventObjCache[220] = value;
			}
			return value as GSDel_Void_ReqSpawnAnimals;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_OnCloudMoveBegin
	{
		get
		{
			if (!_EventObjCache.TryGetValue(221, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 221;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[221] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_OnCloudMoveEnded
	{
		get
		{
			if (!_EventObjCache.TryGetValue(222, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 222;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[222] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_StringString Evt_RegisterWeaponInfo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(223, out var value))
			{
				value = new GSDel_Void_StringString();
				(value as GSDel_Void_StringString).EventId = 223;
				(value as GSDel_Void_StringString)._OwnerEventCollectionCS = this;
				_EventObjCache[223] = value;
			}
			return value as GSDel_Void_StringString;
		}
		set
		{
		}
	}

	public GSDel_Void_StringString Evt_UnRegisterWeaponInfo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(224, out var value))
			{
				value = new GSDel_Void_StringString();
				(value as GSDel_Void_StringString).EventId = 224;
				(value as GSDel_Void_StringString)._OwnerEventCollectionCS = this;
				_EventObjCache[224] = value;
			}
			return value as GSDel_Void_StringString;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_ClearWeaponInfo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(225, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 225;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[225] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_OnLocalPlayerCostDmg
	{
		get
		{
			if (!_EventObjCache.TryGetValue(226, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 226;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[226] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_AkEvent_ICB Evt_PostMulticastAkEvent
	{
		get
		{
			if (!_EventObjCache.TryGetValue(227, out var value))
			{
				value = new GSDel_Void_AkEvent_ICB(Evt_PostMulticastAkEvent_Invoke, Evt_PostMulticastAkEvent_DelChg);
				(value as GSDel_Void_AkEvent_ICB).EventId = 227;
				(value as GSDel_Void_AkEvent_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[227] = value;
			}
			return value as GSDel_Void_AkEvent_ICB;
		}
		set
		{
		}
	}

	public GSDel_TriggerEnhancedInputAction Evt_TriggerEnhancedInputAction
	{
		get
		{
			if (!_EventObjCache.TryGetValue(228, out var value))
			{
				value = new GSDel_TriggerEnhancedInputAction();
				(value as GSDel_TriggerEnhancedInputAction).EventId = 228;
				(value as GSDel_TriggerEnhancedInputAction)._OwnerEventCollectionCS = this;
				_EventObjCache[228] = value;
			}
			return value as GSDel_TriggerEnhancedInputAction;
		}
		set
		{
		}
	}

	public GSDel_Void_IntString Evt_RegisterCrusadeMonsterInfo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(229, out var value))
			{
				value = new GSDel_Void_IntString();
				(value as GSDel_Void_IntString).EventId = 229;
				(value as GSDel_Void_IntString)._OwnerEventCollectionCS = this;
				_EventObjCache[229] = value;
			}
			return value as GSDel_Void_IntString;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_UpdateCrusadeMonsterInfo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(230, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 230;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[230] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_EncounterUnit
	{
		get
		{
			if (!_EventObjCache.TryGetValue(231, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 231;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[231] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void_EAssistEvent Evt_TriggerAssistEvent
	{
		get
		{
			if (!_EventObjCache.TryGetValue(232, out var value))
			{
				value = new GSDel_Void_EAssistEvent();
				(value as GSDel_Void_EAssistEvent).EventId = 232;
				(value as GSDel_Void_EAssistEvent)._OwnerEventCollectionCS = this;
				_EventObjCache[232] = value;
			}
			return value as GSDel_Void_EAssistEvent;
		}
		set
		{
		}
	}

	public GSDel_Void_Bool Evt_EnterCrusadeArea
	{
		get
		{
			if (!_EventObjCache.TryGetValue(233, out var value))
			{
				value = new GSDel_Void_Bool();
				(value as GSDel_Void_Bool).EventId = 233;
				(value as GSDel_Void_Bool)._OwnerEventCollectionCS = this;
				_EventObjCache[233] = value;
			}
			return value as GSDel_Void_Bool;
		}
		set
		{
		}
	}

	public GSDel_Void_ICB Evt_TeamWipeOut
	{
		get
		{
			if (!_EventObjCache.TryGetValue(234, out var value))
			{
				value = new GSDel_Void_ICB(Evt_TeamWipeOut_Invoke, Evt_TeamWipeOut_DelChg);
				(value as GSDel_Void_ICB).EventId = 234;
				(value as GSDel_Void_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[234] = value;
			}
			return value as GSDel_Void_ICB;
		}
		set
		{
		}
	}

	public GSDel_Void_ICB Evt_CrusadeSuccess
	{
		get
		{
			if (!_EventObjCache.TryGetValue(235, out var value))
			{
				value = new GSDel_Void_ICB(Evt_CrusadeSuccess_Invoke, Evt_CrusadeSuccess_DelChg);
				(value as GSDel_Void_ICB).EventId = 235;
				(value as GSDel_Void_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[235] = value;
			}
			return value as GSDel_Void_ICB;
		}
		set
		{
		}
	}

	public GSDel_Void_OutIntInt Evt_FetchTeleportInfoBeforeAssist
	{
		get
		{
			if (!_EventObjCache.TryGetValue(236, out var value))
			{
				value = new GSDel_Void_OutIntInt();
				(value as GSDel_Void_OutIntInt).EventId = 236;
				(value as GSDel_Void_OutIntInt)._OwnerEventCollectionCS = this;
				_EventObjCache[236] = value;
			}
			return value as GSDel_Void_OutIntInt;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_PlayerTriggerGuideGroup
	{
		get
		{
			if (!_EventObjCache.TryGetValue(237, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 237;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[237] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_PlayerFinishGuideGroup
	{
		get
		{
			if (!_EventObjCache.TryGetValue(238, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 238;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[238] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_TriggerGuideNodeFinishEvent Evt_TriggerGuideNodeFinishEvent
	{
		get
		{
			if (!_EventObjCache.TryGetValue(239, out var value))
			{
				value = new GSDel_TriggerGuideNodeFinishEvent();
				(value as GSDel_TriggerGuideNodeFinishEvent).EventId = 239;
				(value as GSDel_TriggerGuideNodeFinishEvent)._OwnerEventCollectionCS = this;
				_EventObjCache[239] = value;
			}
			return value as GSDel_TriggerGuideNodeFinishEvent;
		}
		set
		{
		}
	}

	public GSDel_TriggerGuideNodeFinishEvent_WithIntParam Evt_TriggerGuideNodeFinishEvent_WithIntParam
	{
		get
		{
			if (!_EventObjCache.TryGetValue(240, out var value))
			{
				value = new GSDel_TriggerGuideNodeFinishEvent_WithIntParam();
				(value as GSDel_TriggerGuideNodeFinishEvent_WithIntParam).EventId = 240;
				(value as GSDel_TriggerGuideNodeFinishEvent_WithIntParam)._OwnerEventCollectionCS = this;
				_EventObjCache[240] = value;
			}
			return value as GSDel_TriggerGuideNodeFinishEvent_WithIntParam;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_TriggerConfirmGuideGroupEvent
	{
		get
		{
			if (!_EventObjCache.TryGetValue(241, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 241;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[241] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_ShrineMainUIFadeInFinish
	{
		get
		{
			if (!_EventObjCache.TryGetValue(242, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 242;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[242] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_OnPlayerRoleDataInit
	{
		get
		{
			if (!_EventObjCache.TryGetValue(243, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 243;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[243] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_UnitDeadDropItem Evt_BGS_UnitDeadDropItem
	{
		get
		{
			if (!_EventObjCache.TryGetValue(244, out var value))
			{
				value = new GSDel_UnitDeadDropItem();
				(value as GSDel_UnitDeadDropItem).EventId = 244;
				(value as GSDel_UnitDeadDropItem)._OwnerEventCollectionCS = this;
				_EventObjCache[244] = value;
			}
			return value as GSDel_UnitDeadDropItem;
		}
		set
		{
		}
	}

	public GSDel_SendOnlineScreenMsg_ICB Evt_BGS_SendOnlineScreenMsg
	{
		get
		{
			if (!_EventObjCache.TryGetValue(245, out var value))
			{
				value = new GSDel_SendOnlineScreenMsg_ICB(Evt_BGS_SendOnlineScreenMsg_Invoke, Evt_BGS_SendOnlineScreenMsg_DelChg);
				(value as GSDel_SendOnlineScreenMsg_ICB).EventId = 245;
				(value as GSDel_SendOnlineScreenMsg_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[245] = value;
			}
			return value as GSDel_SendOnlineScreenMsg_ICB;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_BGS_LevelEventScreenMsg
	{
		get
		{
			if (!_EventObjCache.TryGetValue(246, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 246;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[246] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_Void_UseItemScreenMsg Evt_BGS_UseItemScreenMsg
	{
		get
		{
			if (!_EventObjCache.TryGetValue(247, out var value))
			{
				value = new GSDel_Void_UseItemScreenMsg();
				(value as GSDel_Void_UseItemScreenMsg).EventId = 247;
				(value as GSDel_Void_UseItemScreenMsg)._OwnerEventCollectionCS = this;
				_EventObjCache[247] = value;
			}
			return value as GSDel_Void_UseItemScreenMsg;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_BGS_PlayerDeadScreenMsg
	{
		get
		{
			if (!_EventObjCache.TryGetValue(248, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 248;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[248] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_OnPlayerLogOut_ICB Evt_BGS_OnPlayerLogOut
	{
		get
		{
			if (!_EventObjCache.TryGetValue(249, out var value))
			{
				value = new GSDel_OnPlayerLogOut_ICB(Evt_BGS_OnPlayerLogOut_Invoke, Evt_BGS_OnPlayerLogOut_DelChg);
				(value as GSDel_OnPlayerLogOut_ICB).EventId = 249;
				(value as GSDel_OnPlayerLogOut_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[249] = value;
			}
			return value as GSDel_OnPlayerLogOut_ICB;
		}
		set
		{
		}
	}

	public GSDel_OnPlayerPostLogin_ICB Evt_BGS_OnPlayerPostLogin
	{
		get
		{
			if (!_EventObjCache.TryGetValue(250, out var value))
			{
				value = new GSDel_OnPlayerPostLogin_ICB(Evt_BGS_OnPlayerPostLogin_Invoke, Evt_BGS_OnPlayerPostLogin_DelChg);
				(value as GSDel_OnPlayerPostLogin_ICB).EventId = 250;
				(value as GSDel_OnPlayerPostLogin_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[250] = value;
			}
			return value as GSDel_OnPlayerPostLogin_ICB;
		}
		set
		{
		}
	}

	public GSDel_Void_ICB Evt_OnlineDebugInfoEnd
	{
		get
		{
			if (!_EventObjCache.TryGetValue(251, out var value))
			{
				value = new GSDel_Void_ICB(Evt_OnlineDebugInfoEnd_Invoke, Evt_OnlineDebugInfoEnd_DelChg);
				(value as GSDel_Void_ICB).EventId = 251;
				(value as GSDel_Void_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[251] = value;
			}
			return value as GSDel_Void_ICB;
		}
		set
		{
		}
	}

	public GSDel_ItemDropToUI Evt_OnItemDropToUI
	{
		get
		{
			if (!_EventObjCache.TryGetValue(252, out var value))
			{
				value = new GSDel_ItemDropToUI();
				(value as GSDel_ItemDropToUI).EventId = 252;
				(value as GSDel_ItemDropToUI)._OwnerEventCollectionCS = this;
				_EventObjCache[252] = value;
			}
			return value as GSDel_ItemDropToUI;
		}
		set
		{
		}
	}

	public GSDel_PlayerCollected Evt_BGS_PlayerCollected
	{
		get
		{
			if (!_EventObjCache.TryGetValue(253, out var value))
			{
				value = new GSDel_PlayerCollected();
				(value as GSDel_PlayerCollected).EventId = 253;
				(value as GSDel_PlayerCollected)._OwnerEventCollectionCS = this;
				_EventObjCache[253] = value;
			}
			return value as GSDel_PlayerCollected;
		}
		set
		{
		}
	}

	public GSDel_UnitInBattle Evt_BGS_UnitInBattle
	{
		get
		{
			if (!_EventObjCache.TryGetValue(254, out var value))
			{
				value = new GSDel_UnitInBattle();
				(value as GSDel_UnitInBattle).EventId = 254;
				(value as GSDel_UnitInBattle)._OwnerEventCollectionCS = this;
				_EventObjCache[254] = value;
			}
			return value as GSDel_UnitInBattle;
		}
		set
		{
		}
	}

	public GSDel_Void_StringInt Evt_BGS_UnitLeaveBattle
	{
		get
		{
			if (!_EventObjCache.TryGetValue(255, out var value))
			{
				value = new GSDel_Void_StringInt();
				(value as GSDel_Void_StringInt).EventId = 255;
				(value as GSDel_Void_StringInt)._OwnerEventCollectionCS = this;
				_EventObjCache[255] = value;
			}
			return value as GSDel_Void_StringInt;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_BGS_RemoveForceLeaveBattleUnit
	{
		get
		{
			if (!_EventObjCache.TryGetValue(256, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 256;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[256] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_StandardObjFinishInteract Evt_BGS_StandardObjFinishInteract
	{
		get
		{
			if (!_EventObjCache.TryGetValue(257, out var value))
			{
				value = new GSDel_StandardObjFinishInteract();
				(value as GSDel_StandardObjFinishInteract).EventId = 257;
				(value as GSDel_StandardObjFinishInteract)._OwnerEventCollectionCS = this;
				_EventObjCache[257] = value;
			}
			return value as GSDel_StandardObjFinishInteract;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_PlayerKillMonster
	{
		get
		{
			if (!_EventObjCache.TryGetValue(258, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 258;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[258] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_IntInt Evt_BGS_PlayerGainItem
	{
		get
		{
			if (!_EventObjCache.TryGetValue(259, out var value))
			{
				value = new GSDel_Void_IntInt();
				(value as GSDel_Void_IntInt).EventId = 259;
				(value as GSDel_Void_IntInt)._OwnerEventCollectionCS = this;
				_EventObjCache[259] = value;
			}
			return value as GSDel_Void_IntInt;
		}
		set
		{
		}
	}

	public GSDel_Void_Int_ICB Evt_BGS_ItemFullOnline
	{
		get
		{
			if (!_EventObjCache.TryGetValue(260, out var value))
			{
				value = new GSDel_Void_Int_ICB(Evt_BGS_ItemFullOnline_Invoke, Evt_BGS_ItemFullOnline_DelChg);
				(value as GSDel_Void_Int_ICB).EventId = 260;
				(value as GSDel_Void_Int_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[260] = value;
			}
			return value as GSDel_Void_Int_ICB;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_HideLevelUI
	{
		get
		{
			if (!_EventObjCache.TryGetValue(261, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 261;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[261] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_ShowPartyRoomUI
	{
		get
		{
			if (!_EventObjCache.TryGetValue(262, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 262;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[262] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_OnlineTeleport
	{
		get
		{
			if (!_EventObjCache.TryGetValue(263, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 263;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[263] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_IntInt Evt_BGS_OnlineChallengeBegin
	{
		get
		{
			if (!_EventObjCache.TryGetValue(264, out var value))
			{
				value = new GSDel_Void_IntInt();
				(value as GSDel_Void_IntInt).EventId = 264;
				(value as GSDel_Void_IntInt)._OwnerEventCollectionCS = this;
				_EventObjCache[264] = value;
			}
			return value as GSDel_Void_IntInt;
		}
		set
		{
		}
	}

	public GSDel_Void_IntInt_ICB Evt_BGS_OnlineChallengeStateTrigger
	{
		get
		{
			if (!_EventObjCache.TryGetValue(265, out var value))
			{
				value = new GSDel_Void_IntInt_ICB(Evt_BGS_OnlineChallengeStateTrigger_Invoke, Evt_BGS_OnlineChallengeStateTrigger_DelChg);
				(value as GSDel_Void_IntInt_ICB).EventId = 265;
				(value as GSDel_Void_IntInt_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[265] = value;
			}
			return value as GSDel_Void_IntInt_ICB;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_BGS_OnlineChallengeFailed
	{
		get
		{
			if (!_EventObjCache.TryGetValue(266, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 266;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[266] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_ChallengeSuccessDropItem Evt_BGS_ChallengeSuccessDropItem
	{
		get
		{
			if (!_EventObjCache.TryGetValue(267, out var value))
			{
				value = new GSDel_ChallengeSuccessDropItem();
				(value as GSDel_ChallengeSuccessDropItem).EventId = 267;
				(value as GSDel_ChallengeSuccessDropItem)._OwnerEventCollectionCS = this;
				_EventObjCache[267] = value;
			}
			return value as GSDel_ChallengeSuccessDropItem;
		}
		set
		{
		}
	}

	public GSDel_OnlineOnePlayerDead Evt_BGS_OnlineOnePlayerDead
	{
		get
		{
			if (!_EventObjCache.TryGetValue(268, out var value))
			{
				value = new GSDel_OnlineOnePlayerDead();
				(value as GSDel_OnlineOnePlayerDead).EventId = 268;
				(value as GSDel_OnlineOnePlayerDead)._OwnerEventCollectionCS = this;
				_EventObjCache[268] = value;
			}
			return value as GSDel_OnlineOnePlayerDead;
		}
		set
		{
		}
	}

	public GSDel_OnlineOnePlayerDead Evt_BGS_OnlineOnePlayerFaildying
	{
		get
		{
			if (!_EventObjCache.TryGetValue(269, out var value))
			{
				value = new GSDel_OnlineOnePlayerDead();
				(value as GSDel_OnlineOnePlayerDead).EventId = 269;
				(value as GSDel_OnlineOnePlayerDead)._OwnerEventCollectionCS = this;
				_EventObjCache[269] = value;
			}
			return value as GSDel_OnlineOnePlayerDead;
		}
		set
		{
		}
	}

	public GSDel_OnlineChallengeSpawn Evt_BGS_OnlineChallengeSpawn
	{
		get
		{
			if (!_EventObjCache.TryGetValue(270, out var value))
			{
				value = new GSDel_OnlineChallengeSpawn();
				(value as GSDel_OnlineChallengeSpawn).EventId = 270;
				(value as GSDel_OnlineChallengeSpawn)._OwnerEventCollectionCS = this;
				_EventObjCache[270] = value;
			}
			return value as GSDel_OnlineChallengeSpawn;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BGS_WaveSpawnEventClear
	{
		get
		{
			if (!_EventObjCache.TryGetValue(271, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 271;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[271] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_PlayerState_ICB Evt_BGS_PlayerJoin
	{
		get
		{
			if (!_EventObjCache.TryGetValue(272, out var value))
			{
				value = new GSDel_PlayerState_ICB(Evt_BGS_PlayerJoin_Invoke, Evt_BGS_PlayerJoin_DelChg);
				(value as GSDel_PlayerState_ICB).EventId = 272;
				(value as GSDel_PlayerState_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[272] = value;
			}
			return value as GSDel_PlayerState_ICB;
		}
		set
		{
		}
	}

	public GSDel_PlayerState_ICB Evt_BGS_PlayerLogOut
	{
		get
		{
			if (!_EventObjCache.TryGetValue(273, out var value))
			{
				value = new GSDel_PlayerState_ICB(Evt_BGS_PlayerLogOut_Invoke, Evt_BGS_PlayerLogOut_DelChg);
				(value as GSDel_PlayerState_ICB).EventId = 273;
				(value as GSDel_PlayerState_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[273] = value;
			}
			return value as GSDel_PlayerState_ICB;
		}
		set
		{
		}
	}

	public GSDel_PlayerState Evt_PlayerActorLateBeginPlayFinish
	{
		get
		{
			if (!_EventObjCache.TryGetValue(274, out var value))
			{
				value = new GSDel_PlayerState();
				(value as GSDel_PlayerState).EventId = 274;
				(value as GSDel_PlayerState)._OwnerEventCollectionCS = this;
				_EventObjCache[274] = value;
			}
			return value as GSDel_PlayerState;
		}
		set
		{
		}
	}

	public GSDel_RegisterTaskCollectiont Evt_BGS_RegisterTaskCollectiont
	{
		get
		{
			if (!_EventObjCache.TryGetValue(275, out var value))
			{
				value = new GSDel_RegisterTaskCollectiont();
				(value as GSDel_RegisterTaskCollectiont).EventId = 275;
				(value as GSDel_RegisterTaskCollectiont)._OwnerEventCollectionCS = this;
				_EventObjCache[275] = value;
			}
			return value as GSDel_RegisterTaskCollectiont;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_BGS_UnRegisterTaskCollectiont
	{
		get
		{
			if (!_EventObjCache.TryGetValue(276, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 276;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[276] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_BGS_GMCGTest
	{
		get
		{
			if (!_EventObjCache.TryGetValue(277, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 277;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[277] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_Void_BoolString Evt_BGS_DLDWorld_SetWEFMSystemPaused
	{
		get
		{
			if (!_EventObjCache.TryGetValue(278, out var value))
			{
				value = new GSDel_Void_BoolString();
				(value as GSDel_Void_BoolString).EventId = 278;
				(value as GSDel_Void_BoolString)._OwnerEventCollectionCS = this;
				_EventObjCache[278] = value;
			}
			return value as GSDel_Void_BoolString;
		}
		set
		{
		}
	}

	public GSDel_Void_BoolIntString Evt_BGS_DLDWorld_SetDBCEffectsPaused
	{
		get
		{
			if (!_EventObjCache.TryGetValue(279, out var value))
			{
				value = new GSDel_Void_BoolIntString();
				(value as GSDel_Void_BoolIntString).EventId = 279;
				(value as GSDel_Void_BoolIntString)._OwnerEventCollectionCS = this;
				_EventObjCache[279] = value;
			}
			return value as GSDel_Void_BoolIntString;
		}
		set
		{
		}
	}

	public GSDel_Void_BoolString Evt_BGS_DLDWorld_SetCameraEnvFXPaused
	{
		get
		{
			if (!_EventObjCache.TryGetValue(280, out var value))
			{
				value = new GSDel_Void_BoolString();
				(value as GSDel_Void_BoolString).EventId = 280;
				(value as GSDel_Void_BoolString)._OwnerEventCollectionCS = this;
				_EventObjCache[280] = value;
			}
			return value as GSDel_Void_BoolString;
		}
		set
		{
		}
	}

	public GSDel_ActorTransformInfoData Evt_BGS_RegisterBGUEntityInfo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(281, out var value))
			{
				value = new GSDel_ActorTransformInfoData();
				(value as GSDel_ActorTransformInfoData).EventId = 281;
				(value as GSDel_ActorTransformInfoData)._OwnerEventCollectionCS = this;
				_EventObjCache[281] = value;
			}
			return value as GSDel_ActorTransformInfoData;
		}
		set
		{
		}
	}

	public GSDel_Void_Entity Evt_BGS_DeregisterBGUEntityInfo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(282, out var value))
			{
				value = new GSDel_Void_Entity();
				(value as GSDel_Void_Entity).EventId = 282;
				(value as GSDel_Void_Entity)._OwnerEventCollectionCS = this;
				_EventObjCache[282] = value;
			}
			return value as GSDel_Void_Entity;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BGS_RemoveGridInfo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(283, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 283;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[283] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_Void_ActorFloat Evt_BGS_SimpleOverlapSetRadius
	{
		get
		{
			if (!_EventObjCache.TryGetValue(284, out var value))
			{
				value = new GSDel_Void_ActorFloat();
				(value as GSDel_Void_ActorFloat).EventId = 284;
				(value as GSDel_Void_ActorFloat)._OwnerEventCollectionCS = this;
				_EventObjCache[284] = value;
			}
			return value as GSDel_Void_ActorFloat;
		}
		set
		{
		}
	}

	public GSDel_MarkUnitControl Evt_BGS_BattleTriggerMarkUnitControl
	{
		get
		{
			if (!_EventObjCache.TryGetValue(285, out var value))
			{
				value = new GSDel_MarkUnitControl();
				(value as GSDel_MarkUnitControl).EventId = 285;
				(value as GSDel_MarkUnitControl)._OwnerEventCollectionCS = this;
				_EventObjCache[285] = value;
			}
			return value as GSDel_MarkUnitControl;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_BGS_BattleTriggerUnMarkUnitControl
	{
		get
		{
			if (!_EventObjCache.TryGetValue(286, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 286;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[286] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void_ActorInt Evt_BGS_SetNeedShowDebugChr
	{
		get
		{
			if (!_EventObjCache.TryGetValue(287, out var value))
			{
				value = new GSDel_Void_ActorInt();
				(value as GSDel_Void_ActorInt).EventId = 287;
				(value as GSDel_Void_ActorInt)._OwnerEventCollectionCS = this;
				_EventObjCache[287] = value;
			}
			return value as GSDel_Void_ActorInt;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_CleanTargetInfos
	{
		get
		{
			if (!_EventObjCache.TryGetValue(288, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 288;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[288] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_EQSObjRun Evt_BGS_EQSObjRun
	{
		get
		{
			if (!_EventObjCache.TryGetValue(289, out var value))
			{
				value = new GSDel_EQSObjRun();
				(value as GSDel_EQSObjRun).EventId = 289;
				(value as GSDel_EQSObjRun)._OwnerEventCollectionCS = this;
				_EventObjCache[289] = value;
			}
			return value as GSDel_EQSObjRun;
		}
		set
		{
		}
	}

	public GSDel_EQSObjRunInstant Evt_BGS_EQSObjRunInstant
	{
		get
		{
			if (!_EventObjCache.TryGetValue(290, out var value))
			{
				value = new GSDel_EQSObjRunInstant();
				(value as GSDel_EQSObjRunInstant).EventId = 290;
				(value as GSDel_EQSObjRunInstant)._OwnerEventCollectionCS = this;
				_EventObjCache[290] = value;
			}
			return value as GSDel_EQSObjRunInstant;
		}
		set
		{
		}
	}

	public GSDel_EQSObjRunWithCustomParams Evt_BGS_EQSObjRunWithCustomParams
	{
		get
		{
			if (!_EventObjCache.TryGetValue(291, out var value))
			{
				value = new GSDel_EQSObjRunWithCustomParams();
				(value as GSDel_EQSObjRunWithCustomParams).EventId = 291;
				(value as GSDel_EQSObjRunWithCustomParams)._OwnerEventCollectionCS = this;
				_EventObjCache[291] = value;
			}
			return value as GSDel_EQSObjRunWithCustomParams;
		}
		set
		{
		}
	}

	public GSDel_EQSObjRunInstantWithCustomParams Evt_BGS_EQSObjRunInstantWithCustomParams
	{
		get
		{
			if (!_EventObjCache.TryGetValue(292, out var value))
			{
				value = new GSDel_EQSObjRunInstantWithCustomParams();
				(value as GSDel_EQSObjRunInstantWithCustomParams).EventId = 292;
				(value as GSDel_EQSObjRunInstantWithCustomParams)._OwnerEventCollectionCS = this;
				_EventObjCache[292] = value;
			}
			return value as GSDel_EQSObjRunInstantWithCustomParams;
		}
		set
		{
		}
	}

	public GSDel_Void_UObject Evt_BGS_CollectEQSFunctionBinder
	{
		get
		{
			if (!_EventObjCache.TryGetValue(293, out var value))
			{
				value = new GSDel_Void_UObject();
				(value as GSDel_Void_UObject).EventId = 293;
				(value as GSDel_Void_UObject)._OwnerEventCollectionCS = this;
				_EventObjCache[293] = value;
			}
			return value as GSDel_Void_UObject;
		}
		set
		{
		}
	}

	public GSDel_CreatePlayMontageProxy Evt_BGS_CreateBGUPlayMontageCallbackProxy
	{
		get
		{
			if (!_EventObjCache.TryGetValue(294, out var value))
			{
				value = new GSDel_CreatePlayMontageProxy();
				(value as GSDel_CreatePlayMontageProxy).EventId = 294;
				(value as GSDel_CreatePlayMontageProxy)._OwnerEventCollectionCS = this;
				_EventObjCache[294] = value;
			}
			return value as GSDel_CreatePlayMontageProxy;
		}
		set
		{
		}
	}

	public GSDel_CleanPlayMontageCallbackProxy Evt_BGS_CleanBGUPlayMontageCallbackProxy
	{
		get
		{
			if (!_EventObjCache.TryGetValue(295, out var value))
			{
				value = new GSDel_CleanPlayMontageCallbackProxy();
				(value as GSDel_CleanPlayMontageCallbackProxy).EventId = 295;
				(value as GSDel_CleanPlayMontageCallbackProxy)._OwnerEventCollectionCS = this;
				_EventObjCache[295] = value;
			}
			return value as GSDel_CleanPlayMontageCallbackProxy;
		}
		set
		{
		}
	}

	public GSDel_CollectReplicateData Evt_BGS_CollectReplicateData
	{
		get
		{
			if (!_EventObjCache.TryGetValue(296, out var value))
			{
				value = new GSDel_CollectReplicateData();
				(value as GSDel_CollectReplicateData).EventId = 296;
				(value as GSDel_CollectReplicateData)._OwnerEventCollectionCS = this;
				_EventObjCache[296] = value;
			}
			return value as GSDel_CollectReplicateData;
		}
		set
		{
		}
	}

	public GSDel_DoReplicateData Evt_BGS_DoReplicateData
	{
		get
		{
			if (!_EventObjCache.TryGetValue(297, out var value))
			{
				value = new GSDel_DoReplicateData();
				(value as GSDel_DoReplicateData).EventId = 297;
				(value as GSDel_DoReplicateData)._OwnerEventCollectionCS = this;
				_EventObjCache[297] = value;
			}
			return value as GSDel_DoReplicateData;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BGS_PreBGUCharacterDeadDestroy
	{
		get
		{
			if (!_EventObjCache.TryGetValue(298, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 298;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[298] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BGS_PostBGUCharacterDeadDestroy
	{
		get
		{
			if (!_EventObjCache.TryGetValue(299, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 299;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[299] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_RegisterTamerAuthInfo Evt_BGS_RegisterTamerAuthInfo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(300, out var value))
			{
				value = new GSDel_RegisterTamerAuthInfo();
				(value as GSDel_RegisterTamerAuthInfo).EventId = 300;
				(value as GSDel_RegisterTamerAuthInfo)._OwnerEventCollectionCS = this;
				_EventObjCache[300] = value;
			}
			return value as GSDel_RegisterTamerAuthInfo;
		}
		set
		{
		}
	}

	public GSDel_UnRegisterTamerAuthInfo Evt_BGS_UnRegisterTamerAuthInfo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(301, out var value))
			{
				value = new GSDel_UnRegisterTamerAuthInfo();
				(value as GSDel_UnRegisterTamerAuthInfo).EventId = 301;
				(value as GSDel_UnRegisterTamerAuthInfo)._OwnerEventCollectionCS = this;
				_EventObjCache[301] = value;
			}
			return value as GSDel_UnRegisterTamerAuthInfo;
		}
		set
		{
		}
	}

	public GSDel_ActorChannelClose Evt_BGS_ActorChannelClose
	{
		get
		{
			if (!_EventObjCache.TryGetValue(302, out var value))
			{
				value = new GSDel_ActorChannelClose();
				(value as GSDel_ActorChannelClose).EventId = 302;
				(value as GSDel_ActorChannelClose)._OwnerEventCollectionCS = this;
				_EventObjCache[302] = value;
			}
			return value as GSDel_ActorChannelClose;
		}
		set
		{
		}
	}

	public GSDel_ActorChannelCleanUp Evt_BGS_ActorChannelCleanUp
	{
		get
		{
			if (!_EventObjCache.TryGetValue(303, out var value))
			{
				value = new GSDel_ActorChannelCleanUp();
				(value as GSDel_ActorChannelCleanUp).EventId = 303;
				(value as GSDel_ActorChannelCleanUp)._OwnerEventCollectionCS = this;
				_EventObjCache[303] = value;
			}
			return value as GSDel_ActorChannelCleanUp;
		}
		set
		{
		}
	}

	public GSDel_ActorChannelOpen Evt_BGS_ActorChannelOpen
	{
		get
		{
			if (!_EventObjCache.TryGetValue(304, out var value))
			{
				value = new GSDel_ActorChannelOpen();
				(value as GSDel_ActorChannelOpen).EventId = 304;
				(value as GSDel_ActorChannelOpen)._OwnerEventCollectionCS = this;
				_EventObjCache[304] = value;
			}
			return value as GSDel_ActorChannelOpen;
		}
		set
		{
		}
	}

	public GSDel_DestructionDropItem Evt_BGS_DestructionDropItem
	{
		get
		{
			if (!_EventObjCache.TryGetValue(305, out var value))
			{
				value = new GSDel_DestructionDropItem();
				(value as GSDel_DestructionDropItem).EventId = 305;
				(value as GSDel_DestructionDropItem)._OwnerEventCollectionCS = this;
				_EventObjCache[305] = value;
			}
			return value as GSDel_DestructionDropItem;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_PlayerEnterInteractWindow
	{
		get
		{
			if (!_EventObjCache.TryGetValue(306, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 306;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[306] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_MeditationRecoverAttrRecord
	{
		get
		{
			if (!_EventObjCache.TryGetValue(307, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 307;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[307] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_ActorInt Evt_BGS_OnNavWalkOptLevelChange
	{
		get
		{
			if (!_EventObjCache.TryGetValue(308, out var value))
			{
				value = new GSDel_Void_ActorInt();
				(value as GSDel_Void_ActorInt).EventId = 308;
				(value as GSDel_Void_ActorInt)._OwnerEventCollectionCS = this;
				_EventObjCache[308] = value;
			}
			return value as GSDel_Void_ActorInt;
		}
		set
		{
		}
	}

	public GSDel_Void_Bool Evt_BGS_OnNavWalkOptMassiveModeChange
	{
		get
		{
			if (!_EventObjCache.TryGetValue(309, out var value))
			{
				value = new GSDel_Void_Bool();
				(value as GSDel_Void_Bool).EventId = 309;
				(value as GSDel_Void_Bool)._OwnerEventCollectionCS = this;
				_EventObjCache[309] = value;
			}
			return value as GSDel_Void_Bool;
		}
		set
		{
		}
	}

	public GSDel_Actor_Bool Evt_BGS_OnPauseCameraShakeByActor
	{
		get
		{
			if (!_EventObjCache.TryGetValue(310, out var value))
			{
				value = new GSDel_Actor_Bool();
				(value as GSDel_Actor_Bool).EventId = 310;
				(value as GSDel_Actor_Bool)._OwnerEventCollectionCS = this;
				_EventObjCache[310] = value;
			}
			return value as GSDel_Actor_Bool;
		}
		set
		{
		}
	}

	public GSDel_Bool_Void Evt_BGS_CanEnvironmentInteractLineTrace
	{
		get
		{
			if (!_EventObjCache.TryGetValue(311, out var value))
			{
				value = new GSDel_Bool_Void();
				(value as GSDel_Bool_Void).EventId = 311;
				(value as GSDel_Bool_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[311] = value;
			}
			return value as GSDel_Bool_Void;
		}
		set
		{
		}
	}

	public GSDel_OnSyncPlayGroupLeisureMontage Evt_BGS_OnSyncPlayGroupLeisureMontage
	{
		get
		{
			if (!_EventObjCache.TryGetValue(312, out var value))
			{
				value = new GSDel_OnSyncPlayGroupLeisureMontage();
				(value as GSDel_OnSyncPlayGroupLeisureMontage).EventId = 312;
				(value as GSDel_OnSyncPlayGroupLeisureMontage)._OwnerEventCollectionCS = this;
				_EventObjCache[312] = value;
			}
			return value as GSDel_OnSyncPlayGroupLeisureMontage;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BGS_OnEnterLevelSequenceClearBattleItem
	{
		get
		{
			if (!_EventObjCache.TryGetValue(313, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 313;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[313] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Actor Evt_BGS_OnRegisterAllowUseSpecialItemArea
	{
		get
		{
			if (!_EventObjCache.TryGetValue(314, out var value))
			{
				value = new GSDel_Actor();
				(value as GSDel_Actor).EventId = 314;
				(value as GSDel_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[314] = value;
			}
			return value as GSDel_Actor;
		}
		set
		{
		}
	}

	public GSDel_Actor Evt_BGS_OnUnregisterAllowUseSpecialItemArea
	{
		get
		{
			if (!_EventObjCache.TryGetValue(315, out var value))
			{
				value = new GSDel_Actor();
				(value as GSDel_Actor).EventId = 315;
				(value as GSDel_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[315] = value;
			}
			return value as GSDel_Actor;
		}
		set
		{
		}
	}

	public GSDel_Void_ActorString Evt_BGS_RegisterBattleSCMember
	{
		get
		{
			if (!_EventObjCache.TryGetValue(316, out var value))
			{
				value = new GSDel_Void_ActorString();
				(value as GSDel_Void_ActorString).EventId = 316;
				(value as GSDel_Void_ActorString)._OwnerEventCollectionCS = this;
				_EventObjCache[316] = value;
			}
			return value as GSDel_Void_ActorString;
		}
		set
		{
		}
	}

	public GSDel_Void_ActorString Evt_BGS_UnRegistBattleSCMember
	{
		get
		{
			if (!_EventObjCache.TryGetValue(317, out var value))
			{
				value = new GSDel_Void_ActorString();
				(value as GSDel_Void_ActorString).EventId = 317;
				(value as GSDel_Void_ActorString)._OwnerEventCollectionCS = this;
				_EventObjCache[317] = value;
			}
			return value as GSDel_Void_ActorString;
		}
		set
		{
		}
	}

	public GSDel_BattleSCReceiveMessage Evt_BGS_BattleSCReceiveMessage
	{
		get
		{
			if (!_EventObjCache.TryGetValue(318, out var value))
			{
				value = new GSDel_BattleSCReceiveMessage();
				(value as GSDel_BattleSCReceiveMessage).EventId = 318;
				(value as GSDel_BattleSCReceiveMessage)._OwnerEventCollectionCS = this;
				_EventObjCache[318] = value;
			}
			return value as GSDel_BattleSCReceiveMessage;
		}
		set
		{
		}
	}

	public GSDel_BattleSCReceiveMessageByReason Evt_BGS_BattleSCReceiveMessageByReason
	{
		get
		{
			if (!_EventObjCache.TryGetValue(319, out var value))
			{
				value = new GSDel_BattleSCReceiveMessageByReason();
				(value as GSDel_BattleSCReceiveMessageByReason).EventId = 319;
				(value as GSDel_BattleSCReceiveMessageByReason)._OwnerEventCollectionCS = this;
				_EventObjCache[319] = value;
			}
			return value as GSDel_BattleSCReceiveMessageByReason;
		}
		set
		{
		}
	}

	public GSDel_BattleSCMulticastCachedPointSet Evt_BGS_BattleSCMulticastCachedPointSet
	{
		get
		{
			if (!_EventObjCache.TryGetValue(320, out var value))
			{
				value = new GSDel_BattleSCMulticastCachedPointSet();
				(value as GSDel_BattleSCMulticastCachedPointSet).EventId = 320;
				(value as GSDel_BattleSCMulticastCachedPointSet)._OwnerEventCollectionCS = this;
				_EventObjCache[320] = value;
			}
			return value as GSDel_BattleSCMulticastCachedPointSet;
		}
		set
		{
		}
	}

	public event Del_Evt_BGS_TriggerShortcutServer_Validate Evt_BGS_TriggerShortcutServer_Validate;

	public event Del_Evt_PostMulticastAkEventServer_Validate Evt_PostMulticastAkEventServer_Validate;

	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		base.BeginPlayInCS_Implementation();
		SetIsReplicated(ShouldReplicate: true);
	}

	public static BGS_GSEventCollection Get(UObject WorldContext)
	{
		return (UGameplayStatics.GetGameState(WorldContext) as BGGGameStateCS)?.GameEventCollection;
	}

	public static BGS_GSEventCollection Get(AActor Actor)
	{
		return (UGameplayStatics.GetGameState(Actor) as BGGGameStateCS)?.GameEventCollection;
	}

	public static BGS_GSEventCollection Get(UActorCompBaseCS Comp)
	{
		return Get(Comp.GetOwner());
	}

	public static BGS_GSEventCollection Get(UActorCompBaseUObj Comp)
	{
		return Get(Comp.GetOwner());
	}

	public static BGS_GSEventCollection Get(UBaseActorComp Comp)
	{
		return Get(Comp.GetOwner());
	}

	private void Evt_BGS_TestGameState_DelChg(Del_Void_Int NewDel)
	{
		Evt_BGS_TestGameState_imp = NewDel;
	}

	public void Evt_BGS_TestGameState_Invoke(int P1)
	{
		if (base.HasAuthority)
		{
			Evt_BGS_TestGameState_Multicast_Invoke(P1);
		}
	}

	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = false)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_TestGameState_Multicast_Invoke")]
	public unsafe void Evt_BGS_TestGameState_Multicast_Invoke(int P1)
	{
		CheckDestroyed();
		if (!Evt_BGS_TestGameState_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_TestGameState_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BGS_TestGameState_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BGS_TestGameState_Multicast_Invoke_ParamsSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Evt_BGS_TestGameState_Multicast_Invoke_P1_Offset), P1);
		NativeReflection.InvokeFunction(base.Address, Evt_BGS_TestGameState_Multicast_Invoke_FunctionAddress, intPtr, Evt_BGS_TestGameState_Multicast_Invoke_ParamsSize);
	}

	[UFunction]
	public void Evt_BGS_TestGameState_Multicast_Invoke_Implementation(int P1)
	{
		Evt_BGS_TestGameState_imp?.Invoke(P1);
	}

	private void Evt_BGS_SwitchTickRateLogic_DelChg(Del_Void_Int NewDel)
	{
		Evt_BGS_SwitchTickRateLogic_imp = NewDel;
	}

	public void Evt_BGS_SwitchTickRateLogic_Invoke(int P1)
	{
		if (base.HasAuthority)
		{
			Evt_BGS_SwitchTickRateLogic_Multicast_Invoke(P1);
		}
	}

	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = false)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_SwitchTickRateLogic_Multicast_Invoke")]
	public unsafe void Evt_BGS_SwitchTickRateLogic_Multicast_Invoke(int P1)
	{
		CheckDestroyed();
		if (!Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_SwitchTickRateLogic_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_ParamsSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_P1_Offset), P1);
		NativeReflection.InvokeFunction(base.Address, Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_FunctionAddress, intPtr, Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_ParamsSize);
	}

	[UFunction]
	public void Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_Implementation(int P1)
	{
		Evt_BGS_SwitchTickRateLogic_imp?.Invoke(P1);
	}

	private void Evt_BGS_UnitDead_DelChg(Del_Void_StringDeadReason NewDel)
	{
		Evt_BGS_UnitDead_imp = NewDel;
	}

	public void Evt_BGS_UnitDead_Invoke(string UnitGuid, EDeadReason DeadReason)
	{
		if (base.HasAuthority)
		{
			Evt_BGS_UnitDead_Multicast_Invoke(UnitGuid, DeadReason);
		}
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = true)]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_UnitDead_Multicast_Invoke")]
	public unsafe void Evt_BGS_UnitDead_Multicast_Invoke(string UnitGuid, EDeadReason DeadReason)
	{
		CheckDestroyed();
		if (!Evt_BGS_UnitDead_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_UnitDead_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BGS_UnitDead_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BGS_UnitDead_Multicast_Invoke_ParamsSize);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Evt_BGS_UnitDead_Multicast_Invoke_UnitGuid_Offset), UnitGuid);
		EnumMarshaler<EDeadReason>.ToNative(IntPtr.Add(intPtr, Evt_BGS_UnitDead_Multicast_Invoke_DeadReason_Offset), 0, Evt_BGS_UnitDead_Multicast_Invoke_DeadReason_PropertyAddress.Address, DeadReason);
		NativeReflection.InvokeFunction(base.Address, Evt_BGS_UnitDead_Multicast_Invoke_FunctionAddress, intPtr, Evt_BGS_UnitDead_Multicast_Invoke_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Evt_BGS_UnitDead_Multicast_Invoke_UnitGuid_PropertyAddress.Address, intPtr);
	}

	[UFunction]
	public void Evt_BGS_UnitDead_Multicast_Invoke_Implementation(string UnitGuid, EDeadReason DeadReason)
	{
		Evt_BGS_UnitDead_imp?.Invoke(UnitGuid, DeadReason);
	}

	private void Evt_BGS_OnUnitTransited_DelChg(Del_BGS_OnUnitTransited NewDel)
	{
		Evt_BGS_OnUnitTransited_imp = NewDel;
	}

	public void Evt_BGS_OnUnitTransited_Invoke(AActor OldUnit, AActor NewlySpawnedUnit)
	{
		if (base.HasAuthority)
		{
			Evt_BGS_OnUnitTransited_Multicast_Invoke(OldUnit, NewlySpawnedUnit);
		}
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = true)]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_OnUnitTransited_Multicast_Invoke")]
	public unsafe void Evt_BGS_OnUnitTransited_Multicast_Invoke(AActor OldUnit, AActor NewlySpawnedUnit)
	{
		CheckDestroyed();
		if (!Evt_BGS_OnUnitTransited_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_OnUnitTransited_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BGS_OnUnitTransited_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BGS_OnUnitTransited_Multicast_Invoke_ParamsSize);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, Evt_BGS_OnUnitTransited_Multicast_Invoke_OldUnit_Offset), OldUnit);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, Evt_BGS_OnUnitTransited_Multicast_Invoke_NewlySpawnedUnit_Offset), NewlySpawnedUnit);
		NativeReflection.InvokeFunction(base.Address, Evt_BGS_OnUnitTransited_Multicast_Invoke_FunctionAddress, intPtr, Evt_BGS_OnUnitTransited_Multicast_Invoke_ParamsSize);
	}

	[UFunction]
	public void Evt_BGS_OnUnitTransited_Multicast_Invoke_Implementation(AActor OldUnit, AActor NewlySpawnedUnit)
	{
		Evt_BGS_OnUnitTransited_imp?.Invoke(OldUnit, NewlySpawnedUnit);
	}

	private void Evt_BGS_NotifySwitchTarget_DelChg(Del_BGS_NotifySwitchTarget NewDel)
	{
		Evt_BGS_NotifySwitchTarget_imp = NewDel;
	}

	public void Evt_BGS_NotifySwitchTarget_Invoke(AActor OldTarget, AActor NewTarget, bool TriggerTaunt, ETargetSourceType TargetSourceType)
	{
		if (base.HasAuthority)
		{
			Evt_BGS_NotifySwitchTarget_Multicast_Invoke(OldTarget, NewTarget, TriggerTaunt, TargetSourceType);
		}
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = false)]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_NotifySwitchTarget_Multicast_Invoke")]
	public unsafe void Evt_BGS_NotifySwitchTarget_Multicast_Invoke(AActor OldTarget, AActor NewTarget, bool TriggerTaunt, ETargetSourceType TargetSourceType)
	{
		CheckDestroyed();
		if (!Evt_BGS_NotifySwitchTarget_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_NotifySwitchTarget_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BGS_NotifySwitchTarget_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BGS_NotifySwitchTarget_Multicast_Invoke_ParamsSize);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, Evt_BGS_NotifySwitchTarget_Multicast_Invoke_OldTarget_Offset), OldTarget);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, Evt_BGS_NotifySwitchTarget_Multicast_Invoke_NewTarget_Offset), NewTarget);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TriggerTaunt_Offset), 0, Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TriggerTaunt_PropertyAddress.Address, TriggerTaunt);
		EnumMarshaler<ETargetSourceType>.ToNative(IntPtr.Add(intPtr, Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TargetSourceType_Offset), 0, Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TargetSourceType_PropertyAddress.Address, TargetSourceType);
		NativeReflection.InvokeFunction(base.Address, Evt_BGS_NotifySwitchTarget_Multicast_Invoke_FunctionAddress, intPtr, Evt_BGS_NotifySwitchTarget_Multicast_Invoke_ParamsSize);
	}

	[UFunction]
	public void Evt_BGS_NotifySwitchTarget_Multicast_Invoke_Implementation(AActor OldTarget, AActor NewTarget, bool TriggerTaunt, ETargetSourceType TargetSourceType)
	{
		Evt_BGS_NotifySwitchTarget_imp?.Invoke(OldTarget, NewTarget, TriggerTaunt, TargetSourceType);
	}

	private void Evt_BGS_NotifyCopyHatredInfo_DelChg(Del_BGS_NotifyCopyHatredInfo NewDel)
	{
		Evt_BGS_NotifyCopyHatredInfo_imp = NewDel;
	}

	public void Evt_BGS_NotifyCopyHatredInfo_Invoke(AActor OriginActor, AActor CopyActor, bool bRemoveOriginHatredInfo)
	{
		if (base.HasAuthority)
		{
			Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke(OriginActor, CopyActor, bRemoveOriginHatredInfo);
		}
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = false)]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke")]
	public unsafe void Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke(AActor OriginActor, AActor CopyActor, bool bRemoveOriginHatredInfo)
	{
		CheckDestroyed();
		if (!Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_ParamsSize);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_OriginActor_Offset), OriginActor);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_CopyActor_Offset), CopyActor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_bRemoveOriginHatredInfo_Offset), 0, Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_bRemoveOriginHatredInfo_PropertyAddress.Address, bRemoveOriginHatredInfo);
		NativeReflection.InvokeFunction(base.Address, Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_FunctionAddress, intPtr, Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_ParamsSize);
	}

	[UFunction]
	public void Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_Implementation(AActor OriginActor, AActor CopyActor, bool bRemoveOriginHatredInfo)
	{
		Evt_BGS_NotifyCopyHatredInfo_imp?.Invoke(OriginActor, CopyActor, bRemoveOriginHatredInfo);
	}

	private void Evt_BGS_TriggerShortcut_DelChg(Del_BGS_BoolInt NewDel)
	{
		Evt_BGS_TriggerShortcut_imp = NewDel;
	}

	public void Evt_BGS_TriggerShortcut_Invoke(bool B1, int P2)
	{
		if (GetOwner().GetLocalRole() != ENetRole.ROLE_SimulatedProxy && !BGUFunctionLibraryCS.IsRemoteControlPawn(GetOwner()))
		{
			if (base.HasAuthority)
			{
				Evt_BGS_TriggerShortcutMultiCast(B1, P2);
			}
			else
			{
				Evt_BGS_TriggerShortcutServer(B1, P2);
			}
		}
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = false)]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_TriggerShortcutMultiCast")]
	public unsafe void Evt_BGS_TriggerShortcutMultiCast(bool B1, int P2)
	{
		CheckDestroyed();
		if (!Evt_BGS_TriggerShortcutMultiCast_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_TriggerShortcutMultiCast");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BGS_TriggerShortcutMultiCast_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BGS_TriggerShortcutMultiCast_ParamsSize);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Evt_BGS_TriggerShortcutMultiCast_B1_Offset), 0, Evt_BGS_TriggerShortcutMultiCast_B1_PropertyAddress.Address, B1);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Evt_BGS_TriggerShortcutMultiCast_P2_Offset), P2);
		NativeReflection.InvokeFunction(base.Address, Evt_BGS_TriggerShortcutMultiCast_FunctionAddress, intPtr, Evt_BGS_TriggerShortcutMultiCast_ParamsSize);
	}

	[UFunction]
	public void Evt_BGS_TriggerShortcutMultiCast_Implementation(bool B1, int P2)
	{
		Evt_BGS_TriggerShortcut_imp?.Invoke(B1, P2);
	}

	[RPC(Endpoint = RPCEndpoint.Server, Reliable = false)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_TriggerShortcutServer")]
	public unsafe void Evt_BGS_TriggerShortcutServer(bool B1, int P2)
	{
		CheckDestroyed();
		if (!Evt_BGS_TriggerShortcutServer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_TriggerShortcutServer");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BGS_TriggerShortcutServer_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BGS_TriggerShortcutServer_ParamsSize);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Evt_BGS_TriggerShortcutServer_B1_Offset), 0, Evt_BGS_TriggerShortcutServer_B1_PropertyAddress.Address, B1);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Evt_BGS_TriggerShortcutServer_P2_Offset), P2);
		NativeReflection.InvokeFunction(base.Address, Evt_BGS_TriggerShortcutServer_FunctionAddress, intPtr, Evt_BGS_TriggerShortcutServer_ParamsSize);
	}

	[UFunction]
	public void Evt_BGS_TriggerShortcutServer_Implementation(bool B1, int P2)
	{
		if (this.Evt_BGS_TriggerShortcutServer_Validate == null || this.Evt_BGS_TriggerShortcutServer_Validate(B1, P2))
		{
			Evt_BGS_TriggerShortcutMultiCast(B1, P2);
		}
	}

	private void Evt_RegisterServantSvr_DelChg(Del_Void_ServantInstance NewDel)
	{
		Evt_RegisterServantSvr_imp = NewDel;
	}

	public void Evt_RegisterServantSvr_Invoke(FServantInstanceBase InServantInstance)
	{
		if (base.HasAuthority)
		{
			Evt_RegisterServantSvr_imp?.Invoke(InServantInstance);
		}
	}

	private void Evt_PostMulticastAkEvent_DelChg(Del_Void_AkEvent NewDel)
	{
		Evt_PostMulticastAkEvent_imp = NewDel;
	}

	public void Evt_PostMulticastAkEvent_Invoke(UAkAudioEvent AkEvent)
	{
		if (GetOwner().GetLocalRole() != ENetRole.ROLE_SimulatedProxy && !BGUFunctionLibraryCS.IsRemoteControlPawn(GetOwner()))
		{
			if (base.HasAuthority)
			{
				Evt_PostMulticastAkEventMultiCast(AkEvent);
			}
			else
			{
				Evt_PostMulticastAkEventServer(AkEvent);
			}
		}
	}

	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = false)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_PostMulticastAkEventMultiCast")]
	public unsafe void Evt_PostMulticastAkEventMultiCast(UAkAudioEvent AkEvent)
	{
		CheckDestroyed();
		if (!Evt_PostMulticastAkEventMultiCast_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_PostMulticastAkEventMultiCast");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_PostMulticastAkEventMultiCast_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_PostMulticastAkEventMultiCast_ParamsSize);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(intPtr, Evt_PostMulticastAkEventMultiCast_AkEvent_Offset), AkEvent);
		NativeReflection.InvokeFunction(base.Address, Evt_PostMulticastAkEventMultiCast_FunctionAddress, intPtr, Evt_PostMulticastAkEventMultiCast_ParamsSize);
	}

	[UFunction]
	public void Evt_PostMulticastAkEventMultiCast_Implementation(UAkAudioEvent AkEvent)
	{
		Evt_PostMulticastAkEvent_imp?.Invoke(AkEvent);
	}

	[RPC(Endpoint = RPCEndpoint.Server, Reliable = false)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_PostMulticastAkEventServer")]
	public unsafe void Evt_PostMulticastAkEventServer(UAkAudioEvent AkEvent)
	{
		CheckDestroyed();
		if (!Evt_PostMulticastAkEventServer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_PostMulticastAkEventServer");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_PostMulticastAkEventServer_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_PostMulticastAkEventServer_ParamsSize);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(intPtr, Evt_PostMulticastAkEventServer_AkEvent_Offset), AkEvent);
		NativeReflection.InvokeFunction(base.Address, Evt_PostMulticastAkEventServer_FunctionAddress, intPtr, Evt_PostMulticastAkEventServer_ParamsSize);
	}

	[UFunction]
	public void Evt_PostMulticastAkEventServer_Implementation(UAkAudioEvent AkEvent)
	{
		if (this.Evt_PostMulticastAkEventServer_Validate == null || this.Evt_PostMulticastAkEventServer_Validate(AkEvent))
		{
			Evt_PostMulticastAkEventMultiCast(AkEvent);
		}
	}

	private void Evt_TeamWipeOut_DelChg(Del_Void NewDel)
	{
		Evt_TeamWipeOut_imp = NewDel;
	}

	public void Evt_TeamWipeOut_Invoke()
	{
		if (base.HasAuthority)
		{
			Evt_TeamWipeOut_Multicast_Invoke();
		}
	}

	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = false)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_TeamWipeOut_Multicast_Invoke")]
	public unsafe void Evt_TeamWipeOut_Multicast_Invoke()
	{
		CheckDestroyed();
		if (!Evt_TeamWipeOut_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_TeamWipeOut_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_TeamWipeOut_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_TeamWipeOut_Multicast_Invoke_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, Evt_TeamWipeOut_Multicast_Invoke_FunctionAddress, intPtr, Evt_TeamWipeOut_Multicast_Invoke_ParamsSize);
	}

	[UFunction]
	public void Evt_TeamWipeOut_Multicast_Invoke_Implementation()
	{
		Evt_TeamWipeOut_imp?.Invoke();
	}

	private void Evt_CrusadeSuccess_DelChg(Del_Void NewDel)
	{
		Evt_CrusadeSuccess_imp = NewDel;
	}

	public void Evt_CrusadeSuccess_Invoke()
	{
		if (base.HasAuthority)
		{
			Evt_CrusadeSuccess_Multicast_Invoke();
		}
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = false)]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_CrusadeSuccess_Multicast_Invoke")]
	public unsafe void Evt_CrusadeSuccess_Multicast_Invoke()
	{
		CheckDestroyed();
		if (!Evt_CrusadeSuccess_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_CrusadeSuccess_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_CrusadeSuccess_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_CrusadeSuccess_Multicast_Invoke_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, Evt_CrusadeSuccess_Multicast_Invoke_FunctionAddress, intPtr, Evt_CrusadeSuccess_Multicast_Invoke_ParamsSize);
	}

	[UFunction]
	public void Evt_CrusadeSuccess_Multicast_Invoke_Implementation()
	{
		Evt_CrusadeSuccess_imp?.Invoke();
	}

	private void Evt_BGS_SendOnlineScreenMsg_DelChg(Del_SendOnlineScreenMsg NewDel)
	{
		Evt_BGS_SendOnlineScreenMsg_imp = NewDel;
	}

	public void Evt_BGS_SendOnlineScreenMsg_Invoke(EScreenMsgType ScreenMsgType, string Msg, int TipsDuration)
	{
		if (base.HasAuthority)
		{
			Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke(ScreenMsgType, Msg, TipsDuration);
		}
	}

	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = false)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke")]
	public unsafe void Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke(EScreenMsgType ScreenMsgType, string Msg, int TipsDuration)
	{
		CheckDestroyed();
		if (!Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_ParamsSize);
		EnumMarshaler<EScreenMsgType>.ToNative(IntPtr.Add(intPtr, Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_ScreenMsgType_Offset), 0, Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_ScreenMsgType_PropertyAddress.Address, ScreenMsgType);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_Msg_Offset), Msg);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_TipsDuration_Offset), TipsDuration);
		NativeReflection.InvokeFunction(base.Address, Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_FunctionAddress, intPtr, Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_Msg_PropertyAddress.Address, intPtr);
	}

	[UFunction]
	public void Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_Implementation(EScreenMsgType ScreenMsgType, string Msg, int TipsDuration)
	{
		Evt_BGS_SendOnlineScreenMsg_imp?.Invoke(ScreenMsgType, Msg, TipsDuration);
	}

	private void Evt_BGS_OnPlayerLogOut_DelChg(Del_OnPlayerLogOut NewDel)
	{
		Evt_BGS_OnPlayerLogOut_imp = NewDel;
	}

	public void Evt_BGS_OnPlayerLogOut_Invoke(AController Exitting)
	{
		if (base.HasAuthority)
		{
			Evt_BGS_OnPlayerLogOut_Multicast_Invoke(Exitting);
		}
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = true)]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_OnPlayerLogOut_Multicast_Invoke")]
	public unsafe void Evt_BGS_OnPlayerLogOut_Multicast_Invoke(AController Exitting)
	{
		CheckDestroyed();
		if (!Evt_BGS_OnPlayerLogOut_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_OnPlayerLogOut_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BGS_OnPlayerLogOut_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BGS_OnPlayerLogOut_Multicast_Invoke_ParamsSize);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, Evt_BGS_OnPlayerLogOut_Multicast_Invoke_Exitting_Offset), Exitting);
		NativeReflection.InvokeFunction(base.Address, Evt_BGS_OnPlayerLogOut_Multicast_Invoke_FunctionAddress, intPtr, Evt_BGS_OnPlayerLogOut_Multicast_Invoke_ParamsSize);
	}

	[UFunction]
	public void Evt_BGS_OnPlayerLogOut_Multicast_Invoke_Implementation(AController Exitting)
	{
		Evt_BGS_OnPlayerLogOut_imp?.Invoke(Exitting);
	}

	private void Evt_BGS_OnPlayerPostLogin_DelChg(Del_OnPlayerPostLogin NewDel)
	{
		Evt_BGS_OnPlayerPostLogin_imp = NewDel;
	}

	public void Evt_BGS_OnPlayerPostLogin_Invoke(APlayerController NewPlayer)
	{
		if (base.HasAuthority)
		{
			Evt_BGS_OnPlayerPostLogin_Multicast_Invoke(NewPlayer);
		}
	}

	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = true)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_OnPlayerPostLogin_Multicast_Invoke")]
	public unsafe void Evt_BGS_OnPlayerPostLogin_Multicast_Invoke(APlayerController NewPlayer)
	{
		CheckDestroyed();
		if (!Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_OnPlayerPostLogin_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_ParamsSize);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_NewPlayer_Offset), NewPlayer);
		NativeReflection.InvokeFunction(base.Address, Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_FunctionAddress, intPtr, Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_ParamsSize);
	}

	[UFunction]
	public void Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_Implementation(APlayerController NewPlayer)
	{
		Evt_BGS_OnPlayerPostLogin_imp?.Invoke(NewPlayer);
	}

	private void Evt_OnlineDebugInfoEnd_DelChg(Del_Void NewDel)
	{
		Evt_OnlineDebugInfoEnd_imp = NewDel;
	}

	public void Evt_OnlineDebugInfoEnd_Invoke()
	{
		if (base.HasAuthority)
		{
			Evt_OnlineDebugInfoEnd_Multicast_Invoke();
		}
	}

	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = false)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_OnlineDebugInfoEnd_Multicast_Invoke")]
	public unsafe void Evt_OnlineDebugInfoEnd_Multicast_Invoke()
	{
		CheckDestroyed();
		if (!Evt_OnlineDebugInfoEnd_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_OnlineDebugInfoEnd_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_OnlineDebugInfoEnd_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_OnlineDebugInfoEnd_Multicast_Invoke_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, Evt_OnlineDebugInfoEnd_Multicast_Invoke_FunctionAddress, intPtr, Evt_OnlineDebugInfoEnd_Multicast_Invoke_ParamsSize);
	}

	[UFunction]
	public void Evt_OnlineDebugInfoEnd_Multicast_Invoke_Implementation()
	{
		Evt_OnlineDebugInfoEnd_imp?.Invoke();
	}

	private void Evt_BGS_ItemFullOnline_DelChg(Del_Void_Int NewDel)
	{
		Evt_BGS_ItemFullOnline_imp = NewDel;
	}

	public void Evt_BGS_ItemFullOnline_Invoke(int P1)
	{
		if (base.HasAuthority)
		{
			Evt_BGS_ItemFullOnline_Multicast_Invoke(P1);
		}
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = false)]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_ItemFullOnline_Multicast_Invoke")]
	public unsafe void Evt_BGS_ItemFullOnline_Multicast_Invoke(int P1)
	{
		CheckDestroyed();
		if (!Evt_BGS_ItemFullOnline_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_ItemFullOnline_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BGS_ItemFullOnline_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BGS_ItemFullOnline_Multicast_Invoke_ParamsSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Evt_BGS_ItemFullOnline_Multicast_Invoke_P1_Offset), P1);
		NativeReflection.InvokeFunction(base.Address, Evt_BGS_ItemFullOnline_Multicast_Invoke_FunctionAddress, intPtr, Evt_BGS_ItemFullOnline_Multicast_Invoke_ParamsSize);
	}

	[UFunction]
	public void Evt_BGS_ItemFullOnline_Multicast_Invoke_Implementation(int P1)
	{
		Evt_BGS_ItemFullOnline_imp?.Invoke(P1);
	}

	private void Evt_BGS_OnlineChallengeStateTrigger_DelChg(Del_Void_IntInt NewDel)
	{
		Evt_BGS_OnlineChallengeStateTrigger_imp = NewDel;
	}

	public void Evt_BGS_OnlineChallengeStateTrigger_Invoke(int P1, int P2)
	{
		if (base.HasAuthority)
		{
			Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke(P1, P2);
		}
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = true)]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke")]
	public unsafe void Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke(int P1, int P2)
	{
		CheckDestroyed();
		if (!Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_ParamsSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_P1_Offset), P1);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_P2_Offset), P2);
		NativeReflection.InvokeFunction(base.Address, Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_FunctionAddress, intPtr, Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_ParamsSize);
	}

	[UFunction]
	public void Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_Implementation(int P1, int P2)
	{
		Evt_BGS_OnlineChallengeStateTrigger_imp?.Invoke(P1, P2);
	}

	private void Evt_BGS_PlayerJoin_DelChg(Del_PlayerState NewDel)
	{
		Evt_BGS_PlayerJoin_imp = NewDel;
	}

	public void Evt_BGS_PlayerJoin_Invoke(APlayerState PlayerState)
	{
		if (base.HasAuthority)
		{
			Evt_BGS_PlayerJoin_Multicast_Invoke(PlayerState);
		}
	}

	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = true)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_PlayerJoin_Multicast_Invoke")]
	public unsafe void Evt_BGS_PlayerJoin_Multicast_Invoke(APlayerState PlayerState)
	{
		CheckDestroyed();
		if (!Evt_BGS_PlayerJoin_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_PlayerJoin_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BGS_PlayerJoin_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BGS_PlayerJoin_Multicast_Invoke_ParamsSize);
		UObjectMarshaler<APlayerState>.ToNative(IntPtr.Add(intPtr, Evt_BGS_PlayerJoin_Multicast_Invoke_PlayerState_Offset), PlayerState);
		NativeReflection.InvokeFunction(base.Address, Evt_BGS_PlayerJoin_Multicast_Invoke_FunctionAddress, intPtr, Evt_BGS_PlayerJoin_Multicast_Invoke_ParamsSize);
	}

	[UFunction]
	public void Evt_BGS_PlayerJoin_Multicast_Invoke_Implementation(APlayerState PlayerState)
	{
		Evt_BGS_PlayerJoin_imp?.Invoke(PlayerState);
	}

	private void Evt_BGS_PlayerLogOut_DelChg(Del_PlayerState NewDel)
	{
		Evt_BGS_PlayerLogOut_imp = NewDel;
	}

	public void Evt_BGS_PlayerLogOut_Invoke(APlayerState PlayerState)
	{
		if (base.HasAuthority)
		{
			Evt_BGS_PlayerLogOut_Multicast_Invoke(PlayerState);
		}
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = true)]
	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_PlayerLogOut_Multicast_Invoke")]
	public unsafe void Evt_BGS_PlayerLogOut_Multicast_Invoke(APlayerState PlayerState)
	{
		CheckDestroyed();
		if (!Evt_BGS_PlayerLogOut_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_PlayerLogOut_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BGS_PlayerLogOut_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BGS_PlayerLogOut_Multicast_Invoke_ParamsSize);
		UObjectMarshaler<APlayerState>.ToNative(IntPtr.Add(intPtr, Evt_BGS_PlayerLogOut_Multicast_Invoke_PlayerState_Offset), PlayerState);
		NativeReflection.InvokeFunction(base.Address, Evt_BGS_PlayerLogOut_Multicast_Invoke_FunctionAddress, intPtr, Evt_BGS_PlayerLogOut_Multicast_Invoke_ParamsSize);
	}

	[UFunction]
	public void Evt_BGS_PlayerLogOut_Multicast_Invoke_Implementation(APlayerState PlayerState)
	{
		Evt_BGS_PlayerLogOut_imp?.Invoke(PlayerState);
	}

	[USharpPath("/Script/b1-Managed.BGS_GSEventCollection:EndPlayInCS")]
	protected override void EndPlayInCS_Implementation(EEndPlayReason EndPlayReason)
	{
		base.EndPlayInCS_Implementation(EndPlayReason);
		Evt_BGS_TestGameState_imp = null;
		Evt_BGS_SwitchTickRateLogic_imp = null;
		Evt_BGS_UnitDead_imp = null;
		Evt_BGS_OnUnitTransited_imp = null;
		Evt_BGS_NotifySwitchTarget_imp = null;
		Evt_BGS_NotifyCopyHatredInfo_imp = null;
		Evt_BGS_TriggerShortcut_imp = null;
		Evt_RegisterServantSvr_imp = null;
		Evt_PostMulticastAkEvent_imp = null;
		Evt_TeamWipeOut_imp = null;
		Evt_CrusadeSuccess_imp = null;
		Evt_BGS_SendOnlineScreenMsg_imp = null;
		Evt_BGS_OnPlayerLogOut_imp = null;
		Evt_BGS_OnPlayerPostLogin_imp = null;
		Evt_OnlineDebugInfoEnd_imp = null;
		Evt_BGS_ItemFullOnline_imp = null;
		Evt_BGS_OnlineChallengeStateTrigger_imp = null;
		Evt_BGS_PlayerJoin_imp = null;
		Evt_BGS_PlayerLogOut_imp = null;
	}

	static BGS_GSEventCollection()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGS_GSEventCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGS_GSEventCollection));
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:EndPlayInCS")]
	private static void EndPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, EndPlayInCS_EndPlayReason_Offset), 0, EndPlayInCS_EndPlayReason_PropertyAddress.Address);
		bGS_GSEventCollection.EndPlayInCS_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		bGS_GSEventCollection.BeginPlayInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_TriggerShortcutServer")]
	private static void Evt_BGS_TriggerShortcutServer__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		bool b = BoolMarshaler.FromNative(IntPtr.Add(buffer, Evt_BGS_TriggerShortcutServer_B1_Offset), 0, Evt_BGS_TriggerShortcutServer_B1_PropertyAddress.Address);
		int p = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, Evt_BGS_TriggerShortcutServer_P2_Offset));
		bGS_GSEventCollection.Evt_BGS_TriggerShortcutServer_Implementation(b, p);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_PostMulticastAkEventServer")]
	private static void Evt_PostMulticastAkEventServer__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		UAkAudioEvent akEvent = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(buffer, Evt_PostMulticastAkEventServer_AkEvent_Offset));
		bGS_GSEventCollection.Evt_PostMulticastAkEventServer_Implementation(akEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_TeamWipeOut_Multicast_Invoke")]
	private static void Evt_TeamWipeOut_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		bGS_GSEventCollection.Evt_TeamWipeOut_Multicast_Invoke_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_TriggerShortcutMultiCast")]
	private static void Evt_BGS_TriggerShortcutMultiCast__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		bool b = BoolMarshaler.FromNative(IntPtr.Add(buffer, Evt_BGS_TriggerShortcutMultiCast_B1_Offset), 0, Evt_BGS_TriggerShortcutMultiCast_B1_PropertyAddress.Address);
		int p = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, Evt_BGS_TriggerShortcutMultiCast_P2_Offset));
		bGS_GSEventCollection.Evt_BGS_TriggerShortcutMultiCast_Implementation(b, p);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_PostMulticastAkEventMultiCast")]
	private static void Evt_PostMulticastAkEventMultiCast__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		UAkAudioEvent akEvent = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(buffer, Evt_PostMulticastAkEventMultiCast_AkEvent_Offset));
		bGS_GSEventCollection.Evt_PostMulticastAkEventMultiCast_Implementation(akEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_UnitDead_Multicast_Invoke")]
	private static void Evt_BGS_UnitDead_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		string unitGuid = FStringMarshaler.FromNative(IntPtr.Add(buffer, Evt_BGS_UnitDead_Multicast_Invoke_UnitGuid_Offset));
		EDeadReason deadReason = EnumMarshaler<EDeadReason>.FromNative(IntPtr.Add(buffer, Evt_BGS_UnitDead_Multicast_Invoke_DeadReason_Offset), 0, Evt_BGS_UnitDead_Multicast_Invoke_DeadReason_PropertyAddress.Address);
		bGS_GSEventCollection.Evt_BGS_UnitDead_Multicast_Invoke_Implementation(unitGuid, deadReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_CrusadeSuccess_Multicast_Invoke")]
	private static void Evt_CrusadeSuccess_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		bGS_GSEventCollection.Evt_CrusadeSuccess_Multicast_Invoke_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_PlayerJoin_Multicast_Invoke")]
	private static void Evt_BGS_PlayerJoin_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		APlayerState playerState = UObjectMarshaler<APlayerState>.FromNative(IntPtr.Add(buffer, Evt_BGS_PlayerJoin_Multicast_Invoke_PlayerState_Offset));
		bGS_GSEventCollection.Evt_BGS_PlayerJoin_Multicast_Invoke_Implementation(playerState);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_PlayerLogOut_Multicast_Invoke")]
	private static void Evt_BGS_PlayerLogOut_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		APlayerState playerState = UObjectMarshaler<APlayerState>.FromNative(IntPtr.Add(buffer, Evt_BGS_PlayerLogOut_Multicast_Invoke_PlayerState_Offset));
		bGS_GSEventCollection.Evt_BGS_PlayerLogOut_Multicast_Invoke_Implementation(playerState);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_TestGameState_Multicast_Invoke")]
	private static void Evt_BGS_TestGameState_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		int p = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, Evt_BGS_TestGameState_Multicast_Invoke_P1_Offset));
		bGS_GSEventCollection.Evt_BGS_TestGameState_Multicast_Invoke_Implementation(p);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_OnlineDebugInfoEnd_Multicast_Invoke")]
	private static void Evt_OnlineDebugInfoEnd_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		bGS_GSEventCollection.Evt_OnlineDebugInfoEnd_Multicast_Invoke_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_OnPlayerLogOut_Multicast_Invoke")]
	private static void Evt_BGS_OnPlayerLogOut_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		AController exitting = UObjectMarshaler<AController>.FromNative(IntPtr.Add(buffer, Evt_BGS_OnPlayerLogOut_Multicast_Invoke_Exitting_Offset));
		bGS_GSEventCollection.Evt_BGS_OnPlayerLogOut_Multicast_Invoke_Implementation(exitting);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_ItemFullOnline_Multicast_Invoke")]
	private static void Evt_BGS_ItemFullOnline_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		int p = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, Evt_BGS_ItemFullOnline_Multicast_Invoke_P1_Offset));
		bGS_GSEventCollection.Evt_BGS_ItemFullOnline_Multicast_Invoke_Implementation(p);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_OnUnitTransited_Multicast_Invoke")]
	private static void Evt_BGS_OnUnitTransited_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		AActor oldUnit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, Evt_BGS_OnUnitTransited_Multicast_Invoke_OldUnit_Offset));
		AActor newlySpawnedUnit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, Evt_BGS_OnUnitTransited_Multicast_Invoke_NewlySpawnedUnit_Offset));
		bGS_GSEventCollection.Evt_BGS_OnUnitTransited_Multicast_Invoke_Implementation(oldUnit, newlySpawnedUnit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_OnPlayerPostLogin_Multicast_Invoke")]
	private static void Evt_BGS_OnPlayerPostLogin_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		APlayerController newPlayer = UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(buffer, Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_NewPlayer_Offset));
		bGS_GSEventCollection.Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_Implementation(newPlayer);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_NotifySwitchTarget_Multicast_Invoke")]
	private static void Evt_BGS_NotifySwitchTarget_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		AActor oldTarget = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, Evt_BGS_NotifySwitchTarget_Multicast_Invoke_OldTarget_Offset));
		AActor newTarget = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, Evt_BGS_NotifySwitchTarget_Multicast_Invoke_NewTarget_Offset));
		bool triggerTaunt = BoolMarshaler.FromNative(IntPtr.Add(buffer, Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TriggerTaunt_Offset), 0, Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TriggerTaunt_PropertyAddress.Address);
		ETargetSourceType targetSourceType = EnumMarshaler<ETargetSourceType>.FromNative(IntPtr.Add(buffer, Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TargetSourceType_Offset), 0, Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TargetSourceType_PropertyAddress.Address);
		bGS_GSEventCollection.Evt_BGS_NotifySwitchTarget_Multicast_Invoke_Implementation(oldTarget, newTarget, triggerTaunt, targetSourceType);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_SwitchTickRateLogic_Multicast_Invoke")]
	private static void Evt_BGS_SwitchTickRateLogic_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		int p = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_P1_Offset));
		bGS_GSEventCollection.Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_Implementation(p);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke")]
	private static void Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		EScreenMsgType screenMsgType = EnumMarshaler<EScreenMsgType>.FromNative(IntPtr.Add(buffer, Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_ScreenMsgType_Offset), 0, Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_ScreenMsgType_PropertyAddress.Address);
		string msg = FStringMarshaler.FromNative(IntPtr.Add(buffer, Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_Msg_Offset));
		int tipsDuration = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_TipsDuration_Offset));
		bGS_GSEventCollection.Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_Implementation(screenMsgType, msg, tipsDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke")]
	private static void Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		AActor originActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_OriginActor_Offset));
		AActor copyActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_CopyActor_Offset));
		bool bRemoveOriginHatredInfo = BoolMarshaler.FromNative(IntPtr.Add(buffer, Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_bRemoveOriginHatredInfo_Offset), 0, Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_bRemoveOriginHatredInfo_PropertyAddress.Address);
		bGS_GSEventCollection.Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_Implementation(originActor, copyActor, bRemoveOriginHatredInfo);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke")]
	private static void Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGS_GSEventCollection bGS_GSEventCollection = GCHelper.Find<BGS_GSEventCollection>(obj);
		int p = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_P1_Offset));
		int p2 = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_P2_Offset));
		bGS_GSEventCollection.Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_Implementation(p, p2);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGS_GSEventCollection");
		EndPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EndPlayInCS");
		EndPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(EndPlayInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref EndPlayInCS_EndPlayReason_PropertyAddress, EndPlayInCS_FunctionAddress, "EndPlayReason");
		EndPlayInCS_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(EndPlayInCS_FunctionAddress, "EndPlayReason");
		EndPlayInCS_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(EndPlayInCS_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		EndPlayInCS_IsValid = EndPlayInCS_FunctionAddress != IntPtr.Zero && EndPlayInCS_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:EndPlayInCS", EndPlayInCS_IsValid);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:BeginPlayInCS", BeginPlayInCS_IsValid);
		Evt_BGS_TriggerShortcutServer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BGS_TriggerShortcutServer");
		Evt_BGS_TriggerShortcutServer_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BGS_TriggerShortcutServer_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Evt_BGS_TriggerShortcutServer_B1_PropertyAddress, Evt_BGS_TriggerShortcutServer_FunctionAddress, "B1");
		Evt_BGS_TriggerShortcutServer_B1_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_TriggerShortcutServer_FunctionAddress, "B1");
		Evt_BGS_TriggerShortcutServer_B1_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_TriggerShortcutServer_FunctionAddress, "B1", Classes.FBoolProperty);
		Evt_BGS_TriggerShortcutServer_P2_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_TriggerShortcutServer_FunctionAddress, "P2");
		Evt_BGS_TriggerShortcutServer_P2_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_TriggerShortcutServer_FunctionAddress, "P2", Classes.FIntProperty);
		Evt_BGS_TriggerShortcutServer_IsValid = Evt_BGS_TriggerShortcutServer_FunctionAddress != IntPtr.Zero && Evt_BGS_TriggerShortcutServer_B1_IsValid && Evt_BGS_TriggerShortcutServer_P2_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_TriggerShortcutServer", Evt_BGS_TriggerShortcutServer_IsValid);
		Evt_PostMulticastAkEventServer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_PostMulticastAkEventServer");
		Evt_PostMulticastAkEventServer_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_PostMulticastAkEventServer_FunctionAddress);
		Evt_PostMulticastAkEventServer_AkEvent_Offset = NativeReflection.GetPropertyOffset(Evt_PostMulticastAkEventServer_FunctionAddress, "AkEvent");
		Evt_PostMulticastAkEventServer_AkEvent_IsValid = NativeReflection.ValidatePropertyClass(Evt_PostMulticastAkEventServer_FunctionAddress, "AkEvent", Classes.FObjectProperty);
		Evt_PostMulticastAkEventServer_IsValid = Evt_PostMulticastAkEventServer_FunctionAddress != IntPtr.Zero && Evt_PostMulticastAkEventServer_AkEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_PostMulticastAkEventServer", Evt_PostMulticastAkEventServer_IsValid);
		Evt_TeamWipeOut_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_TeamWipeOut_Multicast_Invoke");
		Evt_TeamWipeOut_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_TeamWipeOut_Multicast_Invoke_FunctionAddress);
		Evt_TeamWipeOut_Multicast_Invoke_IsValid = Evt_TeamWipeOut_Multicast_Invoke_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_TeamWipeOut_Multicast_Invoke", Evt_TeamWipeOut_Multicast_Invoke_IsValid);
		Evt_BGS_TriggerShortcutMultiCast_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BGS_TriggerShortcutMultiCast");
		Evt_BGS_TriggerShortcutMultiCast_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BGS_TriggerShortcutMultiCast_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Evt_BGS_TriggerShortcutMultiCast_B1_PropertyAddress, Evt_BGS_TriggerShortcutMultiCast_FunctionAddress, "B1");
		Evt_BGS_TriggerShortcutMultiCast_B1_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_TriggerShortcutMultiCast_FunctionAddress, "B1");
		Evt_BGS_TriggerShortcutMultiCast_B1_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_TriggerShortcutMultiCast_FunctionAddress, "B1", Classes.FBoolProperty);
		Evt_BGS_TriggerShortcutMultiCast_P2_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_TriggerShortcutMultiCast_FunctionAddress, "P2");
		Evt_BGS_TriggerShortcutMultiCast_P2_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_TriggerShortcutMultiCast_FunctionAddress, "P2", Classes.FIntProperty);
		Evt_BGS_TriggerShortcutMultiCast_IsValid = Evt_BGS_TriggerShortcutMultiCast_FunctionAddress != IntPtr.Zero && Evt_BGS_TriggerShortcutMultiCast_B1_IsValid && Evt_BGS_TriggerShortcutMultiCast_P2_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_TriggerShortcutMultiCast", Evt_BGS_TriggerShortcutMultiCast_IsValid);
		Evt_PostMulticastAkEventMultiCast_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_PostMulticastAkEventMultiCast");
		Evt_PostMulticastAkEventMultiCast_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_PostMulticastAkEventMultiCast_FunctionAddress);
		Evt_PostMulticastAkEventMultiCast_AkEvent_Offset = NativeReflection.GetPropertyOffset(Evt_PostMulticastAkEventMultiCast_FunctionAddress, "AkEvent");
		Evt_PostMulticastAkEventMultiCast_AkEvent_IsValid = NativeReflection.ValidatePropertyClass(Evt_PostMulticastAkEventMultiCast_FunctionAddress, "AkEvent", Classes.FObjectProperty);
		Evt_PostMulticastAkEventMultiCast_IsValid = Evt_PostMulticastAkEventMultiCast_FunctionAddress != IntPtr.Zero && Evt_PostMulticastAkEventMultiCast_AkEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_PostMulticastAkEventMultiCast", Evt_PostMulticastAkEventMultiCast_IsValid);
		Evt_BGS_UnitDead_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BGS_UnitDead_Multicast_Invoke");
		Evt_BGS_UnitDead_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BGS_UnitDead_Multicast_Invoke_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Evt_BGS_UnitDead_Multicast_Invoke_UnitGuid_PropertyAddress, Evt_BGS_UnitDead_Multicast_Invoke_FunctionAddress, "UnitGuid");
		Evt_BGS_UnitDead_Multicast_Invoke_UnitGuid_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_UnitDead_Multicast_Invoke_FunctionAddress, "UnitGuid");
		Evt_BGS_UnitDead_Multicast_Invoke_UnitGuid_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_UnitDead_Multicast_Invoke_FunctionAddress, "UnitGuid", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref Evt_BGS_UnitDead_Multicast_Invoke_DeadReason_PropertyAddress, Evt_BGS_UnitDead_Multicast_Invoke_FunctionAddress, "DeadReason");
		Evt_BGS_UnitDead_Multicast_Invoke_DeadReason_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_UnitDead_Multicast_Invoke_FunctionAddress, "DeadReason");
		Evt_BGS_UnitDead_Multicast_Invoke_DeadReason_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_UnitDead_Multicast_Invoke_FunctionAddress, "DeadReason", Classes.FEnumProperty);
		Evt_BGS_UnitDead_Multicast_Invoke_IsValid = Evt_BGS_UnitDead_Multicast_Invoke_FunctionAddress != IntPtr.Zero && Evt_BGS_UnitDead_Multicast_Invoke_UnitGuid_IsValid && Evt_BGS_UnitDead_Multicast_Invoke_DeadReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_UnitDead_Multicast_Invoke", Evt_BGS_UnitDead_Multicast_Invoke_IsValid);
		Evt_CrusadeSuccess_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_CrusadeSuccess_Multicast_Invoke");
		Evt_CrusadeSuccess_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_CrusadeSuccess_Multicast_Invoke_FunctionAddress);
		Evt_CrusadeSuccess_Multicast_Invoke_IsValid = Evt_CrusadeSuccess_Multicast_Invoke_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_CrusadeSuccess_Multicast_Invoke", Evt_CrusadeSuccess_Multicast_Invoke_IsValid);
		Evt_BGS_PlayerJoin_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BGS_PlayerJoin_Multicast_Invoke");
		Evt_BGS_PlayerJoin_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BGS_PlayerJoin_Multicast_Invoke_FunctionAddress);
		Evt_BGS_PlayerJoin_Multicast_Invoke_PlayerState_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_PlayerJoin_Multicast_Invoke_FunctionAddress, "PlayerState");
		Evt_BGS_PlayerJoin_Multicast_Invoke_PlayerState_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_PlayerJoin_Multicast_Invoke_FunctionAddress, "PlayerState", Classes.FObjectProperty);
		Evt_BGS_PlayerJoin_Multicast_Invoke_IsValid = Evt_BGS_PlayerJoin_Multicast_Invoke_FunctionAddress != IntPtr.Zero && Evt_BGS_PlayerJoin_Multicast_Invoke_PlayerState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_PlayerJoin_Multicast_Invoke", Evt_BGS_PlayerJoin_Multicast_Invoke_IsValid);
		Evt_BGS_PlayerLogOut_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BGS_PlayerLogOut_Multicast_Invoke");
		Evt_BGS_PlayerLogOut_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BGS_PlayerLogOut_Multicast_Invoke_FunctionAddress);
		Evt_BGS_PlayerLogOut_Multicast_Invoke_PlayerState_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_PlayerLogOut_Multicast_Invoke_FunctionAddress, "PlayerState");
		Evt_BGS_PlayerLogOut_Multicast_Invoke_PlayerState_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_PlayerLogOut_Multicast_Invoke_FunctionAddress, "PlayerState", Classes.FObjectProperty);
		Evt_BGS_PlayerLogOut_Multicast_Invoke_IsValid = Evt_BGS_PlayerLogOut_Multicast_Invoke_FunctionAddress != IntPtr.Zero && Evt_BGS_PlayerLogOut_Multicast_Invoke_PlayerState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_PlayerLogOut_Multicast_Invoke", Evt_BGS_PlayerLogOut_Multicast_Invoke_IsValid);
		Evt_BGS_TestGameState_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BGS_TestGameState_Multicast_Invoke");
		Evt_BGS_TestGameState_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BGS_TestGameState_Multicast_Invoke_FunctionAddress);
		Evt_BGS_TestGameState_Multicast_Invoke_P1_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_TestGameState_Multicast_Invoke_FunctionAddress, "P1");
		Evt_BGS_TestGameState_Multicast_Invoke_P1_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_TestGameState_Multicast_Invoke_FunctionAddress, "P1", Classes.FIntProperty);
		Evt_BGS_TestGameState_Multicast_Invoke_IsValid = Evt_BGS_TestGameState_Multicast_Invoke_FunctionAddress != IntPtr.Zero && Evt_BGS_TestGameState_Multicast_Invoke_P1_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_TestGameState_Multicast_Invoke", Evt_BGS_TestGameState_Multicast_Invoke_IsValid);
		Evt_OnlineDebugInfoEnd_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_OnlineDebugInfoEnd_Multicast_Invoke");
		Evt_OnlineDebugInfoEnd_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_OnlineDebugInfoEnd_Multicast_Invoke_FunctionAddress);
		Evt_OnlineDebugInfoEnd_Multicast_Invoke_IsValid = Evt_OnlineDebugInfoEnd_Multicast_Invoke_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_OnlineDebugInfoEnd_Multicast_Invoke", Evt_OnlineDebugInfoEnd_Multicast_Invoke_IsValid);
		Evt_BGS_OnPlayerLogOut_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BGS_OnPlayerLogOut_Multicast_Invoke");
		Evt_BGS_OnPlayerLogOut_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BGS_OnPlayerLogOut_Multicast_Invoke_FunctionAddress);
		Evt_BGS_OnPlayerLogOut_Multicast_Invoke_Exitting_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_OnPlayerLogOut_Multicast_Invoke_FunctionAddress, "Exitting");
		Evt_BGS_OnPlayerLogOut_Multicast_Invoke_Exitting_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_OnPlayerLogOut_Multicast_Invoke_FunctionAddress, "Exitting", Classes.FObjectProperty);
		Evt_BGS_OnPlayerLogOut_Multicast_Invoke_IsValid = Evt_BGS_OnPlayerLogOut_Multicast_Invoke_FunctionAddress != IntPtr.Zero && Evt_BGS_OnPlayerLogOut_Multicast_Invoke_Exitting_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_OnPlayerLogOut_Multicast_Invoke", Evt_BGS_OnPlayerLogOut_Multicast_Invoke_IsValid);
		Evt_BGS_ItemFullOnline_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BGS_ItemFullOnline_Multicast_Invoke");
		Evt_BGS_ItemFullOnline_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BGS_ItemFullOnline_Multicast_Invoke_FunctionAddress);
		Evt_BGS_ItemFullOnline_Multicast_Invoke_P1_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_ItemFullOnline_Multicast_Invoke_FunctionAddress, "P1");
		Evt_BGS_ItemFullOnline_Multicast_Invoke_P1_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_ItemFullOnline_Multicast_Invoke_FunctionAddress, "P1", Classes.FIntProperty);
		Evt_BGS_ItemFullOnline_Multicast_Invoke_IsValid = Evt_BGS_ItemFullOnline_Multicast_Invoke_FunctionAddress != IntPtr.Zero && Evt_BGS_ItemFullOnline_Multicast_Invoke_P1_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_ItemFullOnline_Multicast_Invoke", Evt_BGS_ItemFullOnline_Multicast_Invoke_IsValid);
		Evt_BGS_OnUnitTransited_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BGS_OnUnitTransited_Multicast_Invoke");
		Evt_BGS_OnUnitTransited_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BGS_OnUnitTransited_Multicast_Invoke_FunctionAddress);
		Evt_BGS_OnUnitTransited_Multicast_Invoke_OldUnit_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_OnUnitTransited_Multicast_Invoke_FunctionAddress, "OldUnit");
		Evt_BGS_OnUnitTransited_Multicast_Invoke_OldUnit_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_OnUnitTransited_Multicast_Invoke_FunctionAddress, "OldUnit", Classes.FObjectProperty);
		Evt_BGS_OnUnitTransited_Multicast_Invoke_NewlySpawnedUnit_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_OnUnitTransited_Multicast_Invoke_FunctionAddress, "NewlySpawnedUnit");
		Evt_BGS_OnUnitTransited_Multicast_Invoke_NewlySpawnedUnit_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_OnUnitTransited_Multicast_Invoke_FunctionAddress, "NewlySpawnedUnit", Classes.FObjectProperty);
		Evt_BGS_OnUnitTransited_Multicast_Invoke_IsValid = Evt_BGS_OnUnitTransited_Multicast_Invoke_FunctionAddress != IntPtr.Zero && Evt_BGS_OnUnitTransited_Multicast_Invoke_OldUnit_IsValid && Evt_BGS_OnUnitTransited_Multicast_Invoke_NewlySpawnedUnit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_OnUnitTransited_Multicast_Invoke", Evt_BGS_OnUnitTransited_Multicast_Invoke_IsValid);
		Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BGS_OnPlayerPostLogin_Multicast_Invoke");
		Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_FunctionAddress);
		Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_NewPlayer_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_FunctionAddress, "NewPlayer");
		Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_NewPlayer_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_FunctionAddress, "NewPlayer", Classes.FObjectProperty);
		Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_IsValid = Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_FunctionAddress != IntPtr.Zero && Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_NewPlayer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_OnPlayerPostLogin_Multicast_Invoke", Evt_BGS_OnPlayerPostLogin_Multicast_Invoke_IsValid);
		Evt_BGS_NotifySwitchTarget_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BGS_NotifySwitchTarget_Multicast_Invoke");
		Evt_BGS_NotifySwitchTarget_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BGS_NotifySwitchTarget_Multicast_Invoke_FunctionAddress);
		Evt_BGS_NotifySwitchTarget_Multicast_Invoke_OldTarget_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_NotifySwitchTarget_Multicast_Invoke_FunctionAddress, "OldTarget");
		Evt_BGS_NotifySwitchTarget_Multicast_Invoke_OldTarget_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_NotifySwitchTarget_Multicast_Invoke_FunctionAddress, "OldTarget", Classes.FObjectProperty);
		Evt_BGS_NotifySwitchTarget_Multicast_Invoke_NewTarget_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_NotifySwitchTarget_Multicast_Invoke_FunctionAddress, "NewTarget");
		Evt_BGS_NotifySwitchTarget_Multicast_Invoke_NewTarget_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_NotifySwitchTarget_Multicast_Invoke_FunctionAddress, "NewTarget", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TriggerTaunt_PropertyAddress, Evt_BGS_NotifySwitchTarget_Multicast_Invoke_FunctionAddress, "TriggerTaunt");
		Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TriggerTaunt_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_NotifySwitchTarget_Multicast_Invoke_FunctionAddress, "TriggerTaunt");
		Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TriggerTaunt_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_NotifySwitchTarget_Multicast_Invoke_FunctionAddress, "TriggerTaunt", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TargetSourceType_PropertyAddress, Evt_BGS_NotifySwitchTarget_Multicast_Invoke_FunctionAddress, "TargetSourceType");
		Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TargetSourceType_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_NotifySwitchTarget_Multicast_Invoke_FunctionAddress, "TargetSourceType");
		Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TargetSourceType_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_NotifySwitchTarget_Multicast_Invoke_FunctionAddress, "TargetSourceType", Classes.FEnumProperty);
		Evt_BGS_NotifySwitchTarget_Multicast_Invoke_IsValid = Evt_BGS_NotifySwitchTarget_Multicast_Invoke_FunctionAddress != IntPtr.Zero && Evt_BGS_NotifySwitchTarget_Multicast_Invoke_OldTarget_IsValid && Evt_BGS_NotifySwitchTarget_Multicast_Invoke_NewTarget_IsValid && Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TriggerTaunt_IsValid && Evt_BGS_NotifySwitchTarget_Multicast_Invoke_TargetSourceType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_NotifySwitchTarget_Multicast_Invoke", Evt_BGS_NotifySwitchTarget_Multicast_Invoke_IsValid);
		Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BGS_SwitchTickRateLogic_Multicast_Invoke");
		Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_FunctionAddress);
		Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_P1_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_FunctionAddress, "P1");
		Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_P1_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_FunctionAddress, "P1", Classes.FIntProperty);
		Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_IsValid = Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_FunctionAddress != IntPtr.Zero && Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_P1_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_SwitchTickRateLogic_Multicast_Invoke", Evt_BGS_SwitchTickRateLogic_Multicast_Invoke_IsValid);
		Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke");
		Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_ScreenMsgType_PropertyAddress, Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_FunctionAddress, "ScreenMsgType");
		Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_ScreenMsgType_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_FunctionAddress, "ScreenMsgType");
		Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_ScreenMsgType_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_FunctionAddress, "ScreenMsgType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_Msg_PropertyAddress, Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_FunctionAddress, "Msg");
		Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_Msg_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_FunctionAddress, "Msg");
		Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_Msg_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_FunctionAddress, "Msg", Classes.FStrProperty);
		Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_TipsDuration_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_FunctionAddress, "TipsDuration");
		Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_TipsDuration_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_FunctionAddress, "TipsDuration", Classes.FIntProperty);
		Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_IsValid = Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_FunctionAddress != IntPtr.Zero && Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_ScreenMsgType_IsValid && Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_Msg_IsValid && Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_TipsDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke", Evt_BGS_SendOnlineScreenMsg_Multicast_Invoke_IsValid);
		Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke");
		Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_FunctionAddress);
		Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_OriginActor_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_FunctionAddress, "OriginActor");
		Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_OriginActor_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_FunctionAddress, "OriginActor", Classes.FObjectProperty);
		Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_CopyActor_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_FunctionAddress, "CopyActor");
		Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_CopyActor_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_FunctionAddress, "CopyActor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_bRemoveOriginHatredInfo_PropertyAddress, Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_FunctionAddress, "bRemoveOriginHatredInfo");
		Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_bRemoveOriginHatredInfo_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_FunctionAddress, "bRemoveOriginHatredInfo");
		Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_bRemoveOriginHatredInfo_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_FunctionAddress, "bRemoveOriginHatredInfo", Classes.FBoolProperty);
		Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_IsValid = Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_FunctionAddress != IntPtr.Zero && Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_OriginActor_IsValid && Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_CopyActor_IsValid && Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_bRemoveOriginHatredInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke", Evt_BGS_NotifyCopyHatredInfo_Multicast_Invoke_IsValid);
		Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke");
		Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_FunctionAddress);
		Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_P1_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_FunctionAddress, "P1");
		Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_P1_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_FunctionAddress, "P1", Classes.FIntProperty);
		Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_P2_Offset = NativeReflection.GetPropertyOffset(Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_FunctionAddress, "P2");
		Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_P2_IsValid = NativeReflection.ValidatePropertyClass(Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_FunctionAddress, "P2", Classes.FIntProperty);
		Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_IsValid = Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_FunctionAddress != IntPtr.Zero && Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_P1_IsValid && Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_P2_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGS_GSEventCollection:Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke", Evt_BGS_OnlineChallengeStateTrigger_Multicast_Invoke_IsValid);
	}
}
