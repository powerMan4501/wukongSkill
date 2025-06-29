using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.CinematicCamera;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/CinematicCamera.CameraRig_Rail", "CinematicCamera", UnrealModuleType.Engine)]
public class ACameraRig_Rail : AActor
{
	private static bool CurrentPositionOnRail_IsValid;

	private static int CurrentPositionOnRail_Offset;

	private static bool LockOrientationToRail_IsValid;

	private static FFieldAddress LockOrientationToRail_PropertyAddress;

	private static int LockOrientationToRail_Offset;

	private static bool GetRailSplineComponent_IsValid;

	private static IntPtr GetRailSplineComponent_FunctionAddress;

	private static int GetRailSplineComponent_ParamsSize;

	private static bool GetRailSplineComponent_ReturnValue_IsValid;

	private static FFieldAddress GetRailSplineComponent_ReturnValue_PropertyAddress;

	private static int GetRailSplineComponent_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/CinematicCamera.CameraRig_Rail:CurrentPositionOnRail")]
	public float CurrentPositionOnRail
	{
		get
		{
			CheckDestroyed();
			if (!CurrentPositionOnRail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CameraRig_Rail:CurrentPositionOnRail");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CurrentPositionOnRail_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurrentPositionOnRail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CameraRig_Rail:CurrentPositionOnRail");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CurrentPositionOnRail_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/CinematicCamera.CameraRig_Rail:bLockOrientationToRail")]
	public bool LockOrientationToRail
	{
		get
		{
			CheckDestroyed();
			if (!LockOrientationToRail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CameraRig_Rail:bLockOrientationToRail");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LockOrientationToRail_Offset), 0, LockOrientationToRail_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LockOrientationToRail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CameraRig_Rail:bLockOrientationToRail");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LockOrientationToRail_Offset), 0, LockOrientationToRail_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/CinematicCamera.CameraRig_Rail:GetRailSplineComponent")]
	public unsafe USplineComponent GetRailSplineComponent()
	{
		CheckDestroyed();
		if (!GetRailSplineComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicCamera.CameraRig_Rail:GetRailSplineComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRailSplineComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRailSplineComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRailSplineComponent_FunctionAddress, intPtr, GetRailSplineComponent_ParamsSize);
		return UObjectMarshaler<USplineComponent>.FromNative(IntPtr.Add(intPtr, GetRailSplineComponent_ReturnValue_Offset), 0, GetRailSplineComponent_ReturnValue_PropertyAddress.Address);
	}

	static ACameraRig_Rail()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACameraRig_Rail)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACameraRig_Rail));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/CinematicCamera.CameraRig_Rail");
		CurrentPositionOnRail_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentPositionOnRail");
		CurrentPositionOnRail_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentPositionOnRail", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref LockOrientationToRail_PropertyAddress, intPtr, "bLockOrientationToRail");
		LockOrientationToRail_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLockOrientationToRail");
		LockOrientationToRail_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLockOrientationToRail", Classes.FBoolProperty);
		GetRailSplineComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRailSplineComponent");
		GetRailSplineComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRailSplineComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRailSplineComponent_ReturnValue_PropertyAddress, GetRailSplineComponent_FunctionAddress, "ReturnValue");
		GetRailSplineComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRailSplineComponent_FunctionAddress, "ReturnValue");
		GetRailSplineComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRailSplineComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetRailSplineComponent_IsValid = GetRailSplineComponent_FunctionAddress != IntPtr.Zero && GetRailSplineComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicCamera.CameraRig_Rail:GetRailSplineComponent", GetRailSplineComponent_IsValid);
	}
}
