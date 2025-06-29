using System;
using UnrealEngine.Runtime;

namespace b1.UI;

[UStruct]
[BlueprintType]
[DisplayName("动画片段配置")]
[USharpPath("/Script/b1-Managed.AnimationRestoreInfo")]
public struct AnimationRestoreInfo
{
	[EditAnywhere]
	[UProperty]
	[DisplayName("动画是否需要Restore")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimationRestoreInfo:RestoreState")]
	public bool RestoreState;

	private static int AnimationRestoreInfo_StructSize;

	private static int AnimationRestoreInfo_IsValid;

	private static bool RestoreState_IsValid;

	private static int RestoreState_Offset;

	private static FFieldAddress RestoreState_PropertyAddress;

	public AnimationRestoreInfo Copy()
	{
		return this;
	}

	public static AnimationRestoreInfo FromNative(IntPtr nativeBuffer)
	{
		return new AnimationRestoreInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, AnimationRestoreInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static AnimationRestoreInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new AnimationRestoreInfo(IntPtr.Add(nativeBuffer, arrayIndex * AnimationRestoreInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, AnimationRestoreInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimationRestoreInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimationRestoreInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimationRestoreInfo");
		}
		else
		{
			BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RestoreState_Offset), 0, RestoreState_PropertyAddress.Address, RestoreState);
		}
	}

	public AnimationRestoreInfo(IntPtr nativeStruct)
	{
		if (AnimationRestoreInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimationRestoreInfo");
			RestoreState = false;
		}
		else
		{
			RestoreState = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RestoreState_Offset), 0, RestoreState_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimationRestoreInfo");
		AnimationRestoreInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref RestoreState_PropertyAddress, intPtr, "RestoreState");
		RestoreState_Offset = NativeReflection.GetPropertyOffset(intPtr, "RestoreState");
		RestoreState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RestoreState", Classes.FBoolProperty);
		AnimationRestoreInfo_IsValid = ((intPtr != IntPtr.Zero && RestoreState_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimationRestoreInfo", (byte)AnimationRestoreInfo_IsValid != 0);
	}

	static AnimationRestoreInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AnimationRestoreInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AnimationRestoreInfo));
	}
}
