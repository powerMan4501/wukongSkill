using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPS_ListenerMgrSystem : PlayerControllerSystemBase
{
	private BPC_ListenerMgrData ListenerMgrData;

	private AActor DistanceProbeActor_ForDebug;

	public override void OnAttach()
	{
		ListenerMgrData = RequireWritableLocalPlayerControlData<BPC_ListenerMgrData>();
		BPS_GSEventCollection bPS_GSEventCollection = BPS_EventCollectionCS.Get(base.PlayerController);
		if (bPS_GSEventCollection != null)
		{
			bPS_GSEventCollection.Evt_ViewTargetBlendComplete += new Del_Void(OnViewTargetBlendComplete);
		}
	}

	public override void OnBeginPlay()
	{
		ACharacter aCharacter = base.PlayerController.GetControlledPawn() as ACharacter;
		if (!aCharacter.IsNullOrDestroyed())
		{
			UAkGameplayStatics.SetDistanceProbe(base.PlayerController.PlayerCameraManager, aCharacter);
			ListenerMgrData.ListenerActor = base.PlayerController.PlayerCameraManager;
			DistanceProbeActor_ForDebug = aCharacter;
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateListenerPos();
	}

	private void OnViewTargetBlendComplete()
	{
		if (base.PlayerController.IsNullOrDestroyed())
		{
			return;
		}
		ACharacter aCharacter = base.PlayerController.GetControlledPawn() as ACharacter;
		if (!aCharacter.IsNullOrDestroyed())
		{
			AActor viewTarget = base.PlayerController.GetViewTarget();
			if (!viewTarget.IsNullOrDestroyed() && BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PlayerCameraData>(aCharacter) != null)
			{
				UAkGameplayStatics.SetDistanceProbe(base.PlayerController.PlayerCameraManager, viewTarget);
				ListenerMgrData.ListenerActor = base.PlayerController.PlayerCameraManager;
				DistanceProbeActor_ForDebug = viewTarget;
			}
		}
	}

	private void UpdateListenerPos()
	{
		if (!ListenerMgrData.ListenerActor.IsNullOrDestroyed())
		{
			ListenerMgrData.ListenerPos = ListenerMgrData.ListenerActor.GetActorLocation();
		}
	}

	private void DrawDebugDistanceProbe(float DeltaTime)
	{
		if (!DistanceProbeActor_ForDebug.IsNullOrDestroyed() && !base.PlayerController.IsNullOrDestroyed() && !(base.PlayerController.GetControlledPawn() as ACharacter).IsNullOrDestroyed())
		{
			AActor viewTarget = base.PlayerController.GetViewTarget();
			if (!viewTarget.IsNullOrDestroyed())
			{
				USystemLibrary.DrawDebugSphere(DistanceProbeActor_ForDebug, viewTarget.GetActorLocation(), 35f, 10, FLinearColor.Green, 0f, 1f);
				USystemLibrary.DrawDebugSphere(DistanceProbeActor_ForDebug, DistanceProbeActor_ForDebug.GetActorLocation(), 50f, 10, FLinearColor.Red, 0f, 1f);
			}
		}
	}
}
