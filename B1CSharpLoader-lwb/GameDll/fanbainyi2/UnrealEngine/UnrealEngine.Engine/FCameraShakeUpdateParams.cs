using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.CameraShakeUpdateParams", "Engine", UnrealModuleType.Engine)]
public struct FCameraShakeUpdateParams
{
	private static bool DeltaTime_IsValid;

	private static int DeltaTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CameraShakeUpdateParams:DeltaTime")]
	public float DeltaTime;

	private static bool ShakeScale_IsValid;

	private static int ShakeScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CameraShakeUpdateParams:ShakeScale")]
	public float ShakeScale;

	private static bool DynamicScale_IsValid;

	private static int DynamicScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CameraShakeUpdateParams:DynamicScale")]
	public float DynamicScale;

	private static bool BlendingWeight_IsValid;

	private static int BlendingWeight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CameraShakeUpdateParams:BlendingWeight")]
	public float BlendingWeight;

	private static bool POV_IsValid;

	private static int POV_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Engine.CameraShakeUpdateParams:POV")]
	public FMinimalViewInfo POV;

	private static bool FCameraShakeUpdateParams_IsValid;

	private static int FCameraShakeUpdateParams_StructSize;

	public FCameraShakeUpdateParams Copy()
	{
		return this;
	}

	public static FCameraShakeUpdateParams FromNative(IntPtr nativeBuffer)
	{
		return new FCameraShakeUpdateParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCameraShakeUpdateParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCameraShakeUpdateParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCameraShakeUpdateParams(nativeBuffer + arrayIndex * FCameraShakeUpdateParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCameraShakeUpdateParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCameraShakeUpdateParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCameraShakeUpdateParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CameraShakeUpdateParams");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DeltaTime_Offset), DeltaTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ShakeScale_Offset), ShakeScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DynamicScale_Offset), DynamicScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendingWeight_Offset), BlendingWeight);
		FMinimalViewInfo.ToNative(IntPtr.Add(nativeStruct, POV_Offset), POV);
	}

	public FCameraShakeUpdateParams(IntPtr nativeStruct)
	{
		if (!FCameraShakeUpdateParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CameraShakeUpdateParams");
			DeltaTime = 0f;
			ShakeScale = 0f;
			DynamicScale = 0f;
			BlendingWeight = 0f;
			POV = default(FMinimalViewInfo);
		}
		else
		{
			DeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DeltaTime_Offset));
			ShakeScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ShakeScale_Offset));
			DynamicScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DynamicScale_Offset));
			BlendingWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendingWeight_Offset));
			POV = FMinimalViewInfo.FromNative(IntPtr.Add(nativeStruct, POV_Offset));
		}
	}

	static FCameraShakeUpdateParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCameraShakeUpdateParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCameraShakeUpdateParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CameraShakeUpdateParams");
		FCameraShakeUpdateParams_StructSize = NativeReflection.GetStructSize(intPtr);
		DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DeltaTime");
		DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DeltaTime", Classes.FFloatProperty);
		ShakeScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShakeScale");
		ShakeScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShakeScale", Classes.FFloatProperty);
		DynamicScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DynamicScale");
		DynamicScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DynamicScale", Classes.FFloatProperty);
		BlendingWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendingWeight");
		BlendingWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendingWeight", Classes.FFloatProperty);
		POV_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "POV");
		POV_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "POV", Classes.FStructProperty);
		FCameraShakeUpdateParams_IsValid = intPtr != IntPtr.Zero && DeltaTime_IsValid && ShakeScale_IsValid && DynamicScale_IsValid && BlendingWeight_IsValid && POV_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CameraShakeUpdateParams", FCameraShakeUpdateParams_IsValid);
	}
}
