using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class FForceFightUnitGroupConfig
{
	public EGSForceFightCondition TriggerCondition;

	public FForceFightTriggerUnitFilter TriggerUnitFilter;

	public List<FForceFightUnitCondition> ObserveUnitsConditions;

	public EGSForceFightTargetType ForceFightTargetType;

	public string TargetUnitGuid;

	public List<EGSForceFightTriggerUnitType> TriggerUnitsType;

	public List<string> TriggerUnitsGuid;

	public bool IgnorePlayer;

	public List<string> IgnoreUnitsGuid;

	public bool CanRepeat;

	public FForceFightUnitGroupConfig(FGSForceFightUnitGroupConfig ForceFightUnitGroupConfig)
	{
		TriggerCondition = ForceFightUnitGroupConfig.TriggerCondition;
		TriggerUnitFilter = new FForceFightTriggerUnitFilter(ForceFightUnitGroupConfig.TriggerUnitFilter);
		ObserveUnitsConditions = new List<FForceFightUnitCondition>();
		foreach (FGSForceFightUnitCondition observeUnitsCondition in ForceFightUnitGroupConfig.ObserveUnitsConditions)
		{
			ObserveUnitsConditions.Add(new FForceFightUnitCondition(observeUnitsCondition));
		}
		ForceFightTargetType = ForceFightUnitGroupConfig.ForceFightTargetType;
		TargetUnitGuid = ForceFightUnitGroupConfig.TargetTamerRef.ActorGuid;
		TriggerUnitsType = ForceFightUnitGroupConfig.TriggerUnitsType;
		TriggerUnitsGuid = new List<string>();
		foreach (FGsActorGuidReference triggerTamerRef in ForceFightUnitGroupConfig.TriggerTamerRefs)
		{
			TriggerUnitsGuid.Add(triggerTamerRef.ActorGuid);
		}
		IgnorePlayer = ForceFightUnitGroupConfig.TriggerUnitsWhiteList.IgnorePlayer;
		IgnoreUnitsGuid = new List<string>();
		foreach (FGsActorGuidReference ignoreTamerRef in ForceFightUnitGroupConfig.TriggerUnitsWhiteList.IgnoreTamerRefs)
		{
			IgnoreUnitsGuid.Add(ignoreTamerRef.ActorGuid);
		}
		CanRepeat = ForceFightUnitGroupConfig.CanRepeat;
	}

	public bool IsValidUnitStateCondition(AActor InOwner)
	{
		foreach (FForceFightUnitCondition observeUnitsCondition in ObserveUnitsConditions)
		{
			if (!observeUnitsCondition.IsValidCondition(InOwner))
			{
				return false;
			}
		}
		return true;
	}

	public List<BGUCharacterCS> GetAllObserveUnits(AActor InOwner)
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (FForceFightUnitCondition observeUnitsCondition in ObserveUnitsConditions)
		{
			foreach (string observedUnit in observeUnitsCondition.ObservedUnits)
			{
				hashSet.Add(observedUnit);
			}
		}
		List<BGUCharacterCS> list = new List<BGUCharacterCS>();
		foreach (string item2 in hashSet)
		{
			BGUCharacterCS item = BGU_DataUtil.GetActorByGuid(InOwner, item2) as BGUCharacterCS;
			list.Add(item);
		}
		return list;
	}

	public bool CanUnitTriggerForceFight(AActor Unit)
	{
		if (Unit == null)
		{
			return false;
		}
		if (TriggerCondition == EGSForceFightCondition.ObserveUnitsConditions)
		{
			return true;
		}
		switch (TriggerUnitFilter.FilterType)
		{
		case EGSForceFightUnitFilterType.WhiteListFilter:
			if (!IsUnitInFilterUnits(Unit) && !IsUnitInFilterUnitTypes(Unit))
			{
				return false;
			}
			break;
		case EGSForceFightUnitFilterType.BlackListFilter:
			if (IsUnitInFilterUnits(Unit) || IsUnitInFilterUnitTypes(Unit))
			{
				return false;
			}
			break;
		}
		return true;
	}

	private bool IsUnitInFilterUnits(AActor Unit)
	{
		foreach (string filterUnit in TriggerUnitFilter.FilterUnits)
		{
			if (filterUnit != null)
			{
				string actorGuid = BGU_DataUtil.GetActorGuid(Unit);
				if (filterUnit == actorGuid)
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool IsUnitInFilterUnitTypes(AActor Unit)
	{
		if (Unit == null)
		{
			return false;
		}
		APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Unit)?.GetControlledPawn();
		using (List<EGSForceFightUnitType>.Enumerator enumerator = TriggerUnitFilter.FilterUnitTypes.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				switch (enumerator.Current)
				{
				case EGSForceFightUnitType.Player:
					if (Unit == aPawn)
					{
						return true;
					}
					break;
				case EGSForceFightUnitType.PlayerTeam:
				{
					BGUCharacterCS bGUCharacterCS = Unit as BGUCharacterCS;
					BGUPlayerCharacterCS bGUPlayerCharacterCS = aPawn as BGUPlayerCharacterCS;
					if (bGUCharacterCS != null && bGUPlayerCharacterCS != null && bGUCharacterCS.GetTeamIDInCS() == bGUPlayerCharacterCS.GetTeamIDInCS())
					{
						return true;
					}
					break;
				}
				}
			}
		}
		return false;
	}
}
