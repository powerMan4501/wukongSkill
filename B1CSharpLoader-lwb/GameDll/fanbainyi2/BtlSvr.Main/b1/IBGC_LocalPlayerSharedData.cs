using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBGC_LocalPlayerSharedData
{
	APlayerController FirstLocalPlayerController { get; }

	APlayerCameraManager FirstLocalPlayerCamMgr { get; }

	APawn FirstLocalPlayerPawn { get; }

	FTransform CachedLocalPlayerTransform { get; }

	FVector CachedLocalPlayerLocation { get; }

	FRotator CachedLocalPlayerRotation { get; }

	FRotator CachedLocalPlayerCameraRotation { get; }
}
