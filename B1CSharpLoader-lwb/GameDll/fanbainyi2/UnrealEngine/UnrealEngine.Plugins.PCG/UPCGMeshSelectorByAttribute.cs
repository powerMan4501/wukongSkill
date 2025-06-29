using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMeshSelectorByAttribute", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGMeshSelectorByAttribute : UPCGMeshSelectorBase
{
	private static bool AttributeName_IsValid;

	private static int AttributeName_Offset;

	private static bool UseAttributeMaterialOverrides_IsValid;

	private static FFieldAddress UseAttributeMaterialOverrides_PropertyAddress;

	private static int UseAttributeMaterialOverrides_Offset;

	private static bool MaterialOverrideAttributes_IsValid;

	private static FFieldAddress MaterialOverrideAttributes_PropertyAddress;

	private static int MaterialOverrideAttributes_Offset;

	private TArrayReadWriteMarshaler<FName> MaterialOverrideAttributes_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMeshSelectorByAttribute:AttributeName")]
	public FName AttributeName
	{
		get
		{
			CheckDestroyed();
			if (!AttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMeshSelectorByAttribute:AttributeName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AttributeName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMeshSelectorByAttribute:AttributeName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AttributeName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMeshSelectorByAttribute:bUseAttributeMaterialOverrides")]
	public bool UseAttributeMaterialOverrides
	{
		get
		{
			CheckDestroyed();
			if (!UseAttributeMaterialOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMeshSelectorByAttribute:bUseAttributeMaterialOverrides");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseAttributeMaterialOverrides_Offset), 0, UseAttributeMaterialOverrides_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseAttributeMaterialOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMeshSelectorByAttribute:bUseAttributeMaterialOverrides");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseAttributeMaterialOverrides_Offset), 0, UseAttributeMaterialOverrides_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGMeshSelectorByAttribute:MaterialOverrideAttributes")]
	public TArrayReadWrite<FName> MaterialOverrideAttributes
	{
		get
		{
			CheckDestroyed();
			if (!MaterialOverrideAttributes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMeshSelectorByAttribute:MaterialOverrideAttributes");
				return null;
			}
			if (MaterialOverrideAttributes_MarshalerCached == null)
			{
				MaterialOverrideAttributes_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, MaterialOverrideAttributes_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return MaterialOverrideAttributes_MarshalerCached.FromNative(IntPtr.Add(base.Address, MaterialOverrideAttributes_Offset));
		}
	}

	static UPCGMeshSelectorByAttribute()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGMeshSelectorByAttribute)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGMeshSelectorByAttribute));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGMeshSelectorByAttribute");
		AttributeName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttributeName");
		AttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref UseAttributeMaterialOverrides_PropertyAddress, unrealStruct, "bUseAttributeMaterialOverrides");
		UseAttributeMaterialOverrides_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseAttributeMaterialOverrides");
		UseAttributeMaterialOverrides_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseAttributeMaterialOverrides", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MaterialOverrideAttributes_PropertyAddress, unrealStruct, "MaterialOverrideAttributes");
		MaterialOverrideAttributes_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaterialOverrideAttributes");
		MaterialOverrideAttributes_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaterialOverrideAttributes", Classes.FArrayProperty);
	}
}
