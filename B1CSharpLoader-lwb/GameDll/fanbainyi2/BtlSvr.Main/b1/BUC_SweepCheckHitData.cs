using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_SweepCheckHitData
{
	private TStrongObjectPtr<BGWDataAsset_SweepCheckDebugCollisionInfoConfig> mSCDCollisionInfoConfig = new TStrongObjectPtr<BGWDataAsset_SweepCheckDebugCollisionInfoConfig>();

	public bool bShowSweepCheckShape;

	public BGWDataAsset_SweepCheckDebugCollisionInfoConfig SCDCollisionInfoConfig
	{
		get
		{
			return mSCDCollisionInfoConfig.Get();
		}
		set
		{
			mSCDCollisionInfoConfig.Set(value);
		}
	}

	public List<FSweepCheckCombineInfo> CombineSweepCheck { get; set; }

	public Dictionary<string, FSweepCheckUnitConfig> SweepCheckConfigMap { get; set; }

	public Dictionary<string, AttackWarningUnitConfig> AttackWarningConfigMap { get; set; }

	public List<AActor> CanTriggerPreciseDodgeActors { get; } = new List<AActor>();

	public List<AActor> HitPreciseDodgeActors { get; } = new List<AActor>();

	public Dictionary<int, List<AActor>> SweepCheckGroupIgnoreActors { get; set; }

	public BUC_SweepCheckHitData()
	{
		SweepCheckConfigMap = new Dictionary<string, FSweepCheckUnitConfig>();
		AttackWarningConfigMap = new Dictionary<string, AttackWarningUnitConfig>();
		SweepCheckGroupIgnoreActors = new Dictionary<int, List<AActor>>();
		CombineSweepCheck = new List<FSweepCheckCombineInfo>();
	}
}
