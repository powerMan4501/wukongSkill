using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUGhostActorBase")]
public class BGUGhostActorBase : BGUActorBaseCS
{
	private static bool PoseableMeshComp_IsValid;

	private static int PoseableMeshComp_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUGhostActorBase:PoseableMeshComp")]
	public UPoseableMeshComponent PoseableMeshComp
	{
		get
		{
			CheckDestroyed();
			if (!PoseableMeshComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUGhostActorBase:PoseableMeshComp");
				return null;
			}
			return UObjectMarshaler<UPoseableMeshComponent>.FromNative(IntPtr.Add(base.Address, PoseableMeshComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PoseableMeshComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUGhostActorBase:PoseableMeshComp");
			}
			else
			{
				UObjectMarshaler<UPoseableMeshComponent>.ToNative(IntPtr.Add(base.Address, PoseableMeshComp_Offset), value);
			}
		}
	}

	public List<TWeakObject<UMeshComponent>> MeshCompPtrList { get; } = new List<TWeakObject<UMeshComponent>>();

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		PoseableMeshComp = initializer.CreateDefaultSubobject<UPoseableMeshComponent>(this, B1GlobalFNames.PoseableMeshComp);
		SetRootComponentCS(PoseableMeshComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_GhostPoseableComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_CustomDepthStencilComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_GhostActorDataComp>(this, B1GlobalFNames.GhostActorDataComp);
	}

	public void RefreshMeshComponentList()
	{
		MeshCompPtrList.Clear();
		foreach (UActorComponent item in GetComponentsByClass(UClass.GetClass(typeof(UMeshComponent))))
		{
			if (item is UMeshComponent obj)
			{
				MeshCompPtrList.Add(new TWeakObject<UMeshComponent>(obj));
			}
		}
	}

	public void SetPoseableMeshParamValueOnMat(FName ParamName, float Value)
	{
		foreach (TWeakObject<UMeshComponent> meshCompPtr in MeshCompPtrList)
		{
			if (meshCompPtr.IsValid())
			{
				meshCompPtr.Get().SetScalarParameterValueOnMaterials(ParamName, Value);
			}
		}
	}

	public void CopyMesh(USkeletalMesh NewMesh)
	{
		PoseableMeshComp.SetSkeletalMesh(NewMesh);
	}

	public void CopyPose(USkeletalMeshComponent InComponentToCopy)
	{
		PoseableMeshComp.CopyPoseFromSkeletalComponent(InComponentToCopy);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUGhostActorBase");
		PoseableMeshComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PoseableMeshComp");
		PoseableMeshComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PoseableMeshComp", Classes.FObjectProperty);
	}

	static BGUGhostActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUGhostActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUGhostActorBase));
	}
}
