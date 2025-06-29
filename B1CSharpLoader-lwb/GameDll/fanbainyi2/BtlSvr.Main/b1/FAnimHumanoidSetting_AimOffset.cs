using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AimOffset")]
public struct FAnimHumanoidSetting_AimOffset
{
	[DisplayName("AO转头速度")]
	[Tooltip("单位：秒/°")]
	[UMeta(MDProp.ClampMax, "1080")]
	[UMeta(MDProp.ClampMin, "0")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AimOffset:AimOffsetTurnSpeed")]
	public int AimOffsetTurnSpeed;

	[Tooltip("单位：角度。以单位正后方为基准开始算，单边角度")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.ClampMax, "180")]
	[DisplayName("盲区")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AimOffset:AimOffsetBlindAngle")]
	public int AimOffsetBlindAngle;

	[DisplayName("默认AO")]
	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AimOffset:DefaultAimOffset")]
	public UAimOffsetBlendSpace DefaultAimOffset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("攻击中AO")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_AimOffset:AttackAimOffset")]
	public UAimOffsetBlendSpace AttackAimOffset;

	private static int AnimHumanoidSetting_AimOffset_StructSize;

	private static int AnimHumanoidSetting_AimOffset_IsValid;

	private static bool AimOffsetTurnSpeed_IsValid;

	private static int AimOffsetTurnSpeed_Offset;

	private static bool AimOffsetBlindAngle_IsValid;

	private static int AimOffsetBlindAngle_Offset;

	private static bool DefaultAimOffset_IsValid;

	private static int DefaultAimOffset_Offset;

	private static bool AttackAimOffset_IsValid;

	private static int AttackAimOffset_Offset;

	public FAnimHumanoidSetting_AimOffset Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_AimOffset FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_AimOffset(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_AimOffset value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_AimOffset FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_AimOffset(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_AimOffset_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_AimOffset value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_AimOffset_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_AimOffset_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_AimOffset");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AimOffsetTurnSpeed_Offset), AimOffsetTurnSpeed);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AimOffsetBlindAngle_Offset), AimOffsetBlindAngle);
		UObjectMarshaler<UAimOffsetBlendSpace>.ToNative(IntPtr.Add(nativeStruct, DefaultAimOffset_Offset), DefaultAimOffset);
		UObjectMarshaler<UAimOffsetBlendSpace>.ToNative(IntPtr.Add(nativeStruct, AttackAimOffset_Offset), AttackAimOffset);
	}

	public FAnimHumanoidSetting_AimOffset(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_AimOffset_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_AimOffset");
			AimOffsetTurnSpeed = 0;
			AimOffsetBlindAngle = 0;
			DefaultAimOffset = null;
			AttackAimOffset = null;
		}
		else
		{
			AimOffsetTurnSpeed = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AimOffsetTurnSpeed_Offset));
			AimOffsetBlindAngle = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AimOffsetBlindAngle_Offset));
			DefaultAimOffset = UObjectMarshaler<UAimOffsetBlendSpace>.FromNative(IntPtr.Add(nativeStruct, DefaultAimOffset_Offset));
			AttackAimOffset = UObjectMarshaler<UAimOffsetBlendSpace>.FromNative(IntPtr.Add(nativeStruct, AttackAimOffset_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_AimOffset");
		AnimHumanoidSetting_AimOffset_StructSize = NativeReflection.GetStructSize(intPtr);
		AimOffsetTurnSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "AimOffsetTurnSpeed");
		AimOffsetTurnSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AimOffsetTurnSpeed", Classes.FIntProperty);
		AimOffsetBlindAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "AimOffsetBlindAngle");
		AimOffsetBlindAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AimOffsetBlindAngle", Classes.FIntProperty);
		DefaultAimOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultAimOffset");
		DefaultAimOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultAimOffset", Classes.FObjectProperty);
		AttackAimOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackAimOffset");
		AttackAimOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackAimOffset", Classes.FObjectProperty);
		AnimHumanoidSetting_AimOffset_IsValid = ((intPtr != IntPtr.Zero && AimOffsetTurnSpeed_IsValid && AimOffsetBlindAngle_IsValid && DefaultAimOffset_IsValid && AttackAimOffset_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_AimOffset", (byte)AnimHumanoidSetting_AimOffset_IsValid != 0);
	}

	static FAnimHumanoidSetting_AimOffset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_AimOffset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_AimOffset));
	}
}
