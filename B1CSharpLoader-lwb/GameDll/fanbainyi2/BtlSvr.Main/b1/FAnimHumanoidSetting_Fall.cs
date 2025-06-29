using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Fall")]
public struct FAnimHumanoidSetting_Fall
{
	[EditAnywhere]
	[UProperty]
	[DisplayName("下落Start动画")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Fall:AnimFallStart")]
	public UAnimSequence AnimFallStart;

	[EditAnywhere]
	[DisplayName("下落Loop动画")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Fall:AnimFallLoop")]
	public UAnimSequence AnimFallLoop;

	[UProperty]
	[BlueprintReadOnly]
	[DisplayName("着陆配置")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Fall:LandSetting")]
	public FAnimHumanoidSetting_Jump_Land LandSetting;

	private static int AnimHumanoidSetting_Fall_StructSize;

	private static int AnimHumanoidSetting_Fall_IsValid;

	private static bool AnimFallStart_IsValid;

	private static int AnimFallStart_Offset;

	private static bool AnimFallLoop_IsValid;

	private static int AnimFallLoop_Offset;

	private static bool LandSetting_IsValid;

	private static int LandSetting_Offset;

	public FAnimHumanoidSetting_Fall Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_Fall FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_Fall(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_Fall value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_Fall FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_Fall(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_Fall_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_Fall value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_Fall_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_Fall_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_Fall");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimFallStart_Offset), AnimFallStart);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimFallLoop_Offset), AnimFallLoop);
		FAnimHumanoidSetting_Jump_Land.ToNative(IntPtr.Add(nativeStruct, LandSetting_Offset), LandSetting);
	}

	public FAnimHumanoidSetting_Fall(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_Fall_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_Fall");
			AnimFallStart = null;
			AnimFallLoop = null;
			LandSetting = default(FAnimHumanoidSetting_Jump_Land);
		}
		else
		{
			AnimFallStart = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimFallStart_Offset));
			AnimFallLoop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimFallLoop_Offset));
			LandSetting = FAnimHumanoidSetting_Jump_Land.FromNative(IntPtr.Add(nativeStruct, LandSetting_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_Fall");
		AnimHumanoidSetting_Fall_StructSize = NativeReflection.GetStructSize(intPtr);
		AnimFallStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimFallStart");
		AnimFallStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimFallStart", Classes.FObjectProperty);
		AnimFallLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimFallLoop");
		AnimFallLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimFallLoop", Classes.FObjectProperty);
		LandSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "LandSetting");
		LandSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LandSetting", Classes.FStructProperty);
		AnimHumanoidSetting_Fall_IsValid = ((intPtr != IntPtr.Zero && AnimFallStart_IsValid && AnimFallLoop_IsValid && LandSetting_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_Fall", (byte)AnimHumanoidSetting_Fall_IsValid != 0);
	}

	static FAnimHumanoidSetting_Fall()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_Fall)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_Fall));
	}
}
