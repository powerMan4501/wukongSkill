using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.EnvironmentAbnormalRecoverRate")]
public struct EnvironmentAbnormalRecoverRate
{
	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.EnvironmentAbnormalRecoverRate:AbnormalStateType")]
	public EAbnormalStateType AbnormalStateType;

	[BlueprintReadOnly]
	[UProperty]
	[Tooltip("自动恢复速度倍数")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.EnvironmentAbnormalRecoverRate:AutoRecoverRate")]
	public float AutoRecoverRate;

	private static int EnvironmentAbnormalRecoverRate_StructSize;

	private static int EnvironmentAbnormalRecoverRate_IsValid;

	private static bool AbnormalStateType_IsValid;

	private static int AbnormalStateType_Offset;

	private static FFieldAddress AbnormalStateType_PropertyAddress;

	private static bool AutoRecoverRate_IsValid;

	private static int AutoRecoverRate_Offset;

	public EnvironmentAbnormalRecoverRate Copy()
	{
		return this;
	}

	public static EnvironmentAbnormalRecoverRate FromNative(IntPtr nativeBuffer)
	{
		return new EnvironmentAbnormalRecoverRate(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, EnvironmentAbnormalRecoverRate value)
	{
		value.ToNative(nativeBuffer);
	}

	public static EnvironmentAbnormalRecoverRate FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new EnvironmentAbnormalRecoverRate(IntPtr.Add(nativeBuffer, arrayIndex * EnvironmentAbnormalRecoverRate_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, EnvironmentAbnormalRecoverRate value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * EnvironmentAbnormalRecoverRate_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (EnvironmentAbnormalRecoverRate_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EnvironmentAbnormalRecoverRate");
			return;
		}
		EnumMarshaler<EAbnormalStateType>.ToNative(IntPtr.Add(nativeStruct, AbnormalStateType_Offset), 0, AbnormalStateType_PropertyAddress.Address, AbnormalStateType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AutoRecoverRate_Offset), AutoRecoverRate);
	}

	public EnvironmentAbnormalRecoverRate(IntPtr nativeStruct)
	{
		if (EnvironmentAbnormalRecoverRate_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EnvironmentAbnormalRecoverRate");
			AbnormalStateType = EAbnormalStateType.None;
			AutoRecoverRate = 0f;
		}
		else
		{
			AbnormalStateType = EnumMarshaler<EAbnormalStateType>.FromNative(IntPtr.Add(nativeStruct, AbnormalStateType_Offset), 0, AbnormalStateType_PropertyAddress.Address);
			AutoRecoverRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AutoRecoverRate_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.EnvironmentAbnormalRecoverRate");
		EnvironmentAbnormalRecoverRate_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref AbnormalStateType_PropertyAddress, intPtr, "AbnormalStateType");
		AbnormalStateType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbnormalStateType");
		AbnormalStateType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbnormalStateType", Classes.FEnumProperty);
		AutoRecoverRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "AutoRecoverRate");
		AutoRecoverRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AutoRecoverRate", Classes.FFloatProperty);
		EnvironmentAbnormalRecoverRate_IsValid = ((intPtr != IntPtr.Zero && AbnormalStateType_IsValid && AutoRecoverRate_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.EnvironmentAbnormalRecoverRate", (byte)EnvironmentAbnormalRecoverRate_IsValid != 0);
	}

	static EnvironmentAbnormalRecoverRate()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(EnvironmentAbnormalRecoverRate)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(EnvironmentAbnormalRecoverRate));
	}
}
