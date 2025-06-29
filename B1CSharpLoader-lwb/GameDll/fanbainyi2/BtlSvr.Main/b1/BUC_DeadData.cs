using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_DeadData : IBUC_DeadData
{
	private int DeadInfoID;

	private TStrongObjectPtr<AActor> mAttacker = new TStrongObjectPtr<AActor>();

	public FDeadAMWaitingBeAttackedAMInfo DeadAMWaitingBeAttackedAMInfo;

	private TStrongObjectPtr<UCurveFloat> mThrowUpCurve = new TStrongObjectPtr<UCurveFloat>();

	public bool bWithinOceanSea;

	public bool bInteractCricketLoop;

	public AActor Attacker
	{
		get
		{
			return mAttacker.Get();
		}
		set
		{
			mAttacker.Set(value);
		}
	}

	public float ThrowUpMaxTime { get; set; }

	public float ThrowUpTimer { get; set; }

	public UCurveFloat ThrowUpCurve
	{
		get
		{
			return mThrowUpCurve.Get();
		}
		set
		{
			mThrowUpCurve.Set(value);
		}
	}

	public uint MovementModeHandleID { get; set; }

	public uint CollisionEnabledHandleID { get; set; }

	public bool InDeadAM { get; set; }

	public float AutoSwitchPhysicTimer { get; set; }

	public bool AlreadySwitchPhysic { get; set; }

	public float WaitSwitchPhysicTime { get; set; }

	public FEffectInstReq Cached_EffectInstReq { get; set; }

	public int Cached_StiffLevel { get; set; }

	public float Cached_PhysAnimImpulseScale { get; set; }

	public bool HasBlendPhysicNotifyState { get; set; }

	public float DissolveDisplayTimer { get; set; } = -1f;

	public int GetDeadInfoID()
	{
		return DeadInfoID;
	}

	public void SetDeadInfoID(int DeadID)
	{
		DeadInfoID = DeadID;
	}

	public FDeadAMWaitingBeAttackedAMInfo Get_DeadAMWaitingBeAttackedAMInfo()
	{
		return DeadAMWaitingBeAttackedAMInfo;
	}

	public BUC_DeadData()
	{
		DeadAMWaitingBeAttackedAMInfo = default(FDeadAMWaitingBeAttackedAMInfo);
	}
}
