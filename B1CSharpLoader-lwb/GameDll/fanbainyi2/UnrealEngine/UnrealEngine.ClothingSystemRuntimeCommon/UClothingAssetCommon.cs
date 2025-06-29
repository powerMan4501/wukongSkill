using System;
using UnrealEngine.ClothingSystemRuntimeInterface;
using UnrealEngine.Runtime;

namespace UnrealEngine.ClothingSystemRuntimeCommon;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ClothingSystemRuntimeCommon.ClothingAssetCommon", "ClothingSystemRuntimeCommon", UnrealModuleType.Engine)]
public class UClothingAssetCommon : UClothingAssetBase
{
	private static bool ClothConfigs_IsValid;

	private static FFieldAddress ClothConfigs_PropertyAddress;

	private static int ClothConfigs_Offset;

	private TMapReadOnlyMarshaler<FName, UClothConfigBase> ClothConfigs_MarshalerCached;

	[UProperty(Flags = (PropFlags)5630049290158173uL)]
	[UMetaPath("/Script/ClothingSystemRuntimeCommon.ClothingAssetCommon:ClothConfigs")]
	public TMapReadOnly<FName, UClothConfigBase> ClothConfigs
	{
		get
		{
			CheckDestroyed();
			if (!ClothConfigs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ClothingSystemRuntimeCommon.ClothingAssetCommon:ClothConfigs");
				return null;
			}
			if (ClothConfigs_MarshalerCached == null)
			{
				ClothConfigs_MarshalerCached = new TMapReadOnlyMarshaler<FName, UClothConfigBase>(1, ClothConfigs_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<UClothConfigBase, UObjectMarshaler<UClothConfigBase>>.FromNative, CachedMarshalingDelegates<UClothConfigBase, UObjectMarshaler<UClothConfigBase>>.ToNative);
			}
			return ClothConfigs_MarshalerCached.FromNative(IntPtr.Add(base.Address, ClothConfigs_Offset));
		}
	}

	static UClothingAssetCommon()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UClothingAssetCommon)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UClothingAssetCommon));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/ClothingSystemRuntimeCommon.ClothingAssetCommon");
		NativeReflectionCached.GetPropertyRef(ref ClothConfigs_PropertyAddress, unrealStruct, "ClothConfigs");
		ClothConfigs_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ClothConfigs");
		ClothConfigs_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ClothConfigs", Classes.FMapProperty);
	}
}
