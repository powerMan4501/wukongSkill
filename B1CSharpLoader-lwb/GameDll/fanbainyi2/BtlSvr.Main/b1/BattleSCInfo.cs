using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BattleSCInfo
{
	public List<AActor> MemberList { get; set; } = new List<AActor>();

	public Dictionary<FGameplayTag, FGameplayTag> BattleEventMap { get; set; } = new Dictionary<FGameplayTag, FGameplayTag>();
}
