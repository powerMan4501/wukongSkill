using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.EnvironmentAbnormalEffectConfig")]
public struct EnvironmentAbnormalEffectConfig
{
	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.EnvironmentAbnormalEffectConfig:AbnormalStateConfig")]
	public AbnormalStateAccConfig AbnormalStateConfig;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.EnvironmentAbnormalEffectConfig:bDisableAutoRecover")]
	public bool bDisableAutoRecover;

	private static int EnvironmentAbnormalEffectConfig_StructSize;

	private static int EnvironmentAbnormalEffectConfig_IsValid;

	private static bool AbnormalStateConfig_IsValid;

	private static int AbnormalStateConfig_Offset;

	private static bool bDisableAutoRecover_IsValid;

	private static int bDisableAutoRecover_Offset;

	private static FFieldAddress bDisableAutoRecover_PropertyAddress;

	public EnvironmentAbnormalEffectConfig Copy()
	{
		return this;
	}

	public static EnvironmentAbnormalEffectConfig FromNative(IntPtr nativeBuffer)
	{
		return new EnvironmentAbnormalEffectConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, EnvironmentAbnormalEffectConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static EnvironmentAbnormalEffectConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new EnvironmentAbnormalEffectConfig(IntPtr.Add(nativeBuffer, arrayIndex * EnvironmentAbnormalEffectConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, EnvironmentAbnormalEffectConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * EnvironmentAbnormalEffectConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (EnvironmentAbnormalEffectConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EnvironmentAbnormalEffectConfig");
			return;
		}
		AbnormalStateAccConfig.ToNative(IntPtr.Add(nativeStruct, AbnormalStateConfig_Offset), AbnormalStateConfig);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bDisableAutoRecover_Offset), 0, bDisableAutoRecover_PropertyAddress.Address, bDisableAutoRecover);
	}

	public EnvironmentAbnormalEffectConfig(IntPtr nativeStruct)
	{
		if (EnvironmentAbnormalEffectConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EnvironmentAbnormalEffectConfig");
			AbnormalStateConfig = default(AbnormalStateAccConfig);
			bDisableAutoRecover = false;
		}
		else
		{
			AbnormalStateConfig = AbnormalStateAccConfig.FromNative(IntPtr.Add(nativeStruct, AbnormalStateConfig_Offset));
			bDisableAutoRecover = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bDisableAutoRecover_Offset), 0, bDisableAutoRecover_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.EnvironmentAbnormalEffectConfig");
		EnvironmentAbnormalEffectConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		AbnormalStateConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbnormalStateConfig");
		AbnormalStateConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbnormalStateConfig", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bDisableAutoRecover_PropertyAddress, intPtr, "bDisableAutoRecover");
		bDisableAutoRecover_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableAutoRecover");
		bDisableAutoRecover_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableAutoRecover", Classes.FBoolProperty);
		EnvironmentAbnormalEffectConfig_IsValid = ((intPtr != IntPtr.Zero && AbnormalStateConfig_IsValid && bDisableAutoRecover_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.EnvironmentAbnormalEffectConfig", (byte)EnvironmentAbnormalEffectConfig_IsValid != 0);
	}

	static EnvironmentAbnormalEffectConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(EnvironmentAbnormalEffectConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(EnvironmentAbnormalEffectConfig));
	}
}
