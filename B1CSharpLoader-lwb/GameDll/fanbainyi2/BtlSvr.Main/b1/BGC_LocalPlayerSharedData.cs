using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_LocalPlayerSharedData : IBGC_LocalPlayerSharedData, IPersistentECSData
{
	public APlayerController FirstLocalPlayerController { get; set; }

	public APlayerCameraManager FirstLocalPlayerCamMgr { get; set; }

	public APawn FirstLocalPlayerPawn { get; set; }

	public FTransform CachedLocalPlayerTransform { get; set; }

	public FVector CachedLocalPlayerLocation { get; set; }

	public FRotator CachedLocalPlayerRotation { get; set; }

	public FRotator CachedLocalPlayerCameraRotation { get; set; }
}
