using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.SettingHpConfig")]
public struct FSettingHpConfig
{
	[UProperty]
	[EditAnywhere]
	[DisplayName("备注等级")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SettingHpConfig:Name")]
	public string Name;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("低血量后处理(low)")]
	[USharpPath("/Script/b1-Managed.SettingHpConfig:HPLowPostProcessPercent")]
	public float HPLowPostProcessPercent;

	[DisplayName("低血量后处理(limit)")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SettingHpConfig:HPLimitPostProcessPercent")]
	public float HPLimitPostProcessPercent;

	private static int SettingHpConfig_StructSize;

	private static int SettingHpConfig_IsValid;

	private static bool Name_IsValid;

	private static int Name_Offset;

	private static bool HPLowPostProcessPercent_IsValid;

	private static int HPLowPostProcessPercent_Offset;

	private static bool HPLimitPostProcessPercent_IsValid;

	private static int HPLimitPostProcessPercent_Offset;

	public FSettingHpConfig Copy()
	{
		return this;
	}

	public static FSettingHpConfig FromNative(IntPtr nativeBuffer)
	{
		return new FSettingHpConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSettingHpConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSettingHpConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSettingHpConfig(IntPtr.Add(nativeBuffer, arrayIndex * SettingHpConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSettingHpConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SettingHpConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SettingHpConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SettingHpConfig");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HPLowPostProcessPercent_Offset), HPLowPostProcessPercent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HPLimitPostProcessPercent_Offset), HPLimitPostProcessPercent);
	}

	public FSettingHpConfig(IntPtr nativeStruct)
	{
		if (SettingHpConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SettingHpConfig");
			Name = null;
			HPLowPostProcessPercent = 0f;
			HPLimitPostProcessPercent = 0f;
		}
		else
		{
			Name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			HPLowPostProcessPercent = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HPLowPostProcessPercent_Offset));
			HPLimitPostProcessPercent = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HPLimitPostProcessPercent_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SettingHpConfig");
		SettingHpConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflection.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Name", Classes.FStrProperty);
		HPLowPostProcessPercent_Offset = NativeReflection.GetPropertyOffset(intPtr, "HPLowPostProcessPercent");
		HPLowPostProcessPercent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HPLowPostProcessPercent", Classes.FFloatProperty);
		HPLimitPostProcessPercent_Offset = NativeReflection.GetPropertyOffset(intPtr, "HPLimitPostProcessPercent");
		HPLimitPostProcessPercent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HPLimitPostProcessPercent", Classes.FFloatProperty);
		SettingHpConfig_IsValid = ((intPtr != IntPtr.Zero && Name_IsValid && HPLowPostProcessPercent_IsValid && HPLimitPostProcessPercent_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SettingHpConfig", (byte)SettingHpConfig_IsValid != 0);
	}

	static FSettingHpConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSettingHpConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSettingHpConfig));
	}
}
