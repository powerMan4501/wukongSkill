using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class AIData_Memory
{
	public float LastAttackTime;

	public float LastBeHitTime;

	public Entity LastAttackerEntity;

	public Entity LastTargetEntity;

	public FVector SpawnPosition;

	public FTransform MyPosWhenEnterBattle;

	public FTransform TargetPosCache;

	public float LastAtkDmgTime;

	public List<int> GroupAISkillList;

	public float ObstacleCheckScore { get; set; }

	public FVector EscapeLocation { get; set; }

	public EEscapeWay EscapeWay { get; set; }

	public void Init(FTransform SpawnPosition)
	{
		LastBeHitTime = 0f;
		LastAttackTime = 0f;
		LastAttackerEntity = Entity.Null;
		LastTargetEntity = Entity.Null;
		this.SpawnPosition = SpawnPosition.GetLocation();
		MyPosWhenEnterBattle = SpawnPosition;
		TargetPosCache = SpawnPosition;
		LastAtkDmgTime = 0f;
		GroupAISkillList = new List<int>();
		ObstacleCheckScore = 0f;
	}
}
