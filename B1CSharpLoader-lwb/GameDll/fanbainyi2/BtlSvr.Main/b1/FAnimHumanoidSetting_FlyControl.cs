using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_FlyControl")]
public struct FAnimHumanoidSetting_FlyControl
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_FlyControl:BSFly")]
	public UBlendSpace BSFly;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_FlyControl:ASFlyUpward")]
	public UAnimSequence ASFlyUpward;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_FlyControl:ASFlyDownward")]
	public UAnimSequence ASFlyDownward;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_FlyControl:ASFlyUpToDown")]
	public UAnimSequence ASFlyUpToDown;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_FlyControl:ASFlyDownToUp")]
	public UAnimSequence ASFlyDownToUp;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_FlyControl:BSFlyLean")]
	public UBlendSpace BSFlyLean;

	private static int AnimHumanoidSetting_FlyControl_StructSize;

	private static int AnimHumanoidSetting_FlyControl_IsValid;

	private static bool BSFly_IsValid;

	private static int BSFly_Offset;

	private static bool ASFlyUpward_IsValid;

	private static int ASFlyUpward_Offset;

	private static bool ASFlyDownward_IsValid;

	private static int ASFlyDownward_Offset;

	private static bool ASFlyUpToDown_IsValid;

	private static int ASFlyUpToDown_Offset;

	private static bool ASFlyDownToUp_IsValid;

	private static int ASFlyDownToUp_Offset;

	private static bool BSFlyLean_IsValid;

	private static int BSFlyLean_Offset;

	public FAnimHumanoidSetting_FlyControl Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_FlyControl FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_FlyControl(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_FlyControl value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_FlyControl FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_FlyControl(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_FlyControl_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_FlyControl value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_FlyControl_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_FlyControl_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_FlyControl");
			return;
		}
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSFly_Offset), BSFly);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFlyUpward_Offset), ASFlyUpward);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFlyDownward_Offset), ASFlyDownward);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFlyUpToDown_Offset), ASFlyUpToDown);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASFlyDownToUp_Offset), ASFlyDownToUp);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSFlyLean_Offset), BSFlyLean);
	}

	public FAnimHumanoidSetting_FlyControl(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_FlyControl_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_FlyControl");
			BSFly = null;
			ASFlyUpward = null;
			ASFlyDownward = null;
			ASFlyUpToDown = null;
			ASFlyDownToUp = null;
			BSFlyLean = null;
		}
		else
		{
			BSFly = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSFly_Offset));
			ASFlyUpward = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFlyUpward_Offset));
			ASFlyDownward = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFlyDownward_Offset));
			ASFlyUpToDown = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFlyUpToDown_Offset));
			ASFlyDownToUp = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASFlyDownToUp_Offset));
			BSFlyLean = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSFlyLean_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_FlyControl");
		AnimHumanoidSetting_FlyControl_StructSize = NativeReflection.GetStructSize(intPtr);
		BSFly_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSFly");
		BSFly_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSFly", Classes.FObjectProperty);
		ASFlyUpward_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFlyUpward");
		ASFlyUpward_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFlyUpward", Classes.FObjectProperty);
		ASFlyDownward_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFlyDownward");
		ASFlyDownward_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFlyDownward", Classes.FObjectProperty);
		ASFlyUpToDown_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFlyUpToDown");
		ASFlyUpToDown_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFlyUpToDown", Classes.FObjectProperty);
		ASFlyDownToUp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASFlyDownToUp");
		ASFlyDownToUp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASFlyDownToUp", Classes.FObjectProperty);
		BSFlyLean_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSFlyLean");
		BSFlyLean_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSFlyLean", Classes.FObjectProperty);
		AnimHumanoidSetting_FlyControl_IsValid = ((intPtr != IntPtr.Zero && BSFly_IsValid && ASFlyUpward_IsValid && ASFlyDownward_IsValid && ASFlyUpToDown_IsValid && ASFlyDownToUp_IsValid && BSFlyLean_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_FlyControl", (byte)AnimHumanoidSetting_FlyControl_IsValid != 0);
	}

	static FAnimHumanoidSetting_FlyControl()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_FlyControl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_FlyControl));
	}
}
