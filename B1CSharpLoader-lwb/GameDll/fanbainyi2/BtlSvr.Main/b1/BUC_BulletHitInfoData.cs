using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public class BUC_BulletHitInfoData : IPersistentECSData, b1.IBUC_BulletHitInfoData
{
	public Dictionary<BGUCharacterCS, int> UnitBeHittedCountDic { get; set; }

	public BGUCharacterCS LastHitUnit { get; set; }

	public AActor GetLastHitUnit()
	{
		return LastHitUnit;
	}
}
