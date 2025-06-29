using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.CameraShakeScrubParams", "Engine", UnrealModuleType.Engine)]
public struct FCameraShakeScrubParams
{
	private static bool AbsoluteTime_IsValid;

	private static int AbsoluteTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CameraShakeScrubParams:AbsoluteTime")]
	public float AbsoluteTime;

	private static bool ShakeScale_IsValid;

	private static int ShakeScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CameraShakeScrubParams:ShakeScale")]
	public float ShakeScale;

	private static bool DynamicScale_IsValid;

	private static int DynamicScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CameraShakeScrubParams:DynamicScale")]
	public float DynamicScale;

	private static bool BlendingWeight_IsValid;

	private static int BlendingWeight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CameraShakeScrubParams:BlendingWeight")]
	public float BlendingWeight;

	private static bool POV_IsValid;

	private static int POV_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Engine.CameraShakeScrubParams:POV")]
	public FMinimalViewInfo POV;

	private static bool FCameraShakeScrubParams_IsValid;

	private static int FCameraShakeScrubParams_StructSize;

	public FCameraShakeScrubParams Copy()
	{
		return this;
	}

	public static FCameraShakeScrubParams FromNative(IntPtr nativeBuffer)
	{
		return new FCameraShakeScrubParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCameraShakeScrubParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCameraShakeScrubParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCameraShakeScrubParams(nativeBuffer + arrayIndex * FCameraShakeScrubParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCameraShakeScrubParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCameraShakeScrubParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCameraShakeScrubParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CameraShakeScrubParams");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AbsoluteTime_Offset), AbsoluteTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ShakeScale_Offset), ShakeScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DynamicScale_Offset), DynamicScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendingWeight_Offset), BlendingWeight);
		FMinimalViewInfo.ToNative(IntPtr.Add(nativeStruct, POV_Offset), POV);
	}

	public FCameraShakeScrubParams(IntPtr nativeStruct)
	{
		if (!FCameraShakeScrubParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CameraShakeScrubParams");
			AbsoluteTime = 0f;
			ShakeScale = 0f;
			DynamicScale = 0f;
			BlendingWeight = 0f;
			POV = default(FMinimalViewInfo);
		}
		else
		{
			AbsoluteTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AbsoluteTime_Offset));
			ShakeScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ShakeScale_Offset));
			DynamicScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DynamicScale_Offset));
			BlendingWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendingWeight_Offset));
			POV = FMinimalViewInfo.FromNative(IntPtr.Add(nativeStruct, POV_Offset));
		}
	}

	static FCameraShakeScrubParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCameraShakeScrubParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCameraShakeScrubParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CameraShakeScrubParams");
		FCameraShakeScrubParams_StructSize = NativeReflection.GetStructSize(intPtr);
		AbsoluteTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AbsoluteTime");
		AbsoluteTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AbsoluteTime", Classes.FFloatProperty);
		ShakeScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShakeScale");
		ShakeScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShakeScale", Classes.FFloatProperty);
		DynamicScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DynamicScale");
		DynamicScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DynamicScale", Classes.FFloatProperty);
		BlendingWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendingWeight");
		BlendingWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendingWeight", Classes.FFloatProperty);
		POV_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "POV");
		POV_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "POV", Classes.FStructProperty);
		FCameraShakeScrubParams_IsValid = intPtr != IntPtr.Zero && AbsoluteTime_IsValid && ShakeScale_IsValid && DynamicScale_IsValid && BlendingWeight_IsValid && POV_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CameraShakeScrubParams", FCameraShakeScrubParams_IsValid);
	}
}
