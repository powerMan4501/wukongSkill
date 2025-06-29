using System.Collections.Generic;
using b1.Plugins.TressFX;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class MagicallyChangeDefaultConfig
{
	public float CapsuleHalfHeight;

	public float CapsuleRadius;

	public float HitMoveCollisionHalfHeight;

	public float HitMoveCollisionRadius;

	public FVector UnitScale;

	public TStrongObjectPtr<USkeletalMesh> SKMesh = new TStrongObjectPtr<USkeletalMesh>();

	public TSubclassOf<UAnimInstance> ABPClass;

	public List<MagicallyChangeTFXConfig> TFXConfig = new List<MagicallyChangeTFXConfig>();

	public MagicallyChangeDefaultMeshProperty MeshProperty;

	public void Init(ACharacter Character, UCapsuleComponent HitMoveCollision, List<TStrongObjectPtr<UTressFXComponent>> TFXComponents)
	{
		if (Character == null)
		{
			return;
		}
		UnitScale = Character.GetActorScale3D();
		UCapsuleComponent capsuleComponent = Character.CapsuleComponent;
		CapsuleHalfHeight = capsuleComponent.GetUnscaledCapsuleHalfHeight();
		CapsuleRadius = capsuleComponent.GetUnscaledCapsuleRadius();
		USkeletalMeshComponent mesh = Character.Mesh;
		if (mesh != null)
		{
			SKMesh.Set(mesh.SkeletalMesh);
			ABPClass = mesh.AnimClass;
			MeshProperty = new MagicallyChangeDefaultMeshProperty();
			MeshProperty.CastShadow = mesh.CastShadow;
			MeshProperty.VisibleInRayTracing = mesh.VisibleInRayTracing;
			MeshProperty.RenderInMainPass = mesh.RenderInMainPass;
			MeshProperty.RenderInDepthPass = mesh.RenderInDepthPass;
		}
		if (HitMoveCollision != null)
		{
			HitMoveCollisionHalfHeight = HitMoveCollision.GetUnscaledCapsuleHalfHeight();
			HitMoveCollisionRadius = HitMoveCollision.GetUnscaledCapsuleRadius();
		}
		if (TFXComponents == null)
		{
			return;
		}
		foreach (TStrongObjectPtr<UTressFXComponent> TFXComponent in TFXComponents)
		{
			UTressFXComponent uTressFXComponent = TFXComponent.Get();
			MagicallyChangeTFXConfig magicallyChangeTFXConfig = new MagicallyChangeTFXConfig();
			magicallyChangeTFXConfig.TFXAsset.Set(uTressFXComponent.Asset);
			magicallyChangeTFXConfig.HairMaterial.Set(uTressFXComponent.HairMaterial);
			magicallyChangeTFXConfig.ShadeSettings = uTressFXComponent.ShadeSettings;
			magicallyChangeTFXConfig.LodScreenSize = uTressFXComponent.LodScreenSize;
			magicallyChangeTFXConfig.bEnableSimulation = uTressFXComponent.EnableSimulation;
			TFXConfig.Add(magicallyChangeTFXConfig);
		}
	}
}
