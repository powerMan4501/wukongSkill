using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class PatrolGroupInfo
{
	public USplineComponent Spline;

	public List<string> ActiveUnits;

	public int TargetPathPointIndex;

	public List<string> WaitPointUnits;

	public bool ReversedDirection;

	public bool NeedStopPatrol;

	public string SplineActorGuid;

	public EGSGroupSplinePatrolType GroupSplinePatrolType;

	public List<string> GroupMembersGuid;

	public List<FVector> GroupFormation;

	public PatrolGroupInfo(FPatrolGroupSetting GroupSetting)
	{
		SplineActorGuid = GroupSetting.SplineActor.ActorGuid;
		GroupSplinePatrolType = GroupSetting.GroupSplinePatrolType;
		ReversedDirection = (NeedStopPatrol = false);
		GroupMembersGuid = new List<string>();
		foreach (FGsActorGuidReference groupMember in GroupSetting.GroupMembers)
		{
			GroupMembersGuid.Add(groupMember.ActorGuid);
		}
		GroupFormation = GroupSetting.GroupFormation;
		ActiveUnits = new List<string>();
		WaitPointUnits = new List<string>();
	}

	public void Reset()
	{
		ReversedDirection = (NeedStopPatrol = false);
		TargetPathPointIndex = 0;
	}

	public void RemoveUnit(string Unit)
	{
		ActiveUnits.Remove(Unit);
		WaitPointUnits.Remove(Unit);
	}
}
