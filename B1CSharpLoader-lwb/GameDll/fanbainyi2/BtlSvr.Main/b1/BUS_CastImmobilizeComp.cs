using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_CastImmobilizeComp : UActorCompBaseCS
{
	private const float INV1000 = 0.001f;

	private const float INV10000 = 0.0001f;

	private BUC_CastImmobilizeData CastImmobilizeData { get; set; }

	private IBUC_TargetInfoData TargetInfoData { get; set; }

	private IBUC_BuffData BuffData { get; set; }

	public override void OnAttach()
	{
		CastImmobilizeData = RequireWritableData<BUC_CastImmobilizeData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		base.BUSEventCollection.Evt_CastImmobilize += new Del_Void_Int(OnCastImmobilize);
	}

	public override void PreBeginPlay()
	{
		CastImmobilizeData.ResId = GetActorResID();
		CastImmobilizeData.GetCachedImmobilizeConfigDesc(CastImmobilizeData.ResId);
	}

	private void OnCastImmobilize(int ConfigID)
	{
		if (ConfigID == 0)
		{
			ConfigID = CastImmobilizeData.ResId;
		}
		FUStImmobilizeSkillConfigDesc cachedImmobilizeConfigDesc = CastImmobilizeData.GetCachedImmobilizeConfigDesc(ConfigID);
		if (cachedImmobilizeConfigDesc == null || BGW_LogUtil.LogIfNull(GetOwner() as ABGUCharacter, "CurCharacter is null"))
		{
			return;
		}
		ABGUCharacter aBGUCharacter = null;
		aBGUCharacter = TargetInfoData.GetSkillBaseTarget().LockTargetActor as ABGUCharacter;
		if (aBGUCharacter == null)
		{
			aBGUCharacter = TargetInfoData.GetTargetInfo().LockTargetActor as ABGUCharacter;
		}
		if (BGW_LogUtil.LogIfNull(aBGUCharacter, "CurrentTarget As BGUCharacter is null") || !BGUFuncLibSelectTargetsCS.BGUIsSelectTargetByTeamFilter(GetOwner(), aBGUCharacter, cachedImmobilizeConfigDesc.TargetFilter) || !BGUFuncLibSelectTargetsCS.BGUIsSelectTargetByAffiliationFilter(GetOwner(), aBGUCharacter, cachedImmobilizeConfigDesc.AffiliationTypeFilter))
		{
			return;
		}
		int num = ((cachedImmobilizeConfigDesc.TargetCount <= 0) ? 1 : cachedImmobilizeConfigDesc.TargetCount);
		List<AActor> OutActors = new List<AActor>();
		if (num > 1)
		{
			List<int> list = new List<int> { cachedImmobilizeConfigDesc.RangeRadius };
			AActor owner = GetOwner();
			AActor owner2 = GetOwner();
			FVector baseLoc = BGUFuncLibActorTransformCS.BGUGetActorLocation(aBGUCharacter);
			int targetFilter = cachedImmobilizeConfigDesc.TargetFilter;
			int targetTypeFilter = cachedImmobilizeConfigDesc.TargetTypeFilter;
			int affiliationTypeFilter = cachedImmobilizeConfigDesc.AffiliationTypeFilter;
			IList<int> Prams = list;
			BGUFuncLibSelectTargetsCS.BGUSelectTargetsInShape(owner, out OutActors, owner2, baseLoc, ERangeType.Circle, -1, targetFilter, targetTypeFilter, affiliationTypeFilter, in Prams);
		}
		if (OutActors.Contains(aBGUCharacter))
		{
			OutActors.Remove(aBGUCharacter);
			OutActors.Insert(0, aBGUCharacter);
		}
		else
		{
			OutActors.Insert(0, aBGUCharacter);
		}
		int num2 = 0;
		foreach (AActor item in OutActors)
		{
			if (num2 >= num)
			{
				break;
			}
			if (BGUFunctionLibraryCS.BGUHasUnitState(item, EBGUUnitState.Dead))
			{
				continue;
			}
			if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(item, EBGUSimpleState.ImmueImmobilizing))
			{
				int actorResID = BGU_DataUtil.GetActorResID(item);
				UBGWDataAsset fXAssetByResID = GetFXAssetByResID(cachedImmobilizeConfigDesc.FailedFXs, actorResID, CastImmobilizeData.ResId);
				if (fXAssetByResID != null)
				{
					BUS_EventCollectionCS.Get(item)?.Evt_RequestSpawnFXByDispConfigDA.Invoke(fXAssetByResID, out var _);
				}
				continue;
			}
			num2++;
			int actorResID2 = BGU_DataUtil.GetActorResID(item);
			if (BGW_LogUtil.LogIfNull(BGW_GameDB.GetUnitCommDesc(actorResID2), "BGW_GameDB.GetUnitCommDesc is null, ResID:%d", actorResID2))
			{
				continue;
			}
			float num3 = cachedImmobilizeConfigDesc.DurationMs;
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(GetOwner(), EBattleInfoType.DingShen, "<character>" + GetOwner().GetName() + "</><action>对</><bechosed>" + item.GetName() + "</><action>施加定身</>");
			}
			ImmobilizeConfigInstance immobilizeConfigInstance = new ImmobilizeConfigInstance();
			int actorResID3 = BGU_DataUtil.GetActorResID(item);
			immobilizeConfigInstance.DurationSecond = num3 * 0.001f;
			immobilizeConfigInstance.AlmostEndAheadTimeSecond = (float)cachedImmobilizeConfigDesc.AlmostEndAheadTimeMs * 0.001f;
			immobilizeConfigInstance.MinDurationSecond = (float)cachedImmobilizeConfigDesc.MinimalDurationMs * 0.001f;
			immobilizeConfigInstance.RepeatedImmobilizedDef = (float)cachedImmobilizeConfigDesc.RepeatedImmobilizedDef * 0.0001f;
			immobilizeConfigInstance.CasterActor = GetOwner();
			immobilizeConfigInstance.bEnableGreatSageTalent = cachedImmobilizeConfigDesc.GreatSageTalentActiveBuff > 0 && BuffData.HasBuff(cachedImmobilizeConfigDesc.GreatSageTalentActiveBuff);
			immobilizeConfigInstance.BeginFX = GetFXAssetByResID(cachedImmobilizeConfigDesc.BeginFXs, actorResID3, CastImmobilizeData.ResId);
			immobilizeConfigInstance.AlmostEndFX = GetFXAssetByResID(cachedImmobilizeConfigDesc.AlmostEndFXs, actorResID3, CastImmobilizeData.ResId);
			immobilizeConfigInstance.EndFX = GetFXAssetByResID(cachedImmobilizeConfigDesc.EndFXs, actorResID3, CastImmobilizeData.ResId);
			immobilizeConfigInstance.QuickFX = GetFXAssetByResID(cachedImmobilizeConfigDesc.QuickEndFXs, actorResID3, CastImmobilizeData.ResId);
			immobilizeConfigInstance.BreakingFXsTriggerRatio = (float)cachedImmobilizeConfigDesc.BreakingFXsTriggerRatio * 0.0001f;
			immobilizeConfigInstance.BreakingFX = GetFXAssetByResID(cachedImmobilizeConfigDesc.BreakingFXs, actorResID3, CastImmobilizeData.ResId);
			foreach (FSpellEffect beginEffect in cachedImmobilizeConfigDesc.BeginEffects)
			{
				immobilizeConfigInstance.BeginEffects.Add(new FSpellEffectForData(beginEffect));
			}
			foreach (FSpellEffect endEffect in cachedImmobilizeConfigDesc.EndEffects)
			{
				immobilizeConfigInstance.EndEffects.Add(new FSpellEffectForData(endEffect));
			}
			foreach (FSpellEffect breakEffect in cachedImmobilizeConfigDesc.BreakEffects)
			{
				immobilizeConfigInstance.BreakEffects.Add(new FSpellEffectForData(breakEffect));
			}
			foreach (FSpellEffect deadEffect in cachedImmobilizeConfigDesc.DeadEffects)
			{
				immobilizeConfigInstance.DeadEffects.Add(new FSpellEffectForData(deadEffect));
			}
			BUS_EventCollectionCS.Get(item)?.Evt_TriggerImmobilize.Invoke(immobilizeConfigInstance);
		}
	}

	private UBGWDataAsset GetFXAssetByResID(IList<FPlayFXByResID> FXs, int TargetResID, int OwnerResID)
	{
		string text = "";
		foreach (FPlayFXByResID FX in FXs)
		{
			if (FX.ResID == TargetResID)
			{
				text = FX.FXPathByDBC;
				break;
			}
			if (FX.ResID == OwnerResID)
			{
				text = FX.FXPathByDBC;
			}
		}
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		return BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UBGWDataAsset>(text, ELoadResourceType.AsyncLoadAndCache);
	}
}
