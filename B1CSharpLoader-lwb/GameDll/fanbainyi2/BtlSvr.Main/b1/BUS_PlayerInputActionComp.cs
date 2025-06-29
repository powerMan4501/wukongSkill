using System;
using System.Collections.Generic;
using System.Linq;
using ArchiveB1;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using CommB1;
using Diana.Common;
using Google.Protobuf;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

public class BUS_PlayerInputActionComp : UActorCompBaseCS
{
	private static readonly string CAMERA_LOCK = "CAMERA_LOCK";

	private static readonly int TransformSkillFlag = -999;

	private BGW_UIEventCollection UIEC;

	private BUC_PlayerInputActionData PlayerInputActionData;

	private b1.BUC_ComboCacheData ComboCacheData;

	private b1.BUC_ComboWindowData ComboWindowData;

	private BUC_ComboGraphData ComboGraphData;

	private IBUC_ChargeSkillData ChargeSkillData;

	private b1.IBUC_SmartCastSkillData SmartCastSkillData;

	private IBUC_JumpData JumpData;

	private IBUC_FallingData FallingData;

	private IBUC_PlayerInputConfigData PlayerInputConfigData;

	private IBUC_TargetInfoData TargetInfoData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_FallDyingData FallDyingData;

	private IBUC_ABPBodyBlendData BodyBlendData;

	private IBUC_ABPCommonSettingData ABPCommonSettingData;

	private IBUC_ABPCharacterData ChrData;

	private IBUC_BarSockData BarSockData;

	private IBUC_AttrContainer AttrData;

	private IBUC_BuffData BuffData;

	private IBUC_TalentData TalentData;

	private IBUC_PotentialEnergyData PEData;

	private IBUC_MovementData MovementData;

	private IBUC_QiTianDaShengData QiTianDaShengData;

	private b1.IBUC_PoleDrinkData PoleDrinkData;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	private IBGC_GlobalBattleStateData GlobalBattleStateData;

	private IBPC_InputData InputData;

	private IBPC_PlayerRoleData PlayerRoleData;

	private IBPC_PlayerPerformData PlayerPerformData;

	private IBPC_PlayerTagData PlayerTagData;

	private BGW_EffectTemplateList _effectTemplateList;

	private UGameInstance _gameInstance;

	private UCharacterMovementComponent MovementComp;

	private EInputActionType CachedTriggerGraphSuccessAttackKey;

	private Dictionary<EInputActionType, bool> AttackKeyPressStateMap = new Dictionary<EInputActionType, bool>();

	private BGW_EffectTemplateList EffectTemplateList => _effectTemplateList ?? (_effectTemplateList = BGW_EffectTemplateList.Get(Owner));

	private UGameInstance GameInstance => _gameInstance ?? (_gameInstance = UGameplayStatics.GetGameInstance(Owner));

