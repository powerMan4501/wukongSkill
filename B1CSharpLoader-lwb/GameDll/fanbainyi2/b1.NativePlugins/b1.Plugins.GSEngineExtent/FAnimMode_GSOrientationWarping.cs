using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEngineExtent;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GSEngineExtent.AnimMode_GSOrientationWarping", "GSEngineExtent", UnrealModuleType.GamePlugin)]
public struct FAnimMode_GSOrientationWarping
{
	private static bool BasePose_IsValid;

	private static int BasePose_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/GSEngineExtent.AnimMode_GSOrientationWarping:BasePose")]
	public FPoseLink BasePose;

	private static bool LocomotionAngle_IsValid;

	private static int LocomotionAngle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEngineExtent.AnimMode_GSOrientationWarping:LocomotionAngle")]
	public float LocomotionAngle;

	private static bool Settings_IsValid;

	private static int Settings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/GSEngineExtent.AnimMode_GSOrientationWarping:Settings")]
	public FAxisSettings Settings;

	private static bool FAnimMode_GSOrientationWarping_IsValid;

	private static int FAnimMode_GSOrientationWarping_StructSize;

	public FAnimMode_GSOrientationWarping Copy()
	{
		return this;
	}

	public static FAnimMode_GSOrientationWarping FromNative(IntPtr nativeBuffer)
	{
		return new FAnimMode_GSOrientationWarping(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimMode_GSOrientationWarping value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimMode_GSOrientationWarping FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimMode_GSOrientationWarping(nativeBuffer + arrayIndex * FAnimMode_GSOrientationWarping_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimMode_GSOrientationWarping value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimMode_GSOrientationWarping_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimMode_GSOrientationWarping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEngineExtent.AnimMode_GSOrientationWarping");
			return;
		}
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, BasePose_Offset), BasePose);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LocomotionAngle_Offset), LocomotionAngle);
		FAxisSettings.ToNative(IntPtr.Add(nativeStruct, Settings_Offset), Settings);
	}

	public FAnimMode_GSOrientationWarping(IntPtr nativeStruct)
	{
		if (!FAnimMode_GSOrientationWarping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEngineExtent.AnimMode_GSOrientationWarping");
			BasePose = default(FPoseLink);
			LocomotionAngle = 0f;
			Settings = default(FAxisSettings);
		}
		else
		{
			BasePose = FPoseLink.FromNative(IntPtr.Add(nativeStruct, BasePose_Offset));
			LocomotionAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LocomotionAngle_Offset));
			Settings = FAxisSettings.FromNative(IntPtr.Add(nativeStruct, Settings_Offset));
		}
	}

	static FAnimMode_GSOrientationWarping()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimMode_GSOrientationWarping)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimMode_GSOrientationWarping));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSEngineExtent.AnimMode_GSOrientationWarping");
		FAnimMode_GSOrientationWarping_StructSize = NativeReflection.GetStructSize(intPtr);
		BasePose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BasePose");
		BasePose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BasePose", Classes.FStructProperty);
		LocomotionAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocomotionAngle");
		LocomotionAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocomotionAngle", Classes.FFloatProperty);
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		FAnimMode_GSOrientationWarping_IsValid = intPtr != IntPtr.Zero && BasePose_IsValid && LocomotionAngle_IsValid && Settings_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSEngineExtent.AnimMode_GSOrientationWarping", FAnimMode_GSOrientationWarping_IsValid);
	}
}
