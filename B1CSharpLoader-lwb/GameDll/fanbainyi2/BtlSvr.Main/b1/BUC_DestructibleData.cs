using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.ApexDestruction;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_DestructibleData : b1.IBUC_DestructibleData, IPersistentECSData
{
	public bool IsActive { get; set; }

	public float Mass { get; set; }

	public float DestroyedLifeTime { get; set; }

	public DestructibleStrengthLevel StrengthLevel { get; set; }

	public bool IsDestroyed
	{
		get
		{
			if (DestructibleState != EDestructibleState.Destroyed)
			{
				return DestructibleState == EDestructibleState.Destroying;
			}
			return true;
		}
	}

	public bool IsDestroyFinished => DestructibleState == EDestructibleState.Destroyed;

	public float DissipationTimeLeft { get; set; }

	public float DebrisDissipationTime { get; set; }

	public List<EGSHitDestructibleStrengthLevel> CanParryStrengthLevel { get; set; }

	public UAkAudioEvent DestructibleParryEvent { get; set; }

	public UBGWDataAsset DestructibleParryDispConfig { get; set; }

	public FEffectInstReq DestructibleParryEffectInstReq { get; set; }

	public int DestructionDropInfoID { get; set; }

	public bool CanBeHitByBullet { get; set; }

	public bool IsApplyDamage { get; set; }

	public FVector DamageHitLocation { get; set; }

	public FVector DamageImpulseDir { get; set; }

	public float DamageImpulseStrength { get; set; }

	public EDestructibleState DestructibleState { get; set; }

	public Dictionary<UPrimitiveComponent, FName> DestructibleCollisions { get; set; }

	public Dictionary<UDestructibleComponent, TStrongObjectPtr<UDestructibleMesh>> DestructibleCompInfos { get; set; }

	public List<b1.DestructiblePhysicsCompInfo> PhysicsCompInfos { get; set; }

	public List<UMeshComponent> CPD_AlphaComps { get; set; }

	public List<AActor> DestroyRelativeActors { get; set; }

	public BUC_DestructibleData()
	{
		IsActive = true;
		CanBeHitByBullet = false;
		DestructibleState = EDestructibleState.Default;
		DestructibleCollisions = new Dictionary<UPrimitiveComponent, FName>();
		DestructibleCompInfos = new Dictionary<UDestructibleComponent, TStrongObjectPtr<UDestructibleMesh>>();
		PhysicsCompInfos = new List<b1.DestructiblePhysicsCompInfo>();
		CPD_AlphaComps = new List<UMeshComponent>();
		DestroyRelativeActors = new List<AActor>();
	}
}
