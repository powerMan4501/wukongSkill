using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_AIHatredConfig")]
public class BGWDataAsset_AIHatredConfig : UBGWDataAsset
{
	private static bool UnitBaseHatreds_IsValid;

	private static int UnitBaseHatreds_Offset;

	private static FFieldAddress UnitBaseHatreds_PropertyAddress;

	private TMapReadWriteMarshaler<int, int> UnitBaseHatreds_Marshaler;

	private static bool DistanceWeightMultiplier_IsValid;

	private static int DistanceWeightMultiplier_Offset;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[Category("AIHatredConfig")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AIHatredConfig:UnitBaseHatreds")]
	public TMapReadWrite<int, int> UnitBaseHatreds
	{
		get
		{
			CheckDestroyed();
			if (!UnitBaseHatreds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AIHatredConfig:UnitBaseHatreds");
				return null;
			}
			if (UnitBaseHatreds_Marshaler == null)
			{
				UnitBaseHatreds_Marshaler = new TMapReadWriteMarshaler<int, int>(1, UnitBaseHatreds_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return UnitBaseHatreds_Marshaler.FromNative(IntPtr.Add(base.Address, UnitBaseHatreds_Offset));
		}
	}

	[Category("AIHatredConfig")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AIHatredConfig:DistanceWeightMultiplier")]
	public float DistanceWeightMultiplier
	{
		get
		{
			CheckDestroyed();
			if (!DistanceWeightMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AIHatredConfig:DistanceWeightMultiplier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DistanceWeightMultiplier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceWeightMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AIHatredConfig:DistanceWeightMultiplier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DistanceWeightMultiplier_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_AIHatredConfig");
		NativeReflection.GetPropertyRef(ref UnitBaseHatreds_PropertyAddress, unrealStruct, "UnitBaseHatreds");
		UnitBaseHatreds_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitBaseHatreds");
		UnitBaseHatreds_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitBaseHatreds", Classes.FMapProperty);
		DistanceWeightMultiplier_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DistanceWeightMultiplier");
		DistanceWeightMultiplier_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DistanceWeightMultiplier", Classes.FFloatProperty);
	}

	static BGWDataAsset_AIHatredConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_AIHatredConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_AIHatredConfig));
	}
}
