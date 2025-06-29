using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_FollowPartnerData : IBUC_FollowPartnerData, IPersistentECSData
{
	private TStrongObjectPtr<UAnimMontage> mCurrentIdleDispMontage = new TStrongObjectPtr<UAnimMontage>();

	public float LastPlayerCostDmgTime;

	public bool IsFollowPartnerUnit { get; set; }

	public bool IsAssociationUnit { get; set; }

	public bool CanTriggerIdleDodge { get; set; }

	public bool CanTriggerIdleWaiting { get; set; }

	public bool IsInDodgeMontage { get; set; }

	public bool IsInWaitingMontage { get; set; }

	public float IdleDodgeTimer { get; set; }

	public float IdleWaitingTimer { get; set; }

	public FFollowPartnerDodgeInfo IdleDodgeInfo { get; set; }

	public FFollowPartnerIdleWaitingInfo IdleWaitingInfo { get; set; }

	public float PlayerBattleLeisureTime { get; set; }

	public UAnimMontage CurrentIdleDispMontage
	{
		get
		{
			return mCurrentIdleDispMontage.Get();
		}
		set
		{
			mCurrentIdleDispMontage.Set(value);
		}
	}

	public bool CanTickIdleDisp()
	{
		if (!CanTriggerIdleDodge)
		{
			return CanTriggerIdleWaiting;
		}
		return true;
	}
}
