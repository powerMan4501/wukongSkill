using System;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.LandCamShake")]
public struct FLandCamShake
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.LandCamShake:CameraShake_Mid")]
	public TSubclassOf<UMatineeCameraShake> CameraShake_Mid;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.LandCamShake:CameraShake_High")]
	public TSubclassOf<UMatineeCameraShake> CameraShake_High;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.LandCamShake:CameraShake_Dead")]
	public TSubclassOf<UMatineeCameraShake> CameraShake_Dead;

	private static int LandCamShake_StructSize;

	private static int LandCamShake_IsValid;

	private static bool CameraShake_Mid_IsValid;

	private static int CameraShake_Mid_Offset;

	private static bool CameraShake_High_IsValid;

	private static int CameraShake_High_Offset;

	private static bool CameraShake_Dead_IsValid;

	private static int CameraShake_Dead_Offset;

	public FLandCamShake Copy()
	{
		return this;
	}

	public static FLandCamShake FromNative(IntPtr nativeBuffer)
	{
		return new FLandCamShake(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLandCamShake value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLandCamShake FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLandCamShake(IntPtr.Add(nativeBuffer, arrayIndex * LandCamShake_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLandCamShake value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * LandCamShake_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (LandCamShake_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.LandCamShake");
			return;
		}
		TSubclassOfMarshaler<UMatineeCameraShake>.ToNative(IntPtr.Add(nativeStruct, CameraShake_Mid_Offset), CameraShake_Mid);
		TSubclassOfMarshaler<UMatineeCameraShake>.ToNative(IntPtr.Add(nativeStruct, CameraShake_High_Offset), CameraShake_High);
		TSubclassOfMarshaler<UMatineeCameraShake>.ToNative(IntPtr.Add(nativeStruct, CameraShake_Dead_Offset), CameraShake_Dead);
	}

	public FLandCamShake(IntPtr nativeStruct)
	{
		if (LandCamShake_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.LandCamShake");
			CameraShake_Mid = default(TSubclassOf<UMatineeCameraShake>);
			CameraShake_High = default(TSubclassOf<UMatineeCameraShake>);
			CameraShake_Dead = default(TSubclassOf<UMatineeCameraShake>);
		}
		else
		{
			CameraShake_Mid = TSubclassOfMarshaler<UMatineeCameraShake>.FromNative(IntPtr.Add(nativeStruct, CameraShake_Mid_Offset));
			CameraShake_High = TSubclassOfMarshaler<UMatineeCameraShake>.FromNative(IntPtr.Add(nativeStruct, CameraShake_High_Offset));
			CameraShake_Dead = TSubclassOfMarshaler<UMatineeCameraShake>.FromNative(IntPtr.Add(nativeStruct, CameraShake_Dead_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.LandCamShake");
		LandCamShake_StructSize = NativeReflection.GetStructSize(intPtr);
		CameraShake_Mid_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraShake_Mid");
		CameraShake_Mid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraShake_Mid", Classes.FClassProperty);
		CameraShake_High_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraShake_High");
		CameraShake_High_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraShake_High", Classes.FClassProperty);
		CameraShake_Dead_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraShake_Dead");
		CameraShake_Dead_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraShake_Dead", Classes.FClassProperty);
		LandCamShake_IsValid = ((intPtr != IntPtr.Zero && CameraShake_Mid_IsValid && CameraShake_High_IsValid && CameraShake_Dead_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.LandCamShake", (byte)LandCamShake_IsValid != 0);
	}

	static FLandCamShake()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FLandCamShake)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLandCamShake));
	}
}
