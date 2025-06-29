using System.Collections.Generic;
using GUR.Runtime;
using UnrealEngine.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_TargetInfoData
{
	List<string> CachedLockSkeletonSocket { get; }

	HashSet<string> DisabledLockSkeletonSocket { get; }

	HashSet<string> DisabledAutoLockSceneComp { get; }

	List<UnitLockTargetInfo> GetMultiTargetInfoList();

	UnitLockTargetInfo GetTargetInfo();

	UnitLockTargetInfo GetSkillBaseTarget();

	UnitLockTargetInfo GetComboTarget();

	UnitLockTargetInfo GetAOTarget();

	UnitLockTargetInfo GetMoveToTarget();

	int GetTargetedCount();

	bool GetCanSetTarget();

	bool IsSupportMultiLockTarget();

	FVector GetLockPointPosition();
}
