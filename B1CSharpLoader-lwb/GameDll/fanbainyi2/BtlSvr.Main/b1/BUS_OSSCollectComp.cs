using System;
using b1.BGW;
using b1.EventDelDefine;
using BtlShare;
using Google.Protobuf.Collections;
using OssB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_OSSCollectComp : UActorCompBaseCS
{
	private BGW_EventCollection BGWE;

	private bool bEventBinded;

	private IBGC_TeamRelationData TeamRelationData;

	private IBUC_GuidData GuidData;

	private IBUC_AttrContainer AttrContainer;

	private IBPC_PlayerRoleData LocalPlayerRoleData;

	private BUC_OSSCollectData OSSCollectData;

	public static bool Config_AlreadySet = false;

	public static FOSSConfig OSSConfig;

	public static int SkillID_BajieTimeUp = 509962;

	public static int SkillID_BajieBossLowHP = 509963;

	private BGU_ActorType OwnerActorType { get; set; }

	private IBGC_LocalPlayerSharedData LocalPlayerSharedData { get; set; }

	private IBIC_BossRushData BossRushData { get; set; }

	private void OnAttachBossRush()
	{
		TeamRelationData = RequireReadOnlyGameStateData<IBGC_TeamRelationData, BGC_TeamRelationData>();
		BGWE = BGW_EventCollection.Get(Owner);
		if (BGWE != null)
		{
			BGW_EventCollection bGWE = BGWE;
			bGWE.Evt_BeginBossRushBattle = (Del_Void)Delegate.Combine(bGWE.Evt_BeginBossRushBattle, new Del_Void(BossRushBegin));
			BGW_EventCollection bGWE2 = BGWE;
			bGWE2.Evt_EndBossRushBattle = (Del_Void)Delegate.Combine(bGWE2.Evt_EndBossRushBattle, new Del_Void(BossRushEnd));
			BGW_EventCollection bGWE3 = BGWE;
			bGWE3.Evt_FinishBossRushBattle = (Del_Void)Delegate.Combine(bGWE3.Evt_FinishBossRushBattle, new Del_Void(BossRushEnd));
			BGW_EventCollection bGWE4 = BGWE;
			bGWE4.Evt_FailedBossRushBattle = (Del_Void)Delegate.Combine(bGWE4.Evt_FailedBossRushBattle, new Del_Void(BossRushEnd));
		}
		if (B1Global.GIsBossRushMode)
		{
			BossRushBegin();
		}
	}

	private void BossRushBegin()
	{
		if (!bEventBinded)
		{
			bEventBinded = true;
			BindBossRushEvent();
		}
	}

	private void BossRushEnd()
	{
		if (bEventBinded)
		{
			bEventBinded = false;
			UnBindBossRushEvent();
		}
	}

	private void BindBossRushEvent()
	{
		if (!Owner.IsNullOrDestroyed() && !(base.BUSEventCollection == null))
		{
			base.BUSEventCollection.Evt_UpdateOSSDefenceData += new Del_OSSBattle(OnMonsterBeHurted_BossRush);
		}
	}

	private void UnBindBossRushEvent()
	{
		if (!Owner.IsNullOrDestroyed() && !(base.BUSEventCollection == null))
		{
			base.BUSEventCollection.Evt_UpdateOSSDefenceData -= new Del_OSSBattle(OnMonsterBeHurted_BossRush);
		}
	}

	private bool bSendCondition_OnMonsterBeHurted()
	{
		if (TeamRelationData == null || LocalPlayerSharedData == null || LocalPlayerSharedData.FirstLocalPlayerPawn.IsNullOrDestroyed())
		{
			return false;
		}
		return TeamRelationData.IsEnemyTeam(Owner, LocalPlayerSharedData.FirstLocalPlayerPawn);
	}

	private void OnMonsterBeHurted_BossRush(int SkillId, AActor Attacker, int DamageValue, bool bIsCrit, bool bIsElemDot)
	{
		if (bSendCondition_OnMonsterBeHurted())
		{
			IBUC_FollowPartnerData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_FollowPartnerData, b1.BUC_FollowPartnerData>(Attacker);
			if (readOnlyData == null || (!readOnlyData.IsAssociationUnit && !readOnlyData.IsFollowPartnerUnit))
			{
				BGWE?.Evt_BBC_OnMonsterBeHurted(DamageValue, bIsCrit, bIsElemDot);
			}
		}
	}

	private void OnEndPlayBossRush(EEndPlayReason EndPlayReason)
	{
		if (BGWE != null)
		{
			BGW_EventCollection bGWE = BGWE;
			bGWE.Evt_BeginBossRushBattle = (Del_Void)Delegate.Remove(bGWE.Evt_BeginBossRushBattle, new Del_Void(BossRushBegin));
			BGW_EventCollection bGWE2 = BGWE;
			bGWE2.Evt_EndBossRushBattle = (Del_Void)Delegate.Remove(bGWE2.Evt_EndBossRushBattle, new Del_Void(BossRushEnd));
			BGW_EventCollection bGWE3 = BGWE;
			bGWE3.Evt_FinishBossRushBattle = (Del_Void)Delegate.Remove(bGWE3.Evt_FinishBossRushBattle, new Del_Void(BossRushEnd));
			BGW_EventCollection bGWE4 = BGWE;
			bGWE4.Evt_FailedBossRushBattle = (Del_Void)Delegate.Remove(bGWE4.Evt_FailedBossRushBattle, new Del_Void(BossRushEnd));
		}
	}

	public override void OnAttach()
	{
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		LocalPlayerRoleData = RequireReadOnlyLocalPlayerControlData<IBPC_PlayerRoleData, BPC_PlayerRoleData>();
		OSSCollectData = RequireWritableData<BUC_OSSCollectData>();
		OwnerActorType = BGU_DataUtil.GetActorType(Owner);
		LocalPlayerSharedData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>(Owner);
		BossRushData = RequireReadonlyGameInstanceData<IBIC_BossRushData, BIC_BossRushData>();
		if (LocalPlayerRoleData != null && LocalPlayerSharedData != null)
		{
			BindEvent();
			OnAttachBossRush();
		}
	}

	public override void PreBeginPlay()
	{
		InitConfig();
		InitOSSDataType();
	}

	private void InitOSSDataType()
	{
		if (IsPlayerCharacter())
		{
			OSSCollectData.OSS_CharacterType = EOSS_CharacterType.Player;
		}
		else
		{
			if (!IsAiCharacter())
			{
				return;
			}
			OSSCollectData.BattleAiData = new BattleMonster();
			OSSCollectData.BattleAiData.Quality = GetQuality();
			if (BGU_DataUtil.GetActorTeamID(Owner) != 1)
			{
				OSSCollectData.OSS_CharacterType = EOSS_CharacterType.Monster;
				OSSCollectData.bIsSpecialMonster = IsSpecialMonster();
				if (OSSCollectData.bIsSpecialMonster)
				{
					base.BUSEventCollection.Evt_AddLocalPlayerIntoHatredList += new Del_Void(AddLocalPlayerIntoHatredList);
					base.BGSEventCollection.Evt_BGS_LocalPlayerDead_ForOSS += new Del_Void(OnLocalPlayerDead);
				}
			}
			else
			{
				OSSCollectData.OSS_CharacterType = EOSS_CharacterType.AiPartner;
			}
		}
	}

	private void BindEvent()
	{
		base.BUSEventCollection.Evt_UnitCastSkillSuccess += new Del_UnitCastSkillSuccess(OnUnitCastSkillSuccess);
		base.BUSEventCollection.Evt_OnSkillEnd += new Del_Void_Int(OnSkillEnded);
		base.BUSEventCollection.Evt_UpdateOSSAttackData += new Del_OSSBattle(OnUpdateOSSAttackData);
		base.BUSEventCollection.Evt_UpdateOSSDefenceData += new Del_OSSBattle(OnUpdateOSSDefenceData);
		base.BUSEventCollection.Evt_NotifyBattleStateChange += new Del_NotifyBattleStateChange(BeforeReportSelfData);
		if (IsAiCharacter())
		{
			base.BUSEventCollection.Evt_NotifyBattleStateChange += new Del_NotifyBattleStateChange(OnOSSCollectBattleData_AiUnit);
			base.BGSEventCollection.Evt_BGS_EarlyTerminateAiUnitBattleRecord += new Del_Void(EarlyTerminateAiUnitBattleRecord);
		}
	}

	private void InitConfig()
	{
		if (!Config_AlreadySet)
		{
			BGWDataAsset_OSSCollectionConfig bGWDataAsset_OSSCollectionConfig = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<BGWDataAsset_OSSCollectionConfig>("BGWDataAsset_OSSCollectionConfig'/Game/00Main/DataAsset/DA_OSSCollectionConfig.DA_OSSCollectionConfig'", ELoadResourceType.SyncLoadAndCache);
			if (bGWDataAsset_OSSCollectionConfig != null)
			{
				OSSConfig.Battle_SpellFire_AngelUnit = bGWDataAsset_OSSCollectionConfig.Battle_SpellFire_AngelUnit;
				OSSConfig.Battle_SpellFire_DistanceUnit = bGWDataAsset_OSSCollectionConfig.Battle_SpellFire_DistanceUnit;
				Config_AlreadySet = true;
			}
		}
	}

	private void EarlyTerminateAiUnitBattleRecord()
	{
		OnOSSCollectBattleData_AiUnit(IsFight: false);
	}

	private void OnOSSCollectBattleData_AiUnit(bool IsFight)
	{
		if (OSSCollectData.IsFight == IsFight)
		{
			return;
		}
		if (IsFight)
		{
			int quality = OSSCollectData.BattleAiData.Quality;
			OSSCollectData.BattleAiData = new BattleMonster();
			OSSCollectData.BattleAiData.Caller = GetCaller();
			OSSCollectData.BattleAiData.Quality = quality;
			OSSCollectData.BattleAiData.ExtendId = OwnerAsCharacterCS.GetFinalBattleInfoExtendID();
			OSSCollectData.BattleAiData.Guid = GuidData.GetFinalGuid();
			OSSCollectData.BattleAiData.HpMax = (int)AttrContainer.GetFloatValue(EBGUAttrFloat.HpMax);
			if (OSSCollectData.BeginFightTime < GetTotalGameTime())
			{
				OSSCollectData.BeginFightTime = GetTotalGameTime();
			}
			SpecialMonsterFightDataRecordBegin();
		}
		else
		{
			if (!OSSCollectData.bIsRecordingBattleInfo())
			{
				return;
			}
			OSSCollectData.BattleAiData.Dur = GetTotalGameTime() - OSSCollectData.BeginFightTime;
			OSSCollectData.BeginFightTime = -1;
			if (AttrContainer.GetFloatValue(EBGUAttrFloat.Hp) <= 0f)
			{
				OSSCollectData.BattleAiData.EndType = BattleEndType.Die;
			}
			else
			{
				OSSCollectData.BattleAiData.EndType = BattleEndType.Detach;
			}
			if (OSSCollectData.bHasExtEndType)
			{
				OSSCollectData.BattleAiData.EndType = OSSCollectData.Ext_EndType;
			}
			SpecialMonsterFightDataRecordEnd();
			switch (OSSCollectData.OSS_CharacterType)
			{
			case EOSS_CharacterType.AiPartner:
				if (base.BGSEventCollection != null && base.BGSEventCollection.HasBeginPlay)
				{
					base.BGSEventCollection.Evt_BGS_SetOSSAiPartnerInfo.Invoke(OSSCollectData.BattleAiData);
				}
				break;
			case EOSS_CharacterType.Monster:
				if (base.BGSEventCollection != null && base.BGSEventCollection.HasBeginPlay)
				{
					base.BGSEventCollection.Evt_BGS_SetOSSMonstInfo.Invoke(OSSCollectData.BattleAiData);
				}
				break;
			}
		}
		OSSCollectData.IsFight = IsFight;
	}

	private void OnUnitCastSkillSuccess(int MappingSkillId, int OriSkillID, ECastSkillSourceType SourceType)
	{
		OSSCollectData.SkillHitActorInfo.OnSkillStart(MappingSkillId);
		if (!OSSCollectData.IsFight || !IsDataValid())
		{
			return;
		}
		OnUnitCastSkillSuccess_Bajie(MappingSkillId);
		RepeatedField<Attack> repeatedField = (IsPlayerCharacter() ? OSSCollectData.BattlePlayerData.Atk : OSSCollectData.BattleAiData.Atk);
		bool flag = true;
		foreach (Attack item in repeatedField)
		{
			if (item.Id == MappingSkillId)
			{
				item.Num++;
				flag = false;
				break;
			}
		}
		if (flag)
		{
			Attack attack = new Attack();
			attack.Id = MappingSkillId;
			attack.Num = 1;
			attack.Dmg = 0;
			attack.Target = 0;
			repeatedField.Add(attack);
		}
		if (!IsAiCharacter() || OSSCollectData.BattleAiData == null)
		{
			return;
		}
		IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(Owner);
		if (readOnlyData == null)
		{
			return;
		}
		AActor lockTargetActor = readOnlyData.GetTargetInfo().LockTargetActor;
		if (lockTargetActor == null)
		{
			return;
		}
		FVector2D fVector2D = Owner.GetActorLocation().Conv_VectorToVector2D();
		FVector2D fVector2D2 = lockTargetActor.GetActorLocation().Conv_VectorToVector2D();
		int num = (int)FVector2D.Distance(fVector2D, fVector2D2);
		FVector2D v = Owner.GetActorForwardVector().Conv_VectorToVector2D();
		FVector2D v2 = fVector2D2 - fVector2D;
		v.Normalize();
		v2.Normalize();
		float num2 = MathLib.DegAcos(MathLib.DotProduct2D(v, v2));
		FVector2D v3 = Owner.GetActorRightVector().Conv_VectorToVector2D();
		v3.Normalize();
		if (MathLib.DotProduct2D(v3, v2) < 0f)
		{
			num2 = 360f - num2;
		}
		int num3 = ((OSSConfig.Battle_SpellFire_AngelUnit > 0) ? OSSConfig.Battle_SpellFire_AngelUnit : 45);
		int num4 = ((OSSConfig.Battle_SpellFire_DistanceUnit > 0) ? OSSConfig.Battle_SpellFire_DistanceUnit : 2);
		bool flag2 = false;
		for (int i = 0; i < OSSCollectData.BattleAiData.SpellFires.Count; i++)
		{
			if (OSSCollectData.BattleAiData.SpellFires[i].Id != MappingSkillId)
			{
				continue;
			}
			int num5 = (int)num2 / num3;
			if (OSSCollectData.BattleAiData.SpellFires[i].Angle == num5)
			{
				int num6 = (num / num4 + 1) * num4;
				int dist = OSSCollectData.BattleAiData.SpellFires[i].Dist;
				if (num6 == dist)
				{
					flag2 = true;
					OSSCollectData.BattleAiData.SpellFires[i].Num++;
				}
			}
		}
		if (!flag2)
		{
			SpellFire spellFire = new SpellFire();
			spellFire.Id = MappingSkillId;
			int angle = (int)num2 / num3;
			spellFire.Angle = angle;
			spellFire.Dist = (num / num4 + 1) * num4;
			spellFire.Num = 1;
			OSSCollectData.BattleAiData.SpellFires.Add(spellFire);
		}
	}

	private void OnUnitCastSkillSuccess_Bajie(int SkillId)
	{
		if (OSSCollectData.IsFight)
		{
			if (SkillId == SkillID_BajieTimeUp)
			{
				OSSCollectData.bHasExtEndType = true;
				OSSCollectData.Ext_EndType = BattleEndType.BajieTimeup;
			}
			else if (SkillId == SkillID_BajieBossLowHP)
			{
				OSSCollectData.bHasExtEndType = true;
				OSSCollectData.Ext_EndType = BattleEndType.BajieBosslowhp;
			}
		}
	}

	private void OnSkillEnded(int SkillId)
	{
		if (OSSCollectData.IsFight && IsDataValid())
		{
			SettleSkillHitActorCount(SkillId);
			OSSCollectData.SkillHitActorInfo.OnSkillEnded(SkillId);
		}
	}

	private void SettleSkillHitActorCount(int SkillId = -1)
	{
		SkillId = ((SkillId == -1) ? OSSCollectData.SkillHitActorInfo.GetCurSkillID() : SkillId);
		if (SkillId <= 0)
		{
			return;
		}
		int curSkillHitActorNum = OSSCollectData.SkillHitActorInfo.GetCurSkillHitActorNum();
		if (curSkillHitActorNum > 0)
		{
			foreach (Attack item in IsPlayerCharacter() ? OSSCollectData.BattlePlayerData.Atk : OSSCollectData.BattleAiData.Atk)
			{
				if (item.Id == SkillId)
				{
					item.Target += curSkillHitActorNum;
					break;
				}
			}
		}
		OSSCollectData.SkillHitActorInfo.Clear();
	}

	private void OnUpdateOSSAttackData(int SkillId, AActor Victim, int DamageValue, bool bIsCrit, bool bIsElemDot)
	{
		if (!OSSCollectData.IsFight || !IsDataValid())
		{
			return;
		}
		RepeatedField<Attack> repeatedField = (IsPlayerCharacter() ? OSSCollectData.BattlePlayerData.Atk : OSSCollectData.BattleAiData.Atk);
		bool flag = false;
		foreach (Attack item in repeatedField)
		{
			if (item.Id == SkillId)
			{
				item.Dmg += DamageValue;
				item.Hit++;
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Attack attack = new Attack();
			attack.Id = SkillId;
			attack.Num = 1;
			attack.Dmg = DamageValue;
			attack.Hit = 1;
			attack.Target = 1;
			repeatedField.Add(attack);
		}
		OSSCollectData.SkillHitActorInfo.OnSkillCostDmg(SkillId, Victim);
	}

	private void OnUpdateOSSDefenceData(int SkillId, AActor Attacker, int DamageValue, bool bIsCrit, bool bIsElemDot)
	{
		if (!OSSCollectData.IsFight || !IsDataValid())
		{
			return;
		}
		RepeatedField<Defence> repeatedField = (IsPlayerCharacter() ? OSSCollectData.BattlePlayerData.Def : OSSCollectData.BattleAiData.Def);
		bool flag = true;
		ulong num = 0uL;
		if (IsPlayerCharacter(Attacker))
		{
			ABGUCharacter aBGUCharacter = Attacker as ABGUCharacter;
			if (aBGUCharacter != null)
			{
				IBPC_RoleBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>(aBGUCharacter.PlayerState);
				if (readOnlyData != null)
				{
					num = readOnlyData.RoleId;
				}
			}
		}
		foreach (Defence item in repeatedField)
		{
			if (item.Id == SkillId && item.RoleId == num)
			{
				item.Num++;
				item.Dmg += DamageValue;
				if (AttrContainer.GetFloatValue(EBGUAttrFloat.Hp) <= 0f)
				{
					item.IsKill = 1;
				}
				else
				{
					item.IsKill = 0;
				}
				if (!IsPlayerCharacter(Attacker))
				{
					item.IsMonst = 1;
				}
				else
				{
					item.IsMonst = 0;
				}
				flag = false;
				break;
			}
		}
		if (flag)
		{
			Defence defence = new Defence();
			defence.Id = SkillId;
			defence.Num = 1;
			defence.Dmg = DamageValue;
			if (AttrContainer.GetFloatValue(EBGUAttrFloat.Hp) <= 0f)
			{
				defence.IsKill = 1;
			}
			else
			{
				defence.IsKill = 0;
			}
			if (!IsPlayerCharacter(Attacker))
			{
				defence.IsMonst = 1;
			}
			else
			{
				defence.IsMonst = 0;
				defence.RoleId = num;
			}
			repeatedField.Add(defence);
		}
	}

	private void BeforeReportSelfData(bool bInFight)
	{
		if (!bInFight)
		{
			SettleSkillHitActorCount();
		}
	}

	private bool IsAiCharacter()
	{
		return OwnerActorType == BGU_ActorType.CharacterAI;
	}

	private bool IsPlayerCharacter()
	{
		return OwnerActorType == BGU_ActorType.CharacterPlayer;
	}

	private bool IsPlayerCharacter(AActor Attacker)
	{
		return OwnerActorType == BGU_ActorType.CharacterPlayer;
	}

	private int GetTotalGameTime()
	{
		return LocalPlayerRoleData.GetGameTotalTime();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (Config_AlreadySet)
		{
			Config_AlreadySet = false;
			OSSConfig = default(FOSSConfig);
		}
		if (IsAiCharacter() && OSSCollectData.IsFight)
		{
			OnOSSCollectBattleData_AiUnit(IsFight: false);
		}
		if (IsAiCharacter())
		{
			base.BGSEventCollection.Evt_BGS_EarlyTerminateAiUnitBattleRecord -= new Del_Void(EarlyTerminateAiUnitBattleRecord);
			if (OSSCollectData.bIsSpecialMonster)
			{
				base.BGSEventCollection.Evt_BGS_LocalPlayerDead_ForOSS -= new Del_Void(OnLocalPlayerDead);
			}
		}
		OnEndPlayBossRush(EndPlayReason);
	}

	private bool IsDataValid()
	{
		if (IsPlayerCharacter())
		{
			if (OSSCollectData.BattlePlayerData == null)
			{
				return false;
			}
		}
		else if (IsAiCharacter() && OSSCollectData.BattleAiData == null)
		{
			return false;
		}
		return true;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateSpecialMonsterData();
	}

	private bool IsSpecialMonster()
	{
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(OwnerAsCharacterCS.GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc != null)
		{
			EUnitQualityType qualityType = unitBattleInfoExtendDesc.QualityType;
			if (qualityType - 5 <= EUnitQualityType.Captain)
			{
				return true;
			}
		}
		return false;
	}

	private void SpecialMonsterFightDataRecordBegin()
	{
		if (OSSCollectData.bIsSpecialMonster)
		{
			OSSCollectData.TotalFrame = 0;
			OSSCollectData.TotalFrameRate = 0f;
			OSSCollectData.CurBattle_HasPlayerIn = false;
			float currentFPS = UGSE_SystemSettingsFuncLib.GetCurrentFPS();
			OSSCollectData.BattleAiData.MinFps = (int)currentFPS;
			OSSCollectData.BattleAiData.MaxFps = (int)currentFPS;
		}
	}

	private void SpecialMonsterFightDataRecordEnd()
	{
		if (OSSCollectData.bIsSpecialMonster)
		{
			OSSCollectData.TotalFrame = 0;
			OSSCollectData.TotalFrameRate = 0f;
			OSSCollectData.CurBattle_HasPlayerIn = false;
		}
	}

	private void UpdateSpecialMonsterData()
	{
		if (OSSCollectData.bIsSpecialMonster && OSSCollectData.IsFight)
		{
			OSSCollectData.TotalFrame++;
			float currentFPS = UGSE_SystemSettingsFuncLib.GetCurrentFPS();
			OSSCollectData.TotalFrameRate += currentFPS;
			OSSCollectData.BattleAiData.AvgFps = (int)(OSSCollectData.TotalFrameRate / (float)OSSCollectData.TotalFrame);
			OSSCollectData.BattleAiData.MinFps = FMath.Min(OSSCollectData.BattleAiData.MinFps, (int)currentFPS);
			OSSCollectData.BattleAiData.MaxFps = FMath.Max(OSSCollectData.BattleAiData.MaxFps, (int)currentFPS);
		}
	}

	private void AddLocalPlayerIntoHatredList()
	{
		if (Owner.IsNullOrDestroyed() || (BossRushData != null && BossRushData.BossRushType != EBossRushType.None))
		{
			return;
		}
		if (!OSSCollectData.CurBattle_HasPlayerIn)
		{
			string finalGuid = GuidData.GetFinalGuid();
			int finalBattleInfoExtendID = OwnerAsCharacterCS.GetFinalBattleInfoExtendID();
			int num = 0;
			APawn aPawn = LocalPlayerSharedData.FirstLocalPlayerPawn;
			if (aPawn.IsNullOrDestroyed())
			{
				APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner.World);
				if (!firstLocalPlayerController.IsNullOrDestroyed())
				{
					aPawn = firstLocalPlayerController.GetControlledPawn();
				}
			}
			if (aPawn.IsNullOrDestroyed())
			{
				return;
			}
			IBPC_PlayerAttrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerAttrData, BPC_PlayerAttrData>(aPawn.PlayerState);
			if (readOnlyData != null && readOnlyData.KeyMonsterMeetCount.TryGetValue(finalGuid, out var OutValue))
			{
				num = OutValue;
			}
			if (num == 0)
			{
				ReportEventMonsterFirstMeet reportEventMonsterFirstMeet = new ReportEventMonsterFirstMeet();
				reportEventMonsterFirstMeet.Guid = finalGuid;
				reportEventMonsterFirstMeet.ExtendId = finalBattleInfoExtendID;
				reportEventMonsterFirstMeet.Player = BGUFuncLibPlayer.GetPlayerInfoBattleData(aPawn);
				reportEventMonsterFirstMeet.Quality = OSSCollectData.BattleAiData.Quality;
				EventReporter.GetInstance(Owner)?.MonsterFirstMeet(reportEventMonsterFirstMeet);
			}
			if (LocalPlayerSharedData != null && LocalPlayerSharedData.FirstLocalPlayerController != null)
			{
				BPS_EventCollectionCS.GetLocal(Owner)?.Evt_BPS_OnKeyMonsterFightWithLocalPlayer.Invoke(finalGuid);
			}
			OSSCollectData.BattleAiData.BattleCount = num + 1;
		}
		OSSCollectData.CurBattle_HasPlayerIn = true;
	}

	private void OnLocalPlayerDead()
	{
		if (Owner.IsNullOrDestroyed() || (BossRushData != null && BossRushData.BossRushType != EBossRushType.None) || !OSSCollectData.IsFight || GuidData == null)
		{
			return;
		}
		string finalGuid = GuidData.GetFinalGuid();
		APawn aPawn = LocalPlayerSharedData.FirstLocalPlayerPawn;
		if (aPawn.IsNullOrDestroyed())
		{
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner.World);
			if (!firstLocalPlayerController.IsNullOrDestroyed())
			{
				aPawn = firstLocalPlayerController.GetControlledPawn();
			}
		}
		if (!aPawn.IsNullOrDestroyed())
		{
			BPS_EventCollectionCS.GetLocal(Owner)?.Evt_BPS_OnPlayerDeadWhenBattleWithKeyMonster.Invoke(finalGuid);
			IBPC_PlayerAttrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerAttrData, BPC_PlayerAttrData>(aPawn.PlayerState);
			int playerDieTimes = 1;
			if (readOnlyData != null && readOnlyData.KeyMonsterBattlePlayerDieTimes.TryGetValue(finalGuid, out var OutValue))
			{
				playerDieTimes = OutValue;
			}
			OSSCollectData.BattleAiData.PlayerDieTimes = playerDieTimes;
		}
	}

	private int GetQuality()
	{
		return ((int?)BGW_GameDB.GetUnitBattleInfoExtendDesc(OwnerAsCharacterCS.GetFinalBattleInfoExtendID())?.QualityType) ?? (-1);
	}

	private int GetCaller()
	{
		BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(Owner);
		if (readOnlyData != null)
		{
			BGUCharacterCS bGUCharacterCS = readOnlyData.GetMasterActor() as BGUCharacterCS;
			if (bGUCharacterCS != null && bGUCharacterCS != Owner)
			{
				return bGUCharacterCS.GetFinalBattleInfoExtendID();
			}
		}
		return -1;
	}
}
