using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_BattleSCConfig")]
public class BGWDataAsset_BattleSCConfig : UBGWDataAsset
{
	private static bool BattleSCConfigMap_IsValid;

	private static int BattleSCConfigMap_Offset;

	private static FFieldAddress BattleSCConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<FGameplayTag, FBattleSCInfo> BattleSCConfigMap_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BattleSCConfig:BattleSCConfigMap")]
	public TMapReadWrite<FGameplayTag, FBattleSCInfo> BattleSCConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!BattleSCConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BattleSCConfig:BattleSCConfigMap");
				return null;
			}
			if (BattleSCConfigMap_Marshaler == null)
			{
				BattleSCConfigMap_Marshaler = new TMapReadWriteMarshaler<FGameplayTag, FBattleSCInfo>(1, BattleSCConfigMap_PropertyAddress, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative, CachedMarshalingDelegates<FBattleSCInfo, FBattleSCInfo>.FromNative, CachedMarshalingDelegates<FBattleSCInfo, FBattleSCInfo>.ToNative);
			}
			return BattleSCConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, BattleSCConfigMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_BattleSCConfig");
		NativeReflection.GetPropertyRef(ref BattleSCConfigMap_PropertyAddress, unrealStruct, "BattleSCConfigMap");
		BattleSCConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BattleSCConfigMap");
		BattleSCConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BattleSCConfigMap", Classes.FMapProperty);
	}

	static BGWDataAsset_BattleSCConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_BattleSCConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_BattleSCConfig));
	}
}
