using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using B1UI.GSUI;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW;

public static class PreloadAssetHelper
{
	private static readonly int MovieLevelBeginID = 1000000;

	public static Dictionary<int, Dictionary<string, EAssetPriority>> sUnitDescResourcCache = new Dictionary<int, Dictionary<string, EAssetPriority>>();

	public static Dictionary<int, Dictionary<string, EAssetPriority>> sUnitDescResourcCache_IgnoreFX = new Dictionary<int, Dictionary<string, EAssetPriority>>();

	public static Dictionary<int, Dictionary<string, EAssetPriority>> sCommonDescResourceCache_Monster = new Dictionary<int, Dictionary<string, EAssetPriority>>();

	public static Dictionary<int, Dictionary<string, EAssetPriority>> sCommonDescResourceCache_Monster_IgnoreFX = new Dictionary<int, Dictionary<string, EAssetPriority>>();

	public static Dictionary<int, Dictionary<string, EAssetPriority>> sCommonDescResourceCache_Player_IgnoreFX = new Dictionary<int, Dictionary<string, EAssetPriority>>();

	public static Dictionary<int, Dictionary<string, EAssetPriority>> sCommonDescResourceCache_Player = new Dictionary<int, Dictionary<string, EAssetPriority>>();

	private static void AddItemToLoadPath(Dictionary<string, EAssetPriority> LoadPath, string Path, EAssetPriority Priority)
	{
		if (!LoadPath.TryGetValue(Path, out var _))
		{
			LoadPath.Add(Path, Priority);
		}
	}

	private static void OnAddToLoadPath(Type DescType, Dictionary<string, EAssetPriority> LoadPath)
	{
	}

	private static void AddToResourcePathList(string Path, ref Dictionary<string, EAssetPriority> ResourcePathList, EAssetPriority LoadPriority)
	{
		if (!string.IsNullOrEmpty(Path) && !ResourcePathList.ContainsKey(Path))
		{
			ResourcePathList.Add(Path, LoadPriority);
		}
	}

