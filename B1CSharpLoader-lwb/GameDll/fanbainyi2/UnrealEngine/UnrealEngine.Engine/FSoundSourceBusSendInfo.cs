using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundSourceBusSendInfo", "Engine", UnrealModuleType.Engine)]
public struct FSoundSourceBusSendInfo
{
	private static bool MinSendLevel_IsValid;

	private static int MinSendLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundSourceBusSendInfo:MinSendLevel")]
	public float MinSendLevel;

	private static bool MaxSendLevel_IsValid;

	private static int MaxSendLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundSourceBusSendInfo:MaxSendLevel")]
	public float MaxSendLevel;

	private static bool MinSendDistance_IsValid;

	private static int MinSendDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundSourceBusSendInfo:MinSendDistance")]
	public float MinSendDistance;

	private static bool MaxSendDistance_IsValid;

	private static int MaxSendDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundSourceBusSendInfo:MaxSendDistance")]
	public float MaxSendDistance;

	private static bool CustomSendLevelCurve_IsValid;

	private static int CustomSendLevelCurve_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Engine.SoundSourceBusSendInfo:CustomSendLevelCurve")]
	public FRuntimeFloatCurve CustomSendLevelCurve;

	private static bool FSoundSourceBusSendInfo_IsValid;

	private static int FSoundSourceBusSendInfo_StructSize;

	public FSoundSourceBusSendInfo Copy()
	{
		return this;
	}

	public static FSoundSourceBusSendInfo FromNative(IntPtr nativeBuffer)
	{
		return new FSoundSourceBusSendInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSoundSourceBusSendInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSoundSourceBusSendInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSoundSourceBusSendInfo(nativeBuffer + arrayIndex * FSoundSourceBusSendInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSoundSourceBusSendInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSoundSourceBusSendInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSoundSourceBusSendInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundSourceBusSendInfo");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinSendLevel_Offset), MinSendLevel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxSendLevel_Offset), MaxSendLevel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinSendDistance_Offset), MinSendDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxSendDistance_Offset), MaxSendDistance);
		FRuntimeFloatCurve.ToNative(IntPtr.Add(nativeStruct, CustomSendLevelCurve_Offset), CustomSendLevelCurve);
	}

	public FSoundSourceBusSendInfo(IntPtr nativeStruct)
	{
		if (!FSoundSourceBusSendInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundSourceBusSendInfo");
			MinSendLevel = 0f;
			MaxSendLevel = 0f;
			MinSendDistance = 0f;
			MaxSendDistance = 0f;
			CustomSendLevelCurve = default(FRuntimeFloatCurve);
		}
		else
		{
			MinSendLevel = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinSendLevel_Offset));
			MaxSendLevel = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxSendLevel_Offset));
			MinSendDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinSendDistance_Offset));
			MaxSendDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxSendDistance_Offset));
			CustomSendLevelCurve = FRuntimeFloatCurve.FromNative(IntPtr.Add(nativeStruct, CustomSendLevelCurve_Offset));
		}
	}

	static FSoundSourceBusSendInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSoundSourceBusSendInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSoundSourceBusSendInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SoundSourceBusSendInfo");
		FSoundSourceBusSendInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		MinSendLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinSendLevel");
		MinSendLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinSendLevel", Classes.FFloatProperty);
		MaxSendLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxSendLevel");
		MaxSendLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxSendLevel", Classes.FFloatProperty);
		MinSendDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinSendDistance");
		MinSendDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinSendDistance", Classes.FFloatProperty);
		MaxSendDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxSendDistance");
		MaxSendDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxSendDistance", Classes.FFloatProperty);
		CustomSendLevelCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomSendLevelCurve");
		CustomSendLevelCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomSendLevelCurve", Classes.FStructProperty);
		FSoundSourceBusSendInfo_IsValid = intPtr != IntPtr.Zero && MinSendLevel_IsValid && MaxSendLevel_IsValid && MinSendDistance_IsValid && MaxSendDistance_IsValid && CustomSendLevelCurve_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SoundSourceBusSendInfo", FSoundSourceBusSendInfo_IsValid);
	}
}
