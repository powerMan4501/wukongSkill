using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BPS_GSEventCollection")]
public class BPS_GSEventCollection : GSEventCollectionBase
{
	private Del_Void_Int Evt_BPS_TestPlayerState_imp;

	private Del_BPS_AddPredictionKeyState Evt_BPS_AddPredictionKeyState_imp;

	private Del_ServerActivateTamer Evt_BPS_ServerActivateTamer_imp;

	private Del_ClientInitCharacterNetRole Evt_BPS_ClientInitCharacterNetRole_imp;

	private Del_ServerNotifyClientTamerBackToLoad Evt_BPS_ServerNotifyClientTamerBackToLoad_imp;

	private Del_ServerNotifyClientAuthorityTamerDead Evt_BPS_ServerNotifyClientAuthorityTamerDead_imp;

	private Del_ServerSpawnDynamicTamer Evt_BPS_ServerSpawnDynamicTamer_imp;

	private Del_AddTransaction Evt_BPS_StartTransaction_imp;

	private Del_Void_SummonRequest Evt_RequestSummon_imp;

	private Del_Void_ServantReq Evt_SendServantReq_imp;

	private Del_Param_RoleData Evt_BPS_SyncRoleDataTmp_imp;

	private Del_Void_Int Evt_TmpTransSendDropItem_imp;

	private Del_SwitchPlayerTransState Evt_BPS_SwitchPlayerTransState_imp;

	private Del_CloseConnectionWithResult Evt_CloseConnectionWithResult_imp;

	private static bool Evt_RequestSummon_Invoke_IsValid;

	private static IntPtr Evt_RequestSummon_Invoke_FunctionAddress;

	private static int Evt_RequestSummon_Invoke_ParamsSize;

	private static bool Evt_RequestSummon_Invoke_InSummonReq_IsValid;

	private static int Evt_RequestSummon_Invoke_InSummonReq_Offset;

	private static FFieldAddress Evt_RequestSummon_Invoke_InSummonReq_PropertyAddress;

	private static bool EndPlayInCS_IsValid;

	private static IntPtr EndPlayInCS_FunctionAddress;

	private static int EndPlayInCS_ParamsSize;

	private static bool EndPlayInCS_EndPlayReason_IsValid;

	private static int EndPlayInCS_EndPlayReason_Offset;

	private static FFieldAddress EndPlayInCS_EndPlayReason_PropertyAddress;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	private static bool Evt_BPS_SyncRoleDataTmp_Invoke_IsValid;

	private static IntPtr Evt_BPS_SyncRoleDataTmp_Invoke_FunctionAddress;

	private static int Evt_BPS_SyncRoleDataTmp_Invoke_ParamsSize;

	private static bool Evt_BPS_SyncRoleDataTmp_Invoke_RoleData_IsValid;

	private static int Evt_BPS_SyncRoleDataTmp_Invoke_RoleData_Offset;

	private static FFieldAddress Evt_BPS_SyncRoleDataTmp_Invoke_RoleData_PropertyAddress;

	private static bool Evt_TmpTransSendDropItem_Invoke_IsValid;

	private static IntPtr Evt_TmpTransSendDropItem_Invoke_FunctionAddress;

	private static int Evt_TmpTransSendDropItem_Invoke_ParamsSize;

	private static bool Evt_TmpTransSendDropItem_Invoke_P1_IsValid;

	private static int Evt_TmpTransSendDropItem_Invoke_P1_Offset;

	private static bool Evt_BPS_ServerActivateTamer_Invoke_IsValid;

	private static IntPtr Evt_BPS_ServerActivateTamer_Invoke_FunctionAddress;

	private static int Evt_BPS_ServerActivateTamer_Invoke_ParamsSize;

	private static bool Evt_BPS_ServerActivateTamer_Invoke_Guids_IsValid;

	private static int Evt_BPS_ServerActivateTamer_Invoke_Guids_Offset;

	private static FFieldAddress Evt_BPS_ServerActivateTamer_Invoke_Guids_PropertyAddress;

	private static bool Evt_SendServantReq_Multicast_Invoke_IsValid;

	private static IntPtr Evt_SendServantReq_Multicast_Invoke_FunctionAddress;

	private static int Evt_SendServantReq_Multicast_Invoke_ParamsSize;

	private static bool Evt_SendServantReq_Multicast_Invoke_InServantReq_IsValid;

	private static int Evt_SendServantReq_Multicast_Invoke_InServantReq_Offset;

	private static FFieldAddress Evt_SendServantReq_Multicast_Invoke_InServantReq_PropertyAddress;

	private static bool Evt_CloseConnectionWithResult_Invoke_IsValid;

	private static IntPtr Evt_CloseConnectionWithResult_Invoke_FunctionAddress;

	private static int Evt_CloseConnectionWithResult_Invoke_ParamsSize;

	private static bool Evt_CloseConnectionWithResult_Invoke_CloseResult_IsValid;

	private static int Evt_CloseConnectionWithResult_Invoke_CloseResult_Offset;

	private static FFieldAddress Evt_CloseConnectionWithResult_Invoke_CloseResult_PropertyAddress;

	private static bool Evt_BPS_ServerSpawnDynamicTamer_Invoke_IsValid;

	private static IntPtr Evt_BPS_ServerSpawnDynamicTamer_Invoke_FunctionAddress;

	private static int Evt_BPS_ServerSpawnDynamicTamer_Invoke_ParamsSize;

	private static bool Evt_BPS_ServerSpawnDynamicTamer_Invoke_TamerClass_IsValid;

	private static int Evt_BPS_ServerSpawnDynamicTamer_Invoke_TamerClass_Offset;

	private static FFieldAddress Evt_BPS_ServerSpawnDynamicTamer_Invoke_TamerClass_PropertyAddress;

	private static bool Evt_BPS_TestPlayerState_Multicast_Invoke_IsValid;

	private static IntPtr Evt_BPS_TestPlayerState_Multicast_Invoke_FunctionAddress;

	private static int Evt_BPS_TestPlayerState_Multicast_Invoke_ParamsSize;

	private static bool Evt_BPS_TestPlayerState_Multicast_Invoke_P1_IsValid;

	private static int Evt_BPS_TestPlayerState_Multicast_Invoke_P1_Offset;

	private static bool Evt_BPS_ClientInitCharacterNetRole_Invoke_IsValid;

	private static IntPtr Evt_BPS_ClientInitCharacterNetRole_Invoke_FunctionAddress;

	private static int Evt_BPS_ClientInitCharacterNetRole_Invoke_ParamsSize;

	private static bool Evt_BPS_ClientInitCharacterNetRole_Invoke_Guids_IsValid;

	private static int Evt_BPS_ClientInitCharacterNetRole_Invoke_Guids_Offset;

	private static FFieldAddress Evt_BPS_ClientInitCharacterNetRole_Invoke_Guids_PropertyAddress;

	private static bool Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_IsValid;

	private static IntPtr Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_FunctionAddress;

	private static int Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_ParamsSize;

	private static bool Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_OldActor_IsValid;

	private static int Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_OldActor_Offset;

	private static bool Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_NewActorResId_IsValid;

	private static int Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_NewActorResId_Offset;

	private static bool Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_IsValid;

	private static IntPtr Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_FunctionAddress;

	private static int Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_ParamsSize;

	private static bool Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_Guids_IsValid;

	private static int Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_Guids_Offset;

	private static FFieldAddress Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_Guids_PropertyAddress;

	private static bool Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_IsValid;

	private static IntPtr Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_FunctionAddress;

	private static int Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_ParamsSize;

	private static bool Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_Guids_IsValid;

	private static int Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_Guids_Offset;

	private static FFieldAddress Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_Guids_PropertyAddress;

