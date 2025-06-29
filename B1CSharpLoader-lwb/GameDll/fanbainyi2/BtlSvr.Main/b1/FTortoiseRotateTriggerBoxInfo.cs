using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TortoiseRotateTriggerBoxInfo")]
public struct FTortoiseRotateTriggerBoxInfo
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TortoiseRotateTriggerBoxInfo:UseCurveSettings")]
	public bool UseCurveSettings;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "UseCurveSettings == false")]
	[USharpPath("/Script/b1-Managed.TortoiseRotateTriggerBoxInfo:RotationAnimation")]
	public UAnimationAsset RotationAnimation;

	[UMeta(MDProp.EditCondition, "UseCurveSettings == true")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TortoiseRotateTriggerBoxInfo:RotationCurve")]
	public UCurveVector RotationCurve;

	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "UseCurveSettings == true")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TortoiseRotateTriggerBoxInfo:TransitionCurve")]
	public UCurveVector TransitionCurve;

	private static int TortoiseRotateTriggerBoxInfo_StructSize;

	private static int TortoiseRotateTriggerBoxInfo_IsValid;

	private static bool UseCurveSettings_IsValid;

	private static int UseCurveSettings_Offset;

	private static FFieldAddress UseCurveSettings_PropertyAddress;

	private static bool RotationAnimation_IsValid;

	private static int RotationAnimation_Offset;

	private static bool RotationCurve_IsValid;

	private static int RotationCurve_Offset;

	private static bool TransitionCurve_IsValid;

	private static int TransitionCurve_Offset;

	public FTortoiseRotateTriggerBoxInfo Copy()
	{
		return this;
	}

	public static FTortoiseRotateTriggerBoxInfo FromNative(IntPtr nativeBuffer)
	{
		return new FTortoiseRotateTriggerBoxInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTortoiseRotateTriggerBoxInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTortoiseRotateTriggerBoxInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTortoiseRotateTriggerBoxInfo(IntPtr.Add(nativeBuffer, arrayIndex * TortoiseRotateTriggerBoxInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTortoiseRotateTriggerBoxInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TortoiseRotateTriggerBoxInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TortoiseRotateTriggerBoxInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TortoiseRotateTriggerBoxInfo");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseCurveSettings_Offset), 0, UseCurveSettings_PropertyAddress.Address, UseCurveSettings);
		UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(nativeStruct, RotationAnimation_Offset), RotationAnimation);
		UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(nativeStruct, RotationCurve_Offset), RotationCurve);
		UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(nativeStruct, TransitionCurve_Offset), TransitionCurve);
	}

	public FTortoiseRotateTriggerBoxInfo(IntPtr nativeStruct)
	{
		if (TortoiseRotateTriggerBoxInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TortoiseRotateTriggerBoxInfo");
			UseCurveSettings = false;
			RotationAnimation = null;
			RotationCurve = null;
			TransitionCurve = null;
		}
		else
		{
			UseCurveSettings = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseCurveSettings_Offset), 0, UseCurveSettings_PropertyAddress.Address);
			RotationAnimation = UObjectMarshaler<UAnimationAsset>.FromNative(IntPtr.Add(nativeStruct, RotationAnimation_Offset));
			RotationCurve = UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(nativeStruct, RotationCurve_Offset));
			TransitionCurve = UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(nativeStruct, TransitionCurve_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TortoiseRotateTriggerBoxInfo");
		TortoiseRotateTriggerBoxInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref UseCurveSettings_PropertyAddress, intPtr, "UseCurveSettings");
		UseCurveSettings_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseCurveSettings");
		UseCurveSettings_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseCurveSettings", Classes.FBoolProperty);
		RotationAnimation_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotationAnimation");
		RotationAnimation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotationAnimation", Classes.FObjectProperty);
		RotationCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotationCurve");
		RotationCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotationCurve", Classes.FObjectProperty);
		TransitionCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "TransitionCurve");
		TransitionCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TransitionCurve", Classes.FObjectProperty);
		TortoiseRotateTriggerBoxInfo_IsValid = ((intPtr != IntPtr.Zero && UseCurveSettings_IsValid && RotationAnimation_IsValid && RotationCurve_IsValid && TransitionCurve_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TortoiseRotateTriggerBoxInfo", (byte)TortoiseRotateTriggerBoxInfo_IsValid != 0);
	}

	static FTortoiseRotateTriggerBoxInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTortoiseRotateTriggerBoxInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTortoiseRotateTriggerBoxInfo));
	}
}
