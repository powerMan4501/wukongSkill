using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FGSProjectileSpawnInfo
{
	public AActor Spawner;

	public EProjectileType ProjectileType;

	public int SkillID;

	public List<int> BuffIDList;

	public int ProjectileID;

	public int TotalNumInAWave;

	public int SelfIndexInAWave;

	public FSpawnBulletSpeed ProjectileFlySpd;

	public FSpawnBulletSpeed ProjectileRotSpd;

	public FSpawnBulletSpeedGroup BulletSpdGroup;

	public FVector SpawnPosition;

	public FRotator BornDir;

	public bool UseSocket_Spawn;

	public FName SpawnPointName;

	public bool UseSocket_Target;

	public FName TargetSocketNameFromNotify;

	public AActor CurTarget;

	public FGSTargetOffsetInfo TargetOffsetInfo;

	public FVector TargetPos;

	public AActor InnerSceneItem;

	public bool AttachToSpawnBase;

	public AActor AttachToSpawnBase_SpawnBaseActor;

	public FName AttachToSpawnBase_SocketName;

	public USceneComponent AttachToSpawnBase_SocketOwnerComp;

	public EAttachmentRule AttachRule_Rot;

	public AActor ModularActor;
}
