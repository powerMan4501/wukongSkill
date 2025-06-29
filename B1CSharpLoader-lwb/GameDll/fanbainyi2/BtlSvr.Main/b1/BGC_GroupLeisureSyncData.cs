using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_GroupLeisureSyncData
{
	public Dictionary<FGameplayTag, AActor> GroupLeisureSyncLeaderDic = new Dictionary<FGameplayTag, AActor>();

	public Dictionary<FGameplayTag, HashSet<AActor>> GroupLeisureSyncMemberDic = new Dictionary<FGameplayTag, HashSet<AActor>>();

	public Dictionary<FGameplayTag, UAnimMontage> GroupLeisureSyncMontageDic = new Dictionary<FGameplayTag, UAnimMontage>();
}
