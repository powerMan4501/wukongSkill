using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.DispInteractOverride")]
public struct DispInteractOverride
{
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispInteractOverride:FirstBoneName")]
	public FName FirstBoneName;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispInteractOverride:NextBoneName")]
	public FName NextBoneName;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispInteractOverride:FirstScaleValue")]
	public float FirstScaleValue;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispInteractOverride:NextScaleValue")]
	public float NextScaleValue;

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "ScaleUseCurve")]
	[USharpPath("/Script/b1-Managed.DispInteractOverride:FirstScaleCurve")]
	public UCurveFloat FirstScaleCurve;

	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "ScaleUseCurve")]
	[USharpPath("/Script/b1-Managed.DispInteractOverride:NextScaleCurve")]
	public UCurveFloat NextScaleCurve;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispInteractOverride:FirstOffsetValue")]
	public float FirstOffsetValue;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispInteractOverride:NextOffsetValue")]
	public float NextOffsetValue;

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "OffsetUseCurve")]
	[USharpPath("/Script/b1-Managed.DispInteractOverride:FirstOffsetCurve")]
	public UCurveFloat FirstOffsetCurve;

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "OffsetUseCurve")]
	[USharpPath("/Script/b1-Managed.DispInteractOverride:NextOffsetCurve")]
	public UCurveFloat NextOffsetCurve;

	public float StartTime;

	private static int DispInteractOverride_StructSize;

	private static int DispInteractOverride_IsValid;

	private static bool FirstBoneName_IsValid;

	private static int FirstBoneName_Offset;

	private static bool NextBoneName_IsValid;

	private static int NextBoneName_Offset;

	private static bool FirstScaleValue_IsValid;

	private static int FirstScaleValue_Offset;

	private static bool NextScaleValue_IsValid;

	private static int NextScaleValue_Offset;

	private static bool FirstScaleCurve_IsValid;

	private static int FirstScaleCurve_Offset;

	private static bool NextScaleCurve_IsValid;

	private static int NextScaleCurve_Offset;

	private static bool FirstOffsetValue_IsValid;

	private static int FirstOffsetValue_Offset;

	private static bool NextOffsetValue_IsValid;

	private static int NextOffsetValue_Offset;

	private static bool FirstOffsetCurve_IsValid;

	private static int FirstOffsetCurve_Offset;

	private static bool NextOffsetCurve_IsValid;

	private static int NextOffsetCurve_Offset;

	public DispInteractOverride Copy()
	{
		return this;
	}

	public static DispInteractOverride FromNative(IntPtr nativeBuffer)
	{
		return new DispInteractOverride(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, DispInteractOverride value)
	{
		value.ToNative(nativeBuffer);
	}

	public static DispInteractOverride FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new DispInteractOverride(IntPtr.Add(nativeBuffer, arrayIndex * DispInteractOverride_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, DispInteractOverride value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DispInteractOverride_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DispInteractOverride_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DispInteractOverride");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, FirstBoneName_Offset), FirstBoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, NextBoneName_Offset), NextBoneName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FirstScaleValue_Offset), FirstScaleValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NextScaleValue_Offset), NextScaleValue);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, FirstScaleCurve_Offset), FirstScaleCurve);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, NextScaleCurve_Offset), NextScaleCurve);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FirstOffsetValue_Offset), FirstOffsetValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NextOffsetValue_Offset), NextOffsetValue);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, FirstOffsetCurve_Offset), FirstOffsetCurve);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, NextOffsetCurve_Offset), NextOffsetCurve);
	}

	public DispInteractOverride(IntPtr nativeStruct)
	{
		if (DispInteractOverride_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DispInteractOverride");
			FirstBoneName = default(FName);
			NextBoneName = default(FName);
			FirstScaleValue = 0f;
			NextScaleValue = 0f;
			FirstScaleCurve = null;
			NextScaleCurve = null;
			FirstOffsetValue = 0f;
			NextOffsetValue = 0f;
			FirstOffsetCurve = null;
			NextOffsetCurve = null;
		}
		else
		{
			FirstBoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, FirstBoneName_Offset));
			NextBoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, NextBoneName_Offset));
			FirstScaleValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FirstScaleValue_Offset));
			NextScaleValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NextScaleValue_Offset));
			FirstScaleCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, FirstScaleCurve_Offset));
			NextScaleCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, NextScaleCurve_Offset));
			FirstOffsetValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FirstOffsetValue_Offset));
			NextOffsetValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NextOffsetValue_Offset));
			FirstOffsetCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, FirstOffsetCurve_Offset));
			NextOffsetCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, NextOffsetCurve_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DispInteractOverride");
		DispInteractOverride_StructSize = NativeReflection.GetStructSize(intPtr);
		FirstBoneName_Offset = NativeReflection.GetPropertyOffset(intPtr, "FirstBoneName");
		FirstBoneName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FirstBoneName", Classes.FNameProperty);
		NextBoneName_Offset = NativeReflection.GetPropertyOffset(intPtr, "NextBoneName");
		NextBoneName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NextBoneName", Classes.FNameProperty);
		FirstScaleValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "FirstScaleValue");
		FirstScaleValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FirstScaleValue", Classes.FFloatProperty);
		NextScaleValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "NextScaleValue");
		NextScaleValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NextScaleValue", Classes.FFloatProperty);
		FirstScaleCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "FirstScaleCurve");
		FirstScaleCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FirstScaleCurve", Classes.FObjectProperty);
		NextScaleCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "NextScaleCurve");
		NextScaleCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NextScaleCurve", Classes.FObjectProperty);
		FirstOffsetValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "FirstOffsetValue");
		FirstOffsetValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FirstOffsetValue", Classes.FFloatProperty);
		NextOffsetValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "NextOffsetValue");
		NextOffsetValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NextOffsetValue", Classes.FFloatProperty);
		FirstOffsetCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "FirstOffsetCurve");
		FirstOffsetCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FirstOffsetCurve", Classes.FObjectProperty);
		NextOffsetCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "NextOffsetCurve");
		NextOffsetCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NextOffsetCurve", Classes.FObjectProperty);
		DispInteractOverride_IsValid = ((intPtr != IntPtr.Zero && FirstBoneName_IsValid && NextBoneName_IsValid && FirstScaleValue_IsValid && NextScaleValue_IsValid && FirstScaleCurve_IsValid && NextScaleCurve_IsValid && FirstOffsetValue_IsValid && NextOffsetValue_IsValid && FirstOffsetCurve_IsValid && NextOffsetCurve_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DispInteractOverride", (byte)DispInteractOverride_IsValid != 0);
	}

	static DispInteractOverride()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispInteractOverride)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispInteractOverride));
	}
}
