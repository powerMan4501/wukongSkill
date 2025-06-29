using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_AnimationSyncGuestData : IBUC_AnimationSyncGuestData
{
	public AActor Killer;

	public AActor PendingCatchTarget;

	public bool bIsSummon;

	public int DeathStiffLevel;

	public int DeathDmgID;

	public FEffectInstReq DeathEffectInstReq;

	public bool bIsFakeDead;

	public AActor Host { get; set; }

	public UAnimMontage DeathMontage { get; set; }

	public EInteractSyncAnimationBowState InteractSyncAnimationBowState { get; set; }

	public FVector InteractSyncAnimationBowLocation { get; set; }
}
