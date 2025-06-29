using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class FNeedSpawnDropItem
{
	public int ItemResID;

	public TSubclassOf<BGUDropItemActor> DropItemActor;

	public FVector DefaultSpawnLocation;

	public FRotator DefaultSpawnRotator;

	public float DropDelay;

	public int OwnerResID;

	public AActor DropperActor;

	public FName SpawnPosSocket;

	public UEnvQuery EQSTemplate;

	public float EQSActivationDistance;

	public DropReason DropReason;
}
