using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 266753)]
[BlueprintType]
[UMetaPath("/Script/Engine.InteriorSettings", "Engine", UnrealModuleType.Engine)]
public struct FInteriorSettings
{
	private static bool ExteriorVolume_IsValid;

	private static int ExteriorVolume_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InteriorSettings:ExteriorVolume")]
	public float ExteriorVolume;

	private static bool ExteriorTime_IsValid;

	private static int ExteriorTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InteriorSettings:ExteriorTime")]
	public float ExteriorTime;

	private static bool ExteriorLPF_IsValid;

	private static int ExteriorLPF_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InteriorSettings:ExteriorLPF")]
	public float ExteriorLPF;

	private static bool ExteriorLPFTime_IsValid;

	private static int ExteriorLPFTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InteriorSettings:ExteriorLPFTime")]
	public float ExteriorLPFTime;

	private static bool InteriorVolume_IsValid;

	private static int InteriorVolume_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InteriorSettings:InteriorVolume")]
	public float InteriorVolume;

	private static bool InteriorTime_IsValid;

	private static int InteriorTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InteriorSettings:InteriorTime")]
	public float InteriorTime;

	private static bool InteriorLPF_IsValid;

	private static int InteriorLPF_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InteriorSettings:InteriorLPF")]
	public float InteriorLPF;

	private static bool InteriorLPFTime_IsValid;

	private static int InteriorLPFTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InteriorSettings:InteriorLPFTime")]
	public float InteriorLPFTime;

	private static bool FInteriorSettings_IsValid;

	private static int FInteriorSettings_StructSize;

	public FInteriorSettings Copy()
	{
		return this;
	}

	public static FInteriorSettings FromNative(IntPtr nativeBuffer)
	{
		return new FInteriorSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInteriorSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInteriorSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInteriorSettings(nativeBuffer + arrayIndex * FInteriorSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInteriorSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInteriorSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInteriorSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InteriorSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ExteriorVolume_Offset), ExteriorVolume);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ExteriorTime_Offset), ExteriorTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ExteriorLPF_Offset), ExteriorLPF);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ExteriorLPFTime_Offset), ExteriorLPFTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InteriorVolume_Offset), InteriorVolume);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InteriorTime_Offset), InteriorTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InteriorLPF_Offset), InteriorLPF);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InteriorLPFTime_Offset), InteriorLPFTime);
	}

	public FInteriorSettings(IntPtr nativeStruct)
	{
		if (!FInteriorSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InteriorSettings");
			ExteriorVolume = 0f;
			ExteriorTime = 0f;
			ExteriorLPF = 0f;
			ExteriorLPFTime = 0f;
			InteriorVolume = 0f;
			InteriorTime = 0f;
			InteriorLPF = 0f;
			InteriorLPFTime = 0f;
		}
		else
		{
			ExteriorVolume = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ExteriorVolume_Offset));
			ExteriorTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ExteriorTime_Offset));
			ExteriorLPF = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ExteriorLPF_Offset));
			ExteriorLPFTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ExteriorLPFTime_Offset));
			InteriorVolume = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InteriorVolume_Offset));
			InteriorTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InteriorTime_Offset));
			InteriorLPF = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InteriorLPF_Offset));
			InteriorLPFTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InteriorLPFTime_Offset));
		}
	}

	static FInteriorSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInteriorSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInteriorSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.InteriorSettings");
		FInteriorSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		ExteriorVolume_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExteriorVolume");
		ExteriorVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExteriorVolume", Classes.FFloatProperty);
		ExteriorTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExteriorTime");
		ExteriorTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExteriorTime", Classes.FFloatProperty);
		ExteriorLPF_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExteriorLPF");
		ExteriorLPF_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExteriorLPF", Classes.FFloatProperty);
		ExteriorLPFTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExteriorLPFTime");
		ExteriorLPFTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExteriorLPFTime", Classes.FFloatProperty);
		InteriorVolume_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InteriorVolume");
		InteriorVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InteriorVolume", Classes.FFloatProperty);
		InteriorTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InteriorTime");
		InteriorTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InteriorTime", Classes.FFloatProperty);
		InteriorLPF_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InteriorLPF");
		InteriorLPF_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InteriorLPF", Classes.FFloatProperty);
		InteriorLPFTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InteriorLPFTime");
		InteriorLPFTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InteriorLPFTime", Classes.FFloatProperty);
		FInteriorSettings_IsValid = intPtr != IntPtr.Zero && ExteriorVolume_IsValid && ExteriorTime_IsValid && ExteriorLPF_IsValid && ExteriorLPFTime_IsValid && InteriorVolume_IsValid && InteriorTime_IsValid && InteriorLPF_IsValid && InteriorLPFTime_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.InteriorSettings", FInteriorSettings_IsValid);
	}
}
