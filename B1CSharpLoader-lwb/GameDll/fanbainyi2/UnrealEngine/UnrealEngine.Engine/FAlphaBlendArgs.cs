using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AlphaBlendArgs", "Engine", UnrealModuleType.Engine)]
public struct FAlphaBlendArgs
{
	private static bool CustomCurve_IsValid;

	private static int CustomCurve_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.AlphaBlendArgs:CustomCurve")]
	public UCurveFloat CustomCurve;

	private static bool BlendTime_IsValid;

	private static int BlendTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AlphaBlendArgs:BlendTime")]
	public float BlendTime;

	private static bool BlendOption_IsValid;

	private static FFieldAddress BlendOption_PropertyAddress;

	private static int BlendOption_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AlphaBlendArgs:BlendOption")]
	public EAlphaBlendOption BlendOption;

	private static bool FAlphaBlendArgs_IsValid;

	private static int FAlphaBlendArgs_StructSize;

	public FAlphaBlendArgs Copy()
	{
		return this;
	}

	public static FAlphaBlendArgs FromNative(IntPtr nativeBuffer)
	{
		return new FAlphaBlendArgs(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAlphaBlendArgs value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAlphaBlendArgs FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAlphaBlendArgs(nativeBuffer + arrayIndex * FAlphaBlendArgs_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAlphaBlendArgs value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAlphaBlendArgs_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAlphaBlendArgs_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AlphaBlendArgs");
			return;
		}
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, CustomCurve_Offset), CustomCurve);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendTime_Offset), BlendTime);
		EnumMarshaler<EAlphaBlendOption>.ToNative(IntPtr.Add(nativeStruct, BlendOption_Offset), 0, BlendOption_PropertyAddress.Address, BlendOption);
	}

	public FAlphaBlendArgs(IntPtr nativeStruct)
	{
		if (!FAlphaBlendArgs_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AlphaBlendArgs");
			CustomCurve = null;
			BlendTime = 0f;
			BlendOption = EAlphaBlendOption.Linear;
		}
		else
		{
			CustomCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, CustomCurve_Offset));
			BlendTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendTime_Offset));
			BlendOption = EnumMarshaler<EAlphaBlendOption>.FromNative(IntPtr.Add(nativeStruct, BlendOption_Offset), 0, BlendOption_PropertyAddress.Address);
		}
	}

	static FAlphaBlendArgs()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAlphaBlendArgs)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAlphaBlendArgs));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AlphaBlendArgs");
		FAlphaBlendArgs_StructSize = NativeReflection.GetStructSize(intPtr);
		CustomCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomCurve");
		CustomCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomCurve", Classes.FObjectProperty);
		BlendTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendTime");
		BlendTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendOption_PropertyAddress, intPtr, "BlendOption");
		BlendOption_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendOption");
		BlendOption_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendOption", Classes.FEnumProperty);
		FAlphaBlendArgs_IsValid = intPtr != IntPtr.Zero && CustomCurve_IsValid && BlendTime_IsValid && BlendOption_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AlphaBlendArgs", FAlphaBlendArgs_IsValid);
	}
}
