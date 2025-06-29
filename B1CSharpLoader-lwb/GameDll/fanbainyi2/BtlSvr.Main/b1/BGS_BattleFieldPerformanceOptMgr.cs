using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BGS_BattleFieldPerformanceOptMgr : GameStateSystemBase
{
	private BGC_BattleFieldPerformanceOptData OptData;

	private IBGC_LocalPlayerSharedData LocalPlayerSharedData;

	public override void OnAttach()
	{
		OptData = RequireWritableData<BGC_BattleFieldPerformanceOptData>();
		LocalPlayerSharedData = RequireReadOnlyGameStateData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>();
		base.BGSEventCollection.Evt_BGS_BattleFieldPerformanceOptUnit += new Del_Void_Actor(OnRegistOptTarget);
	}

	private void OnRegistOptTarget(AActor Unit)
	{
		if (Unit.IsNullOrDestroyed() || Unit is BGUPlayerCharacterCS)
		{
			return;
		}
		string actorGuid = BGU_DataUtil.GetActorGuid(Unit);
		if (!OptData.BattleFieldMonitorDic.ContainsKey(actorGuid))
		{
			if (OptData.BattleFieldMonitorDic.Count == 0)
			{
				base.BGSEventCollection.Evt_BGS_UnitDead += new Del_Void_StringDeadReason(OnUnitDead);
			}
			BattleFieldMonitor_UnitInfo value = new BattleFieldMonitor_UnitInfo(Unit);
			OptData.BattleFieldMonitorDic.Add(actorGuid, value);
		}
	}

	private void OnUnitDead(string UnitGuid, EDeadReason DeadReason)
	{
		if (OptData.BattleFieldMonitorDic.Remove(UnitGuid))
		{
			OptData.NeedOptUnitList.Remove(UnitGuid);
			if (OptData.BattleFieldMonitorDic.Count == 0)
			{
				base.BGSEventCollection.Evt_BGS_UnitDead -= new Del_Void_StringDeadReason(OnUnitDead);
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	private void InitOptConfig()
	{
		OptData.OptConfig = BGW_PreloadAssetMgr.Get(Owner).BattleFieldPerformanceOptConfig;
		if (!(OptData.OptConfig == null))
		{
			OptData.IsConfigSetted = true;
		}
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!OptData.IsConfigSetted)
		{
			InitOptConfig();
			if (!OptData.IsConfigSetted)
			{
				return;
			}
		}
		if (OptData.OptConfig.Enable && OptData.BattleFieldMonitorDic.Count >= 0)
		{
			OptData.TickIntervalTime -= DeltaTime;
			if (OptData.TickIntervalTime <= 0f)
			{
				OptData.TickIntervalTime = OptData.OptConfig.TickInterval;
				UpdateMonitor();
			}
			if (OptData.OptConfig.DrawDebug)
			{
				DrawDebug();
			}
		}
	}

	private void UpdateMonitor()
	{
		OptData.NeedOptUnitList.Clear();
		foreach (KeyValuePair<string, BattleFieldMonitor_UnitInfo> item in OptData.BattleFieldMonitorDic)
		{
			if (item.Value.bNeedOpenOpt(LocalPlayerSharedData.FirstLocalPlayerPawn, OptData.OptConfig.DistThreshold_ToPlayer))
			{
				OptData.NeedOptUnitList.Add(item.Key);
			}
		}
	}

	private void DrawDebug()
	{
		FLinearColor aqua = FLinearColor.Aqua;
		float thickness = 1f;
		foreach (string needOptUnit in OptData.NeedOptUnitList)
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, needOptUnit);
			if (!actorByGuid.IsNullOrDestroyed())
			{
				BGUCharacterCS bGUCharacterCS = actorByGuid as BGUCharacterCS;
				if (!bGUCharacterCS.IsNullOrDestroyed())
				{
					USystemLibrary.DrawDebugCapsule(bGUCharacterCS, bGUCharacterCS.GetActorLocation(), bGUCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight(), bGUCharacterCS.CapsuleComponent.GetScaledCapsuleRadius(), bGUCharacterCS.GetActorRotation(), aqua, 0f, thickness);
				}
			}
		}
	}
}
