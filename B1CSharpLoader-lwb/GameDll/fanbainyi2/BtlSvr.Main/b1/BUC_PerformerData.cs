using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_PerformerData : IBUC_PerformerData
{
	public readonly int PauseAIBuffID = 901;

	public readonly int InvisibleBuffID = 902;

	public readonly int InvincibleBuffID = 903;

	public readonly int CannotSelectedBuffID = 904;

	public readonly int DisableCapsuleCollisionBuffID = 905;

	public readonly int DisableMeshCollisionForOtherBuffID = 906;

	public readonly int DisableMeshCollisionForWukongBuffID = 916;

	public readonly int DisableGravityBuffID = 907;

	public int DisableMeshCollisionBuffID
	{
		get
		{
			if (!bHasEquip)
			{
				return DisableMeshCollisionForOtherBuffID;
			}
			return DisableMeshCollisionForWukongBuffID;
		}
	}

	public bool bPerforming { get; set; }

	public bool bBowWhenAfterShow { get; set; }

	public bool bWaitingPerformer { get; set; }

	public bool bWaitingWhenReturnHome { get; set; }

	public bool bStandingWaiting { get; set; }

	public bool bUseSceneItemPosition { get; set; }

	public FName WaitingLocationItemTag { get; set; }

	public FVector WaitingLocation { get; set; }

	public FRotator WaitingRotation { get; set; }

	public TWeakObject<UAnimMontage> WaitingAnim { get; set; }

	public bool bPlayingWaitingAnim { get; set; }

	public PerformerStateConfigData WaitingStateConfigData { get; } = new PerformerStateConfigData();

	public PerformerStateConfigData PreShowStateConfigData { get; } = new PerformerStateConfigData();

	public PerformerStateConfigData ShowingStateConfigData { get; } = new PerformerStateConfigData();

	public PerformerStateConfigData CompletedStateConfigData { get; } = new PerformerStateConfigData();

	public PerformerStateConfigData ActualStateConfigData { get; } = new PerformerStateConfigData();

	public FVector CompletedLocation { get; set; }

	public FRotator CompletedRotation { get; set; }

	public Entity OwnerEntity { get; set; }

	public float TotalBowTime { get; set; }

	public float TargetBowTime { get; set; }

	public FVector TargetBowLocation { get; set; }

	public FVector OriginBowLocation { get; set; }

	public FVector? CurrentBowLocation { get; set; }

	public bool bFinishBow { get; set; }

	public uint HandleID { get; set; }

	public float CapsuleHalfHeight { get; set; }

	public float CapsuleRadius { get; set; }

	public FVector LastFrameBowLocation { get; set; }

	public bool bHasEquip { get; set; }
}
