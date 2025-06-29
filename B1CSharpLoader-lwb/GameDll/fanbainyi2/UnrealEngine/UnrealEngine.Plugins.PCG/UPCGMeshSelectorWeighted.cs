using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMeshSelectorWeighted", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGMeshSelectorWeighted : UPCGMeshSelectorBase
{
	private static bool MeshEntries_IsValid;

	private static FFieldAddress MeshEntries_PropertyAddress;

	private static int MeshEntries_Offset;

	private TArrayReadWriteMarshaler<FPCGMeshSelectorWeightedEntry> MeshEntries_MarshalerCached;

	private static bool UseAttributeMaterialOverrides_IsValid;

	private static FFieldAddress UseAttributeMaterialOverrides_PropertyAddress;

	private static int UseAttributeMaterialOverrides_Offset;

	private static bool MaterialOverrideAttributes_IsValid;

	private static FFieldAddress MaterialOverrideAttributes_PropertyAddress;

	private static int MaterialOverrideAttributes_Offset;

	private TArrayReadWriteMarshaler<FName> MaterialOverrideAttributes_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGMeshSelectorWeighted:MeshEntries")]
	public TArrayReadWrite<FPCGMeshSelectorWeightedEntry> MeshEntries
	{
		get
		{
			CheckDestroyed();
			if (!MeshEntries_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMeshSelectorWeighted:MeshEntries");
				return null;
			}
			if (MeshEntries_MarshalerCached == null)
			{
				MeshEntries_MarshalerCached = new TArrayReadWriteMarshaler<FPCGMeshSelectorWeightedEntry>(1, MeshEntries_PropertyAddress, CachedMarshalingDelegates<FPCGMeshSelectorWeightedEntry, FPCGMeshSelectorWeightedEntry>.FromNative, CachedMarshalingDelegates<FPCGMeshSelectorWeightedEntry, FPCGMeshSelectorWeightedEntry>.ToNative);
			}
			return MeshEntries_MarshalerCached.FromNative(IntPtr.Add(base.Address, MeshEntries_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMeshSelectorWeighted:bUseAttributeMaterialOverrides")]
	public bool UseAttributeMaterialOverrides
	{
		get
		{
			CheckDestroyed();
			if (!UseAttributeMaterialOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMeshSelectorWeighted:bUseAttributeMaterialOverrides");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseAttributeMaterialOverrides_Offset), 0, UseAttributeMaterialOverrides_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseAttributeMaterialOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMeshSelectorWeighted:bUseAttributeMaterialOverrides");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseAttributeMaterialOverrides_Offset), 0, UseAttributeMaterialOverrides_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGMeshSelectorWeighted:MaterialOverrideAttributes")]
	public TArrayReadWrite<FName> MaterialOverrideAttributes
	{
		get
		{
			CheckDestroyed();
			if (!MaterialOverrideAttributes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMeshSelectorWeighted:MaterialOverrideAttributes");
				return null;
			}
			if (MaterialOverrideAttributes_MarshalerCached == null)
			{
				MaterialOverrideAttributes_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, MaterialOverrideAttributes_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return MaterialOverrideAttributes_MarshalerCached.FromNative(IntPtr.Add(base.Address, MaterialOverrideAttributes_Offset));
		}
	}

	static UPCGMeshSelectorWeighted()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGMeshSelectorWeighted)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGMeshSelectorWeighted));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGMeshSelectorWeighted");
		NativeReflectionCached.GetPropertyRef(ref MeshEntries_PropertyAddress, unrealStruct, "MeshEntries");
		MeshEntries_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MeshEntries");
		MeshEntries_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MeshEntries", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UseAttributeMaterialOverrides_PropertyAddress, unrealStruct, "bUseAttributeMaterialOverrides");
		UseAttributeMaterialOverrides_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseAttributeMaterialOverrides");
		UseAttributeMaterialOverrides_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseAttributeMaterialOverrides", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MaterialOverrideAttributes_PropertyAddress, unrealStruct, "MaterialOverrideAttributes");
		MaterialOverrideAttributes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaterialOverrideAttributes");
		MaterialOverrideAttributes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaterialOverrideAttributes", Classes.FArrayProperty);
	}
}
