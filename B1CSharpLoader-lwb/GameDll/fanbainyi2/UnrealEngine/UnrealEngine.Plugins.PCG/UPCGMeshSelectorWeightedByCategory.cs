using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMeshSelectorWeightedByCategory", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGMeshSelectorWeightedByCategory : UPCGMeshSelectorBase
{
	private static bool CategoryAttribute_IsValid;

	private static int CategoryAttribute_Offset;

	private static bool Entries_IsValid;

	private static FFieldAddress Entries_PropertyAddress;

	private static int Entries_Offset;

	private TArrayReadWriteMarshaler<FPCGWeightedByCategoryEntryList> Entries_MarshalerCached;

	private static bool UseAttributeMaterialOverrides_IsValid;

	private static FFieldAddress UseAttributeMaterialOverrides_PropertyAddress;

	private static int UseAttributeMaterialOverrides_Offset;

	private static bool MaterialOverrideAttributes_IsValid;

	private static FFieldAddress MaterialOverrideAttributes_PropertyAddress;

	private static int MaterialOverrideAttributes_Offset;

	private TArrayReadWriteMarshaler<FName> MaterialOverrideAttributes_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMeshSelectorWeightedByCategory:CategoryAttribute")]
	public FName CategoryAttribute
	{
		get
		{
			CheckDestroyed();
			if (!CategoryAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMeshSelectorWeightedByCategory:CategoryAttribute");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CategoryAttribute_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CategoryAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMeshSelectorWeightedByCategory:CategoryAttribute");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CategoryAttribute_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGMeshSelectorWeightedByCategory:Entries")]
	public TArrayReadWrite<FPCGWeightedByCategoryEntryList> Entries
	{
		get
		{
			CheckDestroyed();
			if (!Entries_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMeshSelectorWeightedByCategory:Entries");
				return null;
			}
			if (Entries_MarshalerCached == null)
			{
				Entries_MarshalerCached = new TArrayReadWriteMarshaler<FPCGWeightedByCategoryEntryList>(1, Entries_PropertyAddress, CachedMarshalingDelegates<FPCGWeightedByCategoryEntryList, FPCGWeightedByCategoryEntryList>.FromNative, CachedMarshalingDelegates<FPCGWeightedByCategoryEntryList, FPCGWeightedByCategoryEntryList>.ToNative);
			}
			return Entries_MarshalerCached.FromNative(IntPtr.Add(base.Address, Entries_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMeshSelectorWeightedByCategory:bUseAttributeMaterialOverrides")]
	public bool UseAttributeMaterialOverrides
	{
		get
		{
			CheckDestroyed();
			if (!UseAttributeMaterialOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMeshSelectorWeightedByCategory:bUseAttributeMaterialOverrides");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseAttributeMaterialOverrides_Offset), 0, UseAttributeMaterialOverrides_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseAttributeMaterialOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMeshSelectorWeightedByCategory:bUseAttributeMaterialOverrides");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseAttributeMaterialOverrides_Offset), 0, UseAttributeMaterialOverrides_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGMeshSelectorWeightedByCategory:MaterialOverrideAttributes")]
	public TArrayReadWrite<FName> MaterialOverrideAttributes
	{
		get
		{
			CheckDestroyed();
			if (!MaterialOverrideAttributes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMeshSelectorWeightedByCategory:MaterialOverrideAttributes");
				return null;
			}
			if (MaterialOverrideAttributes_MarshalerCached == null)
			{
				MaterialOverrideAttributes_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, MaterialOverrideAttributes_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return MaterialOverrideAttributes_MarshalerCached.FromNative(IntPtr.Add(base.Address, MaterialOverrideAttributes_Offset));
		}
	}

	static UPCGMeshSelectorWeightedByCategory()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGMeshSelectorWeightedByCategory)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGMeshSelectorWeightedByCategory));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGMeshSelectorWeightedByCategory");
		CategoryAttribute_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CategoryAttribute");
		CategoryAttribute_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CategoryAttribute", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Entries_PropertyAddress, unrealStruct, "Entries");
		Entries_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Entries");
		Entries_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Entries", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UseAttributeMaterialOverrides_PropertyAddress, unrealStruct, "bUseAttributeMaterialOverrides");
		UseAttributeMaterialOverrides_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseAttributeMaterialOverrides");
		UseAttributeMaterialOverrides_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseAttributeMaterialOverrides", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MaterialOverrideAttributes_PropertyAddress, unrealStruct, "MaterialOverrideAttributes");
		MaterialOverrideAttributes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaterialOverrideAttributes");
		MaterialOverrideAttributes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaterialOverrideAttributes", Classes.FArrayProperty);
	}
}
