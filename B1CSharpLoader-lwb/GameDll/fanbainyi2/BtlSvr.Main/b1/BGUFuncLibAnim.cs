using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFuncLibAnim")]
public class BGUFuncLibAnim : UBlueprintFunctionLibrary
{
	private static bool BGURootMotionJumpEnd_IsValid;

	private static IntPtr BGURootMotionJumpEnd_FunctionAddress;

	private static int BGURootMotionJumpEnd_ParamsSize;

	private static bool BGURootMotionJumpEnd_Owner_IsValid;

	private static int BGURootMotionJumpEnd_Owner_Offset;

	private static bool BGUSetUseSnapshotPose_IsValid;

	private static IntPtr BGUSetUseSnapshotPose_FunctionAddress;

	private static int BGUSetUseSnapshotPose_ParamsSize;

	private static bool BGUSetUseSnapshotPose_Owner_IsValid;

	private static int BGUSetUseSnapshotPose_Owner_Offset;

	private static bool BGUSetUseSnapshotPose_bUseSnapshot_IsValid;

	private static int BGUSetUseSnapshotPose_bUseSnapshot_Offset;

	private static FFieldAddress BGUSetUseSnapshotPose_bUseSnapshot_PropertyAddress;

	private static bool BGUSetUseSnapshotPose_BlendTime_IsValid;

	private static int BGUSetUseSnapshotPose_BlendTime_Offset;

	private static bool BGUActorTryPlayMontage_IsValid;

	private static IntPtr BGUActorTryPlayMontage_FunctionAddress;

	private static int BGUActorTryPlayMontage_ParamsSize;

	private static bool BGUActorTryPlayMontage_Owner_IsValid;

	private static int BGUActorTryPlayMontage_Owner_Offset;

	private static bool BGUActorTryPlayMontage_Montage_IsValid;

	private static int BGUActorTryPlayMontage_Montage_Offset;

	private static bool BGUActorTryPlayMontage_StartSectionName_IsValid;

	private static int BGUActorTryPlayMontage_StartSectionName_Offset;

	private static bool BGUActorTryPlayMontage_Reason_IsValid;

	private static int BGUActorTryPlayMontage_Reason_Offset;

	private static FFieldAddress BGUActorTryPlayMontage_Reason_PropertyAddress;

	private static bool BGUActorTryPlayMontage_Scale_IsValid;

	private static int BGUActorTryPlayMontage_Scale_Offset;

	private static bool BGUActorTryPlayMontage_PlayTimeRate_IsValid;

	private static int BGUActorTryPlayMontage_PlayTimeRate_Offset;

	private static bool BGUActorTryPlayMontage_MontagePosOffset_IsValid;

	private static int BGUActorTryPlayMontage_MontagePosOffset_Offset;

	private static bool BGUActorTryPlayMontage_ReturnValue_IsValid;

	private static int BGUActorTryPlayMontage_ReturnValue_Offset;

	private static bool BGURootMotionJumpStart_IsValid;

	private static IntPtr BGURootMotionJumpStart_FunctionAddress;

	private static int BGURootMotionJumpStart_ParamsSize;

	private static bool BGURootMotionJumpStart_Owner_IsValid;

	private static int BGURootMotionJumpStart_Owner_Offset;

	private static bool BGUSetGlideMoveAnimState_IsValid;

	private static IntPtr BGUSetGlideMoveAnimState_FunctionAddress;

	private static int BGUSetGlideMoveAnimState_ParamsSize;

	private static bool BGUSetGlideMoveAnimState_Owner_IsValid;

	private static int BGUSetGlideMoveAnimState_Owner_Offset;

	private static bool BGUSetGlideMoveAnimState_State_IsValid;

	private static int BGUSetGlideMoveAnimState_State_Offset;

	private static FFieldAddress BGUSetGlideMoveAnimState_State_PropertyAddress;

	private static bool BGUSetParkourMoveAnimState_IsValid;

	private static IntPtr BGUSetParkourMoveAnimState_FunctionAddress;

	private static int BGUSetParkourMoveAnimState_ParamsSize;

	private static bool BGUSetParkourMoveAnimState_Owner_IsValid;

	private static int BGUSetParkourMoveAnimState_Owner_Offset;

	private static bool BGUSetParkourMoveAnimState_State_IsValid;

	private static int BGUSetParkourMoveAnimState_State_Offset;

	private static FFieldAddress BGUSetParkourMoveAnimState_State_PropertyAddress;

	private static bool BGUSplineMoveEnterStopState_IsValid;

	private static IntPtr BGUSplineMoveEnterStopState_FunctionAddress;

	private static int BGUSplineMoveEnterStopState_ParamsSize;

	private static bool BGUSplineMoveEnterStopState_Owner_IsValid;

	private static int BGUSplineMoveEnterStopState_Owner_Offset;

	private static bool BGUPlayerLocomotionStartIdle_IsValid;

	private static IntPtr BGUPlayerLocomotionStartIdle_FunctionAddress;

	private static int BGUPlayerLocomotionStartIdle_ParamsSize;

	private static bool BGUPlayerLocomotionStartIdle_Owner_IsValid;

	private static int BGUPlayerLocomotionStartIdle_Owner_Offset;

	private static bool BGUSetCharacterMontagePlaying_IsValid;

	private static IntPtr BGUSetCharacterMontagePlaying_FunctionAddress;

	private static int BGUSetCharacterMontagePlaying_ParamsSize;

	private static bool BGUSetCharacterMontagePlaying_Owner_IsValid;

	private static int BGUSetCharacterMontagePlaying_Owner_Offset;

	private static bool BGUSetCharacterMontagePlaying_IsPlaying_IsValid;

	private static int BGUSetCharacterMontagePlaying_IsPlaying_Offset;

	private static FFieldAddress BGUSetCharacterMontagePlaying_IsPlaying_PropertyAddress;

	private static bool BGUMonsterLocomotionLockStopLeft_IsValid;

	private static IntPtr BGUMonsterLocomotionLockStopLeft_FunctionAddress;

	private static int BGUMonsterLocomotionLockStopLeft_ParamsSize;

	private static bool BGUMonsterLocomotionLockStopLeft_Owner_IsValid;

	private static int BGUMonsterLocomotionLockStopLeft_Owner_Offset;

	private static bool BGUMonsterLocomotionLockStopLeft_MonsterLocomotionAnimInst_IsValid;

	private static int BGUMonsterLocomotionLockStopLeft_MonsterLocomotionAnimInst_Offset;

	private static bool BGUMonsterLocomotionLockStopRight_IsValid;

	private static IntPtr BGUMonsterLocomotionLockStopRight_FunctionAddress;

	private static int BGUMonsterLocomotionLockStopRight_ParamsSize;

	private static bool BGUMonsterLocomotionLockStopRight_Owner_IsValid;

	private static int BGUMonsterLocomotionLockStopRight_Owner_Offset;

	private static bool BGUMonsterLocomotionLockStopRight_MonsterLocomotionAnimInst_IsValid;

	private static int BGUMonsterLocomotionLockStopRight_MonsterLocomotionAnimInst_Offset;

	private static bool BGUMonsterLocomotionEnterMoveLoop_IsValid;

	private static IntPtr BGUMonsterLocomotionEnterMoveLoop_FunctionAddress;

	private static int BGUMonsterLocomotionEnterMoveLoop_ParamsSize;

	private static bool BGUMonsterLocomotionEnterMoveLoop_Owner_IsValid;

	private static int BGUMonsterLocomotionEnterMoveLoop_Owner_Offset;

	private static bool BGUMonsterLocomotionEnterMoveLoop_MonsterLocomotionAnimInst_IsValid;

	private static int BGUMonsterLocomotionEnterMoveLoop_MonsterLocomotionAnimInst_Offset;

