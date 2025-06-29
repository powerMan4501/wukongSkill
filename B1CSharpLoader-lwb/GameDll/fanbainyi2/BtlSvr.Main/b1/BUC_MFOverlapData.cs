using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_MFOverlapData : IBUC_MFOverlapData, IPersistentECSData
{
	private EMFOverlapPhase mPhase;

	public float UpdateOverlapInterval;

	public float UpdateOverlapIntervalRemainTime;

	public EMagicFieldOverlapType OverlapType { get; set; }

	public EMFOverlapPhase Phase => mPhase;

	public bool bNeedAvoid { get; set; }

	public Dictionary<AActor, IBUC_MFOverlapData> AvoidanceOverlapDataMap { get; } = new Dictionary<AActor, IBUC_MFOverlapData>();

	public bool bUseSoftEdge { get; set; }

	public List<FFieldBuffInfo> FieldBuffList { get; } = new List<FFieldBuffInfo>();

	public List<MFEventForData> EnterEvents { get; } = new List<MFEventForData>();

	public List<MFEventForData> ExitEvents { get; } = new List<MFEventForData>();

	public bool bCanTriggerBornEffect { get; set; }

	public float MagicFieldAge { get; set; }

	public float BornEffectDelayTime { get; set; }

	public float BornAttackWarningStartTime { get; set; }

	public bool bAttackWarningTriggerPreciseDodge { get; set; }

	public bool bPreciseDodgeFilterTeammate { get; set; }

	public List<MFEventForData> BirthEvents { get; } = new List<MFEventForData>();

	public List<MFEventForData> DieEvents { get; } = new List<MFEventForData>();

	public List<AbnormalStateAccConfig> AbnormalStateAccEffectList { get; } = new List<AbnormalStateAccConfig>();

	private TStrongObjectPtr<UPrimitiveComponent> mOverlapComp { get; } = new TStrongObjectPtr<UPrimitiveComponent>();

	private TStrongObjectPtr<UPrimitiveComponent> mSoftEdgeOverlapComp { get; } = new TStrongObjectPtr<UPrimitiveComponent>();

	public EGSHitDestructibleStrengthLevel HitDestructibleStrengthLevel { get; set; }

	public EGSHitDestructibleDirection HitDestructibleDirectionType { get; set; }

	public List<int> HitDestructibleEffectsTriggerForSelf { get; } = new List<int>();

	public UPrimitiveComponent OverlapComp
	{
		get
		{
			return mOverlapComp.Get();
		}
		set
		{
			mOverlapComp.Set(value);
		}
	}

	public UPrimitiveComponent SoftEdgeOverlapComp
	{
		get
		{
			return mSoftEdgeOverlapComp.Get();
		}
		set
		{
			mSoftEdgeOverlapComp.Set(value);
		}
	}

	public List<AActor> AttackWarnedActors { get; } = new List<AActor>();

	public HashSet<AActor> InnerActorList_AlreadyTriggerOverlapBegin { get; set; } = new HashSet<AActor>();

	public bool SetPhase(EMFOverlapPhase NewPhase)
	{
		if (mPhase != NewPhase)
		{
			mPhase = NewPhase;
			return true;
		}
		return false;
	}

	public List<MFEventForData> GetEnterEvents()
	{
		return EnterEvents;
	}

	public List<MFEventForData> GetExitEvents()
	{
		return ExitEvents;
	}

	public bool IsActorInnerRange(AActor InActor)
	{
		if (InnerActorList_AlreadyTriggerOverlapBegin.Contains(InActor))
		{
			return true;
		}
		return false;
	}
}