	public static bool GetUnitTransStagePreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath, bool IsIgnoreAllFX)
	{
		return false;
	}

	public static bool GetUnitDeadPreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath)
	{
		Dictionary<int, FUStUnitDeadDesc> unitDeadDescDicByUnitResID = BGW_GameDB.GetUnitDeadDescDicByUnitResID(ConfigID);
		if (unitDeadDescDicByUnitResID == null)
		{
			return false;
		}
		foreach (KeyValuePair<int, FUStUnitDeadDesc> item in unitDeadDescDicByUnitResID)
		{
			FUStUnitDeadDesc value = item.Value;
			if (value != null)
			{
				AddItemToLoadPath(LoadPath, value.DeadPAPath, EAssetPriority.High);
				AddItemToLoadPath(LoadPath, value.DeadUseFrozenFracture, EAssetPriority.High);
				AddItemToLoadPath(LoadPath, value.ThrowUpCurve, EAssetPriority.High);
				OnAddToLoadPath(value.GetType(), LoadPath);
			}
		}
		return true;
	}

	public static bool GetLevelUpDescPreloadData(int ResID, int OverrideID, Dictionary<string, EAssetPriority> LoadPath)
	{
		FUStUnitLevelUpDesc unitLevelUpDesc = BGW_GameDB.GetUnitLevelUpDesc(ResID, OverrideID);
		if (unitLevelUpDesc == null)
		{
			return false;
		}
		AddItemToLoadPath(LoadPath, unitLevelUpDesc.CommAbnormalAttrConfigPath, EAssetPriority.Top);
		return true;
	}

	public static bool GetUnitPhysicalAnimationPreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath)
	{
		FUStUnitPhysicalAnimationDesc unitPhysicalAnimationDesc = BGW_GameDB.GetUnitPhysicalAnimationDesc(ConfigID);
		if (unitPhysicalAnimationDesc != null)
		{
			AddItemToLoadPath(LoadPath, unitPhysicalAnimationDesc.NormalPhysAnimDataAsset, EAssetPriority.High);
			AddItemToLoadPath(LoadPath, unitPhysicalAnimationDesc.BeCatchThrowPhysAnimDataAsset, EAssetPriority.High);
			AddItemToLoadPath(LoadPath, unitPhysicalAnimationDesc.PhysMoveAnimDataAsset, EAssetPriority.High);
			OnAddToLoadPath(unitPhysicalAnimationDesc.GetType(), LoadPath);
			return true;
		}
		return false;
	}

	public static bool GetSummonCommPreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath, bool IsIgnoreAllFX)
	{
		FUStSummonCommDesc originalSummonCommDesc = BGW_GameDB.GetOriginalSummonCommDesc(ConfigID);
		if (originalSummonCommDesc != null)
		{
			AddItemToLoadPath(LoadPath, originalSummonCommDesc.SummonTamerTemplatePath, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, originalSummonCommDesc.SummonBPTemplatePath, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, originalSummonCommDesc.SummonDataAssetsPath, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, originalSummonCommDesc.SummonSpawnEQSPath, EAssetPriority.Medium);
			if (!IsIgnoreAllFX)
			{
				AddItemToLoadPath(LoadPath, originalSummonCommDesc.BornEffectPath, EAssetPriority.Low);
			}
			if (originalSummonCommDesc.UseBornSkill == EGSYesNo.Yes)
			{
				foreach (int bornSkill in originalSummonCommDesc.BornSkillList)
				{
					GetSkillSPreloadData(bornSkill, LoadPath);
				}
			}
			else
			{
				foreach (string bornMontagePath in originalSummonCommDesc.BornMontagePathList)
				{
					AddItemToLoadPath(LoadPath, bornMontagePath, EAssetPriority.Medium);
				}
			}
			foreach (string disappearMontagePath in originalSummonCommDesc.DisappearMontagePathList)
			{
				AddItemToLoadPath(LoadPath, disappearMontagePath, EAssetPriority.Medium);
			}
			OnAddToLoadPath(originalSummonCommDesc.GetType(), LoadPath);
			return true;
		}
		return false;
	}

	public static bool GetUnitTransPreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath, bool IsIgnoreAllFX)
	{
		FUStUnitTransCommDesc unitTransCommDesc = BGW_GameDB.GetUnitTransCommDesc(ConfigID);
		if (unitTransCommDesc != null)
		{
			AddItemToLoadPath(LoadPath, unitTransCommDesc.BPPath, EAssetPriority.High);
			LoadPlayerSkillRelatedResource(unitTransCommDesc.UnitBornSkillID, IsIgnoreAllFX, ref LoadPath);
			LoadPlayerSkillRelatedResource(unitTransCommDesc.NewUnitBornSkillID, IsIgnoreAllFX, ref LoadPath);
			OnAddToLoadPath(unitTransCommDesc.GetType(), LoadPath);
			return true;
		}
		return false;
	}

	public static bool GetPlayerImmobilizeSkillConfigPreloadData(Dictionary<string, EAssetPriority> LoadPath, bool IsIgnoreAllFX)
	{
		foreach (KeyValuePair<int, FUStImmobilizeSkillConfigDesc> item in BGW_GameDB.GetAllImmobilizeSkillConfigDesc())
		{
			FUStImmobilizeSkillConfigDesc value = item.Value;
			if (value == null)
			{
				continue;
			}
			foreach (FPlayFXByResID beginFX in value.BeginFXs)
			{
				AddItemToLoadPath(LoadPath, beginFX.FXPathByDBC, EAssetPriority.Medium);
			}
			foreach (FPlayFXByResID almostEndFX in value.AlmostEndFXs)
			{
				AddItemToLoadPath(LoadPath, almostEndFX.FXPathByDBC, EAssetPriority.Medium);
			}
			foreach (FPlayFXByResID endFX in value.EndFXs)
			{
				AddItemToLoadPath(LoadPath, endFX.FXPathByDBC, EAssetPriority.Medium);
			}
			foreach (FPlayFXByResID quickEndFX in value.QuickEndFXs)
			{
				AddItemToLoadPath(LoadPath, quickEndFX.FXPathByDBC, EAssetPriority.Medium);
			}
		}
		return true;
	}

	public static bool GetUnitImmobilizeSkillConfigPreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath, bool IsIgnoreAllFX)
	{
		FUStImmobilizeSkillConfigDesc immobilizeSkillConfigDesc = BGW_GameDB.GetImmobilizeSkillConfigDesc(ConfigID);
		if (immobilizeSkillConfigDesc != null)
		{
			foreach (FPlayFXByResID beginFX in immobilizeSkillConfigDesc.BeginFXs)
			{
				AddItemToLoadPath(LoadPath, beginFX.FXPathByDBC, EAssetPriority.Medium);
			}
			foreach (FPlayFXByResID almostEndFX in immobilizeSkillConfigDesc.AlmostEndFXs)
			{
				AddItemToLoadPath(LoadPath, almostEndFX.FXPathByDBC, EAssetPriority.Medium);
			}
			foreach (FPlayFXByResID endFX in immobilizeSkillConfigDesc.EndFXs)
			{
				AddItemToLoadPath(LoadPath, endFX.FXPathByDBC, EAssetPriority.Medium);
			}
			foreach (FPlayFXByResID quickEndFX in immobilizeSkillConfigDesc.QuickEndFXs)
			{
				AddItemToLoadPath(LoadPath, quickEndFX.FXPathByDBC, EAssetPriority.Medium);
			}
			return true;
		}
		return false;
	}

	public static bool GetUnitIronConfigPreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath, bool IsIgnoreAllFX)
	{
		FUStIronBodyConfigDesc originalIronBodyConfigDesc = BGW_GameDB.GetOriginalIronBodyConfigDesc(ConfigID);
		if (originalIronBodyConfigDesc != null)
		{
			foreach (FUStIronBodyBuffTriggerInfo startTriggerInfo in originalIronBodyConfigDesc.StartTriggerInfoList)
			{
				GetBuffPreloadData(startTriggerInfo.BuffID, LoadPath, IsIgnoreAllFX: false);
			}
			foreach (FUStIronBodyBuffTriggerInfo defeatTriggerInfo in originalIronBodyConfigDesc.DefeatTriggerInfoList)
			{
				GetBuffPreloadData(defeatTriggerInfo.BuffID, LoadPath, IsIgnoreAllFX: false);
			}
			foreach (FUStIronBodyBuffTriggerInfo preciseTriggerInfo in originalIronBodyConfigDesc.PreciseTriggerInfoList)
			{
				GetBuffPreloadData(preciseTriggerInfo.BuffID, LoadPath, IsIgnoreAllFX: false);
			}
			foreach (FUStIronBodyBuffTriggerInfo notPreciseTriggerInfo in originalIronBodyConfigDesc.NotPreciseTriggerInfoList)
			{
				GetBuffPreloadData(notPreciseTriggerInfo.BuffID, LoadPath, IsIgnoreAllFX: false);
			}
			return true;
		}
		return false;
	}

	public static bool GetPhantomRushConfigPreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath, bool IsIgnoreAllFX, AActor Caster = null)
	{
		FUStPhantomRushSkillConfigDesc phantomRushSkillConfigDesc = BGW_GameDB.GetPhantomRushSkillConfigDesc(ConfigID, Caster);
		if (phantomRushSkillConfigDesc == null)
		{
			return false;
		}
		AddItemToLoadPath(LoadPath, phantomRushSkillConfigDesc.PhantomRushRelatedSkillConfigPath, EAssetPriority.Medium);
		GetSkillSPreloadData(phantomRushSkillConfigDesc.PhantomRushSkillID, LoadPath);
		GetSummonCommPreloadData(phantomRushSkillConfigDesc.PhantomRushSummonID, LoadPath, IsIgnoreAllFX);
		foreach (int phantomRushBeginAddBuffID in phantomRushSkillConfigDesc.PhantomRushBeginAddBuffIDList)
		{
			GetBuffPreloadData(phantomRushBeginAddBuffID, LoadPath, IsIgnoreAllFX);
		}
		foreach (int phantomRushEndTriggerEffectID in phantomRushSkillConfigDesc.PhantomRushEndTriggerEffectIDList)
		{
			GetSkillEffectPreloadData(phantomRushEndTriggerEffectID, LoadPath, IsIgnoreAllFX);
		}
		return true;
	}

	public static bool GetSkillSPreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath)
	{
		FUStSkillSDesc originalSkillSDesc = BGW_GameDB.GetOriginalSkillSDesc(ConfigID);
		if (originalSkillSDesc == null)
		{
			return false;
		}
		AddItemToLoadPath(LoadPath, originalSkillSDesc.TemplatePath, EAssetPriority.High);
		AddItemToLoadPath(LoadPath, originalSkillSDesc.AtkReboundingMontage, EAssetPriority.Medium);
		AddItemToLoadPath(LoadPath, originalSkillSDesc.SkillArmorBrokeMontage, EAssetPriority.Medium);
		OnAddToLoadPath(originalSkillSDesc.GetType(), LoadPath);
		if (originalSkillSDesc.SkillType == ESkillType.ChargeSkillBegin)
		{
			GetChargeSkillPreloadData(ConfigID, LoadPath);
		}
		return true;
	}

	public static bool GetChargeSkillPreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath)
	{
		FUStChargeSkillSDesc originalChargeSkillSDesc = BGW_GameDB.GetOriginalChargeSkillSDesc(ConfigID);
		if (originalChargeSkillSDesc != null)
		{
			AddItemToLoadPath(LoadPath, originalChargeSkillSDesc.LoopTemplatePath, EAssetPriority.High);
			AddItemToLoadPath(LoadPath, originalChargeSkillSDesc.ChargeSkillSuperArmorInfo.SSABreakAssignedAnim, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, originalChargeSkillSDesc.ChargeLevelConfigPath, EAssetPriority.Medium);
			foreach (FUStChargeSkillBuffInfo chargeSkillBuffInfo in originalChargeSkillSDesc.ChargeSkillBuffInfoList)
			{
				GetBuffPreloadData(chargeSkillBuffInfo.BuffID, LoadPath, IsIgnoreAllFX: true);
			}
			OnAddToLoadPath(originalChargeSkillSDesc.GetType(), LoadPath);
			return true;
		}
		return false;
	}

	public static bool GetSkillSMappingPreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath)
	{
		FUStSkillSMappingDesc skillSMappingDesc = BGW_GameDB.GetSkillSMappingDesc(ConfigID);
		if (skillSMappingDesc != null)
		{
			foreach (SkillMappingConfig mappingConfig in skillSMappingDesc.MappingConfigList)
			{
				foreach (int skillID in mappingConfig.SkillIDs)
				{
					GetSkillSPreloadData(skillID, LoadPath);
				}
				foreach (string montagePath in mappingConfig.MontagePaths)
				{
					AddItemToLoadPath(LoadPath, montagePath, EAssetPriority.High);
				}
			}
			OnAddToLoadPath(skillSMappingDesc.GetType(), LoadPath);
			return true;
		}
		return false;
	}

	public static bool GetSummonCopySkillPreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath)
	{
		FUStSummonCopySkillDesc summonCopySkillDesc = BGW_GameDB.GetSummonCopySkillDesc(ConfigID);
		if (summonCopySkillDesc != null)
		{
			AddItemToLoadPath(LoadPath, summonCopySkillDesc.SummonUnitMontagePath, EAssetPriority.Medium);
			OnAddToLoadPath(summonCopySkillDesc.GetType(), LoadPath);
			return true;
		}
		return false;
	}

	public static bool GetSkillEffectPreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath, bool IsIgnoreAllFX)
	{
		FUStSkillEffectDesc originalSkillEffectDesc = BGW_GameDB.GetOriginalSkillEffectDesc(ConfigID);
		if (originalSkillEffectDesc == null)
		{
			return false;
		}
		foreach (string item in originalSkillEffectDesc.EffectParamsStr)
		{
			AddItemToLoadPath(LoadPath, item, EAssetPriority.Medium);
		}
		switch (originalSkillEffectDesc.EffectType)
		{
		case EBuffAndSkillEffectType.SummonUnit:
			if (originalSkillEffectDesc.EffectParamsInt.Count > 0)
			{
				GetSummonCommPreloadData(originalSkillEffectDesc.EffectParamsInt[0], LoadPath, IsIgnoreAllFX);
			}
			break;
		case EBuffAndSkillEffectType.SwitchBullet:
		case EBuffAndSkillEffectType.BulletSwitchSelf:
		case EBuffAndSkillEffectType.BulletAutoAttack:
		case EBuffAndSkillEffectType.BulletSwitchSelfNoImmediately:
			if (originalSkillEffectDesc.EffectParamsInt.Count > 0)
			{
				GetBulletSwitchPreloadData(originalSkillEffectDesc.EffectParamsInt[0], LoadPath);
			}
			break;
		case EBuffAndSkillEffectType.BulletsSimpleSpawn:
			if (originalSkillEffectDesc.EffectParamsInt.Count > 0)
			{
				GetProjectilePreloadData(originalSkillEffectDesc.EffectParamsInt[0], LoadPath, IsIgnoreAllFX);
			}
			break;
		case EBuffAndSkillEffectType.SetPhantomRushConfig:
			if (originalSkillEffectDesc.EffectParamsInt.Count > 0)
			{
				GetPhantomRushConfigPreloadData(originalSkillEffectDesc.EffectParamsInt[0], LoadPath, IsIgnoreAllFX);
			}
			break;
		}
		OnAddToLoadPath(originalSkillEffectDesc.GetType(), LoadPath);
		return true;
	}

	public static bool GetBulletSwitchPreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath)
	{
		FUStBulletSwitchDesc bulletSwitchDesc = BGW_GameDB.GetBulletSwitchDesc(ConfigID);
		if (bulletSwitchDesc != null)
		{
			AddItemToLoadPath(LoadPath, bulletSwitchDesc.BulletMoveModeFlySpdCurvePath, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, bulletSwitchDesc.BulletMoveModeRotSpdCurvePath, EAssetPriority.Medium);
			OnAddToLoadPath(bulletSwitchDesc.GetType(), LoadPath);
			return true;
		}
		return false;
	}

	public static bool GetAttackHitFXPreloadData(int UnitResID, Dictionary<string, EAssetPriority> LoadPath)
	{
		Dictionary<int, FUStAttackHitFXMapDesc> allAttackHitFXMapDesc = BGW_GameDB.GetAllAttackHitFXMapDesc();
		if (allAttackHitFXMapDesc == null)
		{
			return false;
		}
		foreach (KeyValuePair<int, FUStAttackHitFXMapDesc> item in allAttackHitFXMapDesc)
		{
			if (UnitResID == 0 && item.Value.UnitResID != UnitResID)
			{
				break;
			}
			if (item.Value.UnitResID == UnitResID)
			{
				AddItemToLoadPath(LoadPath, item.Value.HitFXPath, EAssetPriority.Low);
				AddItemToLoadPath(LoadPath, item.Value.DirectionalFXPath, EAssetPriority.Low);
				AddItemToLoadPath(LoadPath, item.Value.CameraShake, EAssetPriority.Low);
				AddItemToLoadPath(LoadPath, item.Value.PromptEffectMPCPath, EAssetPriority.Low);
				for (int i = 0; i < item.Value.MPCParamWithCurve.Count; i++)
				{
					AddItemToLoadPath(LoadPath, item.Value.MPCParamWithCurve[i].MPCFloatCurvePath, EAssetPriority.Low);
				}
			}
		}
		OnAddToLoadPath(typeof(FUStAttackHitFXMapDesc), LoadPath);
		return true;
	}

	public static bool GetBeAttackedFXPreloadData(int UnitResID, Dictionary<string, EAssetPriority> LoadPath)
	{
		Dictionary<int, FUStBeAttackedFXMapDesc> allBeAttackedFXMapDesc = BGW_GameDB.GetAllBeAttackedFXMapDesc();
		if (allBeAttackedFXMapDesc == null)
		{
			return false;
		}
		foreach (KeyValuePair<int, FUStBeAttackedFXMapDesc> item in allBeAttackedFXMapDesc)
		{
			if (item.Value.UnitResID == UnitResID || (UnitResID == 0 && item.Value.UnitResID == 1))
			{
				AddItemToLoadPath(LoadPath, item.Value.BeHitFXPath, EAssetPriority.Low);
				AddItemToLoadPath(LoadPath, item.Value.BeHitFXPathAttachVer, EAssetPriority.Low);
			}
		}
		OnAddToLoadPath(typeof(FUStBeAttackedFXMapDesc), LoadPath);
		return true;
	}

	public static bool GetHitSceneItemPerformPreloadData(int UnitResID, Dictionary<string, EAssetPriority> LoadPath)
	{
		if (UnitResID != 10 && UnitResID != 0)
		{
			return false;
		}
		Dictionary<int, FUStHitSceneItemPerformDesc> allHitSceneItemPerformDesc = BGW_GameDB.GetAllHitSceneItemPerformDesc();
		if (allHitSceneItemPerformDesc == null)
		{
			return false;
		}
		foreach (KeyValuePair<int, FUStHitSceneItemPerformDesc> item in allHitSceneItemPerformDesc)
		{
			if (UnitResID == 0 && item.Value.UnitResID != UnitResID)
			{
				break;
			}
			if (item.Value.UnitResID == UnitResID)
			{
				AddItemToLoadPath(LoadPath, item.Value.HitWorldItemFXPath, EAssetPriority.Low);
				AddItemToLoadPath(LoadPath, item.Value.HitWorldItemDecalPath, EAssetPriority.Low);
				AddItemToLoadPath(LoadPath, item.Value.HitGroundFXPath, EAssetPriority.Low);
				AddItemToLoadPath(LoadPath, item.Value.HitGroundDirectionFXPath, EAssetPriority.Low);
				AddItemToLoadPath(LoadPath, item.Value.HitGroundDecalPath, EAssetPriority.Low);
				AddItemToLoadPath(LoadPath, item.Value.HitWorldItemAKPath, EAssetPriority.Low);
			}
		}
		OnAddToLoadPath(typeof(FUStHitSceneItemPerformDesc), LoadPath);
		return true;
	}

	public static bool GetProjectilePreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath, bool IsIgnoreAllFX)
	{
		FUStProjectileCommDesc originalProjectileCommDesc = BGW_GameDB.GetOriginalProjectileCommDesc(ConfigID);
		if (originalProjectileCommDesc == null)
		{
			return false;
		}
		AddItemToLoadPath(LoadPath, originalProjectileCommDesc.ProjectileBPTemplatePath, EAssetPriority.Medium);
		AddItemToLoadPath(LoadPath, originalProjectileCommDesc.ProjectileAnimPath, EAssetPriority.Medium);
		AddItemToLoadPath(LoadPath, originalProjectileCommDesc.ProjectileScaleCurvePath, EAssetPriority.Medium);
		AddItemToLoadPath(LoadPath, originalProjectileCommDesc.ProjectileInnerRadiusCurvePath, EAssetPriority.Medium);
		AddItemToLoadPath(LoadPath, originalProjectileCommDesc.ProjectileSweepReactionDataAssetPath, EAssetPriority.Medium);
		OnAddToLoadPath(originalProjectileCommDesc.GetType(), LoadPath);
		if (!IsIgnoreAllFX)
		{
			FUStProjectileDispDesc projectileDispDesc = BGW_GameDB.GetProjectileDispDesc(ConfigID);
			if (projectileDispDesc != null)
			{
				AddItemToLoadPath(LoadPath, projectileDispDesc.ProjectileSpawnPSPath, EAssetPriority.Low);
				AddItemToLoadPath(LoadPath, projectileDispDesc.BulletHitItemPSPath, EAssetPriority.Low);
				AddItemToLoadPath(LoadPath, projectileDispDesc.BulletHitUnitPSPath, EAssetPriority.Low);
				AddItemToLoadPath(LoadPath, projectileDispDesc.BulletLifeOverPSPath, EAssetPriority.Low);
				AddItemToLoadPath(LoadPath, projectileDispDesc.BeHitedProjectilePlayFXPath, EAssetPriority.Low);
				AddItemToLoadPath(LoadPath, projectileDispDesc.BeHitedProjectilePostAKPath, EAssetPriority.Low);
			}
		}
		FUStProjectileMoveDesc projectileMoveDesc = BGW_GameDB.GetProjectileMoveDesc(ConfigID);
		if (projectileMoveDesc != null && (projectileMoveDesc.ProjectileMoveModeType == EBulletOrMagicFieldMoveModeType.ManualCurveMoveMode || projectileMoveDesc.ProjectileMoveModeType == EBulletOrMagicFieldMoveModeType.CircleSurroundMoveMode) && projectileMoveDesc.ProjectileMoveModeStrParam.Count > 0)
		{
			AddItemToLoadPath(LoadPath, projectileMoveDesc.ProjectileMoveModeStrParam[0], EAssetPriority.Medium);
		}
		FUStBulletExpandDesc bulletExpandDesc = BGW_GameDB.GetBulletExpandDesc(ConfigID);
		if (bulletExpandDesc != null)
		{
			AddItemToLoadPath(LoadPath, bulletExpandDesc.LaserLengthSpeedCurvePath, EAssetPriority.Top);
		}
		return true;
	}

	public static void GetDialogueFacialAnimPreloadData(int ResID, Dictionary<string, EAssetPriority> LoadPath)
	{
		List<string> facialAnimPreloadAssetPathList = BGW_GameDB.GetFacialAnimPreloadAssetPathList(ResID);
		if (facialAnimPreloadAssetPathList == null)
		{
			return;
		}
		foreach (string item in facialAnimPreloadAssetPathList)
		{
			AddItemToLoadPath(LoadPath, item, EAssetPriority.Medium);
		}
	}

	public static bool GetBuffPreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath, bool IsIgnoreAllFX)
	{
		FUStBuffDesc originalBuffDesc = BGW_GameDB.GetOriginalBuffDesc(ConfigID);
		if (originalBuffDesc != null)
		{
			foreach (FUStBuffEffectAttr buffEffect in originalBuffDesc.BuffEffects)
			{
				foreach (string item in buffEffect.EffectParamsString)
				{
					AddItemToLoadPath(LoadPath, item, EAssetPriority.Medium);
				}
				switch (buffEffect.EffectType)
				{
				case EBuffAndSkillEffectType.SwitchBullet:
				case EBuffAndSkillEffectType.BulletSwitchSelf:
				case EBuffAndSkillEffectType.BulletAutoAttack:
					if (buffEffect.EffectParams.Count > 0)
					{
						GetBulletSwitchPreloadData(buffEffect.EffectParams[0], LoadPath);
					}
					break;
				case EBuffAndSkillEffectType.SummonUnit:
					if (buffEffect.EffectParams.Count > 0)
					{
						GetSummonCommPreloadData(buffEffect.EffectParams[0], LoadPath, IsIgnoreAllFX);
					}
					break;
				case EBuffAndSkillEffectType.BulletsSimpleSpawn:
					if (buffEffect.EffectParams.Count > 0)
					{
						GetProjectilePreloadData(buffEffect.EffectParams[0], LoadPath, IsIgnoreAllFX);
					}
					break;
				case EBuffAndSkillEffectType.SetPhantomRushConfig:
					if (buffEffect.EffectParams.Count > 0)
					{
						GetPhantomRushConfigPreloadData(buffEffect.EffectParams[0], LoadPath, IsIgnoreAllFX);
					}
					break;
				}
			}
			OnAddToLoadPath(originalBuffDesc.GetType(), LoadPath);
			if (!IsIgnoreAllFX)
			{
				int num = 100;
				int num2 = ConfigID * num;
				for (int i = 1; i < num; i++)
				{
					GetBuffDispPreloadData(num2 + i, LoadPath);
				}
			}
			return true;
		}
		return false;
	}

	public static void GetBuffDispGroupPreloadData(Dictionary<string, EAssetPriority> LoadPath)
	{
		foreach (KeyValuePair<int, FUStBuffDispGroupDesc> item in BGW_GameDB.GetAllBuffDispGroupDesc())
		{
			foreach (int item2 in BGW_GameDB.GetBuffDispList_ByBuffID(item.Value.SingleBuffDisp))
			{
				GetBuffDispPreloadData(item2, LoadPath);
			}
			foreach (int item3 in BGW_GameDB.GetBuffDispList_ByBuffID(item.Value.GroupBuffDisp))
			{
				GetBuffDispPreloadData(item3, LoadPath);
			}
		}
	}

	public static bool GetBuffDispPreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath)
	{
		FUStBuffDispDesc buffDispDescByID = BGW_GameDB.GetBuffDispDescByID(ConfigID);
		if (buffDispDescByID != null)
		{
			foreach (FUStFXSetting item in buffDispDescByID.EnterFX)
			{
				AddItemToLoadPath(LoadPath, item.PSPath, EAssetPriority.Medium);
			}
			foreach (FUStFXSetting item2 in buffDispDescByID.LeaveFX)
			{
				AddItemToLoadPath(LoadPath, item2.PSPath, EAssetPriority.Medium);
			}
			foreach (FUStFloatCurveToParam item3 in buffDispDescByID.TickingCurveParam)
			{
				AddItemToLoadPath(LoadPath, item3.FloatCurvePath, EAssetPriority.Medium);
			}
			foreach (FUStFXSetting item4 in buffDispDescByID.DamageFXSetting)
			{
				AddItemToLoadPath(LoadPath, item4.PSPath, EAssetPriority.Medium);
			}
			foreach (string item5 in buffDispDescByID.MaterialSetting)
			{
				AddItemToLoadPath(LoadPath, item5, EAssetPriority.Medium);
			}
			OnAddToLoadPath(buffDispDescByID.GetType(), LoadPath);
		}
		FUStBuffLayerDispDesc buffLayerDispDescByID = BGW_GameDB.GetBuffLayerDispDescByID(ConfigID);
		if (buffLayerDispDescByID != null)
		{
			foreach (FUStBuffLayerDispConfig item6 in buffLayerDispDescByID.Config)
			{
				AddItemToLoadPath(LoadPath, item6.DBCPath, EAssetPriority.Medium);
			}
			OnAddToLoadPath(buffLayerDispDescByID.GetType(), LoadPath);
		}
		return true;
	}

	public static bool GetBeAttackedInfoPreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath)
	{
		FUStBeAttackedInfoDesc beAttackedInfoDesc = BGW_GameDB.GetBeAttackedInfoDesc(ConfigID);
		if (beAttackedInfoDesc == null)
		{
			return false;
		}
		AddItemToLoadPath(LoadPath, beAttackedInfoDesc.BeAttackedPhysAnimAsset, EAssetPriority.Low);
		OnAddToLoadPath(beAttackedInfoDesc.GetType(), LoadPath);
		return true;
	}

	public static bool GetCBGTemplatePreloadData(int ConfigID, int ResID, Dictionary<string, EAssetPriority> LoadPath)
	{
		FUStCBGTemplateDesc cBGTemplateDesc = BGW_GameDB.GetCBGTemplateDesc(ConfigID);
		if (cBGTemplateDesc == null)
		{
			return false;
		}
		AddItemToLoadPath(LoadPath, cBGTemplateDesc.Path, EAssetPriority.Medium);
		OnAddToLoadPath(cBGTemplateDesc.GetType(), LoadPath);
		return true;
	}

	public static bool GetPartInfoPreloadData(int ConfigID, Dictionary<string, EAssetPriority> LoadPath)
	{
		List<int> partRuleInfoListByResID = BGW_GameDB.GetPartRuleInfoListByResID(ConfigID);
		if (partRuleInfoListByResID == null)
		{
			return false;
		}
		foreach (int item in partRuleInfoListByResID)
		{
			FUStPartRuleInfoDesc originalPartRuleInfoDesc = BGW_GameDB.GetOriginalPartRuleInfoDesc(item);
			AddItemToLoadPath(LoadPath, originalPartRuleInfoDesc.PartHitUnitBeAttackedConfigPath, EAssetPriority.High);
			OnAddToLoadPath(originalPartRuleInfoDesc.GetType(), LoadPath);
		}
		return true;
	}

	public static bool GetUnitFootstepPreloadData(int UnitResID, Dictionary<string, EAssetPriority> LoadPath)
	{
		List<FUStUnitFootstepDesc> unitFootstepDescByResID = BGW_GameDB.GetUnitFootstepDescByResID(UnitResID);
		if (unitFootstepDescByResID == null)
		{
			return false;
		}
		foreach (FUStUnitFootstepDesc item in unitFootstepDescByResID)
		{
			AddItemToLoadPath(LoadPath, item.WalkLeftFootFXPath, EAssetPriority.Low);
			AddItemToLoadPath(LoadPath, item.WalkRightFootFXPath, EAssetPriority.Low);
			AddItemToLoadPath(LoadPath, item.RunLeftFootFXPath, EAssetPriority.Low);
			AddItemToLoadPath(LoadPath, item.RunRightFootFXPath, EAssetPriority.Low);
			AddItemToLoadPath(LoadPath, item.SprintLeftFootFXPath, EAssetPriority.Low);
			AddItemToLoadPath(LoadPath, item.SprintRightFootFXPath, EAssetPriority.Low);
			AddItemToLoadPath(LoadPath, item.LeftFootDecalDBC, EAssetPriority.Low);
			AddItemToLoadPath(LoadPath, item.RightFootDecalDBC, EAssetPriority.Low);
			OnAddToLoadPath(item.GetType(), LoadPath);
		}
		return true;
	}

	public static bool GetUnitAiConversationPreloadData(int ResID, Dictionary<string, EAssetPriority> LoadPath)
	{
		if (ResID == 10)
		{
			return true;
		}
		foreach (FUStAiConversationContentDesc value in BGW_GameDB.GetAllAiConversationContentDesc().Values)
		{
			if (value.ResID == ResID)
			{
				AddItemToLoadPath(LoadPath, value.AkEventPath, EAssetPriority.Medium);
				AddItemToLoadPath(LoadPath, value.AMPath, EAssetPriority.Medium);
				OnAddToLoadPath(value.GetType(), LoadPath);
			}
		}
		return true;
	}

	public static bool GetUnitFacialAnimationPreloadData(int ResID, Dictionary<string, EAssetPriority> LoadPath)
	{
		List<string> facialAnimPreloadAssetPathList = BGW_GameDB.GetFacialAnimPreloadAssetPathList(ResID);
		if (facialAnimPreloadAssetPathList != null && facialAnimPreloadAssetPathList.Count > 0)
		{
			foreach (string item in facialAnimPreloadAssetPathList)
			{
				AddItemToLoadPath(LoadPath, item, EAssetPriority.Medium);
			}
		}
		return true;
	}

	public static bool GetAbnormalDispMapPreloadData(int ResID, int ExtendID, Dictionary<string, EAssetPriority> LoadPath)
	{
		int num = 0;
		int num2 = 0;
		if (ResID != 0 && ResID != 1 && ResID != 2)
		{
			FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(ExtendID);
			if (unitBattleInfoExtendDesc == null)
			{
				return false;
			}
			num = unitBattleInfoExtendDesc.AbnormalDispAttackerID;
			num2 = unitBattleInfoExtendDesc.AbnormalDispVictimID;
		}
		switch (ResID)
		{
		case 1:
			num = 1;
			break;
		case 2:
			num = 2;
			num2 = 1006;
			break;
		}
		if (ResID == 0 || num > 0)
		{
			LoadAbnormalDisp_Attacker(LoadPath, num);
		}
		if (num2 > 0)
		{
			LoadAbnormalDisp_Victim(LoadPath, num2);
		}
		return true;
	}

	private static void LoadAbnormalDisp_Attacker(Dictionary<string, EAssetPriority> LoadPath, int AbnormalDispID_Attacker)
	{
		FUStAbnormalDispAttackerMapDesc oriAbnormalDispModifyInfo_Attacker = BGW_GameDB.GetOriAbnormalDispModifyInfo_Attacker(AbnormalDispID_Attacker);
		if (oriAbnormalDispModifyInfo_Attacker != null)
		{
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Freeze.DBCAccProcess, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Freeze.DBCFinalBegin, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Freeze.DBCFinalLoop, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Freeze.DBCHitExt, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Burn.DBCFinalBegin, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Burn.DBCFinalLoop, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Burn.DBCDeadKeep, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Burn.DBCDeadDisappear, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Poison.DBCFinalBegin, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Poison.DBCFinalLoop, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Poison.DBCDeadKeep, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Poison.DBCDeadDisappear, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Thunder.DBCFinalBegin, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Thunder.DBCFinalLoop, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Thunder.DBCHitExt, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Yin.DBCAccProcess, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Yin.DBCFinalBegin, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Yin.DBCFinalLoop, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Yin.DBCDeadKeep, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Yin.DBCDeadDisappear, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Yang.DBCAccProcess, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Yang.DBCFinalBegin, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Yang.DBCFinalLoop, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Yang.DBCDeadKeep, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.Yang.DBCDeadDisappear, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.FreezeExt.DBCBroken, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.FreezeExt.DBCAutoRelease, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Attacker.FreezeExt.DBCShakeFreeze, EAssetPriority.Medium);
			OnAddToLoadPath(oriAbnormalDispModifyInfo_Attacker.GetType(), LoadPath);
		}
	}

	private static void LoadAbnormalDisp_Victim(Dictionary<string, EAssetPriority> LoadPath, int AbnormalDispID_Victim)
	{
		FUStAbnormalDispVictimMapDesc oriAbnormalDispModifyInfo_Victim = BGW_GameDB.GetOriAbnormalDispModifyInfo_Victim(AbnormalDispID_Victim);
		if (oriAbnormalDispModifyInfo_Victim != null)
		{
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Freeze.DBCAccProcess, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Freeze.DBCFinalBegin, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Freeze.DBCFinalLoop, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Freeze.DBCHitExt, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Burn.DBCFinalBegin, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Burn.DBCFinalLoop, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Burn.DBCDeadKeep, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Burn.DBCDeadDisappear, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Poison.DBCFinalBegin, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Poison.DBCFinalLoop, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Poison.DBCDeadKeep, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Poison.DBCDeadDisappear, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Thunder.DBCFinalBegin, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Thunder.DBCFinalLoop, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Thunder.DBCHitExt, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Yin.DBCAccProcess, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Yin.DBCFinalBegin, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Yin.DBCFinalLoop, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Yin.DBCDeadKeep, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Yin.DBCDeadDisappear, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Yang.DBCAccProcess, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Yang.DBCFinalBegin, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Yang.DBCFinalLoop, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Yang.DBCDeadKeep, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.Yang.DBCDeadDisappear, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.FreezeExt.DBCBroken, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.FreezeExt.DBCAutoRelease, EAssetPriority.Medium);
			AddItemToLoadPath(LoadPath, oriAbnormalDispModifyInfo_Victim.FreezeExt.DBCShakeFreeze, EAssetPriority.Medium);
			OnAddToLoadPath(oriAbnormalDispModifyInfo_Victim.GetType(), LoadPath);
		}
	}

	public static bool GetUnitPEConfigPreloadData(int ResID, Dictionary<string, EAssetPriority> LoadPath)
	{
		Dictionary<int, Dictionary<int, FUStPotentialEnergyConfigDesc>> originalPotentialEnergyResConfigDesc = BGW_GameDB.GetOriginalPotentialEnergyResConfigDesc(ResID);
		if (originalPotentialEnergyResConfigDesc == null)
		{
			return false;
		}
		foreach (Dictionary<int, FUStPotentialEnergyConfigDesc> value in originalPotentialEnergyResConfigDesc.Values)
		{
			foreach (FUStPotentialEnergyConfigDesc value2 in value.Values)
			{
				AddItemToLoadPath(LoadPath, value2.PELevelConfig.DBCDAPath, EAssetPriority.Top);
			}
		}
		return true;
	}

	public static bool LoadPlayerCommDescResource(int ResID, Dictionary<string, EAssetPriority> LoadPath, AActor Actor)
	{
		FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(ResID, Actor);
		if (playerCommDesc == null)
		{
			return false;
		}
		AddItemToLoadPath(LoadPath, playerCommDesc.UnFreezeAdditiveAMPath, EAssetPriority.Medium);
		AddItemToLoadPath(LoadPath, playerCommDesc.UnFreezeFXPath, EAssetPriority.Medium);
		return true;
	}

	public static bool LoadLifeSavingHairDescResource(int ResID, Dictionary<string, EAssetPriority> LoadPath)
	{
		FUStLifeSavingHairConfigDesc originalLifeSavingHairConfigDesc = BGW_GameDB.GetOriginalLifeSavingHairConfigDesc(ResID);
		if (originalLifeSavingHairConfigDesc == null)
		{
			return false;
		}
		AddItemToLoadPath(LoadPath, originalLifeSavingHairConfigDesc.AMPath, EAssetPriority.Medium);
		return true;
	}

	public static bool GetSoulLockCameraPreloadData(int ResID, Dictionary<string, EAssetPriority> LoadPath)
	{
		string b = ResID.ToString();
		foreach (FUStStraightCamDesc value in BGW_GameDB.GetAllStraightCamDesc().Values)
		{
			if (!string.Equals(value.CamID.ToString().Substring(0, 4), b))
			{
				continue;
			}
			if (value.CameraParamString.Count > 0)
			{
				for (int i = 0; i < value.CameraParamString.Count && i < 2; i++)
				{
					AddItemToLoadPath(LoadPath, value.CameraParamString[i], EAssetPriority.Medium);
				}
			}
			if (!string.IsNullOrEmpty(value.SlowTraceSpeedCurve))
			{
				AddItemToLoadPath(LoadPath, value.SlowTraceSpeedCurve, EAssetPriority.Medium);
			}
		}
		return true;
	}

	public static bool GetUnitChangeMaterialByAttrPreloadData(int ResID, Dictionary<string, EAssetPriority> LoadPath)
	{
		FUStUnitChangeMaterialByAttrDesc unitChangeMaterialByAttrDesc = BGW_GameDB.GetUnitChangeMaterialByAttrDesc(ResID);
		if (unitChangeMaterialByAttrDesc == null)
		{
			return false;
		}
		AddItemToLoadPath(LoadPath, unitChangeMaterialByAttrDesc.ConfigDAPath, EAssetPriority.Medium);
		OnAddToLoadPath(unitChangeMaterialByAttrDesc.GetType(), LoadPath);
		return true;
	}

	public static Dictionary<string, EAssetPriority> Change2ValidPathList(Dictionary<string, EAssetPriority> PathInfoDic)
	{
		Dictionary<string, EAssetPriority> dictionary = new Dictionary<string, EAssetPriority>();
		foreach (KeyValuePair<string, EAssetPriority> item in PathInfoDic)
		{
			string text = FPackageName.ExportTextPathToObjectPath(item.Key);
			if (IsPathValid(text, bOutputLog: false) && !dictionary.ContainsKey(text))
			{
				dictionary.Add(text, item.Value);
			}
		}
		return dictionary;
	}

	public static bool IsPathValid(string path, bool bOutputLog = true)
	{
		bool result = path.Length != 0;
		if (path.Contains("//"))
		{
			result = false;
		}
		if (path == "None")
		{
			result = false;
		}
		if (!path.Contains("/") || !path.Contains("."))
		{
			result = false;
		}
		return result;
	}

	public static void GetUIBPLoadList(ref Dictionary<string, EAssetPriority> PublicResourcePathDic)
	{
		PublicResourcePathDic.Add("/Game/00Main/UI/BluePrintsV3/Role/BUI_RoleMain.BUI_RoleMain", EAssetPriority.High);
		PublicResourcePathDic.Add("/Game/00Main/UI/BluePrintsV3/Role/BUI_EquipMain.BUI_EquipMain", EAssetPriority.High);
		PublicResourcePathDic.Add("/Game/00Main/UI/BluePrintsV3/Comm/BUI_Name.BUI_Name", EAssetPriority.High);
	}

	public static void GetLevelDescLoadList(ref Dictionary<string, EAssetPriority> PublicResourcePathDic)
	{
		foreach (LevelDesc item in GameDBRuntime.GetTBLevelDesc().List)
		{
			AddToResourcePathList(item.LevelGroupPatrolDataAssetPath, ref PublicResourcePathDic, EAssetPriority.Top);
			AddToResourcePathList(GSUIResPathUtil.GetLoadTipsImagePath(item.TravelLevelLoadingScreenImageId), ref PublicResourcePathDic, EAssetPriority.Low);
			AddToResourcePathList(item.LevelDefaultBgmConfigPath, ref PublicResourcePathDic, EAssetPriority.Low);
			AddToResourcePathList(item.LevelHatredBattleConfig, ref PublicResourcePathDic, EAssetPriority.Low);
		}
	}

	public static void GetInputIconMgrLoadList(ref Dictionary<string, EAssetPriority> PublicResourcePathDic)
	{
		AddToResourcePathList("MaterialParameterCollection'/Game/00MainHZ/UIDev/Comm/Interact/MPC_UIInteractConfig.MPC_UIInteractConfig'", ref PublicResourcePathDic, EAssetPriority.Top);
		AddToResourcePathList("/Game/00MainHZ/UIDev/Comm/Interact/IMG_interact_inputconnect.IMG_interact_inputconnect", ref PublicResourcePathDic, EAssetPriority.Top);
		AddToResourcePathList("/Game/00MainHZ/UI/AlwaysCook/PressKeyIcon/InputIcon_None.InputIcon_None", ref PublicResourcePathDic, EAssetPriority.Top);
		AddToResourcePathList("/Game/00MainHZ/UI/AlwaysCook/RichTextIcon/IMG_richtexticon_inputconnect.IMG_richtexticon_inputconnect", ref PublicResourcePathDic, EAssetPriority.Top);
		foreach (EGSInputIconType supportInputIconType in FInputDeviceTracker.GetSupportInputIconTypes())
		{
			string inputIconConfigPath = FInputIconTracker.GetInputIconConfigPath(supportInputIconType);
			string inputIconDirPath = FInputIconTracker.GetInputIconDirPath(supportInputIconType);
			AddToResourcePathList(inputIconConfigPath, ref PublicResourcePathDic, EAssetPriority.Top);
			if (Directory.Exists(inputIconDirPath))
			{
				foreach (object value in Enum.GetValues(FInputIconTracker.GetIconBgEnumType(supportInputIconType)))
				{
					string text = value.ToString();
					FileInfo[] files = new DirectoryInfo(Path.Combine(inputIconDirPath, text)).GetFiles();
					foreach (FileInfo fileInfo in files)
					{
						string text2 = fileInfo.Name.Replace(fileInfo.Extension, "");
						_ = string.Empty;
						AddToResourcePathList(new Regex("\\w+?.\\w+?$").Replace(inputIconConfigPath, text + "/" + text2 + "." + text2), ref PublicResourcePathDic, EAssetPriority.Top);
					}
				}
			}
			string inlineIconDirPath = FInputIconTracker.GetInlineIconDirPath(supportInputIconType);
			if (Directory.Exists(inlineIconDirPath))
			{
				FileInfo[] files = new DirectoryInfo(inlineIconDirPath).GetFiles();
				foreach (FileInfo fileInfo2 in files)
				{
					string text3 = fileInfo2.Name.Replace(fileInfo2.Extension, "");
					AddToResourcePathList(inlineIconDirPath.Replace(FPaths.ProjectDir, "").Replace("Content", "/Game") + "/" + text3 + "." + text3, ref PublicResourcePathDic, EAssetPriority.Top);
				}
			}
		}
	}

	public static void GetPublicDataAssetResourceLoadList(ref Dictionary<string, EAssetPriority> PublicResourcePathDic)
	{
		PublicResourcePathDic.Add("/Game/00Main/Audio/SFX/Player/PauseAll.PauseAll", EAssetPriority.Top);
		PublicResourcePathDic.Add("/Game/00Main/Audio/SFX/Player/ResumeAll.ResumeAll", EAssetPriority.Top);
		PublicResourcePathDic.Add("/Game/00Main/Design/Tech/DynamicSDF/BPs/DynamicSDFGenerator.DynamicSDFGenerator_C", EAssetPriority.Top);
		PublicResourcePathDic.Add("/Game/00Main/Design/Tech/Landscape_Interactive_Virtual/MPCs/MPC_Landscape_Interactive_Virtual.MPC_Landscape_Interactive_Virtual", EAssetPriority.Low);
		PublicResourcePathDic.Add("/Game/00Main/Design/Tech/Landscape_Interactive_Virtual/MPCs/NPC_Landscape_Interactive_Virtual.NPC_Landscape_Interactive_Virtual", EAssetPriority.Low);
		PublicResourcePathDic.Add("/Game/00Main/Design/Tech/Landscape_Interactive_Virtual/Materials/M_CombineTexture.M_CombineTexture", EAssetPriority.Low);
		PublicResourcePathDic.Add("/Game/00Main/Design/Tech/Landscape_Interactive_Virtual/RTs/RT_LandscapeMap.RT_LandscapeMap", EAssetPriority.Low);
		PublicResourcePathDic.Add("/Game/00Main/Design/Tech/Landscape_Interactive_Virtual/RTs/RT_Display.RT_Display", EAssetPriority.Low);
		PublicResourcePathDic.Add("/Game/00Main/BPLibrary/BGW/BP_BeAttackHitLvlDataAsset.BP_BeAttackHitLvlDataAsset", EAssetPriority.Top);
		PublicResourcePathDic.Add("BGWDataAsset_UnitDeathDispAbnormalStateDBC'/Game/00Main/Design/AI/DeathDispDBCDataAsset/UDDAS_Default.UDDAS_Default'", EAssetPriority.Low);
		PublicResourcePathDic.Add("BGWDataAsset_OSSCollectionConfig'/Game/00Main/DataAsset/DA_OSSCollectionConfig.DA_OSSCollectionConfig'", EAssetPriority.Medium);
		PublicResourcePathDic.Add("CurveTable'/Game/Yuchen/TestCameraCurveTable.TestCameraCurveTable'", EAssetPriority.Medium);
		PublicResourcePathDic.Add("/Game/00Main/Design/CameraSeq/BP_CameraActor_ForSeq.BP_CameraActor_ForSeq_C", EAssetPriority.Medium);
		PublicResourcePathDic.Add("/Game/00Main/Design/CameraSeq/BP_CameraCinematic_ForSeq.BP_CameraCinematic_ForSeq_C", EAssetPriority.Medium);
		PublicResourcePathDic.Add("/Game/00Main/Design/CameraSeq/BP_CameraCrane_ForSeq.BP_CameraCrane_ForSeq_C", EAssetPriority.Medium);
		PublicResourcePathDic.Add("/Game/00Main/Design/CameraSeq/BP_CameraRail_ForSeq.BP_CameraRail_ForSeq_C", EAssetPriority.Medium);
		PublicResourcePathDic.Add("/Game/00Main/BPLibrary/UnitBase/BP_SkillSelectHelper.BP_SkillSelectHelper_C", EAssetPriority.Low);
		PublicResourcePathDic.Add("BGWDataAsset_SweepCheckDebugCollisionInfoConfig'/Game/00Main/BPLibrary/Debug/SCDCollisionInfoConfig.SCDCollisionInfoConfig'", EAssetPriority.Low);
		PublicResourcePathDic.Add("BGWDataAsset_PerformerConfig'/Game/00Main/DataAsset/DA_PerformerConfig.DA_PerformerConfig'", EAssetPriority.Low);
		PublicResourcePathDic.Add("BGWBeAtkPhysAnimDataAsset'/Game/00Main/BPLibrary/PhysAnim/PhysAnimConfig_BeAttack.PhysAnimConfig_BeAttack'", EAssetPriority.Low);
		PublicResourcePathDic.Add("BGWDataAsset_MaterialLayerParamGlobalConfig'/Game/00MainHZ/Characters/Wukong/EnvInteractive/DA_MaterialLayerGlobalConfig.DA_MaterialLayerGlobalConfig'", EAssetPriority.Medium);
		PublicResourcePathDic.Add("BGWDataAsset_GlobalFoliageInteractSoundConfig'/Game/00Main/BPLibrary/BGW/DA_GlobalFoliageInteractSound.DA_GlobalFoliageInteractSound'", EAssetPriority.Low);
		PublicResourcePathDic.Add("MaterialParameterCollection'/Game/00MainHZ/Environment/MPC/GlobalFoliageMPC.GlobalFoliageMPC'", EAssetPriority.Low);
		PublicResourcePathDic.Add("Material'/Game/00Main/Design/AI/GroupAI/M_AIViewBoard.M_AIViewBoard'", EAssetPriority.Top);
		PublicResourcePathDic.Add("BGWGroupAIMgrConfigDataAsset'/Game/00Main/Design/AI/GroupAI/BP_GroupAIConfig_Default.BP_GroupAIConfig_Default'", EAssetPriority.Top);
		PublicResourcePathDic.Add("BGWGroupAIBattleHotZoneConfigDataAsset'/Game/00Main/Design/AI/GroupAI/BP_GroupAIHotZoneConfig_Default.BP_GroupAIHotZoneConfig_Default'", EAssetPriority.Top);
		PublicResourcePathDic.Add("NiagaraSystem'/Game/00Main/BPLibrary/Debug/TargetDebugLine/NG_target_debug_line.NG_target_debug_line'", EAssetPriority.Top);
		PublicResourcePathDic.Add("BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FenShen/DBC/DBC_fenshen_disappear.DBC_fenshen_disappear'", EAssetPriority.Low);
		PublicResourcePathDic.Add("EnvQuery'/Game/00Main/Design/AI/BTs/Player/SummonMokey_FS/EQ_SummonMonkey_FS_Spawn.EQ_SummonMonkey_FS_Spawn'", EAssetPriority.Low);
		PublicResourcePathDic.Add("BGWBGMConfigDataAsset'/Game/00Main/DataAsset/DA_BGMConfig.DA_BGMConfig'", EAssetPriority.Low);
		if (BGW_GameDB.GetAllGuideAssetConfigDesc(out var GuideAssetConfigDescList))
		{
			foreach (FUStGuideAssetConfigDesc item in GuideAssetConfigDescList)
			{
				string assetPath = item.AssetPath;
				if (!string.IsNullOrEmpty(assetPath) && !PublicResourcePathDic.ContainsKey(assetPath))
				{
					PublicResourcePathDic.Add(assetPath, EAssetPriority.Low);
				}
			}
		}
		foreach (KeyValuePair<int, FUStStreamingLevelStateDesc> item2 in BGW_GameDB.GetAllStreamingLevelStateDesc())
		{
			string dataAssetPath = item2.Value.DataAssetPath;
			if (!string.IsNullOrEmpty(dataAssetPath) && !PublicResourcePathDic.ContainsKey(dataAssetPath))
			{
				PublicResourcePathDic.Add(dataAssetPath, EAssetPriority.Low);
			}
		}
		foreach (FUStEnvironmentSurfaceEffectDesc value in BGW_GameDB.GetAllEnvironmentSurfaceEffectDesc().Values)
		{
			string environmentAbnormalEffectDA = value.EnvironmentAbnormalEffectDA;
			if (!string.IsNullOrEmpty(environmentAbnormalEffectDA))
			{
				PublicResourcePathDic.Add(environmentAbnormalEffectDA, EAssetPriority.Low);
			}
		}
	}

	public static List<string> GetUnitBeAttackedConfigLoadList(int ResID)
	{
		List<string> list = new List<string>();
		if (ResID > 0)
		{
			for (int i = 1; i <= 99; i++)
			{
				FUStBeAttackedInfoDesc beAttackedInfoDesc = BGW_GameDB.GetBeAttackedInfoDesc(ResID * 100 + i);
				if (beAttackedInfoDesc != null && IsPathValid(beAttackedInfoDesc.UnitBeAttackedConfigPath, bOutputLog: false))
				{
					list.Add(FPackageName.ExportTextPathToObjectPath(beAttackedInfoDesc.UnitBeAttackedConfigPath));
				}
				int partRuleID = ResID * 100 + i;
				List<int> partRuleInfoListByRuleID = BGW_GameDB.GetPartRuleInfoListByRuleID(ResID, partRuleID);
				if (partRuleInfoListByRuleID == null || partRuleInfoListByRuleID.Count <= 0)
				{
					continue;
				}
				foreach (int item in partRuleInfoListByRuleID)
				{
					FUStPartRuleInfoDesc originalPartRuleInfoDesc = BGW_GameDB.GetOriginalPartRuleInfoDesc(item);
					if (originalPartRuleInfoDesc != null && IsPathValid(originalPartRuleInfoDesc.PartHitUnitBeAttackedConfigPath, bOutputLog: false))
					{
						list.Add(FPackageName.ExportTextPathToObjectPath(originalPartRuleInfoDesc.PartHitUnitBeAttackedConfigPath));
					}
				}
			}
		}
		return list;
	}

	public static List<string> GetUnitDeathDispConfigLoadList(int ResID)
	{
		List<string> list = new List<string>();
		if (ResID > 0)
		{
			Dictionary<int, FUStUnitDeadDesc> unitDeadDescDicByUnitResID = BGW_GameDB.GetUnitDeadDescDicByUnitResID(ResID);
			if (unitDeadDescDicByUnitResID != null)
			{
				foreach (KeyValuePair<int, FUStUnitDeadDesc> item in unitDeadDescDicByUnitResID)
				{
					FUStUnitDeadDesc value = item.Value;
					if (value != null && IsPathValid(value.DeathDispConfigPath, bOutputLog: false))
					{
						list.Add(FPackageName.ExportTextPathToObjectPath(value.DeathDispConfigPath));
					}
				}
			}
		}
		return list;
	}

	public static void LoadUnitDescResource(PreloadLevelConfig PL_Config, int ResID, int OverrideID, ref Dictionary<string, EAssetPriority> LoadList)
	{
		if (!PL_Config.IsIgnoreAllFX && !PL_Config.IsIgnoreHitSceneItemFX)
		{
			GetHitSceneItemPerformPreloadData(ResID, LoadList);
		}
		if (!PL_Config.IsIgnoreAllAiConversation)
		{
			GetUnitAiConversationPreloadData(ResID, LoadList);
		}
		GetUnitFacialAnimationPreloadData(ResID, LoadList);
		GetLevelUpDescPreloadData(ResID, OverrideID, LoadList);
		switch (ResID)
		{
		case 0:
			GetAbnormalDispMapPreloadData(0, OverrideID, LoadList);
			GetAbnormalDispMapPreloadData(1, OverrideID, LoadList);
			break;
		case 1025:
			GetAbnormalDispMapPreloadData(2, OverrideID, LoadList);
			break;
		default:
			GetAbnormalDispMapPreloadData(ResID, OverrideID, LoadList);
			break;
		}
		Dictionary<int, Dictionary<string, EAssetPriority>> dictionary = (PL_Config.IsIgnoreAllFX ? sUnitDescResourcCache_IgnoreFX : sUnitDescResourcCache);
		if (!dictionary.TryGetValue(ResID, out var value))
		{
			value = new Dictionary<string, EAssetPriority>();
			GetUnitTransStagePreloadData(ResID, value, PL_Config.IsIgnoreAllFX);
			GetUnitDeadPreloadData(ResID, value);
			GetUnitTransPreloadData(ResID, value, PL_Config.IsIgnoreAllFX);
			if (!PL_Config.IsIgnoreAllFX)
			{
				GetAttackHitFXPreloadData(ResID, value);
				GetBeAttackedFXPreloadData(ResID, value);
			}
			GetUnitPhysicalAnimationPreloadData(ResID, value);
			GetPartInfoPreloadData(ResID, value);
			GetSoulLockCameraPreloadData(ResID, value);
			GetUnitChangeMaterialByAttrPreloadData(ResID, value);
			GetUnitFootstepPreloadData(ResID, value);
			for (int i = 0; i < 200; i++)
			{
				GetProjectilePreloadData(i, value, PL_Config.IsIgnoreAllFX);
			}
			GetDialogueFacialAnimPreloadData(ResID, value);
			dictionary.Add(ResID, value);
		}
		foreach (KeyValuePair<string, EAssetPriority> item in value)
		{
			if (!LoadList.ContainsKey(item.Key))
			{
				LoadList.Add(item.Key, item.Value);
			}
		}
	}

	public static void LoadUnitCommResource(PreloadLevelConfig PL_Config, ref Dictionary<string, EAssetPriority> LoadList)
	{
		LoadUnitDescResource(PL_Config, 0, 0, ref LoadList);
		int num = 0;
		for (int i = 0; i < 1000; i++)
		{
			GetBuffPreloadData(num + i, LoadList, PL_Config.IsIgnoreAllFX);
		}
		if (!PL_Config.IsIgnoreAllFX)
		{
			GetBuffDispGroupPreloadData(LoadList);
		}
		num = 20000;
		for (int j = 0; j < 1000; j++)
		{
			GetBuffPreloadData(num + j, LoadList, PL_Config.IsIgnoreAllFX);
		}
		num = 22000;
		for (int k = 0; k < 1000; k++)
		{
			GetBuffPreloadData(num + k, LoadList, PL_Config.IsIgnoreAllFX);
		}
	}

	public static void LoadMonsterDescResource(PreloadLevelConfig PL_Config, int ResID, int OverrideID, ref Dictionary<string, EAssetPriority> LoadList)
	{
		LoadUnitDescResource(PL_Config, ResID, OverrideID, ref LoadList);
		Dictionary<int, Dictionary<string, EAssetPriority>> dictionary = (PL_Config.IsIgnoreAllFX ? sCommonDescResourceCache_Monster_IgnoreFX : sCommonDescResourceCache_Monster);
		if (!dictionary.TryGetValue(ResID, out var value))
		{
			value = new Dictionary<string, EAssetPriority>();
			GetUnitImmobilizeSkillConfigPreloadData(ResID, value, IsIgnoreAllFX: false);
			GetUnitIronConfigPreloadData(ResID, value, IsIgnoreAllFX: false);
			int num = 100;
			int num2 = ResID * num;
			for (int i = 0; i < num; i++)
			{
				int num3 = 100;
				int num4 = (num2 + i) * num3;
				for (int j = 0; j < num3; j++)
				{
					GetSkillEffectPreloadData(num4 + j, value, PL_Config.IsIgnoreAllFX);
					GetProjectilePreloadData(num4 + j, value, PL_Config.IsIgnoreAllFX);
				}
				if (GetSkillSPreloadData(num2 + i, value))
				{
					GetSkillSMappingPreloadData(num2 + i, value);
					GetSummonCopySkillPreloadData(num2 + i, value);
				}
				GetBuffPreloadData(num2 + i, value, PL_Config.IsIgnoreAllFX);
				GetBeAttackedInfoPreloadData(num2 + i, value);
				GetCBGTemplatePreloadData(num2 + i, ResID, value);
			}
			GetUnitOutlawPreloadData(ResID, value, PL_Config.IsIgnoreAllFX);
			dictionary.Add(ResID, value);
		}
		foreach (KeyValuePair<string, EAssetPriority> item in value)
		{
			if (!LoadList.ContainsKey(item.Key))
			{
				LoadList.Add(item.Key, item.Value);
			}
		}
	}

	public static bool GetUnitOutlawPreloadData(int ResID, Dictionary<string, EAssetPriority> LoadPath, bool IsIgnoreAllFX)
	{
		if (BGW_PreloadAssetMgr.UnitPreload_Outlaws == null)
		{
			return false;
		}
		if (BGW_PreloadAssetMgr.UnitPreload_Outlaws.Outlaws.TryGetValue(ResID, out var value))
		{
			foreach (FResourceID_PreloadOutlaw item in value.Array)
			{
				switch (item.Type)
				{
				case EIDType_Outlaw.Buff:
					GetBuffPreloadData(item.ID, LoadPath, IsIgnoreAllFX);
					break;
				case EIDType_Outlaw.SkillEffect:
					GetSkillEffectPreloadData(item.ID, LoadPath, IsIgnoreAllFX);
					break;
				case EIDType_Outlaw.Projectile:
					GetProjectilePreloadData(item.ID, LoadPath, IsIgnoreAllFX);
					break;
				case EIDType_Outlaw.Summon:
					GetSummonCommPreloadData(item.ID, LoadPath, IsIgnoreAllFX);
					break;
				}
			}
		}
		return false;
	}

	public static void LoadPlayerDescResource(PreloadLevelConfig PL_Config, AActor PlayerActor, int ResID, int OverrideID, bool IsOriginPlayer, ref Dictionary<string, EAssetPriority> LoadList)
	{
		LoadUnitDescResource(PL_Config, ResID, OverrideID, ref LoadList);
		Dictionary<int, Dictionary<string, EAssetPriority>> dictionary = (PL_Config.IsIgnoreAllFX ? sCommonDescResourceCache_Player_IgnoreFX : sCommonDescResourceCache_Player);
		if (!dictionary.TryGetValue(ResID, out var value))
		{
			value = new Dictionary<string, EAssetPriority>();
			GetUnitPEConfigPreloadData(ResID, value);
			LoadPlayerCommDescResource(ResID, value, PlayerActor);
			LoadLifeSavingHairDescResource(ResID, value);
			int num = 1000;
			int num2 = ResID * num;
			for (int i = 0; i < num; i++)
			{
				GetBeAttackedInfoPreloadData(num2 + i, value);
				GetCBGTemplatePreloadData(num2 + i, ResID, value);
				FUStSkillSDesc originalSkillSDesc = BGW_GameDB.GetOriginalSkillSDesc(num2 + i);
				if (originalSkillSDesc != null)
				{
					if (IsOriginPlayer)
					{
						if (originalSkillSDesc.TemplatePath.Contains("/AM/Attack/") || originalSkillSDesc.TemplatePath.Contains("/AM/Behit/") || originalSkillSDesc.TemplatePath.Contains("/AM/Dodge/") || originalSkillSDesc.TemplatePath.Contains("/AM/PreciseDodge/") || originalSkillSDesc.TemplatePath.Contains("/AM/Fashu/"))
						{
							LoadPlayerSkillRelatedResource(num2 + i, PL_Config.IsIgnoreAllFX, ref value);
						}
					}
					else
					{
						LoadPlayerSkillRelatedResource(num2 + i, PL_Config.IsIgnoreAllFX, ref value);
					}
				}
				GetBuffPreloadData(num2 + i, value, PL_Config.IsIgnoreAllFX);
			}
			LoadPlayerDescByAbility(PL_Config, PlayerActor, ResID, new List<EPreloadPlayerAbilityType>
			{
				EPreloadPlayerAbilityType.FaBao,
				EPreloadPlayerAbilityType.Magic,
				EPreloadPlayerAbilityType.Talent
			}, ref value);
			dictionary.Add(ResID, value);
		}
		foreach (KeyValuePair<string, EAssetPriority> item in value)
		{
			if (!LoadList.ContainsKey(item.Key))
			{
				LoadList.Add(item.Key, item.Value);
			}
		}
	}

	private static void LoadPlayerTalentDesc(TalentSDesc TalentSDesc, PreloadLevelConfig PL_Config, ref Dictionary<string, EAssetPriority> LoadList)
	{
		if (TalentSDesc == null)
		{
			return;
		}
		string[] array = TalentSDesc.AddBuffIDs.Split(',');
		for (int i = 0; i < array.Length; i++)
		{
			if (int.TryParse(array[i], out var result))
			{
				GetBuffPreloadData(result, LoadList, PL_Config.IsIgnoreAllFX);
			}
		}
	}

	private static void LoadPlayerFaBaoDesc(EquipFaBaoAttrDesc FaBaoDesc, PreloadLevelConfig PL_Config, ref Dictionary<string, EAssetPriority> LoadList)
	{
		if (FaBaoDesc != null)
		{
			LoadPlayerSkillRelatedResource(FaBaoDesc.CastSkillId, PL_Config.IsIgnoreAllFX, ref LoadList);
		}
	}

	private static void LoadPlayerSpellDesc(SpellDesc SpellDesc, AActor PlayerActor, int ResID, PreloadLevelConfig PL_Config, ref Dictionary<string, EAssetPriority> LoadList)
	{
		if (SpellDesc == null)
		{
			return;
		}
		LoadPlayerSkillRelatedResource(SpellDesc.SkillId, PL_Config.IsIgnoreAllFX, ref LoadList);
		if (SpellDesc.Type == SpellType.BianShen && SpellDesc.FloatParam.Count >= 5)
		{
			int num = (int)SpellDesc.FloatParam[4];
			FUStUnitTransCommDesc unitTransCommDesc = BGW_GameDB.GetUnitTransCommDesc(num);
			if (unitTransCommDesc != null)
			{
				AddItemToLoadPath(LoadList, unitTransCommDesc.BPPath, EAssetPriority.High);
				LoadPlayerSkillRelatedResource(unitTransCommDesc.UnitBornSkillID, PL_Config.IsIgnoreAllFX, ref LoadList);
				LoadPlayerSkillRelatedResource(unitTransCommDesc.NewUnitBornSkillID, PL_Config.IsIgnoreAllFX, ref LoadList);
				int num2 = 1000;
				int num3 = num * num2;
				for (int i = 0; i < num2; i++)
				{
					GetBuffPreloadData(num3 + i, LoadList, PL_Config.IsIgnoreAllFX);
				}
			}
		}
		else if (SpellDesc.NameEnum == SpellNameEnum.IronBody)
		{
			GetUnitIronConfigPreloadData(ResID, LoadList, IsIgnoreAllFX: false);
		}
		else if (SpellDesc.NameEnum == SpellNameEnum.Immobilize)
		{
			GetPlayerImmobilizeSkillConfigPreloadData(LoadList, IsIgnoreAllFX: false);
		}
		else if (SpellDesc.NameEnum == SpellNameEnum.PhantomRush)
		{
			GetPhantomRushConfigPreloadData(BUS_PhantomRushComp.PhantomRushDefaultConfigID, LoadList, IsIgnoreAllFX: false, PlayerActor);
		}
	}

	private static void LoadPlayerSoulSkillDesc(SoulSkillDesc SoulSkillDesc, PreloadLevelConfig PL_Config, ref Dictionary<string, EAssetPriority> LoadList, int LoadDepth)
	{
		if (SoulSkillDesc == null)
		{
			return;
		}
		LoadPlayerSkillRelatedResource(SoulSkillDesc.SkillIdWhenLeave, PL_Config.IsIgnoreAllFX, ref LoadList);
		LoadPlayerSkillRelatedResource(SoulSkillDesc.SkillId, PL_Config.IsIgnoreAllFX, ref LoadList);
		LoadPlayerSkillRelatedResource(SoulSkillDesc.SkillIdReEnter, PL_Config.IsIgnoreAllFX, ref LoadList);
		if (!SoulSkillDesc.LeaveFXPath.Equals(""))
		{
			AddItemToLoadPath(LoadList, SoulSkillDesc.LeaveFXPath, EAssetPriority.Low);
		}
		if (!SoulSkillDesc.ReEnterFadeOutFXPath.Equals(""))
		{
			AddItemToLoadPath(LoadList, SoulSkillDesc.ReEnterFadeOutFXPath, EAssetPriority.Low);
		}
		switch (SoulSkillDesc.Type)
		{
		case SoulSkillType.MagicallyChange:
		{
			AddItemToLoadPath(LoadList, SoulSkillDesc.DAPath, EAssetPriority.High);
			int overrideAbnormalDispIDAttacker2 = SoulSkillDesc.OverrideAbnormalDispIDAttacker;
			int overrideAbnormalDispIDVictim2 = SoulSkillDesc.OverrideAbnormalDispIDVictim;
			if (overrideAbnormalDispIDAttacker2 > 0)
			{
				LoadAbnormalDisp_Attacker(LoadList, overrideAbnormalDispIDAttacker2);
			}
			if (overrideAbnormalDispIDVictim2 > 0)
			{
				LoadAbnormalDisp_Victim(LoadList, overrideAbnormalDispIDVictim2);
			}
			if (SoulSkillDesc.MappingRandomId.Length <= 0 || LoadDepth > 1)
			{
				break;
			}
			string[] array = SoulSkillDesc.MappingRandomId.Split(';');
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Split(',');
				if (array2.Length == 2)
				{
					int num = int.Parse(array2[0]);
					if (num > 0)
					{
						LoadPlayerSoulSkillDesc(GameDBRuntime.GetSoulSkillDesc(num), PL_Config, ref LoadList, LoadDepth + 1);
					}
				}
			}
			break;
		}
		case SoulSkillType.Mimicry:
		{
			Dictionary<int, FUStSoulSkillMimicryDesc> soulSkillMimicryDescListBySouldSkillID = BGW_GameDB.GetSoulSkillMimicryDescListBySouldSkillID(SoulSkillDesc.Id);
			if (soulSkillMimicryDescListBySouldSkillID == null)
			{
				break;
			}
			{
				foreach (KeyValuePair<int, FUStSoulSkillMimicryDesc> item in soulSkillMimicryDescListBySouldSkillID)
				{
					AddItemToLoadPath(LoadList, item.Value.DAPath, EAssetPriority.High);
					int overrideAbnormalDispIDAttacker = item.Value.OverrideAbnormalDispIDAttacker;
					int overrideAbnormalDispIDVictim = item.Value.OverrideAbnormalDispIDVictim;
					if (overrideAbnormalDispIDAttacker > 0)
					{
						LoadAbnormalDisp_Attacker(LoadList, overrideAbnormalDispIDAttacker);
					}
					if (overrideAbnormalDispIDVictim > 0)
					{
						LoadAbnormalDisp_Victim(LoadList, overrideAbnormalDispIDVictim);
					}
				}
				break;
			}
		}
		}
	}

	public static void LoadPlayerDescByAbility(PreloadLevelConfig PL_Config, AActor PlayerActor, int ResID, List<EPreloadPlayerAbilityType> AbilityTypeList, ref Dictionary<string, EAssetPriority> LoadList)
	{
		APawn aPawn = PlayerActor as APawn;
		IBPC_RoleBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>(aPawn?.PlayerState);
		if (readOnlyData == null)
		{
			return;
		}
		using List<EPreloadPlayerAbilityType>.Enumerator enumerator = AbilityTypeList.GetEnumerator();
		while (enumerator.MoveNext())
		{
			switch (enumerator.Current)
			{
			case EPreloadPlayerAbilityType.Talent:
				foreach (KeyValuePair<int, int> talen in readOnlyData.TalenList)
				{
					LoadPlayerTalentDesc(GameDBRuntime.GetTalentSDescByUnitResIDInMapCache(talen.Key, ResID), PL_Config, ref LoadList);
				}
				break;
			case EPreloadPlayerAbilityType.FaBao:
				foreach (KeyValuePair<EquipPosition, int> equip in readOnlyData.EquipList)
				{
					if (equip.Key == EquipPosition.Fabao)
					{
						LoadPlayerFaBaoDesc(GameDBRuntime.GetEquipFaBaoAttrDesc(equip.Value), PL_Config, ref LoadList);
					}
				}
				break;
			case EPreloadPlayerAbilityType.Magic:
			{
				IBUC_PlayerSpellConfData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_PlayerSpellConfData, BUC_PlayerSpellConfData>(aPawn);
				if (readOnlyData2 == null)
				{
					break;
				}
				foreach (FUStMagicConfInfo item in readOnlyData2.MagicConfInfo)
				{
					LoadPlayerSpellDesc(GameDBRuntime.GetSpellDesc(item.SpellID), PlayerActor, ResID, PL_Config, ref LoadList);
				}
				break;
			}
			case EPreloadPlayerAbilityType.Vigor:
				LoadPlayerSoulSkillDesc(GameDBRuntime.GetSoulSkillDesc(readOnlyData.SoulSkillID), PL_Config, ref LoadList, 0);
				break;
			}
		}
	}

	public static void LoadAllPlayerDescByAbility(PreloadLevelConfig PL_Config, AActor PlayerActor, int ResID, ref Dictionary<string, EAssetPriority> LoadList)
	{
		foreach (object value in Enum.GetValues(typeof(EPreloadPlayerAbilityType)))
		{
			if (!(value is EPreloadPlayerAbilityType))
			{
				continue;
			}
			switch ((EPreloadPlayerAbilityType)value)
			{
			case EPreloadPlayerAbilityType.Talent:
				foreach (TalentSDesc item in GameDBRuntime.GetTBTalentSDesc().List)
				{
					LoadPlayerTalentDesc(item, PL_Config, ref LoadList);
				}
				break;
			case EPreloadPlayerAbilityType.FaBao:
				foreach (EquipFaBaoAttrDesc item2 in GameDBRuntime.GetTBEquipFaBaoAttrDesc().List)
				{
					LoadPlayerFaBaoDesc(item2, PL_Config, ref LoadList);
				}
				break;
			case EPreloadPlayerAbilityType.Magic:
				foreach (SpellDesc item3 in GameDBRuntime.GetTBSpellDesc().List)
				{
					LoadPlayerSpellDesc(item3, PlayerActor, ResID, PL_Config, ref LoadList);
				}
				break;
			case EPreloadPlayerAbilityType.Vigor:
				foreach (SoulSkillDesc item4 in GameDBRuntime.GetTBSoulSkillDesc().List)
				{
					LoadPlayerSoulSkillDesc(item4, PL_Config, ref LoadList, 0);
				}
				break;
			}
		}
	}

	public static void LoadPlayerSkillRelatedResource(int SkillID, bool IsIgnoreAllFX, ref Dictionary<string, EAssetPriority> LoadList)
	{
		if (GetSkillSPreloadData(SkillID, LoadList))
		{
			GetSkillSMappingPreloadData(SkillID, LoadList);
			int num = 100;
			int num2 = SkillID * num;
			for (int i = 0; i < num; i++)
			{
				GetSkillEffectPreloadData(num2 + i, LoadList, IsIgnoreAllFX);
				GetProjectilePreloadData(num2 + i, LoadList, IsIgnoreAllFX);
				GetSummonCopySkillPreloadData(num2 + i, LoadList);
			}
		}
	}

	public static void LoadLevelResource(int NewLevelID, ref Dictionary<string, EAssetPriority> LoadList, ref List<int> RelatedUnitResIDList)
	{
		foreach (ItemDesc item in GameDBRuntime.GetTBItemDesc().List)
		{
			if (!string.IsNullOrEmpty(item.DropTemplete) && !LoadList.ContainsKey(item.DropTemplete))
			{
				LoadList.Add(item.DropTemplete, EAssetPriority.Low);
			}
		}
		foreach (FUStAiConversationContentDesc value in BGW_GameDB.GetAllAiConversationContentDesc().Values)
		{
			if (value.LevelID > 0 && value.LevelID == NewLevelID)
			{
				if (!string.IsNullOrEmpty(value.AkEventPath) && !LoadList.ContainsKey(value.AkEventPath))
				{
					LoadList.Add(value.AkEventPath, EAssetPriority.Medium);
				}
				if (!string.IsNullOrEmpty(value.AMPath) && !LoadList.ContainsKey(value.AMPath))
				{
					LoadList.Add(value.AMPath, EAssetPriority.Medium);
				}
			}
		}
	}

	public static void LoadInteractResource(int InteractID, ref Dictionary<string, EAssetPriority> LoadList)
	{
		FUStInteractiveUnitCommDesc interactiveUnitCommDesc = BGW_GameDB.GetInteractiveUnitCommDesc(InteractID);
		if (interactiveUnitCommDesc != null)
		{
			if (!LoadList.ContainsKey(interactiveUnitCommDesc.FocusIconPath))
			{
				LoadList.Add(interactiveUnitCommDesc.FocusIconPath, EAssetPriority.Medium);
			}
			if (!LoadList.ContainsKey(interactiveUnitCommDesc.HighLightFXPath))
			{
				LoadList.Add(interactiveUnitCommDesc.HighLightFXPath, EAssetPriority.Medium);
			}
			if (!LoadList.ContainsKey(interactiveUnitCommDesc.TalentHighLightFXPath))
			{
				LoadList.Add(interactiveUnitCommDesc.TalentHighLightFXPath, EAssetPriority.Medium);
			}
		}
		foreach (FUStInteractionMappingDesc value in BGW_GameDB.GetAllInteractionMappingDesc().Values)
		{
			if (value.OriginID != InteractID)
			{
				continue;
			}
			if (value.ParamsString.Count > 0)
			{
				string key = value.ParamsString[0];
				if (!LoadList.ContainsKey(key))
				{
					LoadList.Add(key, EAssetPriority.Medium);
				}
			}
			if (value.ParamsString.Count > 1)
			{
				string key2 = value.ParamsString[1];
				if (!LoadList.ContainsKey(key2))
				{
					LoadList.Add(key2, EAssetPriority.Medium);
				}
			}
			if (value.ParamsString.Count > 2)
			{
				string key3 = value.ParamsString[2];
				if (!LoadList.ContainsKey(key3))
				{
					LoadList.Add(key3, EAssetPriority.Medium);
				}
			}
			if (!LoadList.ContainsKey(value.IdleBefore))
			{
				LoadList.Add(value.IdleBefore, EAssetPriority.Medium);
			}
			if (!LoadList.ContainsKey(value.IdleAfter))
			{
				LoadList.Add(value.IdleAfter, EAssetPriority.Medium);
			}
			if (!LoadList.ContainsKey(value.InitAnim))
			{
				LoadList.Add(value.InitAnim, EAssetPriority.Medium);
			}
		}
	}

	public static void LoadDynamicObstacleResource(int PerformID, ref Dictionary<string, EAssetPriority> LoadList)
	{
		List<string> uDOPPreloadPath = BGW_GameDB.GetUDOPPreloadPath(PerformID);
		if (uDOPPreloadPath == null)
		{
			return;
		}
		foreach (string item in uDOPPreloadPath)
		{
			LoadList.Add(item, EAssetPriority.Low);
		}
	}
}
