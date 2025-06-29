using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class FBuffTriggerUnitCondition
{
	public EConditionsTarget ConditionsTarget;

	public List<FName> Tags;

	public bool ObserveIsActivedUnit;

	public bool ObserveIsDeadUnit;

	public bool ObserveHasUnitState;

	public List<EBGUUnitState> ObserveUnitStates;

	public bool ObserveHasSimpleState;

	public List<EBGUSimpleState> ObserveSimpleStates;

	public bool ObserveHasBuff;

	public List<int> ObserveBuffIDs;

	public bool ObserveHasUnitAttr;

	public List<FUnitAttrCondition> ObserveUnitAttrs;

	public List<BGUBulletBaseCS> ObserveBullets;

	public FBuffTriggerConfig BuffTriggerConfig;

	public bool CanRepeat;

	public List<string> ObservedUnitGuidList { get; } = new List<string>();

	public List<string> ObserveActivedUnitGuidList { get; } = new List<string>();

	public List<string> ObserveDeadUnitGuidList { get; } = new List<string>();

	public FBuffTriggerUnitCondition(FGSBuffTriggerUnitCondition UnitCondition)
	{
		ConditionsTarget = UnitCondition.ConditionsTarget;
		Tags = UnitCondition.Tags;
		ObservedUnitGuidList.Clear();
		foreach (FGsActorGuidReference observedTamerRef in UnitCondition.ObservedTamerRefs)
		{
			ObservedUnitGuidList.Add(observedTamerRef.ActorGuid);
		}
		ObserveIsActivedUnit = UnitCondition.ObserveIsActivedUnit;
		ObserveActivedUnitGuidList.Clear();
		foreach (FGsActorGuidReference observeActiveTamerRef in UnitCondition.ObserveActiveTamerRefs)
		{
			ObserveActivedUnitGuidList.Add(observeActiveTamerRef.ActorGuid);
		}
		ObserveIsDeadUnit = UnitCondition.ObserveIsDeadUnit;
		ObserveDeadUnitGuidList.Clear();
		foreach (FGsActorGuidReference observeDeadTamerRef in UnitCondition.ObserveDeadTamerRefs)
		{
			ObserveDeadUnitGuidList.Add(observeDeadTamerRef.ActorGuid);
		}
		ObserveHasUnitState = UnitCondition.ObserveHasUnitState;
		ObserveUnitStates = UnitCondition.ObserveUnitStates;
		ObserveHasSimpleState = UnitCondition.ObserveHasSimpleState;
		ObserveSimpleStates = UnitCondition.ObserveSimpleStates;
		ObserveHasBuff = UnitCondition.ObserveHasBuff;
		ObserveBuffIDs = UnitCondition.ObserveBuffIDs;
		ObserveHasUnitAttr = UnitCondition.ObserveHasUnitAttr;
		ObserveUnitAttrs = UnitCondition.ObserveUnitAttrs;
		BuffTriggerConfig = new FBuffTriggerConfig(UnitCondition.BuffTriggerConfig);
		ObserveBullets = new List<BGUBulletBaseCS>();
	}

	public bool IsValidCondition()
	{
		if (BuffTriggerConfig.AddBuffTarget == EBuffTarget.SceneUnit && BuffTriggerConfig.AddSceneUnitGuidList.Count == 0)
		{
			return false;
		}
		if (BuffTriggerConfig.RemoveBuffTarget == EBuffTarget.SceneUnit && BuffTriggerConfig.RemoveSceneUnitGuidList.Count == 0)
		{
			return false;
		}
		return true;
	}
}
