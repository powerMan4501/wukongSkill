using System;
using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.ECS;
using b1.EventDelDefine;
using b1.Localization;
using b1.Plugins.AkAudio;
using BtlB1;
using BtlShare;
using CommB1;
using CsB1;
using ResB1;
using UnrealEngine.CinematicCamera;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1;

public class BUS_InteractCompImpl : BUS_QuestCompBase
{
	private USkeletalMeshComponent MasterMesh;

	public USceneComponent InteractSock;

	public USceneComponent InteractRangeAnchor;

	private BIC_PersistentECSData PersistentECSData;

	private IBUC_TickRateData TickRateData;

	private BUC_InteractData InteractData;

	private APlayerController PlayerController;

	private IBUC_UnitStateData UnitStateData;

	private TStrongObjectPtr<USceneComponent> _AvailableFXCom = new TStrongObjectPtr<USceneComponent>();

	private TStrongObjectPtr<USceneComponent> _DisabledFxCom = new TStrongObjectPtr<USceneComponent>();

	private Dictionary<UMeshComponent, ECollisionEnabled> SubMeshCompCollisionCache;

	private IBIC_LevelData LevelData { get; set; }

	private USceneComponent AvailableFXCom
	{
		get
		{
			return _AvailableFXCom.Get();
		}
		set
		{
			_AvailableFXCom.Set(value);
		}
	}

	private USceneComponent DisabledFxCom
	{
		get
		{
			return _DisabledFxCom.Get();
		}
		set
		{
			_DisabledFxCom.Set(value);
		}
	}

	public override void OnAttach()
	{
		base.OnAttach();
		PersistentECSData = RequireReadonlyGameInstanceData<BIC_PersistentECSData, BIC_PersistentECSData>();
		LevelData = RequireReadonlyGameInstanceData<IBIC_LevelData, BIC_LevelData>();
		InteractData = RequireWritableData<BUC_InteractData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		base.BUSEventCollection.Evt_CallBPFunc += new Del_Void(OnCallBPFunc);
		base.BUSEventCollection.Evt_SetInteractActiveState += new Del_Void_Bool(OnSetInteractTarget);
		base.BUSEventCollection.Evt_TriggerPreInteract += new Del_Void_Actor(OnTriggerPreInteract);
		base.BUSEventCollection.Evt_TriggerPreInteractForAiInteract += new Del_Void_Actor(OnTriggerPreInteractForAiInteract);
		base.BUSEventCollection.Evt_TriggerInteractRollback += new Del_Void(OnTriggerInteractRollback);
		base.BUSEventCollection.Evt_TriggerBeInteract += new Del_TriggerBeInteract(OnTriggerBeInteract);
		base.BUSEventCollection.Evt_TriggerBreakInteract += new Del_Void_Actor(OnTriggerBreakInteract);
		base.BUSEventCollection.Evt_TriggerFinishInteract += new Del_Void_Actor(OnTriggerFinishInteract);
		base.BUSEventCollection.Evt_InteractGroup_Update += new Del_UpdateInteractGroup(UpdateInteractGroup);
		base.BUSEventCollection.Evt_InteractState_Update += new Del_UpdateInteractState(UpdateInteractState);
		base.BUSEventCollection.Evt_SwitchNoInteraction += new Del_Void_Bool(SwitchNoInteraction);
		base.BUSEventCollection.Evt_SwitchNoInteraction_Local += new Del_Void_Bool(SwitchNoInteraction);
		base.BGSEventCollection.Evt_BGS_UnitDead += new Del_Void_StringDeadReason(OnUnitDead);
		base.BGSEventCollection.Evt_InteractGroup_Refresh += new Del_Void(UpdateActionInGroup);
	}

