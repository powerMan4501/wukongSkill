using System;
using System.Collections.Generic;
using System.Linq;
using b1.AutoQA;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_SweepCheckHitComp : UActorCompBaseCS
{
	private static readonly FName BG_LOG_CATEGORY = B1GlobalFNames.BANS_GSSweepCheck;

	private BUC_SweepCheckHitData SweepCheckHitData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_GuidData GuidData;

	private BUC_UnitDebugData DebugData;

	private IBUC_SpeedCtrlData SpeedCtrlData;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	private IBGC_BattleFieldPerformanceOptData BattleFieldPerformanceOptData;

	private IBGC_TeamRelationData TeamRelationData;

	private IBUC_MasterData MasterData;

	private IBGC_LocalPlayerSharedData LocalPlayerSharedData;

	private static bool bSetted_ChannelsForFilter = false;

	private static List<ECollisionChannel> OverlapChannelsForFilter;

	private static List<ECollisionChannel> OverlapChannelsForFilter_AttackWarning;

	private static ECollisionChannel SweepCheckChannel;

	private const float OPT_SIMPLEOVERLAPOFFSET = 500f;

	public override void OnAttach()
	{
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		BattleFieldPerformanceOptData = RequireReadOnlyGameStateData<IBGC_BattleFieldPerformanceOptData, BGC_BattleFieldPerformanceOptData>();
		SweepCheckHitData = RequireWritableData<BUC_SweepCheckHitData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		DebugData = BGU_DataUtil.GetReadOnlyData<BUC_UnitDebugData>(Owner);
		TeamRelationData = RequireReadOnlyGameStateData<IBGC_TeamRelationData, BGC_TeamRelationData>();
		MasterData = RequireReadOnlyData<IBUC_MasterData, BUC_MasterData>();
		SpeedCtrlData = RequireReadOnlyData<IBUC_SpeedCtrlData, BUC_SpeedCtrlData>();
		LocalPlayerSharedData = RequireReadOnlyGameStateData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>();
		base.BUSEventCollection.Evt_SweepCheckBegin += new Del_SweepCheckBegin(SweepCheckBegin);
		base.BUSEventCollection.Evt_SweepCheckEnd += new Del_SweepCheckEnd(SweepCheckEnd);
		base.BUSEventCollection.Evt_ShowSweepCheckShape += new Del_Void(ShowSweepCheckShape);
		base.BUSEventCollection.Evt_SetAllSweepCheckPaused += new Del_Void_Bool(SetAllSweepCheckPaused);
		base.BUSEventCollection.Evt_AttackWarnningCheckBegin += new Del_AttackWarnningCheckBegin(AttackWarningCheckBegin);
		base.BUSEventCollection.Evt_AttackWarnningCheckEnd += new Del_AttackWarnningCheckEnd(AttackWarningCheckEnd);
		base.BUSEventCollection.Evt_SetAllAttackWarningPaused += new Del_Void_Bool(SetAllAttackWarningPaused);
		base.BUSEventCollection.Evt_UnitCastSkillSuccess += new Del_UnitCastSkillSuccess(OnUnitCastSkillSuccess);
		base.BUSEventCollection.Evt_ClearSweepCheckData += new Del_Void(OnClearSweepCheckData);
	}

	public override bool AllowTRO()
	{
		return false;
	}

	public override void PreBeginPlay()
	{
		if (!bSetted_ChannelsForFilter)
		{
			OverlapChannelsForFilter = new List<ECollisionChannel>
			{
				ECollisionChannel.ECC_PhysicsBody,
				ECollisionChannel.ECC_WorldDynamic
			};
			OverlapChannelsForFilter_AttackWarning = new List<ECollisionChannel> { ECollisionChannel.ECC_PhysicsBody };
			bSetted_ChannelsForFilter = true;
			SweepCheckChannel = ECollisionChannel.ECC_GameTraceChannel2;
		}
		AActor owner = GetOwner();
		if (owner != null)
		{
			SweepCheckHitData.SCDCollisionInfoConfig = BGW_PreloadAssetMgr.Get(owner).TryGetCachedResourceObj<BGWDataAsset_SweepCheckDebugCollisionInfoConfig>("BGWDataAsset_SweepCheckDebugCollisionInfoConfig'/Game/00Main/BPLibrary/Debug/SCDCollisionInfoConfig.SCDCollisionInfoConfig'", ELoadResourceType.AsyncLoadAndCache);
		}
	}

	private void ShowSweepCheckShape()
	{
		SweepCheckHitData.bShowSweepCheckShape = !SweepCheckHitData.bShowSweepCheckShape;
	}

	private bool CanCombineSweepCheck()
	{
		return GSGameplayCVar.CVar_CombineSweepCheckShape.GetValueInGameThread() == 1;
	}

	public override int GetTickGroupMask()
	{
		return 10;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		switch (TickGroup)
		{
		case 2:
			AttackWarnningCheck(DeltaTime);
			break;
		case 8:
			SweepCheckAllNotify();
			break;
		}
	}

	private void OnSweepCheckHit(AActor Victim, float SweepProtectTime, string SkillTaskUniqID, in FEffectInstReq EffectInstReq, List<AbnormalStateAccConfig> AbnormalStateEffectList, List<FTriggerEffectWithCondition> EffectsWithCondition_Before, List<int> EffectIDList, List<FTriggerEffectWithCondition> EffectsWithCondition_After, int GroupID, int FromInstanceID)
	{
		AActor owner = GetOwner();
		if (owner == null || Victim == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Victim as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS2 = owner as BGUCharacterCS;
		if (bGUCharacterCS2 == null)
		{
			return;
		}
		int actorResID = BGU_DataUtil.GetActorResID(Victim);
		if (BGW_LogUtil.LogIfNull(BGW_GameDB.GetUnitCommDesc(actorResID), "Find VictimUnitCommDesc failed! VictimResID: {0}", actorResID))
		{
			return;
		}
		bool flag = false;
		if (bGUCharacterCS2.IsPlayerControlled())
		{
			if (!bGUCharacterCS2.IsLocallyControlled())
			{
				return;
			}
		}
		else if (bGUCharacterCS.IsPlayerControlled())
		{
			if (!bGUCharacterCS.IsLocallyControlled())
			{
				return;
			}
			flag = true;
		}
		else if (bGUCharacterCS2.GetLocalRole() != ENetRole.ROLE_Authority)
		{
			return;
		}
		b1.IBUC_UnitBeAttackedFequenceData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitBeAttackedFequenceData>(Victim);
		if (!readOnlyData.CheckBeAttackedFequenceData(SkillTaskUniqID) || !readOnlyData.CheckBeAttackedGroupInfo(GroupID, FromInstanceID))
		{
			return;
		}
		float groupResetTime = UBGUFuncLibSkill.BGUCalcMontageNeedModifyTotalTime(owner as ACharacter, FromInstanceID);
		BUS_EventCollectionCS.Get(Victim).Evt_MarkBeAttackedProtectTime.Invoke(SkillTaskUniqID, SweepProtectTime, groupResetTime, GroupID, FromInstanceID);
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text = "";
			for (int i = 0; i < EffectIDList.Count; i++)
			{
				string text2 = EffectIDList[i].ToString();
				if (i < EffectIDList.Count - 1)
				{
					text2 += "、";
				}
				text += text2;
			}
			BGUFunctionLibraryCS.LogBattleInfo(owner, EBattleInfoType.SweepCheck, (text == "") ? ("<character>" + GetOwner().GetName() + "</><action>触发SweepCheck，扫到了</><bechosed>" + Victim.GetName() + "</><action>，没有触发技能效果</>") : ("<character>" + GetOwner().GetName() + "</><action>触发SweepCheck，扫到了</><bechosed>" + Victim.GetName() + "</><action>，触发了技能效果</><effectnum>" + text + "</>"));
		}
		foreach (AbnormalStateAccConfig AbnormalStateEffect in AbnormalStateEffectList)
		{
			int abnormalStateAccEffectOrBuffID = BGUFuncLib_AbnormalState.GetAbnormalStateAccEffectOrBuffID(owner, AbnormalStateEffect);
			if (abnormalStateAccEffectOrBuffID > 0)
			{
				if (flag)
				{
					base.BUSEventCollection?.Evt_TriggerSkillEffect_Transmit.Invoke(abnormalStateAccEffectOrBuffID, EffectInstReq, Victim);
				}
				else
				{
					base.BUSEventCollection?.Evt_TriggerSkillEffect.Invoke(abnormalStateAccEffectOrBuffID, EffectInstReq, Victim);
				}
			}
		}
		foreach (FTriggerEffectWithCondition item in EffectsWithCondition_Before)
		{
			if (BGUFunctionLibraryCS.CheckConditions(Owner, item.UnitType, item.Conditions, item.ConditionalRelation, item.IsReverseCondition, Victim) != 1)
			{
				continue;
			}
			foreach (int effectID in item.EffectIDList)
			{
				if (flag)
				{
					base.BUSEventCollection?.Evt_TriggerSkillEffect_Transmit.Invoke(effectID, EffectInstReq, Victim);
				}
				else
				{
					base.BUSEventCollection?.Evt_TriggerSkillEffect.Invoke(effectID, EffectInstReq, Victim);
				}
			}
		}
		foreach (int EffectID in EffectIDList)
		{
			if (flag)
			{
				base.BUSEventCollection?.Evt_TriggerSkillEffect_Transmit.Invoke(EffectID, EffectInstReq, Victim);
			}
			else
			{
				base.BUSEventCollection?.Evt_TriggerSkillEffect.Invoke(EffectID, EffectInstReq, Victim);
			}
		}
		foreach (FTriggerEffectWithCondition item2 in EffectsWithCondition_After)
		{
			if (BGUFunctionLibraryCS.CheckConditions(Owner, item2.UnitType, item2.Conditions, item2.ConditionalRelation, item2.IsReverseCondition, Victim) != 1)
			{
				continue;
			}
			foreach (int effectID2 in item2.EffectIDList)
			{
				if (flag)
				{
					base.BUSEventCollection?.Evt_TriggerSkillEffect_Transmit.Invoke(effectID2, EffectInstReq, Victim);
				}
				else
				{
					base.BUSEventCollection?.Evt_TriggerSkillEffect.Invoke(effectID2, EffectInstReq, Victim);
				}
			}
		}
	}

	private void SweepCheckBegin(int ObjectID, int WeaponIndex, List<FUStCheckShape> SweepCheckShape, List<int> EffectIDList, List<AbnormalStateAccConfig> AbnormalStateEffectList, List<int> EffectIDListForSceneItem, FHitDestructibleActorConfig HitDestructibleActorConfig, int HitChrAudioID, int HitChrFXWeight, FHitCheckConf HitCheckConf, bool CanHitBackBullet, float SweepCheckProtectTime, UAnimSequenceBase Animation, UAnimMontage AtkReboundingAM, UAnimMontage LowAtkReboundingAM, int SweepCheckGroupID, int FromInstanceID, List<FTriggerEffectWithCondition> EffectsWithCondition_Before, List<FTriggerEffectWithCondition> EffectsWithCondition_After, float NotifyBeginTime)
	{
		string NotifyInstID = Convert.ToString(FromInstanceID) + Convert.ToString(ObjectID);
		if (SweepCheckHitData.SweepCheckConfigMap.ContainsKey(NotifyInstID))
		{
			return;
		}
		if (AtkReboundingAM != null)
		{
			base.BUSEventCollection?.Evt_SetSpAtkReboundingAM.Invoke(ObjectID, AtkReboundingAM, IsLowAtkRebounding: false);
		}
		if (LowAtkReboundingAM != null)
		{
			base.BUSEventCollection?.Evt_SetSpAtkReboundingAM.Invoke(ObjectID, LowAtkReboundingAM, IsLowAtkRebounding: true);
		}
		FSweepCheckUnitConfig fSweepCheckUnitConfig = new FSweepCheckUnitConfig
		{
			TriggerSkillID = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(Owner).CurrentCastingSkillID,
			NotifyID = NotifyInstID,
			ObjectID = ObjectID,
			WeaponIndex = WeaponIndex,
			SweepCheckShape = SweepCheckShape,
			AbnormalStateEffectList = AbnormalStateEffectList,
			EffectsWithCondition_Before = EffectsWithCondition_Before,
			EffectIDList = EffectIDList,
			EffectsWithCondition_After = EffectsWithCondition_After,
			EffectIDListForSceneItem = EffectIDListForSceneItem,
			HitDestructibleActorConfig = HitDestructibleActorConfig,
			HitChrAudioID = HitChrAudioID,
			HitChrFXWeight = HitChrFXWeight,
			HitCheckConf = HitCheckConf,
			CanHitProjectile = CanHitBackBullet,
			SweepCheckProtectTime = SweepCheckProtectTime,
			BeginTimeWorldSeconds = (UnrealGameplayData?.GetTimeSeconds() ?? 0f),
			NotifyBeginTime = NotifyBeginTime,
			Animation = Animation,
			SPAtkReboundingAM = AtkReboundingAM,
			LowSPAtkReboundingAM = LowAtkReboundingAM,
			SweepCheckGroupID = SweepCheckGroupID,
			TransformList = new List<FTransform>(),
			IgnoreActors = new List<AActor> { GetOwner() },
			FromInstanceID = FromInstanceID
		};
		List<FSweepCheckCombineInfo> list = new List<FSweepCheckCombineInfo>();
		for (int i = 0; i < fSweepCheckUnitConfig.SweepCheckShape.Count; i++)
		{
			FUStCheckShape ShapeA = fSweepCheckUnitConfig.SweepCheckShape[i];
			FSweepCheckCombineInfo fSweepCheckCombineInfo = null;
			foreach (FSweepCheckCombineInfo item in SweepCheckHitData.CombineSweepCheck)
			{
				if (item.TriggerSkillID == fSweepCheckUnitConfig.TriggerSkillID && item.SharingAnimation == fSweepCheckUnitConfig.Animation && IsSameShape(in ShapeA, in item.SweepCheckShape))
				{
					ListExtensions.AddUnique(item.CombinedConfigShapeNotifyIDSet, fSweepCheckUnitConfig.NotifyID);
					item.bCanHitProjectile = item.bCanHitProjectile || fSweepCheckUnitConfig.CanHitProjectile;
					fSweepCheckCombineInfo = item;
					break;
				}
			}
			if (fSweepCheckCombineInfo != null)
			{
				list.Add(fSweepCheckCombineInfo);
				continue;
			}
			FSweepCheckCombineInfo CombineInfo = new FSweepCheckCombineInfo
			{
				TriggerSkillID = fSweepCheckUnitConfig.TriggerSkillID,
				SweepCheckShape = ShapeA,
				SharingAnimation = fSweepCheckUnitConfig.Animation,
				bCanHitProjectile = fSweepCheckUnitConfig.CanHitProjectile
			};
			ListExtensions.AddUnique(CombineInfo.CombinedConfigShapeNotifyIDSet, fSweepCheckUnitConfig.NotifyID);
			PrepareCombineSweepCheck(ref CombineInfo);
			list.Add(CombineInfo);
			SweepCheckHitData.CombineSweepCheck.Add(CombineInfo);
		}
		SweepCheckHitData.SweepCheckConfigMap.Add(NotifyInstID, fSweepCheckUnitConfig);
		if (CanCombineSweepCheck())
		{
			for (int j = 0; j < list.Count; j++)
			{
				FSweepCheckCombineInfo CombineInfo2 = list[j];
				CombineSweepCheckInternal_Single(ref CombineInfo2);
				if (SweepCheckHitData.CombineSweepCheck.Count == 0)
				{
					break;
				}
			}
		}
		else
		{
			SweepCheckInternal(in NotifyInstID);
		}
	}

	private void StartSweepCheck(in float TriggerTime)
	{
		if (!CanCombineSweepCheck())
		{
			foreach (KeyValuePair<string, FSweepCheckUnitConfig> item in SweepCheckHitData.SweepCheckConfigMap)
			{
				SweepCheckInternal(item.Key, TriggerTime);
			}
			return;
		}
		CombineSweepCheckInternal(in TriggerTime);
	}

	private void CombineSweepCheckInternal(in float TriggerTime = 0f)
	{
		if (SweepCheckHitData.CombineSweepCheck == null)
		{
			SweepCheckHitData.CombineSweepCheck = new List<FSweepCheckCombineInfo>();
		}
		if (SweepCheckHitData.CombineSweepCheck.Count == 0)
		{
			return;
		}
		for (int i = 0; i < SweepCheckHitData.CombineSweepCheck.Count; i++)
		{
			FSweepCheckCombineInfo CombineInfo = SweepCheckHitData.CombineSweepCheck[i];
			CombineSweepCheckInternal_Single(ref CombineInfo, TriggerTime);
			if (SweepCheckHitData.CombineSweepCheck.Count == 0)
			{
				break;
			}
		}
	}

	private bool PrepareCombineSweepCheck(ref FSweepCheckCombineInfo CombineInfo)
	{
		FUStCheckShape sweepCheckShape = CombineInfo.SweepCheckShape;
		if (!CombineInfo.bTramsformInit)
		{
			CombineInfo.SharingTransform = GetSocketWorldTransform(sweepCheckShape.SKComp, sweepCheckShape.SocketName);
			CombineInfo.bTramsformInit = true;
			return false;
		}
		return true;
	}

	private void CombineSweepCheckInternal_Single(ref FSweepCheckCombineInfo CombineInfo, float TriggerTime = 0f, string EndNotifyID = "")
	{
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) || SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen) || (EndNotifyID != "" && !CombineInfo.CombinedConfigShapeNotifyIDSet.Contains(EndNotifyID)) || !PrepareCombineSweepCheck(ref CombineInfo))
		{
			return;
		}
		FUStCheckShape sweepCheckShape = CombineInfo.SweepCheckShape;
		float WorldTime = Owner.World.GetTimeSeconds();
		bool flag = GSGameplayCVar.CVar_EnableSweepCheckRuntimeShowCollision.GetValueInGameThread() != 0 && (GSGameplayCVar.CVar_FilterPlayerSweepCheck.GetValueInGameThread() == 0 || !(OwnerAsCharacterCS is BGUPlayerCharacterCS));
		bool flag2 = GSGameplayCVar.CVar_ForceShowSweepCheckOptCollision.GetValueInGameThread() != 0;
		GSGameplayCVar.CVar_EnableSweepCheckShowHitTargetCollision.GetValueInGameThread();
		bool flag3 = GSGameplayCVar.CVar_DebugShowSweepCheck_SweepRange.GetValueInGameThread() != 0;
		bool num = GSGameplayCVar.CVar_DisableSweepCheckOpt.GetValueInGameThread() != 0;
		bool flag4 = GSGameplayCVar.CVar_DisableSweepCheckOpt2.GetValueInGameThread() != 0;
		bool flag5 = GSGameplayCVar.CVar_EnableSweepCheckEndDebug.GetValueInGameThread() != 0;
		FTransform sharingTransform = CombineInfo.SharingTransform;
		FTransform identity = FTransform.Identity;
		FGSSweepCheckShapeInfo SweepCheckShapeInfo = new FGSSweepCheckShapeInfo
		{
			SweepCheckShapeType = (sweepCheckShape.IsCapsuleShape ? EGSSweepCheckShapeType.CapsuleShape : EGSSweepCheckShapeType.SphereShape),
			ShapeParamFloat = sweepCheckShape.Radius * Owner.GetActorScale3D().X,
			ShapeParamVector = sweepCheckShape.Scale
		};
		if (TriggerTime > 0f && sweepCheckShape.SKComp == OwnerAsCharacterCS.Mesh)
		{
			identity = GetSocketCompTransformByTime(CombineInfo.SharingAnimation, sweepCheckShape.SocketName, TriggerTime, bExtractRootMotion: false, bRelativeTrans: true);
			identity *= sweepCheckShape.SKComp.GetSocketTransform(B1GlobalFNames.root);
			if (flag5)
			{
				UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(Owner.World, identity.GetLocation(), identity.Rotation, SweepCheckShapeInfo, FColor.Aqua);
				UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(Owner.World, sharingTransform.GetLocation(), sharingTransform.Rotation, SweepCheckShapeInfo, FColor.Green);
			}
		}
		else
		{
			identity = GetSocketWorldTransform(sweepCheckShape.SKComp, sweepCheckShape.SocketName);
		}
		FTransform fTransform = identity;
		float num2 = (identity.GetLocation() - sharingTransform.GetLocation()).Size();
		if (num2 == 0f)
		{
			fTransform.SetLocation(identity.GetLocation() + FVector.OneVector);
		}
		FVector StartPos = sharingTransform.GetLocation();
		FVector EndPos = identity.GetLocation();
		FQuat rotation = identity.Rotation;
		rotation *= sweepCheckShape.Rotation.ToOrientationQuat();
		float num3 = num2 / 2f + 500f;
		if (num2 > 0f && EndNotifyID == "")
		{
			CombineInfo.SharingTransform = fTransform;
		}
		if (!num)
		{
			num3 += (sweepCheckShape.IsCapsuleShape ? (FMath.Max(SweepCheckShapeInfo.ShapeParamVector.X, SweepCheckShapeInfo.ShapeParamVector.Y) + SweepCheckShapeInfo.ShapeParamVector.Z) : SweepCheckShapeInfo.ShapeParamFloat);
			if (!SweepCheckOptimize_bySimpleOverlap(sharingTransform.GetLocation(), fTransform.GetLocation(), num3, out var Actors_SimpleOverlap, out var SimpleOverlapFailed, CombineInfo.bCanHitProjectile))
			{
				if (flag && flag2)
				{
					if (flag3)
					{
						DebugDrawSweepCheck_SphereSweep(Owner.World, in StartPos, in EndPos, in SweepCheckShapeInfo, new FColor(100, 0, 50));
					}
					else
					{
						UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(Owner.World, fTransform.GetLocation(), fTransform.Rotation, SweepCheckShapeInfo, new FColor(100, 0, 50));
					}
				}
				return;
			}
			if (!SimpleOverlapFailed)
			{
				if (IsFakeSweepCheckEnable() && Actors_SimpleOverlap.Count > 0)
				{
					int count = CombineInfo.CombinedConfigShapeNotifyIDSet.Count;
					for (int i = 0; i < count; i++)
					{
						if (i < CombineInfo.CombinedConfigShapeNotifyIDSet.Count)
						{
							string SkillTaskUniqID = CombineInfo.CombinedConfigShapeNotifyIDSet[i];
							if (!SweepCheckHitData.SweepCheckConfigMap.TryGetValue(SkillTaskUniqID, out var value))
							{
								break;
							}
							GetEffectInst(in value, in EndPos, in StartPos, out var EffectInstReq);
							HandleFakeCheck(in Actors_SimpleOverlap, in value, in EffectInstReq, in SkillTaskUniqID);
						}
					}
					return;
				}
				if (!flag4 && !FilterSimpleOverlapResult_ByCombineInfo(in Actors_SimpleOverlap, in CombineInfo))
				{
					if (flag && flag2)
					{
						if (flag3)
						{
							DebugDrawSweepCheck_SphereSweep(Owner.World, in StartPos, in EndPos, in SweepCheckShapeInfo, new FColor(100, 0, 50));
						}
						else
						{
							UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(Owner.World, fTransform.GetLocation(), fTransform.Rotation, SweepCheckShapeInfo, new FColor(100, 0, 50));
						}
					}
					return;
				}
			}
		}
		if (flag)
		{
			if (flag3)
			{
				DebugDrawSweepCheck_SphereSweep(Owner.World, in StartPos, in EndPos, in SweepCheckShapeInfo, in FColor.Red);
			}
			else
			{
				UBGUFunctionLibraryForCS.BGUDrawSweepCheckShape(Owner.World, fTransform.GetLocation(), rotation, SweepCheckShapeInfo);
			}
		}
		List<FUStGSHitResult> SweepResults = new List<FUStGSHitResult>();
		UBGUFuncLibSelectTargets.BGUGetSweepCheckResultsByCollisionChannelWithCaster(Owner.World, sharingTransform, fTransform, rotation, SweepCheckChannel, SweepCheckShapeInfo, out SweepResults, null, null, OverlapChannelsForFilter, SweepCheckHitData.bShowSweepCheckShape, GetOwner(), -1, ESweepCheckType.SweepCheck);
		if (SweepResults == null || SweepResults.Count <= 0)
		{
			return;
		}
		if (EndNotifyID != "")
		{
			HandleHitResultEffect(in SweepResults, in EndNotifyID, in EndPos, in StartPos, in WorldTime, SweepCheckShapeInfo);
			return;
		}
		int count2 = CombineInfo.CombinedConfigShapeNotifyIDSet.Count;
		for (int j = 0; j < count2; j++)
		{
			if (j < CombineInfo.CombinedConfigShapeNotifyIDSet.Count)
			{
				HandleHitResultEffect(in SweepResults, CombineInfo.CombinedConfigShapeNotifyIDSet[j], in EndPos, in StartPos, in WorldTime, SweepCheckShapeInfo);
			}
		}
	}

	private void GetEffectInst(in FSweepCheckUnitConfig SweepCheckUnitConfig, in FVector EndSweepLoc, in FVector StartSweepLoc, out FEffectInstReq EffectInstReq)
	{
		EffectInstReq = new FEffectInstReq(GetOwner())
		{
			AudioID_HitChr = SweepCheckUnitConfig.HitChrAudioID,
			FXWeight_HitChr = SweepCheckUnitConfig.HitChrFXWeight,
			ObjectID = SweepCheckUnitConfig.ObjectID,
			HitActionDir = SweepCheckUnitConfig.HitCheckConf.HitActionDir,
			HitDiretionRealDir = (EndSweepLoc - StartSweepLoc).GetSafeNormal(),
			TriggerSkillId = SweepCheckUnitConfig.TriggerSkillID
		};
		FVector fVector = CalcHitDir(Owner, SweepCheckUnitConfig.HitCheckConf.HitActionDir);
		if (EffectInstReq.HitActionDir != EHitActionDir.Default)
		{
			float num = MathLib.DegAcos(FVector.DotProduct(fVector, EffectInstReq.HitDiretionRealDir));
			if (num > 30f)
			{
				EffectInstReq.HitDiretionRealDir += (fVector - EffectInstReq.HitDiretionRealDir) * (1f - 30f / num);
				EffectInstReq.HitDiretionRealDir = EffectInstReq.HitDiretionRealDir.GetSafeNormal();
			}
		}
		else
		{
			EffectInstReq.HitDiretionRealDir = fVector;
		}
		EffectInstReq.SweepCheckBegin = StartSweepLoc;
		EffectInstReq.SweepCheckEnd = EndSweepLoc;
	}

	private void HandleHitResultEffect(in List<FUStGSHitResult> CurSweepResults, in string NotifyID, in FVector EndSweepLoc, in FVector StartSweepLoc, in float WorldTime, FGSSweepCheckShapeInfo SweepCheckShapeForDebug)
	{
		if (!SweepCheckHitData.SweepCheckConfigMap.TryGetValue(NotifyID, out var value))
		{
			return;
		}
		GetEffectInst(in value, in EndSweepLoc, in StartSweepLoc, out var EffectInstReq);
		bool flag = GSGameplayCVar.CVar_EnableSweepCheckShowHitTargetCollision.GetValueInGameThread() != 0;
		bool flag2 = GSGameplayCVar.CVar_DebugShowSweepCheck_SweepRange.GetValueInGameThread() != 0;
		foreach (FUStGSHitResult CurSweepResult in CurSweepResults)
		{
			EffectInstReq.HitLocation = CurSweepResult.ImpactPoint;
			FVector normal = CurSweepResult.Normal;
			EffectInstReq.HitPointNormalDir = normal.Rotation();
			FName boneName = CurSweepResult.BoneName;
			EffectInstReq.HitBoneName = new FName(StringParseHelper.SafeToLower(boneName.ToString()));
			EffectInstReq.HitComp = CurSweepResult.HitComponent;
			if (CurSweepResult.Actor is IECSWorldObj iECSWorldObj && !iECSWorldObj.IsBeginPlayFinished())
			{
				continue;
			}
			if (CurSweepResult.Actor is BGUCharacterCS bGUCharacterCS)
			{
				if (SimpleStateData.HasSimpleState(EBGUSimpleState.CantSweepUnit) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.CantBeSweepChecked) || BGUFuncLibSelectTargetsCS.FilterSweepCheck(Owner, CurSweepResult.Actor, value.HitCheckConf.ResultFilterType))
				{
					continue;
				}
				int resID = FindHitVEffectID(Owner, value.EffectIDList);
				if (!(bGUCharacterCS != null))
				{
					continue;
				}
				IBUC_SpecialBoneListData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SpecialBoneListData, BUC_SpecialBoneListData>(bGUCharacterCS);
				if (readOnlyData == null || readOnlyData.ExcludedBonesFromSweepCheck.Contains(CurSweepResult.BoneName))
				{
					continue;
				}
				b1.IBUC_UnitBeAttackedFequenceData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_UnitBeAttackedFequenceData>(bGUCharacterCS);
				if (!readOnlyData2.CheckBeAttackedFequenceData(NotifyID) || !readOnlyData2.CheckBeAttackedGroupInfo(value.SweepCheckGroupID, value.FromInstanceID))
				{
					continue;
				}
				FUStHitVEffectDesc hitVEffectDesc = BGW_GameDB.GetHitVEffectDesc(resID);
				if (hitVEffectDesc != null)
				{
					BUC_UnitHitVEffectData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<BUC_UnitHitVEffectData>(Owner);
					if (readOnlyData3 != null && !readOnlyData3.CheckIsInFreezeFrameGap(WorldTime))
					{
						value.SweepCheckProtectTime += hitVEffectDesc.FreezeFrameTime;
					}
				}
				if (GSGameplayCVar.CVar_ScarDebug.GetValueInGameThread() == 1)
				{
					USystemLibrary.DrawDebugArrow(Owner, EffectInstReq.HitLocation, EffectInstReq.HitLocation + (EndSweepLoc - StartSweepLoc).GetSafeNormal() * 1000.0, 30f, FLinearColor.Red, 10f, 10f);
					USystemLibrary.DrawDebugArrow(Owner, EffectInstReq.HitLocation, EffectInstReq.HitLocation + CalcHitDir(Owner, value.HitCheckConf.HitActionDir) * 1000.0, 30f, FLinearColor.Yellow, 10f, 10f);
				}
				OnSweepCheckHit(CurSweepResult.Actor, value.SweepCheckProtectTime, NotifyID, in EffectInstReq, value.AbnormalStateEffectList, value.EffectsWithCondition_Before, value.EffectIDList, value.EffectsWithCondition_After, value.SweepCheckGroupID, value.FromInstanceID);
				if (flag)
				{
					if (flag2)
					{
						DebugDrawSweepCheck_SphereSweep(Owner.World, in StartSweepLoc, in EndSweepLoc, in SweepCheckShapeForDebug, in FColor.Aqua);
					}
					else
					{
						SweepCheckShapeForDebug.ShapeParamFloat *= 1.2f;
						UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(Owner.World, StartSweepLoc, FQuat.Identity, SweepCheckShapeForDebug, FColor.DarkGreen);
						UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(Owner.World, EndSweepLoc, FQuat.Identity, SweepCheckShapeForDebug, FColor.Aqua);
					}
				}
				if (DebugData.ZBBOwner != null)
				{
					HitForZBBInfo hitInfo = new HitForZBBInfo
					{
						HitWorldTime = WorldTime,
						NotifyBeginTime = value.NotifyBeginTime
					};
					BGUSkillPreviewSystem componentByClass = DebugData.ZBBOwner.GetComponentByClass<BGUSkillPreviewSystem>();
					if (componentByClass != null)
					{
						componentByClass.OnSendInfoToZBB(hitInfo);
					}
				}
			}
			else
			{
				if (value.IgnoreActors.Contains(CurSweepResult.Actor) || (SweepCheckHitData.SweepCheckGroupIgnoreActors.TryGetValue(value.SweepCheckGroupID, out var value2) && value2.Contains(CurSweepResult.Actor)))
				{
					continue;
				}
				if (BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_DestructibleData, b1.BUC_DestructibleData>(CurSweepResult.Actor) != null)
				{
					AddSweepCheckConfigIgnoreActor(value, CurSweepResult.Actor);
					if (!value.HitDestructibleActorConfig.EnableCanHitDestructible || value.HitDestructibleActorConfig.HitStrengthLevel == EGSHitDestructibleStrengthLevel.None || CurSweepResult.Actor.GetParentActor() == GetOwner())
					{
						continue;
					}
					if (flag)
					{
						if (flag2)
						{
							DebugDrawSweepCheck_SphereSweep(Owner.World, in StartSweepLoc, in EndSweepLoc, in SweepCheckShapeForDebug, in FColor.Aqua);
						}
						else
						{
							SweepCheckShapeForDebug.ShapeParamFloat *= 1.2f;
							UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(Owner.World, StartSweepLoc, FQuat.Identity, SweepCheckShapeForDebug, FColor.DarkGreen);
							UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(Owner.World, EndSweepLoc, FQuat.Identity, SweepCheckShapeForDebug, FColor.Aqua);
						}
					}
					float destructibleImpulse = BGUFunctionLibraryCS.GetDestructibleImpulse(Owner, value.HitDestructibleActorConfig.HitStrengthLevel);
					BUS_EventCollectionCS.Get(CurSweepResult.Actor)?.Evt_HitDestructible.Invoke(Owner, value.HitDestructibleActorConfig.HitStrengthLevel, value.HitDestructibleActorConfig.HitDirection, EffectInstReq, destructibleImpulse);
					continue;
				}
				if (value.CanHitProjectile && CurSweepResult.Actor is BGUProjectileBaseActor)
				{
					AddSweepCheckConfigIgnoreActor(value, CurSweepResult.Actor);
					BGUProjectileBaseActor bGUProjectileBaseActor = CurSweepResult.Actor as BGUProjectileBaseActor;
					BUS_EventCollectionCS.Get(bGUProjectileBaseActor)?.Evt_OnProjectileBeHitted?.Invoke(Owner, value.EffectIDList);
					if (flag)
					{
						if (flag2)
						{
							DebugDrawSweepCheck_SphereSweep(Owner.World, in StartSweepLoc, in EndSweepLoc, in SweepCheckShapeForDebug, in FColor.Aqua);
						}
						else
						{
							SweepCheckShapeForDebug.ShapeParamFloat *= 1.2f;
							UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(Owner.World, StartSweepLoc, FQuat.Identity, SweepCheckShapeForDebug, FColor.DarkGreen);
							UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(Owner.World, EndSweepLoc, FQuat.Identity, SweepCheckShapeForDebug, FColor.Aqua);
						}
					}
					foreach (int effectID in value.EffectIDList)
					{
						base.BUSEventCollection?.Evt_TriggerSkillEffect.Invoke(effectID, EffectInstReq, bGUProjectileBaseActor);
					}
					continue;
				}
				if (CurSweepResult.Actor is b1.BGUJJSObstacleBase)
				{
					AddSweepCheckConfigIgnoreActor(value, CurSweepResult.Actor);
					foreach (int effectID2 in value.EffectIDList)
					{
						BUS_EventCollectionCS.Get(CurSweepResult.Actor)?.Evt_HitJJSObstacle.Invoke(effectID2);
					}
					continue;
				}
				foreach (int item in value.EffectIDListForSceneItem)
				{
					base.BUSEventCollection?.Evt_TriggerSkillEffect.Invoke(item, EffectInstReq);
				}
				base.BUSEventCollection?.Evt_OnHitWorldItemPerform.Invoke(Owner.World, value.ObjectID, 0.5f, value.EffectIDList.ToList(), StartSweepLoc, EndSweepLoc, ref EffectInstReq);
			}
		}
	}

	private bool IsSameShape(in FUStCheckShape ShapeA, in FUStCheckShape ShapeB)
	{
		if (ShapeA.SocketName == ShapeB.SocketName && ShapeA.Radius == ShapeB.Radius && ShapeA.Scale == ShapeB.Scale && ShapeA.IsCapsuleShape == ShapeB.IsCapsuleShape && ShapeA.SKComp == ShapeB.SKComp)
		{
			return ShapeA.Rotation == ShapeB.Rotation;
		}
		return false;
	}

	private void SweepCheckEnd(int ObjectID, int FromInstanceID, float NotifyEndTime)
	{
		string NotifyInstID = Convert.ToString(FromInstanceID) + Convert.ToString(ObjectID);
		if (!SweepCheckHitData.SweepCheckConfigMap.ContainsKey(NotifyInstID))
		{
			return;
		}
		bool flag = CanCombineSweepCheck();
		if (!flag)
		{
			SweepCheckInternal(in NotifyInstID, NotifyEndTime);
		}
		if (SweepCheckHitData.CombineSweepCheck.Count > 0)
		{
			for (int num = SweepCheckHitData.CombineSweepCheck.Count - 1; num >= 0; num--)
			{
				int count = SweepCheckHitData.CombineSweepCheck.Count;
				if (num > count - 1)
				{
					break;
				}
				FSweepCheckCombineInfo CombineInfo = SweepCheckHitData.CombineSweepCheck[num];
				if (flag)
				{
					CombineSweepCheckInternal_Single(ref CombineInfo, NotifyEndTime, NotifyInstID);
				}
				if (SweepCheckHitData.CombineSweepCheck.Count == 0)
				{
					break;
				}
				if (!CombineInfo.TryRemoveConfigAndCheckValid(in NotifyInstID))
				{
					SweepCheckHitData.CombineSweepCheck.Remove(CombineInfo);
				}
			}
		}
		SweepCheckHitData.SweepCheckConfigMap.Remove(NotifyInstID);
		base.BUSEventCollection?.Evt_RemoveSpAtkReboundingAM.Invoke(ObjectID, IsLowAtkRebounding: false);
		base.BUSEventCollection?.Evt_RemoveSpAtkReboundingAM.Invoke(ObjectID, IsLowAtkRebounding: true);
	}

	private void OnClearSweepCheckData()
	{
		if (SweepCheckHitData != null)
		{
			SweepCheckHitData.AttackWarningConfigMap.Clear();
			SweepCheckHitData.CombineSweepCheck.Clear();
			SweepCheckHitData.SweepCheckConfigMap.Clear();
			SweepCheckHitData.SweepCheckGroupIgnoreActors.Clear();
		}
	}

	private void SetAllSweepCheckPaused(bool bPaused)
	{
		foreach (KeyValuePair<string, AttackWarningUnitConfig> item in SweepCheckHitData.AttackWarningConfigMap)
		{
			AttackWarningUnitConfig value = item.Value;
			value.bPaused = bPaused;
			if (bPaused)
			{
				value.TransformList.Clear();
			}
			else
			{
				InitSetPreCheckTransform(value.AttackWarnningCheckShape, value.TransformList);
			}
		}
		for (int i = 0; i < SweepCheckHitData.CombineSweepCheck.Count; i++)
		{
			int count = SweepCheckHitData.CombineSweepCheck.Count;
			if (i > count - 1)
			{
				break;
			}
			FSweepCheckCombineInfo CombineInfo = SweepCheckHitData.CombineSweepCheck[i];
			if (CombineInfo != null)
			{
				if (bPaused)
				{
					CombineInfo.bTramsformInit = false;
				}
				else
				{
					PrepareCombineSweepCheck(ref CombineInfo);
				}
			}
		}
	}

	private void SetAllAttackWarningPaused(bool bPaused)
	{
		foreach (KeyValuePair<string, AttackWarningUnitConfig> item in SweepCheckHitData.AttackWarningConfigMap)
		{
			AttackWarningUnitConfig value = item.Value;
			value.bPaused = bPaused;
			if (bPaused)
			{
				value.TransformList.Clear();
			}
			else
			{
				InitSetPreCheckTransform(value.AttackWarnningCheckShape, value.TransformList);
			}
			value.TransformList.Clear();
		}
	}

	private void AttackWarningCheckBegin(int FromInstanceID, int GroupID, int NotifyID, int WeaponIndex, List<FUStCheckShape> AttackWarnningCheckShape, FVector FixedLocalOffset, ESweepCheckHitFilterType ResultFilterType, int HitLevel, EHitActionDir HitActionDir, float Duration, UAnimSequenceBase Animation, float NotifyBeginTime)
	{
		string text = Convert.ToString(FromInstanceID) + Convert.ToString(NotifyID);
		if (!SweepCheckHitData.AttackWarningConfigMap.ContainsKey(text))
		{
			AttackWarningUnitConfig attackWarningUnitConfig = new AttackWarningUnitConfig
			{
				TransformList = new List<FTransform>(),
				IgnoreActors = new List<AActor>(),
				NotifyID = text,
				ObjectID = NotifyID,
				WeaponIndex = WeaponIndex,
				HitActionDir = HitActionDir,
				HitLevel = HitLevel,
				AttackWarnningCheckShape = AttackWarnningCheckShape,
				FixedLocalOffset = FixedLocalOffset,
				ResultFilterType = ResultFilterType,
				AttackWarnningGroupID = GroupID,
				FromInstanceID = FromInstanceID,
				Animation = Animation,
				NotifyBeginTime = NotifyBeginTime
			};
			attackWarningUnitConfig.IgnoreActors.Add(GetOwner());
			InitSetPreCheckTransform(attackWarningUnitConfig.AttackWarnningCheckShape, attackWarningUnitConfig.TransformList);
			attackWarningUnitConfig.TotalDuration = Duration;
			attackWarningUnitConfig.bCanTick = AttackWarningDistanceCheck(attackWarningUnitConfig);
			SweepCheckHitData.AttackWarningConfigMap.Add(text, attackWarningUnitConfig);
		}
	}

	private bool AttackWarningDistanceCheck(AttackWarningUnitConfig Config)
	{
		if (GSGameplayCVar.CVar_EnableAttackWarningDetaectOpt.GetValueInGameThread() == 0)
		{
			return true;
		}
		BGUCharacterCS ownerAsCharacterCS = OwnerAsCharacterCS;
		if (ownerAsCharacterCS != null && Config.TransformList.Count > 0)
		{
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(ownerAsCharacterCS);
			float num = 0f;
			FName fName = FName.None;
			FVector fVector2 = FVector.ZeroVector;
			OwnerAsCharacterCS.Mesh.GetWorldTransform();
			FTransform fTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(OwnerAsCharacterCS);
			FVector fVector3 = FVector.ZeroVector;
			USkeletalMeshComponent sKComp = OwnerAsCharacterCS.Mesh;
			for (int i = 0; i < Config.AttackWarnningCheckShape.Count; i++)
			{
				FUStCheckShape fUStCheckShape = Config.AttackWarnningCheckShape[i];
				FVector location = Config.TransformList[i].GetLocation();
				FVector fVector4 = location - fVector;
				float num2 = fVector4.Size();
				num2 += fUStCheckShape.Radius;
				num2 = (fUStCheckShape.IsCapsuleShape ? (FMath.Max(fUStCheckShape.Scale.X, fUStCheckShape.Scale.Y) + fUStCheckShape.Scale.Z) : num2);
				if (num2 > num)
				{
					num = num2;
					fName = Config.AttackWarnningCheckShape[i].SocketName;
					sKComp = Config.AttackWarnningCheckShape[i].SKComp;
					fVector2 = location;
					fVector3 = fVector4;
				}
			}
			float num3 = Config.TotalDuration * 0.5f;
			FVector location2 = (GetSocketCompTransformByTime(Config.Animation, fName, Config.NotifyBeginTime + Config.TotalDuration) * fTransform).GetLocation();
			FVector zeroVector = FVector.ZeroVector;
			zeroVector = (location2 - fVector2) / Config.TotalDuration;
			float num4 = UGSE_AnimFuncLib.ExtractRootMotionFromAnimation(Config.Animation, Config.NotifyBeginTime, Config.NotifyBeginTime + num3 * 2f).GetLocation().Size() / num3;
			num = (zeroVector * Config.TotalDuration + fVector3).Size();
			float num5 = SpeedCtrlData.GetMoveSpeedFast() * SpeedCtrlData.GetFinalSpeedCtrlRate();
			FVector fVector5 = BGUFuncLibActorTransformCS.BGUGetVelocity(ownerAsCharacterCS);
			if (fVector5.Size() < num4)
			{
				fVector5 = fVector5.GetSafeNormal() * num4;
			}
			FVector fVector6 = fVector5 + zeroVector;
			float num6 = fVector6.Size();
			FVector fVector7 = fVector6.GetSafeNormal() * fVector3.Size() * 2.0 / 3.0;
			num += (num6 + num5) * Config.TotalDuration;
			num = (Config.DetectDistance = FMath.Clamp(num, 800f, 50000f));
			Config.DetectSocketName = fName;
			Config.SKComp = sKComp;
			bool flag = false;
			if (OptimizeSimpleOverlap_ByMask(fVector2, 1, num, out var Actors_SimpleOverlap, out var SimpleOverlapFailed))
			{
				foreach (AActor item in Actors_SimpleOverlap)
				{
					BGUCharacterCS bGUCharacterCS = item as BGUCharacterCS;
					if (bGUCharacterCS != null && bGUCharacterCS != OwnerAsCharacterCS)
					{
						if (bGUCharacterCS is BGUPlayerCharacterCS)
						{
							flag = true;
							break;
						}
						if (TeamRelationData.IsEnemyTeam(ownerAsCharacterCS, bGUCharacterCS) && BGUFuncLibActorTransformCS.BGUGetCharacterHasBlockConfig(bGUCharacterCS))
						{
							flag = true;
							break;
						}
					}
				}
			}
			if (GSGameplayCVar.CVar_EnableAttackWarningDetaectShowCollision.GetValueInGameThread() != 0)
			{
				USystemLibrary.DrawDebugArrow(Owner, fVector, fVector + fVector5 * num3 * 2.0, 30f, FLinearColor.Green, Config.TotalDuration + 0.5f, 10f);
				USystemLibrary.DrawDebugArrow(Owner, fVector2, fVector2 + zeroVector * num3 * 2.0, 30f, FLinearColor.Yellow, Config.TotalDuration + 0.5f, 10f);
				USystemLibrary.DrawDebugArrow(Owner, fVector2, fVector2 + fVector7, 30f, FLinearColor.Red, Config.TotalDuration + 0.5f, 10f);
				USystemLibrary.DrawDebugSphere(Owner, fVector2 + fVector7, num, 30, flag ? FLinearColor.Orange : FLinearColor.Red, Config.TotalDuration + 0.5f, 10f);
			}
			return flag || SimpleOverlapFailed;
		}
		return false;
	}

	private bool FilterSimpleOverlapResult_Character(BGUCharacterCS BGUCharacterTarget, string NotifyID, in b1.IBUC_UnitBeAttackedFequenceData BeAttackedFequenceData)
	{
		if (BGUCharacterTarget != null)
		{
			if (SimpleStateData != null)
			{
				if (SimpleStateData.HasSimpleState(EBGUSimpleState.CantSweepUnit))
				{
					return false;
				}
				if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(BGUCharacterTarget, EBGUSimpleState.CantBeSweepChecked))
				{
					return false;
				}
			}
			if (BeAttackedFequenceData != null && !BeAttackedFequenceData.CheckBeAttackedFequenceData(NotifyID))
			{
				return false;
			}
			if (!SweepCheckHitData.SweepCheckConfigMap.TryGetValue(NotifyID, out var value))
			{
				return false;
			}
			if (value != null)
			{
				int sweepCheckGroupID = value.SweepCheckGroupID;
				int fromInstanceID = value.FromInstanceID;
				if (BeAttackedFequenceData != null && !BeAttackedFequenceData.CheckBeAttackedGroupInfo(sweepCheckGroupID, fromInstanceID))
				{
					return false;
				}
				if (BGUFuncLibSelectTargetsCS.FilterSweepCheck(Owner, BGUCharacterTarget, value.HitCheckConf.ResultFilterType))
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	private bool FilterSimpleOverlapResult_Destructible(AActor DestructibleTarget, string NotifyID, in b1.IBUC_DestructibleData DestructibleData)
	{
		if (DestructibleData != null)
		{
			if (!SweepCheckHitData.SweepCheckConfigMap.TryGetValue(NotifyID, out var value))
			{
				return false;
			}
			if (value != null && value.HitDestructibleActorConfig.HitStrengthLevel == EGSHitDestructibleStrengthLevel.None)
			{
				return false;
			}
			if (DestructibleData.IsDestroyed)
			{
				return false;
			}
		}
		return true;
	}

	private bool FilterSimpleOverlapResult_BySweepConfig(in List<AActor> Actors_SimpleOverlap, in FSweepCheckUnitConfig SweepConfig)
	{
		if (Actors_SimpleOverlap.Count > 0)
		{
			int count = Actors_SimpleOverlap.Count;
			int num = 0;
			for (int num2 = Actors_SimpleOverlap.Count - 1; num2 >= 0; num2--)
			{
				if (Actors_SimpleOverlap[num2] is BGUCharacterCS bGUCharacterCS)
				{
					if (bGUCharacterCS != null)
					{
						b1.IBUC_UnitBeAttackedFequenceData BeAttackedFequenceData = BGU_DataUtil.GetReadOnlyData<BUC_UnitBeAttackedFequenceData>(bGUCharacterCS);
						if (!FilterSimpleOverlapResult_Character(bGUCharacterCS, SweepConfig.NotifyID, in BeAttackedFequenceData))
						{
							num++;
						}
					}
					else
					{
						num++;
					}
				}
				else
				{
					AActor aActor = Actors_SimpleOverlap[num2];
					b1.IBUC_DestructibleData DestructibleData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_DestructibleData, b1.BUC_DestructibleData>(aActor);
					if (DestructibleData != null)
					{
						if (!FilterSimpleOverlapResult_Destructible(aActor, SweepConfig.NotifyID, in DestructibleData))
						{
							num++;
						}
					}
					else
					{
						num++;
					}
				}
			}
			return count > num;
		}
		return true;
	}

	private bool FilterSimpleOverlapResult_ByCombineInfo(in List<AActor> Actors_SimpleOverlap, in FSweepCheckCombineInfo CombineInfo)
	{
		if (Actors_SimpleOverlap.Count > 0)
		{
			int count = Actors_SimpleOverlap.Count;
			int num = 0;
			for (int num2 = Actors_SimpleOverlap.Count - 1; num2 >= 0; num2--)
			{
				if (Actors_SimpleOverlap[num2] is BGUCharacterCS bGUCharacterCS)
				{
					if (bGUCharacterCS != null)
					{
						int count2 = CombineInfo.CombinedConfigShapeNotifyIDSet.Count;
						int num3 = 0;
						b1.IBUC_UnitBeAttackedFequenceData BeAttackedFequenceData = BGU_DataUtil.GetReadOnlyData<BUC_UnitBeAttackedFequenceData>(bGUCharacterCS);
						for (int i = 0; i < count2; i++)
						{
							if (i < CombineInfo.CombinedConfigShapeNotifyIDSet.Count)
							{
								string text = CombineInfo.CombinedConfigShapeNotifyIDSet[i];
								if (SweepCheckHitData.SweepCheckConfigMap.TryGetValue(text, out var _) && !FilterSimpleOverlapResult_Character(bGUCharacterCS, text, in BeAttackedFequenceData))
								{
									num3++;
								}
							}
						}
						if (num3 == count2)
						{
							num++;
						}
					}
					else
					{
						num++;
					}
				}
				else
				{
					AActor aActor = Actors_SimpleOverlap[num2];
					b1.IBUC_DestructibleData DestructibleData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_DestructibleData, b1.BUC_DestructibleData>(aActor);
					int count3 = CombineInfo.CombinedConfigShapeNotifyIDSet.Count;
					int num4 = 0;
					if (DestructibleData != null)
					{
						for (int j = 0; j < count3; j++)
						{
							if (j < CombineInfo.CombinedConfigShapeNotifyIDSet.Count)
							{
								string notifyID = CombineInfo.CombinedConfigShapeNotifyIDSet[j];
								if (!FilterSimpleOverlapResult_Destructible(aActor, notifyID, in DestructibleData))
								{
									num4++;
								}
							}
						}
						if (num4 == count3)
						{
							num++;
						}
					}
				}
			}
			return count > num;
		}
		return true;
	}

	private void AttackWarningCheckEnd(int FromInstanceID, int NotifyID)
	{
		string key = Convert.ToString(FromInstanceID) + Convert.ToString(NotifyID);
		SweepCheckHitData.AttackWarningConfigMap.Remove(key);
	}

	private void SweepCheckAllNotify()
	{
		if (SweepCheckHitData.SweepCheckConfigMap.Count > 0)
		{
			StartSweepCheck(0f);
		}
	}

	private void DebugDrawSweepCheck_SphereSweep(in UWorld World, in FVector StartPos, in FVector EndPos, in FGSSweepCheckShapeInfo SweepCheckShapeInfo, in FColor Color)
	{
		if (SweepCheckShapeInfo.SweepCheckShapeType == EGSSweepCheckShapeType.SphereShape)
		{
			FVector fVector = EndPos - StartPos;
			FVector safeNormal = fVector.GetSafeNormal();
			FQuat fQuat = FQuat.FindBetween(FVector.UpVector, safeNormal);
			USystemLibrary.DrawDebugCapsule(LineColor: new FLinearColor(Color), WorldContextObject: World, Center: (EndPos + StartPos) / 2.0, HalfHeight: fVector.Size() / 2f + SweepCheckShapeInfo.ShapeParamFloat, Radius: SweepCheckShapeInfo.ShapeParamFloat, Rotation: fQuat.Rotator(), Duration: 0.5f, Thickness: 1f);
		}
	}

	private void SweepCheckInternal(in string NotifyInstID, float TriggerTime = 0f)
	{
		SingleSweepCheck(NotifyInstID, TriggerTime);
	}

	private void SingleSweepCheck(string NotifyInstID, float TriggerTime)
	{
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) || SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen) || !SweepCheckHitData.SweepCheckConfigMap.TryGetValue(NotifyInstID, out var SweepCheckUnitConfig) || SweepCheckUnitConfig.bPaused)
		{
			return;
		}
		bool flag = GSGameplayCVar.CVar_EnableSweepCheckRuntimeShowCollision.GetValueInGameThread() != 0 && (GSGameplayCVar.CVar_FilterPlayerSweepCheck.GetValueInGameThread() == 0 || !(OwnerAsCharacterCS is BGUPlayerCharacterCS));
		bool flag2 = GSGameplayCVar.CVar_ForceShowSweepCheckOptCollision.GetValueInGameThread() != 0;
		bool flag3 = GSGameplayCVar.CVar_EnableSweepCheckShowHitTargetCollision.GetValueInGameThread() != 0;
		bool flag4 = GSGameplayCVar.CVar_DebugShowSweepCheck_SweepRange.GetValueInGameThread() != 0;
		bool flag5 = GSGameplayCVar.CVar_DisableSweepCheckOpt.GetValueInGameThread() != 0;
		List<FTransform> list = new List<FTransform>();
		list = SweepCheckUnitConfig.TransformList;
		if (list != null && list.Count < 1)
		{
			InitSetPreCheckTransform(SweepCheckUnitConfig.SweepCheckShape, list);
			return;
		}
		float timeSeconds = Owner.World.GetTimeSeconds();
		for (int i = 0; i < SweepCheckUnitConfig.SweepCheckShape.Count; i++)
		{
			FUStCheckShape fUStCheckShape = SweepCheckUnitConfig.SweepCheckShape[i];
			FTransform preTransform = list[i];
			FTransform identity = FTransform.Identity;
			if (TriggerTime > 0f && fUStCheckShape.SKComp == OwnerAsCharacterCS.Mesh)
			{
				identity = GetSocketCompTransformByTime(SweepCheckUnitConfig.Animation, fUStCheckShape.SocketName, TriggerTime, bExtractRootMotion: false, bRelativeTrans: true);
				identity *= fUStCheckShape.SKComp.GetSocketTransform(B1GlobalFNames.root);
			}
			else
			{
				identity = GetSocketWorldTransform(fUStCheckShape.SKComp, fUStCheckShape.SocketName);
			}
			FTransform fTransform = identity;
			float num = (identity.GetLocation() - preTransform.GetLocation()).Size();
			if (num == 0f)
			{
				fTransform.SetLocation(identity.GetLocation() + FVector.OneVector);
			}
			FGSSweepCheckShapeInfo SweepCheckShapeInfo = new FGSSweepCheckShapeInfo
			{
				SweepCheckShapeType = (fUStCheckShape.IsCapsuleShape ? EGSSweepCheckShapeType.CapsuleShape : EGSSweepCheckShapeType.SphereShape),
				ShapeParamFloat = fUStCheckShape.Radius * Owner.GetActorScale3D().X,
				ShapeParamVector = fUStCheckShape.Scale
			};
			FVector StartPos = preTransform.GetLocation();
			FVector EndPos = identity.GetLocation();
			string SkillTaskUniqID = NotifyInstID;
			FEffectInstReq fEffectInstReq = new FEffectInstReq(GetOwner());
			fEffectInstReq.AudioID_HitChr = SweepCheckUnitConfig.HitChrAudioID;
			fEffectInstReq.FXWeight_HitChr = SweepCheckUnitConfig.HitChrFXWeight;
			fEffectInstReq.ObjectID = SweepCheckUnitConfig.ObjectID;
			fEffectInstReq.HitActionDir = SweepCheckUnitConfig.HitCheckConf.HitActionDir;
			fEffectInstReq.HitDiretionRealDir = (EndPos - StartPos).GetSafeNormal();
			fEffectInstReq.TriggerSkillId = SweepCheckUnitConfig.TriggerSkillID;
			FEffectInstReq EffectInstReq = fEffectInstReq;
			FVector fVector = CalcHitDir(Owner, SweepCheckUnitConfig.HitCheckConf.HitActionDir);
			if (EffectInstReq.HitActionDir != EHitActionDir.Default)
			{
				float num2 = MathLib.DegAcos(FVector.DotProduct(fVector, EffectInstReq.HitDiretionRealDir));
				if (num2 > 30f)
				{
					EffectInstReq.HitDiretionRealDir += (fVector - EffectInstReq.HitDiretionRealDir) * (1f - 30f / num2);
					EffectInstReq.HitDiretionRealDir = EffectInstReq.HitDiretionRealDir.GetSafeNormal();
				}
			}
			else
			{
				EffectInstReq.HitDiretionRealDir = fVector;
			}
			EffectInstReq.SweepCheckBegin = StartPos;
			EffectInstReq.SweepCheckEnd = EndPos;
			if (SweepCheckHitData.SweepCheckGroupIgnoreActors.TryGetValue(SweepCheckUnitConfig.SweepCheckGroupID, out var value))
			{
				SweepCheckUnitConfig.IgnoreActors = SweepCheckUnitConfig.IgnoreActors.Union(value).ToList();
			}
			FQuat rotation = identity.Rotation;
			rotation *= fUStCheckShape.Rotation.ToOrientationQuat();
			if (!flag5)
			{
				float num3 = num / 2f + 500f;
				num3 += (fUStCheckShape.IsCapsuleShape ? (FMath.Max(SweepCheckShapeInfo.ShapeParamVector.X, SweepCheckShapeInfo.ShapeParamVector.Y) + SweepCheckShapeInfo.ShapeParamVector.Z) : SweepCheckShapeInfo.ShapeParamFloat);
				if (!SweepCheckOptimize_bySimpleOverlap(preTransform.GetLocation(), fTransform.GetLocation(), num3, out var Actors_SimpleOverlap, out var SimpleOverlapFailed))
				{
					if (flag && flag2)
					{
						if (flag4)
						{
							DebugDrawSweepCheck_SphereSweep(Owner.World, in StartPos, in EndPos, in SweepCheckShapeInfo, new FColor(100, 0, 50));
						}
						else
						{
							UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(Owner.World, fTransform.GetLocation(), fTransform.Rotation, SweepCheckShapeInfo, new FColor(100, 0, 50));
						}
					}
					continue;
				}
				if (IsFakeSweepCheckEnable() && Actors_SimpleOverlap.Count > 0 && !SimpleOverlapFailed)
				{
					HandleFakeCheck(in Actors_SimpleOverlap, in SweepCheckUnitConfig, in EffectInstReq, in SkillTaskUniqID);
					continue;
				}
				if (!FilterSimpleOverlapResult_BySweepConfig(in Actors_SimpleOverlap, in SweepCheckUnitConfig) && !SimpleOverlapFailed)
				{
					if (flag && flag2)
					{
						if (flag4)
						{
							DebugDrawSweepCheck_SphereSweep(Owner.World, in StartPos, in EndPos, in SweepCheckShapeInfo, new FColor(100, 0, 50));
						}
						else
						{
							UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(Owner.World, fTransform.GetLocation(), fTransform.Rotation, SweepCheckShapeInfo, new FColor(100, 0, 50));
						}
					}
					continue;
				}
			}
			if (flag)
			{
				if (flag4)
				{
					DebugDrawSweepCheck_SphereSweep(Owner.World, preTransform.GetLocation(), fTransform.GetLocation(), in SweepCheckShapeInfo, in FColor.Red);
				}
				else
				{
					UBGUFunctionLibraryForCS.BGUDrawSweepCheckShape(Owner.World, fTransform.GetLocation(), rotation, SweepCheckShapeInfo);
				}
			}
			List<FUStGSHitResult> SweepResults = new List<FUStGSHitResult>();
			UBGUFuncLibSelectTargets.BGUGetSweepCheckResultsByCollisionChannelWithCaster(Owner.World, preTransform, fTransform, rotation, SweepCheckChannel, SweepCheckShapeInfo, out SweepResults, null, null, OverlapChannelsForFilter, SweepCheckHitData.bShowSweepCheckShape, GetOwner(), SweepCheckUnitConfig.SweepCheckGroupID, ESweepCheckType.SweepCheck);
			if (SweepResults != null && SweepResults.Count > 0)
			{
				foreach (FUStGSHitResult item in SweepResults)
				{
					EffectInstReq.HitLocation = item.ImpactPoint;
					FVector normal = item.Normal;
					EffectInstReq.HitPointNormalDir = normal.Rotation();
					FName boneName = item.BoneName;
					EffectInstReq.HitBoneName = new FName(StringParseHelper.SafeToLower(boneName.ToString()));
					EffectInstReq.HitComp = item.HitComponent;
					if (item.Actor is IECSWorldObj iECSWorldObj && !iECSWorldObj.IsBeginPlayFinished())
					{
						continue;
					}
					if (item.Actor is BGUCharacterCS bGUCharacterCS)
					{
						if (SimpleStateData.HasSimpleState(EBGUSimpleState.CantSweepUnit) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.CantBeSweepChecked) || BGUFuncLibSelectTargetsCS.FilterSweepCheck(Owner, item.Actor, SweepCheckUnitConfig.HitCheckConf.ResultFilterType))
						{
							continue;
						}
						int resID = FindHitVEffectID(Owner, SweepCheckUnitConfig.EffectIDList);
						if (!(bGUCharacterCS != null))
						{
							continue;
						}
						IBUC_SpecialBoneListData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SpecialBoneListData, BUC_SpecialBoneListData>(bGUCharacterCS);
						if (readOnlyData != null && readOnlyData.ExcludedBonesFromSweepCheck.Contains(item.BoneName))
						{
							continue;
						}
						FUStHitVEffectDesc hitVEffectDesc = BGW_GameDB.GetHitVEffectDesc(resID);
						if (hitVEffectDesc != null)
						{
							BUC_UnitHitVEffectData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_UnitHitVEffectData>(Owner);
							if (readOnlyData2 != null && !readOnlyData2.CheckIsInFreezeFrameGap(timeSeconds))
							{
								SweepCheckUnitConfig.SweepCheckProtectTime += hitVEffectDesc.FreezeFrameTime;
							}
						}
						if (GSGameplayCVar.CVar_ScarDebug.GetValueInGameThread() == 1)
						{
							USystemLibrary.DrawDebugArrow(Owner, EffectInstReq.HitLocation, EffectInstReq.HitLocation + (EndPos - StartPos).GetSafeNormal() * 1000.0, 30f, FLinearColor.Red, 10f, 10f);
							USystemLibrary.DrawDebugArrow(Owner, EffectInstReq.HitLocation, EffectInstReq.HitLocation + CalcHitDir(Owner, SweepCheckUnitConfig.HitCheckConf.HitActionDir) * 1000.0, 30f, FLinearColor.Yellow, 10f, 10f);
						}
						OnSweepCheckHit(item.Actor, SweepCheckUnitConfig.SweepCheckProtectTime, SkillTaskUniqID, in EffectInstReq, SweepCheckUnitConfig.AbnormalStateEffectList, SweepCheckUnitConfig.EffectsWithCondition_Before, SweepCheckUnitConfig.EffectIDList, SweepCheckUnitConfig.EffectsWithCondition_After, SweepCheckUnitConfig.SweepCheckGroupID, SweepCheckUnitConfig.FromInstanceID);
						if (flag3)
						{
							FGSSweepCheckShapeInfo sweepCheckShapeInfo = SweepCheckShapeInfo;
							if (flag4)
							{
								DebugDrawSweepCheck_SphereSweep(Owner.World, preTransform.GetLocation(), fTransform.GetLocation(), in SweepCheckShapeInfo, in FColor.Aqua);
							}
							else
							{
								sweepCheckShapeInfo.ShapeParamFloat *= 1.2f;
								UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(Owner.World, StartPos, preTransform.Rotation, sweepCheckShapeInfo, FColor.DarkGreen);
								UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(Owner.World, EndPos, fTransform.Rotation, sweepCheckShapeInfo, FColor.Aqua);
							}
						}
						if (DebugData.ZBBOwner != null)
						{
							HitForZBBInfo hitInfo = new HitForZBBInfo
							{
								HitWorldTime = timeSeconds,
								NotifyBeginTime = SweepCheckUnitConfig.NotifyBeginTime
							};
							BGUSkillPreviewSystem componentByClass = DebugData.ZBBOwner.GetComponentByClass<BGUSkillPreviewSystem>();
							if (componentByClass != null)
							{
								componentByClass.OnSendInfoToZBB(hitInfo);
							}
						}
						continue;
					}
					if (BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_DestructibleData, b1.BUC_DestructibleData>(item.Actor) != null)
					{
						AddSweepCheckConfigIgnoreActor(SweepCheckUnitConfig, item.Actor);
						if (flag3)
						{
							FGSSweepCheckShapeInfo sweepCheckShapeInfo2 = SweepCheckShapeInfo;
							if (flag4)
							{
								DebugDrawSweepCheck_SphereSweep(Owner.World, preTransform.GetLocation(), fTransform.GetLocation(), in SweepCheckShapeInfo, in FColor.Aqua);
							}
							else
							{
								sweepCheckShapeInfo2.ShapeParamFloat *= 1.2f;
								UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(Owner.World, StartPos, preTransform.Rotation, sweepCheckShapeInfo2, FColor.DarkGreen);
								UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(Owner.World, EndPos, fTransform.Rotation, sweepCheckShapeInfo2, FColor.Aqua);
							}
						}
						if (SweepCheckUnitConfig.HitDestructibleActorConfig.HitStrengthLevel != EGSHitDestructibleStrengthLevel.None && !(item.Actor.GetParentActor() == GetOwner()))
						{
							float destructibleImpulse = BGUFunctionLibraryCS.GetDestructibleImpulse(Owner, SweepCheckUnitConfig.HitDestructibleActorConfig.HitStrengthLevel);
							BUS_EventCollectionCS.Get(item.Actor)?.Evt_HitDestructible.Invoke(Owner, SweepCheckUnitConfig.HitDestructibleActorConfig.HitStrengthLevel, SweepCheckUnitConfig.HitDestructibleActorConfig.HitDirection, EffectInstReq, destructibleImpulse);
						}
						continue;
					}
					if (SweepCheckUnitConfig.CanHitProjectile && item.Actor is BGUProjectileBaseActor)
					{
						AddSweepCheckConfigIgnoreActor(SweepCheckUnitConfig, item.Actor);
						BGUProjectileBaseActor bGUProjectileBaseActor = item.Actor as BGUProjectileBaseActor;
						BUS_EventCollectionCS.Get(bGUProjectileBaseActor)?.Evt_OnProjectileBeHitted?.Invoke(Owner, SweepCheckUnitConfig.EffectIDList);
						foreach (int effectID in SweepCheckUnitConfig.EffectIDList)
						{
							base.BUSEventCollection?.Evt_TriggerSkillEffect.Invoke(effectID, EffectInstReq, bGUProjectileBaseActor);
						}
						continue;
					}
					if (item.Actor is b1.BGUJJSObstacleBase)
					{
						AddSweepCheckConfigIgnoreActor(SweepCheckUnitConfig, item.Actor);
						foreach (int effectID2 in SweepCheckUnitConfig.EffectIDList)
						{
							BUS_EventCollectionCS.Get(item.Actor)?.Evt_HitJJSObstacle.Invoke(effectID2);
						}
						continue;
					}
					foreach (int item2 in SweepCheckUnitConfig.EffectIDListForSceneItem)
					{
						base.BUSEventCollection?.Evt_TriggerSkillEffect.Invoke(item2, EffectInstReq);
					}
					base.BUSEventCollection?.Evt_OnHitWorldItemPerform.Invoke(Owner.World, SweepCheckUnitConfig.ObjectID, 0.5f, SweepCheckUnitConfig.EffectIDList.ToList(), StartPos, EndPos, ref EffectInstReq);
				}
			}
			if (num > 0f)
			{
				list[i] = fTransform;
			}
		}
	}

	private void AddSweepCheckConfigIgnoreActor(FSweepCheckUnitConfig SweepCheckUnitConfig, AActor Actor)
	{
		if (SweepCheckUnitConfig.SweepCheckGroupID != -1)
		{
			if (SweepCheckHitData.SweepCheckGroupIgnoreActors.TryGetValue(SweepCheckUnitConfig.SweepCheckGroupID, out var value))
			{
				if (!value.Contains(Actor))
				{
					value.Add(Actor);
				}
			}
			else
			{
				SweepCheckHitData.SweepCheckGroupIgnoreActors.Add(SweepCheckUnitConfig.SweepCheckGroupID, new List<AActor> { Actor });
			}
		}
		SweepCheckUnitConfig.IgnoreActors.Add(Actor);
	}

	private void AttackWarnningCheck(float DeltaTime)
	{
		if (SweepCheckHitData.AttackWarningConfigMap.Count < 1)
		{
			return;
		}
		AActor owner = GetOwner();
		if (owner.IsNullOrDestroyed() || SweepCheckHitData.AttackWarningConfigMap.Count <= 0)
		{
			return;
		}
		bool flag = GSGameplayCVar.CVar_EnableAttackWarningRuntimeShowCollision.GetValueInGameThread() != 0 && (GSGameplayCVar.CVar_FilterPlayerSweepCheck.GetValueInGameThread() == 0 || !(OwnerAsCharacterCS is BGUPlayerCharacterCS));
		bool flag2 = GSGameplayCVar.CVar_ForceShowSweepCheckOptCollision.GetValueInGameThread() != 0;
		bool flag3 = GSGameplayCVar.CVar_DebugShowSweepCheck_SweepRange.GetValueInGameThread() != 0;
		bool flag4 = GSGameplayCVar.CVar_DisableSweepCheckOpt.GetValueInGameThread() != 0;
		UWorld world = owner.World;
		string[] array = SweepCheckHitData.AttackWarningConfigMap.Keys.ToArray();
		List<FTransform> list = new List<FTransform>();
		List<FUStGSHitResult> SweepResults = new List<FUStGSHitResult>();
		ECollisionChannel collisionChannel = ECollisionChannel.ECC_GameTraceChannel6;
		GetOwner().World.GetTimeSeconds();
		string[] array2 = array;
		foreach (string key in array2)
		{
			AttackWarningUnitConfig attackWarningUnitConfig = SweepCheckHitData.AttackWarningConfigMap[key];
			if (attackWarningUnitConfig.bPaused)
			{
				continue;
			}
			attackWarningUnitConfig.AlreadyTickTime += DeltaTime;
			list = attackWarningUnitConfig.TransformList;
			if (!attackWarningUnitConfig.bCanTick && !(OwnerAsCharacterCS is BGUPlayerCharacterCS))
			{
				FVector zeroVector = FVector.ZeroVector;
				FVector zeroVector2 = FVector.ZeroVector;
				if (LocalPlayerSharedData != null)
				{
					zeroVector = LocalPlayerSharedData.CachedLocalPlayerLocation;
				}
				else
				{
					APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(owner);
					APawn aPawn = ((firstLocalPlayerController != null) ? firstLocalPlayerController.GetControlledPawn() : null);
					zeroVector = ((aPawn != null) ? BGUFuncLibActorTransformCS.BGUGetActorLocation(aPawn) : FVector.ZeroVector);
				}
				zeroVector2 = ((!(attackWarningUnitConfig.SKComp != null) || !FNameExtension.NotEqualTo(attackWarningUnitConfig.DetectSocketName, FName.None)) ? BGUFuncLibActorTransformCS.BGUGetActorLocation(owner) : GetSocketWorldTransform(attackWarningUnitConfig.SKComp, attackWarningUnitConfig.DetectSocketName).GetLocation());
				if (FVector.Distance(zeroVector2, zeroVector) <= attackWarningUnitConfig.DetectDistance)
				{
					attackWarningUnitConfig.bCanTick = true;
				}
			}
			if (list != null && list.Count < 1)
			{
				InitSetPreCheckTransform(attackWarningUnitConfig.AttackWarnningCheckShape, list);
			}
			for (int j = 0; j < attackWarningUnitConfig.AttackWarnningCheckShape.Count; j++)
			{
				FUStCheckShape fUStCheckShape = attackWarningUnitConfig.AttackWarnningCheckShape[j];
				FTransform preTransform = list[j];
				FTransform identity = FTransform.Identity;
				identity = GetSocketWorldTransform(fUStCheckShape.SKComp, fUStCheckShape.SocketName);
				FTransform fTransform = identity;
				float num = (identity.GetLocation() - preTransform.GetLocation()).Size();
				if (num == 0f)
				{
					fTransform.SetLocation(identity.GetLocation() + FVector.OneVector);
				}
				if (num > 0f)
				{
					list[j] = fTransform;
				}
				FGSSweepCheckShapeInfo SweepCheckShapeInfo = new FGSSweepCheckShapeInfo
				{
					SweepCheckShapeType = (fUStCheckShape.IsCapsuleShape ? EGSSweepCheckShapeType.CapsuleShape : EGSSweepCheckShapeType.SphereShape),
					ShapeParamFloat = fUStCheckShape.Radius * owner.GetActorScale3D().X,
					ShapeParamVector = fUStCheckShape.Scale
				};
				if (!attackWarningUnitConfig.bCanTick && !flag4)
				{
					if (flag && flag2)
					{
						if (flag3)
						{
							DebugDrawSweepCheck_SphereSweep(owner.World, preTransform.GetLocation(), identity.GetLocation(), in SweepCheckShapeInfo, new FColor(150, 150, 80));
						}
						else
						{
							UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(world, identity.GetLocation(), identity.Rotation, SweepCheckShapeInfo, new FColor(150, 150, 80));
						}
					}
					continue;
				}
				FQuat rotation = identity.Rotation;
				rotation *= new FQuat(new FVector(1.0, 0.0, 0.0), (float)Math.PI / (180f / fUStCheckShape.Rotation.X));
				rotation *= new FQuat(new FVector(0.0, 1.0, 0.0), (float)Math.PI / (180f / fUStCheckShape.Rotation.Y));
				rotation *= new FQuat(new FVector(0.0, 0.0, 1.0), (float)Math.PI / (180f / fUStCheckShape.Rotation.Z));
				if (!flag4)
				{
					float num2 = num / 2f + 500f;
					num2 += (fUStCheckShape.IsCapsuleShape ? (FMath.Max(SweepCheckShapeInfo.ShapeParamVector.X, SweepCheckShapeInfo.ShapeParamVector.Y) + SweepCheckShapeInfo.ShapeParamVector.Z) : SweepCheckShapeInfo.ShapeParamFloat);
					if (!SweepCheckOptimize_bySimpleOverlap(preTransform.GetLocation(), fTransform.GetLocation(), num2, out var _, out var _))
					{
						if (flag && flag2)
						{
							if (flag3)
							{
								DebugDrawSweepCheck_SphereSweep(owner.World, preTransform.GetLocation(), identity.GetLocation(), in SweepCheckShapeInfo, new FColor(150, 150, 80));
							}
							else
							{
								UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(world, identity.GetLocation(), identity.Rotation, SweepCheckShapeInfo, new FColor(150, 150, 80));
							}
						}
						continue;
					}
				}
				if (GSGameplayCVar.CVar_EnableAttackWarningRuntimeShowCollision.GetValueInGameThread() != 0)
				{
					if (flag3)
					{
						DebugDrawSweepCheck_SphereSweep(owner.World, preTransform.GetLocation(), identity.GetLocation(), in SweepCheckShapeInfo, in FColor.Yellow);
					}
					else
					{
						UBGUFunctionLibraryForCS.BguDrawSweepCheckShapeWithColor(world, fTransform.GetLocation(), rotation, SweepCheckShapeInfo, FColor.Yellow);
					}
				}
				SweepResults.Clear();
				UBGUFuncLibSelectTargets.BGUGetSweepCheckResultsByCollisionChannelWithCaster(world, preTransform, fTransform, rotation, collisionChannel, SweepCheckShapeInfo, out SweepResults, attackWarningUnitConfig.IgnoreActors, null, OverlapChannelsForFilter_AttackWarning, SweepCheckHitData.bShowSweepCheckShape, GetOwner(), attackWarningUnitConfig.AttackWarnningGroupID, ESweepCheckType.AttackWarning);
				if (SweepResults == null || SweepResults.Count <= 0)
				{
					continue;
				}
				foreach (FUStGSHitResult item in SweepResults)
				{
					AActor owner2 = item.HitComponent.GetOwner();
					if (owner2 == null || (owner2 is IECSWorldObj iECSWorldObj && !iECSWorldObj.IsBeginPlayFinished()) || !TeamRelationData.IsEnemyTeam(owner, owner2) || !(owner2 is BGUCharacterCS actor) || SimpleStateData.HasSimpleState(EBGUSimpleState.CantSweepUnit) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(owner2, EBGUSimpleState.CantBeSweepChecked))
					{
						continue;
					}
					bool flag5 = false;
					switch (attackWarningUnitConfig.ResultFilterType)
					{
					case ESweepCheckHitFilterType.FilterMaster:
						if (MasterData != null && MasterData.GetMasterActor() == owner2)
						{
							continue;
						}
						break;
					case ESweepCheckHitFilterType.NotInSameTeam:
						if (!TeamRelationData.IsEnemyTeam(owner, owner2))
						{
							continue;
						}
						break;
					}
					if (!flag5)
					{
						if (GSGameplayCVar.CVar_EnableAttackWarningRuntimeShowCollision.GetValueInGameThread() != 0)
						{
							DebugDrawSweepCheck_SphereSweep(owner.World, preTransform.GetLocation(), identity.GetLocation(), in SweepCheckShapeInfo, in FColor.Yellow);
						}
						float montageTime = UBGUFuncLibSkill.BGUCalcMontageNeedModifyTotalTime(OwnerAsCharacterCS, attackWarningUnitConfig.FromInstanceID);
						BUS_EventCollectionCS.Get(actor).Evt_SweepCheckInPreciseDodgeRange.Invoke(owner, attackWarningUnitConfig.FromInstanceID, attackWarningUnitConfig.AttackWarnningGroupID, attackWarningUnitConfig.ObjectID, montageTime);
						BUS_EventCollectionCS.Get(actor).Evt_TriggerBlock.Invoke(owner, attackWarningUnitConfig.FromInstanceID, attackWarningUnitConfig.AttackWarnningGroupID, attackWarningUnitConfig.ObjectID, montageTime, attackWarningUnitConfig.HitLevel, attackWarningUnitConfig.HitActionDir);
					}
				}
			}
		}
	}

	private bool OptimizeSimpleOverlap_ByMask(FVector Pos, int Mask, float OverlapRadius, out List<AActor> Actors_SimpleOverlap, out bool SimpleOverlapFailed)
	{
		Actors_SimpleOverlap = null;
		bool allActorsBySimpleOverlapWithTypeFilter = BGUFuncLibSelectTargetsCS.GetAllActorsBySimpleOverlapWithTypeFilter(Owner, Owner, Pos, Mask, OverlapRadius, 0f, 0f, FVector2D.ZeroVector, bIsSphere: true, out Actors_SimpleOverlap);
		if (Actors_SimpleOverlap.Count > 0)
		{
			for (int i = 0; i < Actors_SimpleOverlap.Count; i++)
			{
				if (Actors_SimpleOverlap[i] == Owner)
				{
					Actors_SimpleOverlap.RemoveAt(i);
				}
			}
		}
		SimpleOverlapFailed = !allActorsBySimpleOverlapWithTypeFilter;
		if (Actors_SimpleOverlap.Count <= 0)
		{
			return !allActorsBySimpleOverlapWithTypeFilter;
		}
		return true;
	}

	private bool SweepCheckOptimize_bySimpleOverlap(FVector PrePos, FVector CurPos, float OverlapRadius, out List<AActor> Actors_SimpleOverlap, out bool SimpleOverlapFailed, bool bCanHitProjectile = true)
	{
		Actors_SimpleOverlap = null;
		FVector pos = (PrePos + CurPos) / 2.0;
		int num = 0;
		num++;
		if (bCanHitProjectile)
		{
			num += 2;
		}
		num += 4;
		num += 8;
		float overlapRadius = OverlapRadius + 1000f;
		return OptimizeSimpleOverlap_ByMask(pos, num, overlapRadius, out Actors_SimpleOverlap, out SimpleOverlapFailed);
	}

	private FVector CalcHitDir(AActor OwnerActor, EHitActionDir HitActionDir)
	{
		FVector result = FVector.ZeroVector;
		switch (HitActionDir)
		{
		case EHitActionDir.Default:
			result = CalcHitDir(OwnerActor, (EHitActionDir)UB1Util.GetRandomNumberInt(1, 6));
			break;
		case EHitActionDir.Up:
			result = OwnerActor.GetActorUpVector();
			break;
		case EHitActionDir.Down:
			result = OwnerActor.GetActorUpVector() * -1.0;
			break;
		case EHitActionDir.Left:
			result = OwnerActor.GetActorRightVector() * -1.0;
			break;
		case EHitActionDir.Right:
			result = OwnerActor.GetActorRightVector();
			break;
		case EHitActionDir.Front:
			result = OwnerActor.GetActorForwardVector();
			break;
		case EHitActionDir.Back:
			result = OwnerActor.GetActorForwardVector() * -1.0;
			break;
		}
		return result;
	}

	private void InitSetPreCheckTransform(List<FUStCheckShape> CheckShapes, List<FTransform> CheckPreTransform)
	{
		for (int i = 0; i < CheckShapes.Count; i++)
		{
			FUStCheckShape fUStCheckShape = CheckShapes[i];
			FTransform socketWorldTransform = GetSocketWorldTransform(fUStCheckShape.SKComp, fUStCheckShape.SocketName);
			CheckPreTransform.Add(socketWorldTransform);
		}
	}

	private FTransform GetSocketCompTransformByTime(UAnimSequenceBase AnimSeq, FName SocketName, float Time, bool bExtractRootMotion = true, bool bRelativeTrans = false)
	{
		if (!USystemLibrary.IsValid(AnimSeq))
		{
			return FTransform.Identity;
		}
		if (AnimSeq.IsA<UAnimSequence>())
		{
			return UGSE_AnimFuncLib.Sequence_GetBoneTransformCS(AnimSeq as UAnimSequence, Time, SocketName, bExtractRootMotion: true);
		}
		if (!bRelativeTrans)
		{
			return UGSE_AnimFuncLib.Montage_GetBoneTransformCS(AnimSeq as UAnimMontage, Time, SocketName, FName.None, bExtractRootMotion);
		}
		return UGSE_AnimFuncLib.Montage_GetBoneRelativeTransformCS(AnimSeq as UAnimMontage, Time, SocketName, FName.None, bExtractRootMotion);
	}

	private FTransform GetSocketWorldTransform(USkeletalMeshComponent MeshComp, FName SocketName)
	{
		if (!USystemLibrary.IsValid(MeshComp))
		{
			return FTransform.Identity;
		}
		return MeshComp.GetSocketTransform(SocketName);
	}

	private int FindHitVEffectID(AActor OwnerActor, List<int> EffectIDList)
	{
		int result = 0;
		foreach (int EffectID in EffectIDList)
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, OwnerActor);
			if (skillEffectDesc != null && skillEffectDesc.EffectType == EBuffAndSkillEffectType.SkillDamage)
			{
				result = skillEffectDesc.EffectParamsInt[0];
				break;
			}
		}
		return result;
	}

	private void OnUnitCastSkillSuccess(int MappingSkillID, int OriSkillID, ECastSkillSourceType SourceType)
	{
		SweepCheckHitData.SweepCheckGroupIgnoreActors.Clear();
	}

	private bool IsFakeSweepCheckEnable()
	{
		return BattleFieldPerformanceOptData.bUnitNeedOpt(GuidData.GetFinalGuid());
	}

	private void HandleFakeCheck(in List<AActor> Actors_SimpleOverlap, in FSweepCheckUnitConfig SweepCheckUnitConfig, in FEffectInstReq EffectInstReq, in string SkillTaskUniqID)
	{
		if (Actors_SimpleOverlap != null && Actors_SimpleOverlap.Count >= 1)
		{
			return;
		}
		foreach (AActor item in Actors_SimpleOverlap)
		{
			if (item is BGUCharacterCS)
			{
				if (item is IECSWorldObj iECSWorldObj && !iECSWorldObj.IsBeginPlayFinished())
				{
					break;
				}
				if (!SimpleStateData.HasSimpleState(EBGUSimpleState.CantSweepUnit) && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(item, EBGUSimpleState.CantBeSweepChecked) && !BGUFuncLibSelectTargetsCS.FilterSweepCheck(Owner, item, SweepCheckUnitConfig.HitCheckConf.ResultFilterType))
				{
					OnSweepCheckHit(item, SweepCheckUnitConfig.SweepCheckProtectTime, SkillTaskUniqID, in EffectInstReq, SweepCheckUnitConfig.AbnormalStateEffectList, SweepCheckUnitConfig.EffectsWithCondition_Before, SweepCheckUnitConfig.EffectIDList, SweepCheckUnitConfig.EffectsWithCondition_After, SweepCheckUnitConfig.SweepCheckGroupID, SweepCheckUnitConfig.FromInstanceID);
				}
			}
		}
	}
}
