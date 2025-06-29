using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.LightWeightInstanceStaticMeshManager", "Engine", UnrealModuleType.Engine)]
public class ALightWeightInstanceStaticMeshManager : ALightWeightInstanceManager, ISMInstanceManager, IInterface
{
	private static bool StaticMesh_IsValid;

	private static int StaticMesh_Offset;

	private static bool InstancedStaticMeshComponent_IsValid;

	private static int InstancedStaticMeshComponent_Offset;

	[UProperty(Flags = (PropFlags)12393699363260469uL)]
	[UMetaPath("/Script/Engine.LightWeightInstanceStaticMeshManager:StaticMesh")]
	protected TSoftObject<UStaticMesh> StaticMesh
	{
		get
		{
			CheckDestroyed();
			if (!StaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightWeightInstanceStaticMeshManager:StaticMesh");
				return default(TSoftObject<UStaticMesh>);
			}
			return TSoftObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(base.Address, StaticMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaticMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightWeightInstanceStaticMeshManager:StaticMesh");
			}
			else
			{
				TSoftObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(base.Address, StaticMesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12398162908545565uL)]
	[UMetaPath("/Script/Engine.LightWeightInstanceStaticMeshManager:InstancedStaticMeshComponent")]
	protected UHierarchicalInstancedStaticMeshComponent InstancedStaticMeshComponent
	{
		get
		{
			CheckDestroyed();
			if (!InstancedStaticMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightWeightInstanceStaticMeshManager:InstancedStaticMeshComponent");
				return null;
			}
			return UObjectMarshaler<UHierarchicalInstancedStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, InstancedStaticMeshComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InstancedStaticMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightWeightInstanceStaticMeshManager:InstancedStaticMeshComponent");
			}
			else
			{
				UObjectMarshaler<UHierarchicalInstancedStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, InstancedStaticMeshComponent_Offset), value);
			}
		}
	}

	static ALightWeightInstanceStaticMeshManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ALightWeightInstanceStaticMeshManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ALightWeightInstanceStaticMeshManager));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.LightWeightInstanceStaticMeshManager");
		StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StaticMesh");
		StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StaticMesh", Classes.FSoftObjectProperty);
		InstancedStaticMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InstancedStaticMeshComponent");
		InstancedStaticMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InstancedStaticMeshComponent", Classes.FObjectProperty);
	}
}
