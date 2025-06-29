using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.FGSCameraOffsetSetting")]
public struct FGSCameraOffsetSetting
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSCameraOffsetSetting:EnableArmLength")]
	public bool EnableArmLength;

	[UProperty]
	[UMeta(MDProp.EditCondition, "EnableArmLength")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSCameraOffsetSetting:ArmLengthOffsetCurve")]
	public UCurveFloat ArmLengthOffsetCurve;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSCameraOffsetSetting:EnableFOVOffset")]
	public bool EnableFOVOffset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.EditCondition, "EnableFOVOffset")]
	[USharpPath("/Script/b1-Managed.FGSCameraOffsetSetting:FOVOffsetCurve")]
	public UCurveFloat FOVOffsetCurve;

	private static int FGSCameraOffsetSetting_StructSize;

	private static int FGSCameraOffsetSetting_IsValid;

	private static bool EnableArmLength_IsValid;

	private static int EnableArmLength_Offset;

	private static FFieldAddress EnableArmLength_PropertyAddress;

	private static bool ArmLengthOffsetCurve_IsValid;

	private static int ArmLengthOffsetCurve_Offset;

	private static bool EnableFOVOffset_IsValid;

	private static int EnableFOVOffset_Offset;

	private static FFieldAddress EnableFOVOffset_PropertyAddress;

	private static bool FOVOffsetCurve_IsValid;

	private static int FOVOffsetCurve_Offset;

	public FGSCameraOffsetSetting Copy()
	{
		return this;
	}

	public static FGSCameraOffsetSetting FromNative(IntPtr nativeBuffer)
	{
		return new FGSCameraOffsetSetting(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSCameraOffsetSetting value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSCameraOffsetSetting FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSCameraOffsetSetting(IntPtr.Add(nativeBuffer, arrayIndex * FGSCameraOffsetSetting_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSCameraOffsetSetting value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSCameraOffsetSetting_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSCameraOffsetSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSCameraOffsetSetting");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableArmLength_Offset), 0, EnableArmLength_PropertyAddress.Address, EnableArmLength);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, ArmLengthOffsetCurve_Offset), ArmLengthOffsetCurve);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableFOVOffset_Offset), 0, EnableFOVOffset_PropertyAddress.Address, EnableFOVOffset);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, FOVOffsetCurve_Offset), FOVOffsetCurve);
	}

	public FGSCameraOffsetSetting(IntPtr nativeStruct)
	{
		if (FGSCameraOffsetSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSCameraOffsetSetting");
			EnableArmLength = false;
			ArmLengthOffsetCurve = null;
			EnableFOVOffset = false;
			FOVOffsetCurve = null;
		}
		else
		{
			EnableArmLength = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableArmLength_Offset), 0, EnableArmLength_PropertyAddress.Address);
			ArmLengthOffsetCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, ArmLengthOffsetCurve_Offset));
			EnableFOVOffset = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableFOVOffset_Offset), 0, EnableFOVOffset_PropertyAddress.Address);
			FOVOffsetCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, FOVOffsetCurve_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSCameraOffsetSetting");
		FGSCameraOffsetSetting_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref EnableArmLength_PropertyAddress, intPtr, "EnableArmLength");
		EnableArmLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableArmLength");
		EnableArmLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableArmLength", Classes.FBoolProperty);
		ArmLengthOffsetCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "ArmLengthOffsetCurve");
		ArmLengthOffsetCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ArmLengthOffsetCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref EnableFOVOffset_PropertyAddress, intPtr, "EnableFOVOffset");
		EnableFOVOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableFOVOffset");
		EnableFOVOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableFOVOffset", Classes.FBoolProperty);
		FOVOffsetCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "FOVOffsetCurve");
		FOVOffsetCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FOVOffsetCurve", Classes.FObjectProperty);
		FGSCameraOffsetSetting_IsValid = ((intPtr != IntPtr.Zero && EnableArmLength_IsValid && ArmLengthOffsetCurve_IsValid && EnableFOVOffset_IsValid && FOVOffsetCurve_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSCameraOffsetSetting", (byte)FGSCameraOffsetSetting_IsValid != 0);
	}

	static FGSCameraOffsetSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSCameraOffsetSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSCameraOffsetSetting));
	}
}
