using b1.EventDelDefine;
using UnrealEngine.Engine;

namespace b1;

public class BGS_SharedDataMgr : GameStateSystemBase
{
	private BGC_LocalPlayerSharedData LocalPlayerSharedData { get; set; }

	public override void OnAttach()
	{
		LocalPlayerSharedData = RequireWritableData<BGC_LocalPlayerSharedData>();
		base.BGSEventCollection.Evt_BGS_OnUnitTransited += new Del_BGS_OnUnitTransited(OnUnitTransited);
	}

	public override void OnBeginPlay()
	{
		InitLocalPlayerSharedData();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		base.BGSEventCollection.Evt_BGS_OnUnitTransited -= new Del_BGS_OnUnitTransited(OnUnitTransited);
	}

	private void InitLocalPlayerSharedData()
	{
		LocalPlayerSharedData.FirstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner.World);
		LocalPlayerSharedData.FirstLocalPlayerPawn = LocalPlayerSharedData.FirstLocalPlayerController?.GetControlledPawn();
		LocalPlayerSharedData.FirstLocalPlayerCamMgr = LocalPlayerSharedData.FirstLocalPlayerController?.PlayerCameraManager;
	}

	private void OnUnitTransited(AActor OldActor, AActor CurActor)
	{
		if (OldActor == LocalPlayerSharedData.FirstLocalPlayerPawn && CurActor is APawn firstLocalPlayerPawn)
		{
			LocalPlayerSharedData.FirstLocalPlayerPawn = firstLocalPlayerPawn;
		}
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		LocalPlayerSharedData.CachedLocalPlayerTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(LocalPlayerSharedData.FirstLocalPlayerPawn);
		LocalPlayerSharedData.CachedLocalPlayerLocation = LocalPlayerSharedData.CachedLocalPlayerTransform.GetLocation();
		LocalPlayerSharedData.CachedLocalPlayerRotation = LocalPlayerSharedData.CachedLocalPlayerTransform.GetRotation().Rotator();
		LocalPlayerSharedData.CachedLocalPlayerCameraRotation = LocalPlayerSharedData.FirstLocalPlayerCamMgr.GetCameraRotation();
	}
}
