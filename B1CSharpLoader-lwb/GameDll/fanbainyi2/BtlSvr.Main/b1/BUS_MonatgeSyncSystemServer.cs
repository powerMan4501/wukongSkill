using UnrealEngine.Engine;

namespace b1;

public class BUS_MonatgeSyncSystemServer : UActorCompBaseCS
{
	private BUC_MontageSyncData MontageSyncData;

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (MontageSyncData.SkeletalMesh != null && MontageSyncData.SkeletalMesh.GetAnimInstance() != null)
		{
			UAnimMontage currentActiveMontage = MontageSyncData.SkeletalMesh.GetAnimInstance().GetCurrentActiveMontage();
			if (currentActiveMontage != null)
			{
				MontageSyncData.MontagePath = currentActiveMontage.GetPathName().ToString();
				MontageSyncData.Position = MontageSyncData.SkeletalMesh.GetAnimInstance().Montage_GetPosition(currentActiveMontage);
			}
			MontageSyncData.IsPlayingMontage = currentActiveMontage != null;
		}
	}

	public override void OnBeginPlay()
	{
		MontageSyncData.SkeletalMesh = (GetOwner() as BGUCharacterCS)?.Mesh;
	}

	public override void OnAttach()
	{
		MontageSyncData = RequireWritableData<BUC_MontageSyncData>();
	}
}
