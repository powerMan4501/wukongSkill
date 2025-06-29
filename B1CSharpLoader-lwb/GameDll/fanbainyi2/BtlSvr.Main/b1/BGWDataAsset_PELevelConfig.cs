using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGWDataAsset_PELevelConfig")]
public class BGWDataAsset_PELevelConfig : UBGWDataAsset
{
	private static bool Config_IsValid;

	private static int Config_Offset;

	private static FFieldAddress Config_PropertyAddress;

	private TMapReadWriteMarshaler<int, FPEConfig> Config_Marshaler;

	private static bool PELimit_Normal_IsValid;

	private static int PELimit_Normal_Offset;

	private static bool PELimit_ByChargeSkill_IsValid;

	private static int PELimit_ByChargeSkill_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("棍势配置")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PELevelConfig:Config")]
	public TMapReadWrite<int, FPEConfig> Config
	{
		get
		{
			CheckDestroyed();
			if (!Config_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PELevelConfig:Config");
				return null;
			}
			if (Config_Marshaler == null)
			{
				Config_Marshaler = new TMapReadWriteMarshaler<int, FPEConfig>(1, Config_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FPEConfig, FPEConfig>.FromNative, CachedMarshalingDelegates<FPEConfig, FPEConfig>.ToNative);
			}
			return Config_Marshaler.FromNative(IntPtr.Add(base.Address, Config_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("亮槽上限")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PELevelConfig:PELimit_Normal")]
	public float PELimit_Normal
	{
		get
		{
			CheckDestroyed();
			if (!PELimit_Normal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PELevelConfig:PELimit_Normal");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PELimit_Normal_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PELimit_Normal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PELevelConfig:PELimit_Normal");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PELimit_Normal_Offset), value);
			}
		}
	}

	[DisplayName("黯淡槽上限")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PELevelConfig:PELimit_ByChargeSkill")]
	public float PELimit_ByChargeSkill
	{
		get
		{
			CheckDestroyed();
			if (!PELimit_ByChargeSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PELevelConfig:PELimit_ByChargeSkill");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PELimit_ByChargeSkill_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PELimit_ByChargeSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PELevelConfig:PELimit_ByChargeSkill");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PELimit_ByChargeSkill_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_PELevelConfig");
		NativeReflection.GetPropertyRef(ref Config_PropertyAddress, unrealStruct, "Config");
		Config_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Config");
		Config_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Config", Classes.FMapProperty);
		PELimit_Normal_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PELimit_Normal");
		PELimit_Normal_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PELimit_Normal", Classes.FFloatProperty);
		PELimit_ByChargeSkill_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PELimit_ByChargeSkill");
		PELimit_ByChargeSkill_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PELimit_ByChargeSkill", Classes.FFloatProperty);
	}

	static BGWDataAsset_PELevelConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_PELevelConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_PELevelConfig));
	}
}