	private static bool BGUSetMonsterLocomotionLockMoveDir_IsValid;

	private static IntPtr BGUSetMonsterLocomotionLockMoveDir_FunctionAddress;

	private static int BGUSetMonsterLocomotionLockMoveDir_ParamsSize;

	private static bool BGUSetMonsterLocomotionLockMoveDir_Owner_IsValid;

	private static int BGUSetMonsterLocomotionLockMoveDir_Owner_Offset;

	private static bool BGUSetMonsterLocomotionLockMoveDir_MoveDir_IsValid;

	private static int BGUSetMonsterLocomotionLockMoveDir_MoveDir_Offset;

	private static FFieldAddress BGUSetMonsterLocomotionLockMoveDir_MoveDir_PropertyAddress;

	private static bool BGUPlayerLocomotionLockTurnStopDir_IsValid;

	private static IntPtr BGUPlayerLocomotionLockTurnStopDir_FunctionAddress;

	private static int BGUPlayerLocomotionLockTurnStopDir_ParamsSize;

	private static bool BGUPlayerLocomotionLockTurnStopDir_Owner_IsValid;

	private static int BGUPlayerLocomotionLockTurnStopDir_Owner_Offset;

	private static bool BGUPlayerLocomotionLockTurnStopDir_Direction_IsValid;

	private static int BGUPlayerLocomotionLockTurnStopDir_Direction_Offset;

	private static FFieldAddress BGUPlayerLocomotionLockTurnStopDir_Direction_PropertyAddress;

	private static bool BGUPlayerLocomotionEnterLockMoveState_IsValid;

	private static IntPtr BGUPlayerLocomotionEnterLockMoveState_FunctionAddress;

	private static int BGUPlayerLocomotionEnterLockMoveState_ParamsSize;

	private static bool BGUPlayerLocomotionEnterLockMoveState_Owner_IsValid;

	private static int BGUPlayerLocomotionEnterLockMoveState_Owner_Offset;

	private static bool BGUTryFindCPGIdleNodeWithoutResetGroup_IsValid;

	private static IntPtr BGUTryFindCPGIdleNodeWithoutResetGroup_FunctionAddress;

	private static int BGUTryFindCPGIdleNodeWithoutResetGroup_ParamsSize;

	private static bool BGUTryFindCPGIdleNodeWithoutResetGroup_CPG_IsValid;

	private static int BGUTryFindCPGIdleNodeWithoutResetGroup_CPG_Offset;

	private static bool BGUTryFindCPGIdleNodeWithoutResetGroup_TargetAction_IsValid;

	private static int BGUTryFindCPGIdleNodeWithoutResetGroup_TargetAction_Offset;

	private static FFieldAddress BGUTryFindCPGIdleNodeWithoutResetGroup_TargetAction_PropertyAddress;

	private static bool BGUTryFindCPGIdleNodeWithoutResetGroup_ReturnValue_IsValid;

	private static int BGUTryFindCPGIdleNodeWithoutResetGroup_ReturnValue_Offset;

	private static FFieldAddress BGUTryFindCPGIdleNodeWithoutResetGroup_ReturnValue_PropertyAddress;

	private static bool BGUSetPlayerLocomotionLockMoveDirection_IsValid;

	private static IntPtr BGUSetPlayerLocomotionLockMoveDirection_FunctionAddress;

	private static int BGUSetPlayerLocomotionLockMoveDirection_ParamsSize;

	private static bool BGUSetPlayerLocomotionLockMoveDirection_Owner_IsValid;

	private static int BGUSetPlayerLocomotionLockMoveDirection_Owner_Offset;

	private static bool BGUSetPlayerLocomotionLockMoveDirection_Direction_IsValid;

	private static int BGUSetPlayerLocomotionLockMoveDirection_Direction_Offset;

