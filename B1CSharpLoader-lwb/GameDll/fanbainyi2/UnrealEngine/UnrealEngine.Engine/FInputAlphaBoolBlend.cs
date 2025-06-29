using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.InputAlphaBoolBlend", "Engine", UnrealModuleType.Engine)]
public struct FInputAlphaBoolBlend
{
	private static bool BlendInTime_IsValid;

	private static int BlendInTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputAlphaBoolBlend:BlendInTime")]
	public float BlendInTime;

	private static bool BlendOutTime_IsValid;

	private static int BlendOutTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputAlphaBoolBlend:BlendOutTime")]
	public float BlendOutTime;

	private static bool BlendOption_IsValid;

	private static FFieldAddress BlendOption_PropertyAddress;

	private static int BlendOption_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputAlphaBoolBlend:BlendOption")]
	public EAlphaBlendOption BlendOption;

	private static bool CustomCurve_IsValid;

	private static int CustomCurve_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.InputAlphaBoolBlend:CustomCurve")]
	public UCurveFloat CustomCurve;

	private static bool FInputAlphaBoolBlend_IsValid;

	private static int FInputAlphaBoolBlend_StructSize;

	public FInputAlphaBoolBlend Copy()
	{
		return this;
	}

	public static FInputAlphaBoolBlend FromNative(IntPtr nativeBuffer)
	{
		return new FInputAlphaBoolBlend(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputAlphaBoolBlend value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputAlphaBoolBlend FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputAlphaBoolBlend(nativeBuffer + arrayIndex * FInputAlphaBoolBlend_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputAlphaBoolBlend value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInputAlphaBoolBlend_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInputAlphaBoolBlend_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputAlphaBoolBlend");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendInTime_Offset), BlendInTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendOutTime_Offset), BlendOutTime);
		EnumMarshaler<EAlphaBlendOption>.ToNative(IntPtr.Add(nativeStruct, BlendOption_Offset), 0, BlendOption_PropertyAddress.Address, BlendOption);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, CustomCurve_Offset), CustomCurve);
	}

	public FInputAlphaBoolBlend(IntPtr nativeStruct)
	{
		if (!FInputAlphaBoolBlend_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputAlphaBoolBlend");
			BlendInTime = 0f;
			BlendOutTime = 0f;
			BlendOption = EAlphaBlendOption.Linear;
			CustomCurve = null;
		}
		else
		{
			BlendInTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendInTime_Offset));
			BlendOutTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendOutTime_Offset));
			BlendOption = EnumMarshaler<EAlphaBlendOption>.FromNative(IntPtr.Add(nativeStruct, BlendOption_Offset), 0, BlendOption_PropertyAddress.Address);
			CustomCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, CustomCurve_Offset));
		}
	}

	static FInputAlphaBoolBlend()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInputAlphaBoolBlend)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputAlphaBoolBlend));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.InputAlphaBoolBlend");
		FInputAlphaBoolBlend_StructSize = NativeReflection.GetStructSize(intPtr);
		BlendInTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendInTime");
		BlendInTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendInTime", Classes.FFloatProperty);
		BlendOutTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendOutTime");
		BlendOutTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendOutTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendOption_PropertyAddress, intPtr, "BlendOption");
		BlendOption_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendOption");
		BlendOption_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendOption", Classes.FEnumProperty);
		CustomCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomCurve");
		CustomCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomCurve", Classes.FObjectProperty);
		FInputAlphaBoolBlend_IsValid = intPtr != IntPtr.Zero && BlendInTime_IsValid && BlendOutTime_IsValid && BlendOption_IsValid && CustomCurve_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.InputAlphaBoolBlend", FInputAlphaBoolBlend_IsValid);
	}
}
