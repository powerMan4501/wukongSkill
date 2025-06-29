using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_ChargeLevelConfig")]
public class BGWDataAsset_ChargeLevelConfig : UBGWDataAsset
{
	private static bool ChargeLevelConfigs_IsValid;

	private static int ChargeLevelConfigs_Offset;

	private static FFieldAddress ChargeLevelConfigs_PropertyAddress;

	private TArrayReadWriteMarshaler<FChargeLevelConfig> ChargeLevelConfigs_Marshaler;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ChargeLevelConfig:ChargeLevelConfigs")]
	public TArrayReadWrite<FChargeLevelConfig> ChargeLevelConfigs
	{
		get
		{
			CheckDestroyed();
			if (!ChargeLevelConfigs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ChargeLevelConfig:ChargeLevelConfigs");
				return null;
			}
			if (ChargeLevelConfigs_Marshaler == null)
			{
				ChargeLevelConfigs_Marshaler = new TArrayReadWriteMarshaler<FChargeLevelConfig>(1, ChargeLevelConfigs_PropertyAddress, CachedMarshalingDelegates<FChargeLevelConfig, FChargeLevelConfig>.FromNative, CachedMarshalingDelegates<FChargeLevelConfig, FChargeLevelConfig>.ToNative);
			}
			return ChargeLevelConfigs_Marshaler.FromNative(IntPtr.Add(base.Address, ChargeLevelConfigs_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_ChargeLevelConfig");
		NativeReflection.GetPropertyRef(ref ChargeLevelConfigs_PropertyAddress, unrealStruct, "ChargeLevelConfigs");
		ChargeLevelConfigs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ChargeLevelConfigs");
		ChargeLevelConfigs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ChargeLevelConfigs", Classes.FArrayProperty);
	}

	static BGWDataAsset_ChargeLevelConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_ChargeLevelConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_ChargeLevelConfig));
	}
}
