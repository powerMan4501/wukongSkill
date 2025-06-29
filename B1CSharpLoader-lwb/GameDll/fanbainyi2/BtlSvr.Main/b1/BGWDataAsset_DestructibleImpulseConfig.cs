using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_DestructibleImpulseConfig")]
public class BGWDataAsset_DestructibleImpulseConfig : UBGWDataAsset
{
	private static bool DefaultImpulse_IsValid;

	private static int DefaultImpulse_Offset;

	private static bool DestructibleHitImpulseMap_IsValid;

	private static int DestructibleHitImpulseMap_Offset;

	private static FFieldAddress DestructibleHitImpulseMap_PropertyAddress;

	private TMapReadWriteMarshaler<EGSHitDestructibleStrengthLevel, float> DestructibleHitImpulseMap_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("默认力度")]
	[Tooltip("移动撞碎和缺省的攻击档位配置都使用这个力度")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_DestructibleImpulseConfig:DefaultImpulse")]
	public float DefaultImpulse
	{
		get
		{
			CheckDestroyed();
			if (!DefaultImpulse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_DestructibleImpulseConfig:DefaultImpulse");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DefaultImpulse_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultImpulse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_DestructibleImpulseConfig:DefaultImpulse");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DefaultImpulse_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("攻击物理力度配置")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_DestructibleImpulseConfig:DestructibleHitImpulseMap")]
	public TMapReadWrite<EGSHitDestructibleStrengthLevel, float> DestructibleHitImpulseMap
	{
		get
		{
			CheckDestroyed();
			if (!DestructibleHitImpulseMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_DestructibleImpulseConfig:DestructibleHitImpulseMap");
				return null;
			}
			if (DestructibleHitImpulseMap_Marshaler == null)
			{
				DestructibleHitImpulseMap_Marshaler = new TMapReadWriteMarshaler<EGSHitDestructibleStrengthLevel, float>(1, DestructibleHitImpulseMap_PropertyAddress, CachedMarshalingDelegates<EGSHitDestructibleStrengthLevel, EnumMarshaler<EGSHitDestructibleStrengthLevel>>.FromNative, CachedMarshalingDelegates<EGSHitDestructibleStrengthLevel, EnumMarshaler<EGSHitDestructibleStrengthLevel>>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return DestructibleHitImpulseMap_Marshaler.FromNative(IntPtr.Add(base.Address, DestructibleHitImpulseMap_Offset));
		}
	}

	public float GetDestructibleImpulse(EGSHitDestructibleStrengthLevel Strength)
	{
		if (DestructibleHitImpulseMap.TryGetValue(Strength, out var value))
		{
			return value;
		}
		return DefaultImpulse;
	}

	public float GetDestructibleImpulse()
	{
		return DefaultImpulse;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_DestructibleImpulseConfig");
		DefaultImpulse_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DefaultImpulse");
		DefaultImpulse_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DefaultImpulse", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DestructibleHitImpulseMap_PropertyAddress, unrealStruct, "DestructibleHitImpulseMap");
		DestructibleHitImpulseMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DestructibleHitImpulseMap");
		DestructibleHitImpulseMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DestructibleHitImpulseMap", Classes.FMapProperty);
	}

	static BGWDataAsset_DestructibleImpulseConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_DestructibleImpulseConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_DestructibleImpulseConfig));
	}
}