	public GSDel_Void Evt_BPS_BreakInteract
	{
		get
		{
			if (!_EventObjCache.TryGetValue(1, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 1;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[1] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_Int_ICB Evt_BPS_TestPlayerState
	{
		get
		{
			if (!_EventObjCache.TryGetValue(2, out var value))
			{
				value = new GSDel_Void_Int_ICB(Evt_BPS_TestPlayerState_Invoke, Evt_BPS_TestPlayerState_DelChg);
				(value as GSDel_Void_Int_ICB).EventId = 2;
				(value as GSDel_Void_Int_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[2] = value;
			}
			return value as GSDel_Void_Int_ICB;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_BPS_TestPlayerController
	{
		get
		{
			if (!_EventObjCache.TryGetValue(3, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 3;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[3] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_BPS_TeleportTo Evt_BPS_TeleportTo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(4, out var value))
			{
				value = new GSDel_BPS_TeleportTo();
				(value as GSDel_BPS_TeleportTo).EventId = 4;
				(value as GSDel_BPS_TeleportTo)._OwnerEventCollectionCS = this;
				_EventObjCache[4] = value;
			}
			return value as GSDel_BPS_TeleportTo;
		}
		set
		{
		}
	}

	public GSDel_BPS_AddPredictionKeyState_ICB Evt_BPS_AddPredictionKeyState
	{
		get
		{
			if (!_EventObjCache.TryGetValue(5, out var value))
			{
				value = new GSDel_BPS_AddPredictionKeyState_ICB(Evt_BPS_AddPredictionKeyState_Invoke, Evt_BPS_AddPredictionKeyState_DelChg);
				(value as GSDel_BPS_AddPredictionKeyState_ICB).EventId = 5;
				(value as GSDel_BPS_AddPredictionKeyState_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[5] = value;
			}
			return value as GSDel_BPS_AddPredictionKeyState_ICB;
		}
		set
		{
		}
	}

	public GSDel_BPS_GetPredictionKeyState Evt_BPS_GetPredictionKeyState
	{
		get
		{
			if (!_EventObjCache.TryGetValue(6, out var value))
			{
				value = new GSDel_BPS_GetPredictionKeyState();
				(value as GSDel_BPS_GetPredictionKeyState).EventId = 6;
				(value as GSDel_BPS_GetPredictionKeyState)._OwnerEventCollectionCS = this;
				_EventObjCache[6] = value;
			}
			return value as GSDel_BPS_GetPredictionKeyState;
		}
		set
		{
		}
	}

	public GSDel_CollectReplicateData Evt_BPS_CollectReplicateData
	{
		get
		{
			if (!_EventObjCache.TryGetValue(7, out var value))
			{
				value = new GSDel_CollectReplicateData();
				(value as GSDel_CollectReplicateData).EventId = 7;
				(value as GSDel_CollectReplicateData)._OwnerEventCollectionCS = this;
				_EventObjCache[7] = value;
			}
			return value as GSDel_CollectReplicateData;
		}
		set
		{
		}
	}

	public GSDel_DoReplicateData Evt_BPS_DoReplicateData
	{
		get
		{
			if (!_EventObjCache.TryGetValue(8, out var value))
			{
				value = new GSDel_DoReplicateData();
				(value as GSDel_DoReplicateData).EventId = 8;
				(value as GSDel_DoReplicateData)._OwnerEventCollectionCS = this;
				_EventObjCache[8] = value;
			}
			return value as GSDel_DoReplicateData;
		}
		set
		{
		}
	}

	public GSDel_ServerActivateTamer_ICB Evt_BPS_ServerActivateTamer
	{
		get
		{
			if (!_EventObjCache.TryGetValue(9, out var value))
			{
				value = new GSDel_ServerActivateTamer_ICB(Evt_BPS_ServerActivateTamer_Invoke, Evt_BPS_ServerActivateTamer_DelChg);
				(value as GSDel_ServerActivateTamer_ICB).EventId = 9;
				(value as GSDel_ServerActivateTamer_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[9] = value;
			}
			return value as GSDel_ServerActivateTamer_ICB;
		}
		set
		{
		}
	}

	public GSDel_ClientInitCharacterNetRole_ICB Evt_BPS_ClientInitCharacterNetRole
	{
		get
		{
			if (!_EventObjCache.TryGetValue(10, out var value))
			{
				value = new GSDel_ClientInitCharacterNetRole_ICB(Evt_BPS_ClientInitCharacterNetRole_Invoke, Evt_BPS_ClientInitCharacterNetRole_DelChg);
				(value as GSDel_ClientInitCharacterNetRole_ICB).EventId = 10;
				(value as GSDel_ClientInitCharacterNetRole_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[10] = value;
			}
			return value as GSDel_ClientInitCharacterNetRole_ICB;
		}
		set
		{
		}
	}

	public GSDel_ServerNotifyClientTamerBackToLoad_ICB Evt_BPS_ServerNotifyClientTamerBackToLoad
	{
		get
		{
			if (!_EventObjCache.TryGetValue(11, out var value))
			{
				value = new GSDel_ServerNotifyClientTamerBackToLoad_ICB(Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke, Evt_BPS_ServerNotifyClientTamerBackToLoad_DelChg);
				(value as GSDel_ServerNotifyClientTamerBackToLoad_ICB).EventId = 11;
				(value as GSDel_ServerNotifyClientTamerBackToLoad_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[11] = value;
			}
			return value as GSDel_ServerNotifyClientTamerBackToLoad_ICB;
		}
		set
		{
		}
	}

	public GSDel_ServerNotifyClientAuthorityTamerDead_ICB Evt_BPS_ServerNotifyClientAuthorityTamerDead
	{
		get
		{
			if (!_EventObjCache.TryGetValue(12, out var value))
			{
				value = new GSDel_ServerNotifyClientAuthorityTamerDead_ICB(Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke, Evt_BPS_ServerNotifyClientAuthorityTamerDead_DelChg);
				(value as GSDel_ServerNotifyClientAuthorityTamerDead_ICB).EventId = 12;
				(value as GSDel_ServerNotifyClientAuthorityTamerDead_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[12] = value;
			}
			return value as GSDel_ServerNotifyClientAuthorityTamerDead_ICB;
		}
		set
		{
		}
	}

	public GSDel_ServerSpawnDynamicTamer_ICB Evt_BPS_ServerSpawnDynamicTamer
	{
		get
		{
			if (!_EventObjCache.TryGetValue(13, out var value))
			{
				value = new GSDel_ServerSpawnDynamicTamer_ICB(Evt_BPS_ServerSpawnDynamicTamer_Invoke, Evt_BPS_ServerSpawnDynamicTamer_DelChg);
				(value as GSDel_ServerSpawnDynamicTamer_ICB).EventId = 13;
				(value as GSDel_ServerSpawnDynamicTamer_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[13] = value;
			}
			return value as GSDel_ServerSpawnDynamicTamer_ICB;
		}
		set
		{
		}
	}

	public GSDel_ClientInternalReqSpawnDynamicTamer Evt_BPS_ClientInternalReqSpawnDynamicTamer
	{
		get
		{
			if (!_EventObjCache.TryGetValue(14, out var value))
			{
				value = new GSDel_ClientInternalReqSpawnDynamicTamer();
				(value as GSDel_ClientInternalReqSpawnDynamicTamer).EventId = 14;
				(value as GSDel_ClientInternalReqSpawnDynamicTamer)._OwnerEventCollectionCS = this;
				_EventObjCache[14] = value;
			}
			return value as GSDel_ClientInternalReqSpawnDynamicTamer;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BPS_BGUCharaterNetReceiveRole
	{
		get
		{
			if (!_EventObjCache.TryGetValue(15, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 15;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[15] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_AddTransaction_ICB Evt_BPS_StartTransaction
	{
		get
		{
			if (!_EventObjCache.TryGetValue(16, out var value))
			{
				value = new GSDel_AddTransaction_ICB(Evt_BPS_StartTransaction_Invoke, Evt_BPS_StartTransaction_DelChg);
				(value as GSDel_AddTransaction_ICB).EventId = 16;
				(value as GSDel_AddTransaction_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[16] = value;
			}
			return value as GSDel_AddTransaction_ICB;
		}
		set
		{
		}
	}

	public GSDel_Void_BoolBoolBool Evt_BPS_BeginCinematicIgnoreMode
	{
		get
		{
			if (!_EventObjCache.TryGetValue(17, out var value))
			{
				value = new GSDel_Void_BoolBoolBool();
				(value as GSDel_Void_BoolBoolBool).EventId = 17;
				(value as GSDel_Void_BoolBoolBool)._OwnerEventCollectionCS = this;
				_EventObjCache[17] = value;
			}
			return value as GSDel_Void_BoolBoolBool;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BPS_EndCinematicIgnoreMode
	{
		get
		{
			if (!_EventObjCache.TryGetValue(18, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 18;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[18] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_SummonRequest_ICB Evt_RequestSummon
	{
		get
		{
			if (!_EventObjCache.TryGetValue(19, out var value))
			{
				value = new GSDel_Void_SummonRequest_ICB(Evt_RequestSummon_Invoke, Evt_RequestSummon_DelChg);
				(value as GSDel_Void_SummonRequest_ICB).EventId = 19;
				(value as GSDel_Void_SummonRequest_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[19] = value;
			}
			return value as GSDel_Void_SummonRequest_ICB;
		}
		set
		{
		}
	}

	public GSDel_Void_ServantReq_ICB Evt_SendServantReq
	{
		get
		{
			if (!_EventObjCache.TryGetValue(20, out var value))
			{
				value = new GSDel_Void_ServantReq_ICB(Evt_SendServantReq_Invoke, Evt_SendServantReq_DelChg);
				(value as GSDel_Void_ServantReq_ICB).EventId = 20;
				(value as GSDel_Void_ServantReq_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[20] = value;
			}
			return value as GSDel_Void_ServantReq_ICB;
		}
		set
		{
		}
	}

	public GSDel_AddPostProcessMat Evt_AddPostProcessMat
	{
		get
		{
			if (!_EventObjCache.TryGetValue(21, out var value))
			{
				value = new GSDel_AddPostProcessMat();
				(value as GSDel_AddPostProcessMat).EventId = 21;
				(value as GSDel_AddPostProcessMat)._OwnerEventCollectionCS = this;
				_EventObjCache[21] = value;
			}
			return value as GSDel_AddPostProcessMat;
		}
		set
		{
		}
	}

	public GSDel_RemovePostProcessMat Evt_RemovePostProcessMat
	{
		get
		{
			if (!_EventObjCache.TryGetValue(22, out var value))
			{
				value = new GSDel_RemovePostProcessMat();
				(value as GSDel_RemovePostProcessMat).EventId = 22;
				(value as GSDel_RemovePostProcessMat)._OwnerEventCollectionCS = this;
				_EventObjCache[22] = value;
			}
			return value as GSDel_RemovePostProcessMat;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_EnterSkillCameraConversionParam
	{
		get
		{
			if (!_EventObjCache.TryGetValue(23, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 23;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[23] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_ExitSkillCameraConversionParam
	{
		get
		{
			if (!_EventObjCache.TryGetValue(24, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 24;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[24] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_SetResIDCameraConversionParam
	{
		get
		{
			if (!_EventObjCache.TryGetValue(25, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 25;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[25] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_Void_ActorInt Evt_EnterSkillCam
	{
		get
		{
			if (!_EventObjCache.TryGetValue(26, out var value))
			{
				value = new GSDel_Void_ActorInt();
				(value as GSDel_Void_ActorInt).EventId = 26;
				(value as GSDel_Void_ActorInt)._OwnerEventCollectionCS = this;
				_EventObjCache[26] = value;
			}
			return value as GSDel_Void_ActorInt;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_ExitSkillCam
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

	public GSDel_Void_IntInt Evt_OnEnterSkillCameraGroup
	{
		get
		{
			if (!_EventObjCache.TryGetValue(28, out var value))
			{
				value = new GSDel_Void_IntInt();
				(value as GSDel_Void_IntInt).EventId = 28;
				(value as GSDel_Void_IntInt)._OwnerEventCollectionCS = this;
				_EventObjCache[28] = value;
			}
			return value as GSDel_Void_IntInt;
		}
		set
		{
		}
	}

	public GSDel_Void_IntInt Evt_OnExitSkillCameraGroup
	{
		get
		{
			if (!_EventObjCache.TryGetValue(29, out var value))
			{
				value = new GSDel_Void_IntInt();
				(value as GSDel_Void_IntInt).EventId = 29;
				(value as GSDel_Void_IntInt)._OwnerEventCollectionCS = this;
				_EventObjCache[29] = value;
			}
			return value as GSDel_Void_IntInt;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_EnterCameraGroup
	{
		get
		{
			if (!_EventObjCache.TryGetValue(30, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 30;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[30] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_ExitCameraGroup
	{
		get
		{
			if (!_EventObjCache.TryGetValue(31, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 31;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[31] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_Void_IntFloatFloat Evt_OnSwitchCameraGroupVolumeTo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(32, out var value))
			{
				value = new GSDel_Void_IntFloatFloat();
				(value as GSDel_Void_IntFloatFloat).EventId = 32;
				(value as GSDel_Void_IntFloatFloat)._OwnerEventCollectionCS = this;
				_EventObjCache[32] = value;
			}
			return value as GSDel_Void_IntFloatFloat;
		}
		set
		{
		}
	}

	public GSDel_Void_ActorActor Evt_NotifyControlPawnChanged
	{
		get
		{
			if (!_EventObjCache.TryGetValue(33, out var value))
			{
				value = new GSDel_Void_ActorActor();
				(value as GSDel_Void_ActorActor).EventId = 33;
				(value as GSDel_Void_ActorActor)._OwnerEventCollectionCS = this;
				_EventObjCache[33] = value;
			}
			return value as GSDel_Void_ActorActor;
		}
		set
		{
		}
	}

	public GSDel_Param_RoleData_ICB Evt_BPS_SyncRoleDataTmp
	{
		get
		{
			if (!_EventObjCache.TryGetValue(34, out var value))
			{
				value = new GSDel_Param_RoleData_ICB(Evt_BPS_SyncRoleDataTmp_Invoke, Evt_BPS_SyncRoleDataTmp_DelChg);
				(value as GSDel_Param_RoleData_ICB).EventId = 34;
				(value as GSDel_Param_RoleData_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[34] = value;
			}
			return value as GSDel_Param_RoleData_ICB;
		}
		set
		{
		}
	}

	public GSDel_Param_APawn Evt_BPS_OnControlledPawnChange
	{
		get
		{
			if (!_EventObjCache.TryGetValue(35, out var value))
			{
				value = new GSDel_Param_APawn();
				(value as GSDel_Param_APawn).EventId = 35;
				(value as GSDel_Param_APawn)._OwnerEventCollectionCS = this;
				_EventObjCache[35] = value;
			}
			return value as GSDel_Param_APawn;
		}
		set
		{
		}
	}

	public GSDel_Param_Actor_Actor Evt_OnControlledPawnChange_Local
	{
		get
		{
			if (!_EventObjCache.TryGetValue(36, out var value))
			{
				value = new GSDel_Param_Actor_Actor();
				(value as GSDel_Param_Actor_Actor).EventId = 36;
				(value as GSDel_Param_Actor_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[36] = value;
			}
			return value as GSDel_Param_Actor_Actor;
		}
		set
		{
		}
	}

	public GSDel_OnTriggerDropItem Evt_OnTriggerDropItem
	{
		get
		{
			if (!_EventObjCache.TryGetValue(37, out var value))
			{
				value = new GSDel_OnTriggerDropItem();
				(value as GSDel_OnTriggerDropItem).EventId = 37;
				(value as GSDel_OnTriggerDropItem)._OwnerEventCollectionCS = this;
				_EventObjCache[37] = value;
			}
			return value as GSDel_OnTriggerDropItem;
		}
		set
		{
		}
	}

	public GSDel_RequestDropSpecialItem Evt_RequestDropSpecialItem
	{
		get
		{
			if (!_EventObjCache.TryGetValue(38, out var value))
			{
				value = new GSDel_RequestDropSpecialItem();
				(value as GSDel_RequestDropSpecialItem).EventId = 38;
				(value as GSDel_RequestDropSpecialItem)._OwnerEventCollectionCS = this;
				_EventObjCache[38] = value;
			}
			return value as GSDel_RequestDropSpecialItem;
		}
		set
		{
		}
	}

	public GSDel_SpawnDropItemOnLoad Evt_SpawnDropItemOnLoad
	{
		get
		{
			if (!_EventObjCache.TryGetValue(39, out var value))
			{
				value = new GSDel_SpawnDropItemOnLoad();
				(value as GSDel_SpawnDropItemOnLoad).EventId = 39;
				(value as GSDel_SpawnDropItemOnLoad)._OwnerEventCollectionCS = this;
				_EventObjCache[39] = value;
			}
			return value as GSDel_SpawnDropItemOnLoad;
		}
		set
		{
		}
	}

	public GSDel_Void_IntBool Evt_ActiveRebirthPoint
	{
		get
		{
			if (!_EventObjCache.TryGetValue(40, out var value))
			{
				value = new GSDel_Void_IntBool();
				(value as GSDel_Void_IntBool).EventId = 40;
				(value as GSDel_Void_IntBool)._OwnerEventCollectionCS = this;
				_EventObjCache[40] = value;
			}
			return value as GSDel_Void_IntBool;
		}
		set
		{
		}
	}

	public GSDel_Void_IntBool Evt_BlockRebirthPoint
	{
		get
		{
			if (!_EventObjCache.TryGetValue(41, out var value))
			{
				value = new GSDel_Void_IntBool();
				(value as GSDel_Void_IntBool).EventId = 41;
				(value as GSDel_Void_IntBool)._OwnerEventCollectionCS = this;
				_EventObjCache[41] = value;
			}
			return value as GSDel_Void_IntBool;
		}
		set
		{
		}
	}

	public GSDel_Void_Int_ICB Evt_TmpTransSendDropItem
	{
		get
		{
			if (!_EventObjCache.TryGetValue(42, out var value))
			{
				value = new GSDel_Void_Int_ICB(Evt_TmpTransSendDropItem_Invoke, Evt_TmpTransSendDropItem_DelChg);
				(value as GSDel_Void_Int_ICB).EventId = 42;
				(value as GSDel_Void_Int_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[42] = value;
			}
			return value as GSDel_Void_Int_ICB;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_SetCurrentBirthPoint
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

	public GSDel_Void_IntList Evt_RegSpecialRebirthPoint
	{
		get
		{
			if (!_EventObjCache.TryGetValue(44, out var value))
			{
				value = new GSDel_Void_IntList();
				(value as GSDel_Void_IntList).EventId = 44;
				(value as GSDel_Void_IntList)._OwnerEventCollectionCS = this;
				_EventObjCache[44] = value;
			}
			return value as GSDel_Void_IntList;
		}
		set
		{
		}
	}

	public GSDel_Void_IntList Evt_UnregSpecialRebirthPoint
	{
		get
		{
			if (!_EventObjCache.TryGetValue(45, out var value))
			{
				value = new GSDel_Void_IntList();
				(value as GSDel_Void_IntList).EventId = 45;
				(value as GSDel_Void_IntList)._OwnerEventCollectionCS = this;
				_EventObjCache[45] = value;
			}
			return value as GSDel_Void_IntList;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_ForceSetRebirthPoint
	{
		get
		{
			if (!_EventObjCache.TryGetValue(46, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 46;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[46] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_SwitchPlayerTransState_ICB Evt_BPS_SwitchPlayerTransState
	{
		get
		{
			if (!_EventObjCache.TryGetValue(47, out var value))
			{
				value = new GSDel_SwitchPlayerTransState_ICB(Evt_BPS_SwitchPlayerTransState_Invoke, Evt_BPS_SwitchPlayerTransState_DelChg);
				(value as GSDel_SwitchPlayerTransState_ICB).EventId = 47;
				(value as GSDel_SwitchPlayerTransState_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[47] = value;
			}
			return value as GSDel_SwitchPlayerTransState_ICB;
		}
		set
		{
		}
	}

	public GSDel_SetSpellType Evt_BPS_SetDefaultSpellType
	{
		get
		{
			if (!_EventObjCache.TryGetValue(48, out var value))
			{
				value = new GSDel_SetSpellType();
				(value as GSDel_SetSpellType).EventId = 48;
				(value as GSDel_SetSpellType)._OwnerEventCollectionCS = this;
				_EventObjCache[48] = value;
			}
			return value as GSDel_SetSpellType;
		}
		set
		{
		}
	}

	public GSDel_ChangeAttrByEquip Evt_BPS_ChangeAttrByEquip
	{
		get
		{
			if (!_EventObjCache.TryGetValue(49, out var value))
			{
				value = new GSDel_ChangeAttrByEquip();
				(value as GSDel_ChangeAttrByEquip).EventId = 49;
				(value as GSDel_ChangeAttrByEquip)._OwnerEventCollectionCS = this;
				_EventObjCache[49] = value;
			}
			return value as GSDel_ChangeAttrByEquip;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BPS_PauseCostEnergy
	{
		get
		{
			if (!_EventObjCache.TryGetValue(50, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 50;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[50] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BPS_ResumeCostEnergy
	{
		get
		{
			if (!_EventObjCache.TryGetValue(51, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 51;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[51] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_PlayerActorSpawn
	{
		get
		{
			if (!_EventObjCache.TryGetValue(52, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 52;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[52] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_PostTransBindData Evt_PostTransBindData
	{
		get
		{
			if (!_EventObjCache.TryGetValue(53, out var value))
			{
				value = new GSDel_PostTransBindData();
				(value as GSDel_PostTransBindData).EventId = 53;
				(value as GSDel_PostTransBindData)._OwnerEventCollectionCS = this;
				_EventObjCache[53] = value;
			}
			return value as GSDel_PostTransBindData;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_SetCurrentRebirthPoint
	{
		get
		{
			if (!_EventObjCache.TryGetValue(54, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 54;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[54] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_SetMapSymbolState Evt_SetMapSymbolState
	{
		get
		{
			if (!_EventObjCache.TryGetValue(55, out var value))
			{
				value = new GSDel_SetMapSymbolState();
				(value as GSDel_SetMapSymbolState).EventId = 55;
				(value as GSDel_SetMapSymbolState)._OwnerEventCollectionCS = this;
				_EventObjCache[55] = value;
			}
			return value as GSDel_SetMapSymbolState;
		}
		set
		{
		}
	}

	public GSDel_SetMapSymbolActiveState Evt_SetMapSymbolActiveState
	{
		get
		{
			if (!_EventObjCache.TryGetValue(56, out var value))
			{
				value = new GSDel_SetMapSymbolActiveState();
				(value as GSDel_SetMapSymbolActiveState).EventId = 56;
				(value as GSDel_SetMapSymbolActiveState)._OwnerEventCollectionCS = this;
				_EventObjCache[56] = value;
			}
			return value as GSDel_SetMapSymbolActiveState;
		}
		set
		{
		}
	}

	public GSDel_Void_FVector Evt_SetSelfDestination
	{
		get
		{
			if (!_EventObjCache.TryGetValue(57, out var value))
			{
				value = new GSDel_Void_FVector();
				(value as GSDel_Void_FVector).EventId = 57;
				(value as GSDel_Void_FVector)._OwnerEventCollectionCS = this;
				_EventObjCache[57] = value;
			}
			return value as GSDel_Void_FVector;
		}
		set
		{
		}
	}

	public GSDel_TeamerSetDestination Evt_TeamerSetDestination
	{
		get
		{
			if (!_EventObjCache.TryGetValue(58, out var value))
			{
				value = new GSDel_TeamerSetDestination();
				(value as GSDel_TeamerSetDestination).EventId = 58;
				(value as GSDel_TeamerSetDestination)._OwnerEventCollectionCS = this;
				_EventObjCache[58] = value;
			}
			return value as GSDel_TeamerSetDestination;
		}
		set
		{
		}
	}

	public GSDel_PlayerTransBegin Evt_TriggerPlayerTransBegin
	{
		get
		{
			if (!_EventObjCache.TryGetValue(59, out var value))
			{
				value = new GSDel_PlayerTransBegin();
				(value as GSDel_PlayerTransBegin).EventId = 59;
				(value as GSDel_PlayerTransBegin)._OwnerEventCollectionCS = this;
				_EventObjCache[59] = value;
			}
			return value as GSDel_PlayerTransBegin;
		}
		set
		{
		}
	}

	public GSDel_PlayerTransEnd Evt_TriggerPlayerTransEnd
	{
		get
		{
			if (!_EventObjCache.TryGetValue(60, out var value))
			{
				value = new GSDel_PlayerTransEnd();
				(value as GSDel_PlayerTransEnd).EventId = 60;
				(value as GSDel_PlayerTransEnd)._OwnerEventCollectionCS = this;
				_EventObjCache[60] = value;
			}
			return value as GSDel_PlayerTransEnd;
		}
		set
		{
		}
	}

	public GSDel_Void_IntInt Evt_ChangePlayerItem
	{
		get
		{
			if (!_EventObjCache.TryGetValue(61, out var value))
			{
				value = new GSDel_Void_IntInt();
				(value as GSDel_Void_IntInt).EventId = 61;
				(value as GSDel_Void_IntInt)._OwnerEventCollectionCS = this;
				_EventObjCache[61] = value;
			}
			return value as GSDel_Void_IntInt;
		}
		set
		{
		}
	}

	public GSDel_ChangePlayerTaskStage Evt_ChangePlayerTaskStage
	{
		get
		{
			if (!_EventObjCache.TryGetValue(62, out var value))
			{
				value = new GSDel_ChangePlayerTaskStage();
				(value as GSDel_ChangePlayerTaskStage).EventId = 62;
				(value as GSDel_ChangePlayerTaskStage)._OwnerEventCollectionCS = this;
				_EventObjCache[62] = value;
			}
			return value as GSDel_ChangePlayerTaskStage;
		}
		set
		{
		}
	}

	public GSDel_DefeatedStateChange Evt_DefeatedStateChange
	{
		get
		{
			if (!_EventObjCache.TryGetValue(63, out var value))
			{
				value = new GSDel_DefeatedStateChange();
				(value as GSDel_DefeatedStateChange).EventId = 63;
				(value as GSDel_DefeatedStateChange)._OwnerEventCollectionCS = this;
				_EventObjCache[63] = value;
			}
			return value as GSDel_DefeatedStateChange;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_TryRemoveBossBarInfo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(64, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 64;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[64] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_TryRemoveEliteBarInfo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(65, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 65;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[65] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_Close_RoleMain
	{
		get
		{
			if (!_EventObjCache.TryGetValue(66, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 66;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[66] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_IntInt Evt_ActiveGeoInfoArea
	{
		get
		{
			if (!_EventObjCache.TryGetValue(67, out var value))
			{
				value = new GSDel_Void_IntInt();
				(value as GSDel_Void_IntInt).EventId = 67;
				(value as GSDel_Void_IntInt)._OwnerEventCollectionCS = this;
				_EventObjCache[67] = value;
			}
			return value as GSDel_Void_IntInt;
		}
		set
		{
		}
	}

	public GSDel_Void_IntInt Evt_ExploreGeoInfoArea
	{
		get
		{
			if (!_EventObjCache.TryGetValue(68, out var value))
			{
				value = new GSDel_Void_IntInt();
				(value as GSDel_Void_IntInt).EventId = 68;
				(value as GSDel_Void_IntInt)._OwnerEventCollectionCS = this;
				_EventObjCache[68] = value;
			}
			return value as GSDel_Void_IntInt;
		}
		set
		{
		}
	}

	public GSDel_Void_GeoInfoCustom Evt_AddGeoInfoCustom
	{
		get
		{
			if (!_EventObjCache.TryGetValue(69, out var value))
			{
				value = new GSDel_Void_GeoInfoCustom();
				(value as GSDel_Void_GeoInfoCustom).EventId = 69;
				(value as GSDel_Void_GeoInfoCustom)._OwnerEventCollectionCS = this;
				_EventObjCache[69] = value;
			}
			return value as GSDel_Void_GeoInfoCustom;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_RemoveGeoInfoCustom
	{
		get
		{
			if (!_EventObjCache.TryGetValue(70, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 70;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[70] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_ClearAllGeoInfoCustom
	{
		get
		{
			if (!_EventObjCache.TryGetValue(71, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 71;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[71] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_GMClearAllArea
	{
		get
		{
			if (!_EventObjCache.TryGetValue(72, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 72;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[72] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_GMActiveRebirthPointArea
	{
		get
		{
			if (!_EventObjCache.TryGetValue(73, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 73;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[73] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_GMCheckRebirthPointArea
	{
		get
		{
			if (!_EventObjCache.TryGetValue(74, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 74;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[74] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_IntInt Evt_SetOSSSlevelLeaveData
	{
		get
		{
			if (!_EventObjCache.TryGetValue(75, out var value))
			{
				value = new GSDel_Void_IntInt();
				(value as GSDel_Void_IntInt).EventId = 75;
				(value as GSDel_Void_IntInt)._OwnerEventCollectionCS = this;
				_EventObjCache[75] = value;
			}
			return value as GSDel_Void_IntInt;
		}
		set
		{
		}
	}

	public GSDel_BPS_PlayerTagTrigger Evt_BPS_PlayerTagTrigger
	{
		get
		{
			if (!_EventObjCache.TryGetValue(76, out var value))
			{
				value = new GSDel_BPS_PlayerTagTrigger();
				(value as GSDel_BPS_PlayerTagTrigger).EventId = 76;
				(value as GSDel_BPS_PlayerTagTrigger)._OwnerEventCollectionCS = this;
				_EventObjCache[76] = value;
			}
			return value as GSDel_BPS_PlayerTagTrigger;
		}
		set
		{
		}
	}

	public GSDel_OSSRebirthPoint Evt_SetOSSRebirthPointData
	{
		get
		{
			if (!_EventObjCache.TryGetValue(77, out var value))
			{
				value = new GSDel_OSSRebirthPoint();
				(value as GSDel_OSSRebirthPoint).EventId = 77;
				(value as GSDel_OSSRebirthPoint)._OwnerEventCollectionCS = this;
				_EventObjCache[77] = value;
			}
			return value as GSDel_OSSRebirthPoint;
		}
		set
		{
		}
	}

	public GSDel_Void_Int_Str Evt_SetOSSSceneWidgetData
	{
		get
		{
			if (!_EventObjCache.TryGetValue(78, out var value))
			{
				value = new GSDel_Void_Int_Str();
				(value as GSDel_Void_Int_Str).EventId = 78;
				(value as GSDel_Void_Int_Str)._OwnerEventCollectionCS = this;
				_EventObjCache[78] = value;
			}
			return value as GSDel_Void_Int_Str;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_SetOSSGameCompleteData
	{
		get
		{
			if (!_EventObjCache.TryGetValue(79, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 79;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[79] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_OSSItemChange Evt_SetOSSItemChangeData
	{
		get
		{
			if (!_EventObjCache.TryGetValue(80, out var value))
			{
				value = new GSDel_OSSItemChange();
				(value as GSDel_OSSItemChange).EventId = 80;
				(value as GSDel_OSSItemChange)._OwnerEventCollectionCS = this;
				_EventObjCache[80] = value;
			}
			return value as GSDel_OSSItemChange;
		}
		set
		{
		}
	}

	public GSDel_Void_Bool Evt_TriggerAllowRide
	{
		get
		{
			if (!_EventObjCache.TryGetValue(81, out var value))
			{
				value = new GSDel_Void_Bool();
				(value as GSDel_Void_Bool).EventId = 81;
				(value as GSDel_Void_Bool)._OwnerEventCollectionCS = this;
				_EventObjCache[81] = value;
			}
			return value as GSDel_Void_Bool;
		}
		set
		{
		}
	}

	public GSDel_CloseConnectionWithResult_ICB Evt_CloseConnectionWithResult
	{
		get
		{
			if (!_EventObjCache.TryGetValue(82, out var value))
			{
				value = new GSDel_CloseConnectionWithResult_ICB(Evt_CloseConnectionWithResult_Invoke, Evt_CloseConnectionWithResult_DelChg);
				(value as GSDel_CloseConnectionWithResult_ICB).EventId = 82;
				(value as GSDel_CloseConnectionWithResult_ICB)._OwnerEventCollectionCS = this;
				_EventObjCache[82] = value;
			}
			return value as GSDel_CloseConnectionWithResult_ICB;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_RebirthTeleportEnd
	{
		get
		{
			if (!_EventObjCache.TryGetValue(83, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 83;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[83] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_SetBossBar Evt_SetBossBar
	{
		get
		{
			if (!_EventObjCache.TryGetValue(84, out var value))
			{
				value = new GSDel_SetBossBar();
				(value as GSDel_SetBossBar).EventId = 84;
				(value as GSDel_SetBossBar)._OwnerEventCollectionCS = this;
				_EventObjCache[84] = value;
			}
			return value as GSDel_SetBossBar;
		}
		set
		{
		}
	}

	public GSDel_SetBossBar Evt_SetEilteBar
	{
		get
		{
			if (!_EventObjCache.TryGetValue(85, out var value))
			{
				value = new GSDel_SetBossBar();
				(value as GSDel_SetBossBar).EventId = 85;
				(value as GSDel_SetBossBar)._OwnerEventCollectionCS = this;
				_EventObjCache[85] = value;
			}
			return value as GSDel_SetBossBar;
		}
		set
		{
		}
	}

	public GSDel_SetBossBar Evt_UpdateHPPercent
	{
		get
		{
			if (!_EventObjCache.TryGetValue(86, out var value))
			{
				value = new GSDel_SetBossBar();
				(value as GSDel_SetBossBar).EventId = 86;
				(value as GSDel_SetBossBar)._OwnerEventCollectionCS = this;
				_EventObjCache[86] = value;
			}
			return value as GSDel_SetBossBar;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BPS_UnitRebirthFinished
	{
		get
		{
			if (!_EventObjCache.TryGetValue(87, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 87;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[87] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BPS_UnitTriggerFallDying
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

	public GSDel_MoveToAction Evt_BPS_MoveToSceneItem
	{
		get
		{
			if (!_EventObjCache.TryGetValue(89, out var value))
			{
				value = new GSDel_MoveToAction();
				(value as GSDel_MoveToAction).EventId = 89;
				(value as GSDel_MoveToAction)._OwnerEventCollectionCS = this;
				_EventObjCache[89] = value;
			}
			return value as GSDel_MoveToAction;
		}
		set
		{
		}
	}

	public GSDel_MoveToAction Evt_BPS_MoveToPos
	{
		get
		{
			if (!_EventObjCache.TryGetValue(90, out var value))
			{
				value = new GSDel_MoveToAction();
				(value as GSDel_MoveToAction).EventId = 90;
				(value as GSDel_MoveToAction)._OwnerEventCollectionCS = this;
				_EventObjCache[90] = value;
			}
			return value as GSDel_MoveToAction;
		}
		set
		{
		}
	}

	public GSDel_EQSRunAction Evt_BPS_EQSRun
	{
		get
		{
			if (!_EventObjCache.TryGetValue(91, out var value))
			{
				value = new GSDel_EQSRunAction();
				(value as GSDel_EQSRunAction).EventId = 91;
				(value as GSDel_EQSRunAction)._OwnerEventCollectionCS = this;
				_EventObjCache[91] = value;
			}
			return value as GSDel_EQSRunAction;
		}
		set
		{
		}
	}

	public GSDel_ComboAction Evt_BPS_Combo
	{
		get
		{
			if (!_EventObjCache.TryGetValue(92, out var value))
			{
				value = new GSDel_ComboAction();
				(value as GSDel_ComboAction).EventId = 92;
				(value as GSDel_ComboAction)._OwnerEventCollectionCS = this;
				_EventObjCache[92] = value;
			}
			return value as GSDel_ComboAction;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BPS_StopCurrentAction
	{
		get
		{
			if (!_EventObjCache.TryGetValue(93, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 93;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[93] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_ActionTimeOut Evt_BPS_MoveToActionTimeOut
	{
		get
		{
			if (!_EventObjCache.TryGetValue(94, out var value))
			{
				value = new GSDel_ActionTimeOut();
				(value as GSDel_ActionTimeOut).EventId = 94;
				(value as GSDel_ActionTimeOut)._OwnerEventCollectionCS = this;
				_EventObjCache[94] = value;
			}
			return value as GSDel_ActionTimeOut;
		}
		set
		{
		}
	}

	public GSDel_ActionTimeOut Evt_BPS_EQSRunActionTimeOut
	{
		get
		{
			if (!_EventObjCache.TryGetValue(95, out var value))
			{
				value = new GSDel_ActionTimeOut();
				(value as GSDel_ActionTimeOut).EventId = 95;
				(value as GSDel_ActionTimeOut)._OwnerEventCollectionCS = this;
				_EventObjCache[95] = value;
			}
			return value as GSDel_ActionTimeOut;
		}
		set
		{
		}
	}

	public GSDel_Void_Actor Evt_BPS_ComboActionTimeOut
	{
		get
		{
			if (!_EventObjCache.TryGetValue(96, out var value))
			{
				value = new GSDel_Void_Actor();
				(value as GSDel_Void_Actor).EventId = 96;
				(value as GSDel_Void_Actor)._OwnerEventCollectionCS = this;
				_EventObjCache[96] = value;
			}
			return value as GSDel_Void_Actor;
		}
		set
		{
		}
	}

	public GSDel_ActionNodeFinish Evt_BPS_ActionNodeFinish
	{
		get
		{
			if (!_EventObjCache.TryGetValue(97, out var value))
			{
				value = new GSDel_ActionNodeFinish();
				(value as GSDel_ActionNodeFinish).EventId = 97;
				(value as GSDel_ActionNodeFinish)._OwnerEventCollectionCS = this;
				_EventObjCache[97] = value;
			}
			return value as GSDel_ActionNodeFinish;
		}
		set
		{
		}
	}

	public GSDel_Void_Int Evt_EnterWeakPerformState
	{
		get
		{
			if (!_EventObjCache.TryGetValue(98, out var value))
			{
				value = new GSDel_Void_Int();
				(value as GSDel_Void_Int).EventId = 98;
				(value as GSDel_Void_Int)._OwnerEventCollectionCS = this;
				_EventObjCache[98] = value;
			}
			return value as GSDel_Void_Int;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_ExitWeakPerformState
	{
		get
		{
			if (!_EventObjCache.TryGetValue(99, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 99;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[99] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_Bool Evt_BPS_EnableCameraFoliageFade
	{
		get
		{
			if (!_EventObjCache.TryGetValue(100, out var value))
			{
				value = new GSDel_Void_Bool();
				(value as GSDel_Void_Bool).EventId = 100;
				(value as GSDel_Void_Bool)._OwnerEventCollectionCS = this;
				_EventObjCache[100] = value;
			}
			return value as GSDel_Void_Bool;
		}
		set
		{
		}
	}

	public GSDel_Void_Float Evt_BPS_SetCameraFoliageFadeValue
	{
		get
		{
			if (!_EventObjCache.TryGetValue(101, out var value))
			{
				value = new GSDel_Void_Float();
				(value as GSDel_Void_Float).EventId = 101;
				(value as GSDel_Void_Float)._OwnerEventCollectionCS = this;
				_EventObjCache[101] = value;
			}
			return value as GSDel_Void_Float;
		}
		set
		{
		}
	}

	public GSDel_Void_Float Evt_BPS_SetPlayerDeathUIDelayTime
	{
		get
		{
			if (!_EventObjCache.TryGetValue(102, out var value))
			{
				value = new GSDel_Void_Float();
				(value as GSDel_Void_Float).EventId = 102;
				(value as GSDel_Void_Float)._OwnerEventCollectionCS = this;
				_EventObjCache[102] = value;
			}
			return value as GSDel_Void_Float;
		}
		set
		{
		}
	}

	public GSDel_Void_Bool Evt_BPS_SetInputDrawDebug
	{
		get
		{
			if (!_EventObjCache.TryGetValue(103, out var value))
			{
				value = new GSDel_Void_Bool();
				(value as GSDel_Void_Bool).EventId = 103;
				(value as GSDel_Void_Bool)._OwnerEventCollectionCS = this;
				_EventObjCache[103] = value;
			}
			return value as GSDel_Void_Bool;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_BPS_SkipInteract
	{
		get
		{
			if (!_EventObjCache.TryGetValue(104, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 104;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[104] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_OnTriggerStopSimpleDropping
	{
		get
		{
			if (!_EventObjCache.TryGetValue(105, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 105;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[105] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_BPS_OnKeyMonsterFightWithLocalPlayer
	{
		get
		{
			if (!_EventObjCache.TryGetValue(106, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 106;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[106] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void_String Evt_BPS_OnPlayerDeadWhenBattleWithKeyMonster
	{
		get
		{
			if (!_EventObjCache.TryGetValue(107, out var value))
			{
				value = new GSDel_Void_String();
				(value as GSDel_Void_String).EventId = 107;
				(value as GSDel_Void_String)._OwnerEventCollectionCS = this;
				_EventObjCache[107] = value;
			}
			return value as GSDel_Void_String;
		}
		set
		{
		}
	}

	public GSDel_Void Evt_ViewTargetBlendComplete
	{
		get
		{
			if (!_EventObjCache.TryGetValue(108, out var value))
			{
				value = new GSDel_Void();
				(value as GSDel_Void).EventId = 108;
				(value as GSDel_Void)._OwnerEventCollectionCS = this;
				_EventObjCache[108] = value;
			}
			return value as GSDel_Void;
		}
		set
		{
		}
	}

	[USharpPath("/Script/b1-Managed.BPS_GSEventCollection:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		base.BeginPlayInCS_Implementation();
		SetIsReplicated(ShouldReplicate: true);
	}

	public static BPS_GSEventCollection Get(APlayerState PlayerState)
	{
		return (PlayerState as BGP_PlayerStateCS)?.PlayerEventCollection;
	}

	public static BPS_GSEventCollection Get(APlayerController PlayerController)
	{
		return (PlayerController?.PlayerState as BGP_PlayerStateCS)?.PlayerEventCollection;
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

	private void Evt_BPS_TestPlayerState_DelChg(Del_Void_Int NewDel)
	{
		Evt_BPS_TestPlayerState_imp = NewDel;
	}

	public void Evt_BPS_TestPlayerState_Invoke(int P1)
	{
		if (base.HasAuthority)
		{
			Evt_BPS_TestPlayerState_Multicast_Invoke(P1);
		}
	}

	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = false)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_TestPlayerState_Multicast_Invoke")]
	public unsafe void Evt_BPS_TestPlayerState_Multicast_Invoke(int P1)
	{
		CheckDestroyed();
		if (!Evt_BPS_TestPlayerState_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_TestPlayerState_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BPS_TestPlayerState_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BPS_TestPlayerState_Multicast_Invoke_ParamsSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Evt_BPS_TestPlayerState_Multicast_Invoke_P1_Offset), P1);
		NativeReflection.InvokeFunction(base.Address, Evt_BPS_TestPlayerState_Multicast_Invoke_FunctionAddress, intPtr, Evt_BPS_TestPlayerState_Multicast_Invoke_ParamsSize);
	}

	[UFunction]
	public void Evt_BPS_TestPlayerState_Multicast_Invoke_Implementation(int P1)
	{
		Evt_BPS_TestPlayerState_imp?.Invoke(P1);
	}

	private void Evt_BPS_AddPredictionKeyState_DelChg(Del_BPS_AddPredictionKeyState NewDel)
	{
		Evt_BPS_AddPredictionKeyState_imp = NewDel;
	}

	public void Evt_BPS_AddPredictionKeyState_Invoke(int KeyId, EPredictionKeyServerState State)
	{
		if (base.HasAuthority)
		{
			Evt_BPS_AddPredictionKeyState_imp?.Invoke(KeyId, State);
		}
	}

	private void Evt_BPS_ServerActivateTamer_DelChg(Del_ServerActivateTamer NewDel)
	{
		Evt_BPS_ServerActivateTamer_imp = NewDel;
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Server, Reliable = true)]
	[USharpPath("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ServerActivateTamer_Invoke")]
	public unsafe void Evt_BPS_ServerActivateTamer_Invoke(List<string> Guids)
	{
		CheckDestroyed();
		if (!Evt_BPS_ServerActivateTamer_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ServerActivateTamer_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BPS_ServerActivateTamer_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BPS_ServerActivateTamer_Invoke_ParamsSize);
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, Evt_BPS_ServerActivateTamer_Invoke_Guids_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, Evt_BPS_ServerActivateTamer_Invoke_Guids_Offset), Guids);
		NativeReflection.InvokeFunction(base.Address, Evt_BPS_ServerActivateTamer_Invoke_FunctionAddress, intPtr, Evt_BPS_ServerActivateTamer_Invoke_ParamsSize);
		Guids = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, Evt_BPS_ServerActivateTamer_Invoke_Guids_Offset));
		NativeReflection.DestroyValue_InContainer(Evt_BPS_ServerActivateTamer_Invoke_Guids_PropertyAddress.Address, intPtr);
	}

	[UFunction]
	public void Evt_BPS_ServerActivateTamer_Invoke_Implementation(List<string> Guids)
	{
		Evt_BPS_ServerActivateTamer_imp?.Invoke(Guids);
	}

	private void Evt_BPS_ClientInitCharacterNetRole_DelChg(Del_ClientInitCharacterNetRole NewDel)
	{
		Evt_BPS_ClientInitCharacterNetRole_imp = NewDel;
	}

	[RPC(Endpoint = RPCEndpoint.Client, Reliable = true)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ClientInitCharacterNetRole_Invoke")]
	public unsafe void Evt_BPS_ClientInitCharacterNetRole_Invoke(List<FTamerRoleSync> Guids)
	{
		CheckDestroyed();
		if (!Evt_BPS_ClientInitCharacterNetRole_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ClientInitCharacterNetRole_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BPS_ClientInitCharacterNetRole_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BPS_ClientInitCharacterNetRole_Invoke_ParamsSize);
		TArrayCopyMarshaler<FTamerRoleSync> tArrayCopyMarshaler = new TArrayCopyMarshaler<FTamerRoleSync>(1, Evt_BPS_ClientInitCharacterNetRole_Invoke_Guids_PropertyAddress, CachedMarshalingDelegates<FTamerRoleSync, FTamerRoleSync>.FromNative, CachedMarshalingDelegates<FTamerRoleSync, FTamerRoleSync>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, Evt_BPS_ClientInitCharacterNetRole_Invoke_Guids_Offset), Guids);
		NativeReflection.InvokeFunction(base.Address, Evt_BPS_ClientInitCharacterNetRole_Invoke_FunctionAddress, intPtr, Evt_BPS_ClientInitCharacterNetRole_Invoke_ParamsSize);
		Guids = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, Evt_BPS_ClientInitCharacterNetRole_Invoke_Guids_Offset));
		NativeReflection.DestroyValue_InContainer(Evt_BPS_ClientInitCharacterNetRole_Invoke_Guids_PropertyAddress.Address, intPtr);
	}

	[UFunction]
	public void Evt_BPS_ClientInitCharacterNetRole_Invoke_Implementation(List<FTamerRoleSync> Guids)
	{
		Evt_BPS_ClientInitCharacterNetRole_imp?.Invoke(Guids);
	}

	private void Evt_BPS_ServerNotifyClientTamerBackToLoad_DelChg(Del_ServerNotifyClientTamerBackToLoad NewDel)
	{
		Evt_BPS_ServerNotifyClientTamerBackToLoad_imp = NewDel;
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Server, Reliable = true)]
	[USharpPath("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke")]
	public unsafe void Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke(List<string> Guids)
	{
		CheckDestroyed();
		if (!Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_ParamsSize);
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_Guids_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_Guids_Offset), Guids);
		NativeReflection.InvokeFunction(base.Address, Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_FunctionAddress, intPtr, Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_ParamsSize);
		Guids = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_Guids_Offset));
		NativeReflection.DestroyValue_InContainer(Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_Guids_PropertyAddress.Address, intPtr);
	}

	[UFunction]
	public void Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_Implementation(List<string> Guids)
	{
		Evt_BPS_ServerNotifyClientTamerBackToLoad_imp?.Invoke(Guids);
	}

	private void Evt_BPS_ServerNotifyClientAuthorityTamerDead_DelChg(Del_ServerNotifyClientAuthorityTamerDead NewDel)
	{
		Evt_BPS_ServerNotifyClientAuthorityTamerDead_imp = NewDel;
	}

	[RPC(Endpoint = RPCEndpoint.Server, Reliable = true)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke")]
	public unsafe void Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke(List<string> Guids)
	{
		CheckDestroyed();
		if (!Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_ParamsSize);
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_Guids_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_Guids_Offset), Guids);
		NativeReflection.InvokeFunction(base.Address, Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_FunctionAddress, intPtr, Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_ParamsSize);
		Guids = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_Guids_Offset));
		NativeReflection.DestroyValue_InContainer(Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_Guids_PropertyAddress.Address, intPtr);
	}

	[UFunction]
	public void Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_Implementation(List<string> Guids)
	{
		Evt_BPS_ServerNotifyClientAuthorityTamerDead_imp?.Invoke(Guids);
	}

	private void Evt_BPS_ServerSpawnDynamicTamer_DelChg(Del_ServerSpawnDynamicTamer NewDel)
	{
		Evt_BPS_ServerSpawnDynamicTamer_imp = NewDel;
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Server, Reliable = true)]
	[USharpPath("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ServerSpawnDynamicTamer_Invoke")]
	public unsafe void Evt_BPS_ServerSpawnDynamicTamer_Invoke(FDynamicTamerSpawnReq TamerClass)
	{
		CheckDestroyed();
		if (!Evt_BPS_ServerSpawnDynamicTamer_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ServerSpawnDynamicTamer_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BPS_ServerSpawnDynamicTamer_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BPS_ServerSpawnDynamicTamer_Invoke_ParamsSize);
		NativeReflection.InitializeValue_InContainer(Evt_BPS_ServerSpawnDynamicTamer_Invoke_TamerClass_PropertyAddress.Address, intPtr);
		FDynamicTamerSpawnReq.ToNative(IntPtr.Add(intPtr, Evt_BPS_ServerSpawnDynamicTamer_Invoke_TamerClass_Offset), TamerClass);
		NativeReflection.InvokeFunction(base.Address, Evt_BPS_ServerSpawnDynamicTamer_Invoke_FunctionAddress, intPtr, Evt_BPS_ServerSpawnDynamicTamer_Invoke_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Evt_BPS_ServerSpawnDynamicTamer_Invoke_TamerClass_PropertyAddress.Address, intPtr);
	}

	[UFunction]
	public void Evt_BPS_ServerSpawnDynamicTamer_Invoke_Implementation(FDynamicTamerSpawnReq TamerClass)
	{
		Evt_BPS_ServerSpawnDynamicTamer_imp?.Invoke(TamerClass);
	}

	private void Evt_BPS_StartTransaction_DelChg(Del_AddTransaction NewDel)
	{
		Evt_BPS_StartTransaction_imp = NewDel;
	}

	public void Evt_BPS_StartTransaction_Invoke(PlayerTransactionBase Transaction)
	{
		if (base.HasAuthority)
		{
			Evt_BPS_StartTransaction_imp?.Invoke(Transaction);
		}
	}

	private void Evt_RequestSummon_DelChg(Del_Void_SummonRequest NewDel)
	{
		Evt_RequestSummon_imp = NewDel;
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Server, Reliable = true)]
	[USharpPath("/Script/b1-Managed.BPS_GSEventCollection:Evt_RequestSummon_Invoke")]
	public unsafe void Evt_RequestSummon_Invoke(FSummonReq InSummonReq)
	{
		CheckDestroyed();
		if (!Evt_RequestSummon_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BPS_GSEventCollection:Evt_RequestSummon_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_RequestSummon_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_RequestSummon_Invoke_ParamsSize);
		NativeReflection.InitializeValue_InContainer(Evt_RequestSummon_Invoke_InSummonReq_PropertyAddress.Address, intPtr);
		FSummonReq.ToNative(IntPtr.Add(intPtr, Evt_RequestSummon_Invoke_InSummonReq_Offset), InSummonReq);
		NativeReflection.InvokeFunction(base.Address, Evt_RequestSummon_Invoke_FunctionAddress, intPtr, Evt_RequestSummon_Invoke_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Evt_RequestSummon_Invoke_InSummonReq_PropertyAddress.Address, intPtr);
	}

	[UFunction]
	public void Evt_RequestSummon_Invoke_Implementation(FSummonReq InSummonReq)
	{
		Evt_RequestSummon_imp?.Invoke(InSummonReq);
	}

	private void Evt_SendServantReq_DelChg(Del_Void_ServantReq NewDel)
	{
		Evt_SendServantReq_imp = NewDel;
	}

	public void Evt_SendServantReq_Invoke(FServantReq InServantReq)
	{
		if (base.HasAuthority)
		{
			Evt_SendServantReq_Multicast_Invoke(InServantReq);
		}
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = true)]
	[USharpPath("/Script/b1-Managed.BPS_GSEventCollection:Evt_SendServantReq_Multicast_Invoke")]
	public unsafe void Evt_SendServantReq_Multicast_Invoke(FServantReq InServantReq)
	{
		CheckDestroyed();
		if (!Evt_SendServantReq_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BPS_GSEventCollection:Evt_SendServantReq_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_SendServantReq_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_SendServantReq_Multicast_Invoke_ParamsSize);
		NativeReflection.InitializeValue_InContainer(Evt_SendServantReq_Multicast_Invoke_InServantReq_PropertyAddress.Address, intPtr);
		FServantReq.ToNative(IntPtr.Add(intPtr, Evt_SendServantReq_Multicast_Invoke_InServantReq_Offset), InServantReq);
		NativeReflection.InvokeFunction(base.Address, Evt_SendServantReq_Multicast_Invoke_FunctionAddress, intPtr, Evt_SendServantReq_Multicast_Invoke_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Evt_SendServantReq_Multicast_Invoke_InServantReq_PropertyAddress.Address, intPtr);
	}

	[UFunction]
	public void Evt_SendServantReq_Multicast_Invoke_Implementation(FServantReq InServantReq)
	{
		Evt_SendServantReq_imp?.Invoke(InServantReq);
	}

	private void Evt_BPS_SyncRoleDataTmp_DelChg(Del_Param_RoleData NewDel)
	{
		Evt_BPS_SyncRoleDataTmp_imp = NewDel;
	}

	[RPC(Endpoint = RPCEndpoint.Server, Reliable = true)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_SyncRoleDataTmp_Invoke")]
	public unsafe void Evt_BPS_SyncRoleDataTmp_Invoke(List<byte> RoleData)
	{
		CheckDestroyed();
		if (!Evt_BPS_SyncRoleDataTmp_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_SyncRoleDataTmp_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BPS_SyncRoleDataTmp_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BPS_SyncRoleDataTmp_Invoke_ParamsSize);
		TArrayCopyMarshaler<byte> tArrayCopyMarshaler = new TArrayCopyMarshaler<byte>(1, Evt_BPS_SyncRoleDataTmp_Invoke_RoleData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, Evt_BPS_SyncRoleDataTmp_Invoke_RoleData_Offset), RoleData);
		NativeReflection.InvokeFunction(base.Address, Evt_BPS_SyncRoleDataTmp_Invoke_FunctionAddress, intPtr, Evt_BPS_SyncRoleDataTmp_Invoke_ParamsSize);
		RoleData = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, Evt_BPS_SyncRoleDataTmp_Invoke_RoleData_Offset));
		NativeReflection.DestroyValue_InContainer(Evt_BPS_SyncRoleDataTmp_Invoke_RoleData_PropertyAddress.Address, intPtr);
	}

	[UFunction]
	public void Evt_BPS_SyncRoleDataTmp_Invoke_Implementation(List<byte> RoleData)
	{
		Evt_BPS_SyncRoleDataTmp_imp?.Invoke(RoleData);
	}

	private void Evt_TmpTransSendDropItem_DelChg(Del_Void_Int NewDel)
	{
		Evt_TmpTransSendDropItem_imp = NewDel;
	}

	[RPC(Endpoint = RPCEndpoint.Server, Reliable = true)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BPS_GSEventCollection:Evt_TmpTransSendDropItem_Invoke")]
	public unsafe void Evt_TmpTransSendDropItem_Invoke(int P1)
	{
		CheckDestroyed();
		if (!Evt_TmpTransSendDropItem_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BPS_GSEventCollection:Evt_TmpTransSendDropItem_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_TmpTransSendDropItem_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_TmpTransSendDropItem_Invoke_ParamsSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Evt_TmpTransSendDropItem_Invoke_P1_Offset), P1);
		NativeReflection.InvokeFunction(base.Address, Evt_TmpTransSendDropItem_Invoke_FunctionAddress, intPtr, Evt_TmpTransSendDropItem_Invoke_ParamsSize);
	}

	[UFunction]
	public void Evt_TmpTransSendDropItem_Invoke_Implementation(int P1)
	{
		Evt_TmpTransSendDropItem_imp?.Invoke(P1);
	}

	private void Evt_BPS_SwitchPlayerTransState_DelChg(Del_SwitchPlayerTransState NewDel)
	{
		Evt_BPS_SwitchPlayerTransState_imp = NewDel;
	}

	public void Evt_BPS_SwitchPlayerTransState_Invoke(AActor OldActor, int NewActorResId)
	{
		if (base.HasAuthority)
		{
			Evt_BPS_SwitchPlayerTransState_Multicast_Invoke(OldActor, NewActorResId);
		}
	}

	[UFunction]
	[RPC(Endpoint = RPCEndpoint.Multicast, Reliable = true)]
	[USharpPath("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_SwitchPlayerTransState_Multicast_Invoke")]
	public unsafe void Evt_BPS_SwitchPlayerTransState_Multicast_Invoke(AActor OldActor, int NewActorResId)
	{
		CheckDestroyed();
		if (!Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_SwitchPlayerTransState_Multicast_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_ParamsSize);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_OldActor_Offset), OldActor);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_NewActorResId_Offset), NewActorResId);
		NativeReflection.InvokeFunction(base.Address, Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_FunctionAddress, intPtr, Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_ParamsSize);
	}

	[UFunction]
	public void Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_Implementation(AActor OldActor, int NewActorResId)
	{
		Evt_BPS_SwitchPlayerTransState_imp?.Invoke(OldActor, NewActorResId);
	}

	private void Evt_CloseConnectionWithResult_DelChg(Del_CloseConnectionWithResult NewDel)
	{
		Evt_CloseConnectionWithResult_imp = NewDel;
	}

	[RPC(Endpoint = RPCEndpoint.Client, Reliable = true)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BPS_GSEventCollection:Evt_CloseConnectionWithResult_Invoke")]
	public unsafe void Evt_CloseConnectionWithResult_Invoke(EGSNetCloseResult CloseResult)
	{
		CheckDestroyed();
		if (!Evt_CloseConnectionWithResult_Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BPS_GSEventCollection:Evt_CloseConnectionWithResult_Invoke");
			return;
		}
		byte* value = stackalloc byte[(int)(uint)Evt_CloseConnectionWithResult_Invoke_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, Evt_CloseConnectionWithResult_Invoke_ParamsSize);
		EnumMarshaler<EGSNetCloseResult>.ToNative(IntPtr.Add(intPtr, Evt_CloseConnectionWithResult_Invoke_CloseResult_Offset), 0, Evt_CloseConnectionWithResult_Invoke_CloseResult_PropertyAddress.Address, CloseResult);
		NativeReflection.InvokeFunction(base.Address, Evt_CloseConnectionWithResult_Invoke_FunctionAddress, intPtr, Evt_CloseConnectionWithResult_Invoke_ParamsSize);
	}

	[UFunction]
	public void Evt_CloseConnectionWithResult_Invoke_Implementation(EGSNetCloseResult CloseResult)
	{
		Evt_CloseConnectionWithResult_imp?.Invoke(CloseResult);
	}

	[USharpPath("/Script/b1-Managed.BPS_GSEventCollection:EndPlayInCS")]
	protected override void EndPlayInCS_Implementation(EEndPlayReason EndPlayReason)
	{
		base.EndPlayInCS_Implementation(EndPlayReason);
		Evt_BPS_TestPlayerState_imp = null;
		Evt_BPS_AddPredictionKeyState_imp = null;
		Evt_BPS_ServerActivateTamer_imp = null;
		Evt_BPS_ClientInitCharacterNetRole_imp = null;
		Evt_BPS_ServerNotifyClientTamerBackToLoad_imp = null;
		Evt_BPS_ServerNotifyClientAuthorityTamerDead_imp = null;
		Evt_BPS_ServerSpawnDynamicTamer_imp = null;
		Evt_BPS_StartTransaction_imp = null;
		Evt_RequestSummon_imp = null;
		Evt_SendServantReq_imp = null;
		Evt_BPS_SyncRoleDataTmp_imp = null;
		Evt_TmpTransSendDropItem_imp = null;
		Evt_BPS_SwitchPlayerTransState_imp = null;
		Evt_CloseConnectionWithResult_imp = null;
	}

	static BPS_GSEventCollection()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BPS_GSEventCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BPS_GSEventCollection));
	}

	[UFunctionInvoker("/Script/b1-Managed.BPS_GSEventCollection:Evt_RequestSummon_Invoke")]
	private static void Evt_RequestSummon_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BPS_GSEventCollection bPS_GSEventCollection = GCHelper.Find<BPS_GSEventCollection>(obj);
		FSummonReq inSummonReq = FSummonReq.FromNative(IntPtr.Add(buffer, Evt_RequestSummon_Invoke_InSummonReq_Offset));
		bPS_GSEventCollection.Evt_RequestSummon_Invoke_Implementation(inSummonReq);
	}

	[UFunctionInvoker("/Script/b1-Managed.BPS_GSEventCollection:EndPlayInCS")]
	private static void EndPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BPS_GSEventCollection bPS_GSEventCollection = GCHelper.Find<BPS_GSEventCollection>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, EndPlayInCS_EndPlayReason_Offset), 0, EndPlayInCS_EndPlayReason_PropertyAddress.Address);
		bPS_GSEventCollection.EndPlayInCS_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BPS_GSEventCollection:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BPS_GSEventCollection bPS_GSEventCollection = GCHelper.Find<BPS_GSEventCollection>(obj);
		bPS_GSEventCollection.BeginPlayInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_SyncRoleDataTmp_Invoke")]
	private static void Evt_BPS_SyncRoleDataTmp_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BPS_GSEventCollection bPS_GSEventCollection = GCHelper.Find<BPS_GSEventCollection>(obj);
		List<byte> roleData = new TArrayCopyMarshaler<byte>(1, Evt_BPS_SyncRoleDataTmp_Invoke_RoleData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(buffer, Evt_BPS_SyncRoleDataTmp_Invoke_RoleData_Offset));
		bPS_GSEventCollection.Evt_BPS_SyncRoleDataTmp_Invoke_Implementation(roleData);
	}

	[UFunctionInvoker("/Script/b1-Managed.BPS_GSEventCollection:Evt_TmpTransSendDropItem_Invoke")]
	private static void Evt_TmpTransSendDropItem_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BPS_GSEventCollection bPS_GSEventCollection = GCHelper.Find<BPS_GSEventCollection>(obj);
		int p = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, Evt_TmpTransSendDropItem_Invoke_P1_Offset));
		bPS_GSEventCollection.Evt_TmpTransSendDropItem_Invoke_Implementation(p);
	}

	[UFunctionInvoker("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ServerActivateTamer_Invoke")]
	private static void Evt_BPS_ServerActivateTamer_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BPS_GSEventCollection bPS_GSEventCollection = GCHelper.Find<BPS_GSEventCollection>(obj);
		List<string> guids = new TArrayCopyMarshaler<string>(1, Evt_BPS_ServerActivateTamer_Invoke_Guids_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(buffer, Evt_BPS_ServerActivateTamer_Invoke_Guids_Offset));
		bPS_GSEventCollection.Evt_BPS_ServerActivateTamer_Invoke_Implementation(guids);
	}

	[UFunctionInvoker("/Script/b1-Managed.BPS_GSEventCollection:Evt_SendServantReq_Multicast_Invoke")]
	private static void Evt_SendServantReq_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BPS_GSEventCollection bPS_GSEventCollection = GCHelper.Find<BPS_GSEventCollection>(obj);
		FServantReq inServantReq = FServantReq.FromNative(IntPtr.Add(buffer, Evt_SendServantReq_Multicast_Invoke_InServantReq_Offset));
		bPS_GSEventCollection.Evt_SendServantReq_Multicast_Invoke_Implementation(inServantReq);
	}

	[UFunctionInvoker("/Script/b1-Managed.BPS_GSEventCollection:Evt_CloseConnectionWithResult_Invoke")]
	private static void Evt_CloseConnectionWithResult_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BPS_GSEventCollection bPS_GSEventCollection = GCHelper.Find<BPS_GSEventCollection>(obj);
		EGSNetCloseResult closeResult = EnumMarshaler<EGSNetCloseResult>.FromNative(IntPtr.Add(buffer, Evt_CloseConnectionWithResult_Invoke_CloseResult_Offset), 0, Evt_CloseConnectionWithResult_Invoke_CloseResult_PropertyAddress.Address);
		bPS_GSEventCollection.Evt_CloseConnectionWithResult_Invoke_Implementation(closeResult);
	}

	[UFunctionInvoker("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ServerSpawnDynamicTamer_Invoke")]
	private static void Evt_BPS_ServerSpawnDynamicTamer_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BPS_GSEventCollection bPS_GSEventCollection = GCHelper.Find<BPS_GSEventCollection>(obj);
		FDynamicTamerSpawnReq tamerClass = FDynamicTamerSpawnReq.FromNative(IntPtr.Add(buffer, Evt_BPS_ServerSpawnDynamicTamer_Invoke_TamerClass_Offset));
		bPS_GSEventCollection.Evt_BPS_ServerSpawnDynamicTamer_Invoke_Implementation(tamerClass);
	}

	[UFunctionInvoker("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_TestPlayerState_Multicast_Invoke")]
	private static void Evt_BPS_TestPlayerState_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BPS_GSEventCollection bPS_GSEventCollection = GCHelper.Find<BPS_GSEventCollection>(obj);
		int p = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, Evt_BPS_TestPlayerState_Multicast_Invoke_P1_Offset));
		bPS_GSEventCollection.Evt_BPS_TestPlayerState_Multicast_Invoke_Implementation(p);
	}

	[UFunctionInvoker("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ClientInitCharacterNetRole_Invoke")]
	private static void Evt_BPS_ClientInitCharacterNetRole_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BPS_GSEventCollection bPS_GSEventCollection = GCHelper.Find<BPS_GSEventCollection>(obj);
		List<FTamerRoleSync> guids = new TArrayCopyMarshaler<FTamerRoleSync>(1, Evt_BPS_ClientInitCharacterNetRole_Invoke_Guids_PropertyAddress, CachedMarshalingDelegates<FTamerRoleSync, FTamerRoleSync>.FromNative, CachedMarshalingDelegates<FTamerRoleSync, FTamerRoleSync>.ToNative).FromNative(IntPtr.Add(buffer, Evt_BPS_ClientInitCharacterNetRole_Invoke_Guids_Offset));
		bPS_GSEventCollection.Evt_BPS_ClientInitCharacterNetRole_Invoke_Implementation(guids);
	}

	[UFunctionInvoker("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_SwitchPlayerTransState_Multicast_Invoke")]
	private static void Evt_BPS_SwitchPlayerTransState_Multicast_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BPS_GSEventCollection bPS_GSEventCollection = GCHelper.Find<BPS_GSEventCollection>(obj);
		AActor oldActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_OldActor_Offset));
		int newActorResId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_NewActorResId_Offset));
		bPS_GSEventCollection.Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_Implementation(oldActor, newActorResId);
	}

	[UFunctionInvoker("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke")]
	private static void Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BPS_GSEventCollection bPS_GSEventCollection = GCHelper.Find<BPS_GSEventCollection>(obj);
		List<string> guids = new TArrayCopyMarshaler<string>(1, Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_Guids_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(buffer, Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_Guids_Offset));
		bPS_GSEventCollection.Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_Implementation(guids);
	}

	[UFunctionInvoker("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke")]
	private static void Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke__Invoker(IntPtr buffer, IntPtr obj)
	{
		BPS_GSEventCollection bPS_GSEventCollection = GCHelper.Find<BPS_GSEventCollection>(obj);
		List<string> guids = new TArrayCopyMarshaler<string>(1, Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_Guids_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(buffer, Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_Guids_Offset));
		bPS_GSEventCollection.Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_Implementation(guids);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BPS_GSEventCollection");
		Evt_RequestSummon_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_RequestSummon_Invoke");
		Evt_RequestSummon_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_RequestSummon_Invoke_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Evt_RequestSummon_Invoke_InSummonReq_PropertyAddress, Evt_RequestSummon_Invoke_FunctionAddress, "InSummonReq");
		Evt_RequestSummon_Invoke_InSummonReq_Offset = NativeReflection.GetPropertyOffset(Evt_RequestSummon_Invoke_FunctionAddress, "InSummonReq");
		Evt_RequestSummon_Invoke_InSummonReq_IsValid = NativeReflection.ValidatePropertyClass(Evt_RequestSummon_Invoke_FunctionAddress, "InSummonReq", Classes.FStructProperty);
		Evt_RequestSummon_Invoke_IsValid = Evt_RequestSummon_Invoke_FunctionAddress != IntPtr.Zero && Evt_RequestSummon_Invoke_InSummonReq_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BPS_GSEventCollection:Evt_RequestSummon_Invoke", Evt_RequestSummon_Invoke_IsValid);
		EndPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EndPlayInCS");
		EndPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(EndPlayInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref EndPlayInCS_EndPlayReason_PropertyAddress, EndPlayInCS_FunctionAddress, "EndPlayReason");
		EndPlayInCS_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(EndPlayInCS_FunctionAddress, "EndPlayReason");
		EndPlayInCS_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(EndPlayInCS_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		EndPlayInCS_IsValid = EndPlayInCS_FunctionAddress != IntPtr.Zero && EndPlayInCS_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BPS_GSEventCollection:EndPlayInCS", EndPlayInCS_IsValid);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BPS_GSEventCollection:BeginPlayInCS", BeginPlayInCS_IsValid);
		Evt_BPS_SyncRoleDataTmp_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BPS_SyncRoleDataTmp_Invoke");
		Evt_BPS_SyncRoleDataTmp_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BPS_SyncRoleDataTmp_Invoke_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Evt_BPS_SyncRoleDataTmp_Invoke_RoleData_PropertyAddress, Evt_BPS_SyncRoleDataTmp_Invoke_FunctionAddress, "RoleData");
		Evt_BPS_SyncRoleDataTmp_Invoke_RoleData_Offset = NativeReflection.GetPropertyOffset(Evt_BPS_SyncRoleDataTmp_Invoke_FunctionAddress, "RoleData");
		Evt_BPS_SyncRoleDataTmp_Invoke_RoleData_IsValid = NativeReflection.ValidatePropertyClass(Evt_BPS_SyncRoleDataTmp_Invoke_FunctionAddress, "RoleData", Classes.FArrayProperty);
		Evt_BPS_SyncRoleDataTmp_Invoke_IsValid = Evt_BPS_SyncRoleDataTmp_Invoke_FunctionAddress != IntPtr.Zero && Evt_BPS_SyncRoleDataTmp_Invoke_RoleData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_SyncRoleDataTmp_Invoke", Evt_BPS_SyncRoleDataTmp_Invoke_IsValid);
		Evt_TmpTransSendDropItem_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_TmpTransSendDropItem_Invoke");
		Evt_TmpTransSendDropItem_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_TmpTransSendDropItem_Invoke_FunctionAddress);
		Evt_TmpTransSendDropItem_Invoke_P1_Offset = NativeReflection.GetPropertyOffset(Evt_TmpTransSendDropItem_Invoke_FunctionAddress, "P1");
		Evt_TmpTransSendDropItem_Invoke_P1_IsValid = NativeReflection.ValidatePropertyClass(Evt_TmpTransSendDropItem_Invoke_FunctionAddress, "P1", Classes.FIntProperty);
		Evt_TmpTransSendDropItem_Invoke_IsValid = Evt_TmpTransSendDropItem_Invoke_FunctionAddress != IntPtr.Zero && Evt_TmpTransSendDropItem_Invoke_P1_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BPS_GSEventCollection:Evt_TmpTransSendDropItem_Invoke", Evt_TmpTransSendDropItem_Invoke_IsValid);
		Evt_BPS_ServerActivateTamer_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BPS_ServerActivateTamer_Invoke");
		Evt_BPS_ServerActivateTamer_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BPS_ServerActivateTamer_Invoke_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Evt_BPS_ServerActivateTamer_Invoke_Guids_PropertyAddress, Evt_BPS_ServerActivateTamer_Invoke_FunctionAddress, "Guids");
		Evt_BPS_ServerActivateTamer_Invoke_Guids_Offset = NativeReflection.GetPropertyOffset(Evt_BPS_ServerActivateTamer_Invoke_FunctionAddress, "Guids");
		Evt_BPS_ServerActivateTamer_Invoke_Guids_IsValid = NativeReflection.ValidatePropertyClass(Evt_BPS_ServerActivateTamer_Invoke_FunctionAddress, "Guids", Classes.FArrayProperty);
		Evt_BPS_ServerActivateTamer_Invoke_IsValid = Evt_BPS_ServerActivateTamer_Invoke_FunctionAddress != IntPtr.Zero && Evt_BPS_ServerActivateTamer_Invoke_Guids_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ServerActivateTamer_Invoke", Evt_BPS_ServerActivateTamer_Invoke_IsValid);
		Evt_SendServantReq_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_SendServantReq_Multicast_Invoke");
		Evt_SendServantReq_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_SendServantReq_Multicast_Invoke_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Evt_SendServantReq_Multicast_Invoke_InServantReq_PropertyAddress, Evt_SendServantReq_Multicast_Invoke_FunctionAddress, "InServantReq");
		Evt_SendServantReq_Multicast_Invoke_InServantReq_Offset = NativeReflection.GetPropertyOffset(Evt_SendServantReq_Multicast_Invoke_FunctionAddress, "InServantReq");
		Evt_SendServantReq_Multicast_Invoke_InServantReq_IsValid = NativeReflection.ValidatePropertyClass(Evt_SendServantReq_Multicast_Invoke_FunctionAddress, "InServantReq", Classes.FStructProperty);
		Evt_SendServantReq_Multicast_Invoke_IsValid = Evt_SendServantReq_Multicast_Invoke_FunctionAddress != IntPtr.Zero && Evt_SendServantReq_Multicast_Invoke_InServantReq_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BPS_GSEventCollection:Evt_SendServantReq_Multicast_Invoke", Evt_SendServantReq_Multicast_Invoke_IsValid);
		Evt_CloseConnectionWithResult_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_CloseConnectionWithResult_Invoke");
		Evt_CloseConnectionWithResult_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_CloseConnectionWithResult_Invoke_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Evt_CloseConnectionWithResult_Invoke_CloseResult_PropertyAddress, Evt_CloseConnectionWithResult_Invoke_FunctionAddress, "CloseResult");
		Evt_CloseConnectionWithResult_Invoke_CloseResult_Offset = NativeReflection.GetPropertyOffset(Evt_CloseConnectionWithResult_Invoke_FunctionAddress, "CloseResult");
		Evt_CloseConnectionWithResult_Invoke_CloseResult_IsValid = NativeReflection.ValidatePropertyClass(Evt_CloseConnectionWithResult_Invoke_FunctionAddress, "CloseResult", Classes.FEnumProperty);
		Evt_CloseConnectionWithResult_Invoke_IsValid = Evt_CloseConnectionWithResult_Invoke_FunctionAddress != IntPtr.Zero && Evt_CloseConnectionWithResult_Invoke_CloseResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BPS_GSEventCollection:Evt_CloseConnectionWithResult_Invoke", Evt_CloseConnectionWithResult_Invoke_IsValid);
		Evt_BPS_ServerSpawnDynamicTamer_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BPS_ServerSpawnDynamicTamer_Invoke");
		Evt_BPS_ServerSpawnDynamicTamer_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BPS_ServerSpawnDynamicTamer_Invoke_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Evt_BPS_ServerSpawnDynamicTamer_Invoke_TamerClass_PropertyAddress, Evt_BPS_ServerSpawnDynamicTamer_Invoke_FunctionAddress, "TamerClass");
		Evt_BPS_ServerSpawnDynamicTamer_Invoke_TamerClass_Offset = NativeReflection.GetPropertyOffset(Evt_BPS_ServerSpawnDynamicTamer_Invoke_FunctionAddress, "TamerClass");
		Evt_BPS_ServerSpawnDynamicTamer_Invoke_TamerClass_IsValid = NativeReflection.ValidatePropertyClass(Evt_BPS_ServerSpawnDynamicTamer_Invoke_FunctionAddress, "TamerClass", Classes.FStructProperty);
		Evt_BPS_ServerSpawnDynamicTamer_Invoke_IsValid = Evt_BPS_ServerSpawnDynamicTamer_Invoke_FunctionAddress != IntPtr.Zero && Evt_BPS_ServerSpawnDynamicTamer_Invoke_TamerClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ServerSpawnDynamicTamer_Invoke", Evt_BPS_ServerSpawnDynamicTamer_Invoke_IsValid);
		Evt_BPS_TestPlayerState_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BPS_TestPlayerState_Multicast_Invoke");
		Evt_BPS_TestPlayerState_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BPS_TestPlayerState_Multicast_Invoke_FunctionAddress);
		Evt_BPS_TestPlayerState_Multicast_Invoke_P1_Offset = NativeReflection.GetPropertyOffset(Evt_BPS_TestPlayerState_Multicast_Invoke_FunctionAddress, "P1");
		Evt_BPS_TestPlayerState_Multicast_Invoke_P1_IsValid = NativeReflection.ValidatePropertyClass(Evt_BPS_TestPlayerState_Multicast_Invoke_FunctionAddress, "P1", Classes.FIntProperty);
		Evt_BPS_TestPlayerState_Multicast_Invoke_IsValid = Evt_BPS_TestPlayerState_Multicast_Invoke_FunctionAddress != IntPtr.Zero && Evt_BPS_TestPlayerState_Multicast_Invoke_P1_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_TestPlayerState_Multicast_Invoke", Evt_BPS_TestPlayerState_Multicast_Invoke_IsValid);
		Evt_BPS_ClientInitCharacterNetRole_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BPS_ClientInitCharacterNetRole_Invoke");
		Evt_BPS_ClientInitCharacterNetRole_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BPS_ClientInitCharacterNetRole_Invoke_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Evt_BPS_ClientInitCharacterNetRole_Invoke_Guids_PropertyAddress, Evt_BPS_ClientInitCharacterNetRole_Invoke_FunctionAddress, "Guids");
		Evt_BPS_ClientInitCharacterNetRole_Invoke_Guids_Offset = NativeReflection.GetPropertyOffset(Evt_BPS_ClientInitCharacterNetRole_Invoke_FunctionAddress, "Guids");
		Evt_BPS_ClientInitCharacterNetRole_Invoke_Guids_IsValid = NativeReflection.ValidatePropertyClass(Evt_BPS_ClientInitCharacterNetRole_Invoke_FunctionAddress, "Guids", Classes.FArrayProperty);
		Evt_BPS_ClientInitCharacterNetRole_Invoke_IsValid = Evt_BPS_ClientInitCharacterNetRole_Invoke_FunctionAddress != IntPtr.Zero && Evt_BPS_ClientInitCharacterNetRole_Invoke_Guids_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ClientInitCharacterNetRole_Invoke", Evt_BPS_ClientInitCharacterNetRole_Invoke_IsValid);
		Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BPS_SwitchPlayerTransState_Multicast_Invoke");
		Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_FunctionAddress);
		Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_OldActor_Offset = NativeReflection.GetPropertyOffset(Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_FunctionAddress, "OldActor");
		Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_OldActor_IsValid = NativeReflection.ValidatePropertyClass(Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_FunctionAddress, "OldActor", Classes.FObjectProperty);
		Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_NewActorResId_Offset = NativeReflection.GetPropertyOffset(Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_FunctionAddress, "NewActorResId");
		Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_NewActorResId_IsValid = NativeReflection.ValidatePropertyClass(Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_FunctionAddress, "NewActorResId", Classes.FIntProperty);
		Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_IsValid = Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_FunctionAddress != IntPtr.Zero && Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_OldActor_IsValid && Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_NewActorResId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_SwitchPlayerTransState_Multicast_Invoke", Evt_BPS_SwitchPlayerTransState_Multicast_Invoke_IsValid);
		Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke");
		Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_Guids_PropertyAddress, Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_FunctionAddress, "Guids");
		Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_Guids_Offset = NativeReflection.GetPropertyOffset(Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_FunctionAddress, "Guids");
		Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_Guids_IsValid = NativeReflection.ValidatePropertyClass(Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_FunctionAddress, "Guids", Classes.FArrayProperty);
		Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_IsValid = Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_FunctionAddress != IntPtr.Zero && Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_Guids_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke", Evt_BPS_ServerNotifyClientTamerBackToLoad_Invoke_IsValid);
		Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke");
		Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_Guids_PropertyAddress, Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_FunctionAddress, "Guids");
		Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_Guids_Offset = NativeReflection.GetPropertyOffset(Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_FunctionAddress, "Guids");
		Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_Guids_IsValid = NativeReflection.ValidatePropertyClass(Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_FunctionAddress, "Guids", Classes.FArrayProperty);
		Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_IsValid = Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_FunctionAddress != IntPtr.Zero && Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_Guids_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BPS_GSEventCollection:Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke", Evt_BPS_ServerNotifyClientAuthorityTamerDead_Invoke_IsValid);
	}
}
