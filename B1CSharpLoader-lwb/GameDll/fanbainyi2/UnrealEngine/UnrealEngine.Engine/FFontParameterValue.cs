using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.FontParameterValue", "Engine", UnrealModuleType.Engine)]
public struct FFontParameterValue
{
	private static bool ParameterInfo_IsValid;

	private static int ParameterInfo_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.FontParameterValue:ParameterInfo")]
	public FMaterialParameterInfo ParameterInfo;

	private static bool FontValue_IsValid;

	private static int FontValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.FontParameterValue:FontValue")]
	public UFont FontValue;

	private static bool FontPage_IsValid;

	private static int FontPage_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.FontParameterValue:FontPage")]
	public int FontPage;

	private static bool FFontParameterValue_IsValid;

	private static int FFontParameterValue_StructSize;

	public FFontParameterValue Copy()
	{
		return this;
	}

	public static FFontParameterValue FromNative(IntPtr nativeBuffer)
	{
		return new FFontParameterValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFontParameterValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFontParameterValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFontParameterValue(nativeBuffer + arrayIndex * FFontParameterValue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFontParameterValue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFontParameterValue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFontParameterValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FontParameterValue");
			return;
		}
		FMaterialParameterInfo.ToNative(IntPtr.Add(nativeStruct, ParameterInfo_Offset), ParameterInfo);
		UObjectMarshaler<UFont>.ToNative(IntPtr.Add(nativeStruct, FontValue_Offset), FontValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FontPage_Offset), FontPage);
	}

	public FFontParameterValue(IntPtr nativeStruct)
	{
		if (!FFontParameterValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FontParameterValue");
			ParameterInfo = default(FMaterialParameterInfo);
			FontValue = null;
			FontPage = 0;
		}
		else
		{
			ParameterInfo = FMaterialParameterInfo.FromNative(IntPtr.Add(nativeStruct, ParameterInfo_Offset));
			FontValue = UObjectMarshaler<UFont>.FromNative(IntPtr.Add(nativeStruct, FontValue_Offset));
			FontPage = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FontPage_Offset));
		}
	}

	static FFontParameterValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFontParameterValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFontParameterValue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.FontParameterValue");
		FFontParameterValue_StructSize = NativeReflection.GetStructSize(intPtr);
		ParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParameterInfo");
		ParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParameterInfo", Classes.FStructProperty);
		FontValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FontValue");
		FontValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FontValue", Classes.FObjectProperty);
		FontPage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FontPage");
		FontPage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FontPage", Classes.FIntProperty);
		FFontParameterValue_IsValid = intPtr != IntPtr.Zero && ParameterInfo_IsValid && FontValue_IsValid && FontPage_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.FontParameterValue", FFontParameterValue_IsValid);
	}
}
