using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_MessageDistributionCenter")]
public class BUS_MessageDistributionCenter : UActorEditCompBase
{
	private static bool BattleEventMap_IsValid;

	private static int BattleEventMap_Offset;

	private static FFieldAddress BattleEventMap_PropertyAddress;

	private TMapReadWriteMarshaler<FGameplayTag, FGameplayTag> BattleEventMap_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Config")]
	[Tooltip("【废弃不再用，请配置进DA_BattleSCConfig】")]
	[DisplayName("【废弃不再用，请配置进DA_BattleSCConfig】")]
	[USharpPath("/Script/b1-Managed.BUS_MessageDistributionCenter:BattleEventMap")]
	public TMapReadWrite<FGameplayTag, FGameplayTag> BattleEventMap
	{
		get
		{
			CheckDestroyed();
			if (!BattleEventMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MessageDistributionCenter:BattleEventMap");
				return null;
			}
			if (BattleEventMap_Marshaler == null)
			{
				BattleEventMap_Marshaler = new TMapReadWriteMarshaler<FGameplayTag, FGameplayTag>(1, BattleEventMap_PropertyAddress, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative);
			}
			return BattleEventMap_Marshaler.FromNative(IntPtr.Add(base.Address, BattleEventMap_Offset));
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_MessageDistributionCenter");
		NativeReflection.GetPropertyRef(ref BattleEventMap_PropertyAddress, unrealStruct, "BattleEventMap");
		BattleEventMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BattleEventMap");
		BattleEventMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BattleEventMap", Classes.FMapProperty);
	}

	static BUS_MessageDistributionCenter()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_MessageDistributionCenter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_MessageDistributionCenter));
	}
}