	public override void PreBeginPlay()
	{
		if (InteractData.InteractiveUnitID == 0)
		{
			return;
		}
		InitSceneCompTransform();
		InitSubMeshCompCollisionCache();
		EBGUInteractUnitState interactUnitState = EBGUInteractUnitState.Default;
		InteractData.InteractiveUnitCommDesc = BGW_GameDB.GetInteractiveUnitCommDesc(InteractData.InteractiveUnitID);
		InteractData.DefalutInteractiveGroupID = InteractData.InteractiveUnitCommDesc.DefaultTask;
		if (PersistentECSData.FindBUCDataByGuid(base.GuidData.GetFinalGuid(), LevelData.CurrentLevelID, out var Ret) && Ret.BUCInteractData != null && Ret.BUCInteractData.HasActionGroupIDPersistent)
		{
			InteractData.DefalutInteractiveGroupID = Ret.BUCInteractData.ActionGroupIDPersistent;
			if (Ret.BUCInteractData.HasInteractUnitStatePersistent)
			{
				interactUnitState = (EBGUInteractUnitState)Ret.BUCInteractData.InteractUnitStatePersistent;
			}
		}
		else if (InteractData.InstOverrideInteractiveGroupID >= 0)
		{
			InteractData.DefalutInteractiveGroupID = InteractData.InstOverrideInteractiveGroupID;
		}
		if (DebugConfig.EnablePlaneMoveMode)
		{
			interactUnitState = EBGUInteractUnitState.AfterInactive;
		}
		UpdateInteractGroup_Internal(InteractData.DefalutInteractiveGroupID, interactUnitState);
		InteractData.TrueActivableDistance = ((InteractData.InstOverrideActivableDistance <= 0f) ? InteractData.InteractiveUnitCommDesc.ActivableDistance : InteractData.InstOverrideActivableDistance);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		if (InteractData.InteractiveUnitID == 0)
		{
			return;
		}
		InteractData.CanInteractPlayerEntity = Entity.Null;
		InteractData.InteractingPlayerEntity = Entity.Null;
		InteractData.TriggerInteractPlayerEntity = Entity.Null;
		InteractData.RemainingInteractTime = -1f;
		InteractData.InteractUIState = EInteractUIState.Invisiable;
		InteractData.bSpecialIcon = true;
		InteractRangeAnchor = base.Owner.RootComponent;
		List<UActorComponent> componentsByClass = base.Owner.GetComponentsByClass(UClass.GetClass<UActorComponent>());
		if (componentsByClass.Count > 0)
		{
			foreach (UActorComponent item in componentsByClass)
			{
				if (InteractSock == null && item.IsA<USceneComponent>() && item.ComponentHasTag(B1GlobalFNames.GSInteractSock))
				{
					InteractSock = item as USceneComponent;
					InteractData.bSpecialIcon = false;
				}
				if (item.IsA<USceneComponent>() && InteractData.InteractAnchorOverride != FName.None && item.ComponentHasTag(InteractData.InteractAnchorOverride))
				{
					InteractRangeAnchor = item as USceneComponent;
				}
				if (MasterMesh == null && item.IsA<USkeletalMeshComponent>() && item.ComponentHasTag(B1GlobalFNames.master))
				{
					MasterMesh = item as USkeletalMeshComponent;
				}
				if (item.GetFName() == B1GlobalFNames.InteractiveObjFxAvailable)
				{
					AvailableFXCom = item as USceneComponent;
				}
				else if (item.GetFName() == B1GlobalFNames.InteractiveObjFxDisable)
				{
					DisabledFxCom = item as USceneComponent;
				}
				if (item.IsA<UCameraComponent>() || item.IsA<UCineCameraComponent>())
				{
					UCameraComponent obj = item as UCameraComponent;
					CheckInteractCameraFov(item);
					for (int i = 0; i < item.ComponentTags.Count; i++)
					{
						string key = item.ComponentTags[i].ToString();
						if (!InteractData.CameraComps.ContainsKey(key))
						{
							InteractData.CameraComps.Add(key, new TWeakObject<UCameraComponent>(obj));
							break;
						}
					}
				}
				if (item.ComponentHasTag(B1GlobalFNames.AreaDefinition) && item is USceneComponent uSceneComponent)
				{
					InteractData.AreaDefinition.Add(uSceneComponent.GetWorldLocation());
				}
			}
		}
		InteractData.QAInteractRangeAnchor = InteractRangeAnchor;
		PlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner.World);
		if (InteractData.InteractiveUnitCommDesc != null && InteractData.InteractiveUnitCommDesc.InteractType == EInteractType.RequireItem)
		{
			BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
			bGWEventCollection.Evt_TaskGraphNotifyGraph_ItemChange = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange)Delegate.Combine(bGWEventCollection.Evt_TaskGraphNotifyGraph_ItemChange, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange(OnRoleItemChange));
			UpdateItemRequireCondition();
		}
		base.BGWEventCollection.Evt_BGW_InteractRequestPreload(InteractData.InteractiveUnitID);
		UpdateFx();
		base.BGWEventCollection.Evt_RegisterInteractor(base.GuidData.GetFinalGuid());
	}

	private void CheckInteractCameraFov(UActorComponent Comp)
	{
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (InteractData.InteractiveUnitID == 0)
		{
			return;
		}
		if (InteractData.CD > 0f)
		{
			InteractData.CD -= DeltaTime;
		}
		if (InteractData != null && InteractData.InteractiveUnitCommDesc != null && TickRateData != null && TickRateData.CanTickFor200msInterval(out var AccumulatedDeltaTime, out var _, out var _, out var _, out var _) && InteractData.InteractUnitState == EBGUInteractUnitState.BeforeActive && !InteractData.bIsInteracting)
		{
			if (InteractData.InteractiveUnitCommDesc.InteractType == EInteractType.NotForPlayer)
			{
				TickForAiInteract(AccumulatedDeltaTime);
			}
			else
			{
				TickPlayerInteractive(AccumulatedDeltaTime);
			}
		}
		TickForRemainingInteractTime(DeltaTime);
		TickInteractSock();
		if (DebugConfig.InteractiveObj)
		{
			FSlateColor color = B1GlobalFSlateColor.Green;
			switch (InteractData.InteractUnitState)
			{
			case EBGUInteractUnitState.BeforeInactive:
				color = B1GlobalFSlateColor.Yellow;
				break;
			case EBGUInteractUnitState.BeforeActive:
				color = B1GlobalFSlateColor.Green;
				break;
			case EBGUInteractUnitState.AfterInactive:
				color = B1GlobalFSlateColor.Red;
				break;
			}
			int num = 0;
			if (InteractData.ActionList.Count > 0)
			{
				num = InteractData.ActionList[0].ID;
			}
			base.BUSEventCollection.Evt_UpdateDebugUILamp.Invoke("InteractiveObj", color);
			base.BUSEventCollection.Evt_UpdateDebugUILamp.Invoke("InteractiveObj", InteractData.bIsInteracting ? B1GlobalFSlateColor.Green : B1GlobalFSlateColor.Gray, 1);
			base.BUSEventCollection.Evt_UpdateDebugUITitle.Invoke("InteractiveObj", InteractData.InteractiveUnitCommDesc.Name.ToFText().ToString());
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("InteractiveObj", "当前交互组", InteractData.ActionGroupID.ToString());
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("InteractiveObj", "当前交互行为ID", num.ToString());
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("InteractiveObj", "UI状态", InteractData.InteractUIState.ToString());
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.BGSEventCollection.Evt_BGS_UnitDead -= new Del_Void_StringDeadReason(OnUnitDead);
		base.BGSEventCollection.Evt_InteractGroup_Refresh -= new Del_Void(UpdateActionInGroup);
		base.BUSEventCollection.Evt_InteractGroup_Update -= new Del_UpdateInteractGroup(UpdateInteractGroup);
		if (InteractData.InteractiveUnitCommDesc != null && InteractData.InteractiveUnitCommDesc.InteractType == EInteractType.RequireItem)
		{
			BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
			bGWEventCollection.Evt_TaskGraphNotifyGraph_ItemChange = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange)Delegate.Remove(bGWEventCollection.Evt_TaskGraphNotifyGraph_ItemChange, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange(OnRoleItemChange));
		}
		if (InteractData.bInActiveArea)
		{
			ACharacter playerCharacter = UBGUFunctionLibrary.GetPlayerCharacter(base.Owner);
			if (playerCharacter.IsNullOrDestroyed())
			{
				return;
			}
			FUStInteractiveUnitCommDesc interactiveUnitCommDesc = BGW_GameDB.GetInteractiveUnitCommDesc(InteractData.InteractiveUnitID);
			InteractData.bInActiveArea = false;
			base.BUSEventCollection.Evt_LeaveActiveArea.Invoke(playerCharacter, interactiveUnitCommDesc.InteractType);
			BUS_EventCollectionCS.Get(playerCharacter).Evt_LeaveActiveArea.Invoke(base.Owner, interactiveUnitCommDesc.InteractType);
		}
		SubMeshCompCollisionCache = null;
		base.BGWEventCollection.Evt_UnregisterInteractor(base.GuidData.GetFinalGuid());
	}

	private void TickForRemainingInteractTime(float DeltaTime)
	{
		if (!(InteractData.RemainingInteractTime < 0f))
		{
			InteractData.RemainingInteractTime -= DeltaTime;
			if (InteractData.RemainingInteractTime <= 1E-08f)
			{
				base.BUSEventCollection.Evt_NotifyGraphClient.Invoke(base.GuidData.GetFinalGuid(), BGW_FlowUtils.CommonTag.InteractionTimeEmpty);
			}
		}
	}

	private void OnSetInteractTarget(bool bActive)
	{
		if (InteractData.bIsInteractTarget != bActive)
		{
			InteractData.bIsInteractTarget = bActive;
		}
	}

	private bool CheckInBattle(ACharacter Target)
	{
		if (InteractData.InteractiveUnitID == 9809)
		{
			return false;
		}
		float leaveActivableDistance = UBGWFunctionLibraryCS.GetLeaveActivableDistance(InteractData.TrueActivableDistance);
		List<ABGUCharacter> allTargetCharacterList = BGUFunctionLibraryCS.GetAllTargetCharacterList(Target as ABGUCharacter);
		if (allTargetCharacterList != null)
		{
			for (int i = 0; i < allTargetCharacterList.Count; i++)
			{
				ABGUCharacter aBGUCharacter = allTargetCharacterList[i];
				if (!(aBGUCharacter != null))
				{
					continue;
				}
				IBUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(aBGUCharacter);
				if (readOnlyData != null && !readOnlyData.HasState(EBGUUnitState.Dead) && FVector.Distance(aBGUCharacter.GetActorLocation(), base.Owner.GetActorLocation()) < leaveActivableDistance)
				{
					IBUC_TargetInfoData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(aBGUCharacter);
					if (readOnlyData2 != null && readOnlyData2.GetTargetInfo().LockTargetEntity != Entity.Null)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	private void TickPlayerInteractive(float DeltaTime)
	{
		ACharacter playerCharacter = UBGUFunctionLibrary.GetPlayerCharacter(base.Owner);
		if (playerCharacter.IsNullFastCheck())
		{
			return;
		}
		EInteractUIState interactUIState = InteractData.InteractUIState;
		float num = TickRateData.GetDistanceToPlayer();
		if (!InteractRangeAnchor.IsNullFastCheck())
		{
			num = FVector.Distance(playerCharacter.GetActorLocation(), InteractRangeAnchor.GetWorldLocation());
		}
		if (InteractData.InteractiveUnitCommDesc.HighLightFXPath != string.Empty && InteractData.PlayingHighLightDBCID == 0 && !InteractData.bIsInteracting && InteractData.InteractUnitState == EBGUInteractUnitState.BeforeActive && num <= (float)InteractData.InteractiveUnitCommDesc.HighLightFXActiveRange && InteractData.CD <= 0f)
		{
			if (CheckCanShowHighLightEfx())
			{
				string text = InteractData.InteractiveUnitCommDesc.HighLightFXPath;
				if (BGW_CollectionActorFuncUtil.CheckTalentActive(GetOwner(), text))
				{
					text = InteractData.InteractiveUnitCommDesc.TalentHighLightFXPath;
				}
				base.BUSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(text, out var RequestID);
				InteractData.PlayingHighLightDBCID = RequestID;
			}
		}
		else if (InteractData.PlayingHighLightDBCID != 0 && num > (float)(InteractData.InteractiveUnitCommDesc.HighLightFXActiveRange + 150))
		{
			base.BUSEventCollection.Evt_RequestDestroyByFXRequestID.Invoke(InteractData.PlayingHighLightDBCID);
			InteractData.PlayingHighLightDBCID = 0;
		}
		if (num <= InteractData.TrueActivableDistance)
		{
			if (!InteractData.bInActiveArea)
			{
				UpdateActionInGroup();
				InteractData.bInActiveArea = true;
				base.BUSEventCollection.Evt_EnterActiveArea.Invoke(playerCharacter, InteractData.InteractiveUnitCommDesc.InteractType);
				BUS_EventCollectionCS.Get(playerCharacter).Evt_EnterActiveArea.Invoke(base.Owner, InteractData.InteractiveUnitCommDesc.InteractType);
				interactUIState = EInteractUIState.Focus;
			}
			if (InteractData.ItemRequireCondition)
			{
				interactUIState = EInteractUIState.Invisiable;
			}
		}
		else if (num > UBGWFunctionLibraryCS.GetLeaveActivableDistance(InteractData.TrueActivableDistance) && InteractData.bInActiveArea)
		{
			interactUIState = EInteractUIState.Invisiable;
			DisposeAndReset(playerCharacter);
		}
		if (InteractData.bInActiveArea)
		{
			interactUIState = ((!InterActivePreCheckInvisable(playerCharacter)) ? EInteractUIState.Invisiable : (CheckInBattle(playerCharacter) ? EInteractUIState.Invisiable : EInteractUIState.Focus));
			bool flag = false;
			if (num <= InteractData.InteractiveUnitCommDesc.InteractDistance)
			{
				InterActivePreCheckFocus(playerCharacter);
				FVector b = BGUFuncLibActorTransformCS.BGUGetActorLocation(playerCharacter) - ((InteractRangeAnchor == null) ? BGUFuncLibActorTransformCS.BGUGetActorLocation(base.Owner) : InteractRangeAnchor.GetWorldLocation());
				b.Normalize();
				if (FMath.Abs(MathLib.DegAcos(FVector.DotProduct(base.Owner.GetActorForwardVector(), b))) <= InteractData.InteractiveUnitCommDesc.InteractAngle / 2f)
				{
					flag = true;
					if (InteractData.CanInteractPlayerEntity == Entity.Null)
					{
						InteractData.CanInteractPlayerEntity = ECSUtil.ToEntity(playerCharacter);
						base.BUSEventCollection.Evt_EnterActiveArea.Invoke(playerCharacter, InteractData.InteractiveUnitCommDesc.InteractType);
						BUS_EventCollectionCS.Get(playerCharacter).Evt_EnterActiveArea.Invoke(base.Owner, InteractData.InteractiveUnitCommDesc.InteractType);
						BUS_EventCollectionCS.Get(playerCharacter).Evt_EnterInteractiveArea.Invoke(base.Owner);
					}
					if (!InteractData.bIsInteractTarget)
					{
						interactUIState = (((int)InteractData.InteractConstraint >= 6) ? EInteractUIState.Invisiable : EInteractUIState.Focus);
					}
					else
					{
						interactUIState = ((InteractData.InteractConstraint == EInteractConstraint.TransForming || InteractData.InteractConstraint == EInteractConstraint.EnemyAround || InteractData.InteractConstraint == EInteractConstraint.BossRush) ? EInteractUIState.CantInteract : (((int)InteractData.InteractConstraint >= 3 && (int)InteractData.InteractConstraint < 6) ? EInteractUIState.Focus : ((InteractData.InteractConstraint != EInteractConstraint.None) ? EInteractUIState.Invisiable : EInteractUIState.Interactable)));
						if (InteractData.ActionGroupID == 980901 || InteractData.ActionGroupID == 980903)
						{
							interactUIState = EInteractUIState.Invisiable;
						}
					}
				}
			}
			if (!flag && InteractData.CanInteractPlayerEntity != Entity.Null)
			{
				interactUIState = EInteractUIState.Focus;
				if (InteractData.ItemRequireCondition)
				{
					interactUIState = EInteractUIState.Invisiable;
				}
				InteractData.CanInteractPlayerEntity = Entity.Null;
				BUS_EventCollectionCS.Get(playerCharacter).Evt_LeaveInteractiveArea.Invoke(base.Owner);
			}
		}
		if ((int)InteractData.InteractConstraint > 6)
		{
			interactUIState = EInteractUIState.Invisiable;
		}
		InteractData.InteractUIState = interactUIState;
	}

	private void DisposeAndReset(AActor Player)
	{
		InteractData.InteractUIState = EInteractUIState.Invisiable;
		InteractData.bInActiveArea = false;
		InteractData.CanInteractPlayerEntity = Entity.Null;
		if (InteractData.InteractiveUnitCommDesc.InteractType == EInteractType.NotForPlayer)
		{
			base.BGSEventCollection.Evt_BGS_LeaveFollowPartnerInteractArea.Invoke(base.Owner);
			return;
		}
		base.BUSEventCollection.Evt_LeaveActiveArea.Invoke(Player, InteractData.InteractiveUnitCommDesc.InteractType);
		BUS_EventCollectionCS.Get(Player).Evt_LeaveActiveArea.Invoke(base.Owner, InteractData.InteractiveUnitCommDesc.InteractType);
	}

	private bool CheckCanShowHighLightEfx()
	{
		if (UnitStateData != null)
		{
			return !UnitStateData.HasState(EBGUUnitState.Dead);
		}
		return true;
	}

	private void TickForAiInteract(float DeltaTime)
	{
		ACharacter playerCharacter = UBGUFunctionLibrary.GetPlayerCharacter(base.Owner);
		if (playerCharacter == null)
		{
			return;
		}
		float num = TickRateData.GetDistanceToPlayer();
		if (InteractRangeAnchor != null)
		{
			num = FVector.Distance(playerCharacter.GetActorLocation(), InteractRangeAnchor.GetWorldLocation());
		}
		if (num <= InteractData.TrueActivableDistance)
		{
			InteractData.bInActiveArea = true;
			base.BGSEventCollection.Evt_BGS_ComeCloseToFollowPartnerInteractiveArea.Invoke(base.Owner);
		}
		else if (num > UBGWFunctionLibraryCS.GetLeaveActivableDistance(InteractData.TrueActivableDistance))
		{
			DisposeAndReset(playerCharacter);
		}
		if (InteractData.bInActiveArea && num <= InteractData.InteractiveUnitCommDesc.InteractDistance)
		{
			FVector b = BGUFuncLibActorTransformCS.BGUGetActorLocation(playerCharacter) - ((InteractRangeAnchor == null) ? BGUFuncLibActorTransformCS.BGUGetActorLocation(base.Owner) : InteractRangeAnchor.GetWorldLocation());
			b.Normalize();
			if (FMath.Abs(MathLib.DegAcos(FVector.DotProduct(base.Owner.GetActorForwardVector(), b))) <= InteractData.InteractiveUnitCommDesc.InteractAngle / 2f)
			{
				base.BGSEventCollection.Evt_BGS_EnterFollowPartnerInteractArea.Invoke(base.Owner);
			}
		}
		InteractData.InteractUIState = EInteractUIState.Invisiable;
	}

	private bool InterActivePreCheckFocus(AActor InteractPlayer)
	{
		if (B1Global.GIsBossRushMode)
		{
			InteractData.InteractConstraint = EInteractConstraint.BossRush;
			return false;
		}
		if ((int)InteractData.InteractConstraint >= 6)
		{
			return false;
		}
		BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(InteractPlayer);
		BUC_SimpleStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(InteractPlayer);
		BUInteractTypeTemplate interactTypeTemplate = BGW_EffectTemplateList.Get(GetOwner()).GetInteractTypeTemplate(InteractData.InteractiveUnitCommDesc.InteractType);
		if (interactTypeTemplate != null && !interactTypeTemplate.PreCheckInteract(InteractData, InteractPlayer, GetOwner()))
		{
			return false;
		}
		if (IsOnline() && InteractData.InteractiveUnitCommDesc.NetGameMultiInteract == EGSYesNo.No && InteractData.InteractingPlayerEntity != Entity.Null && InteractData.InteractiveUnitCommDesc.InteractType != EInteractType.Rescue)
		{
			InteractData.InteractConstraint = EInteractConstraint.OtherIsUsing;
		}
		if (readOnlyData2 != null && (readOnlyData2.HasSimpleState(EBGUSimpleState.Frozen) || readOnlyData2.HasSimpleState(EBGUSimpleState.Immobilizing)))
		{
			InteractData.InteractConstraint = EInteractConstraint.Busy;
			return false;
		}
		if (!readOnlyData.HasState(EBGUUnitState.InInteractWindow) && (readOnlyData.HasState(EBGUUnitState.Attacking) || readOnlyData.HasState(EBGUUnitState.JumpMoving) || readOnlyData.HasState(EBGUUnitState.Beatback)))
		{
			InteractData.InteractConstraint = EInteractConstraint.Busy;
			return false;
		}
		return true;
	}

	private bool InterActivePreCheckInvisable(AActor InteractPlayer, bool IgnoreCheckInteracting = false)
	{
		BPC_PlayerInteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerInteractData>((InteractPlayer as APawn).PlayerState);
		BUC_UnitStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(InteractPlayer);
		BUC_FallDyingData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<BUC_FallDyingData>(InteractPlayer);
		BUC_SimpleStateData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(InteractPlayer);
		IBUC_ManualSplineMoveData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ManualSplineMoveData, BUC_ManualSplineMoveData>(InteractPlayer);
		InteractData.InteractConstraint = EInteractConstraint.None;
		if (InteractData == null)
		{
			InteractData.InteractConstraint = EInteractConstraint.Other;
			return false;
		}
		if (InteractData.CD > 0f)
		{
			InteractData.InteractConstraint = EInteractConstraint.CD;
			return false;
		}
		if (!IgnoreCheckInteracting && readOnlyData.IsInInteraction())
		{
			InteractData.InteractConstraint = EInteractConstraint.Interacting;
			return false;
		}
		if (readOnlyData2.HasState(EBGUUnitState.Dead) || readOnlyData3.UnitFallDyingState != EFallDyingState.Alive || readOnlyData2.HasState(EBGUUnitState.LifeSavingHair_FakeDead) || readOnlyData4.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			InteractData.InteractConstraint = EInteractConstraint.Dead;
			return false;
		}
		BUC_UnitStateData readOnlyData5 = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(base.Owner);
		if (readOnlyData5 != null && (readOnlyData5.HasState(EBGUUnitState.Dead) || readOnlyData5.HasState(EBGUUnitState.LifeSavingHair_FakeDead) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(base.Owner, EBGUSimpleState.PendingDeathInAnimationSyncing)))
		{
			InteractData.InteractConstraint = EInteractConstraint.Dead;
			return false;
		}
		if (readOnlyData4 != null && (readOnlyData4.HasSimpleState(EBGUSimpleState.Interacting) || readOnlyData4.HasSimpleState(EBGUSimpleState.IgnoreAllInput) || readOnlyData4.HasSimpleState(EBGUSimpleState.CantInteract)))
		{
			InteractData.InteractConstraint = EInteractConstraint.Restriction;
			return false;
		}
		if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.IsManuaslSplineMovingWithSpecialAnimation())
		{
			InteractData.InteractConstraint = EInteractConstraint.SplineMoving;
			return false;
		}
		if (InteractData.InteractiveUnitCommDesc == null)
		{
			InteractData.InteractConstraint = EInteractConstraint.ConfigMiss;
			return false;
		}
		if (InteractData.ItemRequireCondition)
		{
			InteractData.InteractConstraint = EInteractConstraint.ItemRequireCondition;
			return false;
		}
		return true;
	}

	private void TickInteractSock()
	{
		if (InteractData.bInActiveArea && !InteractSock.IsNullOrDestroyed())
		{
			InteractData.IconSockVector = InteractSock.GetWorldLocation();
			InteractData.bSpecialIcon = false;
		}
	}

	private void UpdateIdle()
	{
		if (InteractData.ActionList.Count == 0)
		{
			return;
		}
		string path = ((InteractData.InteractUnitState == EBGUInteractUnitState.AfterInactive) ? InteractData.ActionList[0].IdleAfter : InteractData.ActionList[0].IdleBefore);
		if (!(base.Owner is BGUInteractiveActorBase))
		{
			return;
		}
		UAnimSequence uAnimSequence = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UAnimSequence>(path, ELoadResourceType.SyncLoadAndCache);
		bool num = InteractData.ActionList[0].HideIfCantInteract == EGSYesNo.Yes && (InteractData.InteractUnitState == EBGUInteractUnitState.AfterInactive || InteractData.InteractUnitState == EBGUInteractUnitState.BeforeInactive);
		bool flag = false;
		if ((InteractData.ActionGroupID == 702701 || InteractData.ActionGroupID == 703101) && InteractData.InteractUnitState == EBGUInteractUnitState.BeforeInactive)
		{
			flag = true;
		}
		if (num || flag)
		{
			base.Owner.SetActorHiddenInGame(bNewHidden: true);
			InteractData.ModifiedCollision = true;
			if (SubMeshCompCollisionCache != null)
			{
				foreach (KeyValuePair<UMeshComponent, ECollisionEnabled> item in SubMeshCompCollisionCache)
				{
					if (!item.Key.IsNullOrDestroyed())
					{
						item.Key.SetCollisionEnabled(ECollisionEnabled.NoCollision);
					}
				}
			}
		}
		else if (InteractData.ModifiedCollision)
		{
			InteractData.ModifiedCollision = false;
			base.Owner.SetActorHiddenInGame(bNewHidden: false);
			if (SubMeshCompCollisionCache != null)
			{
				foreach (KeyValuePair<UMeshComponent, ECollisionEnabled> item2 in SubMeshCompCollisionCache)
				{
					if (!item2.Key.IsNullOrDestroyed())
					{
						item2.Key.SetCollisionEnabled(item2.Value);
					}
				}
			}
		}
		if (uAnimSequence != null)
		{
			foreach (UActorComponent item3 in base.Owner.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>()))
			{
				if (item3.ComponentHasTag(B1GlobalFNames.master))
				{
					BUAnimInteractiveActor bUAnimInteractiveActor = (item3 as USkeletalMeshComponent).GetAnimInstance() as BUAnimInteractiveActor;
					if (bUAnimInteractiveActor == null)
					{
						BGW_LogUtil.LogError("[interactcomp] " + GetOwner().GetName() + " AnimInst != BUAnimInteractiveActor");
						return;
					}
					bUAnimInteractiveActor.AnimIdle = uAnimSequence;
				}
			}
		}
		else
		{
			BGW_EffectTemplateList.Get(GetOwner()).GetInteractActionTemplate(InteractData.ActionList[0].InteractAction)?.UpdateIdle(GetOwner(), InteractData.ActionList[0], InteractData.InteractUnitState);
		}
		base.BGSEventCollection.Evt_BGS_SetSceneInactiveActorForceActivateTicks.Invoke(base.Owner);
	}

	private void OnCallBPFunc()
	{
		BGUInteractiveActorBase bGUInteractiveActorBase = GetOwner() as BGUInteractiveActorBase;
		if (bGUInteractiveActorBase != null)
		{
			bGUInteractiveActorBase.CallBPFunc();
		}
	}

	private void OnUnitDead(string UnitGuid, EDeadReason InDeadReason)
	{
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, UnitGuid);
		if (InteractData.CanInteractPlayerEntity == ECSUtil.ToEntity(actorByGuid))
		{
			InteractData.CanInteractPlayerEntity = Entity.Null;
		}
	}

	private void OnTriggerPreInteract(AActor Player)
	{
		InteractData.TriggerInteractPlayerEntity = ECSUtil.ToEntity(Player);
		List<UActorComponent> componentsByTag = base.Owner.GetComponentsByTag(UClass.GetClass<USkeletalMeshComponent>(), B1GlobalFNames.master);
		if (componentsByTag.Count == 1)
		{
			bool ComponentCreated;
			UAkComponent akComponent = UAkGameplayStatics.GetAkComponent(componentsByTag[0] as USkeletalMeshComponent, out ComponentCreated, FName.None, FVector.ZeroVector, EAttachLocation.SnapToTarget);
			string switchState = InteractData.GetFNameByMaterial(InteractData.ObjectMaterial).ToString();
			if (akComponent != null)
			{
				akComponent.SetSwitch(null, "ENV_door_big", switchState);
				akComponent.SetSwitch(null, "ENV_door_mid", switchState);
				akComponent.SetSwitch(null, "ENV_door_small", switchState);
			}
		}
		UpdateActionInGroup();
		InterActivePreCheckInvisable(Player, IgnoreCheckInteracting: true);
		InterActivePreCheckFocus(Player);
	}

	private void OnTriggerPreInteractForAiInteract(AActor Player)
	{
		InteractData.TriggerInteractPlayerEntity = ECSUtil.ToEntity(Player);
		UpdateActionInGroup();
	}

	private void OnTriggerInteractRollback()
	{
		if (!InteractData.bIsInteracting)
		{
			InteractData.TriggerInteractPlayerEntity = Entity.Null;
			InteractData.InteractingPlayerEntity = Entity.Null;
			InteractData.InteractConstraint = EInteractConstraint.None;
			InteractData.bMuteSubtitle = true;
			GetOwner().Tags.Remove(B1GlobalFNames.InteractTarget);
		}
	}

	private void OnTriggerBeInteract(AActor PlayerActor, bool IsAiTrigger)
	{
		if (IsAiTrigger || !(InteractData.CanInteractPlayerEntity != ECSUtil.ToEntity(PlayerActor)))
		{
			InteractData.bMuteSubtitle = false;
			GetOwner().Tags.Add(B1GlobalFNames.InteractTarget);
			NotifyGraph(BGW_FlowUtils.CommonTag.InteractionBegin);
			InteractData.RemainingInteractTime = InteractData.ActionList[0].GraphTriggerTime;
			InteractData.CD = InteractData.ActionList[0].CoolDown;
			InteractData.InteractUIState = EInteractUIState.Invisiable;
			InteractData.ModifiedGroupWhenInteracting = false;
			if (InteractData.PlayingHighLightDBCID != 0)
			{
				base.BUSEventCollection.Evt_RequestDestroyByFXRequestID.Invoke(InteractData.PlayingHighLightDBCID);
				InteractData.PlayingHighLightDBCID = 0;
			}
			UpdateFx(ForceDeactive: true);
		}
	}

	private void OnTriggerBreakInteract(AActor Player)
	{
		InteractData.TriggerInteractPlayerEntity = Entity.Null;
		InteractData.InteractingPlayerEntity = Entity.Null;
		InteractData.bMuteSubtitle = true;
		GetOwner().Tags.Remove(B1GlobalFNames.InteractTarget);
		InteractData.ModifiedGroupWhenInteracting = false;
		NotifyGraph(BGW_FlowUtils.CommonTag.InteractionBreak);
	}

	private void OnTriggerFinishInteract(AActor Player)
	{
		base.BGSEventCollection.Evt_BGS_FollowPartnerFinishInteract.Invoke(base.Owner);
		BGUCharacterCS bGUCharacterCS = Player as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BTF_EventCollectionCS.Get(bGUCharacterCS.PlayerState)?.Evt_CollectionInteractiveUnlockReq(new CSMsgCollectionInteractiveUnlockReq
			{
				CardId = InteractData.InteractiveUnitCommDesc.HandbookCardID
			}, null);
		}
		InteractData.TriggerInteractPlayerEntity = Entity.Null;
		InteractData.InteractingPlayerEntity = Entity.Null;
		if (Player as APawn == null)
		{
			return;
		}
		GetOwner().Tags.Remove(B1GlobalFNames.InteractTarget);
		NotifyGraph(BGW_FlowUtils.CommonTag.InteractionEnd);
		if (InteractData.ModifiedGroupWhenInteracting || InteractData.ActionList.Count == 0)
		{
			InteractData.ModifiedGroupWhenInteracting = false;
			return;
		}
		if (InteractData.ActionList[0].Condition == EInterActMappingCondition.Loop)
		{
			List<FUStInteractionMappingDesc> interactionActionsByGroupID = BGW_GameDB.GetInteractionActionsByGroupID(InteractData.InteractiveUnitID, InteractData.ActionGroupID);
			int count = interactionActionsByGroupID.Count;
			int num = 0;
			for (int i = 0; i < interactionActionsByGroupID.Count; i++)
			{
				if (interactionActionsByGroupID[i].Param1 == 1)
				{
					num = i + 1;
				}
			}
			if (InteractData.InteractCounter < count)
			{
				InteractData.InteractCounter++;
			}
			else if (num > 0)
			{
				InteractData.InteractCounter = num;
			}
		}
		if (InteractData.ActionList[0].ResetAction == EGSYesNo.No)
		{
			UpdateInteractState_Internal(EBGUInteractUnitState.AfterInactive, UpdatePersistent: true, UpdateAction: false);
			DisposeAndReset(Player);
		}
		else
		{
			UpdateInteractState_Internal(EBGUInteractUnitState.BeforeActive, UpdatePersistent: true, UpdateAction: false);
		}
	}

	private void UpdateInteractGroup(int GroupID, EBGUInteractUnitState InteractUnitState)
	{
		UpdateInteractGroup_Internal(GroupID, InteractUnitState);
	}

	private void UpdateInteractGroup_Internal(int GroupID, EBGUInteractUnitState InteractUnitState, bool UpdatePersistent = true)
	{
		BUC_InteractData interactData = InteractData;
		if (interactData == null)
		{
			_ = 1;
		}
		else
			_ = interactData.InteractiveUnitCommDesc?.InteractType != EInteractType.Collection;
		InteractData.SetActionGroupID(GroupID, UpdatePersistent);
		InteractData.ItemRequireCondition = false;
		InteractData.ModifiedGroupWhenInteracting = true;
		UpdateInteractState(InteractUnitState, UpdatePersistent);
		PlayAnimAfterUpdateGroupID();
		if (InteractData.InteractiveUnitID == 3040 && GroupID == 0)
		{
			ACharacter playerCharacter = UBGUFunctionLibrary.GetPlayerCharacter(base.Owner);
			DisposeAndReset(playerCharacter);
		}
	}

	private void UpdateInteractState(EBGUInteractUnitState InteractUnitState, bool UpdatePersistent)
	{
		UpdateInteractState_Internal(InteractUnitState, UpdatePersistent);
	}

	private void UpdateInteractState_Internal(EBGUInteractUnitState InteractUnitState, bool UpdatePersistent, bool UpdateAction = true)
	{
		InteractData.SetInteractUnitState(InteractUnitState, UpdatePersistent);
		InteractData.ItemRequireCondition = false;
		if (UpdateAction)
		{
			UpdateActionInGroup();
		}
		if (InteractUnitState == EBGUInteractUnitState.Default)
		{
			if (InteractData.ActionGroupID >= 0 && InteractData.ActionList.Count > 0 && InteractData.ActionList[0].ActionCanInteract == EGSYesNo.Yes)
			{
				InteractData.SetInteractUnitState(EBGUInteractUnitState.BeforeActive, UpdatePersistent);
			}
			else
			{
				InteractData.SetInteractUnitState(EBGUInteractUnitState.BeforeInactive, UpdatePersistent);
			}
		}
		if (InteractData.InteractUnitState != EBGUInteractUnitState.BeforeActive)
		{
			InteractData.InteractUIState = EInteractUIState.Invisiable;
			if (InteractData.CanInteractPlayerEntity != Entity.Null)
			{
				AActor aActor = ECSUtil.ToActor(InteractData.CanInteractPlayerEntity);
				if (aActor != null)
				{
					InteractData.CanInteractPlayerEntity = Entity.Null;
					BUS_EventCollectionCS.Get(aActor).Evt_LeaveInteractiveArea.Invoke(base.Owner);
				}
			}
			OnSetInteractTarget(bActive: false);
		}
		base.BUSEventCollection.Evt_RequestAudioEmitter.Invoke(InteractData.InteractUnitState == EBGUInteractUnitState.BeforeActive);
		UpdateIdle();
		UpdateFx();
	}

	private void UpdateFx(bool ForceDeactive = false)
	{
		if (AvailableFXCom != null)
		{
			if (base.Owner is BGUMeditationPointBase)
			{
				APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
				if (firstLocalPlayerController != null)
				{
					BUC_MeditationPointData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MeditationPointData>(base.Owner);
					BPC_PlayerRoleData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(firstLocalPlayerController);
					if (readOnlyData2 != null && readOnlyData != null && readOnlyData2.RoleData.RoleCs.Actor.Progress.AwardMeditationList.Contains(readOnlyData.MeditationPointConfigID))
					{
						ForceDeactive = true;
					}
				}
			}
			AvailableFXCom.GetChildrenComponents(bIncludeAllDescendants: true, out var Children);
			foreach (USceneComponent item in Children)
			{
				if (item is UNiagaraComponent uNiagaraComponent)
				{
					bool flag = InteractData.InteractUnitState != EBGUInteractUnitState.BeforeActive || ForceDeactive;
					uNiagaraComponent.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, flag);
					if (flag)
					{
						uNiagaraComponent.Deactivate();
					}
					else
					{
						uNiagaraComponent.Activate();
					}
				}
			}
		}
		if (!(DisabledFxCom != null))
		{
			return;
		}
		DisabledFxCom.GetChildrenComponents(bIncludeAllDescendants: true, out var Children2);
		foreach (USceneComponent item2 in Children2)
		{
			if (item2 is UNiagaraComponent uNiagaraComponent2)
			{
				bool flag2 = InteractData.InteractUnitState == EBGUInteractUnitState.BeforeActive;
				uNiagaraComponent2.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, flag2);
				if (flag2)
				{
					uNiagaraComponent2.Deactivate();
				}
				else
				{
					uNiagaraComponent2.Activate();
				}
			}
		}
	}

	private void SwitchNoInteraction(bool bIsRecover)
	{
		if (GetOwner() != null)
		{
			if (bIsRecover)
			{
				UpdateInteractGroup_Internal(InteractData.DefalutInteractiveGroupID, EBGUInteractUnitState.Default, UpdatePersistent: false);
			}
			else
			{
				UpdateInteractGroup_Internal(-1, EBGUInteractUnitState.BeforeInactive, UpdatePersistent: false);
			}
		}
	}

	private void UpdateActionInGroup()
	{
		if (InteractData.InteractiveUnitID == 0)
		{
			return;
		}
		InteractData.ActionList.Clear();
		if (InteractData.ActionGroupID < 0)
		{
			return;
		}
		ACharacter aCharacter = ECSExtension.ToActor(InteractData.TriggerInteractPlayerEntity) as ACharacter;
		if (aCharacter.IsNullOrDestroyed())
		{
			aCharacter = UBGUFunctionLibrary.GetPlayerCharacter(base.Owner);
		}
		List<FUStInteractionMappingDesc> list = new List<FUStInteractionMappingDesc>();
		List<FUStInteractionMappingDesc> interactionActionsByGroupID = BGW_GameDB.GetInteractionActionsByGroupID(InteractData.InteractiveUnitID, InteractData.ActionGroupID);
		if (interactionActionsByGroupID != null)
		{
			if (interactionActionsByGroupID.Count > 0 && interactionActionsByGroupID[0].Condition == EInterActMappingCondition.Default)
			{
				list.Add(interactionActionsByGroupID[0]);
			}
			else if (interactionActionsByGroupID.Count > 0 && interactionActionsByGroupID[0].Condition == EInterActMappingCondition.DistanceToMachingPoint)
			{
				float num = float.MaxValue;
				FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter);
				foreach (FUStInteractionMappingDesc item in interactionActionsByGroupID)
				{
					FName tag = new FName(item.MathchingPointCompTag);
					List<UActorComponent> componentsByTag = base.Owner.GetComponentsByTag(UClass.GetClass<USceneComponent>(), tag);
					if (componentsByTag.Count != 0)
					{
						FVector worldLocation = (componentsByTag[0] as USceneComponent).GetWorldLocation();
						float num2 = (fVector - worldLocation).Size();
						if (num2 < num)
						{
							list.Clear();
							list.Add(item);
							num = num2;
						}
					}
				}
			}
			else if (interactionActionsByGroupID.Count > 0 && interactionActionsByGroupID[0].Condition == EInterActMappingCondition.Loop)
			{
				list.Clear();
				if (interactionActionsByGroupID.Count >= InteractData.InteractCounter)
				{
					list.Add(interactionActionsByGroupID[InteractData.InteractCounter - 1]);
				}
				else
				{
					list.Add(interactionActionsByGroupID[0]);
				}
			}
			else if (interactionActionsByGroupID.Count > 0 && interactionActionsByGroupID[0].Condition == EInterActMappingCondition.MatchHeight)
			{
				list.Add(interactionActionsByGroupID[0]);
				float num3 = BGUFuncLibActorTransformCS.BGUGetActorLocation(base.Owner).Z - BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter).Z + 120f;
				foreach (FUStInteractionMappingDesc item2 in interactionActionsByGroupID)
				{
					if (num3 >= (float)item2.Param1 && num3 < (float)item2.Param2)
					{
						list.Clear();
						list.Add(item2);
						break;
					}
				}
			}
			else if (interactionActionsByGroupID.Count > 0 && interactionActionsByGroupID[0].Condition == EInterActMappingCondition.HasItem)
			{
				BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(aCharacter.GetController());
				if (readOnlyData == null)
				{
					BGW_LogUtil.LogError("[BUS_InteractCompImpl] UpdateActionInGroup PlayerRoleData == null");
				}
				else
				{
					foreach (FUStInteractionMappingDesc item3 in interactionActionsByGroupID)
					{
						int param = item3.Param1;
						bool flag = item3.Param2 > 0;
						bool flag2 = RoleDataHelper.HasItem(readOnlyData, param);
						if ((flag && flag2) || (!flag && !flag2))
						{
							list.Clear();
							list.Add(item3);
							break;
						}
					}
				}
			}
			else if (interactionActionsByGroupID.Count > 0 && interactionActionsByGroupID[0].Condition == EInterActMappingCondition.SeedSubmitted)
			{
				BPC_PlayerRoleData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(aCharacter.GetController());
				if (readOnlyData2 == null || readOnlyData2.RoleData == null || readOnlyData2.RoleData.RoleCs == null)
				{
					BGW_LogUtil.LogError("[BUS_InteractCompImpl] UpdateActionInGroup PlayerRoleData == null");
				}
				else
				{
					bool flag3 = readOnlyData2.RoleData.RoleCs.Garden.CropList != null && readOnlyData2.RoleData.RoleCs.Garden.CropList.Count > 0;
					foreach (FUStInteractionMappingDesc item4 in interactionActionsByGroupID)
					{
						bool flag4 = item4.Param1 > 0;
						if ((flag4 && flag3) || (!flag4 && !flag3))
						{
							list.Clear();
							list.Add(item4);
							break;
						}
					}
				}
			}
		}
		List<FUStInteractionMappingDesc> interactionActionsByGroupID2 = BGW_GameDB.GetInteractionActionsByGroupID(InteractData.InteractiveUnitID, 0);
		if (interactionActionsByGroupID2 != null && interactionActionsByGroupID2.Count > 0 && interactionActionsByGroupID2[0].Condition == EInterActMappingCondition.FunctionEnable)
		{
			IBPC_PlayerRoleData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner));
			ReadOnlyShopOneList shopList = readOnlyData3.RoleData.RoleCs.Shop.ShopList;
			bool flag5 = false;
			ReadOnlyInt32List interactionFuncList = readOnlyData3.RoleData.RoleCs.Interaction.InteractionFuncList;
			if (InteractData != null)
			{
				foreach (int item5 in interactionFuncList)
				{
					if (!InteractData.InteractFuncList.Contains(item5))
					{
						continue;
					}
					InteractionFuncDesc interactionFuncDesc = GameDBRuntime.GetInteractionFuncDesc(item5);
					if (interactionFuncDesc == null || interactionFuncDesc.MenuBtnActionType == EMenuBtnActionType.None)
					{
						continue;
					}
					if (interactionFuncDesc.MenuBtnActionType == EMenuBtnActionType.Shop || interactionFuncDesc.MenuBtnActionType == EMenuBtnActionType.ShopBuy || interactionFuncDesc.MenuBtnActionType == EMenuBtnActionType.ShopSell)
					{
						foreach (ReadOnlyShopOne item6 in shopList)
						{
							if (InteractData.ShopID == item6.ShopId)
							{
								flag5 = true;
								break;
							}
						}
						continue;
					}
					flag5 = true;
					break;
				}
			}
			if (flag5)
			{
				if (InteractData.InteractUnitState != EBGUInteractUnitState.BeforeActive)
				{
					UpdateInteractGroup_Internal(InteractData.ActionGroupID, EBGUInteractUnitState.BeforeActive, UpdatePersistent: false);
				}
				InteractData.InteractTipOverride = interactionActionsByGroupID2[0].InteractName;
				list.Add(interactionActionsByGroupID2[0]);
			}
		}
		InteractData.ActionList = list;
		if (list.Count == 1)
		{
			InteractData.InteractTipOverride = list[0].InteractName;
			InteractData.InteractinputTime = list[0].InteractInputTime;
		}
	}

	private void OnRoleItemChange(int ItemID, int OldNum, int NewNum)
	{
		UpdateItemRequireCondition();
	}

	private void OnRoleLegacyChange(int LegacyID)
	{
		UpdateItemRequireCondition();
	}

	private void UpdateItemRequireCondition()
	{
		InteractData.ItemRequireCondition = false;
		if (InteractData.ActionList.Count <= 0)
		{
			return;
		}
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(PlayerController);
		if (readOnlyData == null || readOnlyData.RoleData == null)
		{
			return;
		}
		foreach (FUStInteractCondition item in InteractData.ActionList[0].InteractCondition)
		{
			if (RoleDataHelper.GetBagItemNum(readOnlyData, item.ConditionItemID) < item.ConditionItemNum)
			{
				InteractData.ItemRequireCondition = true;
				break;
			}
		}
	}

	private void InitSubMeshCompCollisionCache()
	{
		SubMeshCompCollisionCache = new Dictionary<UMeshComponent, ECollisionEnabled>();
		List<UActorComponent> componentsByClass = base.Owner.GetComponentsByClass(UClass.GetClass<UMeshComponent>());
		if (componentsByClass == null)
		{
			return;
		}
		foreach (UActorComponent item in componentsByClass)
		{
			UMeshComponent uMeshComponent = item as UMeshComponent;
			if (!uMeshComponent.IsNullOrDestroyed())
			{
				SubMeshCompCollisionCache.Add(uMeshComponent, uMeshComponent.GetCollisionEnabled());
			}
		}
	}

	private void PlayAnimAfterUpdateGroupID()
	{
		if (InteractData.InteractUnitState == EBGUInteractUnitState.BeforeActive && InteractData.ActionGroupID >= 0 && InteractData.ActionList.Count > 0 && InteractData.ActionList[0].ParamsString.Count > 0 && !string.IsNullOrEmpty(InteractData.ActionList[0].InitAnim))
		{
			UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<UAnimMontage>(InteractData.ActionList[0].InitAnim, ELoadResourceType.SyncLoadAndCache);
			if (uAnimMontage != null)
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(base.Owner, uAnimMontage, FName.None, EMontageBindReason.Interact);
				base.BGSEventCollection.Evt_BGS_SetSceneInactiveActorForceActivateTicks.Invoke(base.Owner);
			}
		}
	}

	private void InitSceneCompTransform()
	{
		if (InteractData.SceneCompTransformDict == null || InteractData.SceneCompTransformDict.Count <= 0)
		{
			return;
		}
		List<UActorComponent> list = GetOwner()?.GetComponentsByClass(UClass.GetClass<USceneComponent>());
		if (list == null)
		{
			return;
		}
		foreach (UActorComponent item in list)
		{
			USceneComponent uSceneComponent = item as USceneComponent;
			if (uSceneComponent == null || uSceneComponent.ComponentTags == null || uSceneComponent.ComponentTags.Count <= 0)
			{
				continue;
			}
			foreach (FName componentTag in uSceneComponent.ComponentTags)
			{
				if (InteractData.SceneCompTransformDict.ContainsKey(componentTag))
				{
					uSceneComponent.SetRelativeTransform(InteractData.SceneCompTransformDict[componentTag], bSweep: false, out var _, bTeleport: true);
					break;
				}
			}
		}
	}
}