	private static FFieldAddress BGUSetPlayerLocomotionLockMoveDirection_Direction_PropertyAddress;

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Anim")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAnim:BGUPlayerLocomotionStartIdle")]
	public static void BGUPlayerLocomotionStartIdle(AActor Owner)
	{
		BUS_EventCollectionCS.Get(Owner)?.Evt_PlayerLocomotionStartIdle.Invoke();
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Anim")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAnim:BGUPlayerLocomotionLockTurnStopDir")]
	public static void BGUPlayerLocomotionLockTurnStopDir(AActor Owner, ELockMoveDirectionSix Direction)
	{
		BUS_EventCollectionCS.Get(Owner)?.Evt_SetPlayerLocomotionLockTurnStopDirection.Invoke(Direction);
	}

	[Category("BGU|Anim")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAnim:BGUPlayerLocomotionEnterLockMoveState")]
	public static void BGUPlayerLocomotionEnterLockMoveState(AActor Owner)
	{
		BUS_EventCollectionCS.Get(Owner)?.Evt_PlayerLocomotionEnterLockMoveState.Invoke();
	}

	[Category("BGU|Anim")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAnim:BGUSetPlayerLocomotionLockMoveDirection")]
	public static void BGUSetPlayerLocomotionLockMoveDirection(AActor Owner, ELockMoveDirectionSix Direction)
	{
		BUS_EventCollectionCS.Get(Owner)?.Evt_SetPlayerLocomotionLockMoveDirection.Invoke(Direction);
	}

	[BlueprintCallable]
	[UFunction]
	[Category("BGU|Anim")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAnim:BGUSetGlideMoveAnimState")]
	public static void BGUSetGlideMoveAnimState(AActor Owner, EGlideMoveAnimState State)
	{
		BUS_EventCollectionCS.Get(Owner)?.Evt_SetGlideMoveAnimState.Invoke(State);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Anim")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAnim:BGUSetParkourMoveAnimState")]
	public static void BGUSetParkourMoveAnimState(AActor Owner, EParkourMoveAnimState State)
	{
		BUS_EventCollectionCS.Get(Owner)?.Evt_SetParkourMoveAnimState.Invoke(State);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Anim")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAnim:BGUSetMonsterLocomotionLockMoveDir")]
	public static void BGUSetMonsterLocomotionLockMoveDir(AActor Owner, EMoveDirectionEight MoveDir)
	{
		BUS_EventCollectionCS.Get(Owner)?.Evt_SetMonsterLocomotionLockMoveDir.Invoke(MoveDir);
	}

	[Category("BGU|Anim")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAnim:BGUMonsterLocomotionLockStopLeft")]
	public static void BGUMonsterLocomotionLockStopLeft(AActor Owner, UAnimInstance MonsterLocomotionAnimInst)
	{
		if (!(Owner == null) && !(MonsterLocomotionAnimInst == null))
		{
			BUS_EventCollectionCS.Get(Owner)?.Evt_MonsterLocomotionLockStopLeft.Invoke(MonsterLocomotionAnimInst);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Anim")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAnim:BGUMonsterLocomotionLockStopRight")]
	public static void BGUMonsterLocomotionLockStopRight(AActor Owner, UAnimInstance MonsterLocomotionAnimInst)
	{
		if (!(Owner == null) && !(MonsterLocomotionAnimInst == null))
		{
			BUS_EventCollectionCS.Get(Owner)?.Evt_MonsterLocomotionLockStopRight.Invoke(MonsterLocomotionAnimInst);
		}
	}

	[Category("BGU|Anim")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAnim:BGUMonsterLocomotionEnterMoveLoop")]
	public static void BGUMonsterLocomotionEnterMoveLoop(AActor Owner, UAnimInstance MonsterLocomotionAnimInst)
	{
		if (!(Owner == null) && !(MonsterLocomotionAnimInst == null))
		{
			BUS_EventCollectionCS.Get(Owner)?.Evt_MonsterLocomotionEnterMoveLoop.Invoke(MonsterLocomotionAnimInst);
		}
	}

	[UFunction]
	[Category("BGU|Anim")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAnim:BGUSplineMoveEnterStopState")]
	public static void BGUSplineMoveEnterStopState(AActor Owner)
	{
		if (!(Owner == null))
		{
			BUS_EventCollectionCS.Get(Owner).Evt_SplineMoveEnterStopState.Invoke();
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Anim")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAnim:BGURootMotionJumpStart")]
	public static void BGURootMotionJumpStart(AActor Owner)
	{
		BUS_EventCollectionCS.Get(Owner)?.Evt_RootMotionJumpStart.Invoke();
	}

	[BlueprintCallable]
	[UFunction]
	[Category("BGU|Anim")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAnim:BGURootMotionJumpEnd")]
	public static void BGURootMotionJumpEnd(AActor Owner)
	{
		BUS_EventCollectionCS.Get(Owner)?.Evt_RootMotionJumpEnd.Invoke();
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Anim")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAnim:BGUSetUseSnapshotPose")]
	public static void BGUSetUseSnapshotPose(AActor Owner, bool bUseSnapshot, float BlendTime)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (!(aCharacter == null) && !(aCharacter.Mesh == null))
		{
			FPoseSnapshot Snapshot = default(FPoseSnapshot);
			if (bUseSnapshot)
			{
				aCharacter.Mesh.SnapshotPose(ref Snapshot);
			}
			BUS_EventCollectionCS.Get(aCharacter)?.Evt_OnToggleSnapshotPose.Invoke(bUseSnapshot, Snapshot, BlendTime);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Anim")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAnim:BGUSetCharacterMontagePlaying")]
	public static void BGUSetCharacterMontagePlaying(AActor Owner, bool IsPlaying)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (!(aCharacter == null) && !(aCharacter.Mesh == null))
		{
			UBUS_UtilComm.SafeSetCharacterMontagePlaying(aCharacter, IsPlaying);
			BUS_EventCollectionCS.Get(aCharacter)?.Evt_OnMontagePausePlaying.Invoke(!IsPlaying);
			BGS_EventCollectionCS.Get(aCharacter)?.Evt_BGS_OnPauseCameraShakeByActor.Invoke(aCharacter, !IsPlaying);
		}
	}

	[UFunction]
	[Category("BGU|Anim")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAnim:BGUTryFindCPGIdleNodeWithoutResetGroup")]
	public static bool BGUTryFindCPGIdleNodeWithoutResetGroup(BED_ProcessAsset CPG, EIdleProcessActionType TargetAction)
	{
		Dictionary<FCalliopeGuid, UCalliopeNode> nodes = CPG.GetNodes();
		bool result = false;
		foreach (KeyValuePair<FCalliopeGuid, UCalliopeNode> item in nodes)
		{
			BED_ProcessMachineNode_Idle bED_ProcessMachineNode_Idle = item.Value as BED_ProcessMachineNode_Idle;
			if (!(bED_ProcessMachineNode_Idle != null) || bED_ProcessMachineNode_Idle.ProcessActions.Count <= 0)
			{
				continue;
			}
			foreach (FIdleProcessAction processAction in bED_ProcessMachineNode_Idle.ProcessActions)
			{
				if (processAction.ActionType != TargetAction)
				{
					continue;
				}
				UCalliopeNode uCalliopeNode = bED_ProcessMachineNode_Idle;
				List<FCalliopeGuid> parentNodes = uCalliopeNode.GetParentNodes();
				FCalliopeGuid guid = uCalliopeNode.GetGuid();
				int count = parentNodes.Count;
				UCalliopeNode uCalliopeNode2 = bED_ProcessMachineNode_Idle;
				while (count == 1 && uCalliopeNode != null)
				{
					uCalliopeNode2 = uCalliopeNode;
					count = uCalliopeNode.GetParentNodes().Count;
					guid = uCalliopeNode.ParentNode.NodeGuid;
					uCalliopeNode = CPG.GetNode(guid);
				}
				FCalliopeGuid guid2 = uCalliopeNode2.GetGuid();
				uCalliopeNode2 = null;
				foreach (KeyValuePair<FCalliopeGuid, UCalliopeNode> item2 in nodes)
				{
					if (item2.Value != null && item2.Value.IsOutputConnectTo(guid2))
					{
						uCalliopeNode2 = item2.Value;
						break;
					}
				}
				if (!(uCalliopeNode2 is BED_ProcessMachineNode_GroupStart) && !(uCalliopeNode2 == null))
				{
					result = true;
				}
			}
		}
		return result;
	}

	public static void BGUGetAnimsNotifySoftPathSet(in List<UAnimSequenceBase> Anims, ref Dictionary<BAN_GSBase, HashSet<FSoftObjectPath>> NotifySoftPath, ref Dictionary<BANS_GSBase, HashSet<FSoftObjectPath>> NotifyStateSoftPath)
	{
		if (NotifySoftPath == null)
		{
			NotifySoftPath = new Dictionary<BAN_GSBase, HashSet<FSoftObjectPath>>();
		}
		if (NotifyStateSoftPath == null)
		{
			NotifyStateSoftPath = new Dictionary<BANS_GSBase, HashSet<FSoftObjectPath>>();
		}
		if (Anims.Count != 0)
		{
			List<FAnimNotifyEvent> AnimNotifyEventList = new List<FAnimNotifyEvent>();
			UGSE_AnimFuncLib.GetAnimAllNotifyEventIncludeAS(Anims, out AnimNotifyEventList);
			BGUGetNotifySoftPathSet(in AnimNotifyEventList, ref NotifySoftPath, ref NotifyStateSoftPath);
		}
	}

	public static void BGUGetOneAnimNotifySoftPathSet(UAnimSequenceBase AnimBase, ref Dictionary<BAN_GSBase, HashSet<FSoftObjectPath>> NotifySoftPath, ref Dictionary<BANS_GSBase, HashSet<FSoftObjectPath>> NotifyStateSoftPath)
	{
		if (NotifySoftPath == null)
		{
			NotifySoftPath = new Dictionary<BAN_GSBase, HashSet<FSoftObjectPath>>();
		}
		if (NotifyStateSoftPath == null)
		{
			NotifyStateSoftPath = new Dictionary<BANS_GSBase, HashSet<FSoftObjectPath>>();
		}
		if (!(AnimBase == null))
		{
			List<FAnimNotifyEvent> AnimNotifyEventList = new List<FAnimNotifyEvent>();
			UGSE_AnimFuncLib.GetOneAnimAllNotifyEventIncludeAS(AnimBase, out AnimNotifyEventList);
			BGUGetNotifySoftPathSet(in AnimNotifyEventList, ref NotifySoftPath, ref NotifyStateSoftPath);
		}
	}

	public static void BGUGetNotifySoftPathSet(in List<FAnimNotifyEvent> AllNotifyEvent, ref Dictionary<BAN_GSBase, HashSet<FSoftObjectPath>> NotifySoftPath, ref Dictionary<BANS_GSBase, HashSet<FSoftObjectPath>> NotifyStateSoftPath)
	{
		if (NotifySoftPath == null)
		{
			NotifySoftPath = new Dictionary<BAN_GSBase, HashSet<FSoftObjectPath>>();
		}
		if (NotifyStateSoftPath == null)
		{
			NotifyStateSoftPath = new Dictionary<BANS_GSBase, HashSet<FSoftObjectPath>>();
		}
		if (AllNotifyEvent == null || AllNotifyEvent.Count <= 0)
		{
			return;
		}
		foreach (FAnimNotifyEvent item in AllNotifyEvent)
		{
			if (item.Notify != null && item.Notify is BAN_GSBase bAN_GSBase)
			{
				if (!NotifySoftPath.TryGetValue(bAN_GSBase, out var value))
				{
					value = new HashSet<FSoftObjectPath>();
					NotifySoftPath.Add(bAN_GSBase, value);
				}
				bAN_GSBase.GetSoftReferencesCS(ref value);
				NotifySoftPath[bAN_GSBase] = value;
			}
			if (item.NotifyStateClass != null && item.NotifyStateClass is BANS_GSBase bANS_GSBase)
			{
				if (!NotifyStateSoftPath.TryGetValue(bANS_GSBase, out var value2))
				{
					value2 = new HashSet<FSoftObjectPath>();
					NotifyStateSoftPath.Add(bANS_GSBase, value2);
				}
				bANS_GSBase.GetSoftReferencesCS(ref value2);
				NotifyStateSoftPath[bANS_GSBase] = value2;
			}
		}
	}

	[BlueprintCallable]
	[Category("BGU|Anim")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAnim:BGUActorTryPlayMontage")]
	public static float BGUActorTryPlayMontage(AActor Owner, UAnimMontage Montage, FName StartSectionName, EMontageBindReason Reason = EMontageBindReason.Default, float Scale = 1f, float PlayTimeRate = 1f, float MontagePosOffset = 0f)
	{
		float result = 0f;
		ACharacter aCharacter = Owner as ACharacter;
		BGUInteractiveActorBase bGUInteractiveActorBase = Owner as BGUInteractiveActorBase;
		BGUPerformerActorCS bGUPerformerActorCS = Owner as BGUPerformerActorCS;
		if (aCharacter != null)
		{
			bool flag = false;
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Owner);
			if (Owner as BGUCharacterCS != null)
			{
				flag = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_MovementData, BUC_MovementData>(aCharacter) != null && bUS_GSEventCollection != null;
			}
			if (flag)
			{
				bUS_GSEventCollection.Evt_MoveWithAnimMontage.Invoke(Montage, Scale, PlayTimeRate, MontagePosOffset, StartSectionName, Reason);
				result = ((StartSectionName == FName.None) ? UBGUFunctionLibrary.BGUGetMontageSectionLengthByIndex(Owner, Montage, 0) : UBGUFunctionLibrary.BGUGetMontageSectionLengthByName(Owner, Montage, StartSectionName));
				return result * PlayTimeRate;
			}
			UAnimInstance animInstance = aCharacter.Mesh.GetAnimInstance();
			if (animInstance != null)
			{
				result = animInstance.Montage_Play(Montage, PlayTimeRate);
				if (MontagePosOffset != 0f)
				{
					animInstance.Montage_SetPosition(Montage, MontagePosOffset);
				}
				return result;
			}
			return 0f;
		}
		if (bGUInteractiveActorBase != null)
		{
			foreach (UActorComponent item in bGUInteractiveActorBase.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>()))
			{
				if (item.ComponentHasTag(B1GlobalFNames.master) && item is USkeletalMeshComponent uSkeletalMeshComponent)
				{
					UAnimInstance animInstance2 = uSkeletalMeshComponent.GetAnimInstance();
					if (animInstance2 != null)
					{
						result = animInstance2.Montage_Play(Montage, PlayTimeRate);
						if (MontagePosOffset != 0f)
						{
							animInstance2.Montage_SetPosition(Montage, MontagePosOffset);
						}
					}
				}
			}
			return result;
		}
		if (bGUPerformerActorCS != null)
		{
			UAnimInstance animInstance3 = bGUPerformerActorCS.Mesh.GetAnimInstance();
			if (animInstance3 != null)
			{
				result = animInstance3.Montage_Play(Montage, PlayTimeRate);
				if (MontagePosOffset != 0f)
				{
					animInstance3.Montage_SetPosition(Montage, MontagePosOffset);
				}
			}
		}
		return result;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAnim:BGURootMotionJumpEnd")]
	private static void BGURootMotionJumpEnd__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGURootMotionJumpEnd_Owner_Offset));
		BGURootMotionJumpEnd(owner);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAnim:BGUSetUseSnapshotPose")]
	private static void BGUSetUseSnapshotPose__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSetUseSnapshotPose_Owner_Offset));
		bool bUseSnapshot = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGUSetUseSnapshotPose_bUseSnapshot_Offset), 0, BGUSetUseSnapshotPose_bUseSnapshot_PropertyAddress.Address);
		float blendTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUSetUseSnapshotPose_BlendTime_Offset));
		BGUSetUseSnapshotPose(owner, bUseSnapshot, blendTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAnim:BGUActorTryPlayMontage")]
	private static void BGUActorTryPlayMontage__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUActorTryPlayMontage_Owner_Offset));
		UAnimMontage montage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, BGUActorTryPlayMontage_Montage_Offset));
		FName startSectionName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, BGUActorTryPlayMontage_StartSectionName_Offset));
		EMontageBindReason reason = EnumMarshaler<EMontageBindReason>.FromNative(IntPtr.Add(buffer, BGUActorTryPlayMontage_Reason_Offset), 0, BGUActorTryPlayMontage_Reason_PropertyAddress.Address);
		float scale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUActorTryPlayMontage_Scale_Offset));
		float playTimeRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUActorTryPlayMontage_PlayTimeRate_Offset));
		float montagePosOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUActorTryPlayMontage_MontagePosOffset_Offset));
		float value = BGUActorTryPlayMontage(owner, montage, startSectionName, reason, scale, playTimeRate, montagePosOffset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, BGUActorTryPlayMontage_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAnim:BGURootMotionJumpStart")]
	private static void BGURootMotionJumpStart__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGURootMotionJumpStart_Owner_Offset));
		BGURootMotionJumpStart(owner);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAnim:BGUSetGlideMoveAnimState")]
	private static void BGUSetGlideMoveAnimState__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSetGlideMoveAnimState_Owner_Offset));
		EGlideMoveAnimState state = EnumMarshaler<EGlideMoveAnimState>.FromNative(IntPtr.Add(buffer, BGUSetGlideMoveAnimState_State_Offset), 0, BGUSetGlideMoveAnimState_State_PropertyAddress.Address);
		BGUSetGlideMoveAnimState(owner, state);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAnim:BGUSetParkourMoveAnimState")]
	private static void BGUSetParkourMoveAnimState__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSetParkourMoveAnimState_Owner_Offset));
		EParkourMoveAnimState state = EnumMarshaler<EParkourMoveAnimState>.FromNative(IntPtr.Add(buffer, BGUSetParkourMoveAnimState_State_Offset), 0, BGUSetParkourMoveAnimState_State_PropertyAddress.Address);
		BGUSetParkourMoveAnimState(owner, state);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAnim:BGUSplineMoveEnterStopState")]
	private static void BGUSplineMoveEnterStopState__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSplineMoveEnterStopState_Owner_Offset));
		BGUSplineMoveEnterStopState(owner);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAnim:BGUPlayerLocomotionStartIdle")]
	private static void BGUPlayerLocomotionStartIdle__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUPlayerLocomotionStartIdle_Owner_Offset));
		BGUPlayerLocomotionStartIdle(owner);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAnim:BGUSetCharacterMontagePlaying")]
	private static void BGUSetCharacterMontagePlaying__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSetCharacterMontagePlaying_Owner_Offset));
		bool isPlaying = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGUSetCharacterMontagePlaying_IsPlaying_Offset), 0, BGUSetCharacterMontagePlaying_IsPlaying_PropertyAddress.Address);
		BGUSetCharacterMontagePlaying(owner, isPlaying);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAnim:BGUMonsterLocomotionLockStopLeft")]
	private static void BGUMonsterLocomotionLockStopLeft__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUMonsterLocomotionLockStopLeft_Owner_Offset));
		UAnimInstance monsterLocomotionAnimInst = UObjectMarshaler<UAnimInstance>.FromNative(IntPtr.Add(buffer, BGUMonsterLocomotionLockStopLeft_MonsterLocomotionAnimInst_Offset));
		BGUMonsterLocomotionLockStopLeft(owner, monsterLocomotionAnimInst);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAnim:BGUMonsterLocomotionLockStopRight")]
	private static void BGUMonsterLocomotionLockStopRight__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUMonsterLocomotionLockStopRight_Owner_Offset));
		UAnimInstance monsterLocomotionAnimInst = UObjectMarshaler<UAnimInstance>.FromNative(IntPtr.Add(buffer, BGUMonsterLocomotionLockStopRight_MonsterLocomotionAnimInst_Offset));
		BGUMonsterLocomotionLockStopRight(owner, monsterLocomotionAnimInst);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAnim:BGUMonsterLocomotionEnterMoveLoop")]
	private static void BGUMonsterLocomotionEnterMoveLoop__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUMonsterLocomotionEnterMoveLoop_Owner_Offset));
		UAnimInstance monsterLocomotionAnimInst = UObjectMarshaler<UAnimInstance>.FromNative(IntPtr.Add(buffer, BGUMonsterLocomotionEnterMoveLoop_MonsterLocomotionAnimInst_Offset));
		BGUMonsterLocomotionEnterMoveLoop(owner, monsterLocomotionAnimInst);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAnim:BGUSetMonsterLocomotionLockMoveDir")]
	private static void BGUSetMonsterLocomotionLockMoveDir__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSetMonsterLocomotionLockMoveDir_Owner_Offset));
		EMoveDirectionEight moveDir = EnumMarshaler<EMoveDirectionEight>.FromNative(IntPtr.Add(buffer, BGUSetMonsterLocomotionLockMoveDir_MoveDir_Offset), 0, BGUSetMonsterLocomotionLockMoveDir_MoveDir_PropertyAddress.Address);
		BGUSetMonsterLocomotionLockMoveDir(owner, moveDir);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAnim:BGUPlayerLocomotionLockTurnStopDir")]
	private static void BGUPlayerLocomotionLockTurnStopDir__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUPlayerLocomotionLockTurnStopDir_Owner_Offset));
		ELockMoveDirectionSix direction = EnumMarshaler<ELockMoveDirectionSix>.FromNative(IntPtr.Add(buffer, BGUPlayerLocomotionLockTurnStopDir_Direction_Offset), 0, BGUPlayerLocomotionLockTurnStopDir_Direction_PropertyAddress.Address);
		BGUPlayerLocomotionLockTurnStopDir(owner, direction);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAnim:BGUPlayerLocomotionEnterLockMoveState")]
	private static void BGUPlayerLocomotionEnterLockMoveState__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUPlayerLocomotionEnterLockMoveState_Owner_Offset));
		BGUPlayerLocomotionEnterLockMoveState(owner);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAnim:BGUTryFindCPGIdleNodeWithoutResetGroup")]
	private static void BGUTryFindCPGIdleNodeWithoutResetGroup__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessAsset cPG = UObjectMarshaler<BED_ProcessAsset>.FromNative(IntPtr.Add(buffer, BGUTryFindCPGIdleNodeWithoutResetGroup_CPG_Offset));
		EIdleProcessActionType targetAction = EnumMarshaler<EIdleProcessActionType>.FromNative(IntPtr.Add(buffer, BGUTryFindCPGIdleNodeWithoutResetGroup_TargetAction_Offset), 0, BGUTryFindCPGIdleNodeWithoutResetGroup_TargetAction_PropertyAddress.Address);
		bool value = BGUTryFindCPGIdleNodeWithoutResetGroup(cPG, targetAction);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, BGUTryFindCPGIdleNodeWithoutResetGroup_ReturnValue_Offset), 0, BGUTryFindCPGIdleNodeWithoutResetGroup_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAnim:BGUSetPlayerLocomotionLockMoveDirection")]
	private static void BGUSetPlayerLocomotionLockMoveDirection__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSetPlayerLocomotionLockMoveDirection_Owner_Offset));
		ELockMoveDirectionSix direction = EnumMarshaler<ELockMoveDirectionSix>.FromNative(IntPtr.Add(buffer, BGUSetPlayerLocomotionLockMoveDirection_Direction_Offset), 0, BGUSetPlayerLocomotionLockMoveDirection_Direction_PropertyAddress.Address);
		BGUSetPlayerLocomotionLockMoveDirection(owner, direction);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUFuncLibAnim");
		BGURootMotionJumpEnd_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGURootMotionJumpEnd");
		BGURootMotionJumpEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(BGURootMotionJumpEnd_FunctionAddress);
		BGURootMotionJumpEnd_Owner_Offset = NativeReflection.GetPropertyOffset(BGURootMotionJumpEnd_FunctionAddress, "Owner");
		BGURootMotionJumpEnd_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGURootMotionJumpEnd_FunctionAddress, "Owner", Classes.FObjectProperty);
		BGURootMotionJumpEnd_IsValid = BGURootMotionJumpEnd_FunctionAddress != IntPtr.Zero && BGURootMotionJumpEnd_Owner_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAnim:BGURootMotionJumpEnd", BGURootMotionJumpEnd_IsValid);
		BGUSetUseSnapshotPose_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetUseSnapshotPose");
		BGUSetUseSnapshotPose_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetUseSnapshotPose_FunctionAddress);
		BGUSetUseSnapshotPose_Owner_Offset = NativeReflection.GetPropertyOffset(BGUSetUseSnapshotPose_FunctionAddress, "Owner");
		BGUSetUseSnapshotPose_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUSetUseSnapshotPose_FunctionAddress, "Owner", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUSetUseSnapshotPose_bUseSnapshot_PropertyAddress, BGUSetUseSnapshotPose_FunctionAddress, "bUseSnapshot");
		BGUSetUseSnapshotPose_bUseSnapshot_Offset = NativeReflection.GetPropertyOffset(BGUSetUseSnapshotPose_FunctionAddress, "bUseSnapshot");
		BGUSetUseSnapshotPose_bUseSnapshot_IsValid = NativeReflection.ValidatePropertyClass(BGUSetUseSnapshotPose_FunctionAddress, "bUseSnapshot", Classes.FBoolProperty);
		BGUSetUseSnapshotPose_BlendTime_Offset = NativeReflection.GetPropertyOffset(BGUSetUseSnapshotPose_FunctionAddress, "BlendTime");
		BGUSetUseSnapshotPose_BlendTime_IsValid = NativeReflection.ValidatePropertyClass(BGUSetUseSnapshotPose_FunctionAddress, "BlendTime", Classes.FFloatProperty);
		BGUSetUseSnapshotPose_IsValid = BGUSetUseSnapshotPose_FunctionAddress != IntPtr.Zero && BGUSetUseSnapshotPose_Owner_IsValid && BGUSetUseSnapshotPose_bUseSnapshot_IsValid && BGUSetUseSnapshotPose_BlendTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAnim:BGUSetUseSnapshotPose", BGUSetUseSnapshotPose_IsValid);
		BGUActorTryPlayMontage_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUActorTryPlayMontage");
		BGUActorTryPlayMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUActorTryPlayMontage_FunctionAddress);
		BGUActorTryPlayMontage_Owner_Offset = NativeReflection.GetPropertyOffset(BGUActorTryPlayMontage_FunctionAddress, "Owner");
		BGUActorTryPlayMontage_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUActorTryPlayMontage_FunctionAddress, "Owner", Classes.FObjectProperty);
		BGUActorTryPlayMontage_Montage_Offset = NativeReflection.GetPropertyOffset(BGUActorTryPlayMontage_FunctionAddress, "Montage");
		BGUActorTryPlayMontage_Montage_IsValid = NativeReflection.ValidatePropertyClass(BGUActorTryPlayMontage_FunctionAddress, "Montage", Classes.FObjectProperty);
		BGUActorTryPlayMontage_StartSectionName_Offset = NativeReflection.GetPropertyOffset(BGUActorTryPlayMontage_FunctionAddress, "StartSectionName");
		BGUActorTryPlayMontage_StartSectionName_IsValid = NativeReflection.ValidatePropertyClass(BGUActorTryPlayMontage_FunctionAddress, "StartSectionName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref BGUActorTryPlayMontage_Reason_PropertyAddress, BGUActorTryPlayMontage_FunctionAddress, "Reason");
		BGUActorTryPlayMontage_Reason_Offset = NativeReflection.GetPropertyOffset(BGUActorTryPlayMontage_FunctionAddress, "Reason");
		BGUActorTryPlayMontage_Reason_IsValid = NativeReflection.ValidatePropertyClass(BGUActorTryPlayMontage_FunctionAddress, "Reason", Classes.FEnumProperty);
		BGUActorTryPlayMontage_Scale_Offset = NativeReflection.GetPropertyOffset(BGUActorTryPlayMontage_FunctionAddress, "Scale");
		BGUActorTryPlayMontage_Scale_IsValid = NativeReflection.ValidatePropertyClass(BGUActorTryPlayMontage_FunctionAddress, "Scale", Classes.FFloatProperty);
		BGUActorTryPlayMontage_PlayTimeRate_Offset = NativeReflection.GetPropertyOffset(BGUActorTryPlayMontage_FunctionAddress, "PlayTimeRate");
		BGUActorTryPlayMontage_PlayTimeRate_IsValid = NativeReflection.ValidatePropertyClass(BGUActorTryPlayMontage_FunctionAddress, "PlayTimeRate", Classes.FFloatProperty);
		BGUActorTryPlayMontage_MontagePosOffset_Offset = NativeReflection.GetPropertyOffset(BGUActorTryPlayMontage_FunctionAddress, "MontagePosOffset");
		BGUActorTryPlayMontage_MontagePosOffset_IsValid = NativeReflection.ValidatePropertyClass(BGUActorTryPlayMontage_FunctionAddress, "MontagePosOffset", Classes.FFloatProperty);
		BGUActorTryPlayMontage_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUActorTryPlayMontage_FunctionAddress, "ReturnValue");
		BGUActorTryPlayMontage_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUActorTryPlayMontage_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BGUActorTryPlayMontage_IsValid = BGUActorTryPlayMontage_FunctionAddress != IntPtr.Zero && BGUActorTryPlayMontage_Owner_IsValid && BGUActorTryPlayMontage_Montage_IsValid && BGUActorTryPlayMontage_StartSectionName_IsValid && BGUActorTryPlayMontage_Reason_IsValid && BGUActorTryPlayMontage_Scale_IsValid && BGUActorTryPlayMontage_PlayTimeRate_IsValid && BGUActorTryPlayMontage_MontagePosOffset_IsValid && BGUActorTryPlayMontage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAnim:BGUActorTryPlayMontage", BGUActorTryPlayMontage_IsValid);
		BGURootMotionJumpStart_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGURootMotionJumpStart");
		BGURootMotionJumpStart_ParamsSize = NativeReflection.GetFunctionParamsSize(BGURootMotionJumpStart_FunctionAddress);
		BGURootMotionJumpStart_Owner_Offset = NativeReflection.GetPropertyOffset(BGURootMotionJumpStart_FunctionAddress, "Owner");
		BGURootMotionJumpStart_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGURootMotionJumpStart_FunctionAddress, "Owner", Classes.FObjectProperty);
		BGURootMotionJumpStart_IsValid = BGURootMotionJumpStart_FunctionAddress != IntPtr.Zero && BGURootMotionJumpStart_Owner_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAnim:BGURootMotionJumpStart", BGURootMotionJumpStart_IsValid);
		BGUSetGlideMoveAnimState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetGlideMoveAnimState");
		BGUSetGlideMoveAnimState_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetGlideMoveAnimState_FunctionAddress);
		BGUSetGlideMoveAnimState_Owner_Offset = NativeReflection.GetPropertyOffset(BGUSetGlideMoveAnimState_FunctionAddress, "Owner");
		BGUSetGlideMoveAnimState_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUSetGlideMoveAnimState_FunctionAddress, "Owner", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUSetGlideMoveAnimState_State_PropertyAddress, BGUSetGlideMoveAnimState_FunctionAddress, "State");
		BGUSetGlideMoveAnimState_State_Offset = NativeReflection.GetPropertyOffset(BGUSetGlideMoveAnimState_FunctionAddress, "State");
		BGUSetGlideMoveAnimState_State_IsValid = NativeReflection.ValidatePropertyClass(BGUSetGlideMoveAnimState_FunctionAddress, "State", Classes.FEnumProperty);
		BGUSetGlideMoveAnimState_IsValid = BGUSetGlideMoveAnimState_FunctionAddress != IntPtr.Zero && BGUSetGlideMoveAnimState_Owner_IsValid && BGUSetGlideMoveAnimState_State_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAnim:BGUSetGlideMoveAnimState", BGUSetGlideMoveAnimState_IsValid);
		BGUSetParkourMoveAnimState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetParkourMoveAnimState");
		BGUSetParkourMoveAnimState_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetParkourMoveAnimState_FunctionAddress);
		BGUSetParkourMoveAnimState_Owner_Offset = NativeReflection.GetPropertyOffset(BGUSetParkourMoveAnimState_FunctionAddress, "Owner");
		BGUSetParkourMoveAnimState_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUSetParkourMoveAnimState_FunctionAddress, "Owner", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUSetParkourMoveAnimState_State_PropertyAddress, BGUSetParkourMoveAnimState_FunctionAddress, "State");
		BGUSetParkourMoveAnimState_State_Offset = NativeReflection.GetPropertyOffset(BGUSetParkourMoveAnimState_FunctionAddress, "State");
		BGUSetParkourMoveAnimState_State_IsValid = NativeReflection.ValidatePropertyClass(BGUSetParkourMoveAnimState_FunctionAddress, "State", Classes.FEnumProperty);
		BGUSetParkourMoveAnimState_IsValid = BGUSetParkourMoveAnimState_FunctionAddress != IntPtr.Zero && BGUSetParkourMoveAnimState_Owner_IsValid && BGUSetParkourMoveAnimState_State_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAnim:BGUSetParkourMoveAnimState", BGUSetParkourMoveAnimState_IsValid);
		BGUSplineMoveEnterStopState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSplineMoveEnterStopState");
		BGUSplineMoveEnterStopState_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSplineMoveEnterStopState_FunctionAddress);
		BGUSplineMoveEnterStopState_Owner_Offset = NativeReflection.GetPropertyOffset(BGUSplineMoveEnterStopState_FunctionAddress, "Owner");
		BGUSplineMoveEnterStopState_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUSplineMoveEnterStopState_FunctionAddress, "Owner", Classes.FObjectProperty);
		BGUSplineMoveEnterStopState_IsValid = BGUSplineMoveEnterStopState_FunctionAddress != IntPtr.Zero && BGUSplineMoveEnterStopState_Owner_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAnim:BGUSplineMoveEnterStopState", BGUSplineMoveEnterStopState_IsValid);
		BGUPlayerLocomotionStartIdle_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUPlayerLocomotionStartIdle");
		BGUPlayerLocomotionStartIdle_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUPlayerLocomotionStartIdle_FunctionAddress);
		BGUPlayerLocomotionStartIdle_Owner_Offset = NativeReflection.GetPropertyOffset(BGUPlayerLocomotionStartIdle_FunctionAddress, "Owner");
		BGUPlayerLocomotionStartIdle_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUPlayerLocomotionStartIdle_FunctionAddress, "Owner", Classes.FObjectProperty);
		BGUPlayerLocomotionStartIdle_IsValid = BGUPlayerLocomotionStartIdle_FunctionAddress != IntPtr.Zero && BGUPlayerLocomotionStartIdle_Owner_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAnim:BGUPlayerLocomotionStartIdle", BGUPlayerLocomotionStartIdle_IsValid);
		BGUSetCharacterMontagePlaying_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetCharacterMontagePlaying");
		BGUSetCharacterMontagePlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetCharacterMontagePlaying_FunctionAddress);
		BGUSetCharacterMontagePlaying_Owner_Offset = NativeReflection.GetPropertyOffset(BGUSetCharacterMontagePlaying_FunctionAddress, "Owner");
		BGUSetCharacterMontagePlaying_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUSetCharacterMontagePlaying_FunctionAddress, "Owner", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUSetCharacterMontagePlaying_IsPlaying_PropertyAddress, BGUSetCharacterMontagePlaying_FunctionAddress, "IsPlaying");
		BGUSetCharacterMontagePlaying_IsPlaying_Offset = NativeReflection.GetPropertyOffset(BGUSetCharacterMontagePlaying_FunctionAddress, "IsPlaying");
		BGUSetCharacterMontagePlaying_IsPlaying_IsValid = NativeReflection.ValidatePropertyClass(BGUSetCharacterMontagePlaying_FunctionAddress, "IsPlaying", Classes.FBoolProperty);
		BGUSetCharacterMontagePlaying_IsValid = BGUSetCharacterMontagePlaying_FunctionAddress != IntPtr.Zero && BGUSetCharacterMontagePlaying_Owner_IsValid && BGUSetCharacterMontagePlaying_IsPlaying_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAnim:BGUSetCharacterMontagePlaying", BGUSetCharacterMontagePlaying_IsValid);
		BGUMonsterLocomotionLockStopLeft_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUMonsterLocomotionLockStopLeft");
		BGUMonsterLocomotionLockStopLeft_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUMonsterLocomotionLockStopLeft_FunctionAddress);
		BGUMonsterLocomotionLockStopLeft_Owner_Offset = NativeReflection.GetPropertyOffset(BGUMonsterLocomotionLockStopLeft_FunctionAddress, "Owner");
		BGUMonsterLocomotionLockStopLeft_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUMonsterLocomotionLockStopLeft_FunctionAddress, "Owner", Classes.FObjectProperty);
		BGUMonsterLocomotionLockStopLeft_MonsterLocomotionAnimInst_Offset = NativeReflection.GetPropertyOffset(BGUMonsterLocomotionLockStopLeft_FunctionAddress, "MonsterLocomotionAnimInst");
		BGUMonsterLocomotionLockStopLeft_MonsterLocomotionAnimInst_IsValid = NativeReflection.ValidatePropertyClass(BGUMonsterLocomotionLockStopLeft_FunctionAddress, "MonsterLocomotionAnimInst", Classes.FObjectProperty);
		BGUMonsterLocomotionLockStopLeft_IsValid = BGUMonsterLocomotionLockStopLeft_FunctionAddress != IntPtr.Zero && BGUMonsterLocomotionLockStopLeft_Owner_IsValid && BGUMonsterLocomotionLockStopLeft_MonsterLocomotionAnimInst_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAnim:BGUMonsterLocomotionLockStopLeft", BGUMonsterLocomotionLockStopLeft_IsValid);
		BGUMonsterLocomotionLockStopRight_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUMonsterLocomotionLockStopRight");
		BGUMonsterLocomotionLockStopRight_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUMonsterLocomotionLockStopRight_FunctionAddress);
		BGUMonsterLocomotionLockStopRight_Owner_Offset = NativeReflection.GetPropertyOffset(BGUMonsterLocomotionLockStopRight_FunctionAddress, "Owner");
		BGUMonsterLocomotionLockStopRight_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUMonsterLocomotionLockStopRight_FunctionAddress, "Owner", Classes.FObjectProperty);
		BGUMonsterLocomotionLockStopRight_MonsterLocomotionAnimInst_Offset = NativeReflection.GetPropertyOffset(BGUMonsterLocomotionLockStopRight_FunctionAddress, "MonsterLocomotionAnimInst");
		BGUMonsterLocomotionLockStopRight_MonsterLocomotionAnimInst_IsValid = NativeReflection.ValidatePropertyClass(BGUMonsterLocomotionLockStopRight_FunctionAddress, "MonsterLocomotionAnimInst", Classes.FObjectProperty);
		BGUMonsterLocomotionLockStopRight_IsValid = BGUMonsterLocomotionLockStopRight_FunctionAddress != IntPtr.Zero && BGUMonsterLocomotionLockStopRight_Owner_IsValid && BGUMonsterLocomotionLockStopRight_MonsterLocomotionAnimInst_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAnim:BGUMonsterLocomotionLockStopRight", BGUMonsterLocomotionLockStopRight_IsValid);
		BGUMonsterLocomotionEnterMoveLoop_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUMonsterLocomotionEnterMoveLoop");
		BGUMonsterLocomotionEnterMoveLoop_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUMonsterLocomotionEnterMoveLoop_FunctionAddress);
		BGUMonsterLocomotionEnterMoveLoop_Owner_Offset = NativeReflection.GetPropertyOffset(BGUMonsterLocomotionEnterMoveLoop_FunctionAddress, "Owner");
		BGUMonsterLocomotionEnterMoveLoop_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUMonsterLocomotionEnterMoveLoop_FunctionAddress, "Owner", Classes.FObjectProperty);
		BGUMonsterLocomotionEnterMoveLoop_MonsterLocomotionAnimInst_Offset = NativeReflection.GetPropertyOffset(BGUMonsterLocomotionEnterMoveLoop_FunctionAddress, "MonsterLocomotionAnimInst");
		BGUMonsterLocomotionEnterMoveLoop_MonsterLocomotionAnimInst_IsValid = NativeReflection.ValidatePropertyClass(BGUMonsterLocomotionEnterMoveLoop_FunctionAddress, "MonsterLocomotionAnimInst", Classes.FObjectProperty);
		BGUMonsterLocomotionEnterMoveLoop_IsValid = BGUMonsterLocomotionEnterMoveLoop_FunctionAddress != IntPtr.Zero && BGUMonsterLocomotionEnterMoveLoop_Owner_IsValid && BGUMonsterLocomotionEnterMoveLoop_MonsterLocomotionAnimInst_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAnim:BGUMonsterLocomotionEnterMoveLoop", BGUMonsterLocomotionEnterMoveLoop_IsValid);
		BGUSetMonsterLocomotionLockMoveDir_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetMonsterLocomotionLockMoveDir");
		BGUSetMonsterLocomotionLockMoveDir_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetMonsterLocomotionLockMoveDir_FunctionAddress);
		BGUSetMonsterLocomotionLockMoveDir_Owner_Offset = NativeReflection.GetPropertyOffset(BGUSetMonsterLocomotionLockMoveDir_FunctionAddress, "Owner");
		BGUSetMonsterLocomotionLockMoveDir_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUSetMonsterLocomotionLockMoveDir_FunctionAddress, "Owner", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUSetMonsterLocomotionLockMoveDir_MoveDir_PropertyAddress, BGUSetMonsterLocomotionLockMoveDir_FunctionAddress, "MoveDir");
		BGUSetMonsterLocomotionLockMoveDir_MoveDir_Offset = NativeReflection.GetPropertyOffset(BGUSetMonsterLocomotionLockMoveDir_FunctionAddress, "MoveDir");
		BGUSetMonsterLocomotionLockMoveDir_MoveDir_IsValid = NativeReflection.ValidatePropertyClass(BGUSetMonsterLocomotionLockMoveDir_FunctionAddress, "MoveDir", Classes.FEnumProperty);
		BGUSetMonsterLocomotionLockMoveDir_IsValid = BGUSetMonsterLocomotionLockMoveDir_FunctionAddress != IntPtr.Zero && BGUSetMonsterLocomotionLockMoveDir_Owner_IsValid && BGUSetMonsterLocomotionLockMoveDir_MoveDir_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAnim:BGUSetMonsterLocomotionLockMoveDir", BGUSetMonsterLocomotionLockMoveDir_IsValid);
		BGUPlayerLocomotionLockTurnStopDir_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUPlayerLocomotionLockTurnStopDir");
		BGUPlayerLocomotionLockTurnStopDir_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUPlayerLocomotionLockTurnStopDir_FunctionAddress);
		BGUPlayerLocomotionLockTurnStopDir_Owner_Offset = NativeReflection.GetPropertyOffset(BGUPlayerLocomotionLockTurnStopDir_FunctionAddress, "Owner");
		BGUPlayerLocomotionLockTurnStopDir_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUPlayerLocomotionLockTurnStopDir_FunctionAddress, "Owner", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUPlayerLocomotionLockTurnStopDir_Direction_PropertyAddress, BGUPlayerLocomotionLockTurnStopDir_FunctionAddress, "Direction");
		BGUPlayerLocomotionLockTurnStopDir_Direction_Offset = NativeReflection.GetPropertyOffset(BGUPlayerLocomotionLockTurnStopDir_FunctionAddress, "Direction");
		BGUPlayerLocomotionLockTurnStopDir_Direction_IsValid = NativeReflection.ValidatePropertyClass(BGUPlayerLocomotionLockTurnStopDir_FunctionAddress, "Direction", Classes.FEnumProperty);
		BGUPlayerLocomotionLockTurnStopDir_IsValid = BGUPlayerLocomotionLockTurnStopDir_FunctionAddress != IntPtr.Zero && BGUPlayerLocomotionLockTurnStopDir_Owner_IsValid && BGUPlayerLocomotionLockTurnStopDir_Direction_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAnim:BGUPlayerLocomotionLockTurnStopDir", BGUPlayerLocomotionLockTurnStopDir_IsValid);
		BGUPlayerLocomotionEnterLockMoveState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUPlayerLocomotionEnterLockMoveState");
		BGUPlayerLocomotionEnterLockMoveState_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUPlayerLocomotionEnterLockMoveState_FunctionAddress);
		BGUPlayerLocomotionEnterLockMoveState_Owner_Offset = NativeReflection.GetPropertyOffset(BGUPlayerLocomotionEnterLockMoveState_FunctionAddress, "Owner");
		BGUPlayerLocomotionEnterLockMoveState_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUPlayerLocomotionEnterLockMoveState_FunctionAddress, "Owner", Classes.FObjectProperty);
		BGUPlayerLocomotionEnterLockMoveState_IsValid = BGUPlayerLocomotionEnterLockMoveState_FunctionAddress != IntPtr.Zero && BGUPlayerLocomotionEnterLockMoveState_Owner_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAnim:BGUPlayerLocomotionEnterLockMoveState", BGUPlayerLocomotionEnterLockMoveState_IsValid);
		BGUTryFindCPGIdleNodeWithoutResetGroup_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUTryFindCPGIdleNodeWithoutResetGroup");
		BGUTryFindCPGIdleNodeWithoutResetGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUTryFindCPGIdleNodeWithoutResetGroup_FunctionAddress);
		BGUTryFindCPGIdleNodeWithoutResetGroup_CPG_Offset = NativeReflection.GetPropertyOffset(BGUTryFindCPGIdleNodeWithoutResetGroup_FunctionAddress, "CPG");
		BGUTryFindCPGIdleNodeWithoutResetGroup_CPG_IsValid = NativeReflection.ValidatePropertyClass(BGUTryFindCPGIdleNodeWithoutResetGroup_FunctionAddress, "CPG", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUTryFindCPGIdleNodeWithoutResetGroup_TargetAction_PropertyAddress, BGUTryFindCPGIdleNodeWithoutResetGroup_FunctionAddress, "TargetAction");
		BGUTryFindCPGIdleNodeWithoutResetGroup_TargetAction_Offset = NativeReflection.GetPropertyOffset(BGUTryFindCPGIdleNodeWithoutResetGroup_FunctionAddress, "TargetAction");
		BGUTryFindCPGIdleNodeWithoutResetGroup_TargetAction_IsValid = NativeReflection.ValidatePropertyClass(BGUTryFindCPGIdleNodeWithoutResetGroup_FunctionAddress, "TargetAction", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref BGUTryFindCPGIdleNodeWithoutResetGroup_ReturnValue_PropertyAddress, BGUTryFindCPGIdleNodeWithoutResetGroup_FunctionAddress, "ReturnValue");
		BGUTryFindCPGIdleNodeWithoutResetGroup_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUTryFindCPGIdleNodeWithoutResetGroup_FunctionAddress, "ReturnValue");
		BGUTryFindCPGIdleNodeWithoutResetGroup_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUTryFindCPGIdleNodeWithoutResetGroup_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUTryFindCPGIdleNodeWithoutResetGroup_IsValid = BGUTryFindCPGIdleNodeWithoutResetGroup_FunctionAddress != IntPtr.Zero && BGUTryFindCPGIdleNodeWithoutResetGroup_CPG_IsValid && BGUTryFindCPGIdleNodeWithoutResetGroup_TargetAction_IsValid && BGUTryFindCPGIdleNodeWithoutResetGroup_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAnim:BGUTryFindCPGIdleNodeWithoutResetGroup", BGUTryFindCPGIdleNodeWithoutResetGroup_IsValid);
		BGUSetPlayerLocomotionLockMoveDirection_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetPlayerLocomotionLockMoveDirection");
		BGUSetPlayerLocomotionLockMoveDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetPlayerLocomotionLockMoveDirection_FunctionAddress);
		BGUSetPlayerLocomotionLockMoveDirection_Owner_Offset = NativeReflection.GetPropertyOffset(BGUSetPlayerLocomotionLockMoveDirection_FunctionAddress, "Owner");
		BGUSetPlayerLocomotionLockMoveDirection_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUSetPlayerLocomotionLockMoveDirection_FunctionAddress, "Owner", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUSetPlayerLocomotionLockMoveDirection_Direction_PropertyAddress, BGUSetPlayerLocomotionLockMoveDirection_FunctionAddress, "Direction");
		BGUSetPlayerLocomotionLockMoveDirection_Direction_Offset = NativeReflection.GetPropertyOffset(BGUSetPlayerLocomotionLockMoveDirection_FunctionAddress, "Direction");
		BGUSetPlayerLocomotionLockMoveDirection_Direction_IsValid = NativeReflection.ValidatePropertyClass(BGUSetPlayerLocomotionLockMoveDirection_FunctionAddress, "Direction", Classes.FEnumProperty);
		BGUSetPlayerLocomotionLockMoveDirection_IsValid = BGUSetPlayerLocomotionLockMoveDirection_FunctionAddress != IntPtr.Zero && BGUSetPlayerLocomotionLockMoveDirection_Owner_IsValid && BGUSetPlayerLocomotionLockMoveDirection_Direction_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAnim:BGUSetPlayerLocomotionLockMoveDirection", BGUSetPlayerLocomotionLockMoveDirection_IsValid);
	}

	static BGUFuncLibAnim()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFuncLibAnim)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFuncLibAnim));
	}
}
