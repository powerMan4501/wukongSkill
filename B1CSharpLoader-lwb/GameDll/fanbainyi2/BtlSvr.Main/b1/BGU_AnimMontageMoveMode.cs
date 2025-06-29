using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_AnimMontageMoveMode : BUC_MoveModeWithRotateBase
{
	private UAnimMontage CachedMontage;

	public void BeginMove(UAnimMontage Montage, float PlayTimeRate, float MontagePosOffset, FName StartSectionName, EMontageBindReason Reason = EMontageBindReason.Default)
	{
		USkeletalMeshComponent uSkeletalMeshComponent = OwnerCharacter?.Mesh;
		if (uSkeletalMeshComponent != null && uSkeletalMeshComponent.GetAnimInstance() != null)
		{
			CachedMontage = Montage;
			BGS_GSEventCollection.Get(OwnerCharacter).Evt_BGS_CreateBGUPlayMontageCallbackProxy.Invoke(Reason, uSkeletalMeshComponent, Montage, PlayTimeRate, MontagePosOffset, StartSectionName);
		}
		else
		{
			StopMove();
		}
	}

	public void OnMontageBlendingOut(UAnimMontage Montage)
	{
		if (!(CachedMontage != Montage) && IsActive())
		{
			StopMove();
		}
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.AnimationMontage;
	}

	protected override void OnUpdate(float DeltaTime)
	{
		base.OnUpdate(DeltaTime);
	}

	protected override void OnEnd()
	{
		base.OnEnd();
		ResetAllStatus();
		CachedMontage = null;
	}

	public override bool CanOptimizeMoverTick()
	{
		if (OwnerCharacter.IsPlayingRootMotion())
		{
			return false;
		}
		return true;
	}
}
