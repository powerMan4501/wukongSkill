using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.ECS;
using b1.EventDelDefine;
using b1.Plugins.Calliope;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BGS_SummonManagerSystem : GameStateSystemBase
{
	private BGC_SummonData SummonData { get; set; }

	private IBGC_TamerData TamerData { get; set; }

	public override void OnAttach()
	{
		SummonData = RequireWritableData<BGC_SummonData>();
		TamerData = RequireReadOnlyData<IBGC_TamerData, BGC_TamerData>();
		base.BGSEventCollection.Evt_RequestSummonSvr += new Del_Void_SummonRequest(RequestSummon);
		base.BGSEventCollection.Evt_ClearAllSummon += new Del_Void(ClearAllSummon);
		base.BGSEventCollection.Evt_NotifyPossessEntityChanged += new Del_Void_EntityEntity(OnPossessEntityChanged);
		base.BGSEventCollection.Evt_RegisterServantSvr += new Del_Void_ServantInstance(RegisterServant);
		base.BGSEventCollection.Evt_BGS_UnitDead += new Del_Void_StringDeadReason(OnUnitDead);
	}

	private void OnUnitDead(string InUnitGuid, EDeadReason InDeadReason)
	{
		if (InDeadReason != EDeadReason.SkillDamage || !TamerData.TryGetTamerEntityRef(InUnitGuid, out var OutTamerRef) || OutTamerRef.TamerType != ETamerType.Summoned)
		{
			return;
		}
		FServantInstanceBase servantInstance = OutTamerRef.ServantInstance;
		if (servantInstance != null)
		{
			FCalliopeGuid summonInstanceID = OutTamerRef.ServantInstance.SummonInstanceID;
			if (SummonData.SummonInstances.TryGetValue(summonInstanceID, out var value))
			{
				value.NotifyServantBeKilled(servantInstance);
				servantInstance.ActualPhase = EServantPhase.Dead;
			}
		}
	}

	private void RegisterServant(FServantInstanceBase InServantInstance)
	{
		if (InServantInstance != null && SummonData.SummonInstances.TryGetValue(InServantInstance.SummonInstanceID, out var value))
		{
			value.ServantInstances.Add(InServantInstance);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		SummonData.SummonerSummonInstances.Clear();
		SummonData.SummonInstances.Clear();
	}

	private void OnPossessEntityChanged(Entity OldEntity, Entity NewEntity)
	{
		string actorGuid = BGU_DataUtil.GetActorGuid(ECSExtension.ToActor(OldEntity));
		string actorGuid2 = BGU_DataUtil.GetActorGuid(ECSExtension.ToActor(NewEntity));
		if (!SummonData.SummonerSummonInstances.TryGetValue(actorGuid, out var value))
		{
			return;
		}
		SummonData.SummonerSummonInstances.Remove(actorGuid);
		SummonData.SummonerSummonInstances[actorGuid2] = value;
		foreach (FSummonInstance item in value)
		{
			item.SummonReq.Summoner = ECSExtension.ToActor(NewEntity);
			item.SummonerGuid = actorGuid2;
		}
	}

	public override void PreBeginPlay()
	{
		SummonData.SystemContext = new FSummonSystemContext
		{
			PreloadAssetMgr = BGW_PreloadAssetMgr.Get(Owner),
			BGSEventCollection = base.BGSEventCollection,
			BGWEventCollection = base.BGWEventCollection,
			SystemOwner = Owner
		};
	}

	private void RequestSummon(FSummonReq InSummonReq)
	{
		FSummonInstance fSummonInstance = new FSummonInstance(InSummonReq);
		if (fSummonInstance.Init(SummonData.SystemContext) != 0)
		{
			return;
		}
		SummonData.SummonInstances[fSummonInstance.SummonInstanceID] = fSummonInstance;
		string summonerGuid = fSummonInstance.SummonerGuid;
		if (!string.IsNullOrEmpty(summonerGuid))
		{
			if (!SummonData.SummonerSummonInstances.TryGetValue(summonerGuid, out var value))
			{
				value = new List<FSummonInstance>();
				SummonData.SummonerSummonInstances[summonerGuid] = value;
			}
			value.Add(fSummonInstance);
		}
		fSummonInstance.DoSummon();
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		foreach (FSummonInstance item in SummonData.SummonInstances.Values.ToList())
		{
			item.OnTick(DeltaTime);
			if (item.bSummonEnd)
			{
				SummonData.SummonInstances.Remove(item.SummonInstanceID);
				string summonerGuid = item.SummonerGuid;
				SummonData.SummonerSummonInstances[summonerGuid].Remove(item);
			}
		}
	}

	private void ClearAllSummon()
	{
		foreach (FSummonInstance item in SummonData.SummonInstances.Values.ToList())
		{
			item.ShutdownSummon();
		}
		SummonData.SummonInstances.Clear();
	}
}
