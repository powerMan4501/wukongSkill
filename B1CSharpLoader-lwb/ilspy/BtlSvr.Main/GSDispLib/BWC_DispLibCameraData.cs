using b1;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class BWC_DispLibCameraData : BUC_DispLibDataBase, IPersistentECSData
{
	public TStrongObjectPtr<AActor> CameraActor = new TStrongObjectPtr<AActor>();

	public FVector CurFrameCameraPosWS;

	public FVector LastFrameCameraPosWS;

	public FVector CurFrameCameraForwardDir;

	public FVector CameraMoveV3;

	public FVector CameraVelocity;

	public FVector CameraVelocityDirection;

	public FRotator CurFrameCameraRotation;

	public TStrongObjectPtr<UCameraComponent> CameraComp = new TStrongObjectPtr<UCameraComponent>();

	public TStrongObjectPtr<USceneCaptureComponent2D> SceneCaptureComp2D = new TStrongObjectPtr<USceneCaptureComponent2D>();

	public TStrongObjectPtr<APlayerCameraManager> PlayerCameraManager = new TStrongObjectPtr<APlayerCameraManager>();

	public TStrongObjectPtr<APlayerController> PlayerController = new TStrongObjectPtr<APlayerController>();

	internal void Init(UObject WorldContextObject)
	{
		PlayerCameraManager.Set(UGameplayStatics.GetPlayerCameraManager(WorldContextObject, 0));
		PlayerController.Set(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContextObject));
		if (PlayerController.IsValid())
		{
			BGUPlayerCharacterCS bGUPlayerCharacterCS = PlayerController.Get().GetViewTarget() as BGUPlayerCharacterCS;
			if (bGUPlayerCharacterCS != null)
			{
				CameraComp.Set(bGUPlayerCharacterCS.GetFollowCamera());
				CameraActor.Set(bGUPlayerCharacterCS);
			}
		}
	}

	internal void Reset()
	{
		CameraActor?.Delete();
		CameraComp?.Delete();
		SceneCaptureComp2D?.Delete();
		PlayerCameraManager?.Delete();
		PlayerController?.Delete();
		CurFrameCameraPosWS = default(FVector);
		LastFrameCameraPosWS = default(FVector);
		CurFrameCameraForwardDir = default(FVector);
		CameraMoveV3 = default(FVector);
		CameraVelocity = default(FVector);
		CameraVelocityDirection = default(FVector);
		CurFrameCameraRotation = default(FRotator);
	}
}
