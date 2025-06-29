using System;
using b1.ECS;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class GroupAIPerformerInfo : IEquatable<GroupAIPerformerInfo>, IComparable<GroupAIPerformerInfo>
{
	public Entity PerformerEntity;

	public AActor PerformerActor;

	public int ResID;

	public int SortPriority;

	public EGroupAIAttackBias UnitAttackBias;

	public int CostToken;

	public string PerformerName;

	public int RangeAtkSkillNum;

	public int MeleeAtkSkillNum;

	public bool IsAttacking;

	public FVector CachedLocation;

	public float Score;

	public GroupAIPerformerInfo(Entity _PerformerEntity, AActor _PerformerActor, int _ResID, int _SortPriority, EGroupAIAttackBias _UnitAttackBias, int _CostToken, string _PerformerName)
	{
		PerformerEntity = _PerformerEntity;
		PerformerActor = _PerformerActor;
		ResID = _ResID;
		SortPriority = _SortPriority;
		UnitAttackBias = _UnitAttackBias;
		CostToken = _CostToken;
		PerformerName = _PerformerName;
		IsAttacking = false;
		CachedLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(PerformerActor);
	}

	public override int GetHashCode()
	{
		return PerformerEntity.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (!(obj is GroupAIPerformerInfo other))
		{
			return false;
		}
		return Equals(other);
	}

	public bool Equals(GroupAIPerformerInfo other)
	{
		if (other == null)
		{
			return false;
		}
		return PerformerEntity.Equals(other.PerformerEntity);
	}

	public int CompareTo(GroupAIPerformerInfo other)
	{
		if (Score <= 0f)
		{
			if (other.Score <= 0f)
			{
				return 0;
			}
			return -1;
		}
		if (other.Score <= 0f)
		{
			if (Score <= 0f)
			{
				return 0;
			}
			return 1;
		}
		if (Score == other.Score)
		{
			if (SortPriority > other.SortPriority)
			{
				return 1;
			}
			if (SortPriority < other.SortPriority)
			{
				return -1;
			}
			return 0;
		}
		if (Score < other.Score)
		{
			return -1;
		}
		return 1;
	}
}
