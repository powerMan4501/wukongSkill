using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_PerformerConfig")]
public class BGWDataAsset_PerformerConfig : UBGWDataAsset
{
	private static bool PerformerInfoMapping_IsValid;

	private static int PerformerInfoMapping_Offset;

	private static FFieldAddress PerformerInfoMapping_PropertyAddress;

	private TMapReadWriteMarshaler<FName, FPerformerInfo> PerformerInfoMapping_Marshaler;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("演员标识映射")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PerformerConfig:PerformerInfoMapping")]
	public TMapReadWrite<FName, FPerformerInfo> PerformerInfoMapping
	{
		get
		{
			CheckDestroyed();
			if (!PerformerInfoMapping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PerformerConfig:PerformerInfoMapping");
				return null;
			}
			if (PerformerInfoMapping_Marshaler == null)
			{
				PerformerInfoMapping_Marshaler = new TMapReadWriteMarshaler<FName, FPerformerInfo>(1, PerformerInfoMapping_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FPerformerInfo, FPerformerInfo>.FromNative, CachedMarshalingDelegates<FPerformerInfo, FPerformerInfo>.ToNative);
			}
			return PerformerInfoMapping_Marshaler.FromNative(IntPtr.Add(base.Address, PerformerInfoMapping_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_PerformerConfig");
		NativeReflection.GetPropertyRef(ref PerformerInfoMapping_PropertyAddress, unrealStruct, "PerformerInfoMapping");
		PerformerInfoMapping_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PerformerInfoMapping");
		PerformerInfoMapping_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PerformerInfoMapping", Classes.FMapProperty);
	}

	static BGWDataAsset_PerformerConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_PerformerConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_PerformerConfig));
	}
}