	public override void OnAttach()
	{
		ComboCacheData = RequireWritableData<b1.BUC_ComboCacheData>();
		ComboWindowData = RequireWritableData<b1.BUC_ComboWindowData>();
		PlayerInputActionData = RequireWritableData<BUC_PlayerInputActionData>();
		ComboGraphData = RequireWritableData<BUC_ComboGraphData>();
		PlayerInputConfigData = RequireReadOnlyData<IBUC_PlayerInputConfigData, BUC_PlayerInputConfigData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		BodyBlendData = RequireReadOnlyData<IBUC_ABPBodyBlendData, BUC_ABPBodyBlendData>();
		ABPCommonSettingData = RequireReadOnlyData<IBUC_ABPCommonSettingData, BUC_ABPCommonSettingData>();
		ChrData = RequireReadOnlyData<IBUC_ABPCharacterData, BUC_ABPCharacterData>();
		ChargeSkillData = RequireReadOnlyData<IBUC_ChargeSkillData, BUC_ChargeSkillData>();
		SmartCastSkillData = RequireReadOnlyData<b1.IBUC_SmartCastSkillData, b1.BUC_SmartCastSkillData>();
		JumpData = RequireReadOnlyData<IBUC_JumpData, b1.BUC_JumpData>();
		FallDyingData = RequireReadOnlyData<IBUC_FallDyingData, BUC_FallDyingData>();
		FallingData = RequireReadOnlyData<IBUC_FallingData, BUC_FallingData>();
		BarSockData = RequireReadOnlyData<IBUC_BarSockData, BUC_BarSockData>();
		AttrData = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		TalentData = RequireReadOnlyData<IBUC_TalentData, BUC_TalentData>();
		PEData = RequireReadOnlyData<IBUC_PotentialEnergyData, BUC_PotentialEnergyData>();
		MovementData = RequireReadOnlyData<IBUC_MovementData, BUC_MovementData>();
		QiTianDaShengData = RequireReadOnlyData<IBUC_QiTianDaShengData, BUC_QiTianDaShengData>();
		PoleDrinkData = RequireReadOnlyData<b1.IBUC_PoleDrinkData, BUC_PoleDrinkData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		GlobalBattleStateData = RequireReadOnlyGameStateData<IBGC_GlobalBattleStateData, BGC_GlobalBattleStateData>();
		InputData = RequireReadOnlyControlledPlayerControlData<IBPC_InputData, BPC_InputData>();
		PlayerRoleData = RequireReadOnlyControlledPlayerControlData<IBPC_PlayerRoleData, BPC_PlayerRoleData>();
		PlayerPerformData = RequireReadOnlyControledPlayerStateData<IBPC_PlayerPerformData, BPC_PlayerPerformData>();
		PlayerTagData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(OwnerAsCharacterCS.PlayerState);
		base.BUSEventCollection.Evt_TriggerInputActionImpl += new Del_TriggerInputActionImpl(OnTriggerInputActionImpl);
		base.BUSEventCollection.Evt_InputCastSkill += new Del_InputCastSkill(OnInputCastSkill);
		base.BUSEventCollection.Evt_TriggerItemSkillAction_ShortCut += new Del_TriggerItemSkillAction_ShortCut(OnTriggerItemSkillAction_ShortCut);
		base.BUSEventCollection.Evt_TriggerItemSkillAction_UseItem += new Del_TriggerItemSkillAction_UseItem(OnTriggerItemSkillAction_UseItem);
		base.BUSEventCollection.Evt_SetPressedSprinting += new Del_Void_Bool(OnSetPressedSprinting);
		base.BUSEventCollection.Evt_CameraLockTarget += new Del_CameraLockTarget(OnCameraLockTarget);
		base.BUSEventCollection.Evt_ClearCameraLock += new Del_Void(OnClearCameraLock);
		base.BUSEventCollection.Evt_TrySwitchCameraLockTarget += new Del_TrySwitchCameraLockTarget(OnTrySwitchCameraLockTarget);
		base.BUSEventCollection.Evt_StopSlotAnimation += new Del_Void_Float(OnStopSlotAnimation);
		base.BUSEventCollection.Evt_TriggerChargeSkillNextStageEvent += new Del_TriggerChargeSkillNextStageEvent(OnTriggerChargeSkillEndEvent);
		base.BUSEventCollection.Evt_InputKeyCacheStart += new Del_EnterInputKeyCacheWindow(OnInputKeyCacheStart);
		base.BUSEventCollection.Evt_ClearComboKeyCache += new Del_Void(OnClearKeyCache);
		base.BUSEventCollection.Evt_ComboGraphReset += new Del_Void(OnComboGraphReset);
		base.BUSEventCollection.Evt_ComboGraphTryTriggerChargeSkillTimeOut += new Del_Void(OnComboGraphTryTriggerChargeSkillTimeOut);
		base.BUSEventCollection.Evt_TriggerComboWindow += new Del_TriggerComboWindow(OnTriggerComboWindow);
		base.BUSEventCollection.Evt_SetItemSkillWhiteList += new Del_Void_IntList(OnSetItemSkillWhiteList);
		base.BUSEventCollection.Evt_TriggerResetAllActors += new Del_Void(OnTriggerResetAllActors);
		base.BUSEventCollection.Evt_OnWeaponStanceSwitchSuccess += new Del_Void(OnWeaponStanceSwitchSuccess);
		base.BUSEventCollection.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnPlayMontageCallback);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_PostInputMappingContextRegister = (BGW_EventCollection.Del_PostInputMappingContextRegister)Delegate.Combine(bGWEventCollection.Evt_PostInputMappingContextRegister, new BGW_EventCollection.Del_PostInputMappingContextRegister(OnPostInputMappingContextRegister));
		UIEC = BGW_UIEventCollection.Get(GetOwner());
	}

	public override void PreBeginPlay()
	{
		ComboGraphData.NodeActions.Add(B1CalliopeDef.ComboNode.Start, OnTriggerStartNode);
		ComboGraphData.NodeActions.Add(B1CalliopeDef.ComboNode.Idle, OnTriggerIdleNode);
		ComboGraphData.NodeActions.Add(B1CalliopeDef.ComboNode.Reroute, OnTriggerRerouteNode);
		ComboGraphData.NodeActions.Add(B1CalliopeDef.ComboNode.Skill, OnTriggerSkillNode);
		ComboGraphData.NodeActions.Add(B1CalliopeDef.ComboNode.Condition, OnTriggerConditionNode);
		ComboGraphData.NodeActions.Add(B1CalliopeDef.ComboNode.Restart, OnTriggerRestartNode);
		ComboGraphData.RestartCommandList.Add(B1ComboEventDef.COMBO_EVENT_COMBO_RESTART.PlainName);
		ComboGraphData.RestartCommandList.Add(B1ComboEventDef.COMBO_EVENT_COMBO_TIMEOUT.PlainName);
		MovementComp = OwnerAsCharacterCS.CharacterMovement;
		PlayerInputActionData.bInPressedSpinModeState = false;
	}

	public override void OnBeginPlay()
	{
		if (ComboGraphData.DefaultTemplate != null)
		{
			ComboGraphData.CurrentInstance = FCalliopeAssetReference.CreateInstance(Owner, ECalliopeAssetType.Combo, ComboGraphData.DefaultTemplate);
			if (ComboGraphData.CurrentInstance != null)
			{
				ComboGraphData.CurrentInstance.StartInstance();
			}
		}
		OnGraphStart();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_PostInputMappingContextRegister = (BGW_EventCollection.Del_PostInputMappingContextRegister)Delegate.Remove(bGWEventCollection.Evt_PostInputMappingContextRegister, new BGW_EventCollection.Del_PostInputMappingContextRegister(OnPostInputMappingContextRegister));
		OnGraphEnd();
	}

	public override int GetTickGroupMask()
	{
		return 192;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		switch (TickGroup)
		{
		case 64:
		{
			FVector MoveInputAxis = new FVector(GetSidewaysInputAxisValue(), GetForwardInputAxisValue(), GetUpwardInputAxisValue());
			TickAllPlayerControl(DeltaTime);
			TickInputForMoving(in MoveInputAxis, DeltaTime);
			TickCanClearCameraLock();
			TickShouldChangeCameraLockType();
			TickForDebugInfo();
			TickForKeyCache(DeltaTime);
			break;
		}
		case 128:
			TryTriggerRealDodge();
			break;
		}
	}

	private void TickAllPlayerControl(float DeltaTime)
	{
		PlayerInputActionData.DeltaTime = DeltaTime;
		if (OwnerAsCharacterCS == null)
		{
			return;
		}
		APlayerController playerController = OwnerAsCharacterCS.World.GetPlayerController(0);
		if (!(playerController == null))
		{
			base.BUSEventCollection.Evt_SetLocalControlled.Invoke(OwnerAsCharacterCS.IsLocallyControlled());
			if (BGUFuncLibInput.BGUIsCanReceiveBattleInput(OwnerAsCharacterCS))
			{
				playerController.ResetIgnoreMoveInput();
			}
		}
	}

	private void TickInputForMoving(in FVector MoveInputAxis, float DeltaTime)
	{
		if (FMath.Abs(MoveInputAxis.Y) > 0.3f || FMath.Abs(MoveInputAxis.X) > 0.3f || FMath.Abs(MoveInputAxis.Z) > 0.3f)
		{
			PlayerInputActionData.IsWithInputMoving = true;
		}
		else
		{
			PlayerInputActionData.IsWithInputMoving = false;
		}
		TickForSkillEndingWithMoving(PlayerInputActionData.IsWithInputMoving, PlayerInputConfigData.GSCameraAutoLockSetting.SkillResumeMoveBlendTime);
		if (UnitStateData.HasState(EBGUUnitState.Sprinting) && !PlayerInputActionData.bPressedSprinting)
		{
			if (PlayerInputActionData.MoveWeakInputTimer >= 0.3f)
			{
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.UnitInputSprintRelease, -1f);
			}
			if (UnitStateData.HasState(EBGUUnitState.Attacking) && !UnitStateData.HasState(EBGUUnitState.AttackMoving))
			{
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.UnitInputSprintRelease, -1f);
			}
		}
		if (MoveInputAxis.Size() < 0.5f)
		{
			PlayerInputActionData.MoveWeakInputTimer += DeltaTime;
		}
		else
		{
			PlayerInputActionData.MoveWeakInputTimer = 0f;
		}
	}

	private void TickForSkillEndingWithMoving(bool IsWithInputMoving, float BlendTime)
	{
		if (!InputCheckState())
		{
			return;
		}
		if (OwnerAsCharacterCS == null)
		{
			BGW_LogUtil.LogError("OwnerAsCharacterCS is nullptr");
		}
		else
		{
			if (!OwnerAsCharacterCS.IsPlayerControlled())
			{
				return;
			}
			if (UnitStateData == null)
			{
				BGW_LogUtil.LogError("UnitStateData is nullptr");
				return;
			}
			UAnimInstance uAnimInstance = null;
			USkeletalMeshComponent mesh = OwnerAsCharacterCS.Mesh;
			if (mesh != null)
			{
				uAnimInstance = mesh.GetAnimInstance();
			}
			if (uAnimInstance == null)
			{
				BGW_LogUtil.LogError("Can't Find AnimInstance Failed");
				return;
			}
			bool flag = false;
			if (IsWithInputMoving && uAnimInstance.IsAnyMontagePlaying())
			{
				flag = true;
				if (UnitStateData.HasState(EBGUUnitState.ImpactActionPlaying))
				{
					flag = false;
				}
				if (BodyBlendData != null && BodyBlendData.bEnableAnimCurveBodySeparation)
				{
					flag = false;
				}
				if (UnitStateData.HasState(EBGUUnitState.LifeSavingHair_FakeDead) || UnitStateData.HasState(EBGUUnitState.LifeSavingHair_Rebirth) || UnitStateData.HasState(EBGUUnitState.Dead))
				{
					flag = false;
				}
			}
			if (flag)
			{
				base.BUSEventCollection.Evt_StopSlotAnimation.Invoke(BlendTime);
			}
		}
	}

	private void TickCanClearCameraLock()
	{
		if (PlayerPerformData.IsInPerformState())
		{
			return;
		}
		UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
		if (targetInfo.IsValidManualTargetInfo())
		{
			bool flag = false;
			bool flag2 = false;
			BGUCharacterCS bGUCharacterCS = targetInfo.LockTargetActor as BGUCharacterCS;
			if (bGUCharacterCS.IsNullOrDestroyed())
			{
				flag = true;
			}
			else if (BGUFunctionLibraryCS.BGUIsUnitDead(bGUCharacterCS))
			{
				var (aActor, skeletonSocketName) = FindBestTargetInScreen(bGUCharacterCS);
				if (aActor != null)
				{
					OnCameraLockTarget(new UnitLockTargetInfo(aActor, ETargetSourceType.None, ELockTargetWayType.Manual, "", skeletonSocketName));
					return;
				}
				flag = true;
			}
			else
			{
				IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(bGUCharacterCS);
				if (IsCameraLockTargetTooFar(bGUCharacterCS))
				{
					flag = true;
				}
				else if (SimpleStateData.HasSimpleState(EBGUSimpleState.PlayerCantLock))
				{
					flag = true;
				}
				else if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.CantBeLock))
				{
					flag = true;
				}
				else if (readOnlyData != null && ((targetInfo.LockTargetType == ELockTargetType.SkeletonSocket && readOnlyData.DisabledLockSkeletonSocket.Contains(targetInfo.LockTargetSkeletonSocketName)) || (targetInfo.LockTargetType == ELockTargetType.Actor && readOnlyData.DisabledLockSkeletonSocket.Contains(CAMERA_LOCK))))
				{
					flag = true;
					flag2 = true;
				}
			}
			if (flag)
			{
				OnClearCameraLock();
			}
			if (flag2)
			{
				BGUFuncLibInput.BGUInputCameraLockTarget(Owner, bGUCharacterCS);
			}
		}
		else if (!UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			OnClearCameraLock();
		}
	}

	private (AActor, string) FindBestTargetInScreen(AActor PreLockTarget)
	{
		AActor aActor = null;
		string item = "";
		if (BGW_SettingFuncUtil.GetSettingBoolValueByType(GetOwner(), UISettingConfigType.AutoLockNewTarget))
		{
			float maxCamLockTargetDistance = PlayerInputConfigData.GSCameraAutoLockSetting.MaxCamLockTargetDistance;
			UBGUSelectUtil.SphereOverlapBGUCharacters(Owner, BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), maxCamLockTargetDistance, out var OutArray);
			APlayerController firstLocalPlayerController = UnrealGameplayData.GetFirstLocalPlayerController();
			if (firstLocalPlayerController != null)
			{
				FVector actorLocation = firstLocalPlayerController.GetControlledPawn().GetActorLocation();
				FVector2D fVector2D = UWidgetLayoutLibrary.GetViewportSize(firstLocalPlayerController) / UWidgetLayoutLibrary.GetViewportScale(firstLocalPlayerController);
				IBGC_CircusControlData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_CircusControlData>(UGameplayStatics.GetGameState(Owner));
				float num = float.MaxValue;
				for (int i = 0; i < OutArray.Count; i++)
				{
					BGUCharacterCS bGUCharacterCS = OutArray[i] as BGUCharacterCS;
					if (!(bGUCharacterCS != Owner) || BGUFunctionLibraryCS.BGUIsUnitDead(bGUCharacterCS) || !BGUFunctionLibraryCS.BGUIsEnemyTeam(Owner, bGUCharacterCS))
					{
						continue;
					}
					IBUC_TargetInfoData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(bGUCharacterCS);
					if (readOnlyData2 == null || BGW_GameDB.GetUnitCommDesc(bGUCharacterCS.GetResID()) == null)
					{
						continue;
					}
					foreach (string item2 in readOnlyData2.CachedLockSkeletonSocket)
					{
						if (bGUCharacterCS == PreLockTarget || readOnlyData2.DisabledLockSkeletonSocket.Contains(item2))
						{
							continue;
						}
						FVector socketLocation = bGUCharacterCS.Mesh.GetSocketLocation(new FName(item2));
						UWidgetLayoutLibrary.ProjectWorldLocationToWidgetPosition(firstLocalPlayerController, socketLocation, out var ScreenPosition, bPlayerViewportRelative: false);
						if (ScreenPosition.X <= 0f || ScreenPosition.Y <= 0f || ScreenPosition.X >= fVector2D.X || ScreenPosition.Y >= fVector2D.Y)
						{
							continue;
						}
						float num2 = FVector.Dist(socketLocation, actorLocation);
						int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.AutoLockDistance);
						if (!((float)commLogicCfgValue <= num2) && CheckCanSelectTarget(Owner, bGUCharacterCS, item2, readOnlyData, num2))
						{
							if (aActor == null && (float)commLogicCfgValue > num2)
							{
								num = num2;
								item = item2;
								aActor = bGUCharacterCS;
							}
							else if (num >= num2)
							{
								num = num2;
								item = item2;
								aActor = bGUCharacterCS;
							}
						}
					}
				}
			}
		}
		return (aActor, item);
	}

	private bool CheckCanSelectTarget(AActor Player, BGUCharacterCS NewTarget, string Socket, IBGC_CircusControlData TamerFamilyTreeData, float Dist)
	{
		ACharacter aCharacter = Player as ACharacter;
		if (aCharacter != null)
		{
			FVector socketLocation = NewTarget.Mesh.GetSocketLocation(new FName(Socket));
			aCharacter.GetController().GetPlayerViewPoint(out var Location, out var _);
			UBGUSelectUtil.LineTraceSimple(Owner, Location, socketLocation, ETraceTypeQuery.TraceTypeQuery1, bDebug: false, out var HitResult, new List<AActor> { NewTarget });
			if (HitResult.IsBlockingHit)
			{
				if (TamerFamilyTreeData == null)
				{
					return false;
				}
				if (!TamerFamilyTreeData.IsInSameCircus(NewTarget, HitResult.HitActor))
				{
					return false;
				}
			}
			FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(NewTarget.GetResID());
			if (unitCommDesc != null)
			{
				float cameraLockDist = unitCommDesc.CameraLockDist;
				if (Dist > cameraLockDist)
				{
					return false;
				}
			}
		}
		return true;
	}

	private void TickShouldChangeCameraLockType()
	{
		UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
		if (targetInfo.LockTargetWayType != ELockTargetWayType.Manual)
		{
			return;
		}
		AActor lockTargetActor = targetInfo.LockTargetActor;
		IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(lockTargetActor);
		if (readOnlyData == null)
		{
			return;
		}
		int num = readOnlyData.CachedLockSkeletonSocket.Count - readOnlyData.DisabledLockSkeletonSocket.Count;
		if (targetInfo.LockTargetType == ELockTargetType.Point)
		{
			return;
		}
		UnitLockTargetInfo unitLockTargetInfo = null;
		switch (targetInfo.LockTargetType)
		{
		case ELockTargetType.Actor:
			if (num > 1)
			{
				unitLockTargetInfo = new UnitLockTargetInfo(lockTargetActor, ETargetSourceType.CameraLockUpdate, ELockTargetWayType.Manual, "", CAMERA_LOCK);
			}
			break;
		case ELockTargetType.SkeletonSocket:
			if (num <= 0)
			{
				unitLockTargetInfo = new UnitLockTargetInfo(lockTargetActor, ETargetSourceType.CameraLockUpdate);
			}
			break;
		}
		if (unitLockTargetInfo != null)
		{
			BGUFunctionLibraryCS.BGUSetTargetInfo(IsOnline(), Owner, unitLockTargetInfo);
		}
	}

	private void TickForDebugInfo()
	{
		if (!DebugConfig.InputDebugInfo)
		{
			return;
		}
		string text = "";
		string text2 = "";
		foreach (KeyValuePair<int, AttackWindowInfo> item in ComboWindowData.AttackWindowInfoDict)
		{
			int key = item.Key;
			AttackWindowInfo value = item.Value;
			foreach (int whiteListComboSkillID in value.WhiteListComboSkillIDList)
			{
				text += $"{whiteListComboSkillID}(G:{key})；";
			}
			foreach (int blackListComboSkillID in value.BlackListComboSkillIDList)
			{
				text2 += $"{blackListComboSkillID}(G:{key})；";
			}
		}
		base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("InputDebug_KeyCache", "Combo白名单", (text.Length > 0) ? text : "无");
		base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("InputDebug_KeyCache", "Combo黑名单", (text2.Length > 0) ? text2 : "无");
		string text3 = "";
		foreach (int itemSkillWhite in ComboWindowData.ItemSkillWhiteList)
		{
			text3 += $"{itemSkillWhite}；";
		}
		base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("InputDebug_KeyCache", "ItemSkill白名单", (text3.Length > 0) ? text3 : "无");
		base.BUSEventCollection.Evt_UpdateDebugUITitle.Invoke("InputDebug_KeyCache", "按键缓存");
		base.BUSEventCollection.Evt_UpdateDebugUILamp.Invoke("InputDebug_KeyCache", (ComboCacheData.ComboKeyStack.Count > 0) ? B1GlobalFSlateColor.Green : B1GlobalFSlateColor.Red);
		ComboKeyInfo[] array = ComboCacheData.ComboKeyStack.ToArray();
		for (int i = 1; i <= 4; i++)
		{
			string value2 = "";
			if (i > array.Length)
			{
				value2 = "---";
			}
			else
			{
				ComboKeyInfo comboKeyInfo = array[i - 1];
				if (comboKeyInfo != null)
				{
					EInputActionType inputActionType = comboKeyInfo.InputActionType;
					bool isRelease = comboKeyInfo.IsRelease;
					string text4 = " (";
					if (comboKeyInfo.GroupIDList != null && comboKeyInfo.GroupIDList.Count > 0)
					{
						foreach (int groupID in comboKeyInfo.GroupIDList)
						{
							text4 += $"{groupID}；";
						}
					}
					value2 = (isRelease ? $"{inputActionType} IsRelease" : $"{inputActionType} IsPress");
					value2 = value2 + text4 + ")";
				}
			}
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("InputDebug_KeyCache", value2, i - 1);
		}
		string text5 = "";
		if (UnitStateData.HasState(EBGUUnitState.InComboWindow))
		{
			text5 = "触发;";
		}
		if (UnitStateData.HasState(EBGUUnitState.AtkComboKeyCache))
		{
			text5 += "缓存";
		}
		base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("InputDebug_Window", "ComboWindow状态", text5);
		string text6 = "";
		if (UnitStateData.HasState(EBGUUnitState.InDodgeWindow))
		{
			text6 = "触发;";
		}
		if (UnitStateData.HasState(EBGUUnitState.DodgeComboKeyCache))
		{
			text6 += "缓存";
		}
		base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("InputDebug_Window", "DodgeWindow状态", text6);
		string text7 = "";
		if (UnitStateData.HasState(EBGUUnitState.InMagicWindow))
		{
			text7 = "触发;";
		}
		if (UnitStateData.HasState(EBGUUnitState.MagicKeyCache))
		{
			text7 += "缓存";
		}
		base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("InputDebug_Window", "MagicWindow状态", text7);
		string text8 = "";
		if (UnitStateData.HasState(EBGUUnitState.InVigorWindow))
		{
			text8 = "触发;";
		}
		if (UnitStateData.HasState(EBGUUnitState.VigorKeyCache))
		{
			text8 += "缓存";
		}
		base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("InputDebug_Window", "VigorWindow状态", text8);
		string text9 = "";
		if (UnitStateData.HasState(EBGUUnitState.InItemSkillWindow))
		{
			text9 = "触发;";
		}
		if (UnitStateData.HasState(EBGUUnitState.ItemSkillKeyCache))
		{
			text9 += "缓存";
		}
		base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("InputDebug_Window", "ItemSkillWindow状态", text9);
		string value3 = "无";
		if (ChargeSkillData.IsCastingChargeSkill)
		{
			switch (ChargeSkillData.ChargeSkillStage)
			{
			case EChargeSkillStage.None:
				value3 = "异常";
				break;
			case EChargeSkillStage.Begin:
				value3 = "起始段";
				break;
			case EChargeSkillStage.Loop:
				value3 = "循环段";
				break;
			case EChargeSkillStage.End:
				value3 = "结束段";
				break;
			}
		}
		base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("InputDebug_Window", "蓄力技能状态", value3);
	}

	private void TickForKeyCache(float DeltaTime)
	{
		ComboWindowData.UpdateWindowInfo(DeltaTime, UnitStateData.HasState(EBGUUnitState.InComboWindow), UnitStateData.HasState(EBGUUnitState.InItemSkillWindow));
		ComboCacheData.TryConsumeAttackKeyGroupID = 0;
		ETriggerEventReturnType eTriggerEventReturnType = ETriggerEventReturnType.NotTriggered;
		if (UnitStateData.HasState(EBGUUnitState.Attacking) || UnitStateData.HasState(EBGUUnitState.Beatback))
		{
			while (!ComboCacheData.IsComboKeyStackEmpty())
			{
				ComboKeyInfo lastComboKey = ComboCacheData.GetLastComboKey();
				EInputActionType inputActionType = lastComboKey.InputActionType;
				bool isRelease = lastComboKey.IsRelease;
				if (IsAttackKey(inputActionType))
				{
					if (ChargeSkillData.IsCastingChargeSkill)
					{
						if (ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Loop)
						{
							eTriggerEventReturnType = (TriggerComboGraphInputEvent(inputActionType, isRelease) ? ETriggerEventReturnType.TriggerSucceeded : ETriggerEventReturnType.TriggerFailed);
						}
						else if (ChargeSkillData.ChargeSkillStage == EChargeSkillStage.End && UnitStateData.HasState(EBGUUnitState.InComboWindow))
						{
							eTriggerEventReturnType = TryConsumeAttackCachedKey(lastComboKey);
						}
					}
					else if (UnitStateData.HasState(EBGUUnitState.InComboWindow))
					{
						eTriggerEventReturnType = ((!(CachedTriggerGraphSuccessAttackKey == inputActionType && isRelease)) ? TryConsumeAttackCachedKey(lastComboKey) : ETriggerEventReturnType.TriggerFailed);
					}
				}
				else if (inputActionType == EInputActionType.Dodge)
				{
					if (UnitStateData.HasState(EBGUUnitState.InDodgeWindow))
					{
						float num = InputData.GetInputValue(GSBattleActionEn.MoveSideways);
						float num2 = InputData.GetInputValue(GSBattleActionEn.MoveForward);
						float dodgeInputFixLine = PlayerInputConfigData.DodgeInputFixLine;
						if (FMath.IsNearlyZero(num) && FMath.IsNearlyZero(num2))
						{
							num = ComboCacheData.LastCacheDodgeInputDir.X;
							num2 = ComboCacheData.LastCacheDodgeInputDir.Y;
						}
						TriggerDodge(BGUFuncLibInput.CalcInputDir(num, num2, dodgeInputFixLine));
						eTriggerEventReturnType = ETriggerEventReturnType.TriggerSucceeded;
					}
				}
				else if (IsSkillKey(inputActionType))
				{
					if (UnitStateData.HasState(EBGUUnitState.InMagicWindow))
					{
						TriggerMagicSkill(ComboCacheData.LastMagicSkillID);
						eTriggerEventReturnType = ETriggerEventReturnType.TriggerSucceeded;
					}
				}
				else if (inputActionType == EInputActionType.UseVigorSkill)
				{
					if (UnitStateData.HasState(EBGUUnitState.InVigorWindow))
					{
						TriggerVigorSkill();
						eTriggerEventReturnType = ETriggerEventReturnType.TriggerSucceeded;
					}
				}
				else if (IsItemSkillKey(inputActionType) && UnitStateData.HasState(EBGUUnitState.InItemSkillWindow))
				{
					TriggerItemSkill();
					eTriggerEventReturnType = ETriggerEventReturnType.TriggerSucceeded;
				}
				bool flag = false;
				switch (eTriggerEventReturnType)
				{
				case ETriggerEventReturnType.TriggerSucceeded:
					flag = true;
					OnClearKeyCache();
					break;
				case ETriggerEventReturnType.TriggerFailed:
					ComboCacheData.PopLastComboKey();
					break;
				case ETriggerEventReturnType.NotTriggered:
					flag = true;
					break;
				}
				if (flag)
				{
					break;
				}
			}
		}
		else if (ComboCacheData.ComboKeyStack.Count > 0)
		{
			OnClearKeyCache();
		}
		if (eTriggerEventReturnType != ETriggerEventReturnType.TriggerSucceeded)
		{
			if ((!ChargeSkillData.IsCastingChargeSkill || ChargeSkillData.ChargeSkillStage == EChargeSkillStage.End) && !UnitStateData.HasState(EBGUUnitState.Attacking) && !UnitStateData.HasState(EBGUUnitState.Beatback) && !IsComboFSMInIdleState() && !SmartCastSkillData.IsInAttackRunTracing)
			{
				eTriggerEventReturnType = (TriggerComboGraphConditionEvent(B1ComboEventDef.COMBO_EVENT_COMBO_TIMEOUT) ? ETriggerEventReturnType.TriggerSucceeded : ETriggerEventReturnType.TriggerFailed);
			}
			if (eTriggerEventReturnType != ETriggerEventReturnType.TriggerSucceeded && !IsComboFSMInIdleState() && CachedTriggerGraphSuccessAttackKey != EInputActionType.None && ChargeSkillData.IsCastingChargeSkill && ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Loop)
			{
				bool flag2 = true;
				if (AttackKeyPressStateMap.TryGetValue(CachedTriggerGraphSuccessAttackKey, out var value))
				{
					flag2 = !value;
				}
				if (flag2)
				{
					TriggerComboGraphInputEvent(CachedTriggerGraphSuccessAttackKey, IsRelease: true);
				}
			}
		}
		if (ChargeSkillData.IsCastingChargeSkill)
		{
			bool flag3 = false;
			bool isRelease2 = true;
			float inputValue = InputData.GetInputValue(GSBattleActionEn.MoveForward);
			if (inputValue > 0f && ComboCacheData.LastAxisMoveForward <= 0f)
			{
				flag3 = true;
				isRelease2 = false;
			}
			else if (inputValue <= 0f && ComboCacheData.LastAxisMoveForward > 0f)
			{
				flag3 = true;
				isRelease2 = true;
			}
			if (flag3)
			{
				DoAttackLogic(EInputActionType.SpinModeMoveForward, isRelease2);
			}
		}
		ComboCacheData.LastAxisMoveForward = InputData.GetInputValue(GSBattleActionEn.MoveForward);
	}

	private T GetNodeCustomData<T>(FCalliopeNode Node) where T : IMessage, new()
	{
		Guid nodeGuid = Node.NodeGuid;
		if (ComboGraphData.NodeCustomDataCache.ContainsKey(nodeGuid))
		{
			return (T)ComboGraphData.NodeCustomDataCache[nodeGuid];
		}
		T val = new T();
		if (Node.NodeData != null)
		{
			val.MergeFrom(Node.NodeData);
		}
		ComboGraphData.NodeCustomDataCache.Add(nodeGuid, val);
		return val;
	}

	private void OnGraphRestart()
	{
		_ = ComboGraphData.bEnableDebug;
		if (ComboGraphData.CurrentInstance != null)
		{
			ComboGraphData.CurrentInstance.ClearRecordData();
		}
		OnGraphStart();
	}

	private void OnGraphRestart(string RestartCommand)
	{
		if (ComboGraphData.CurrentGraph != null && ComboGraphData.CurrentGraph.Nodes.Count != 0)
		{
			OnGraphRestart();
			TriggerComboEvent(RestartCommand);
		}
	}

	private void OnGraphStart()
	{
		if (ComboGraphData.CurrentGraph != null && ComboGraphData.CurrentGraph.Nodes.Count != 0)
		{
			FCalliopeNode startNode = ComboGraphData.CurrentGraph.GetStartNode();
			if (startNode != null)
			{
				OnExecuteNode(startNode, "");
				CachedTriggerGraphSuccessAttackKey = EInputActionType.None;
			}
		}
	}

	private void OnGraphEnd()
	{
		if (ComboGraphData.CurrentGraph != null && ComboGraphData.CurrentGraph.Nodes.Count != 0)
		{
			if (ComboGraphData.CurrentInstance != null)
			{
				ComboGraphData.CurrentInstance.FinishInstance();
				ComboGraphData.CurrentInstance = null;
			}
			ComboGraphData.CurrentNode = null;
			ComboGraphData.CurrentGraph = null;
		}
	}

	private bool TriggerComboEvent(string EventName)
	{
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) || SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen))
		{
			return false;
		}
		if (ComboGraphData.RestartCommandList.Contains(EventName) && ComboGraphData.CurrentNode != null && ComboGraphData.CurrentNode.InputEdges.Count > 0)
		{
			OnGraphRestart();
			return true;
		}
		OnExecuteCurrentNode(EventName);
		if (ComboGraphData.bHasOutputPin && ComboGraphData.bTriggerConditionResult)
		{
			return ComboGraphData.bTriggerSkillResult;
		}
		return false;
	}

	private void OnExecuteEdge(FCalliopeEdge Edge)
	{
		if (ComboGraphData.CurrentInstance != null)
		{
			ComboGraphData.CurrentInstance.RecordOutput(Edge.From.NodeGuid, Edge.FromPinName);
			ComboGraphData.CurrentInstance.DeactivateNode(Edge.From.NodeGuid);
		}
		OnExecuteNode(Edge.To, Edge.ToPinName);
	}

	private void OnExecuteNode(FCalliopeNode Node, string InputPin)
	{
		if (ComboGraphData.NodeActions.ContainsKey(Node.NodeClass))
		{
			ComboGraphData.NodeActions[Node.NodeClass](Node, InputPin);
			if (ComboGraphData.CurrentInstance != null)
			{
				ComboGraphData.CurrentInstance.RecordInput(Node.NodeGuid, InputPin);
			}
		}
	}

	private void OnExecuteCurrentNode(string EventName)
	{
		ComboGraphData.bHasOutputPin = true;
		FCalliopeNode currentNode = ComboGraphData.CurrentNode;
		if (currentNode == null || !currentNode.OutputEdges.ContainsKey(EventName))
		{
			ComboGraphData.bHasOutputPin = false;
			return;
		}
		_ = ComboGraphData.bEnableDebug;
		OnExecuteEdge(currentNode.OutputEdges[EventName]);
	}

	private void SetCurrentNode(FCalliopeNode Node, bool InIsComboSubIdle)
	{
		if (Node != null)
		{
			ComboCacheData.IsComboSubIdle = InIsComboSubIdle;
			ComboGraphData.CurrentNode = Node;
		}
	}

	private bool CheckCondition(FCalliopeNode Node)
	{
		List<CalliopeCustom_ComboCondition> list = GetNodeCustomData<ComboCustom_Start>(Node).ComboConditions.ToList();
		for (int i = 0; i < list.Count; i++)
		{
			CalliopeCustom_ComboCondition calliopeCustom_ComboCondition = list[i];
			if (IsConditionSuccess(calliopeCustom_ComboCondition))
			{
				string key = ((!string.IsNullOrEmpty(calliopeCustom_ComboCondition.ConditionIdentity)) ? calliopeCustom_ComboCondition.ConditionIdentity : i.ToString());
				if (Node.OutputEdges.ContainsKey(key))
				{
					OnExecuteEdge(Node.OutputEdges[key]);
					return true;
				}
			}
		}
		return false;
	}

	private void OnTriggerStartNode(FCalliopeNode Node, string InputPin)
	{
		ComboGraphData.bTriggerConditionResult = true;
		if (!CheckCondition(Node))
		{
			if (Node.OutputEdges.TryGetValue(B1CalliopeDef.Common.DefaultConditionPinName, out var value))
			{
				OnExecuteEdge(value);
				return;
			}
			BGW_LogUtil.LogError("Start节点没有条件能满足且也没有连Default！！！！！");
			ComboGraphData.bTriggerConditionResult = false;
		}
	}

	private void OnTriggerIdleNode(FCalliopeNode Node, string InputPin)
	{
		SetCurrentNode(Node, InIsComboSubIdle: true);
	}

	private void OnTriggerRerouteNode(FCalliopeNode Node, string InputPin)
	{
		OnExecuteEdge(Node.OutputEdges.Values.First());
	}

	private void OnTriggerSkillNode(FCalliopeNode Node, string InputPin)
	{
		ComboGraphData.bTriggerSkillResult = true;
		ComboCustom_Skill nodeCustomData = GetNodeCustomData<ComboCustom_Skill>(Node);
		int skillId = nodeCustomData.SkillId;
		if (UnitStateData.HasState(EBGUUnitState.InComboWindow) && !ComboWindowData.CanSkillCombo(skillId, ComboCacheData.TryConsumeAttackKeyGroupID))
		{
			ComboGraphData.bTriggerSkillResult = false;
			return;
		}
		SetCurrentNode(Node, InIsComboSubIdle: false);
		_ = ComboGraphData.bEnableDebug;
		List<int> mappingRuleIDList = nodeCustomData.SkillMappingRuleIdList.ToList();
		if (BGUFunctionLibraryCS.BGUTrySmartCastSpell(GetOwner(), skillId, mappingRuleIDList) != 0)
		{
			ComboGraphData.bTriggerSkillResult = false;
			_ = ComboGraphData.bEnableDebug;
			OnGraphRestart();
		}
	}

	private void OnTriggerConditionNode(FCalliopeNode Node, string InputPin)
	{
		ComboGraphData.bTriggerConditionResult = true;
		if (!CheckCondition(Node))
		{
			if (Node.OutputEdges.TryGetValue(B1CalliopeDef.Common.DefaultConditionPinName, out var value))
			{
				OnExecuteEdge(value);
				return;
			}
			OnGraphRestart();
			ComboGraphData.bTriggerConditionResult = false;
		}
	}

	private void OnTriggerRestartNode(FCalliopeNode Node, string InputPin)
	{
		if (string.IsNullOrEmpty(InputPin) || InputPin == B1CalliopeDef.Common.DefaultInputPinName)
		{
			OnGraphRestart();
		}
		else
		{
			OnGraphRestart(InputPin);
		}
	}

	private bool IsConditionSuccess(CalliopeCustom_ComboCondition ComboCondition)
	{
		return (EComboConditionType)(byte)ComboCondition.ConditionType switch
		{
			EComboConditionType.UnitAttr => OnCheckUnitAttr(ComboCondition), 
			EComboConditionType.SimpleState => OnCheckSimpleState(ComboCondition), 
			EComboConditionType.UnitState => OnCheckUnitState(ComboCondition), 
			EComboConditionType.HasBuff => OnCheckBuff(ComboCondition), 
			EComboConditionType.PotentialEnergy => OnCheckPotentialEnergy(ComboCondition), 
			EComboConditionType.Charge => OnCheckCharge(ComboCondition), 
			EComboConditionType.CeilingHeight => OnCheckCeilingHeight(ComboCondition), 
			EComboConditionType.HasTalent => OnCheckTalent(ComboCondition), 
			EComboConditionType.StanceType => OnCheckStanceType(ComboCondition), 
			EComboConditionType.IsFalling => OnCheckIsFalling(ComboCondition), 
			EComboConditionType.InJumpUpper => OnCheckInJumpUpper(ComboCondition), 
			EComboConditionType.NotInStrideUpJump => OnCheckNotInStrideUpJump(ComboCondition), 
			EComboConditionType.AirSkillCount => CheckAirSkillCount(ComboCondition), 
			EComboConditionType.FlooDistance => CheckFlooDistance(ComboCondition), 
			EComboConditionType.MoveMode => CheckMoveMode(ComboCondition), 
			EComboConditionType.HasMoveInput => ChecHasMoveInput(ComboCondition), 
			EComboConditionType.InLittleMonkeyStage => CheckDaShengStage(ComboCondition, EDaShengStage.LittleMonkey), 
			EComboConditionType.InPreDaShengStage => CheckDaShengStage(ComboCondition, EDaShengStage.PreStage), 
			EComboConditionType.InDaShengStage => CheckDaShengStage(ComboCondition, EDaShengStage.DaShengMode), 
			EComboConditionType.InPressedSpinModeState => CheckPressedSpinModeState(ComboCondition), 
			_ => false, 
		};
	}

	private bool OnCheckUnitAttr(CalliopeCustom_ComboCondition ComboCondition)
	{
		if (AttrData == null)
		{
			return false;
		}
		float floatValue = AttrData.GetFloatValue((EBGUAttrFloat)ComboCondition.AttrFloatType);
		float floatValMin = AttrData.GetFloatValMin((EBGUAttrFloat)ComboCondition.AttrFloatType);
		float floatValMax = AttrData.GetFloatValMax((EBGUAttrFloat)ComboCondition.AttrFloatType);
		float num = (floatValue - floatValMin) / (floatValMax - floatValMin) * 100f;
		bool result = false;
		float compareValue = ComboCondition.CompareValue;
		switch ((EValueCompareOperations)(byte)ComboCondition.CompareOperation)
		{
		case EValueCompareOperations.EqualTo:
			result = Math.Abs(floatValue - compareValue) < 1E-08f;
			break;
		case EValueCompareOperations.NotEqualTo:
			result = Math.Abs(floatValue - compareValue) > 1E-08f;
			break;
		case EValueCompareOperations.LessThan:
			result = floatValue < compareValue;
			break;
		case EValueCompareOperations.LessThanOrEqualTo:
			result = floatValue <= compareValue;
			break;
		case EValueCompareOperations.GreaterThan:
			result = floatValue > compareValue;
			break;
		case EValueCompareOperations.GreaterThanOrEqualTo:
			result = floatValue >= compareValue;
			break;
		case EValueCompareOperations.LessThanPercentage:
			result = num < compareValue;
			break;
		case EValueCompareOperations.LessThanOrEqualToPercentage:
			result = num <= compareValue;
			break;
		case EValueCompareOperations.GreaterThanPercentage:
			result = num > compareValue;
			break;
		case EValueCompareOperations.GreaterThanOrEqualToPercentage:
			result = num >= compareValue;
			break;
		}
		return result;
	}

	private bool OnCheckSimpleState(CalliopeCustom_ComboCondition ComboCondition)
	{
		if (SimpleStateData != null && SimpleStateData.HasSimpleState((EBGUSimpleState)ComboCondition.SimpleState))
		{
			return true;
		}
		return false;
	}

	private bool OnCheckUnitState(CalliopeCustom_ComboCondition ComboCondition)
	{
		if (UnitStateData != null && UnitStateData.HasState((EBGUUnitState)ComboCondition.UnitState))
		{
			return true;
		}
		return false;
	}

	private bool OnCheckBuff(CalliopeCustom_ComboCondition ComboCondition)
	{
		if (BuffData != null && BuffData.HasBuff(ComboCondition.BuffId))
		{
			return true;
		}
		return false;
	}

	private bool OnCheckTalent(CalliopeCustom_ComboCondition ComboCondition)
	{
		if (TalentData != null && TalentData.HasTalent(ComboCondition.TalentId))
		{
			return true;
		}
		return false;
	}

	private bool OnCheckStanceType(CalliopeCustom_ComboCondition ComboCondition)
	{
		if (PlayerRoleData != null && PlayerRoleData.RoleData.RoleCs.Actor.Wear.Stance == (Stance)ComboCondition.StanceType)
		{
			return true;
		}
		return false;
	}

	private bool OnCheckPotentialEnergy(CalliopeCustom_ComboCondition ComboCondition)
	{
		bool result = false;
		int curPELevel = PEData.GetCurPELevel(GetOwner());
		int potentialEnergyLevel = ComboCondition.PotentialEnergyLevel;
		switch ((EValueCompareOperations)(byte)ComboCondition.ComparePotentialEnergyOperation)
		{
		case EValueCompareOperations.EqualTo:
			result = (float)Math.Abs(curPELevel - potentialEnergyLevel) < 1E-08f;
			break;
		case EValueCompareOperations.NotEqualTo:
			result = (float)Math.Abs(curPELevel - potentialEnergyLevel) > 1E-08f;
			break;
		case EValueCompareOperations.LessThan:
			result = curPELevel < potentialEnergyLevel;
			break;
		case EValueCompareOperations.LessThanOrEqualTo:
			result = curPELevel <= potentialEnergyLevel;
			break;
		case EValueCompareOperations.GreaterThan:
			result = curPELevel > potentialEnergyLevel;
			break;
		case EValueCompareOperations.GreaterThanOrEqualTo:
			result = curPELevel >= potentialEnergyLevel;
			break;
		}
		return result;
	}

	private bool OnCheckCharge(CalliopeCustom_ComboCondition ComboCondition)
	{
		bool result = false;
		int curChargeLevel = ChargeSkillData.CurChargeLevel;
		int chargeLevel = ComboCondition.ChargeLevel;
		switch ((EValueCompareOperations)(byte)ComboCondition.CompareChargeOperation)
		{
		case EValueCompareOperations.EqualTo:
			result = (float)Math.Abs(curChargeLevel - chargeLevel) < 1E-08f;
			break;
		case EValueCompareOperations.NotEqualTo:
			result = (float)Math.Abs(curChargeLevel - chargeLevel) > 1E-08f;
			break;
		case EValueCompareOperations.LessThan:
			result = curChargeLevel < chargeLevel;
			break;
		case EValueCompareOperations.LessThanOrEqualTo:
			result = curChargeLevel <= chargeLevel;
			break;
		case EValueCompareOperations.GreaterThan:
			result = curChargeLevel > chargeLevel;
			break;
		case EValueCompareOperations.GreaterThanOrEqualTo:
			result = curChargeLevel >= chargeLevel;
			break;
		}
		return result;
	}

	private bool OnCheckCeilingHeight(CalliopeCustom_ComboCondition ComboCondition)
	{
		bool result = false;
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (!aCharacter.IsNullOrDestroyed())
		{
			float nowValue = BGUFunctionLibraryCS.CheckCurCeilingHeight(aCharacter);
			int ceilingHeight = ComboCondition.CeilingHeight;
			result = ValueCompareOperation((EValueCompareOperations)ComboCondition.CompareCeilingHeightOperation, ceilingHeight, nowValue);
		}
		return result;
	}

	private bool OnCheckIsFalling(CalliopeCustom_ComboCondition ComboCondition)
	{
		return (GetOwner() as ABGUCharacter).CharacterMovement.IsFalling();
	}

	private bool OnCheckInJumpUpper(CalliopeCustom_ComboCondition ComboCondition)
	{
		if (GetOwner() as ABGUCharacter == null)
		{
			return false;
		}
		if (((JumpData != null && JumpData.JumpType == EJumpType.Normal) || JumpData.JumpType == EJumpType.GlideJump) && MovementComp != null)
		{
			return MovementComp.Velocity.Z > 0f;
		}
		return false;
	}

	private bool OnCheckNotInStrideUpJump(CalliopeCustom_ComboCondition ComboCondition)
	{
		if (GetOwner() as ABGUCharacter == null)
		{
			return true;
		}
		if (JumpData != null && JumpData.JumpType == EJumpType.StrideJump && JumpData.ObstacleHeight_StrideJump > 0f)
		{
			return false;
		}
		return true;
	}

	private bool CheckAirSkillCount(CalliopeCustom_ComboCondition ComboCondition)
	{
		bool result = false;
		if (FallingData != null)
		{
			int num = 0;
			foreach (int skillId in ComboCondition.SkillIdList)
			{
				if (FallingData.SkillInAirRecordList.TryGetValue(skillId, out var value))
				{
					num += value;
				}
			}
			int compareValue = (int)ComboCondition.CompareValue;
			result = ValueCompareOperation((EValueCompareOperations)ComboCondition.CompareOperation, compareValue, num);
		}
		return result;
	}

	private bool CheckFlooDistance(CalliopeCustom_ComboCondition ComboCondition)
	{
		bool result = false;
		if (FallingData != null)
		{
			float compareValue = ComboCondition.CompareValue;
			result = ValueCompareOperation((EValueCompareOperations)ComboCondition.CompareOperation, compareValue, FallingData.FloorDistance);
		}
		return result;
	}

	private bool CheckMoveMode(CalliopeCustom_ComboCondition ComboCondition)
	{
		if (MovementData == null)
		{
			return false;
		}
		return (int)MovementData.GetMoveType() == ComboCondition.MoveMode;
	}

	private bool ChecHasMoveInput(CalliopeCustom_ComboCondition ComboCondition)
	{
		if (MovementData == null)
		{
			return false;
		}
		float inputValue = InputData.GetInputValue(GSBattleActionEn.MoveSideways);
		float inputValue2 = InputData.GetInputValue(GSBattleActionEn.MoveForward);
		if (inputValue == 0f)
		{
			return inputValue2 != 0f;
		}
		return true;
	}

	private bool CheckDaShengStage(CalliopeCustom_ComboCondition ComboCondition, EDaShengStage CheckStage)
	{
		if (MovementData == null)
		{
			return false;
		}
		if (QiTianDaShengData != null && QiTianDaShengData.DaShengStage == CheckStage)
		{
			return true;
		}
		return false;
	}

	private bool CheckPressedSpinModeState(CalliopeCustom_ComboCondition ComboCondition)
	{
		return PlayerInputActionData.bInPressedSpinModeState;
	}

	private bool ValueCompareOperation(EValueCompareOperations OperationType, float CompareValue, float NowValue)
	{
		bool result = false;
		switch (OperationType)
		{
		case EValueCompareOperations.EqualTo:
			result = Math.Abs(NowValue - CompareValue) < 1E-08f;
			break;
		case EValueCompareOperations.NotEqualTo:
			result = Math.Abs(NowValue - CompareValue) > 1E-08f;
			break;
		case EValueCompareOperations.LessThan:
			result = NowValue < CompareValue;
			break;
		case EValueCompareOperations.LessThanOrEqualTo:
			result = NowValue <= CompareValue;
			break;
		case EValueCompareOperations.GreaterThan:
			result = NowValue > CompareValue;
			break;
		case EValueCompareOperations.GreaterThanOrEqualTo:
			result = NowValue >= CompareValue;
			break;
		}
		return result;
	}

	private bool ValueCompareOperation(EValueCompareOperations OperationType, int CompareValue, int NowValue)
	{
		bool result = false;
		switch (OperationType)
		{
		case EValueCompareOperations.EqualTo:
			result = NowValue == CompareValue;
			break;
		case EValueCompareOperations.NotEqualTo:
			result = NowValue != CompareValue;
			break;
		case EValueCompareOperations.LessThan:
			result = NowValue < CompareValue;
			break;
		case EValueCompareOperations.LessThanOrEqualTo:
			result = NowValue <= CompareValue;
			break;
		case EValueCompareOperations.GreaterThan:
			result = NowValue > CompareValue;
			break;
		case EValueCompareOperations.GreaterThanOrEqualTo:
			result = NowValue >= CompareValue;
			break;
		}
		return result;
	}

	private float GetSidewaysInputAxisValue()
	{
		GSBattleActionEn battleActionEn = GSBattleActionEn.MoveSideways;
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.CloudMove))
		{
			battleActionEn = GSBattleActionEn.Cloud_MoveSideways;
		}
		return InputData.GetInputValue(battleActionEn);
	}

	private float GetForwardInputAxisValue()
	{
		GSBattleActionEn battleActionEn = GSBattleActionEn.MoveForward;
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.CloudMove))
		{
			battleActionEn = GSBattleActionEn.Cloud_MoveForward;
		}
		return InputData.GetInputValue(battleActionEn);
	}

	private float GetUpwardInputAxisValue()
	{
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.CloudMove))
		{
			return InputData.GetInputValue(GSBattleActionEn.Cloud_Lift);
		}
		return 0f;
	}

	private bool InputCheckState()
	{
		if (!UnitStateData.HasState(EBGUUnitState.InMoveWindow))
		{
			if (UnitStateData.HasState(EBGUUnitState.Attacking))
			{
				return false;
			}
			if (UnitStateData.HasState(EBGUUnitState.Beatback))
			{
				return false;
			}
		}
		if (UnitStateData.HasState(EBGUUnitState.Dead) || SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			return false;
		}
		if (UnitStateData.HasState(EBGUUnitState.LifeSavingHair_FakeDead))
		{
			return false;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.CantMove))
		{
			return false;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
		{
			return false;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen))
		{
			return false;
		}
		if (FallDyingData.GetFallDyingState() != EFallDyingState.Alive)
		{
			return false;
		}
		return true;
	}

	private bool IsCameraLockTargetTooFar(BGUCharacterCS BGUTarget)
	{
		if (BGUTarget == null)
		{
			return false;
		}
		if (Owner == null)
		{
			return false;
		}
		float num = 0f;
		float num2 = 0f;
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(BGUTarget.GetResID());
		if (unitCommDesc != null)
		{
			num = unitCommDesc.CameraLockDist;
			num2 = unitCommDesc.CameraLockDistTolerance;
		}
		if (FVector.Dist(BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), BGUFuncLibActorTransformCS.BGUGetActorLocation(BGUTarget)) >= num + num2)
		{
			return true;
		}
		return false;
	}

	private void TriggerAttackSkill(EInputActionType InputActionType, bool IsRelease)
	{
		bool flag = true;
		if (UnitStateData.HasState(EBGUUnitState.InComboWindow))
		{
			foreach (KeyValuePair<int, AttackWindowInfo> item in ComboWindowData.AttackWindowInfoDict)
			{
				int key = item.Key;
				ComboCacheData.TryConsumeAttackKeyGroupID = key;
				if (TriggerComboGraphInputEvent(InputActionType, IsRelease))
				{
					flag = false;
					break;
				}
			}
		}
		if (!flag || !UnitStateData.HasState(EBGUUnitState.AtkComboKeyCache))
		{
			return;
		}
		List<int> list = new List<int>();
		if (ComboWindowData.AttackKeyCacheWindowInfoDict != null && ComboWindowData.AttackKeyCacheWindowInfoDict.Count > 0)
		{
			foreach (KeyValuePair<int, ComboKeyCacheWindowInfo> item2 in ComboWindowData.AttackKeyCacheWindowInfoDict)
			{
				int key2 = item2.Key;
				list.Add(key2);
			}
		}
		ComboCacheData.AddLastComboKey(new ComboKeyInfo
		{
			InputActionType = InputActionType,
			IsRelease = IsRelease,
			GroupIDList = list
		});
	}

	private ETriggerEventReturnType TryConsumeAttackCachedKey(ComboKeyInfo ComboKeyInfo)
	{
		EInputActionType inputActionType = ComboKeyInfo.InputActionType;
		bool isRelease = ComboKeyInfo.IsRelease;
		if (ComboKeyInfo.GroupIDList != null)
		{
			bool flag = true;
			bool flag2 = false;
			foreach (KeyValuePair<int, AttackWindowInfo> item in ComboWindowData.AttackWindowInfoDict)
			{
				int key = item.Key;
				if (ComboKeyInfo.GroupIDList.Contains(key))
				{
					flag = false;
					ComboCacheData.TryConsumeAttackKeyGroupID = key;
					ComboKeyInfo.GroupIDList.Remove(key);
					if (TriggerComboGraphInputEvent(inputActionType, isRelease))
					{
						return ETriggerEventReturnType.TriggerSucceeded;
					}
					flag2 = true;
					if (ComboKeyInfo.GroupIDList.Count == 0)
					{
						return ETriggerEventReturnType.TriggerFailed;
					}
					if (!ChargeSkillData.IsCastingChargeSkill && inputActionType == EInputActionType.HeavyAttack && isRelease)
					{
						return ETriggerEventReturnType.TriggerFailed;
					}
				}
			}
			if (flag2)
			{
				ComboCacheData.PopLastComboKey();
				ComboCacheData.AddLastComboKey(ComboKeyInfo);
				return ETriggerEventReturnType.NotTriggered;
			}
			if (!flag)
			{
				return ETriggerEventReturnType.TriggerFailed;
			}
			return ETriggerEventReturnType.NotTriggered;
		}
		if (!TriggerComboGraphInputEvent(inputActionType, isRelease))
		{
			return ETriggerEventReturnType.TriggerFailed;
		}
		return ETriggerEventReturnType.TriggerSucceeded;
	}

	private void DoAttackLogic(EInputActionType InputActionType, bool IsRelease, int DescID = -1)
	{
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.Input, $"<action>响应技能输入，InputActionType = </><effect>{InputActionType}</><action>，IsRelease = </><effect>{IsRelease}</><action>，DescID = </><effect>{DescID}</>");
		}
		if (!IsComboFSMInIdleState() && !UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.Input, "<action>触发CCG重置！</>");
			}
			OnComboGraphReset();
		}
		ComboCacheData.TryConsumeAttackKeyGroupID = 0;
		if (IsAttackKey(InputActionType))
		{
			AttackKeyPressStateMap[InputActionType] = !IsRelease;
		}
		float inputValue = InputData.GetInputValue(GSBattleActionEn.MoveSideways);
		float inputValue2 = InputData.GetInputValue(GSBattleActionEn.MoveForward);
		float dodgeInputFixLine = PlayerInputConfigData.DodgeInputFixLine;
		ESkillDirection skillDirection = BGUFuncLibInput.CalcInputDir(inputValue, inputValue2, dodgeInputFixLine);
		if (ChargeSkillData.IsCastingChargeSkill)
		{
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.CanForceAttackInChargeSkill) && IsAttackKey(InputActionType))
			{
				TriggerComboGraphInputEvent(InputActionType, IsRelease);
			}
			else if (InputActionType == EInputActionType.Dodge)
			{
				if (UnitStateData.HasState(EBGUUnitState.DodgeComboKeyCache))
				{
					ComboCacheData.LastCacheDodgeInputDir = new FVector(inputValue, inputValue2, dodgeInputFixLine);
					ComboCacheData.AddLastComboKey(new ComboKeyInfo(InputActionType, IsRelease));
				}
				else if (UnitStateData.HasState(EBGUUnitState.InDodgeWindow))
				{
					TriggerDodge(skillDirection);
				}
			}
			else if (IsSkillKey(InputActionType))
			{
				if (ChargeSkillData.ChargeSkillStage != EChargeSkillStage.End)
				{
					int lastMagicSkillID = ComboCacheData.LastMagicSkillID;
					int currentBeginChargeSkillOriginSkillID = ChargeSkillData.CurrentBeginChargeSkillOriginSkillID;
					if (UnitStateData.HasState(EBGUUnitState.InMagicWindow))
					{
						TriggerMagicSkill(ComboCacheData.LastMagicSkillID);
					}
					else if (lastMagicSkillID == currentBeginChargeSkillOriginSkillID)
					{
						int currentBeginChargeSkillID = ChargeSkillData.CurrentBeginChargeSkillID;
						TriggerMagicSkill(currentBeginChargeSkillID);
					}
				}
				else if (UnitStateData.HasState(EBGUUnitState.MagicKeyCache))
				{
					ComboCacheData.AddLastComboKey(new ComboKeyInfo(InputActionType, IsRelease));
				}
				else if (UnitStateData.HasState(EBGUUnitState.InMagicWindow))
				{
					TriggerMagicSkill(ComboCacheData.LastMagicSkillID);
				}
			}
			else if (InputActionType == EInputActionType.UseVigorSkill)
			{
				if (UnitStateData.HasState(EBGUUnitState.VigorKeyCache))
				{
					ComboCacheData.AddLastComboKey(new ComboKeyInfo(InputActionType, IsRelease));
				}
				else if (UnitStateData.HasState(EBGUUnitState.InVigorWindow))
				{
					TriggerVigorSkill();
				}
			}
			else if (IsAttackKey(InputActionType))
			{
				if (ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Begin)
				{
					ComboCacheData.AddLastComboKey(new ComboKeyInfo(InputActionType, IsRelease));
				}
				else if (ChargeSkillData.ChargeSkillStage == EChargeSkillStage.Loop)
				{
					TriggerComboGraphInputEvent(InputActionType, IsRelease);
				}
				else if (ChargeSkillData.ChargeSkillStage == EChargeSkillStage.End)
				{
					TriggerAttackSkill(InputActionType, IsRelease);
				}
			}
			else if (IsItemSkillKey(InputActionType))
			{
				if (UnitStateData.HasState(EBGUUnitState.ItemSkillKeyCache))
				{
					ComboCacheData.AddLastComboKey(new ComboKeyInfo(InputActionType, IsRelease));
				}
				else if (UnitStateData.HasState(EBGUUnitState.InItemSkillWindow))
				{
					TriggerItemSkill();
				}
			}
			return;
		}
		if (UnitStateData.HasState(EBGUUnitState.Attacking) || UnitStateData.HasState(EBGUUnitState.Beatback))
		{
			if (IsAttackKey(InputActionType))
			{
				TriggerAttackSkill(InputActionType, IsRelease);
				return;
			}
			if (InputActionType == EInputActionType.Dodge)
			{
				if (UnitStateData.HasState(EBGUUnitState.DodgeComboKeyCache))
				{
					ComboCacheData.LastCacheDodgeInputDir = new FVector(inputValue, inputValue2, dodgeInputFixLine);
					ComboCacheData.AddLastComboKey(new ComboKeyInfo(InputActionType, IsRelease));
					return;
				}
				if (UnitStateData.HasState(EBGUUnitState.InDodgeWindow))
				{
					TriggerDodge(skillDirection);
					return;
				}
			}
			else if (IsSkillKey(InputActionType))
			{
				if (UnitStateData.HasState(EBGUUnitState.MagicKeyCache))
				{
					ComboCacheData.AddLastComboKey(new ComboKeyInfo(InputActionType, IsRelease));
					return;
				}
				if (UnitStateData.HasState(EBGUUnitState.InMagicWindow))
				{
					TriggerMagicSkill(ComboCacheData.LastMagicSkillID);
					return;
				}
			}
			else if (InputActionType == EInputActionType.UseVigorSkill)
			{
				if (UnitStateData.HasState(EBGUUnitState.VigorKeyCache))
				{
					ComboCacheData.AddLastComboKey(new ComboKeyInfo(InputActionType, IsRelease));
					return;
				}
				if (UnitStateData.HasState(EBGUUnitState.InVigorWindow))
				{
					TriggerVigorSkill();
					return;
				}
			}
			else if (IsItemSkillKey(InputActionType))
			{
				if (UnitStateData.HasState(EBGUUnitState.ItemSkillKeyCache))
				{
					ComboCacheData.AddLastComboKey(new ComboKeyInfo(InputActionType, IsRelease));
					return;
				}
				if (UnitStateData.HasState(EBGUUnitState.InItemSkillWindow))
				{
					TriggerItemSkill();
					return;
				}
			}
		}
		if (IsComboFSMInIdleState() || ComboGraphData.CurrentGraph == null)
		{
			if (IsAttackKey(InputActionType))
			{
				TriggerComboGraphInputEvent(InputActionType, IsRelease);
			}
			else if (InputActionType == EInputActionType.Dodge)
			{
				TriggerDodge(skillDirection);
			}
			else if (IsSkillKey(InputActionType))
			{
				TriggerMagicSkill(ComboCacheData.LastMagicSkillID);
			}
			else if (InputActionType == EInputActionType.UseVigorSkill)
			{
				TriggerVigorSkill();
			}
			else if (IsItemSkillKey(InputActionType))
			{
				TriggerItemSkill();
			}
		}
	}

	private void OnTriggerResetAllActors()
	{
		base.BUSEventCollection?.Evt_ClearCameraLock.Invoke();
		PlayerInputActionData.bInPressedSpinModeState = false;
	}

	private bool IsAttackKey(EInputActionType InputActionType)
	{
		if (InputActionType == EInputActionType.LightAttack || InputActionType == EInputActionType.HeavyAttack || InputActionType == EInputActionType.SpinMode || InputActionType == EInputActionType.SpinModeMoveForward)
		{
			return true;
		}
		return false;
	}

	private bool IsSkillKey(EInputActionType InputActionType)
	{
		if (InputActionType == EInputActionType.UseSkillByType)
		{
			return true;
		}
		return false;
	}

	private bool IsItemSkillKey(EInputActionType InputActionType)
	{
		if (InputActionType == EInputActionType.CastItemSkill)
		{
			return true;
		}
		return false;
	}

	private FName GetAttackComboGraphEvent(EInputActionType InputActionType, bool IsRelease)
	{
		if (IsRelease)
		{
			switch (InputActionType)
			{
			case EInputActionType.LightAttack:
				return B1ComboEventDef.COMBO_EVENT_ATTACK_LIGHT_RELEASE;
			case EInputActionType.HeavyAttack:
				return B1ComboEventDef.COMBO_EVENT_ATTACK_HEAVY_RELEASE;
			case EInputActionType.SpinMode:
				return B1ComboEventDef.COMBO_EVENT_SPECIAL_CHARGE_RELEASE;
			case EInputActionType.SpinModeMoveForward:
				return B1ComboEventDef.COMBO_EVENT_MOVE_FORWARD_RELEASE;
			}
		}
		else if (OwnerAsCharacterCS.CharacterMovement.IsFalling())
		{
			if (CanAirAtk())
			{
				switch (InputActionType)
				{
				case EInputActionType.LightAttack:
					return B1ComboEventDef.COMBO_EVENT_ATTACK_LIGHT_FALLING;
				case EInputActionType.HeavyAttack:
					return B1ComboEventDef.COMBO_EVENT_ATTACK_HEAVY_FALLING;
				}
			}
		}
		else
		{
			switch (InputActionType)
			{
			case EInputActionType.LightAttack:
				return B1ComboEventDef.COMBO_EVENT_ATTACK_LIGHT;
			case EInputActionType.HeavyAttack:
				return B1ComboEventDef.COMBO_EVENT_ATTACK_HEAVY;
			case EInputActionType.SpinMode:
				return B1ComboEventDef.COMBO_EVENT_SPECIAL_CHARGE_START;
			case EInputActionType.SpinModeMoveForward:
				return B1ComboEventDef.COMBO_EVENT_MOVE_FORWARD;
			}
		}
		return FName.None;
	}

	private bool TriggerComboGraphInputEvent(EInputActionType InputActionType, bool IsRelease)
	{
		FName attackComboGraphEvent = GetAttackComboGraphEvent(InputActionType, IsRelease);
		if (attackComboGraphEvent == FName.None)
		{
			return false;
		}
		if (TriggerComboEvent(attackComboGraphEvent.PlainName))
		{
			if (IsAttackKey(InputActionType))
			{
				CachedTriggerGraphSuccessAttackKey = InputActionType;
			}
			return true;
		}
		return false;
	}

	private bool TriggerComboGraphConditionEvent(FName EventName)
	{
		if (EventName == FName.None)
		{
			return false;
		}
		if (TriggerComboEvent(EventName.PlainName))
		{
			CachedTriggerGraphSuccessAttackKey = EInputActionType.None;
			return true;
		}
		return false;
	}

	private void TriggerMagicSkill(int SkillID)
	{
		if (SkillID == TransformSkillFlag)
		{
			if (!PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
			{
				BPS_GSEventCollection.Get(OwnerAsCharacterCS.PlayerState).Evt_TriggerPlayerTransBegin.Invoke(EPlayerTransBeginType.CastSpell, default(PlayerTransParam));
			}
			else
			{
				BPS_GSEventCollection.Get(OwnerAsCharacterCS.PlayerState).Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.CastSpell, default(PlayerTransParam));
			}
		}
		else
		{
			base.BUSEventCollection.Evt_TriggerInputSkillRelease.Invoke(SkillID);
		}
	}

	private void TriggerVigorSkill()
	{
		int lastVigorSkillID = ComboCacheData.LastVigorSkillID;
		base.BUSEventCollection.Evt_TriggerVigorSkill.Invoke(lastVigorSkillID);
	}

	private void TriggerItemSkill()
	{
		int lastItemSkillID = ComboCacheData.LastItemSkillID;
		int lastItemID = ComboCacheData.LastItemID;
		if ((UnitStateData.HasState(EBGUUnitState.InItemSkillWindow) && ComboWindowData.ItemSkillWhiteList.Contains(lastItemSkillID)) || lastItemSkillID <= 0)
		{
			return;
		}
		if (lastItemID > 0)
		{
			if (CheckItemNumInBag(lastItemID) > 0)
			{
				base.BUSEventCollection.Evt_TriggerInputSkillRelease.Invoke(lastItemSkillID);
				base.BUSEventCollection.Evt_TriggerUseItem.Invoke(lastItemID);
			}
		}
		else
		{
			base.BUSEventCollection.Evt_TriggerInputSkillRelease.Invoke(lastItemSkillID);
		}
	}

	private void TryTriggerRealDodge()
	{
		if (ComboCacheData.PrepareForDodge)
		{
			ComboCacheData.PrepareForDodge = false;
			base.BUSEventCollection.Evt_BeginPreciseDodge.Invoke(ComboCacheData.PrepareDodgeDirection);
			ComboCacheData.PrepareDodgeDirection = ESkillDirection.Forward;
			ComboCacheData.LastCacheDodgeInputDir = FVector.ZeroVector;
		}
	}

	private void TriggerDodge(ESkillDirection SkillDirection)
	{
		ComboCacheData.PrepareForDodge = true;
		ComboCacheData.PrepareDodgeDirection = SkillDirection;
	}

	private bool IsComboFSMInIdleState()
	{
		return ComboCacheData.IsComboSubIdle;
	}

	private bool CanAirAtk()
	{
		if (JumpData != null && !JumpData.CanJumpAttack())
		{
			return false;
		}
		if (FallingData != null && !FallingData.CanFallingAttack())
		{
			return false;
		}
		return true;
	}

	private int CheckItemNumInBag(int ItemId)
	{
		return RoleDataHelper.FindBagItem(PlayerRoleData.RoleData.RoleCs, ItemId)?.Num ?? 0;
	}

	private void TryCastConsumeItemSkill(int ItemID, int PosIndex)
	{
		ConsumeDesc consumeDesc = GameDBRuntime.GetConsumeDesc(ItemID);
		if (consumeDesc == null || CheckItemNumInBag(ItemID) == 0)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if ((bGUCharacterCS != null && !bGUCharacterCS.IsNullOrDestroyed() && bGUCharacterCS.CharacterMovement != null && bGUCharacterCS.CharacterMovement.IsFalling()) || PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			return;
		}
		if (consumeDesc.CantUseInBossRoom > 0)
		{
			if (B1Global.GIsBossRushMode)
			{
				UIEC?.Evt_BossRushItemTips();
				return;
			}
			if (GlobalBattleStateData != null && GlobalBattleStateData.IsInBossRoom())
			{
				UIEC?.Evt_ShowShortItemTips();
				return;
			}
		}
		if (!BGUFunctionLibraryCS.BGUCheckSpecialConsumeItemUseAble(GetOwner(), ItemID))
		{
			return;
		}
		if (PoleDrinkData != null && PoleDrinkData.bPoleDrinkFlag)
		{
			if (ItemID != 0 && CheckItemNumInBag(ItemID) > 0)
			{
				base.BUSEventCollection?.Evt_DoPoleDrink.Invoke(EPoleDrinkType.UseItem, consumeDesc.SkillId, PosIndex);
				base.BUSEventCollection?.Evt_TriggerUseItem.Invoke(ItemID);
			}
		}
		else
		{
			ItemDesc itemDesc = GameDBRuntime.GetItemDesc(ItemID);
			if (itemDesc != null && itemDesc.ItemType == ItemType.Consume && BGW_GameDB.GetSkillSDesc(consumeDesc.SkillId, Owner) != null)
			{
				OnInputCastSkill(EInputActionType.CastItemSkill, IsRelease: true, consumeDesc.SkillId, -1, ItemID);
			}
		}
	}

	private void OnClearCameraLock()
	{
		base.BUSEventCollection.Evt_ClearTargetInfo.Invoke();
		base.BUSEventCollection.Evt_Camera_ClearCamLock.Invoke();
		base.BUSEventCollection.Evt_CameraLockCleared.Invoke();
	}

	private void OnCameraLockTarget(UnitLockTargetInfo TargetInfo)
	{
		if (TargetInfo == null)
		{
			return;
		}
		AActor lockTargetActor = TargetInfo.LockTargetActor;
		if (!(lockTargetActor == null))
		{
			BUS_EventCollectionCS.Get(lockTargetActor)?.Evt_BePlayerAddTargeted.Invoke();
			BGUFunctionLibraryCS.BGUSetTargetInfo(IsOnline(), Owner, TargetInfo);
			BGUFunctionLibraryCS.BGUSetTargetInfoWithCameraLocking(IsOnline(), Owner, TargetInfo);
			if (ChrData.MoveAcceleration.IsNearlyZero() && !ABPCommonSettingData.bLockUseFreeMode)
			{
				FRotator fRotator = BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner);
				FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
				fRotator.Yaw = MathLib.FindLookAtRotation(fVector, BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor)).Yaw;
				base.BUSEventCollection.Evt_ActorRotateToPos.Invoke(fVector + fRotator.Vector() * 1000.0, PlayerInputConfigData.GSCameraAutoLockSetting.CamLockTurnSpeed, bForceUpdate: false);
			}
			base.BUSEventCollection.Evt_Camera_ManualLock.Invoke(lockTargetActor, TargetInfo.LockTargetSkeletonSocketName);
		}
	}

	private void OnStopSlotAnimation(float BlendTime)
	{
		if (InputCheckState() && !(OwnerAsCharacterCS == null))
		{
			UAnimInstance uAnimInstance = null;
			USkeletalMeshComponent mesh = OwnerAsCharacterCS.Mesh;
			if (mesh != null)
			{
				uAnimInstance = mesh.GetAnimInstance();
			}
			if (uAnimInstance == null)
			{
				BGW_LogUtil.LogError("Can't Find AnimInstance Failed");
			}
			else
			{
				uAnimInstance.StopSlotAnimation(BlendTime, FName.None);
			}
		}
	}

	private void OnSetPressedSprinting(bool bPressed)
	{
		PlayerInputActionData.bPressedSprinting = bPressed;
	}

	private void OnTrySwitchCameraLockTarget(int ActionId, FVector2D InputAxis, float AngleMax, float ActionGap, float RecordTime, float Dist)
	{
		BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(Owner);
		if (bGW_SettingMgrV != null && !bGW_SettingMgrV.GetCVBoolByType(UISettingConfigType.LockSwitchTarget))
		{
			return;
		}
		InputAxisPeriod inputAxisPeriodData = InputData.GetInputAxisPeriodData(ActionId);
		if (inputAxisPeriodData == null)
		{
			return;
		}
		inputAxisPeriodData.AddInputAxis(PlayerInputActionData.DeltaTime, InputAxis);
		List<InputAxisPeriodData> aPeriodTimeDataList = inputAxisPeriodData.GetAPeriodTimeDataList(RecordTime);
		FVector2D zeroVector = FVector2D.ZeroVector;
		for (int i = 0; i < aPeriodTimeDataList.Count; i++)
		{
			zeroVector += aPeriodTimeDataList[i].InputAxis;
		}
		APlayerController firstLocalPlayerController = UnrealGameplayData.GetFirstLocalPlayerController();
		if (InputData.DebugDraw)
		{
			base.BUSEventCollection?.Evt_ResetScreenDebugDraw.Invoke();
			UWidgetLayoutLibrary.ProjectWorldLocationToWidgetPosition(firstLocalPlayerController, BarSockData.GetLockTargetSockLocation(), out var ScreenPosition, bPlayerViewportRelative: false);
			base.BUSEventCollection?.Evt_ScreenDebugDraw.Invoke(ScreenPosition, FLinearColor.Blue, 10f);
			base.BUSEventCollection?.Evt_ScreenDebugDraw.Invoke(ScreenPosition + InputAxis * 10.0, FLinearColor.Red, 10f);
			base.BUSEventCollection?.Evt_ScreenDebugDraw.Invoke(ScreenPosition + zeroVector * 20.0, FLinearColor.BurlyWood, 10f);
			base.BUSEventCollection?.Evt_ScreenDebugDraw.Invoke(ScreenPosition + zeroVector.GetSafeNormal() * Dist * 20.0, FLinearColor.Azure, 10f);
		}
		if (zeroVector.Size() <= Dist || Owner.World.GetTimeSeconds() - BarSockData.GetLastSwitchLockTime() < ActionGap || !(firstLocalPlayerController != null) || !firstLocalPlayerController.IsLocalPlayerController())
		{
			return;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		float maxCamLockTargetDistance = PlayerInputConfigData.GSCameraAutoLockSetting.MaxCamLockTargetDistance;
		UnitLockTargetInfo unitLockTargetInfo = BGUFunctionLibraryCS.BGUGetTargetInfo(Owner);
		AActor lockTargetActor = unitLockTargetInfo.LockTargetActor;
		string lockTargetSkeletonSocketName = unitLockTargetInfo.LockTargetSkeletonSocketName;
		if (!(lockTargetActor != null) || unitLockTargetInfo.LockTargetWayType != ELockTargetWayType.Manual)
		{
			return;
		}
		AActor aActor = null;
		string skeletonSocketName = "";
		float num = FMath.Cos(FMath.DegreesToRadians(AngleMax * 0.5f));
		float num2 = float.MaxValue;
		zeroVector.Normal2D();
		FVector lockTargetSockLocation = BarSockData.GetLockTargetSockLocation();
		UWidgetLayoutLibrary.ProjectWorldLocationToWidgetPosition(firstLocalPlayerController, lockTargetSockLocation, out var ScreenPosition2, bPlayerViewportRelative: false);
		UBGUSelectUtil.SphereOverlapBGUCharacters(Owner, BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), maxCamLockTargetDistance, out var OutArray);
		FVector2D fVector2D = UWidgetLayoutLibrary.GetViewportSize(firstLocalPlayerController) / UWidgetLayoutLibrary.GetViewportScale(firstLocalPlayerController);
		IBGC_CircusControlData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_CircusControlData>(UGameplayStatics.GetGameState(Owner));
		for (int j = 0; j < OutArray.Count; j++)
		{
			BGUCharacterCS bGUCharacterCS = OutArray[j] as BGUCharacterCS;
			if (!(bGUCharacterCS != Owner) || BGUFunctionLibraryCS.BGUIsUnitDead(bGUCharacterCS) || !BGUFunctionLibraryCS.BGUIsEnemyTeam(Owner, bGUCharacterCS))
			{
				continue;
			}
			IBUC_TargetInfoData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(bGUCharacterCS);
			if (readOnlyData2 == null)
			{
				continue;
			}
			FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(bGUCharacterCS.GetResID());
			if (unitCommDesc == null)
			{
				continue;
			}
			foreach (string item in readOnlyData2.CachedLockSkeletonSocket)
			{
				if ((bGUCharacterCS == lockTargetActor && item == lockTargetSkeletonSocketName) || readOnlyData2.DisabledLockSkeletonSocket.Contains(item))
				{
					continue;
				}
				FVector socketLocation = bGUCharacterCS.Mesh.GetSocketLocation(new FName(item));
				UWidgetLayoutLibrary.ProjectWorldLocationToWidgetPosition(firstLocalPlayerController, socketLocation, out var ScreenPosition3, bPlayerViewportRelative: false);
				if (bGUCharacterCS != lockTargetActor && (ScreenPosition3.X <= 0f || ScreenPosition3.Y <= 0f || ScreenPosition3.X >= fVector2D.X || ScreenPosition3.Y >= fVector2D.Y))
				{
					continue;
				}
				double num3 = (ScreenPosition3 - ScreenPosition2).GetSafeNormal().DotProduct2D(zeroVector);
				if (InputData.DebugDraw)
				{
					base.BUSEventCollection?.Evt_ScreenDebugDraw.Invoke(ScreenPosition3, FLinearColor.Red, 10f);
				}
				float num4 = (socketLocation - fVector).Size2D();
				if (!(num4 > unitCommDesc.CameraLockDist))
				{
					float dist = FVector.Dist(fVector, socketLocation);
					if (CheckCanSelectTarget(Owner, bGUCharacterCS, item, readOnlyData, dist) && num3 > (double)num && num4 < num2)
					{
						num2 = num4;
						aActor = bGUCharacterCS;
						skeletonSocketName = item;
					}
				}
			}
		}
		if (aActor != null)
		{
			OnCameraLockTarget(new UnitLockTargetInfo(aActor, ETargetSourceType.None, ELockTargetWayType.Manual, "", skeletonSocketName));
		}
	}

	private void OnTriggerInputActionImpl(string ActionName, ETriggerEvent TriggerEvent, FInputActionValue Value)
	{
		FUStEnhancedInputActionDesc descByInputActionNameAndTriggerEvent = BGW_GameDB.GetDescByInputActionNameAndTriggerEvent(GetActorResID(), ActionName, TriggerEvent);
		if (descByInputActionNameAndTriggerEvent != null)
		{
			(EffectTemplateList?.GetInputActionTemplate(descByInputActionNameAndTriggerEvent.InputActionType))?.TriggerInputAction(GameInstance, descByInputActionNameAndTriggerEvent.ID, TriggerEvent, Value, null);
		}
	}

	private void OnInputCastSkill(EInputActionType InputActionType, bool IsRelease, int SkillID, int DescID, int ItemID = -1)
	{
		bool flag = false;
		switch (InputActionType)
		{
		case EInputActionType.LightAttack:
			flag = true;
			break;
		case EInputActionType.HeavyAttack:
			flag = true;
			break;
		case EInputActionType.SpinMode:
		{
			PlayerInputActionData.bInPressedSpinModeState = !IsRelease;
			BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
			if (bGUCharacterCS == null || bGUCharacterCS.CharacterMovement.IsFalling())
			{
				return;
			}
			flag = true;
			break;
		}
		case EInputActionType.Dodge:
			flag = true;
			break;
		case EInputActionType.UseVigorSkill:
			flag = true;
			ComboCacheData.LastVigorSkillID = SkillID;
			break;
		case EInputActionType.CastItemSkill:
			flag = true;
			ComboCacheData.LastItemSkillID = SkillID;
			ComboCacheData.LastItemID = ItemID;
			break;
		case EInputActionType.UseSkillByType:
		{
			if (BGW_GameDB.GetSkillSDesc(SkillID, Owner) == null)
			{
				break;
			}
			FUStEnhancedInputActionDesc enhancedInputActionDesc = BGW_GameDB.GetEnhancedInputActionDesc(DescID);
			if (enhancedInputActionDesc != null)
			{
				if ((byte)enhancedInputActionDesc.InputActionParamsInt[0] == 4)
				{
					flag = true;
					ComboCacheData.LastMagicSkillID = TransformSkillFlag;
				}
				else
				{
					flag = true;
					ComboCacheData.LastMagicSkillID = SkillID;
				}
			}
			break;
		}
		}
		if (flag)
		{
			DoAttackLogic(InputActionType, IsRelease, DescID);
		}
	}

	private void OnTriggerItemSkillAction_ShortCut(int InputActionID, ETriggerEvent TriggerEvent, EInputActionType InputActionType)
	{
		AActor owner = GetOwner();
		if (owner == null || !BGUFuncLibInput.BGUIsCanReceiveBattleInput(owner) || !BGUFuncLibInput.BGUIsCanReceiveBattleInputByActionType(owner, InputActionType))
		{
			return;
		}
		FUStEnhancedInputActionDesc enhancedInputActionDesc = BGW_GameDB.GetEnhancedInputActionDesc(InputActionID);
		if (enhancedInputActionDesc == null || enhancedInputActionDesc.InputActionParamsInt.Count == 0 || UnitStateData == null || UnitStateData.HasState(EBGUUnitState.JumpMoving))
		{
			return;
		}
		switch (InputActionType)
		{
		case EInputActionType.UseShortcutItem:
		{
			int num = enhancedInputActionDesc.InputActionParamsInt[0];
			if (num == -1 && owner as APawn != null)
			{
				if (PlayerRoleData == null || PlayerRoleData.RoleData == null)
				{
					break;
				}
				num = PlayerRoleData.DefaultShortcutsPosition;
			}
			if (num >= 0)
			{
				base.BGSEventCollection.Evt_BGS_TriggerShortcut.Invoke(B1: false, num);
			}
			int num2 = 0;
			foreach (ReadOnlyShortcutItem shortcuts in PlayerRoleData.RoleData.RoleCs.Actor.Wear.ShortcutsList)
			{
				if (shortcuts.Position == num)
				{
					num2 = shortcuts.ItemId;
					break;
				}
			}
			if (GameDBRuntime.GetConsumeDesc(num2) != null)
			{
				TryCastConsumeItemSkill(num2, num);
			}
			break;
		}
		case EInputActionType.CastItemSkill:
		{
			if (PoleDrinkData != null && PoleDrinkData.bPoleDrinkFlag)
			{
				base.BUSEventCollection?.Evt_DoPoleDrink.Invoke(EPoleDrinkType.DrinkHPBottom, 0, -1);
				break;
			}
			int skillID = enhancedInputActionDesc.InputActionParamsInt[0];
			if (PlayerTagData != null && PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
			{
				FUStPlayerTransUnitConfDesc fUStPlayerTransUnitConfDesc = BGW_GameDB.GetFUStPlayerTransUnitConfDesc(OwnerAsCharacterCS.GetResID());
				if (fUStPlayerTransUnitConfDesc == null || fUStPlayerTransUnitConfDesc.DrinkSkillId <= 0)
				{
					break;
				}
				skillID = fUStPlayerTransUnitConfDesc.DrinkSkillId;
			}
			OnInputCastSkill(EInputActionType.CastItemSkill, IsRelease: false, skillID, -1);
			break;
		}
		}
	}

	private void OnTriggerItemSkillAction_UseItem(int ItemID)
	{
		AActor owner = GetOwner();
		if (!(owner == null) && BGUFuncLibInput.BGUIsCanReceiveBattleInput(owner, bSkilIgnoreInputJudge: true) && BGUFuncLibInput.BGUIsCanReceiveBattleInputByActionType(owner, EInputActionType.UseShortcutItem) && UnitStateData != null && !UnitStateData.HasState(EBGUUnitState.JumpMoving) && GameDBRuntime.GetConsumeDesc(ItemID) != null)
		{
			TryCastConsumeItemSkill(ItemID, -1);
		}
	}

	private void OnInputKeyCacheStart(EInputKeyCacheType KeyCacheType, int MontageID, uint NotifyID, int GroupID, float Duration)
	{
		switch (KeyCacheType)
		{
		case EInputKeyCacheType.Combo:
			ComboWindowData.AttackKeyCacheWindowInfoDict[GroupID] = new ComboKeyCacheWindowInfo
			{
				MontageInstanceID = MontageID,
				NotifyUniqueID = NotifyID,
				TotalTime = Duration
			};
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnterAtkComboKeyCache, Duration);
			break;
		case EInputKeyCacheType.Dodge:
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnterDodgeComboKeyCache, Duration, NeedForceUpdate: true);
			break;
		case EInputKeyCacheType.Magic:
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnterMagicKeyCache, Duration, NeedForceUpdate: true);
			break;
		case EInputKeyCacheType.ItemSkill:
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnterItemSkillKeyCache, Duration, NeedForceUpdate: true);
			break;
		case EInputKeyCacheType.Vigor:
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnterVigorKeyCache, Duration, NeedForceUpdate: true);
			break;
		}
	}

	private void OnComboGraphReset()
	{
		OnClearKeyCache();
		TriggerComboGraphConditionEvent(B1ComboEventDef.COMBO_EVENT_COMBO_RESTART);
		CachedTriggerGraphSuccessAttackKey = EInputActionType.None;
	}

	private void OnComboGraphTryTriggerChargeSkillTimeOut()
	{
		if (!IsComboFSMInIdleState() && ComboGraphData.CurrentGraph != null && ChargeSkillData.IsCastingChargeSkill && ComboGraphData.CurrentNode != null && ComboGraphData.CurrentNode.OutputEdges.ContainsKey(B1ComboEventDef.COMBO_EVENT_CHARGE_TIMEOUT.ToString()))
		{
			TriggerComboGraphConditionEvent(B1ComboEventDef.COMBO_EVENT_CHARGE_TIMEOUT);
		}
	}

	private void OnTriggerChargeSkillEndEvent(EChargeSkillEndEventType ChargeSkillEndEventType)
	{
		switch (ChargeSkillEndEventType)
		{
		case EChargeSkillEndEventType.TimeOut:
			TriggerComboGraphConditionEvent(B1ComboEventDef.COMBO_EVENT_CHARGE_TIMEOUT);
			break;
		case EChargeSkillEndEventType.ChargeEnd:
			TriggerComboGraphConditionEvent(B1ComboEventDef.COMBO_EVENT_CHARGE_END);
			break;
		case EChargeSkillEndEventType.StaminaOver:
			TriggerComboGraphConditionEvent(B1ComboEventDef.COMBO_EVENT_CHARGE_STAMINAOVER);
			break;
		case EChargeSkillEndEventType.PELevelGrowUp:
			TriggerComboGraphConditionEvent(B1ComboEventDef.COMBO_EVENT_PE_LEVELGROWUP);
			break;
		}
	}

	private void OnClearKeyCache()
	{
		ComboCacheData.ClearComboKeyStack();
	}

	private void OnTriggerComboWindow(int MontageInstanceID, uint NotifyUniqueID, int GroupID, List<int> BlackListComboSkillID, List<int> WhiteListComboSkillID, float TotalDuration)
	{
		ComboWindowData.SetAttackWindowInfo(GroupID, MontageInstanceID, NotifyUniqueID, TotalDuration, BlackListComboSkillID, WhiteListComboSkillID);
		base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnterComboWindow, TotalDuration);
	}

	private void OnSetItemSkillWhiteList(List<int> ItemSkillWhiteList)
	{
		ComboWindowData.ItemSkillWhiteList = ItemSkillWhiteList;
	}

	private void OnWeaponStanceSwitchSuccess()
	{
		if (PlayerInputActionData.EffectIDList_SwitchWeaponPose.Count < 1)
		{
			return;
		}
		float gameTimeInSeconds = Owner.World.GetGameTimeInSeconds();
		if (!(gameTimeInSeconds >= PlayerInputActionData.TriggerEffectCoolDown_SwitchWeaponPose + PlayerInputActionData.LastTriggerEffectTime_SwitchWeaponPose))
		{
			return;
		}
		foreach (int item in PlayerInputActionData.EffectIDList_SwitchWeaponPose)
		{
			base.BUSEventCollection.Evt_TriggerSkillEffect.Invoke(item, default(FEffectInstReq), Owner);
		}
		PlayerInputActionData.LastTriggerEffectTime_SwitchWeaponPose = gameTimeInSeconds;
	}

	private void OnPlayMontageCallback(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
	{
		if (State == EMontageCallbackState.OnStarted && (!ChargeSkillData.IsCastingChargeSkill || (ChargeSkillData.ChargeSkillStage != EChargeSkillStage.Loop && ChargeSkillData.ChargeSkillStage != EChargeSkillStage.Begin)))
		{
			OnClearKeyCache();
		}
	}

	private void OnPostInputMappingContextRegister(EInputMappingContextTagV2 Tag, UInputMappingContext InputMappingContext, List<string> RelatedActions, bool IsRegister)
	{
		if (Tag == EInputMappingContextTagV2.SprintAndDodge)
		{
			if (UnitStateData.HasState(EBGUUnitState.Sprinting))
			{
				base.BUSEventCollection.Evt_UnitStateTriggerCMultiCast.Invoke(EBUStateTrigger.UnitInputSprintRelease, -1f);
			}
			OnSetPressedSprinting(bPressed: false);
		}
	}
}
