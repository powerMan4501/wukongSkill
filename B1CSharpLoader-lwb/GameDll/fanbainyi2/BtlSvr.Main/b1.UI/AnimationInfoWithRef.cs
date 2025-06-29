using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimationInfoWithRef")]
public struct AnimationInfoWithRef
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimationInfoWithRef:WidgetAnimationRef")]
	public UWidgetAnimation WidgetAnimationRef;

	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimationInfoWithRef:AnimInfo")]
	public AnimationInfo AnimInfo;

	private static int AnimationInfoWithRef_StructSize;

	private static int AnimationInfoWithRef_IsValid;

	private static bool WidgetAnimationRef_IsValid;

	private static int WidgetAnimationRef_Offset;

	private static bool AnimInfo_IsValid;

	private static int AnimInfo_Offset;

	public AnimationInfoWithRef Copy()
	{
		return this;
	}

	public static AnimationInfoWithRef FromNative(IntPtr nativeBuffer)
	{
		return new AnimationInfoWithRef(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, AnimationInfoWithRef value)
	{
		value.ToNative(nativeBuffer);
	}

	public static AnimationInfoWithRef FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new AnimationInfoWithRef(IntPtr.Add(nativeBuffer, arrayIndex * AnimationInfoWithRef_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, AnimationInfoWithRef value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimationInfoWithRef_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimationInfoWithRef_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimationInfoWithRef");
			return;
		}
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(nativeStruct, WidgetAnimationRef_Offset), WidgetAnimationRef);
		AnimationInfo.ToNative(IntPtr.Add(nativeStruct, AnimInfo_Offset), AnimInfo);
	}

	public AnimationInfoWithRef(IntPtr nativeStruct)
	{
		if (AnimationInfoWithRef_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimationInfoWithRef");
			WidgetAnimationRef = null;
			AnimInfo = default(AnimationInfo);
		}
		else
		{
			WidgetAnimationRef = UObjectMarshaler<UWidgetAnimation>.FromNative(IntPtr.Add(nativeStruct, WidgetAnimationRef_Offset));
			AnimInfo = AnimationInfo.FromNative(IntPtr.Add(nativeStruct, AnimInfo_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimationInfoWithRef");
		AnimationInfoWithRef_StructSize = NativeReflection.GetStructSize(intPtr);
		WidgetAnimationRef_Offset = NativeReflection.GetPropertyOffset(intPtr, "WidgetAnimationRef");
		WidgetAnimationRef_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WidgetAnimationRef", Classes.FObjectProperty);
		AnimInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimInfo");
		AnimInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimInfo", Classes.FStructProperty);
		AnimationInfoWithRef_IsValid = ((intPtr != IntPtr.Zero && WidgetAnimationRef_IsValid && AnimInfo_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimationInfoWithRef", (byte)AnimationInfoWithRef_IsValid != 0);
	}

	static AnimationInfoWithRef()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AnimationInfoWithRef)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AnimationInfoWithRef));
	}
}
