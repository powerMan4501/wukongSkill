using System;
using UnrealEngine.Runtime;

namespace b1.UI;

[UStruct]
[BlueprintType]
[DisplayName("动画片段配置")]
[USharpPath("/Script/b1-Managed.AnimationInfo")]
public struct AnimationInfo
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("动画名")]
	[USharpPath("/Script/b1-Managed.AnimationInfo:AnimationClipName")]
	public string AnimationClipName;

	[DisplayName("开始时间")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimationInfo:AnimationClipStartTime")]
	public float AnimationClipStartTime;

	[DisplayName("结束时间")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimationInfo:AnimationClipEndTime")]
	public float AnimationClipEndTime;

	[DisplayName("禁止输入")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimationInfo:DisableInputAtStart")]
	public bool DisableInputAtStart;

	private static int AnimationInfo_StructSize;

	private static int AnimationInfo_IsValid;

	private static bool AnimationClipName_IsValid;

	private static int AnimationClipName_Offset;

	private static bool AnimationClipStartTime_IsValid;

	private static int AnimationClipStartTime_Offset;

	private static bool AnimationClipEndTime_IsValid;

	private static int AnimationClipEndTime_Offset;

	private static bool DisableInputAtStart_IsValid;

	private static int DisableInputAtStart_Offset;

	private static FFieldAddress DisableInputAtStart_PropertyAddress;

	public AnimationInfo Copy()
	{
		return this;
	}

	public static AnimationInfo FromNative(IntPtr nativeBuffer)
	{
		return new AnimationInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, AnimationInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static AnimationInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new AnimationInfo(IntPtr.Add(nativeBuffer, arrayIndex * AnimationInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, AnimationInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimationInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimationInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimationInfo");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, AnimationClipName_Offset), AnimationClipName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AnimationClipStartTime_Offset), AnimationClipStartTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AnimationClipEndTime_Offset), AnimationClipEndTime);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DisableInputAtStart_Offset), 0, DisableInputAtStart_PropertyAddress.Address, DisableInputAtStart);
	}

	public AnimationInfo(IntPtr nativeStruct)
	{
		if (AnimationInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimationInfo");
			AnimationClipName = null;
			AnimationClipStartTime = 0f;
			AnimationClipEndTime = 0f;
			DisableInputAtStart = false;
		}
		else
		{
			AnimationClipName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, AnimationClipName_Offset));
			AnimationClipStartTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AnimationClipStartTime_Offset));
			AnimationClipEndTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AnimationClipEndTime_Offset));
			DisableInputAtStart = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DisableInputAtStart_Offset), 0, DisableInputAtStart_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimationInfo");
		AnimationInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		AnimationClipName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimationClipName");
		AnimationClipName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimationClipName", Classes.FStrProperty);
		AnimationClipStartTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimationClipStartTime");
		AnimationClipStartTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimationClipStartTime", Classes.FFloatProperty);
		AnimationClipEndTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimationClipEndTime");
		AnimationClipEndTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimationClipEndTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DisableInputAtStart_PropertyAddress, intPtr, "DisableInputAtStart");
		DisableInputAtStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisableInputAtStart");
		DisableInputAtStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisableInputAtStart", Classes.FBoolProperty);
		AnimationInfo_IsValid = ((intPtr != IntPtr.Zero && AnimationClipName_IsValid && AnimationClipStartTime_IsValid && AnimationClipEndTime_IsValid && DisableInputAtStart_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimationInfo", (byte)AnimationInfo_IsValid != 0);
	}

	static AnimationInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AnimationInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AnimationInfo));
	}
}
