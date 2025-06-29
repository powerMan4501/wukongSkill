using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FForceFightUnitCondition
{
	public bool ObserveHasUnitState;

	public List<EBGUUnitState> ObserveUnitStates;

	public bool ObserveHasSimpleState;

	public List<EBGUSimpleState> ObserveSimpleStates;

	public bool ObserveHasBuff;

	public List<int> ObserveBuffIDs;

	public List<string> ObservedUnits { get; } = new List<string>();

	public FForceFightUnitCondition(FGSForceFightUnitCondition UnitStateCondition)
	{
		foreach (FGsActorGuidReference observedTamerRef in UnitStateCondition.ObservedTamerRefs)
		{
			ObservedUnits.Add(observedTamerRef.ActorGuid);
		}
		for (int num = ObservedUnits.Count - 1; num >= 0; num--)
		{
			if (ObservedUnits[num] == null)
			{
				ObservedUnits.RemoveAt(num);
			}
		}
		ObserveHasUnitState = UnitStateCondition.ObserveHasUnitState;
		ObserveUnitStates = UnitStateCondition.ObserveUnitStates;
		ObserveHasSimpleState = UnitStateCondition.ObserveHasSimpleState;
		ObserveSimpleStates = UnitStateCondition.ObserveSimpleStates;
		ObserveHasBuff = UnitStateCondition.ObserveHasBuff;
		ObserveBuffIDs = UnitStateCondition.ObserveBuffIDs;
	}

	public bool IsValidCondition(AActor InOwner)
	{
		foreach (string observedUnit in ObservedUnits)
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(InOwner, observedUnit);
			if (ObserveHasUnitState)
			{
				foreach (EBGUUnitState observeUnitState in ObserveUnitStates)
				{
					if ((observeUnitState != EBGUUnitState.Dead || (!(actorByGuid == null) && !actorByGuid.IsNullOrDestroyed())) && !BGUFunctionLibraryCS.BGUHasUnitState(actorByGuid, observeUnitState))
					{
						return false;
					}
				}
			}
			if (ObserveHasSimpleState)
			{
				foreach (EBGUSimpleState observeSimpleState in ObserveSimpleStates)
				{
					if (!BGUFunctionLibraryCS.BGUHasUnitSimpleState(actorByGuid, observeSimpleState))
					{
						return false;
					}
				}
			}
			if (!ObserveHasBuff)
			{
				continue;
			}
			foreach (int observeBuffID in ObserveBuffIDs)
			{
				if (!BGUFunctionLibraryCS.BGUHasBuffByID(actorByGuid, observeBuffID))
				{
					return false;
				}
			}
		}
		return true;
	}
}
