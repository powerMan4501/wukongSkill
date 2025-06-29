using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Patrol")]
public struct FAnimHumanoidSetting_Patrol
{
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Patrol:AnimIdle")]
	public UAnimSequence AnimIdle;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Patrol:BSWalkFwd")]
	public UBlendSpace BSWalkFwd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Patrol:BSWalkBwd")]
	public UBlendSpace BSWalkBwd;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Patrol:BSWalkLeft")]
	public UBlendSpace BSWalkLeft;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Patrol:BSWalkRight")]
	public UBlendSpace BSWalkRight;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Patrol:BSRunFwd")]
	public UBlendSpace BSRunFwd;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Patrol:BSRunBwd")]
	public UBlendSpace BSRunBwd;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Patrol:BSRunLeft")]
	public UBlendSpace BSRunLeft;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Patrol:BSRunRight")]
	public UBlendSpace BSRunRight;

	private static int AnimHumanoidSetting_Patrol_StructSize;

	private static int AnimHumanoidSetting_Patrol_IsValid;

	private static bool AnimIdle_IsValid;

	private static int AnimIdle_Offset;

	private static bool BSWalkFwd_IsValid;

	private static int BSWalkFwd_Offset;

	private static bool BSWalkBwd_IsValid;

	private static int BSWalkBwd_Offset;

	private static bool BSWalkLeft_IsValid;

	private static int BSWalkLeft_Offset;

	private static bool BSWalkRight_IsValid;

	private static int BSWalkRight_Offset;

	private static bool BSRunFwd_IsValid;

	private static int BSRunFwd_Offset;

	private static bool BSRunBwd_IsValid;

	private static int BSRunBwd_Offset;

	private static bool BSRunLeft_IsValid;

	private static int BSRunLeft_Offset;

	private static bool BSRunRight_IsValid;

	private static int BSRunRight_Offset;

	public FAnimHumanoidSetting_Patrol Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_Patrol FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_Patrol(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_Patrol value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_Patrol FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_Patrol(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_Patrol_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_Patrol value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_Patrol_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_Patrol_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_Patrol");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimIdle_Offset), AnimIdle);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSWalkFwd_Offset), BSWalkFwd);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSWalkBwd_Offset), BSWalkBwd);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSWalkLeft_Offset), BSWalkLeft);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSWalkRight_Offset), BSWalkRight);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSRunFwd_Offset), BSRunFwd);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSRunBwd_Offset), BSRunBwd);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSRunLeft_Offset), BSRunLeft);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSRunRight_Offset), BSRunRight);
	}

	public FAnimHumanoidSetting_Patrol(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_Patrol_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_Patrol");
			AnimIdle = null;
			BSWalkFwd = null;
			BSWalkBwd = null;
			BSWalkLeft = null;
			BSWalkRight = null;
			BSRunFwd = null;
			BSRunBwd = null;
			BSRunLeft = null;
			BSRunRight = null;
		}
		else
		{
			AnimIdle = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimIdle_Offset));
			BSWalkFwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSWalkFwd_Offset));
			BSWalkBwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSWalkBwd_Offset));
			BSWalkLeft = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSWalkLeft_Offset));
			BSWalkRight = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSWalkRight_Offset));
			BSRunFwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSRunFwd_Offset));
			BSRunBwd = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSRunBwd_Offset));
			BSRunLeft = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSRunLeft_Offset));
			BSRunRight = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSRunRight_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_Patrol");
		AnimHumanoidSetting_Patrol_StructSize = NativeReflection.GetStructSize(intPtr);
		AnimIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimIdle");
		AnimIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimIdle", Classes.FObjectProperty);
		BSWalkFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSWalkFwd");
		BSWalkFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSWalkFwd", Classes.FObjectProperty);
		BSWalkBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSWalkBwd");
		BSWalkBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSWalkBwd", Classes.FObjectProperty);
		BSWalkLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSWalkLeft");
		BSWalkLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSWalkLeft", Classes.FObjectProperty);
		BSWalkRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSWalkRight");
		BSWalkRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSWalkRight", Classes.FObjectProperty);
		BSRunFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunFwd");
		BSRunFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunFwd", Classes.FObjectProperty);
		BSRunBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunBwd");
		BSRunBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunBwd", Classes.FObjectProperty);
		BSRunLeft_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunLeft");
		BSRunLeft_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunLeft", Classes.FObjectProperty);
		BSRunRight_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunRight");
		BSRunRight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunRight", Classes.FObjectProperty);
		AnimHumanoidSetting_Patrol_IsValid = ((intPtr != IntPtr.Zero && AnimIdle_IsValid && BSWalkFwd_IsValid && BSWalkBwd_IsValid && BSWalkLeft_IsValid && BSWalkRight_IsValid && BSRunFwd_IsValid && BSRunBwd_IsValid && BSRunLeft_IsValid && BSRunRight_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_Patrol", (byte)AnimHumanoidSetting_Patrol_IsValid != 0);
	}

	static FAnimHumanoidSetting_Patrol()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_Patrol)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_Patrol));
	}
}
