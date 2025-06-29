using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BUC_PerformerMappingConfigDataAsset")]
public class BUC_PerformerMappingConfigDataAsset : UBGWDataAsset
{
	private static bool PerformerTagMapping_IsValid;

	private static int PerformerTagMapping_Offset;

	private static FFieldAddress PerformerTagMapping_PropertyAddress;

	private TMapReadWriteMarshaler<TSubclassOf<BGUPerformerActorCS>, FPerformerTag> PerformerTagMapping_Marshaler;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("演员标记配置")]
	[USharpPath("/Script/b1-Managed.BUC_PerformerMappingConfigDataAsset:PerformerTagMapping")]
	public TMapReadWrite<TSubclassOf<BGUPerformerActorCS>, FPerformerTag> PerformerTagMapping
	{
		get
		{
			CheckDestroyed();
			if (!PerformerTagMapping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_PerformerMappingConfigDataAsset:PerformerTagMapping");
				return null;
			}
			if (PerformerTagMapping_Marshaler == null)
			{
				PerformerTagMapping_Marshaler = new TMapReadWriteMarshaler<TSubclassOf<BGUPerformerActorCS>, FPerformerTag>(1, PerformerTagMapping_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<BGUPerformerActorCS>, TSubclassOfMarshaler<BGUPerformerActorCS>>.FromNative, CachedMarshalingDelegates<TSubclassOf<BGUPerformerActorCS>, TSubclassOfMarshaler<BGUPerformerActorCS>>.ToNative, CachedMarshalingDelegates<FPerformerTag, FPerformerTag>.FromNative, CachedMarshalingDelegates<FPerformerTag, FPerformerTag>.ToNative);
			}
			return PerformerTagMapping_Marshaler.FromNative(IntPtr.Add(base.Address, PerformerTagMapping_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUC_PerformerMappingConfigDataAsset");
		NativeReflection.GetPropertyRef(ref PerformerTagMapping_PropertyAddress, unrealStruct, "PerformerTagMapping");
		PerformerTagMapping_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PerformerTagMapping");
		PerformerTagMapping_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PerformerTagMapping", Classes.FMapProperty);
	}

	static BUC_PerformerMappingConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_PerformerMappingConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_PerformerMappingConfigDataAsset));
	}
}
