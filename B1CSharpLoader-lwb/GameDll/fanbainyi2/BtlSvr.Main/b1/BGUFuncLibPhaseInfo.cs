using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGUFuncLibPhaseInfo
{
	private static readonly char Separated = '-';

	public static List<int> GetBossResIdList(UObject WorldContext)
	{
		List<int> list = new List<int>();
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, UClass.GetClass<BGU_CharacterAI>());
		foreach (AActor aActor in allActorsOfClass)
		{
			IBUC_FsmData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_FsmData>(aActor);
			if (readOnlyData != null && readOnlyData.GetPhaseComp() != null)
			{
				int actorResID = BGU_DataUtil.GetActorResID(aActor);
				list.Add(actorResID);
			}
		}
		return list;
	}

	public static List<AActor> GetBossActorList(UObject WorldContext)
	{
		List<AActor> list = new List<AActor>();
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, UClass.GetClass<BGU_CharacterAI>());
		foreach (AActor aActor in allActorsOfClass)
		{
			IBUC_FsmData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_FsmData>(aActor);
			if (readOnlyData != null && readOnlyData.GetPhaseComp() != null)
			{
				list.Add(aActor);
			}
		}
		return list;
	}

	public static List<string> GetBossPhaseNameList(UObject WorldContext, int ResId)
	{
		List<string> Ret = new List<string>();
		ForeachBossDo(WorldContext, ResId, delegate(FsmInstancePhaseComp Comp)
		{
			Comp.FetchEachBossPhase(ref Ret, Separated.ToString());
		});
		Ret.Sort();
		return Ret;
	}

	public static void TransitionEachPhase(UObject WorldContext, int ResId, string BossPhaseName)
	{
		string[] StateNames = BossPhaseName.Split(Separated);
		ForeachBossDo(WorldContext, ResId, delegate(FsmInstancePhaseComp Comp)
		{
			Comp.TransitionEachPhaseForDebug(StateNames);
		});
	}

	private static void ForeachBossDo(UObject WorldContext, int ResId, Action<FsmInstancePhaseComp> CompFunc)
	{
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, UClass.GetClass<BGU_CharacterAI>());
		foreach (AActor aActor in allActorsOfClass)
		{
			IBUC_FsmData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_FsmData>(aActor);
			if (readOnlyData != null)
			{
				FsmInstancePhaseComp phaseComp = readOnlyData.GetPhaseComp();
				if (phaseComp != null && ResId == BGU_DataUtil.GetActorResID(aActor))
				{
					CompFunc(phaseComp);
				}
			}
		}
	}
}
