using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Foliage;

[UClass(Flags = (ClassFlags)810029216uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Foliage.FoliageType_InstancedStaticMesh", "Foliage", UnrealModuleType.Engine)]
public class UFoliageType_InstancedStaticMesh : UFoliageType
{
	private static bool Mesh_IsValid;

	private static int Mesh_Offset;

	private static bool OverrideMaterials_IsValid;

	private static FFieldAddress OverrideMaterials_PropertyAddress;

	private static int OverrideMaterials_Offset;

	private TArrayReadWriteMarshaler<UMaterialInterface> OverrideMaterials_MarshalerCached;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Foliage.FoliageType_InstancedStaticMesh:Mesh")]
	public UStaticMesh Mesh
	{
		get
		{
			CheckDestroyed();
			if (!Mesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType_InstancedStaticMesh:Mesh");
				return null;
			}
			return UObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(base.Address, Mesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Mesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType_InstancedStaticMesh:Mesh");
			}
			else
			{
				UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(base.Address, Mesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5633897580724741uL)]
	[UMetaPath("/Script/Foliage.FoliageType_InstancedStaticMesh:OverrideMaterials")]
	public TArrayReadWrite<UMaterialInterface> OverrideMaterials
	{
		get
		{
			CheckDestroyed();
			if (!OverrideMaterials_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.FoliageType_InstancedStaticMesh:OverrideMaterials");
				return null;
			}
			if (OverrideMaterials_MarshalerCached == null)
			{
				OverrideMaterials_MarshalerCached = new TArrayReadWriteMarshaler<UMaterialInterface>(1, OverrideMaterials_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative);
			}
			return OverrideMaterials_MarshalerCached.FromNative(IntPtr.Add(base.Address, OverrideMaterials_Offset));
		}
	}

	static UFoliageType_InstancedStaticMesh()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFoliageType_InstancedStaticMesh)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFoliageType_InstancedStaticMesh));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Foliage.FoliageType_InstancedStaticMesh");
		Mesh_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Mesh");
		Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Mesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideMaterials_PropertyAddress, unrealStruct, "OverrideMaterials");
		OverrideMaterials_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OverrideMaterials");
		OverrideMaterials_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OverrideMaterials", Classes.FArrayProperty);
	}
}
