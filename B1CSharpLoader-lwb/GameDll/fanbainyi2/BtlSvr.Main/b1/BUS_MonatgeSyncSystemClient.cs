using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_MonatgeSyncSystemClient : UActorCompBaseCS
{
	private BUC_MontageSyncData MontageSyncData;

	public override void OnAttach()
	{
		MontageSyncData = RequireWritableData<BUC_MontageSyncData>();
	}

	public override void OnBeginPlay()
	{
	}

	public override void LateBeginPlay()
	{
		PlaySynMontage();
	}

	private void PlaySynMontage()
	{
		if (MontageSyncData.IsPlayingMontage && (GetOwner() as BGUCharacterCS)?.Mesh != null)
		{
			UAnimMontage montage = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UAnimMontage>(MontageSyncData.MontagePath, ELoadResourceType.SyncLoadAndCache);
			BGUFuncLibAnim.BGUActorTryPlayMontage(GetOwner(), montage, FName.None, EMontageBindReason.Default, 1f, 1f, MontageSyncData.Position);
		}
	}
}
