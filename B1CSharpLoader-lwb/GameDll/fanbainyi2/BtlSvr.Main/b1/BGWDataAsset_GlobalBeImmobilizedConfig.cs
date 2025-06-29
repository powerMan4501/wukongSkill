using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGWDataAsset_GlobalBeImmobilizedConfig")]
public class BGWDataAsset_GlobalBeImmobilizedConfig : UBGWDataAsset
{
	private static bool BeImmobilizedConfigs_IsValid;

	private static int BeImmobilizedConfigs_Offset;

	private static FFieldAddress BeImmobilizedConfigs_PropertyAddress;

	private TArrayReadWriteMarshaler<BGWDataAsset_BeImmobilizedConfig> BeImmobilizedConfigs_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GlobalBeImmobilizedConfig:BeImmobilizedConfigs")]
	public TArrayReadWrite<BGWDataAsset_BeImmobilizedConfig> BeImmobilizedConfigs
	{
		get
		{
			CheckDestroyed();
			if (!BeImmobilizedConfigs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GlobalBeImmobilizedConfig:BeImmobilizedConfigs");
				return null;
			}
			if (BeImmobilizedConfigs_Marshaler == null)
			{
				BeImmobilizedConfigs_Marshaler = new TArrayReadWriteMarshaler<BGWDataAsset_BeImmobilizedConfig>(1, BeImmobilizedConfigs_PropertyAddress, CachedMarshalingDelegates<BGWDataAsset_BeImmobilizedConfig, UObjectMarshaler<BGWDataAsset_BeImmobilizedConfig>>.FromNative, CachedMarshalingDelegates<BGWDataAsset_BeImmobilizedConfig, UObjectMarshaler<BGWDataAsset_BeImmobilizedConfig>>.ToNative);
			}
			return BeImmobilizedConfigs_Marshaler.FromNative(IntPtr.Add(base.Address, BeImmobilizedConfigs_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_GlobalBeImmobilizedConfig");
		NativeReflection.GetPropertyRef(ref BeImmobilizedConfigs_PropertyAddress, unrealStruct, "BeImmobilizedConfigs");
		BeImmobilizedConfigs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeImmobilizedConfigs");
		BeImmobilizedConfigs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeImmobilizedConfigs", Classes.FArrayProperty);
	}

	static BGWDataAsset_GlobalBeImmobilizedConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_GlobalBeImmobilizedConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_GlobalBeImmobilizedConfig));
	}
}
