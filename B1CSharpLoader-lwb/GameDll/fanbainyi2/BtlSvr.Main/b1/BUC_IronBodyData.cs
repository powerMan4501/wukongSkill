using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public class BUC_IronBodyData : IPersistentECSData
{
	public AActor Attacker;

	public bool IsInPrecise { get; set; }

	public float CurrentTime { get; set; }

	public float BeginPreciseWindowTime { get; set; }

	public float EndPreciseWindowTime { get; set; }

	public int ResId { get; set; }

	public bool IsUpdataTime { get; set; }

	public int EndSkillID { get; set; }

	public bool IsDefeat { get; set; }
}
