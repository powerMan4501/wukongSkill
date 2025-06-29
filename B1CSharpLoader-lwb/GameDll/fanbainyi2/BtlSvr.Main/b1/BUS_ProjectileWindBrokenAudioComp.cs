using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_ProjectileWindBrokenAudioComp : UActorCompBaseCS
{
	private b1.IBPC_PlayerCameraData PlayerCameraData;

	private BUC_ProjectileWindBrokenAudioData WindBrokenAudioData;

	public override void OnAttach()
	{
		WindBrokenAudioData = RequireWritableData<BUC_ProjectileWindBrokenAudioData>();
		base.BUSEventCollection.Evt_OnProjectileDead += new Del_OnBulletDead(OnBulletDead);
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner);
		if (firstLocalPlayerController != null && firstLocalPlayerController.PlayerState != null)
		{
			PlayerCameraData = BGU_DataUtil.GetReadOnlyData<b1.IBPC_PlayerCameraData, BPC_PlayerCameraData>(firstLocalPlayerController.PlayerState);
		}
	}

	private void OnBulletDead(EBGUBulletDestroyReason DestroyReason)
	{
		WindBrokenAudioData.bAudioShutDown = true;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!WindBrokenAudioData.bAudioShutDown)
		{
			DistToLocalCamCheck();
		}
	}

	private void DistToLocalCamCheck()
	{
		if (PlayerCameraData != null && !WindBrokenAudioData.bAlreadyTriggered && FVector.Dist(BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), PlayerCameraData.CameraManagerWorldPos) <= WindBrokenAudioData.TriggerDist)
		{
			base.BUSEventCollection.Evt_PostAkEvent_Follow.Invoke(Owner.RootComponent, FName.None, WindBrokenAudioData.AkEvent);
			WindBrokenAudioData.bAlreadyTriggered = true;
			if (WindBrokenAudioData.bEnableDebug_WindBrokenAudio)
			{
				USystemLibrary.DrawDebugLine(Owner, Owner.GetActorLocation(), Owner.GetActorLocation() + Owner.GetActorForwardVector() * 1000.0, FLinearColor.Green, 3f, 2f);
				USystemLibrary.DrawDebugSphere(Owner, Owner.GetActorLocation(), 50f, 20, FLinearColor.Blue, 3f, 2f);
			}
		}
	}
}
