using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDamageNumberConfigDataAsset")]
public class BGWDamageNumberConfigDataAsset : UBGWDataAsset
{
	private static bool DamageUIMap_IsValid;

	private static int DamageUIMap_Offset;

	private static FFieldAddress DamageUIMap_PropertyAddress;

	private TMapReadWriteMarshaler<EDamageNumberType, TSubclassOf<UUserWidget>> DamageUIMap_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDamageNumberConfigDataAsset:DamageUIMap")]
	public TMapReadWrite<EDamageNumberType, TSubclassOf<UUserWidget>> DamageUIMap
	{
		get
		{
			CheckDestroyed();
			if (!DamageUIMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDamageNumberConfigDataAsset:DamageUIMap");
				return null;
			}
			if (DamageUIMap_Marshaler == null)
			{
				DamageUIMap_Marshaler = new TMapReadWriteMarshaler<EDamageNumberType, TSubclassOf<UUserWidget>>(1, DamageUIMap_PropertyAddress, CachedMarshalingDelegates<EDamageNumberType, EnumMarshaler<EDamageNumberType>>.FromNative, CachedMarshalingDelegates<EDamageNumberType, EnumMarshaler<EDamageNumberType>>.ToNative, CachedMarshalingDelegates<TSubclassOf<UUserWidget>, TSubclassOfMarshaler<UUserWidget>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UUserWidget>, TSubclassOfMarshaler<UUserWidget>>.ToNative);
			}
			return DamageUIMap_Marshaler.FromNative(IntPtr.Add(base.Address, DamageUIMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDamageNumberConfigDataAsset");
		NativeReflection.GetPropertyRef(ref DamageUIMap_PropertyAddress, unrealStruct, "DamageUIMap");
		DamageUIMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DamageUIMap");
		DamageUIMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DamageUIMap", Classes.FMapProperty);
	}

	static BGWDamageNumberConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDamageNumberConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDamageNumberConfigDataAsset));
	}
}
